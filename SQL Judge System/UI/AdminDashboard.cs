using SQL_Judge_System.BL;
using System;
using System.Windows.Forms;

namespace SQL_Judge_System.UI
{
    public partial class AdminDashboard : Form
    {
        private int UserID;
        public AdminDashboard( int userId)
        {
            UserID = userId;
            InitializeComponent();
        }

        public void LoadDashboardData()
        {
            lblStdValue.Text = AdminDashboardBL.TotalStudents().ToString();
            lbladminValue.Text = AdminDashboardBL.TotalAdmins().ToString();
            lblContestValue.Text = AdminDashboardBL.TotalContests().ToString();
            lblProblemValue.Text = AdminDashboardBL.TotalProblems().ToString();
        }

        public void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardData();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opening User Management...");
            // Logic to show users would go here
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_users_Click(object sender, EventArgs e)
        {

        }

        private void btn_students_Click(object sender, EventArgs e)
        {

        }

        private void btn_problems_Click(object sender, EventArgs e)
        {

        }

        private void btn_contests_Click(object sender, EventArgs e)
        {

        }
    }
}