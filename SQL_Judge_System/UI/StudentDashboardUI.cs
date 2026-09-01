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
using SQL_Judge_System.Helper;

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

                if (user == null || student == null)
                {
                    throw new Exception("Student or User profiling data records could not be initialized.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Critical authorization error while loading session parameters:\n{ex.Message}",
                                "Initialization Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

                DataTable dt = StudentBL.GetStudents();
                dgvLeaderboard.DataSource = dt;

                if (dt == null || dt.Columns.Count == 0) return;

                dgvLeaderboard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgvLeaderboard.Columns["StudentID"].Visible = false;
                dgvLeaderboard.Columns["UserID"].Visible = false;
                dgvLeaderboard.Columns["IsActive"].Visible = false;
                dgvLeaderboard.Columns["CreatedAt"].Visible = false;


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
        // NAVIGATION
        // =========================
        private void btn_home_Click(object sender, EventArgs e)
        {
            LoadLeaderBoard();
            LoadStudentData();
        }
        private void btn_problems_Click(object sender, EventArgs e)
        {
            try
            {
                if (student == null) return;
                SolveProblemUI form = new SolveProblemUI(student.StudentID);
                form.ShowDialog();

                // Synchronize data states immediately after workspace tasks exit
                LoadLeaderBoard();
                LoadStudentData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open Solve Problem screen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_contest_Click(object sender, EventArgs e)
        {
            try
            {
                if (student == null) return;
                JoinContestUI form = new JoinContestUI(student.StudentID);
                form.ShowDialog();

                // Re-evaluate core system states when coming back to dashboard limits
                LoadLeaderBoard();
                LoadStudentData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open Contest screen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            if (user == null) return;

            ReportForm form = new ReportForm(user.UserID);
            form.ShowDialog();

            // Re-sync dashboard user elements if details are modified in settings
            user = UserBL.GetUserById(user.UserID);
            LoadStudentData();
        }
        private void btn_settings_Click(object sender, EventArgs e)
        {
            if (user == null) return;

            SettingsForm form = new SettingsForm(user.UserID);
            form.ShowDialog();

            // Re-sync dashboard user elements if details are modified in settings
            user = UserBL.GetUserById(user.UserID);
            LoadStudentData();
        }
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }
    }
}