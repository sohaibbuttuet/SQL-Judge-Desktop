using System;
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
        public StudentDashboardUI(int userId)
        {
            user = UserBL.GetUserById(userId);
            student = StudentBL.GetStudentByUserID(userId);
            InitializeComponent();
        }

       
        private void StudentDashboard_Load(object sender, EventArgs e)
        {
            LoadleaderBoard();
            LoadStudentData();
        }
        private void LoadleaderBoard()
        {
            dgvLeaderboard.DataSource = StudentLeaderboardBL.GetLeaderboard();

            // --- RESPONSIVE LOGIC ---

            // 1. Make columns fill the entire width of the grid
            dgvLeaderboard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // 2. Set specific weight to columns 
            dgvLeaderboard.Columns["GlobalRank"].FillWeight = 50;
            dgvLeaderboard.Columns["StudentID"].FillWeight = 50;
            dgvLeaderboard.Columns["FullName"].FillWeight = 150;
            dgvLeaderboard.Columns["RegistrationNumber"].FillWeight = 100;
            dgvLeaderboard.Columns["LevelName"].FillWeight = 100;
            dgvLeaderboard.Columns["ProblemsSolved"].FillWeight = 80;
            dgvLeaderboard.Columns["TotalScore"].FillWeight = 80;

            // 3. Set the header text for each column
            dgvLeaderboard.Columns["GlobalRank"].HeaderText = "Global Rank";
            dgvLeaderboard.Columns["StudentID"].HeaderText = "Student ID";
            dgvLeaderboard.Columns["FullName"].HeaderText = "Student Name";
            dgvLeaderboard.Columns["RegistrationNumber"].HeaderText = "Reg No";
            dgvLeaderboard.Columns["LevelName"].HeaderText = "Skill Level";
            dgvLeaderboard.Columns["ProblemsSolved"].HeaderText = "Problems Solved";
            dgvLeaderboard.Columns["TotalScore"].HeaderText = "Total Score";
        }
        private void LoadStudentData()
        {
            if (student != null)
            {
                lblWelcome.Text = $"Welcome, {user.FullName}!";
                lblRankValue.Text = $"#{StudentLeaderboardBL.GetRank(student.StudentID)}".ToString();
                lblScoreValue.Text = StudentLeaderboardBL.GetTotalScore(student.StudentID).ToString();
                lblSkillValue.Text = StudentLeaderboardBL.GetSkillLevel(student.StudentID).ToString();
                lblSolvedValue.Text = StudentLeaderboardBL.GetSolvedProblemsCount(student.StudentID).ToString();
            }
            else
            {
                MessageBox.Show("Student data not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_home_Click(object sender, EventArgs e)
        {

        }
        private void btn_problems_Click(object sender, EventArgs e)
        {
            
        }
        private void btn_contest_Click(object sender, EventArgs e)
        {

        }
        private void btnReport_Click(object sender, EventArgs e)
        {

        }
        private void btn_settings_Click(object sender, EventArgs e)
        {

        }
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}