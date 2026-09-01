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
        private bool isEditMode = false;

        public ContestPopupForm(int userID)
        {
            InitializeComponent();

            this.userID = userID;

            LoadCheckBox(clbProblem);
        }
        public ContestPopupForm(int userID, int contestID)
        {
            InitializeComponent();

            this.userID = userID;
            this.contestID = contestID;
            isEditMode = true;

            LoadCheckBox(clbProblem);
            LoadContest(contestID);            
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

                txtTitle.Text = c.Title;
                txtDescription.Text = c.Description;
                dtStartDate.Value = c.StartDate;
                dtEndDate.Value = c.EndDate;
                txtDuration.Text = c.Duration.ToString();

                List<ContestProblem> problems = ContestBL.GetProblemsByContestID(c.ContestID);
                List<int> problemID = problems.Select(p => p.ProblemID).ToList();

                for (int i = 0; i < clbProblem.Items.Count; i++)
                {
                    Problem problem = (Problem)clbProblem.Items[i];

                    if (problem == null) continue;

                    clbProblem.SetItemChecked(i, problemID.Contains(problem.ProblemID));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }     

        private void btnSaveProblem_Click(object sender, EventArgs e)
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

                if (!int.TryParse(txtDuration.Text.Trim(), out int duration))
                {
                    MessageBox.Show("Please enter valid Contest Duration.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (clbProblem.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Please select at least one problem.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Contest contest = null;
                if(isEditMode)
                {
                    // object for Update
                    contest = new Contest(contestID, title, duration, description, startDate, endDate, userID);

                    // Update Contest
                    ContestBL.UpdateContest(contest);

                    // Remove old Problems
                    ContestBL.DeleteProblemsByContestID(contest.ContestID);
                }
                else
                {
                    // Object for Insertion 
                    contest = new Contest(title, description, duration, startDate, endDate, userID);

                    // Create Contest
                    ContestBL.CreateContest(contest);
                }
               
                // Insert problems
                foreach (Problem p in clbProblem.CheckedItems)
                {
                    if (p == null) continue;

                    ContestProblem contestProblem = new ContestProblem(contest.ContestID, p.ProblemID);
                    ContestBL.AddProblem(contestProblem);
                }

                MessageBox.Show("Contest saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }
        private void ClearInputs()
        {
            txtTitle.Clear();
            txtDescription.Clear();
            dtStartDate.Value = DateTime.Now;
            dtEndDate.Value = DateTime.Now.AddHours(1);

            for (int i = 0; i < clbProblem.Items.Count; i++)
            {
                clbProblem.SetItemChecked(i, false);
            }
        }
    }
}
