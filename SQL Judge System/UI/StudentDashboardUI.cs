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
                SubmissionResult result = SubmissionBL.ProcessAndGradeSubmission(student.StudentID, problemID, query, databaseName);

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