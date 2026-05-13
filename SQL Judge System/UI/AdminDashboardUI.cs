using SQL_Judge_System.BL;
using System;
using System.Windows.Forms;

namespace SQL_Judge_System.UI
{
    public partial class AdminDashboardUI : Form
    {
        public AdminDashboardUI()
        {
            InitializeComponent();
            ShowPanel(pnlSuperAdmin, "Admin Dashboard");
        }

        

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadAdminData();
            LoadStudentData();
            LoadProblemData();
            LoadContestData();
            ToolTip();        
        }

        // --- SUPER ADMIN PANEL ---
        private void LoadAdminData()
        {
            LoadAdminDashboard();
            LoadAdmin();
        }
        private void LoadAdmin()
        {
            dgvAdmins.DataSource = UserBL.GetAdminList();          

            dgvAdmins.Columns["UserID"].FillWeight = 20;
            dgvAdmins.Columns["FullName"].FillWeight = 80;
            dgvAdmins.Columns["Email"].FillWeight = 40;
            dgvAdmins.Columns["IsActive"].FillWeight = 20;
            dgvAdmins.Columns["CreatedAt"].FillWeight = 50;

            dgvAdmins.Columns["UserID"].HeaderText = "ID";
            dgvAdmins.Columns["FullName"].HeaderText = "Admin Name";
            dgvAdmins.Columns["Email"].HeaderText = "Email";
            dgvAdmins.Columns["IsActive"].HeaderText = "Status";
            dgvAdmins.Columns["CreatedAt"].HeaderText = "Created At";
        }
        public void LoadAdminDashboard()
        {
            lblStdValue.Text = StudentBL.TotalStudents().ToString();
            lbladminValue.Text = UserBL.TotalAdmins().ToString();
            lblContestValue.Text = ContestBL.TotalContests().ToString();
            lblProblemValue.Text = ProblemBL.TotalProblems().ToString();            
        }
        private void btnAddAdmin_Click(object sender, EventArgs e)
        {

        }
        private void btnUpdateAdmin_Click(object sender, EventArgs e)
        {

        }
        private void btnToggleAdmin_Click(object sender, EventArgs e)
        {

        }

        // --- STUDENT PANEL ---
        private void LoadStudentData()
        {
            LoadStudents();
            LoadStudentDashboard();
        }
        private void LoadStudents()
        {
            dgvStudents.DataSource = StudentBL.GetStudentsForAdmin();

            // Set specific weight to columns 
            dgvStudents.Columns["StudentID"].FillWeight = 20;
            dgvStudents.Columns["UserID"].FillWeight = 20;
            dgvStudents.Columns["FullName"].FillWeight = 100;
            dgvStudents.Columns["RegistrationNumber"].FillWeight = 100;
            dgvStudents.Columns["LevelName"].FillWeight = 50;
            dgvStudents.Columns["ProblemsSolved"].FillWeight = 50;
            dgvStudents.Columns["TotalScore"].FillWeight = 50;
            dgvStudents.Columns["IsActive"].FillWeight = 20;
            dgvStudents.Columns["CreatedAt"].FillWeight = 50;

            // Set the header text for each column
            dgvStudents.Columns["StudentID"].HeaderText = "Student ID";
            dgvStudents.Columns["UserID"].HeaderText = "User ID";
            dgvStudents.Columns["FullName"].HeaderText = "Student Name";
            dgvStudents.Columns["RegistrationNumber"].HeaderText = "Reg No.";
            dgvStudents.Columns["LevelName"].HeaderText = "Skill Level";
            dgvStudents.Columns["ProblemsSolved"].HeaderText = "Problems Solved";
            dgvStudents.Columns["TotalScore"].HeaderText = "Total Score";
            dgvStudents.Columns["IsActive"].HeaderText = "Status";
            dgvStudents.Columns["CreatedAt"].HeaderText = "Created At";
        }
        private void LoadStudentDashboard()
        {
            lbl_stdValue.Text = StudentBL.TotalStudents().ToString();
            lblactstdValue.Text = StudentBL.ActiveStudents().ToString();
            lblinactstdValue.Text = StudentBL.InactiveStudents().ToString();
        }
        private void btntoggleStd_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                int studentID = Convert.ToInt32(dgvStudents.SelectedRows[0].Cells["StudentID"].Value);
                bool isActive = Convert.ToBoolean(dgvStudents.SelectedRows[0].Cells["IsActive"].Value);

                if (isActive)
                {
                    DialogResult confirm = MessageBox.Show("Are you sure you want to deactivate this student?", "Confirm Deactivation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.Yes)
                    {
                        UserBL.DeactivateUser(studentID);
                        MessageBox.Show("Student deactivated successfully.");
                    }
                }
                else
                {
                    UserBL.ActivateUser(studentID);
                    MessageBox.Show("Student activated successfully.");
                }
                RefreshData();
            }
            else
            {
                MessageBox.Show("Please select a student");
            }
        }

        // --- PROBLEM PANEL ---
        private void LoadProblemData()
        {
            LoadProblem(); 
            LoadProblemDashboard();
        }
        private void LoadProblem()
        {
            dgvProblems.DataSource = ProblemBL.ProblemsList();
            dgvProblems.Columns["ProblemID"].FillWeight = 20;
            dgvProblems.Columns["Title"].FillWeight = 100;
            dgvProblems.Columns["DifficultyName"].FillWeight = 30;
            dgvProblems.Columns["Points"].FillWeight = 20;
            dgvProblems.Columns["CreatedAt"].FillWeight = 50;
            dgvProblems.Columns["IsActive"].FillWeight = 20;

            dgvProblems.Columns["ProblemID"].HeaderText = "ID";
            dgvProblems.Columns["Title"].HeaderText = "Title";
            dgvProblems.Columns["DifficultyName"].HeaderText = "Difficulty Level";
            dgvProblems.Columns["Points"].HeaderText = "Points";
            dgvProblems.Columns["CreatedAt"].HeaderText = "Created At";
            dgvProblems.Columns["IsActive"].HeaderText = "Status";
        }
        private void LoadProblemDashboard()
        {
            lblTotalProbValue.Text = ProblemBL.TotalProblems().ToString();
            lblActProbValue.Text = ProblemBL.ActiveProblems().ToString();
            lblInActProbValue.Text = ProblemBL.InactiveProblems().ToString();
        }
        private void btnAddProb_Click(object sender, EventArgs e)
        {

        }
        private void btnUpdateProb_Click(object sender, EventArgs e)
        {

        }
        private void btnToggleProb_Click(object sender, EventArgs e)
        {
            if(dgvProblems.SelectedRows.Count > 0)
            {
                int problemID = Convert.ToInt32(dgvProblems.SelectedRows[0].Cells["ProblemID"].Value);
                bool isActive = Convert.ToBoolean(dgvProblems.SelectedRows[0].Cells["IsActive"].Value);

                if (isActive)
                {
                    DialogResult confirm = MessageBox.Show("Are you sure you want to deactivate this problem?", "Confirm Deactivation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.Yes)
                    {
                        ProblemBL.DeactivateProblem(problemID);
                        MessageBox.Show("Problem deactivated successfully.");
                    }
                }
                else
                {
                    ProblemBL.ActivateProblem(problemID);
                    MessageBox.Show("Problem activated successfully.");
                }
                RefreshData();
            }
            else
            {
                MessageBox.Show("Please select a problem");
            }
        }

        // --- Contest Panel ---
        private void LoadContestData()
        {
            LoadContest();
            LoadContestDashboard();
        }
        private void LoadContest()
        {
            dgvContest.DataSource = ContestBL.GetContests();
            dgvContest.Columns["ContestID"].FillWeight = 20;
            dgvContest.Columns["Title"].FillWeight = 100;
            dgvContest.Columns["StartDate"].FillWeight = 50;
            dgvContest.Columns["EndDate"].FillWeight = 50;
            dgvContest.Columns["CreatedBy"].FillWeight = 30;
            dgvContest.Columns["ContestStatus"].FillWeight = 50;

            dgvContest.Columns["ContestID"].HeaderText = "ID";
            dgvContest.Columns["Title"].HeaderText = "Title";
            dgvContest.Columns["StartDate"].HeaderText = "Start Date";
            dgvContest.Columns["EndDate"].HeaderText = "End Date";
            dgvContest.Columns["CreatedBy"].HeaderText = "Created By";
            dgvContest.Columns["ContestStatus"].HeaderText = "Status";
        }
        private void LoadContestDashboard()
        {
            ContestValue.Text = ContestBL.TotalContests().ToString();
            ActContestValue.Text = ContestBL.ActiveContests().ToString();
            InActcontestValue.Text = ContestBL.InactiveContests().ToString();
            UpcommingContestValue.Text = ContestBL.UpcomingContests().ToString();
        }
        private void btnAddContest_Click(object sender, EventArgs e)
        {

        }
        private void btnUpdContest_Click(object sender, EventArgs e)
        {

        }
        private void btnToggleContest_Click(object sender, EventArgs e)
        {

        }

        // Slide Bar Menu Buttons
        private void btnHome_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlSuperAdmin, "Admin Dashboard");
        }
        private void btn_students_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlStudent, "Student Management");
        }
        private void btn_problems_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlProblems, "Problem Management");
        }
        private void btn_contests_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlContest, "Contest Management");
        }
        private void btnTestCases_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlTestCases, "Test Case Management");
        }
        private void btnContestLeaderboard_Click(object sender, EventArgs e)
        {
            //ShowPanel(pnlContestLeaderboard, "Contest Leaderboard");
        }
        private void btnSubmissions_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlsubmissions, "Submission Management");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        // --- Utility Methods ---
        private void RefreshData()
        {
            // Code to reload Admin data from Database into dgvAdmins
            // and update card values (lblTotalVal, etc.)
        }
        private void ShowPanel(Panel targetPanel, string headerText)
        {
            // 1. Hide all panels first
            pnlSuperAdmin.Visible = false;
            pnlProblems.Visible = false;
            pnlStudent.Visible = false;

            // 2. Show the target panel
            targetPanel.Visible = true;

            // 3. Ensure it fills the space and is on top
            targetPanel.Dock = DockStyle.Fill;
            targetPanel.BringToFront();

            // 4. Update the header label
            lblMainTitle.Text = headerText;
        }
        private void ToolTip()
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(btntoggleStd, "Active/Inactive");
            tip.SetToolTip(btnToggleTestCase, "Active/Inactive");
            tip.SetToolTip(btnToggleProb, "Active/Inactive");
            tip.SetToolTip(btnToggleAdmin, "Active/Inactive");
        }
    }
}