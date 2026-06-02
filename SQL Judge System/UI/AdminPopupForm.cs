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

namespace SQL_Judge_System.UI
{
    public partial class AdminPopupForm : Form
    {
        private int userId;
        private bool isEditMode = false;
        public AdminPopupForm()
        {
            InitializeComponent();
        }
        public AdminPopupForm(int userID)
        {
            InitializeComponent();

            this.userId = userID;
            isEditMode = true;

            LoadAdmin(userID);
        }

        private void LoadAdmin(int userID)
        {
            User user = UserBL.GetUserById(userID);

            txtName.Text = user.FullName;
            txtEmail.Text = user.Email;
            txtPassword.Text = user.Password;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text.Trim();
                string email = txtEmail.Text.Trim();
                string password = txtPassword.Text.Trim();

                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Please fill all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                User user = new User(name, email, password);

                if (!isEditMode)
                {
                    UserBL.SignUp(user);

                    // Get Admin RoleID
                    int AdminRoleID = UserBL.GetAdminRoleID();

                    // Assign Admin Role
                    UserRole userRole = new UserRole(user.UserID, AdminRoleID);
                    UserBL.AssignRoleToUser(userRole);
                }
                else
                {
                    user.UserID = userId;
                    UserBL.UpdateUser(user);
                }

                MessageBox.Show("Admin saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtName.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
        }      
    }
}
