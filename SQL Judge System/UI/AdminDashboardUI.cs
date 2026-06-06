using FontAwesome.Sharp;
using SQL_Judge_System.BL;
using SQL_Judge_System.DL;
using SQL_Judge_System.Models;
using System;
using System.Data;
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
            LoadHomeGrid();
            SetupToolTips();
        }

        // ==========================================
        // --- 1. HOME PANEL ---
        // ==========================================
        private void LoadHomeGrid()
        {
            try
            {
                DataTable dt = UserBL.GetUsers();

                LoadHomeDashboardCounters(dt);

                dgv_Users.DataSource = dt;
                dgv_Users.Columns["UserID"].Visible = false;

                // ===== Users Grid Column Styling & Layout =====
                SafeColumn(dgv_Users, "FullName", "Full Name", 70); 
                SafeColumn(dgv_Users, "Email", "Email", 40);       
                SafeColumn(dgv_Users, "RoleName", "Role", 50);      
                SafeColumn(dgv_Users, "IsActive", "Status", 20);   
                SafeColumn(dgv_Users, "CreatedAt", "Created At", 50); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load home data: " + ex.Message);
            }
        }
        private void LoadHomeDashboardCounters(DataTable dt)
        {
            try
            {
                lblMainTitle.Text = $"Welcome, {user.FullName}!";
                lblTotalUsersValue.Text = dt.Rows.Count.ToString();

                // 1. Active Users
                DataView dvActive = new DataView(dt);
                dvActive.RowFilter = "IsActive = 1";
                lblActiveUsersValue.Text = dvActive.Count.ToString();

                // 2. Inactive Users
                DataView dvInActive = new DataView(dt);
                dvInActive.RowFilter = "IsActive = 0";
                lblInactiveUsersValue.Text = dvInActive.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load home dashboard data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // --- 2. SUPER ADMIN PANEL ---
        // ==========================================  
        private void LoadAdminGrid()
        {
            try
            {
                DataTable dt = UserBL.GetAdmins();

                LoadAdminDashboardCounters(dt);

                dgvAdmins.DataSource = dt;

                dgvAdmins.Columns["UserID"].Visible = false;
                dgvAdmins.Columns["RoleName"].Visible = false;

                // ===== Admins Grid Column Styling & Layout =====
                SafeColumn(dgvAdmins, "FullName", "Admin Name", 80);
                SafeColumn(dgvAdmins, "Email", "Email", 40);
                SafeColumn(dgvAdmins, "IsActive", "Status", 20);
                SafeColumn(dgvAdmins, "CreatedAt", "Created At", 50);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load admin data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LoadAdminDashboardCounters(DataTable dt)
        {
            try
            {
                lbladminValue.Text = dt.Rows.Count.ToString();

                lblsuperAdminValue.Text = UserBL.TotalSuperAdmins().ToString();   
                
                // Active users
                DataView dvActive = new DataView(dt);
                dvActive.RowFilter = "IsActive = 1";
                lblActAdminsValue.Text = dvActive.Count.ToString();

                // InActive users
                DataView dvInActive = new DataView(dt);
                dvInActive.RowFilter = "IsActive = 0";
                lblinActAdminsValue.Text = dvInActive.Count.ToString();
                
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
            LoadAdminGrid();
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
            LoadAdminGrid();
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
            LoadAdminGrid();
        }

        // ==========================================
        // --- 3. STUDENT PANEL ---
        // ==========================================
        private void LoadStudentsGrid()
        {
            try
            {
                DataTable dt = StudentBL.GetStudents();

                LoadStudentDashboardCounters(dt);

                dgvStudents.DataSource = dt;
               
                dgvStudents.Columns["StudentID"].Visible = false;
                dgvStudents.Columns["UserID"].Visible = false;

                // ===== Students Grid Column Styling & Layout =====
                SafeColumn(dgvStudents, "FullName", "Student Name", 70);
                SafeColumn(dgvStudents, "RegistrationNumber", "Reg No.", 50);
                SafeColumn(dgvStudents, "LevelName", "Skill Level", 50);
                SafeColumn(dgvStudents, "ProblemsSolved", "Problems Solved", 50);
                SafeColumn(dgvStudents, "TotalScore", "Total Score", 50);
                SafeColumn(dgvStudents, "IsActive", "Status", 20);
                SafeColumn(dgvStudents, "CreatedAt", "Created At", 50);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load student data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadStudentDashboardCounters(DataTable dt)
        {
            try
            {
                lbl_stdValue.Text = dt.Rows.Count.ToString();


                // Active Students
                DataView dvActive = new DataView(dt);
                dvActive.RowFilter = "IsActive = 1";
                lblactstdValue.Text = dvActive.Count.ToString();

                // InActive Students
                DataView dvInActive = new DataView(dt);
                dvInActive.RowFilter = "IsActive = 0";
                lblinactstdValue.Text = dvInActive.Count.ToString();
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
            LoadStudentsGrid();
        }

        // ==========================================
        // --- 4. PROBLEM PANEL ---
        // ==========================================
        private void LoadProblemGrid()
        {
            try
            {
                DataTable dt = ProblemBL.GetProblemsDT();

                LoadProblemDashboardCounters(dt);

                dgvProblems.DataSource = dt;

                dgvProblems.Columns["ProblemID"].Visible = false;

                // ===== Problems Grid Column Styling & Layout =====
                SafeColumn(dgvProblems, "Title", "Title", 80);
                SafeColumn(dgvProblems, "DifficultyName", "Difficulty Level", 30);
                SafeColumn(dgvProblems, "Points", "Points", 30);
                SafeColumn(dgvProblems, "TargetDatabase", "Target Database", 50);
                SafeColumn(dgvProblems, "IsActive", "Status", 30);
                SafeColumn(dgvProblems, "CreatedBy", "Created By", 50);
                SafeColumn(dgvProblems, "CreatedAt", "Created At", 50);
                SafeColumn(dgvProblems, "UpdatedBy", "Updated By", 50);
                SafeColumn(dgvProblems, "UpdatedAt", "Updated At", 50);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load problem database list: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadProblemDashboardCounters(DataTable dt)
        {
            try
            {
                lblTotalProbValue.Text = dt.Rows.Count.ToString();

                // Active Problems
                DataView dvActive = new DataView(dt);
                dvActive.RowFilter = "IsActive = 1";
                lblActProbValue.Text = dvActive.Count.ToString();

                // InActive Problems
                DataView dvInActive = new DataView(dt);
                dvInActive.RowFilter = "IsActive = 0";
                lblInActProbValue.Text = dvInActive.Count.ToString();
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
            LoadProblemGrid();
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
            LoadProblemGrid();
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
            LoadProblemGrid();
        }

        // ==========================================
        // --- 5. CONTEST PANEL ---
        // ==========================================
        private void LoadContestGrid()
        {
            try
            {
                DataTable dt = ContestBL.GetContests();
                LoadContestDashboardCounters(dt);

                dgvContest.DataSource = dt;                

                dgvContest.Columns["ContestID"].Visible = false;

                // ===== Column Styling & Layout =====
                SafeColumn(dgvContest, "Title", "Title", 80);
                SafeColumn(dgvContest, "StartDate", "Start Date", 40);
                SafeColumn(dgvContest, "EndDate", "End Date", 40);
                SafeColumn(dgvContest, "TotalParticipants", "Participants", 50);
                SafeColumn(dgvContest, "CreatedBy", "Created By", 50);
                SafeColumn(dgvContest, "UpdatedBy", "Updated By", 50);
                SafeColumn(dgvContest, "CreatedAt", "Created At", 50);
                SafeColumn(dgvContest, "UpdatedAt", "Updated At", 50);
                SafeColumn(dgvContest, "ContestStatus", "Status", 40);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load contest data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadContestDashboardCounters(DataTable dt)
        {
            try
            {
                lblTotalContestValue.Text = dt.Rows.Count.ToString();

                // 2. Active Contests 
                DataView dvActive = new DataView(dt);
                dvActive.RowFilter = "ContestStatus = 'Running'";
                lblActContestValue.Text = dvActive.Count.ToString();

                // 3. Inactive / Ended Contests
                DataView dvInactive = new DataView(dt);
                dvInactive.RowFilter = "ContestStatus = 'Ended'";
                lblInActcontestValue.Text = dvInactive.Count.ToString();

                // 4. Upcoming Contests
                DataView dvUpcoming = new DataView(dt);
                dvUpcoming.RowFilter = "ContestStatus = 'Upcoming'";
                lblUpcommingContestValue.Text = dvUpcoming.Count.ToString();
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

            LoadContestGrid();
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

            LoadContestGrid();
        }

        // ==========================================
        // --- 6. SUBMISSIONS PANEL ---
        // ==========================================
        private void LoadSubmissionsGrid()
        {
            try {
                DataTable dt = SubmissionBL.GetSubmissions();

                // 1. Calculate the dashboard stats 
                LoadSubmissionDashboardCounters(dt);

                // 2. Bind the data to the grid
                dgvSubmissions.DataSource = dt;

                // 3. Make sure the DataGridView's AutoSize mode is set up
                dgvSubmissions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // 4. Hide Unnecceesry columns
                dgvSubmissions.Columns["SubmissionID"].Visible = false;
                dgvSubmissions.Columns["StudentID"].Visible = false;
                dgvSubmissions.Columns["ProblemID"].Visible = false;

                SafeColumn(dgvSubmissions, "StudentName", "Student Name", 50);
                SafeColumn(dgvSubmissions, "ProblemTitle", "Problem Title", 80);
                SafeColumn(dgvSubmissions, "TotalScore", "Total Score", 50);
                SafeColumn(dgvSubmissions, "AttemptNumber", "Attempt #", 30);
                SafeColumn(dgvSubmissions, "SubmittedAt", "Submitted At", 50);
                SafeColumn(dgvSubmissions, "Status", "Status", 50);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load submission data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadSubmissionDashboardCounters(DataTable dt)
        {
            try
            {
                // 1. Total Submissions
                totalsubValue.Text = dt.Rows.Count.ToString();

                // 2. Accepted Submissions 
                DataView dvAcc = new DataView(dt);
                dvAcc.RowFilter = "Status = 'Accepted'";
                AccSubValue.Text = dvAcc.Count.ToString();

                // 3. Rejected Submissions 
                DataView dvReg = new DataView(dt);
                dvReg.RowFilter = "Status <> 'Accepted'";
                RegSubValue.Text = dvReg.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error calculating submission stats: {ex.Message}", "Stats Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // --- 7. SLIDE BAR NAVIGATION ACTIONS ---
        // ==========================================
        private void btnHome_Click(object sender, EventArgs e)
        {
            LoadHomeGrid();
            ShowPanel(pnlHome, "Home");
        }
        private void btn_Admin_Click(object sender, EventArgs e)
        {
            LoadAdminGrid();
            ShowPanel(pnlSuperAdmin, "Admin Dashboard");
        }
        private void btn_students_Click(object sender, EventArgs e)
        {
            LoadStudentsGrid();
            ShowPanel(pnlStudent, "Student Management");
        }
        private void btn_problems_Click(object sender, EventArgs e)
        {
            LoadProblemGrid();
            ShowPanel(pnlProblems, "Problem Management");
        }
        private void btn_contests_Click(object sender, EventArgs e)
        {
            LoadContestGrid();
            ShowPanel(pnlContest, "Contest Management");
        }
        private void btnSubmissions_Click(object sender, EventArgs e)
        {
            LoadSubmissionsGrid();
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
        // Helping Function
        private void SafeColumn(DataGridView dgv, string col, string header, int weight)
        {
            if (dgv.Columns.Contains(col))
            {
                dgv.Columns[col].HeaderText = header;
                dgv.Columns[col].FillWeight = weight;
            }
        }
    }
}