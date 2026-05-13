using SQL_Judge_System.BL;
using SQL_Judge_System.LookupDL;
using SQL_Judge_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
                DataTable dt = SkillLevelDL.GetAll();

                cmbSkillLevel.DataSource = null;
                cmbSkillLevel.Items.Clear();

                cmbSkillLevel.DataSource = dt;
                cmbSkillLevel.DisplayMember = "LevelName";
                cmbSkillLevel.ValueMember = "SkillLevelID";

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
                string email = txtEmail.Text.Trim();
                string password = txtPassword.Text;
                string name = txtName.Text.Trim();

                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }

                if (isSignUpMode)
                {                    
                    string regNo = txtRegNo.Text.Trim();
                    int skillId = Convert.ToInt32(cmbSkillLevel.SelectedValue);

                    if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(regNo))
                    {
                        MessageBox.Show("Please fill in all student details.");
                        return;
                    }

                    // Create User object
                    User user = new User(name, email, password);
                    UserBL.SignUp(user);

                    // Create Student object
                    Student student = new Student(user.UserID, regNo, skillId);
                    StudentBL.RegisterStudent(student);

                    // Assign Role to User
                    int roleId = RoleDL.GetStudentRoleID();
                    UserRole userRole = new UserRole(user.UserID, roleId);
                    UserRoleBL.AssignRoleToUser(userRole);

                    MessageBox.Show("Student registered successfully!");
                    SetSignInMode();
                }
                else
                {
                    User user = new User(email, password);
                    if (UserBL.SignIn(user))
                    {
                        if (UserBL.IsUserSuperAdmin(user.UserID))
                        {
                            new AdminDashboardUI().Show();
                        }
                        else if (UserBL.IsUserAdmin(user.UserID))
                        {
                            new AdminDashboardUI().Show();
                        }
                        else
                        {
                            new StudentDashboardUI(user.UserID).Show();
                        }
                        this.Hide();
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
            if (cmbSkillLevel.Items.Count > 0) 
                cmbSkillLevel.SelectedIndex = -1;
        }
    } 
}
