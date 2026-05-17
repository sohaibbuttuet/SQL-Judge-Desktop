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
        public AdminPopupForm()
        {
            InitializeComponent();

            // default state 
            ShowAddPanel();
        }
        public AdminPopupForm(int userID)
        {
            InitializeComponent();

            this.userId = userID;
            LoadUserData(userID);

            // default state 
            ShowEditPanel();
        }

        public void ShowAddPanel()
        {
            addPanel.Visible = true;
            editPanel.Visible = false;
        }
        public void ShowEditPanel()
        {
            addPanel.Visible = false;
            editPanel.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtAddName.Text.Trim();
                string email = txtAddEmail.Text.Trim();
                string password = txtAddPassword.Text.Trim();

                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Please fill all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                User user = new User(name, email, password);
                UserBL.SignUp(user);

                // Get Admin RoleID
                int AdminRoleID = RoleBL.GetAdminRoleID();

                // Assign Admin Role
                UserRole userRole = new UserRole(user.UserID, AdminRoleID);
                UserRoleBL.AssignRoleToUser(userRole);

                MessageBox.Show("Admin added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAddInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAddClear_Click(object sender, EventArgs e)
        {
            ClearAddInputs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)  
        {
            try
            {
                string name = txtEditName.Text.Trim();
                string email = txtEditEmail.Text.Trim();
                string password = txtEditPassword.Text.Trim();

                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Please fill all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                User user = new User(userId, name, email, password);
                UserBL.UpdateUser(user);

                MessageBox.Show("Admin updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearEditInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEditClear_Click(object sender, EventArgs e)
        {
            ClearEditInputs();
        }

        private void LoadUserData(int userID)
        {
            User user = UserBL.GetUserById(userID);

            txtEditName.Text = user.FullName;
            txtEditEmail.Text = user.Email;
            txtEditPassword.Text = user.Password;
        }
        private void ClearAddInputs()
        {
            txtAddName.Clear();
            txtAddEmail.Clear();
            txtAddPassword.Clear();
        }
        private void ClearEditInputs()
        {           
            txtEditEmail.Clear();
            txtEditName.Clear(); 
            txtEditPassword.Clear();
        }
    }
}
