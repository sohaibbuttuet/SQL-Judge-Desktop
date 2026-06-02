using SQL_Judge_System.BL;
using SQL_Judge_System.LookupDL;
using SQL_Judge_System.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SQL_Judge_System.UI
{
    public partial class AuthForm : Form
    {
        private bool isSignUpMode = false;

        public AuthForm()
        {
            InitializeComponent();
            LoadSkillLevels();
            SetSignInMode();
        }

        // LOAD SKILL LEVELS
        private void LoadSkillLevels()
        {
            try
            {
                cmbSkillLevel.DataSource = SkillLevelDL.GetAll();
                cmbSkillLevel.DisplayMember = "Name";
                cmbSkillLevel.ValueMember = "Id";

                cmbSkillLevel.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load skill levels.\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // TOGGLE LOGIN / SIGNUP
        private void lnkToggle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearFields();

            if (isSignUpMode)
                SetSignInMode();
            else
                SetSignUpMode();
        }

        // SIGN UP MODE
        private void SetSignUpMode()
        {
            isSignUpMode = true;

            lblTitle.Text = "Create Account";
            lblSubtitle.Text = "Register as Student";
            btnMainAction.Text = "SIGN UP";
            lnkToggle.Text = "Already have an account? Sign In";

            pnlStudentExtra.Visible = true;

            btnMainAction.Location = new Point(45, pnlStudentExtra.Bottom + 25);

            lnkToggle.Location = new Point(45, btnMainAction.Bottom + 15);

            this.ClientSize = new Size(520, 760);
        }

        // SIGN IN MODE
        private void SetSignInMode()
        {
            isSignUpMode = false;

            lblTitle.Text = "Welcome Back";
            lblSubtitle.Text = "Sign in to continue";

            btnMainAction.Text = "LOGIN";

            lnkToggle.Text = "Don't have an account? Sign Up";

            pnlStudentExtra.Visible = false;

            btnMainAction.Location = new Point(45, txtPassword.Bottom + 45);

            lnkToggle.Location = new Point(45, btnMainAction.Bottom + 15);

            this.ClientSize = new Size(520, 720);
        }

        // MAIN BUTTON CLICK
        private void btnMainAction_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text.Trim();
                string email = txtEmail.Text.Trim();
                string password = txtPassword.Text;

                if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show(
                        "Please fill in all required fields.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                if (isSignUpMode)
                {
                    string regNo = txtRegNo.Text.Trim();

                    if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(regNo))
                    {
                        MessageBox.Show(
                            "Please fill all student details.",
                            "Validation",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );

                        return;
                    }

                    if (cmbSkillLevel.SelectedIndex == -1 || cmbSkillLevel.SelectedValue == null)
                    {
                        MessageBox.Show("Please select skill level.");
                        return;
                    }

                    int skillLevelID = Convert.ToInt32(cmbSkillLevel.SelectedValue);

                    // CREATE USER
                    User user = new User(name, email, password);
                    UserBL.SignUp(user);

                    // REGISTER STUDENT
                    Student student = new Student(user.UserID, regNo, skillLevelID);
                    StudentBL.RegisterStudent(student);

                    // ASSIGN ROLE
                    int roleId = UserBL.GetStudentRoleID();

                    UserRole userRole = new UserRole(user.UserID, roleId);
                    UserBL.AssignRoleToUser(userRole);

                    MessageBox.Show("Student registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SetSignInMode();
                }
                else
                {
                    User user = UserBL.SignIn(email, password);

                    if (user != null)
                    {
                        this.Hide();

                        if (UserBL.IsUserStudent(user.UserID))
                        {
                            StudentDashboardUI studentDashboard = new StudentDashboardUI(user.UserID);
                            studentDashboard.Show();
                        }
                        else
                        {
                            AdminDashboardUI adminDashboard =  new AdminDashboardUI(user.UserID);
                            adminDashboard.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An error occurred during authentication.\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // CLEAR INPUT FIELDS
        private void ClearFields()
        {
            txtEmail.Clear();
            txtPassword.Clear();
            txtName.Clear();
            txtRegNo.Clear();

            cmbSkillLevel.SelectedIndex = -1;
        }
    }
}