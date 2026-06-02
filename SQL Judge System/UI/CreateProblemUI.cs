using SQL_Judge_System.BL;
using SQL_Judge_System.DL;
using SQL_Judge_System.LookupDL;
using SQL_Judge_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Judge_System.UI
{
    public partial class CreateProblemUI : Form
    {
        private int userID;
        private int problemID;
        private bool isEditMode = false;
        private bool isQueryVerified = false;

        public CreateProblemUI(int userID)
        {
            InitializeComponent();
            this.userID = userID;

            LoadCheckListBox();
            LoadComboBox();

            cmbDatabase.SelectedIndexChanged += ResetQueryVerification;
        }
        public CreateProblemUI(int userID, int problemID)
        {
            InitializeComponent();

            this.userID = userID;
            this.problemID = problemID;
            this.isEditMode = true;

            LoadCheckListBox();
            LoadComboBox();
            LoadProblem(problemID);

            cmbDatabase.SelectedIndexChanged += ResetQueryVerification;
        }
        private void ResetQueryVerification(object sender, EventArgs e)
        {
            isQueryVerified = false;
        }

        // Loading Data
        private void LoadCheckListBox()
        {
            try
            {
                clbTags.DataSource = ProblemBL.GetProblemTags();
                clbTags.DisplayMember = "Name";
                clbTags.ValueMember = "ID";

                clbTags.ClearSelected();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadComboBox()
        {
            try
            {
                cmbDifficulty.DataSource = ProblemBL.GetProblemDifficulties();
                cmbDifficulty.DisplayMember = "Name";
                cmbDifficulty.ValueMember = "ID";

                cmbDifficulty.SelectedValue = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadSchemaTreeView(string databaseName)
        {
            // 1. Clear previous items to avoid duplication
            tvSchema.Nodes.Clear();

            // 2. Validate selection
            if (string.IsNullOrEmpty(databaseName)) return;

            try
            {
                // 3. Fetch data from the database
                DataTable schemaTable = SchemaDL.GetDatabaseSchema(databaseName);

                // 4. Freeze the UI to prevent flickering and boost loading speed
                tvSchema.BeginUpdate();

                string lastTableName = string.Empty;

                // 5. Process the sorted rows sequentially
                foreach (DataRow row in schemaTable.Rows)
                {
                    string tableName = row["TABLE_NAME"].ToString();

                    // Only add the table if it hasn't been added yet
                    if (tableName != lastTableName)
                    {
                        TreeNode tableNode = new TreeNode(tableName);
                        tvSchema.Nodes.Add(tableNode);
                        lastTableName = tableName;
                    }
                }

                // 6. Unfreeze the UI
                tvSchema.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading schema: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void LoadProblem(int problemID)
        {
            try
            {
                Problem problem = ProblemBL.GetProblemByID(problemID);

                if (problem == null)
                {
                    MessageBox.Show("Problem not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                txtProblemName.Text = problem.Title;
                txtDescription.Text = problem.Description;
                txtPoints.Text = problem.Points.ToString();
                txtMasterQuery.Text = problem.MasterQuery;
                cmbDatabase.SelectedItem = problem.TargetDatabase;
                cmbDifficulty.SelectedValue = problem.DifficultyID;

                List<ProblemTagMap> tags = ProblemBL.GetProblemTags(problem.ProblemID);
                List<int> tagIDs = tags.Select(t => t.TagID).ToList();

                for (int i = 0; i < clbTags.Items.Count; i++)
                {
                    ProblemTag tag = (ProblemTag)clbTags.Items[i];

                    clbTags.SetItemChecked(i, tagIDs.Contains(tag.Id));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       
        private void cmbDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDatabase.SelectedItem != null)
            {
                string selectedDatabase = cmbDatabase.SelectedItem.ToString();
                LoadSchemaTreeView(selectedDatabase);
            }
        }
        private void SaveSelectedTables()
        {
            List<string> selectedTables = new List<string>();

            foreach (TreeNode tableNode in tvSchema.Nodes)
            {
                if (tableNode.Checked)
                {
                    selectedTables.Add(tableNode.Text);
                }
            }

            ProblemBL.SaveCheckedTables(problemID, selectedTables);

            MessageBox.Show("Problem tables saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Button Click Events
        private void btnSaveProblem_Click(object sender, EventArgs e)
        {
            try
            {
                string title = txtProblemName.Text.Trim();
                string description = txtDescription.Text.Trim();
                string targetDatabase = cmbDatabase.SelectedItem?.ToString() ?? "";
                string masterQuery = txtMasterQuery.Text.Trim();


                if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(description) || string.IsNullOrWhiteSpace(targetDatabase) || string.IsNullOrWhiteSpace(masterQuery))
                {
                    MessageBox.Show("Please fill all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. CRITICAL GATEKEEPER: Force compilation check before writing to DB
                if (!isQueryVerified)
                {
                    MessageBox.Show("You cannot save this problem without verifying the Master Query.\n\nPlease click the 'Verify Master Query' button first.", "Compilation Verification Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtPoints.Text.Trim(), out int points))
                {
                    MessageBox.Show("Please enter valid points.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbDifficulty.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select difficulty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (clbTags.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Please select at least one tag.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (tvSchema.Nodes.Count == 0)
                {
                    MessageBox.Show("Please select a database to load schema.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check if any table node is checked
                bool hasCheckedTable = tvSchema.Nodes.Cast<TreeNode>().Any(t => t.Checked);
                if (!hasCheckedTable)
                {
                    MessageBox.Show("Please check at least one table to reveal to students.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int difficultyId = (int)cmbDifficulty.SelectedValue;

                Problem problem = new Problem(title, description, difficultyId, points, targetDatabase, masterQuery, userID);

                if(isEditMode)
                {
                    problem.ProblemID = problemID;
                    ProblemBL.UpdateProblem(problem);
                    ProblemBL.DeleteTagsByProblemID(problem.ProblemID);
                    ProblemBL.DeleteSchemaByProblemID(problem.ProblemID);
                }
                else
                {
                    // INSERT PROBLEM
                    ProblemBL.AddProblem(problem);
                    this.problemID = problem.ProblemID;
                }

                // INSERT TAG MAPPINGS
                foreach (ProblemTag tag in clbTags.CheckedItems)
                {
                    ProblemTagMap problemTag = new ProblemTagMap(problem.ProblemID, tag.Id);
                    ProblemBL.MapProblemTag(problemTag);
                }

                // INSERT SELECTED TABLES 
                SaveSelectedTables();

                MessageBox.Show("Problem created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnVerifyMasterQuery_Click(object sender, EventArgs e)
        {
            string masterQuery = txtMasterQuery.Text.Trim();
            string targetDatabase = cmbDatabase.SelectedItem?.ToString() ?? "";

            if (string.IsNullOrWhiteSpace(targetDatabase))
            {
                MessageBox.Show("Please select a Target Database first to evaluate the master query.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(masterQuery))
            {
                MessageBox.Show("Please enter the master query to validate.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                QueryRunnerBL.ValidateQuery(targetDatabase, masterQuery);
                this.isQueryVerified = true;

                MessageBox.Show("Query verified successfully! The compiler generated a valid matrix output.", "Verification Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                isQueryVerified = false;
                    
                MessageBox.Show($"Query Verification Failed:\n{ex.Message}", "SQL Compiler Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
 
