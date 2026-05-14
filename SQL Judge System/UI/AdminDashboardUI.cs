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
            LoadTestCaseData();
            LoadSubmissionData();
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
            if (dgvStudents.SelectedRows.Count > 0)
            {
                int adminID = Convert.ToInt32(dgvAdmins.SelectedRows[0].Cells["UserID"].Value);
                bool isActive = Convert.ToBoolean(dgvAdmins.SelectedRows[0].Cells["IsActive"].Value);
                if (isActive)
                {
                    DialogResult confirm = MessageBox.Show("Are you sure you want to deactivate this admin?", "Confirm Deactivation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.Yes)
                    {
                        UserBL.DeactivateUser(adminID);
                        MessageBox.Show("Admin deactivated successfully.");
                    }
                }
                else
                {
                    UserBL.ActivateUser(adminID);
                    MessageBox.Show("Admin activated successfully.");
                }
                RefreshData();
            }
            else
            {
                MessageBox.Show("Please select an admin");
            }
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
            dgvStudents.Columns["UserID"].FillWeight = 30;
            dgvStudents.Columns["FullName"].FillWeight = 70;
            dgvStudents.Columns["RegistrationNumber"].FillWeight = 50;
            dgvStudents.Columns["LevelName"].FillWeight = 50;
            dgvStudents.Columns["ProblemsSolved"].FillWeight = 50;
            dgvStudents.Columns["TotalScore"].FillWeight = 50;
            dgvStudents.Columns["IsActive"].FillWeight = 20;
            dgvStudents.Columns["CreatedAt"].FillWeight = 50;

            // Set the header text for each column
            dgvStudents.Columns["StudentID"].HeaderText = "ID";
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
            dgvContest.Columns["TotalParticipants"].FillWeight = 30;
            dgvContest.Columns["ContestStatus"].FillWeight = 50;

            dgvContest.Columns["ContestID"].HeaderText = "ID";
            dgvContest.Columns["Title"].HeaderText = "Title";
            dgvContest.Columns["StartDate"].HeaderText = "Start Date";
            dgvContest.Columns["EndDate"].HeaderText = "End Date";
            dgvContest.Columns["CreatedBy"].HeaderText = "Created By";
            dgvContest.Columns["TotalParticipants"].HeaderText = "Participants";
            dgvContest.Columns["ContestStatus"].HeaderText = "Status";
        }
        private void LoadContestDashboard()
        {
            lblTotalContestValue.Text = ContestBL.TotalContests().ToString();
            lblActContestValue.Text = ContestBL.ActiveContests().ToString();
            lblInActcontestValue.Text = ContestBL.InactiveContests().ToString();
            lblUpcommingContestValue.Text = ContestBL.UpcomingContests().ToString();
        }
        private void btnAddContest_Click(object sender, EventArgs e)
        {

        }
        private void btnUpdContest_Click(object sender, EventArgs e)
        {

        }

        // --- Test Cases Panel ---
        private void LoadTestCaseData()
        {
            LoadTestCases();
            LoadTestCaseDashboard();
        }
        private void LoadTestCases()
        {
            dgvTestCases.DataSource = TestCaseBL.GetTestCasesForAdmin();
            dgvTestCases.Columns["TestCaseID"].FillWeight = 20;
            dgvTestCases.Columns["ProblemID"].FillWeight = 20;
            dgvTestCases.Columns["Title"].FillWeight = 50;
            dgvTestCases.Columns["SetupSQL"].FillWeight = 100;
            dgvTestCases.Columns["ExpectedOutput"].FillWeight = 100;
            dgvTestCases.Columns["CreatedAt"].FillWeight = 50;
            dgvTestCases.Columns["IsActive"].FillWeight = 20;

            dgvTestCases.Columns["TestCaseID"].HeaderText = "ID";
            dgvTestCases.Columns["ProblemID"].HeaderText = "Problem ID";
            dgvTestCases.Columns["Title"].HeaderText = "Problem Title";
            dgvTestCases.Columns["SetupSQL"].HeaderText = "Setup SQL";
            dgvTestCases.Columns["ExpectedOutput"].HeaderText = "Expected Output";
            dgvTestCases.Columns["IsActive"].HeaderText = "Status";
            dgvTestCases.Columns["CreatedAt"].HeaderText = "Created At";
        }
        private void LoadTestCaseDashboard()
        {
            lbltotalTestCases.Text = TestCaseBL.TotalTestCases().ToString();
            lblActTestCases.Text = TestCaseBL.ActiveTestCases().ToString();
            lblInActiveTestCases.Text = TestCaseBL.InactiveTestCases().ToString();
        }
        private void btnAddTestCase_Click(object sender, EventArgs e)
        {

        }
        private void btnUpdateTestCase_Click(object sender, EventArgs e)
        {

        }
        private void btnToggleTestCase_Click(object sender, EventArgs e)
        {
            if(dgvTestCases.SelectedRows.Count > 0)
            {
                int testCaseID = Convert.ToInt32(dgvTestCases.SelectedRows[0].Cells["TestCaseID"].Value);
                bool isActive = Convert.ToBoolean(dgvTestCases.SelectedRows[0].Cells["IsActive"].Value);
                if (isActive)
                {
                    DialogResult confirm = MessageBox.Show("Are you sure you want to deactivate this test case?", "Confirm Deactivation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.Yes)
                    {
                        TestCaseBL.DeactivateTestCase(testCaseID);
                        MessageBox.Show("Test case deactivated successfully.");
                    }
                }
                else
                {
                    TestCaseBL.ActivateTestCase(testCaseID);
                    MessageBox.Show("Test case activated successfully.");
                }
                RefreshData();
            }
            else
            {
                MessageBox.Show("Please select a test case");
            }
        }

        // --- Submissions Panel ---
        private void LoadSubmissionData()
        {
            LoadSubmissions();
            LoadSubmissionDashboard();
        }
        private void LoadSubmissions()
        {
            dgvSubmissions.DataSource = SubmissionBL.GetSubmissionsForAdmin();
            dgvSubmissions.Columns["SubmissionID"].FillWeight = 20;
            dgvSubmissions.Columns["StudentName"].FillWeight = 100;
            dgvSubmissions.Columns["ProblemTitle"].FillWeight = 100;
            dgvSubmissions.Columns["SubmittedAt"].FillWeight = 50;
            dgvSubmissions.Columns["Status"].FillWeight = 30;
            dgvSubmissions.Columns["Score"].FillWeight = 20;
            dgvSubmissions.Columns["SubmissionID"].HeaderText = "ID";
            dgvSubmissions.Columns["StudentName"].HeaderText = "Student Name";
            dgvSubmissions.Columns["ProblemTitle"].HeaderText = "Problem Title";
            dgvSubmissions.Columns["SubmittedAt"].HeaderText = "Submitted At";
            dgvSubmissions.Columns["Status"].HeaderText = "Status";
            dgvSubmissions.Columns["Score"].HeaderText = "Score";
        }
        private void LoadSubmissionDashboard()
        {
            totalsubValue.Text = SubmissionBL.TotalSubmissions().ToString();
            AccSubValue.Text = SubmissionBL.AcceptedSubmissions().ToString();
            RegSubValue.Text = SubmissionBL.RejectedSubmissions().ToString();
        }



        // Slide Bar Menu Buttons
        private void btnHome_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlSuperAdmin, "Admin Dashboard");
        }
        private void btnAdmin_Click(object sender, EventArgs e)
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
        private void btnReport_Click(object sender, EventArgs e)
        {

        }
        private void btn_Settings_Click(object sender, EventArgs e)
        {

        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // --- Utility Methods ---
        private void RefreshData()
        {
            
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