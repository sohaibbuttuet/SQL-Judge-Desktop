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

            ShowAddPanel();
            LoadCheckBox(clbAProblem);
        }
        public ContestPopupForm(int userID, int contestID)
        {
            InitializeComponent();

            this.userID = userID;
            this.contestID = contestID;

            ShowUpdatePanel();
            LoadContest(contestID);
            LoadCheckBox(clbUProblem);
        }

        private void LoadCheckBox(CheckedListBox box)
        {
            try
            {
                box.DataSource = ProblemBL.GetProblems();
                box.DisplayMember = "Title";
                box.ValueMember = "ProblemID";

                box.ClearSelected();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Failed to load problems.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadContest(int contestID)
        {
            try
            {
                Contest c = ContestBL.GetContestByID(contestID);

                if (c == null)
                {
                    MessageBox.Show("Contest not found.");
                    return;
                }

                txtUTitle.Text = c.Title;
                txtUDescription.Text = c.Description;

                dtp_UStartDate.Value = c.StartDate;
                dtp_UEndDate.Value = c.EndDate;

                List<ContestProblem> problems = ContestBL.GetProblemsByContestID(c.ContestID);
                List<int> problemID = problems.Select(p => p.ProblemID).ToList();

                for (int i = 0; i < clbUProblem.Items.Count; i++)
                {
                    var problem = clbUProblem.Items[i] as Problem;

                    if (problem == null) continue;

                    clbUProblem.SetItemChecked(i, problemID.Contains(problem.ProblemID));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowAddPanel()
        {
            addPanel.Visible = true;
            updatePanel.Visible = false;
        }
        private void ShowUpdatePanel()
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

                if (clbAProblem.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Please select at least one problem.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Contest contest = new Contest(title, description, startDate, endDate, userID);

                // Create Contest
                ContestBL.CreateContest(contest);

                // Insert problems
                foreach (Problem p in clbAProblem.CheckedItems)
                {
                    if (p == null) continue;

                    ContestProblem contestProblem = new ContestProblem(contest.ContestID, p.ProblemID);
                    ContestBL.AddProblem(contestProblem);
                }

                MessageBox.Show("Contest created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
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

                if (clbUProblem.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Please select at least one problem.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Contest contest = new Contest(contestID, title, description, startDate, endDate, userID);

                // Update Contest
                ContestBL.UpdateContest(contest);

                // Remove old Problems
                ContestBL.DeleteProblemsByContestID(contest.ContestID);

                // Insert problems
                foreach (Problem p in clbUProblem.CheckedItems)
                {
                    if (p == null) continue;

                    ContestProblem contestProblem = new ContestProblem(contest.ContestID, p.ProblemID);
                    ContestBL.AddProblem(contestProblem);
                }

                MessageBox.Show("Contest updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
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

            for (int i = 0; i < clbAProblem.Items.Count; i++)
            {
                clbAProblem.SetItemChecked(i, false);
            }
        }
        private void ClearUpdateInputs()
        {
            txtUTitle.Clear();
            txtUDescription.Clear();
            dtp_UStartDate.Value = DateTime.Now;
            dtp_UEndDate.Value = DateTime.Now.AddHours(1);

            for (int i = 0; i < clbUProblem.Items.Count; i++)
            {
                clbUProblem.SetItemChecked(i, false);
            }
        } 
    }
}
