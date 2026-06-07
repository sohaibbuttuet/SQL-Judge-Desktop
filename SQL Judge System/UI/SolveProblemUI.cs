using SQL_Judge_System.BL;
using SQL_Judge_System.DL;
using SQL_Judge_System.LookupDL;
using SQL_Judge_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQL_Judge_System.Helper;

namespace SQL_Judge_System.UI
{
    public partial class SolveProblemUI : Form
    {
        private int? activeContestID = null;
        private int studentID;
        private int problemID;
        private string databaseName;
        private DataTable dtAllProblems;
        private int cooldownSecondsRemaining = 0;

        // Contest timing components
        private DateTime? contestEndTime = null;
        private Timer contestCountdownTimer = null;

        // Constructor 1: Open Practice Mode
        public SolveProblemUI(int studentID)
        {
            InitializeComponent();
            this.studentID = studentID;
            this.activeContestID = null;

            // HIDE the countdown label during practice mode
            if (this.lblTimeRemainingValue != null)
            {
                this.pnlInfoTimeRemaining.Visible = false;
            }

            InitializeFormPipeline();
        }

        // Constructor 2: Active Contest Workspace Mode
        public SolveProblemUI(int studentID, int contestID, DateTime endTime)
        {
            InitializeComponent();

            this.studentID = studentID;
            this.activeContestID = contestID;
            this.contestEndTime = endTime;

            // SHOW the countdown panel during contest mode
            if (this.lblTimeRemainingValue != null)
            {
                this.pnlInfoTimeRemaining.Visible = true;
            }

            pnlStatLastResult.Visible = false;
            pnlStatAttempts.Visible = false;

            InitializeFormPipeline();
            InitializeContestCountdown();
        }

        private void InitializeFormPipeline()
        {
            try
            {
                // Temporarily detach selection handler during structural backend load to avoid null parsing exceptions
                dgvProblems.SelectionChanged -= dgvProblems_SelectionChanged;

                if (activeContestID.HasValue)
                {
                    dtAllProblems = ProblemBL.GetContestProblems(activeContestID.Value);
                }
                else
                {
                    dtAllProblems = ProblemBL.GetAllProblems();
                }

                LoadProblems(dtAllProblems);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Initialization Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dgvProblems.SelectionChanged += dgvProblems_SelectionChanged;

                // Trigger selection parsing explicitly for the initial row post-load
                if (dgvProblems.Rows.Count > 0)
                {
                    dgvProblems_SelectionChanged(this, EventArgs.Empty);
                }
            }
        }
        private void InitializeContestCountdown()
        {
            if (!this.contestEndTime.HasValue) return;

            contestCountdownTimer = new Timer { Interval = 1000 }; // 1000 = 1 second
            contestCountdownTimer.Tick += ContestCountdownTimer_Tick;
            contestCountdownTimer.Start();

            // 1. Calculate the initial time span
            TimeSpan timeRemaining = contestEndTime.Value - DateTime.Now;

            // 2. Assign the initial value directly to the label text safely
            if (this.lblTimeRemainingValue != null)
            {
                this.lblTimeRemainingValue.Text = timeRemaining.ToString(@"hh\:mm\:ss");
            }

            // Run an immediate tick call to prevent a 1-second visual layout delay
            ContestCountdownTimer_Tick(this, EventArgs.Empty);
        }
        private void ContestCountdownTimer_Tick(object sender, EventArgs e)
        {
            if (!contestEndTime.HasValue) return;

            TimeSpan timeRemaining = contestEndTime.Value - DateTime.Now;

            if (timeRemaining.TotalSeconds <= 0)
            {
                contestCountdownTimer.Stop();

                // ---- AUTOMATICALLY SAVE THE QUERY ON TIMEOUT ----
                AutoSaveCurrentQuery();

                txtSqlEditor.Enabled = false;
                btnRunQuery.Enabled = false;
                btnSubmitSolution.Enabled = false;

                MessageBox.Show("The contest duration limit has expired! Submissions are locked.\n\nYour current query draft inside the editor will be automatically submitted as your final contest response.", "Contest Ended", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                this.Text = $"SQL Problem Solver — TIME REMAINING: {timeRemaining.ToString(@"hh\:mm\:ss")}";

                // Give the value to your UI label control every single second here:
                if (this.lblTimeRemainingValue != null)
                {
                    this.lblTimeRemainingValue.Text = timeRemaining.ToString(@"hh\:mm\:ss");
                }
            }
        }
        private void submitCooldownTimer_Tick(object sender, EventArgs e)
        {
            cooldownSecondsRemaining--;

            if (cooldownSecondsRemaining <= 0)
            {
                submitCooldownTimer.Stop();
                btnSubmitSolution.Enabled = true;
                btnSubmitSolution.Text = "Submit Solution";
            }
            else
            {
                btnSubmitSolution.Text = $"Wait ({cooldownSecondsRemaining}s)";
            }
        }
        private void AutoSaveCurrentQuery()
        {
            try
            {
                // Check if a problem is loaded and code exists
                if (this.problemID <= 0 || string.IsNullOrWhiteSpace(txtSqlEditor.Text))
                    return;

                string query = txtSqlEditor.Text.Trim();

                // Optional default text check (skip saving if student didn't write anything new)
                if (query.StartsWith("-- Write your SQL query here"))
                    return;

                // Save the code directly to the database via Business Logic layer
                // This logs it under the active contest context so instructors can view the final snapshot
                SubmissionBL.ProcessAndGradeSubmission(studentID, this.problemID, this.activeContestID, query, this.databaseName);
            }
            catch (Exception)
            {
                // Silent catch during automated time outs to prevent system crash windows 
                // from disrupting the form closing process sequence.
            }

        }

        // ===== Filtering Logic =====
        private void ApplyProblemFilters()
        {
            if (dtAllProblems == null) return;

            try
            {
                // Unbind to avoid infinite triggering loops
                dgvProblems.SelectionChanged -= dgvProblems_SelectionChanged;

                List<string> expressions = new List<string>();

                // 1. Evaluate Difficulty Dropdown Rule
                if (cmbDifficultyFilter.SelectedIndex != -1)
                {
                    string difficultyName = cmbDifficultyFilter.Text;
                    if (difficultyName != "All" && !string.IsNullOrWhiteSpace(difficultyName))
                    {
                        expressions.Add($"DifficultyName = '{difficultyName.Replace("'", "''")}'");
                    }
                }

                // 2. Evaluate Text Search Bar Rule
                string searchKeyword = txtProblemSearch.Text.Trim();
                if (!string.IsNullOrWhiteSpace(searchKeyword) &&
                    !searchKeyword.StartsWith("Search problems...", StringComparison.OrdinalIgnoreCase))
                {
                    expressions.Add($"Title LIKE '%{searchKeyword.Replace("'", "''")}%'");
                }

                // 3. Build and Apply DataView Engine
                DataView dv = new DataView(dtAllProblems);
                if (expressions.Count > 0)
                {
                    dv.RowFilter = string.Join(" AND ", expressions);
                }
                else
                {
                    dv.RowFilter = "";
                }

                LoadProblems(dv.ToTable());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Filtering execution failed:\n\n{ex.Message}", "Workspace Filter Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                // Safely re-subscribe
                dgvProblems.SelectionChanged += dgvProblems_SelectionChanged;

                if (dgvProblems.Rows.Count > 0)
                {
                    dgvProblems_SelectionChanged(this, EventArgs.Empty);
                }
            }
        }
        private void cmbDifficulty_SelectedIndexChanged(object sender, EventArgs e) => ApplyProblemFilters();
        private void txtProblemSearch_TextChanged(object sender, EventArgs e) => ApplyProblemFilters();

        // ===== UI Grid Layout Load =====
        private void LoadProblems(DataTable dt)
        {
            try
            {
                dgvProblems.DataSource = dt;
                dgvProblems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                if (dgvProblems.Columns.Contains("ProblemID"))
                    dgvProblems.Columns["ProblemID"].Visible = false;

                SafeColumn(dgvProblems, "Title", "Title", 80);
                SafeColumn(dgvProblems, "DifficultyName", "Difficulty", 50);
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to load problems into the table grid view.", "UI Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===== Selection Changed Events =====
        private void dgvProblems_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvProblems.CurrentRow == null || dgvProblems.CurrentRow.Index < 0)
                    return;

                this.problemID = Convert.ToInt32(dgvProblems.CurrentRow.Cells["ProblemID"].Value);
                string difficulty = dgvProblems.CurrentRow.Cells["DifficultyName"].Value.ToString();

                Problem p = ProblemBL.GetProblemByID(this.problemID);
                if (p == null) return;

                // Sync data fields securely to presentation UI containers
                lblProblemTitle.Text = p.Title;
                lblDifficultyValue.Text = difficulty;
                txtProblemDescription.Text = p.Description;
                lblPointsValue.Text = p.Points.ToString();
                this.databaseName = p.TargetDatabase;

                RefreshProblemStats(this.problemID);
                LoadTreeView();
            }
            catch (Exception)
            {
                lblProblemTitle.Text = "Error Loading Problem";
                lblDifficultyValue.Text = "";
                txtProblemDescription.Text = "Unable to load problem metrics from backend servers.";
            }
        }

        // ===== Real-Time Statistics Handler =====
        private void RefreshProblemStats(int targetProblemID)
        {
            try
            {
                // Fetch up-to-date indicators from underlying execution pipelines
                lblAttemptsValue.Text = SubmissionBL.AttemptNumber(studentID, targetProblemID).ToString();

                string result = SubmissionStatusDL.StatusOfLastSubmission(studentID, targetProblemID);
                lblLastResultValue.Text = string.IsNullOrEmpty(result) ? "No Submissions" : result;

                // Adjust textual badges dynamically based on outcomes
                if (result == "Accepted")
                {
                    lblSubmissionStatus.Text = "Solved";
                    lblSubmissionStatus.ForeColor = Color.Green;
                }
                else if (!string.IsNullOrEmpty(result))
                {
                    lblSubmissionStatus.Text = "Attempted";
                    lblSubmissionStatus.ForeColor = Color.Orange;
                }
                else
                {
                    lblSubmissionStatus.Text = "Unattempted";
                    lblSubmissionStatus.ForeColor = Color.Gray;
                }
            }
            catch (Exception)
            {
                lblAttemptsValue.Text = "-";
                lblLastResultValue.Text = "Error updating telemetry";
                lblSubmissionStatus.Text = "Unknown";
            }
        }

        // Load Tree View
        private void LoadTreeView()
        {
            try
            {
                // 1. Clear the TreeView completely
                trvDatabaseSchema.BeginUpdate();
                trvDatabaseSchema.Nodes.Clear();

                if (string.IsNullOrWhiteSpace(this.databaseName) || this.problemID <= 0)
                {
                    trvDatabaseSchema.Nodes.Clear();
                    return;
                }

                List<ProblemTable> allowedTables = ProblemBL.GetSelectedTablesByProblemID(problemID);
                List<string> allowedTableNames = allowedTables.Select(t => t.TableName).ToList();

                if (allowedTableNames.Count == 0) return;

                DataTable schemaTable = SchemaDL.GetSelectedSchema(this.databaseName, allowedTableNames);

                TreeNode currentTableNode = null;
                string lastTableName = string.Empty;

                // 2. Loop through the rows and add tables directly to the TreeView root
                foreach (DataRow row in schemaTable.Rows)
                {
                    string tableName = row["TABLE_NAME"].ToString();
                    string columnName = row["COLUMN_NAME"].ToString();
                    string dataType = row["DATA_TYPE"].ToString();

                    // When the table name changes, create a new root-level table node
                    if (tableName != lastTableName)
                    {
                        currentTableNode = new TreeNode(tableName);
                        trvDatabaseSchema.Nodes.Add(currentTableNode);
                        lastTableName = tableName;
                    }

                    // Append columns directly underneath the table node
                    currentTableNode?.Nodes.Add(new TreeNode($"{columnName} ({dataType})"));
                }

                // 3. Expand all table nodes so students see the columns immediately
                trvDatabaseSchema.ExpandAll();
                trvDatabaseSchema.EndUpdate();
            }
            catch (Exception ex)
            {
                trvDatabaseSchema.EndUpdate();
                MessageBox.Show($"Failed to build schema tree: {ex.Message}", "Schema Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                trvDatabaseSchema.EndUpdate();
            }
        }

        // Button Events
        private void btnRunQuery_Click(object sender, EventArgs e)
        {
            if (contestEndTime.HasValue && DateTime.Now > contestEndTime.Value)
            {
                MessageBox.Show("Action denied: The active contest has ended.", "Time Expired", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            try
            {
                if (dgvProblems.CurrentRow == null || this.problemID <= 0)
                {
                    MessageBox.Show("Please select a problem.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = txtSqlEditor.Text.Trim();
                if (string.IsNullOrWhiteSpace(query))
                {
                    MessageBox.Show("Please write an SQL query.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(this.databaseName))
                {
                    MessageBox.Show("Cannot run query: No target database is assigned to this problem.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Map judge database names to dummy database names for local testing
                string targetDb = this.databaseName;
                if (string.Equals(targetDb, "northwind_judge", StringComparison.OrdinalIgnoreCase))
                {
                    targetDb = "northwind_dummy";
                }
                else if (string.Equals(targetDb, "jublinbikes_judge", StringComparison.OrdinalIgnoreCase))
                {
                    targetDb = "jublinbikes_dummy";
                }

                // Get the list of allowed tables for this problem
                List<ProblemTable> allowedTables = ProblemBL.GetSelectedTablesByProblemID(problemID);
                List<string> allowedTableNames = allowedTables.Select(t => t.TableName).ToList();

                // Validate and execute the query, then display results
                DataTable dt = QueryRunnerBL.ExecuteQuery(targetDb, query, allowedTableNames);

                if (dt == null || dt.Rows.Count == 0)
                {
                    dgvQueryOutput.DataSource = null;
                    txtMessages.ForeColor = Color.FromArgb(62, 207, 142);
                    txtMessages.Text = "Query executed successfully. No rows returned.";
                    return;
                }

                dgvQueryOutput.DataSource = dt;
                txtMessages.ForeColor = Color.FromArgb(62, 207, 142); // green colour
                txtMessages.Text = $"Output generated • {dt.Rows.Count} rows";
            }
            catch (Exception ex)
            {
                dgvQueryOutput.DataSource = null;
                txtMessages.ForeColor = Color.FromArgb(224, 90, 90);  // red colour
                txtMessages.Text = "SQL Error: " + ex.Message;
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (contestEndTime.HasValue && DateTime.Now > contestEndTime.Value)
            {
                MessageBox.Show("Action denied: The active contest has ended.", "Time Expired", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            // Lock down the UI button instantly to stop double clicks
            btnSubmitSolution.Enabled = false;
            btnSubmitSolution.Text = "Grading...";

            try
            {
                if (dgvProblems.CurrentRow == null || this.problemID <= 0)
                {
                    MessageBox.Show("Please select a problem.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = txtSqlEditor.Text.Trim();
                if (string.IsNullOrWhiteSpace(query))
                {
                    MessageBox.Show("Please write an SQL query.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Pass student context values down directly to the core grading engines
                SubmissionResult result = SubmissionBL.ProcessAndGradeSubmission(studentID, this.problemID, this.activeContestID, query, databaseName);

                RefreshProblemStats(this.problemID);

                // The submission was successfully created and logged in the database by this point.
                // Now we simply display the evaluation verdict cleanly to the student:

                if (result.IsPassed)
                {
                    // 1. Correct Answer Variant
                    txtMessages.ForeColor = Color.FromArgb(62, 207, 142); // Green Accent
                    txtMessages.Text = "Submission Processed: Verdict [ACCEPTED]";

                    MessageBox.Show(
                        "Your submission has been received and verified.\n\nVerdict: Correct Answer!",
                        "Submission Status",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    txtMessages.ForeColor = Color.FromArgb(224, 90, 90); // Red Accent

                    if (result.ErrorMessage != null && result.ErrorMessage.StartsWith("Runtime error", StringComparison.OrdinalIgnoreCase))
                    {
                        // 2. Syntax/SQL Execution Error Variant
                        txtMessages.Text = "Submission Processed: Verdict [RUNTIME ERROR]";

                        MessageBox.Show(
                            $"Your submission has been recorded.\n\nVerdict: Runtime Error!\nDetails: {result.ErrorMessage}",
                            "Submission Status",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning // Warning icon instead of Error to indicate a code bug, not a app crash
                        );
                    }
                    else
                    {
                        // 3. Data Mismatch Variant
                        txtMessages.Text = "Submission Processed: Verdict [WRONG ANSWER]";

                        MessageBox.Show(
                            $"Your submission has been recorded.\n\nVerdict: Wrong Answer!\nReason: {result.ErrorMessage}",
                            "Submission Status",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                    }
                }
            }
            catch (ArgumentException argEx)
            {
                // Catches syntax validation blocks (e.g., trying to write an UPDATE statement, blocked tables)
                MessageBox.Show(argEx.Message, "SQL Policy Violation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"System execution tracking fault: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Start the mandatory 5 seconds cooling-off system
                cooldownSecondsRemaining = 5;
                btnSubmitSolution.Text = $"Wait ({cooldownSecondsRemaining}s)";

                submitCooldownTimer.Start();
            }
        }
        private void btnClearEditor_Click(object sender, EventArgs e)
        {
            txtSqlEditor.Clear();

            txtSqlEditor.Text = "-- Write your SQL query here \nSELECT ";
        }
        private void rtbSQLEditor_KeyUp(object sender, KeyEventArgs e)
        {
            int index = txtSqlEditor.SelectionStart;

            int line = txtSqlEditor.GetLineFromCharIndex(index);

            int column = index - txtSqlEditor.GetFirstCharIndexFromLine(line);

            lblLineCol.Text = $"Ln {line + 1}, Col {column + 1}";
        }
        private void SafeColumn(DataGridView dgv, string col, string header, int weight)
        {
            if (dgv.Columns.Contains(col))
            {
                dgv.Columns[col].HeaderText = header;
                dgv.Columns[col].FillWeight = weight;
            }
        }      
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // 1. Check if the user manually tried to close the window via 'X' or Alt+F4
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Guard check: Only prompt if the countdown timer hasn't already expired and stopped itself
                if (contestCountdownTimer == null || contestCountdownTimer.Enabled)
                {
                    DialogResult result;

                    // Scenario A: The student is in an active contest
                    if (activeContestID.HasValue && activeContestID.Value > 0)
                    {
                        result = MessageBox.Show(
                            "Are you sure you want to exit the contest workspace?\n\nYour current query draft inside the editor will be automatically submitted as your final contest response.",
                            "Confirm Contest Exit",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning
                        );

                        // If they confirm they want to leave the contest, automatically save their work right now
                        if (result == DialogResult.Yes)
                        {
                            AutoSaveCurrentQuery();
                        }
                    }
                    // Scenario B: The student is just solving a casual practice problem
                    else
                    {
                        result = MessageBox.Show(
                            "Are you sure you want to exit the problem solver? Your unsaved editor modifications will be lost.",
                            "Confirm Exit",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                        );
                    }

                    // Common Logic: If the user clicks 'No', cancel the form closing sequence
                    if (result == DialogResult.No)
                    {
                        e.Cancel = true;
                        return; // Exit early to keep the workspace and timers running smoothly
                    }
                }
            }

            // 2. Perform background cleanup safely since the form is definitely closing
            if (contestCountdownTimer != null)
            {
                contestCountdownTimer.Stop();
                contestCountdownTimer.Dispose();
            }

            if (submitCooldownTimer != null)
            {
                submitCooldownTimer.Stop();
                submitCooldownTimer.Dispose();
            }

            base.OnFormClosing(e);
        }
    }
}