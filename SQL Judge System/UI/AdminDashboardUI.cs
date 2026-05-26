using FontAwesome.Sharp;
using SQL_Judge_System.BL;
using SQL_Judge_System.DL;
using SQL_Judge_System.Models;
using System;
using System.Windows.Forms;

namespace SQL_Judge_System.UI
{
    public partial class AdminDashboardUI : Form
    {
        User user = null;

        public AdminDashboardUI(int userID)
        {
            InitializeComponent();

            user = UserBL.GetUserById(userID);

            if (!UserBL.IsUserSuperAdmin(userID))
            {
                btn_Admin.Visible = false;
            }

            ShowPanel(pnlHome, "Home");
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadHomeData();
            LoadAdminData();
            LoadStudentData();
            LoadProblemData();
            LoadContestData();
            LoadTestCaseData();
            LoadSubmissionData();
            ToolTip();        
        }

        // --- HOME PANEL ---
        private void LoadHomeData()
        {
            LoadHome();
            LoadHomeDashboard();
        }
        private void LoadHome()
        {
            try
            {
                dgv_Users.DataSource = UserBL.GetUsers();

                dgv_Users.Columns["UserID"].FillWeight = 20;
                dgv_Users.Columns["FullName"].FillWeight = 70;
                dgv_Users.Columns["Email"].FillWeight = 40;
                dgv_Users.Columns["RoleName"].FillWeight = 50;
                dgv_Users.Columns["IsActive"].FillWeight = 20;
                dgv_Users.Columns["CreatedAt"].FillWeight = 50;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load home data: " + ex.Message);
            }
        }
        private void LoadHomeDashboard()
        {
            try
            {
                lblMainTitle.Text = $"Welcome, {user.FullName}!";
                lblTotalUsersValue.Text = UserBL.TotalUsers().ToString();
                lblActiveUsersValue.Text = UserBL.ActiveUsers().ToString();
                lblInactiveUsersValue.Text = UserBL.InactiveUsers().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load home dashboard data: " + ex.Message);
            }
        }

        // --- SUPER ADMIN PANEL ---
        private void LoadAdminData()
        {
            LoadAdminDashboard();
            LoadAdmin();
        }
        private void LoadAdmin()
        {
            try
            {
                dgvAdmins.DataSource = UserBL.GetAdminList();

                dgvAdmins.Columns["UserID"].FillWeight = 20;
                dgvAdmins.Columns["FullName"].FillWeight = 80;
                dgvAdmins.Columns["Email"].FillWeight = 40;
                dgvAdmins.Columns["IsActive"].FillWeight = 20;
                dgvAdmins.Columns["CreatedAt"].FillWeight = 50;
                dgvAdmins.Columns["RoleName"].Visible = false;

                dgvAdmins.Columns["UserID"].HeaderText = "ID";
                dgvAdmins.Columns["FullName"].HeaderText = "Admin Name";
                dgvAdmins.Columns["Email"].HeaderText = "Email";
                dgvAdmins.Columns["RoleName"].HeaderText = "Role Name";
                dgvAdmins.Columns["IsActive"].HeaderText = "Status";
                dgvAdmins.Columns["CreatedAt"].HeaderText = "Created At";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Failed to load admin data: " + ex.Message);
            }
        }
        public void LoadAdminDashboard()
        {
            try
            {                
                lblsuperAdminValue.Text = UserBL.TotalSuperAdmins().ToString();
                lbladminValue.Text = UserBL.TotalAdmins().ToString();
                lblinActAdminsValue.Text = UserBL.InactiveAdmins().ToString();
                lblActAdminsValue.Text = UserBL.ActiveAdmins().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load dashboard data: " + ex.Message);
            }
        }
        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                AdminPopupForm form = new AdminPopupForm();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add admin: " + ex.Message);
            }
            LoadAdminData();
        }
        private void btnUpdateAdmin_Click(object sender, EventArgs e)
        {
            try 
            {
                if (dgvAdmins.SelectedRows.Count > 0)
                {
                    int userID = Convert.ToInt32(dgvAdmins.SelectedRows[0].Cells["UserID"].Value);

                    AdminPopupForm form = new AdminPopupForm(userID);
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please select a Contest to update.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update admin: " + ex.Message);
            }
            LoadAdminData();
        }
        private void btnToggleAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAdmins.SelectedRows.Count > 0)
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
                }
                else
                {
                    MessageBox.Show("Please select an admin");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to toggle admin status: " + ex.Message);
            }
            LoadAdminData();
        }

        // --- STUDENT PANEL ---
        private void LoadStudentData()
        {
            LoadStudents();
            LoadStudentDashboard();
        }
        private void LoadStudents()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load student data: " + ex.Message);
            }
        }
        private void LoadStudentDashboard()
        {
            try
            {
                lbl_stdValue.Text = StudentBL.TotalStudents().ToString();
                lblactstdValue.Text = StudentBL.ActiveStudents().ToString();
                lblinactstdValue.Text = StudentBL.InactiveStudents().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load student dashboard data: " + ex.Message);
            }
        }
        private void btntoggleStd_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvStudents.SelectedRows.Count > 0)
                {
                    int userID = Convert.ToInt32(dgvStudents.SelectedRows[0].Cells["UserID"].Value);
                    bool isActive = Convert.ToBoolean(dgvStudents.SelectedRows[0].Cells["IsActive"].Value);

                    if (isActive)
                    {
                        DialogResult confirm = MessageBox.Show("Are you sure you want to deactivate this student?", "Confirm Deactivation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (confirm == DialogResult.Yes)
                        {
                            UserBL.DeactivateUser(userID);
                            MessageBox.Show("Student deactivated successfully.");
                        }
                    }
                    else
                    {
                        UserBL.ActivateUser(userID);
                        MessageBox.Show("Student activated successfully.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a student");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to toggle student status: " + ex.Message);
            }
            LoadStudentData();
        }

        // --- PROBLEM PANEL ---
        private void LoadProblemData()
        {
            LoadProblem(); 
            LoadProblemDashboard();
        }
        private void LoadProblem()
        {
            try
            {
                dgvProblems.DataSource = ProblemBL.ProblemsList();

                dgvProblems.Columns["ProblemID"].FillWeight = 20;
                dgvProblems.Columns["Title"].FillWeight = 80;
                dgvProblems.Columns["DifficultyName"].FillWeight = 30;
                dgvProblems.Columns["Points"].FillWeight = 30;
                dgvProblems.Columns["IsActive"].FillWeight = 30;
                dgvProblems.Columns["CreatedBy"].FillWeight = 50;
                dgvProblems.Columns["CreatedAt"].FillWeight = 50;
                dgvProblems.Columns["UpdatedBy"].FillWeight = 50;
                dgvProblems.Columns["UpdatedAt"].FillWeight = 50;

                dgvProblems.Columns["ProblemID"].HeaderText = "ID";
                dgvProblems.Columns["Title"].HeaderText = "Title";
                dgvProblems.Columns["DifficultyName"].HeaderText = "Difficulty Level";
                dgvProblems.Columns["Points"].HeaderText = "Points";
                dgvProblems.Columns["IsActive"].HeaderText = "Status";
                dgvProblems.Columns["CreatedBy"].HeaderText = "Created By";
                dgvProblems.Columns["CreatedAt"].HeaderText = "Created At";
                dgvProblems.Columns["UpdatedBy"].HeaderText = "Updated By";
                dgvProblems.Columns["UpdatedAt"].HeaderText = "Updated At";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load problem data: " + ex.Message);
            }
        }
        private void LoadProblemDashboard()
        {
            try
            {
                lblTotalProbValue.Text = ProblemBL.TotalProblems().ToString();
                lblActProbValue.Text = ProblemBL.ActiveProblems().ToString();
                lblInActProbValue.Text = ProblemBL.InactiveProblems().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load problem dashboard data: " + ex.Message);
            }
        }
        private void btnAddProb_Click(object sender, EventArgs e)
        {
            try
            {
                ProblemPopupForm form = new ProblemPopupForm(user.UserID);
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update admin: " + ex.Message);
            }
            LoadProblemData();
        }
        private void btnUpdateProb_Click(object sender, EventArgs e)
        {
            try 
            {
                if (dgvProblems.SelectedRows.Count > 0)
                {
                    int problemID = Convert.ToInt32(dgvProblems.SelectedRows[0].Cells["ProblemID"].Value);

                    ProblemPopupForm form = new ProblemPopupForm(user.UserID, problemID);
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please select a Problem to update.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update Problem: " + ex.Message);
            }
            LoadProblemData();
        }
        private void btnToggleProb_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProblems.SelectedRows.Count > 0)
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
                }
                else
                {
                    MessageBox.Show("Please select a problem");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to toggle problem status: " + ex.Message);
            }
            LoadProblemData();
        }

        // --- Contest Panel ---
        private void LoadContestData()
        {
            LoadContest();
            LoadContestDashboard();
        }
        private void LoadContest()
        {
            try
            {
                dgvContest.DataSource = ContestBL.GetContests();

                // ===== Column Styling =====
                dgvContest.Columns["ContestID"].HeaderText = "ID";
                dgvContest.Columns["Title"].HeaderText = "Title";
                dgvContest.Columns["StartDate"].HeaderText = "Start Date";
                dgvContest.Columns["EndDate"].HeaderText = "End Date";
                dgvContest.Columns["TotalParticipants"].HeaderText = "Participants";
                dgvContest.Columns["CreatedBy"].HeaderText = "Created By";
                dgvContest.Columns["UpdatedBy"].HeaderText = "Updated By";
                dgvContest.Columns["CreatedAt"].HeaderText = "Created At";
                dgvContest.Columns["UpdatedAt"].HeaderText = "Updated At";
                dgvContest.Columns["ContestStatus"].HeaderText = "Status";

                // ===== Layout =====
                dgvContest.Columns["ContestID"].FillWeight = 20;
                dgvContest.Columns["Title"].FillWeight = 80;
                dgvContest.Columns["StartDate"].FillWeight = 40;
                dgvContest.Columns["EndDate"].FillWeight = 40;
                dgvContest.Columns["TotalParticipants"].FillWeight = 50;
                dgvContest.Columns["CreatedBy"].FillWeight = 50;
                dgvContest.Columns["UpdatedBy"].FillWeight = 50;
                dgvContest.Columns["CreatedAt"].FillWeight = 50;
                dgvContest.Columns["UpdatedAt"].FillWeight = 50;
                dgvContest.Columns["ContestStatus"].FillWeight = 40;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load contest data: " + ex.Message);
            }
        }
        private void LoadContestDashboard()
        {
            try
            {
                lblTotalContestValue.Text = ContestBL.TotalContests().ToString();
                lblActContestValue.Text = ContestBL.ActiveContests().ToString();
                lblInActcontestValue.Text = ContestBL.InactiveContests().ToString();
                lblUpcommingContestValue.Text = ContestBL.UpcomingContests().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load contest dashboard data: " + ex.Message);
            }
        }
        private void btnAddContest_Click(object sender, EventArgs e)
        {
            try
            {
                ContestPopupForm form = new ContestPopupForm(user.UserID);
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update admin: " + ex.Message);
            }
            LoadContestData();
        }
        private void btnUpdContest_Click(object sender, EventArgs e)
        {
            try 
            {
                if (dgvContest.SelectedRows.Count > 0)
                {
                    int contestID = Convert.ToInt32(dgvContest.SelectedRows[0].Cells["ContestID"].Value);

                    ContestPopupForm form = new ContestPopupForm(user.UserID, contestID);
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please select a Contest to update.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update admin: " + ex.Message);
            }
            LoadContestData();
        }

        // --- Test Cases Panel ---
        private void LoadTestCaseData()
        {
            LoadTestCases();
            LoadTestCaseDashboard();
        }
        private void LoadTestCases()
        {
            try
            {
                dgvTestCases.DataSource = TestCaseBL.GetTestCases();

                dgvTestCases.Columns["TestCaseID"].FillWeight = 30;
                dgvTestCases.Columns["ProblemID"].FillWeight = 50;
                dgvTestCases.Columns["ProblemTitle"].FillWeight = 80;
                dgvTestCases.Columns["SetupSQLPreview"].FillWeight = 80;
                dgvTestCases.Columns["SolutionQueryPreview"].FillWeight = 80;
                dgvContest.Columns["CreatedBy"].FillWeight = 30;
                dgvContest.Columns["UpdatedBy"].FillWeight = 30;
                dgvContest.Columns["CreatedAt"].FillWeight = 30;
                dgvContest.Columns["UpdatedAt"].FillWeight = 30;
                dgvTestCases.Columns["IsActive"].FillWeight = 40;

                dgvTestCases.Columns["TestCaseID"].HeaderText = "ID";
                dgvTestCases.Columns["ProblemID"].HeaderText = "Problem ID";
                dgvTestCases.Columns["ProblemTitle"].HeaderText = "Problem Title";
                dgvTestCases.Columns["SetupSQLPreview"].HeaderText = "Setup SQL Preview";
                dgvTestCases.Columns["SolutionQueryPreview"].HeaderText = "Solution Query Preview";                
                dgvContest.Columns["CreatedBy"].HeaderText = "Created By";
                dgvContest.Columns["UpdatedBy"].HeaderText = "Updated By";
                dgvContest.Columns["CreatedAt"].HeaderText = "Created At";
                dgvContest.Columns["UpdatedAt"].HeaderText = "Updated At";
                dgvTestCases.Columns["IsActive"].HeaderText = "Status";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Failed to load test case data: " + ex.Message);
            }
        }
        private void LoadTestCaseDashboard()
        {
            try
            {
                lbltotalTestCases.Text = TestCaseBL.TotalTestCases().ToString();
                lblActTestCases.Text = TestCaseBL.ActiveTestCases().ToString();
                lblInActiveTestCases.Text = TestCaseBL.InactiveTestCases().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load test case dashboard data: " + ex.Message);
            }
        }
        private void btnAddTestCase_Click(object sender, EventArgs e)
        {
            try
            {
                TestCasePopupForm form = new TestCasePopupForm(user.UserID);
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update admin: " + ex.Message);
            }
            LoadTestCaseData();
        }
        private void btnUpdateTestCase_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTestCases.SelectedRows.Count > 0)
                {
                    int testCaseID = Convert.ToInt32(dgvContest.SelectedRows[0].Cells["TestCaseID"].Value);

                    TestCasePopupForm form = new TestCasePopupForm(user.UserID, testCaseID);
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please select a Test Case to update.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update admin: " + ex.Message);
            }
            LoadTestCaseData();
        }
        private void btnToggleTestCase_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTestCases.SelectedRows.Count > 0)
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
                }
                else
                {
                    MessageBox.Show("Please select a test case");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to toggle test case status: " + ex.Message);
            }
            LoadTestCaseData();
        }

        // --- Submissions Panel ---
        private void LoadSubmissionData()
        {
            LoadSubmissions();
            LoadSubmissionDashboard();
        }
        private void LoadSubmissions()
        {
            try {
                dgvSubmissions.DataSource = SubmissionBL.GetSubmissions();

                dgvSubmissions.Columns["SubmissionID"].FillWeight = 20;
                dgvSubmissions.Columns["StudentID"].FillWeight = 30;
                dgvSubmissions.Columns["StudentName"].FillWeight = 50;
                dgvSubmissions.Columns["ProblemID"].FillWeight = 30;
                dgvSubmissions.Columns["ProblemTitle"].FillWeight = 80;
                dgvSubmissions.Columns["TotalScore"].FillWeight = 30;
                dgvSubmissions.Columns["AttemptNumber"].FillWeight = 30;
                dgvSubmissions.Columns["SubmittedAt"].FillWeight = 50;
                dgvSubmissions.Columns["Status"].FillWeight = 50;                           

                dgvSubmissions.Columns["SubmissionID"].HeaderText = "ID";
                dgvSubmissions.Columns["StudentID"].HeaderText = "Student ID";
                dgvSubmissions.Columns["StudentName"].HeaderText = "Student Name";
                dgvSubmissions.Columns["ProblemID"].HeaderText = "Problem ID";
                dgvSubmissions.Columns["ProblemTitle"].HeaderText = "Problem Title";
                dgvSubmissions.Columns["AttemptNumber"].HeaderText = "Attempt #";
                dgvSubmissions.Columns["TotalScore"].HeaderText = "Total Score";
                dgvSubmissions.Columns["SubmittedAt"].HeaderText = "Submitted At";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load submission data: " + ex.Message);
            }
        }
        private void LoadSubmissionDashboard()
        {
            try
            {
                totalsubValue.Text = SubmissionBL.TotalSubmissions().ToString();
                AccSubValue.Text = SubmissionBL.AcceptedSubmissions().ToString();
                RegSubValue.Text = SubmissionBL.RejectedSubmissions().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load submission dashboard data: " + ex.Message);
            }
        }


        // Slide Bar Menu Buttons
        private void btnHome_Click(object sender, EventArgs e)
        {
          ShowPanel(pnlHome, "Home");
        }
        private void btn_Admin_Click(object sender, EventArgs e)
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
        private void ShowPanel(Panel targetPanel, string headerText)
        {
            // 1. Hide all panels first
            pnlSuperAdmin.Visible = false;
            pnlProblems.Visible = false;
            pnlStudent.Visible = false;
            pnlContest.Visible = false;
            pnlsubmissions.Visible = false;
            pnlTestCases.Visible = false;

            // 2. Show the target panel
            targetPanel.Visible = true;

            // 3. Ensure it fills the space and is on top
            targetPanel.Dock = DockStyle.Fill;
            targetPanel.BringToFront();

            // 4. Update the header label
            lblSuperAdmin.Text = headerText;
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