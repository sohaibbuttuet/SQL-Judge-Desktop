using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQL_Judge_System.Models;
using SQL_Judge_System.BL;

namespace SQL_Judge_System.UI
{
    public partial class ContestPopupForm : Form
    {
        private int userID;
        private int contestID;

        public ContestPopupForm(int userID)
        {
            InitializeComponent();

            this.userID = userID;

            // Default View
            ShowAddPanel();
        }
        public ContestPopupForm(int userID, int contestID)
        {
            InitializeComponent();

            this.userID = userID;
            this.contestID = contestID;

            // Default View
            ShowUpdatePanel();
        }

        public void ShowAddPanel()
        {
            addPanel.Visible = true;
            updatePanel.Visible = false;
        }
        public void ShowUpdatePanel()
        {
            addPanel.Visible = false;
            updatePanel.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string title = txtTitle.Text;
                string description = txtDescription.Text;
                DateTime startDate = dtStartDate.Value;
                DateTime endDate = dtEndDate.Value;

                if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(description))
                {
                    MessageBox.Show("Please fill all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Contest contest = new Contest(title, description, startDate, endDate, userID);
                ContestBL.CreateContest(contest);

                MessageBox.Show("Contest created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ClearAddInputs();
        }
        private void btnAddClear_Click(object sender, EventArgs e)
        {
            ClearAddInputs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try {
                string title = txtUTitle.Text;
                string description = txtUDescription.Text;
                DateTime startDate = dtp_UStartDate.Value;
                DateTime endDate = dtp_UEndDate.Value;

                if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(description))
                {
                    MessageBox.Show("Please fill all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }                  

                Contest contest = new Contest(contestID, title, description, startDate, endDate, userID);
                ContestBL.UpdateContest(contest, userID);

                MessageBox.Show("Contest updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ClearUpdateInputs();
        }
        private void btnUClear_Click(object sender, EventArgs e)
        {
            ClearUpdateInputs();
        }

        private void ClearAddInputs()
        {
            txtTitle.Clear();
            txtDescription.Clear();
            dtStartDate.Value = DateTime.Now;
            dtEndDate.Value = DateTime.Now.AddHours(1);
        }
        private void ClearUpdateInputs()
        {
            txtUTitle.Clear();
            txtUDescription.Clear();
            dtp_UStartDate.Value = DateTime.Now;
            dtp_UEndDate.Value = DateTime.Now.AddHours(1);
        } 
    }
}
