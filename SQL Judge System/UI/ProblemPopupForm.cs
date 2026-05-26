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
    public partial class ProblemPopupForm : Form
    {
        private int userID;
        private int problemID;

        public ProblemPopupForm(int userID)
        {
            InitializeComponent();

            this.userID = userID;

            LoadCheckListBox(clbAddTags);
            LoadComboBox(cmbDifficulty);
            ShowAddPanel();
        }
        public ProblemPopupForm(int userID, int problemID)
        {
            InitializeComponent();

            this.userID = userID;
            this.problemID = problemID;

            LoadCheckListBox(clbUpdateTags);
            LoadComboBox(cmbUDifficulty);
            LoadProblem(problemID);
            ShowUpdatePanel();            
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

        // Loading Data
        private void LoadCheckListBox(CheckedListBox box)
        {
            try
            {
                box.DataSource = ProblemBL.GetProblemTags();
                box.DisplayMember = "Name";
                box.ValueMember = "ID";

                box.ClearSelected();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadComboBox(ComboBox box)
        {
            try
            {
                box.DataSource = ProblemBL.GetProblemDifficulties();
                box.DisplayMember = "Name";
                box.ValueMember = "ID";

                box.SelectedValue = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadProblem(int problemID)
        {
            try
            {
                Problem problem = ProblemBL.GetProblemByID(problemID);

                if (problem == null)
                {
                    MessageBox.Show("Problem not found.");
                    return;
                }

                txtUTitle.Text = problem.Title;
                txtUDescription.Text = problem.Description;
                txtUPoints.Text = problem.Points.ToString();

                cmbUDifficulty.SelectedValue = problem.DifficultyID;

                List<ProblemTagMap> tags = ProblemBL.GetProblemTags(problem.ProblemID);
                List<int> tagIDs = tags.Select(t => t.TagID).ToList();

                for (int i = 0; i < clbUpdateTags.Items.Count; i++)
                {
                    ProblemTag tag = (ProblemTag)clbUpdateTags.Items[i];

                    clbUpdateTags.SetItemChecked(i, tagIDs.Contains(tag.Id));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string title = txtTitle.Text.Trim();
                string description = txtDescription.Text.Trim();

                if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(description))
                {
                    MessageBox.Show("Please fill all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtPoints.Text.Trim(), out int points))
                {
                    MessageBox.Show("Please enter valid points.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbDifficulty.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select difficulty.");
                    return;
                }

                if (clbAddTags.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Please select at least one tag.");
                    return;
                }

                int diffucultyId = (int)cmbDifficulty.SelectedValue;

                Problem problem = new Problem(title, description, diffucultyId, points, userID);

                // INSERT PROBLEM
                ProblemBL.AddProblem(problem);

                // INSERT TAG MAPPINGS
                foreach (ProblemTag tag in clbAddTags.CheckedItems)
                {
                    ProblemTagMap problemTag = new ProblemTagMap(problem.ProblemID, tag.Id);
                    ProblemBL.MapProblemTag(problemTag);
                }

                MessageBox.Show("Problem created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void ClearAddInputs()
        {
            txtTitle.Clear();
            txtDescription.Clear();
            txtPoints.Clear();

            cmbDifficulty.SelectedIndex = -1;

            for (int i = 0; i < clbAddTags.Items.Count; i++)
            {
                clbAddTags.SetItemChecked(i, false);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string title = txtUTitle.Text.Trim();
                string description = txtUDescription.Text.Trim();

                if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(description))
                {
                    MessageBox.Show("Please fill all required fields.");
                    return;
                }

                if (!int.TryParse(txtUPoints.Text.Trim(), out int points))
                {
                    MessageBox.Show("Please enter valid points.");
                    return;
                }

                if (cmbDifficulty.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select difficulty.");
                    return;
                }

                if (clbUpdateTags.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Please select at least one tag.");
                    return;
                }

                int difficultyID = (int)cmbUDifficulty.SelectedValue;

                Problem problem = new Problem(problemID, title, description, difficultyID, points, userID);

                // UPDATE PROBLEM
                ProblemBL.UpdateProblem(problem);

                // DELETE OLD TAGS
                ProblemBL.DeleteByProblemID(problemID);

                // ADD NEW TAGS
                foreach (ProblemTag tag in clbUpdateTags.CheckedItems)
                {
                    ProblemTagMap problemTag = new ProblemTagMap(problemID, tag.Id);
                    ProblemBL.MapProblemTag(problemTag);
                }

                MessageBox.Show("Problem updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnUClear_Click(object sender, EventArgs e)
        {
            ClearUpdateInputs();
        }
        private void ClearUpdateInputs()
        {
            txtUTitle.Clear();
            txtUDescription.Clear();
            txtUPoints.Clear();

            cmbUDifficulty.SelectedIndex = -1;

            for (int i = 0; i < clbUpdateTags.Items.Count; i++)
            {
                clbUpdateTags.SetItemChecked(i, false);
            }
        }
    }
    }
