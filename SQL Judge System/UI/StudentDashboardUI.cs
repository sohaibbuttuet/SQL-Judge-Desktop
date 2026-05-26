using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using SQL_Judge_System.BL;
using SQL_Judge_System.DL;
using SQL_Judge_System.Models;

namespace SQL_Judge_System.UI
{
    public partial class StudentDashboardUI : Form
    {
        User user = null;
        Student student = null;

        // ── Theme colors (reused for active nav state) ──────────────────────
        private readonly Color clrSidebar = Color.FromArgb(24, 29, 56);
        private readonly Color clrHover = Color.FromArgb(35, 40, 69);
        private readonly Color clrAccentPurple = Color.FromArgb(124, 111, 255);
        private readonly Color clrTextMuted = Color.FromArgb(139, 146, 184);
        private readonly Color clrLogout = Color.FromArgb(224, 90, 90);

        public StudentDashboardUI(int userId)
        {
            user = UserBL.GetUserById(userId);
            student = StudentBL.GetStudentByUserID(userId);
            InitializeComponent();
        }

        private void StudentDashboard_Load(object sender, EventArgs e)
        {
            LoadLogo();
            SetActiveNavButton(btn_home);
            LoadLeaderBoard();
            LoadStudentData();
        }
        private void LoadLogo()
        {
            try
            {
                // Option A — if you have a logo file in your project Resources:
                // picLogo.Image = Properties.Resources.logo;

                // Option B — load from a file path:
                // picLogo.Image = System.Drawing.Image.FromFile(
                //     System.IO.Path.Combine(Application.StartupPath, "logo.png"));

                // Option C — draw a simple SQL Judge icon programmatically (no file needed):
                var bmp = new System.Drawing.Bitmap(44, 44);
                using (var g = System.Drawing.Graphics.FromImage(bmp))
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    g.Clear(System.Drawing.Color.Transparent);

                    // Outer circle
                    g.FillEllipse(
                        new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(124, 111, 255)),
                        0, 0, 43, 43);

                    // "SJ" text
                    g.DrawString(
                        "SJ",
                        new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold),
                        System.Drawing.Brushes.White,
                        new System.Drawing.RectangleF(0, 0, 44, 44),
                        new System.Drawing.StringFormat
                        {
                            Alignment = System.Drawing.StringAlignment.Center,
                            LineAlignment = System.Drawing.StringAlignment.Center
                        });
                }
                picLogo.Image = bmp;
            }
            catch { /* logo is optional — fail silently */ }
        }
 
        // Resets all nav buttons to default muted style, then highlights the active one.
        private void SetActiveNavButton(FontAwesome.Sharp.IconButton activeBtn)
        {
            FontAwesome.Sharp.IconButton[] navButtons =
            {
                btn_home, btn_problems, btn_contest, btnReport
            };

            foreach (var btn in navButtons)
            {
                btn.BackColor = clrSidebar;
                btn.ForeColor = clrTextMuted;
                btn.IconColor = clrTextMuted;
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.BorderColor = clrSidebar;
                btn.FlatAppearance.MouseOverBackColor = clrHover;
            }

            // Active state: purple left-border effect via BackColor + ForeColor
            activeBtn.BackColor = clrHover;
            activeBtn.ForeColor = clrAccentPurple;
            activeBtn.IconColor = clrAccentPurple;
            // Simulate a left border by painting it in the Paint event
            activeBtn.Tag = "active";
        }

        // --- Data Loading ---

        private void LoadLeaderBoard()
        {
            dgvLeaderboard.DataSource = StudentLeaderboardBL.GetLeaderboard();

            dgvLeaderboard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvLeaderboard.Columns["GlobalRank"].FillWeight = 50;
            dgvLeaderboard.Columns["StudentID"].FillWeight = 50;
            dgvLeaderboard.Columns["FullName"].FillWeight = 150;
            dgvLeaderboard.Columns["RegistrationNumber"].FillWeight = 80;
            dgvLeaderboard.Columns["LevelName"].FillWeight = 80;
            dgvLeaderboard.Columns["ProblemsSolved"].FillWeight = 80;
            dgvLeaderboard.Columns["TotalScore"].FillWeight = 80;

            dgvLeaderboard.Columns["GlobalRank"].HeaderText = "Global Rank";
            dgvLeaderboard.Columns["StudentID"].HeaderText = "Student ID";
            dgvLeaderboard.Columns["FullName"].HeaderText = "Student Name";
            dgvLeaderboard.Columns["RegistrationNumber"].HeaderText = "Reg No";
            dgvLeaderboard.Columns["LevelName"].HeaderText = "Skill Level";
            dgvLeaderboard.Columns["ProblemsSolved"].HeaderText = "Problems Solved";
            dgvLeaderboard.Columns["TotalScore"].HeaderText = "Total Score";

            HighlightCurrentStudentRow();
        }

        // Highlights the logged-in student's row in the leaderboard with the purple accent.
        private void HighlightCurrentStudentRow()
        {
            if (student == null) return;

            foreach (DataGridViewRow row in dgvLeaderboard.Rows)
            {
                if (row.Cells["StudentID"].Value != null &&
                    row.Cells["StudentID"].Value.ToString() == student.StudentID.ToString())
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(45, 40, 90);
                    row.DefaultCellStyle.ForeColor = clrAccentPurple;
                    row.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                    row.DefaultCellStyle.SelectionBackColor = Color.FromArgb(55, 50, 110);
                    row.DefaultCellStyle.SelectionForeColor = clrAccentPurple;
                    break;
                }
            }
        }

        private void LoadStudentData()
        {
            if (student != null)
            {
                lblWelcome.Text = $"Welcome, {user.FullName}!";
                lblRankValue.Text = $"#{StudentLeaderboardBL.GetRank(student.StudentID)}";
                lblScoreValue.Text = StudentLeaderboardBL.GetTotalScore(student.StudentID).ToString();
                lblSkillValue.Text = StudentLeaderboardBL.GetSkillLevel(student.StudentID).ToString();
                lblSolvedValue.Text = StudentLeaderboardBL.GetSolvedProblemsCount(student.StudentID).ToString();
            }
            else
            {
                MessageBox.Show(
                    "Student data not found.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // --- Button Events ---
        private void btn_home_Click(object sender, EventArgs e)
        {
            SetActiveNavButton(btn_home);
        }
        private void btn_problems_Click(object sender, EventArgs e)
        {
            SetActiveNavButton(btn_problems);

            SolveProblemUI form = new SolveProblemUI(student.StudentID);
            form.ShowDialog();
        }
        private void btn_contest_Click(object sender, EventArgs e)
        {
            SetActiveNavButton(btn_contest);

            ContestUI form = new ContestUI(student.StudentID);
            form.ShowDialog();
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            SetActiveNavButton(btnReport);
            // TODO: open ReportUI
            // var form = new ReportUI(student.StudentID);
            // form.Show();
        }
        private void btn_settings_Click(object sender, EventArgs e)
        {
            // TODO: open SettingsUI
            // var form = new SettingsUI(user.UserID);
            // form.Show();
        }
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                this.Close();
        }
    }
}