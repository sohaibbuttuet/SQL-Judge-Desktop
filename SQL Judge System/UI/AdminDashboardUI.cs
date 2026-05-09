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
            ShowPanel(pnlAdmin, "Admin Dashboard");
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadAdminData();
            LoadStudentData();
            LoadProblemData();
        }

        // --- ADMIN PANEL ---
        private void LoadAdminData()
        {
            LoadAdminDashboard();
            LoadAdmin();
        }
        private void LoadAdmin()
        {
            dgvAdmins.DataSource = AdminDashboardBL.GetAdminList();          

            dgvAdmins.Columns["UserID"].FillWeight = 20;
            dgvAdmins.Columns["Email"].FillWeight = 40;
            dgvAdmins.Columns["IsActive"].FillWeight = 20;
            dgvAdmins.Columns["CreatedAt"].FillWeight = 50;
            dgvAdmins.Columns["Password"].Visible = false; // Hide password column for security

            dgvAdmins.Columns["UserID"].HeaderText = "ID";
            dgvAdmins.Columns["Email"].HeaderText = "Email";
            dgvAdmins.Columns["IsActive"].HeaderText = "Status";
            dgvAdmins.Columns["CreatedAt"].HeaderText = "Created At";
        }
        public void LoadAdminDashboard()
        {
            lblStdValue.Text = AdminDashboardBL.TotalStudents().ToString();
            lbladminValue.Text = AdminDashboardBL.TotalAdmins().ToString();
            lblContestValue.Text = AdminDashboardBL.TotalContests().ToString();
            lblProblemValue.Text = AdminDashboardBL.TotalProblems().ToString();            
        }


        // --- STUDENT PANEL ---
        private void LoadStudentData()
        {
            LoadStudents();
            LoadStudentDashboard();
        }
        private void LoadStudents()
        {
            dgvStudents.DataSource = AdminDashboardBL.GetStudentsForAdmin();

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
            lbl_stdValue.Text = AdminDashboardBL.TotalStudents().ToString();
            lblactstdValue.Text = AdminDashboardBL.ActiveStudents().ToString();
            lblinactstdValue.Text = AdminDashboardBL.InactiveStudents().ToString();
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
                        AdminDashboardBL.DeactivateUser(studentID);
                        MessageBox.Show("Student deactivated successfully.");
                    }
                }
                else
                {
                    AdminDashboardBL.ActivateUser(studentID);
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
            dgvProblems.DataSource = AdminDashboardBL.ProblemsList();
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
            lblTotalProbValue.Text = AdminDashboardBL.TotalProblems().ToString();
            lblActProbValue.Text = AdminDashboardBL.ActiveProblems().ToString();
            lblInActProbValue.Text = AdminDashboardBL.InactiveProblems().ToString();
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
                        AdminDashboardBL.DeactivateProblem(problemID);
                        MessageBox.Show("Problem deactivated successfully.");
                    }
                }
                else
                {
                    AdminDashboardBL.ActivateProblem(problemID);
                    MessageBox.Show("Problem activated successfully.");
                }
                RefreshData();
            }
            else
            {
                MessageBox.Show("Please select a problem");
            }
        }

        // Slide Bar Menu Buttons
        private void btnHome_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlAdmin, "Admin Dashboard");
        }
        private void btn_students_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlStudent, "Student Management");
        }
        private void btn_problems_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlProblem, "Problem Management");
        }
        private void btn_contests_Click(object sender, EventArgs e)
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
        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void RefreshData()
        {
            // Code to reload Admin data from Database into dgvAdmins
            // and update card values (lblTotalVal, etc.)
        }
        private void ShowPanel(Panel targetPanel, string headerText)
        {
            // 1. Hide all panels first
            pnlAdmin.Visible = false;
            pnlProblem.Visible = false;
            pnlStudent.Visible = false;

            // 2. Show the target panel
            targetPanel.Visible = true;

            // 3. Ensure it fills the space and is on top
            targetPanel.Dock = DockStyle.Fill;
            targetPanel.BringToFront();

            // 4. Update the header label
            lblTitle.Text = headerText;
        }
    }
}