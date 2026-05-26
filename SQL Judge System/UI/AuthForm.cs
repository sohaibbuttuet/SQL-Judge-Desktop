using SQL_Judge_System.BL;
using SQL_Judge_System.LookupDL;
using SQL_Judge_System.Models;
using System;
using System.Collections.Generic;
using System.Data;
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
                MessageBox.Show("Failed to load skill levels.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // TOGGLE MODE
        private void lnkToggle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearFields();

            if (isSignUpMode) 
                SetSignInMode();
            else 
                SetSignUpMode();
        }

        private void SetSignUpMode()
        {
            isSignUpMode = true;
            lblTitle.Text = "Student Registration";
            btnMainAction.Text = "SIGN UP";
            lnkToggle.Text = "Already have an account? Sign In";

            // Show the panel containing extra fields
            pnlStudentExtra.Visible = true;

            // Shift buttons down to make room for the panel
            btnMainAction.Location = new Point(50, pnlStudentExtra.Bottom + 20);
            lnkToggle.Location = new Point(50, btnMainAction.Bottom + 15);

            this.ClientSize = new Size(400, 650);
        }

        private void SetSignInMode()
        {
            isSignUpMode = false;
            lblTitle.Text = "Sign In";
            btnMainAction.Text = "LOGIN";
            lnkToggle.Text = "Don't have an account? Sign Up";

            // Hide the panel
            pnlStudentExtra.Visible = false;

            // Move buttons up (immediately under the password field)
            btnMainAction.Location = new Point(50, txtPassword.Bottom + 40);
            lnkToggle.Location = new Point(50, btnMainAction.Bottom + 15);

            this.ClientSize = new Size(400, 450);
        }

        private void btnMainAction_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text.Trim();
                string email = txtEmail.Text.Trim();
                string password = txtPassword.Text;                

                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(email) || !email.Contains("@") || !email.Contains("."))
                {
                    MessageBox.Show("Invalid email format.");
                    return;
                }
                    
                // =========================
                // SIGN UP
                // =========================
                if (isSignUpMode)
                {                    
                    string regNo = txtRegNo.Text.Trim();

                    if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(regNo))
                    {
                        MessageBox.Show("Please fill all student details.");
                        return;
                    }

                    if (cmbSkillLevel.SelectedValue == null)
                    {
                        MessageBox.Show("Please select skill level.");
                        return;
                    }

                    int skillLevelID = Convert.ToInt32(cmbSkillLevel.SelectedValue);

                    // Create User object
                    User user = new User(name, email, password);
                    UserBL.SignUp(user);

                    // Create Student object
                    Student student = new Student(user.UserID, regNo, skillLevelID);
                    StudentBL.RegisterStudent(student);

                    // Assign Role to User
                    int roleId = UserBL.GetStudentRoleID();

                    UserRole userRole = new UserRole(user.UserID, roleId);
                    UserBL.AssignRoleToUser(userRole);

                    MessageBox.Show("Student registered successfully!");
                    SetSignInMode();
                }

                // =========================
                // LOGIN
                // =========================
                else
                {
                    User user = UserBL.SignIn(email, password);

                    if (user != null)
                    {
                        if (UserBL.IsUserSuperAdmin(user.UserID) || UserBL.IsUserAdmin(user.UserID))
                        {
                            new AdminDashboardUI(user.UserID).Show();
                        }
                        else
                        {
                            new StudentDashboardUI(user.UserID).Show();
                        }

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
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
