using SQL_Judge_System.BL;
using SQL_Judge_System.DL;
using SQL_Judge_System.LookupDL;
using SQL_Judge_System.Models;
using System;
using System.Windows.Forms;

namespace SQL_Judge_System.UI
{
    public partial class SettingsForm : Form
    {
        int userID;
        User user = null;
        Student student = null;

        public SettingsForm(int userID)
        {
            InitializeComponent();

            pnlextrastd.Visible = false;
            this.userID = userID;

            LoadData();
        }

        //  LOAD DATA
       
        private void SettingsPanelUI_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            LoadData();
            LoadSettingsProfile();          
        }        
        private void LoadComboBoxes()
        {
            try
            {
                cmbskill.DataSource = SkillLevelDL.GetAll();
                cmbskill.DisplayMember = "Name";
                cmbskill.ValueMember = "ID";
            } 
            catch(Exception ex)
            {
                MessageBox.Show("Failed to load skill levels: " + ex.Message);
            }
        }
        private void LoadData()
        {
            try
            {
                user = UserBL.GetUserById(userID);
                student = StudentBL.GetStudentByUserID(userID);
            }
            catch (Exception ex)
            {
                throw new Exception("Erroe while loading data: " + ex.Message);
            }
        }
        private void LoadSettingsProfile()
        {
            try
            {
                bool isStudent = UserBL.IsUserStudent(user.UserID);
                if (isStudent)
                {
                    txtregno.Text = student.RegistrationNumber;
                    cmbskill.SelectedValue = student.SkillLevelID;
                    pnlextrastd.Visible = true;
                }
                else
                {
                    pnlextrastd.Visible = false;
                }

                txtSettingsFullName.Text = user.FullName;
                txtSettingsEmail.Text = user.Email;
                txtSettingsRole.Text = UserRoleDL.GetRoleNameByUserID(user.UserID);
                txtSettingsCreatedAt.Text = user.CreatedAt.ToString("dd MMM yyyy");
                txtSettingsStatus.Text = user.IsActive ? "Active" : "Inactive";

                // Colour the status field dynamically
                txtSettingsStatus.ForeColor = user.IsActive
                    ? System.Drawing.Color.FromArgb(52, 211, 153)    // emerald
                    : System.Drawing.Color.FromArgb(251, 113, 133);  // rose

                // Clear password fields every open
                ClearPasswordInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load profile data: " + ex.Message);
            }
        }

        //  SAVE PROFILE
        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            try
            {
                string newFullName = txtSettingsFullName.Text.Trim();
                string newEmail = txtSettingsEmail.Text.Trim();

                if (string.IsNullOrEmpty(newFullName) || string.IsNullOrEmpty(newEmail))
                {
                    MessageBox.Show("Name and Email cannot be empty.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Update User
                UserBL.UpdateProfile(new User(user.UserID, newFullName, newEmail));

                // Update Student
                bool isStudent = UserBL.IsUserStudent(user.UserID);
                if (isStudent && student != null)
                {
                    string regNo = txtregno.Text.Trim();
                    if (cmbskill.SelectedValue == null || (int)cmbskill.SelectedValue == -1)
                    {
                        MessageBox.Show("Please select a valid skill level.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    
                    student.SkillLevelID = (int)cmbskill.SelectedValue;
                    student.RegistrationNumber = regNo;

                    StudentBL.UpdateStudent(student);
                }

                MessageBox.Show("Profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                LoadSettingsProfile();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update profile: " + ex.Message);
            }
        }

        //  CHANGE PASSWORD
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                string currentPassword = txtCurrentPassword.Text;
                string newPassword = txtNewPassword.Text;
                string confirmPassword = txtConfirmPassword.Text;

                if (string.IsNullOrEmpty(currentPassword))
                {
                    MessageBox.Show("Please enter your current password.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCurrentPassword.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(newPassword))
                {
                    MessageBox.Show("Please enter a new password.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNewPassword.Focus();
                    return;
                }

                if (newPassword.Length < 6)
                {
                    MessageBox.Show("New password must be at least 6 characters long.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNewPassword.Focus();
                    return;
                }

                if (newPassword != confirmPassword)
                {
                    MessageBox.Show("New password and confirm password do not match.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtConfirmPassword.Focus();
                    return;
                }

                bool currentPasswordCorrect = UserBL.VerifyPassword(user.UserID, currentPassword);

                if (!currentPasswordCorrect)
                {
                    MessageBox.Show("Current password is incorrect.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCurrentPassword.Focus();
                    return;
                }

                UserBL.ChangePassword(user.UserID, newPassword);

                MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearPasswordInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to change password: " + ex.Message);
            }
        }
        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassword.Text) || string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                lblPasswordMatchHint.Text = string.Empty;
                return;
            }

            if (txtNewPassword.Text == txtConfirmPassword.Text)
            {
                lblPasswordMatchHint.Text = "✔  Passwords match";
                lblPasswordMatchHint.ForeColor = System.Drawing.Color.FromArgb(52, 211, 153);
            }
            else
            {
                lblPasswordMatchHint.Text = "✘  Passwords do not match";
                lblPasswordMatchHint.ForeColor = System.Drawing.Color.FromArgb(251, 113, 133);
            }
        }

        // CLOSE FORM
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Helping Functions
        private void ClearPasswordInputs()
        {
            txtCurrentPassword.Text = string.Empty;
            txtNewPassword.Text = string.Empty;
            txtConfirmPassword.Text = string.Empty;
            lblPasswordMatchHint.Text = string.Empty;
        }       
    }
}