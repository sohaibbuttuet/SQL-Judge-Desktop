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

            LoadData();
            ShowAddPanel();
        }
        public ProblemPopupForm(int userID, int problemID)
        {
            InitializeComponent();

            this.userID = userID;
            this.problemID = problemID;

            LoadData();
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
            box.DataSource = ProblemTagsBL.GetAllTags();
            box.DisplayMember = "TagName";
            box.ValueMember = "TagID";
        }
        private void LoadComboBox(ComboBox comboBox)
        {
            comboBox.DataSource = ProblemDifficultyBL.GetAll();
            comboBox.DisplayMember = "DifficultyName";
            comboBox.ValueMember = "DifficultyID";
        }
        private void LoadData()
        {
            LoadCheckListBox(clbUpdateTags);
            LoadCheckListBox(clbAddTags);
            LoadComboBox(cmbDifficulty);
            LoadComboBox(cmbUDifficulty);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string title = txtTitle.Text.Trim();
                string description = txtDescription.Text.Trim();

                int difficultyID = Convert.ToInt32(cmbDifficulty.SelectedValue);

                int points;
                if (!int.TryParse(txtPoints.Text.Trim(), out points))
                {
                    MessageBox.Show("Please enter valid points.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(description))
                {
                    MessageBox.Show("Please fill all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (clbAddTags.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Please select at least one tag.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (ProblemBL.IsProblemExists(title, difficultyID))
                {
                    MessageBox.Show("Problem already exists.");
                    return;
                }

                Problem problem = new Problem(title, description, difficultyID, points, userID);
                ProblemBL.AddProblem(problem);

                foreach (var item in clbAddTags.CheckedItems)
                {
                    DataRowView row = (DataRowView)item;

                    int tagID = Convert.ToInt32(row["TagID"]);

                    ProblemTagMapBL.MapProblemTag(new ProblemTagMap(problemID, tagID));
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

                int difficultyID = Convert.ToInt32(cmbUDifficulty.SelectedValue);

                int points;
                if (!int.TryParse(txtUPoints.Text.Trim(), out points))
                {
                    MessageBox.Show("Please enter valid points.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(description))
                {
                    MessageBox.Show("Please fill all required fields.");
                    return;
                }
                if (clbUpdateTags.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Please select at least one tag.");
                    return;
                }

                Problem problem = new Problem(problemID, title, description, difficultyID, points, userID);
                ProblemBL.UpdateProblem(problem);

                // remove old tags
                ProblemTagMapBL.DeleteByProblemID(problemID);

                // add new tags
                foreach (var item in clbUpdateTags.CheckedItems)
                {
                    DataRowView row = (DataRowView)item;

                    int tagID = Convert.ToInt32(row["TagID"]);

                    ProblemTagMap map = new ProblemTagMap(problemID, tagID);

                    ProblemTagMapBL.MapProblemTag(map);
                }

                MessageBox.Show("Problem updated successfully.");

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

            cmbUDifficulty.SelectedIndex = -1;

            for (int i = 0; i < clbUpdateTags.Items.Count; i++)
            {
                clbUpdateTags.SetItemChecked(i, false);
            }
        }

    }
    }
