using MySqlX.XDevAPI;
using System.Text.RegularExpressions;
using SQL_Judge_System.BL;
using SQL_Judge_System.DL;
using SQL_Judge_System.LookupDL;
using SQL_Judge_System.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SQL_Judge_System.UI
{
    public partial class StudentDashboardUI : Form
    {
        private User user;
        private Student student;
        private string databaseName;
        private int? activeContestID = null;

        private readonly Color clrAccentPurple = Color.FromArgb(124, 111, 255);

        public StudentDashboardUI(int userId)
        {
            InitializeComponent();

            try
            {
                user = UserBL.GetUserById(userId);
                student = StudentBL.GetStudentByUserID(userId);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error while loading data: " + ex.Message);
            }

            VisiblePanel(pnlHome);

            this.Load += StudentDashboard_Load;
            LoadContests();
        }

        // =========================
        // Home Panel LOAD
        // =========================
        private void StudentDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                LoadLogo();
                LoadLeaderBoard();
                LoadStudentData();

                if (cmbDifficulty.Items.Count > 0)
                    cmbDifficulty.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void LoadLogo()
        {
            try
            {
                var bmp = new Bitmap(44, 44);
                using (var g = Graphics.FromImage(bmp))
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    g.Clear(Color.Transparent);

                    g.FillEllipse(new SolidBrush(clrAccentPurple), 0, 0, 43, 43);

                    g.DrawString(
                        "SJ",
                        new Font("Segoe UI", 13F, FontStyle.Bold),
                        Brushes.White,
                        new RectangleF(0, 0, 44, 44),
                        new StringFormat
                        {
                            Alignment = StringAlignment.Center,
                            LineAlignment = StringAlignment.Center
                        });
                }

                picLogo.Image = bmp;
            }
            catch { }
        }
        private void LoadLeaderBoard()
        {
            try
            {
                if (dgvLeaderboard == null) return;

                DataTable dt = StudentBL.GetLeaderboard();
                dgvLeaderboard.DataSource = dt;

                if (dt == null || dt.Columns.Count == 0) return;

                dgvLeaderboard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgvLeaderboard.Columns["StudentID"].Visible = false;

                SafeColumn("GlobalRank", "Global Rank", 50);
                SafeColumn("FullName", "Student Name", 150);
                SafeColumn("RegistrationNumber", "Reg No", 80);
                SafeColumn("LevelName", "Skill Level", 80);
                SafeColumn("ProblemsSolved", "Solved", 80);
                SafeColumn("TotalScore", "Score", 80);

                HighlightCurrentStudentRow();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void LoadStudentData()
        {
            try
            {
                if (student == null || user == null) return;

                lblWelcome.Text = $"Welcome, {user.FullName}!";

                lblRankValue.Text = $"#{StudentBL.GetRank(student.StudentID)}";
                lblSkillValue.Text = SkillLevelDL.GetSkillName(student.SkillLevelID);
                lblScoreValue.Text = student.TotalScore.ToString();
                lblSolvedValue.Text = student.ProblemsSolved.ToString();                   
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // =========================
        // HELPING FUNCTIONS
        // =========================
        private void SafeColumn(string col, string header, int weight)
        {
            if (dgvLeaderboard.Columns.Contains(col))
            {
                dgvLeaderboard.Columns[col].HeaderText = header;
                dgvLeaderboard.Columns[col].FillWeight = weight;
            }
        }
        private void VisiblePanel(Panel pnl)
        {
            pnlHome.Visible = false;
            pnlSolveProblem.Visible = false;
            pnlContest.Visible = false;

            pnl.Visible = true;
            pnl.BringToFront();
        }
        private void HighlightCurrentStudentRow()
        {
            if (student == null || dgvLeaderboard.Rows.Count == 0) return;

            foreach (DataGridViewRow row in dgvLeaderboard.Rows)
            {
                if (row.Cells["StudentID"]?.Value == null) continue;

                if (row.Cells["StudentID"].Value.ToString() == student.StudentID.ToString())
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(45, 40, 90);
                    row.DefaultCellStyle.ForeColor = clrAccentPurple;
                    row.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);

                    // Append (You) to the Name
                    var nameCell = row.Cells["FullName"];
                    if (nameCell.Value != null)
                    {
                        nameCell.Value = $"{nameCell.Value} (You)";
                    }

                    break;
                }
            }
        }

        // =========================
        // SOLVE PROBLEM PANEL
        // =========================
        private void cmbDifficulty_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Prevent error during initial loading
                if (cmbDifficulty.SelectedIndex == -1)
                    return;

                string difficultyName = cmbDifficulty.Text;

                if (difficultyName == "All")
                    LoadProblems(ProblemBL.GetAllProblems());
                else if (difficultyName == "Easy")
                    LoadProblems(ProblemBL.GetEasyProblems());
                else if (difficultyName == "Medium")
                    LoadProblems(ProblemBL.GetMediumProblems());
                else if (difficultyName == "Hard")
                    LoadProblems(ProblemBL.GetHardProblems());
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load problems.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void LoadProblems(DataTable dt)
        {
            try
            {
                dgvProblems.DataSource = dt;
                dgvProblems.Columns["ProblemID"].Visible = false;

                dgvProblems.Columns["Title"].FillWeight = 80;
                dgvProblems.Columns["DifficultyName"].FillWeight = 30;

                dgvProblems.Columns["Title"].HeaderText = "Title";
                dgvProblems.Columns["DifficultyName"].HeaderText = "Difficulty Level";
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to load problems. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvProblems_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvProblems.CurrentRow == null)
                    return;

                int problemID = Convert.ToInt32(dgvProblems.CurrentRow.Cells["ProblemID"].Value);
                string difficulty = dgvProblems.CurrentRow.Cells["DifficultyName"].Value.ToString();

                Problem p = ProblemBL.GetProblemByID(problemID);

                string title = p.Title;                
                string description = p.Description;
                this.databaseName = p.TargetDatabase;

                lblProblemName.Text = title;
                lblDifficultyBadge.Text = difficulty;
                rtbProblemDesc.Text = description;
            }
            catch
            {
                lblProblemName.Text = "Error Loading Problem";
                lblDifficultyBadge.Text = "";
                rtbProblemDesc.Text = "Unable to load description.";
            }
        }

        // Button Events
        private void btnRunQuery_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProblems.CurrentRow == null)
                {
                    MessageBox.Show("Please select a problem.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int problemID = Convert.ToInt32(dgvProblems.CurrentRow.Cells["ProblemID"].Value);

                string query = rtbSQLEditor.Text.Trim();
                if (string.IsNullOrWhiteSpace(query))
                {
                    MessageBox.Show("Please write an SQL query.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Map judge database names to dummy database names for local testing
                string targetDb = databaseName;
                if (targetDb.Equals("northwind_judge", StringComparison.OrdinalIgnoreCase))
                {
                    targetDb = "northwind_dummy";
                }
                else if (targetDb.Equals("jublinbikes_judge", StringComparison.OrdinalIgnoreCase))
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
                    dgvOutput.DataSource = null;
                    lblResultBadge.ForeColor = Color.FromArgb(62, 207, 142); // Green
                    lblResultBadge.Text = "Query executed successfully. No rows returned.";
                    return;
                }

                dgvOutput.DataSource = dt;
                lblResultBadge.ForeColor = Color.FromArgb(62, 207, 142); // green colour
                lblResultBadge.Text = $"Output generated • {dt.Rows.Count} rows";
            }
            catch (Exception ex)
            {
                dgvOutput.DataSource = null;
                lblResultBadge.ForeColor = Color.FromArgb(224, 90, 90);  // red colour
                lblResultBadge.Text = "SQL Error: " + ex.Message;
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProblems.CurrentRow == null)
                {
                    MessageBox.Show("Please select a problem.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }                

                string query = rtbSQLEditor.Text.Trim();
                if (string.IsNullOrWhiteSpace(query))
                {
                    MessageBox.Show("Please write an SQL query.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int problemID = Convert.ToInt32(dgvProblems.CurrentRow.Cells["ProblemID"].Value);

                // pass student ID, problem ID, the query text, and the target database name
                SubmissionResult result = SubmissionBL.ProcessAndGradeSubmission(student.StudentID, problemID, this.activeContestID, query, databaseName);

                // 3. Update UI Badges and Alerts based on execution results
                if (result.IsPassed)
                {
                    lblResultBadge.ForeColor = Color.FromArgb(62, 207, 142); // Green
                    lblResultBadge.Text = "Submission Accepted! Your query is correct.";
                    MessageBox.Show("Congratulations! Your submission is correct.", "Accepted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    lblResultBadge.ForeColor = Color.FromArgb(224, 90, 90); // Red

                    if (result.ErrorMessage.StartsWith("Runtime error"))
                    {
                        lblResultBadge.Text = "Runtime Error encountered during evaluation.";
                        MessageBox.Show(result.ErrorMessage, "Runtime Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        lblResultBadge.Text = "Submission Rejected. Query results mismatch.";
                        MessageBox.Show($"Your submission is incorrect.\n\nReason: {result.ErrorMessage}", "Rejected", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }    
        private void btnClearEditor_Click(object sender, EventArgs e)
        {
            rtbSQLEditor.Clear();

            rtbSQLEditor.Text = "-- Write your SQL query here \nSELECT ";
        }
        private void btnClearOutput_Click(object sender, EventArgs e)
        {
            dgvOutput.DataSource = null;

            lblResultBadge.Text = "";
        }
        private void rtbSQLEditor_KeyUp(object sender, KeyEventArgs e)
        {
            int index = rtbSQLEditor.SelectionStart;

            int line = rtbSQLEditor.GetLineFromCharIndex(index);

            int column = index - rtbSQLEditor.GetFirstCharIndexFromLine(line);

            lblLineCol.Text = $"Ln {line + 1}, Col {column + 1}";
        }

        // =========================
        // Contest Panel
        // =========================
        private void LoadContests()
        {
            try
            {
                DataTable dt = ContestBL.GetContests();
                LoadContest(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading contests: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadContest(DataTable dt)
        {
            dgvContest.DataSource = dt;

            if (dgvContest.Columns.Count > 0)
            {
                // Hide unneccessry columns safely
                string[] columnsToHide = { "ContestID", "Duration", "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" };
                foreach (string col in columnsToHide)
                {
                    if (dgvContest.Columns.Contains(col))
                        dgvContest.Columns[col].Visible = false;
                }

                dgvContest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                SafeColumn("Title", "Title", 100);
                SafeColumn("TotalParticipants", "Participants", 50);
                SafeColumn("StartDate", "Start Date", 50);
                SafeColumn("EndDate", "End Date", 50);
                SafeColumn("ContestStatus", "Status", 50);
            }
        }
        private void dgvContest_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvContest.CurrentRow == null || dgvContest.CurrentRow.Index < 0)
                return;

            try
            {
                int contestID = Convert.ToInt32(dgvContest.CurrentRow.Cells["ContestID"].Value);

                LoadContestDetails(contestID);
                LoadContestProblems(contestID);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error handling selection: {ex.Message}", "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            
        }
        private void LoadContestDetails(int contestID)
        {
            try
            {
                Contest contest = ContestBL.GetContestByID(contestID);

                if (contest != null)
                {
                    lblContestNameValue.Text = contest.Title;
                    lblStartDateValue.Text = contest.StartDate.ToString("g");
                    lblEndDateValue.Text = contest.EndDate.ToString("g");
                    txtDescription.Text = contest.Description;
                    lblContestDuration.Text = $"{contest.Duration} mins";
                    lblDurationValue.Text = $"{contest.Duration} mins";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading contest details: {ex.Message}", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadContestProblems(int contestID)
        {
            try
            {
                DataTable contestProblems = ProblemBL.GetContestProblems(contestID);
                dgvContestProblems.DataSource = contestProblems;
                dgvContestProblems.Columns["ProblemID"].Visible = false;

                SafeColumn("Title", "Title", 100);
                SafeColumn("DifficultyName", "Difficulty", 70);
                SafeColumn("Points", "Points", 50);

                if (contestProblems != null)
                {
                    object sumobj = contestProblems.Compute("Sum(Points)", "");
                    lblTotalPoints.Text = sumobj != DBNull.Value ? sumobj.ToString() : "0";
                    lblTotalProblems.Text = contestProblems.Rows.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading problems: {ex.Message}", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnJoinContest_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvContest.CurrentRow == null)
                {
                    MessageBox.Show("Please select a contest.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int contestID = Convert.ToInt32(dgvContest.CurrentRow.Cells["ContestID"].Value);

                // 1. Register the participant in the database
                ContestParticipant contestParticipant = new ContestParticipant(contestID, student.StudentID);
                ContestBL.AddContestParticipent(contestParticipant);

                // 2. Set the dashboard's active contest state tracking
                this.activeContestID = contestID;

                // 3. Load ONLY the contest problems into the existing problems DataGridView
                DataTable dtContestProblems = ProblemBL.GetContestProblems(contestID);
                LoadProblems(dtContestProblems);

                // 4. Update UI labels so the student knows they are competing
                lblProblemName.Text = "Select a Contest Problem to Begin";
                rtbProblemDesc.Text = "Welcome to the contest workspace! Select a problem from the left panel.";

                // 5. Shift focus smoothly to your existing execution workspace
                VisiblePanel(pnlSolveProblem);

                MessageBox.Show("You have successfully joined the contest! Your workspace has been configured.", "Contest Started", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An unexpected execution fault occurred: " + ex.Message,
                    "Database Engine Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void btnsearchContest_Click(object sender, EventArgs e)
        {
            try
            {
                string contestName = txtSearch.Text.Trim();

                // If search is empty, reload everything
                if (string.IsNullOrWhiteSpace(contestName) || contestName.StartsWith("Search contests here..."))
                {
                    LoadContests();
                    return;
                }

                DataTable dt = ContestBL.GetContestsByName(contestName);
                LoadContest(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"An error occurred while loading problems:\n\n{ex.Message}",
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =========================
        // NAVIGATION
        // =========================
        private void btn_home_Click(object sender, EventArgs e)
        {
            VisiblePanel(pnlHome);
        }
        private void btn_problems_Click(object sender, EventArgs e)
        {
            // Clear out active contest state because they clicked the public Practice menu
            this.activeContestID = null;

            // Reset difficulty dropdown combobox index to refresh the problem list grid
            if (cmbDifficulty.Items.Count > 0)
                cmbDifficulty.SelectedIndex = 0;
            else
                LoadProblems(ProblemBL.GetAllProblems());

            VisiblePanel(pnlSolveProblem);
        }
        private void btn_contest_Click(object sender, EventArgs e)
        {
            VisiblePanel(pnlContest);
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
        }
        private void btn_settings_Click(object sender, EventArgs e)
        {
            SettingsForm form = new SettingsForm(user.UserID);
            form.ShowDialog();
        }
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }
    }
}