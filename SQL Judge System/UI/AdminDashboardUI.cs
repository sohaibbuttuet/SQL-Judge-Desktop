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

            // Default startup view
            ShowPanel(pnlHome, "Home");
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadHomeData();
            LoadAdminData();
            LoadStudentData();
            LoadProblemData();
            LoadContestData();
            LoadSubmissionData();
            SetupToolTips();
        }


        // ==========================================
        // --- 1. HOME PANEL ---
        // ==========================================
        private void LoadHomeData()
        {
            LoadHomeGrid();
            LoadHomeDashboardCounters();
        }
        private void LoadHomeGrid()
        {
            try
            {
                dgv_Users.DataSource = UserBL.GetUsers();
                dgv_Users.Columns["UserID"].Visible = false;

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
        private void LoadHomeDashboardCounters()
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
                MessageBox.Show("Failed to load home dashboard data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // --- 2. SUPER ADMIN PANEL ---
        // ==========================================
        private void LoadAdminData()
        {
            LoadAdminDashboardCounters();
            LoadAdminGrid();
        }   
        private void LoadAdminGrid()
        {
            try
            {
                dgvAdmins.DataSource = UserBL.GetAdminList();

                dgvAdmins.Columns["UserID"].Visible = false;
                dgvAdmins.Columns["RoleName"].Visible = false;

                dgvAdmins.Columns["FullName"].FillWeight = 80;
                dgvAdmins.Columns["Email"].FillWeight = 40;
                dgvAdmins.Columns["IsActive"].FillWeight = 20;
                dgvAdmins.Columns["CreatedAt"].FillWeight = 50;
                
                dgvAdmins.Columns["FullName"].HeaderText = "Admin Name";
                dgvAdmins.Columns["Email"].HeaderText = "Email";
                dgvAdmins.Columns["IsActive"].HeaderText = "Status";
                dgvAdmins.Columns["CreatedAt"].HeaderText = "Created At";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load admin data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LoadAdminDashboardCounters()
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
                MessageBox.Show("Failed to load admin dashboard counters: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Failed to open add admin screen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Please select an Admin account from the grid to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update admin: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        DialogResult confirm = MessageBox.Show("Are you sure you want to deactivate this admin account?", "Confirm Deactivation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (confirm == DialogResult.Yes)
                        {
                            UserBL.DeactivateUser(adminID);
                            MessageBox.Show("Admin deactivated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        UserBL.ActivateUser(adminID);
                        MessageBox.Show("Admin activated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please select an admin from the list.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to toggle admin status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadAdminData();
        }

        // ==========================================
        // --- 3. STUDENT PANEL ---
        // ==========================================
        private void LoadStudentData()
        {
            LoadStudentsGrid();
            LoadStudentDashboardCounters();
        }
        private void LoadStudentsGrid()
        {
            try
            {
                dgvStudents.DataSource = StudentBL.GetStudentsForAdmin();
               
                dgvStudents.Columns["StudentID"].Visible = false;
                dgvStudents.Columns["UserID"].Visible = false;

                // Set specific weight to columns 
                dgvStudents.Columns["FullName"].FillWeight = 70;
                dgvStudents.Columns["RegistrationNumber"].FillWeight = 50;
                dgvStudents.Columns["LevelName"].FillWeight = 50;
                dgvStudents.Columns["ProblemsSolved"].FillWeight = 50;
                dgvStudents.Columns["TotalScore"].FillWeight = 50;
                dgvStudents.Columns["IsActive"].FillWeight = 20;
                dgvStudents.Columns["CreatedAt"].FillWeight = 50;

                // Set the header text for each column
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
                MessageBox.Show("Failed to load student data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadStudentDashboardCounters()
        {
            try
            {
                lbl_stdValue.Text = StudentBL.TotalStudents().ToString();
                lblactstdValue.Text = StudentBL.ActiveStudents().ToString();
                lblinactstdValue.Text = StudentBL.InactiveStudents().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load student dashboard counters: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        DialogResult confirm = MessageBox.Show("Are you sure you want to deactivate this student account?", "Confirm Deactivation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (confirm == DialogResult.Yes)
                        {
                            UserBL.DeactivateUser(userID);
                            MessageBox.Show("Student deactivated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        UserBL.ActivateUser(userID);
                        MessageBox.Show("Student activated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a student from the list.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to toggle student status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadStudentData();
        }

        // ==========================================
        // --- 4. PROBLEM PANEL ---
        // ==========================================
        private void LoadProblemData()
        {
            LoadProblemGrid();
            LoadProblemDashboardCounters();
        }
        private void LoadProblemGrid()
        {
            try
            {
                dgvProblems.DataSource = ProblemBL.ProblemsList();

                dgvProblems.Columns["ProblemID"].Visible = false;

                dgvProblems.Columns["Title"].FillWeight = 80;
                dgvProblems.Columns["DifficultyName"].FillWeight = 30;
                dgvProblems.Columns["Points"].FillWeight = 30;
                dgvProblems.Columns["IsActive"].FillWeight = 30;
                dgvProblems.Columns["CreatedBy"].FillWeight = 50;
                dgvProblems.Columns["CreatedAt"].FillWeight = 50;
                dgvProblems.Columns["UpdatedBy"].FillWeight = 50;
                dgvProblems.Columns["UpdatedAt"].FillWeight = 50;

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
                MessageBox.Show("Failed to load problem database list: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadProblemDashboardCounters()
        {
            try
            {
                lblTotalProbValue.Text = ProblemBL.TotalProblems().ToString();
                lblActProbValue.Text = ProblemBL.ActiveProblems().ToString();
                lblInActProbValue.Text = ProblemBL.InactiveProblems().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load problem dashboard counters: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAddProb_Click(object sender, EventArgs e)
        {
            try
            {
                CreateProblemUI form = new CreateProblemUI(user.UserID);
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open creation engine form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    CreateProblemUI form = new CreateProblemUI(user.UserID, problemID);
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please select a Problem from the grid to modify.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        DialogResult confirm = MessageBox.Show("Are you sure you want to pull this problem down from active judging status?", "Confirm Deactivation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (confirm == DialogResult.Yes)
                        {
                            ProblemBL.DeactivateProblem(problemID);

                            MessageBox.Show("Problem deactivated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        ProblemBL.ActivateProblem(problemID);

                        MessageBox.Show("Problem deployed and activated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a problem from the grid matrix view.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to toggle problem deployment validation status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadProblemData();
        }

        // ==========================================
        // --- 5. CONTEST PANEL ---
        // ==========================================
        private void LoadContestData()
        {
            LoadContestGrid();
            LoadContestDashboardCounters();
        }
        private void LoadContestGrid()
        {
            try
            {
                dgvContest.DataSource = ContestBL.GetContests();               
                dgvContest.Columns["ContestID"].Visible = false;

                // ===== Column Styling =====
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
                MessageBox.Show("Failed to load contest data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadContestDashboardCounters()
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
                MessageBox.Show("Failed to load contest dashboard: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Failed to add contest: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Please select a contest row to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load contest data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadContestData();
        }

        // --- Submissions Panel ---
        // ==========================================
        // --- 6. SUBMISSIONS PANEL ---
        // ==========================================
        private void LoadSubmissionData()
        {
            LoadSubmissionsGrid();
            LoadSubmissionDashboardCounters();
        }
        private void LoadSubmissionsGrid()
        {
            try {
                dgvSubmissions.DataSource = SubmissionBL.GetSubmissions();

                dgvSubmissions.Columns["SubmissionID"].Visible = false;
                dgvSubmissions.Columns["StudentID"].Visible = false;
                dgvSubmissions.Columns["ProblemID"].Visible = false;

                dgvSubmissions.Columns["StudentName"].FillWeight = 50;                
                dgvSubmissions.Columns["ProblemTitle"].FillWeight = 80;
                dgvSubmissions.Columns["TotalScore"].FillWeight = 30;
                dgvSubmissions.Columns["AttemptNumber"].FillWeight = 30;
                dgvSubmissions.Columns["SubmittedAt"].FillWeight = 50;
                dgvSubmissions.Columns["Status"].FillWeight = 50;                           

                dgvSubmissions.Columns["StudentName"].HeaderText = "Student Name";
                dgvSubmissions.Columns["ProblemTitle"].HeaderText = "Problem Title";
                dgvSubmissions.Columns["TotalScore"].HeaderText = "Total Score";
                dgvSubmissions.Columns["AttemptNumber"].HeaderText = "Attempt #";                
                dgvSubmissions.Columns["SubmittedAt"].HeaderText = "Submitted At";
                dgvSubmissions.Columns["Status"].HeaderText = "Status";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load submission data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadSubmissionDashboardCounters()
        {
            try
            {
                totalsubValue.Text = SubmissionBL.TotalSubmissions().ToString();
                AccSubValue.Text = SubmissionBL.AcceptedSubmissions().ToString();
                RegSubValue.Text = SubmissionBL.RejectedSubmissions().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load compiled matrix logs: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // --- 7. SLIDE BAR NAVIGATION ACTIONS ---
        // ==========================================
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
            SettingsForm form = new SettingsForm(user.UserID);
            form.ShowDialog();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // ==========================================
        // --- 8. UTILITY CORE INFRASTRUCTURE ---
        // ==========================================
        private void ShowPanel(Panel targetPanel, string headerText)
        {
            // Hide all panels
            pnlHome.Visible = false;
            pnlSuperAdmin.Visible = false;
            pnlProblems.Visible = false;
            pnlStudent.Visible = false;
            pnlContest.Visible = false;
            pnlsubmissions.Visible = false;

            // Show target panel
           
            targetPanel.Dock = DockStyle.Fill;
            targetPanel.BringToFront();

            targetPanel.Visible = true;
            // Set main app frame layout title
            lblSuperAdmin.Text = headerText;
        }
        private void SetupToolTips()
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(btntoggleStd, "Toggle Account Status (Active/Inactive)");
            tip.SetToolTip(btnToggleProb, "Toggle Problem Deployment (Active/Inactive)");
            tip.SetToolTip(btnToggleAdmin, "Toggle Administrator Status (Active/Inactive)");
        }
    }
}