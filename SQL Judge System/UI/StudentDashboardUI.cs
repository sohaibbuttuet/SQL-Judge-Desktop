using MySqlX.XDevAPI;
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
        private void LoadAllowedSchemaTree(string databaseName, int problemID)
        {
            tvSchema.Nodes.Clear();
            TreeNode rootNode = new TreeNode(databaseName);

            try
            {
                // Get the list of tables assigned to this specific problem
                List<ProblemTable> allowedTables = ProblemBL.GetSchemaByProblemID(problemID);

                foreach (var table in allowedTables)
                {
                    TreeNode tableNode = new TreeNode(table.TableName);

                    // Fetch columns to show under each table node
                    List<string> columns = SchemaDL.GetColumnsOfTable(databaseName, table.TableName);
                    foreach (string colName in columns)
                    {
                        tableNode.Nodes.Add(new TreeNode(colName));
                    }

                    rootNode.Nodes.Add(tableNode);
                }

                tvSchema.Nodes.Add(rootNode);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not load schema tree blueprint mapping: {ex.Message}", "Schema Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dgvProblems_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvProblems.CurrentRow == null)
                    return;

                int problemID = Convert.ToInt32(dgvProblems.CurrentRow.Cells["ProblemID"].Value);
                string title = dgvProblems.CurrentRow.Cells["Title"].Value.ToString();
                string difficulty = dgvProblems.CurrentRow.Cells["DifficultyName"].Value.ToString();
                string description = ProblemBL.GetDescriptionByID(problemID);
                //string databaseName = ProblemBL.GetDatabaseName(problemID);

                lblProblemName.Text = title;
                lblDifficultyBadge.Text = difficulty;
                rtbProblemDesc.Text = description;

                // Load the allowed schema tree for this problem
                LoadAllowedSchemaTree("SQL_Judge_DB", problemID);
            }
            catch
            {
                lblProblemName.Text = "Error Loading Problem";
                lblDifficultyBadge.Text = "";
                rtbProblemDesc.Text = "Unable to load description.";
            }
        }

        // =========================
        // Button Events
        // =========================
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

                // This will throw an exception if the query is invalid or contains disallowed statements
                query = QueryRunnerBL.CleanAndValidateQuery(query); 

                //DataTable dt = QueryRunnerBL.GetOutput(problemID, query);

                //dgvOutput.DataSource = dt;

                //lblResultBadge.ForeColor = Color.FromArgb(62, 207, 142); // green colour
                //lblResultBadge.Text = $"Output generated • {dt.Rows.Count} rows";
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
                int problemID = Convert.ToInt32(dgvProblems.CurrentRow.Cells["ProblemID"].Value);

                string query = rtbSQLEditor.Text.Trim();
                if (string.IsNullOrWhiteSpace(query))
                {
                    MessageBox.Show("Please write an SQL query.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create submission object with pending evaluation status
                int pendingStatusID = SubmissionStatusDL.GetPending();
                Submission submission = new Submission(student.StudentID, problemID, query, pendingStatusID);

                SubmissionBL.CreateSubmission(submission);


                //if (passedCases == totalCases)
                //{
                //    MessageBox.Show("🎉 Success! All test cases cleared. Your solution has been Accepted!",
                //        "Submission Accepted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else
                //{
                //    // Extract details from the very first failing scenario to guide the student's debugging
                //    SubmissionResult firstFailure = results.FirstOrDefault(r => !r.IsPassed);
                //    string failFeedback = firstFailure?.ErrorMessage ?? "Output formatting variance discovered.";

                //    MessageBox.Show(headingSummary + $"❌ Status: Rejected\n\nReason for Failure:\n{failFeedback}",
                //        "Submission Rejected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
            }
            catch (ArgumentException argEx)
            {
                // Catches syntax validation blocks (e.g., trying to write an UPDATE statement or empty strings)
                MessageBox.Show(argEx.Message, "SQL Policy Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"System execution tracking fault: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            dgvOutput.Rows.Clear();
            dgvOutput.Columns.Clear();

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
        // NAVIGATION
        // =========================
        private void btn_home_Click(object sender, EventArgs e)
        {
            VisiblePanel(pnlHome);
        }
        private void btn_problems_Click(object sender, EventArgs e)
        {
            VisiblePanel(pnlSolveProblem);
        }
        private void btn_contest_Click(object sender, EventArgs e)
        {
            // Update this line inside your original btnSubmit_Click method workspace:
            int problemID;
            if (dgvProblems.CurrentRow != null)
            {
                problemID = Convert.ToInt32(dgvProblems.CurrentRow.Cells["ProblemID"].Value);
            }
            else if (dgvProblems.Tag != null) // Fallback used when loaded from the contest workspace
            {
                problemID = Convert.ToInt32(dgvProblems.Tag);
            }
            else
            {
                MessageBox.Show("Please select a problem statement workspace focus context.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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