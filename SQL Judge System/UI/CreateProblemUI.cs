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

        // This method loads the problem details into the form fields when in edit mode. It fetches the problem data from the database using the provided problem ID, populates the text boxes, combo boxes, and checklist box with the existing values, and also loads the schema tree view based on the target database. 
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

                // Load form fields with existing problem data
                txtProblemName.Text = problem.Title;
                txtDescription.Text = problem.Description;
                txtPoints.Text = problem.Points.ToString();
                txtMasterQuery.Text = problem.MasterQuery;
                cmbDatabase.SelectedItem = problem.TargetDatabase;
                cmbDifficulty.SelectedValue = problem.DifficultyID;              

                // Load and check the tags associated with this problem
                List<ProblemTagMap> tags = ProblemBL.GetProblemTags(problem.ProblemID);
                List<int> tagIDs = tags.Select(t => t.TagID).ToList();

                for (int i = 0; i < clbTags.Items.Count; i++)
                {
                    ProblemTag tag = (ProblemTag)clbTags.Items[i];

                    clbTags.SetItemChecked(i, tagIDs.Contains(tag.Id));
                }

                // Load schema tree view based on target database
                if (!string.IsNullOrEmpty(problem.TargetDatabase))
                {
                    LoadTreeView(problem.TargetDatabase);
                }

                //  Fetch and automatically check the tables that were previously saved!
                List<string> savedTables = ProblemBL.GetSelectedTablesByProblemID(problemID).Select(t => t.TableName).ToList();
                CheckSavedTables(savedTables);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CheckSavedTables(List<string> savedTables)
        {
            if (tvSchema.Nodes.Count > 0 && savedTables != null)
            {
                TreeNode rootNode = tvSchema.Nodes[0];
                foreach (TreeNode tableNode in rootNode.Nodes)
                {
                    if (savedTables.Contains(tableNode.Text))
                    {
                        tableNode.Checked = true;
                    }
                }
            }
        }
        private void cmbDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDatabase.SelectedItem != null)
            {
                string selectedDatabase = cmbDatabase.SelectedItem.ToString();
                LoadTreeView(selectedDatabase);

                isQueryVerified = false;
            }
        }

        // TreeView Loading and Interaction
        private void LoadTreeView(string databaseName)
        {
            // Prevent UI flickering while loading a large database schema
            tvSchema.BeginUpdate();
            tvSchema.Nodes.Clear();

            TreeNode rootNode = new TreeNode(databaseName) { ImageIndex = 0 };

            try
            {
                // 1. Get selected Database schema
                DataTable schema = SchemaDL.GetDatabaseSchema(databaseName);

                // 2. Group columns by table using LINQ
                var tableGroups = schema.AsEnumerable().GroupBy(row => row.Field<string>("TABLE_NAME"));

                // 3. Build the read-only tree structure
                foreach (var group in tableGroups)
                {
                    TreeNode tableNode = new TreeNode(group.Key);

                    foreach (var row in group)
                    {
                        string colInfo = $"{row.Field<string>("COLUMN_NAME")} ({row.Field<string>("DATA_TYPE")})";
                        tableNode.Nodes.Add(new TreeNode(colInfo));
                    }

                    rootNode.Nodes.Add(tableNode);
                }

                tvSchema.Nodes.Add(rootNode);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not load reference schema: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                tvSchema.EndUpdate();
            }
        }
        private void tvSchema_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // Ensure the description box is focused before inserting text
            if (!txtDescription.Focused)
            {
                txtDescription.Focus();
            }

            // CASE 1: Admin double-clicked a TABLE (Level 1)
            if (e.Node.Level == 1)
            {
                string tableName = e.Node.Text;
                string template = $"{tableName}();\r\n";

                int cursorPosition = txtDescription.SelectionStart;
                txtDescription.SelectedText = template;

                // Place the cursor perfectly inside the brackets: ( | )
                txtDescription.SelectionStart = cursorPosition + tableName.Length + 1;
                txtDescription.Focus();
            }

            // CASE 2: Admin double-clicked a COLUMN (Level 2)
            else if (e.Node.Level == 2)
            {
                // e.Node.Text looks like "customer_id (int)". We only want "customer_id".
                // Splits "customer_id (int)" into parts["customer_id", "(int)"]
                string[] parts = e.Node.Text.Split(' ');
                string columnName = parts[0]; // Grabs the very first part

                // Get the current cursor position in the text box
                int cursorPosition = txtDescription.SelectionStart;

                // Smart Formatting: Determine if we need a comma separator
                // Look at the character right before the cursor. 
                // If it isn't an open parenthesis '(', it means a column is already there!
                if (cursorPosition > 0 && txtDescription.Text[cursorPosition - 1] != '(')
                {
                    columnName = ", " + columnName;
                }

                // 5. Inject the column name into the text box
                txtDescription.SelectedText = columnName;
                txtDescription.Focus();
            }
        }
        private List<string> GetCheckedTableNames()
        {
            List<string> checkedTablesList = new List<string>();

            // Verify that the tree view actually has nodes loaded
            if (tvSchema.Nodes.Count > 0)
            {
                TreeNode rootNode = tvSchema.Nodes[0]; // Level 0: Database Root

                // Loop through all child nodes under the root (Level 1: Tables)
                foreach (TreeNode tableNode in rootNode.Nodes)
                {
                    if (tableNode.Checked)
                    {
                        checkedTablesList.Add(tableNode.Text); // Grab the table name string
                    }
                }
            }

            return checkedTablesList;
        }
        private bool HasCheckedTables()
        {
            if (tvSchema.Nodes.Count == 0)
            {
                MessageBox.Show("Please select a database to load schema.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (tvSchema.Nodes[0].Nodes.Count == 0)
            {
                MessageBox.Show("The selected database does not contain any tables. Please select a different database.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (GetCheckedTableNames().Count == 0)
            {
                MessageBox.Show("Please check at least one table from the reference schema tree.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
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

                // Force compilation check before writing to DB
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

                if(!HasCheckedTables())
                {
                    return; // If validation fails, exit the method early
                }

                int difficultyId = (int)cmbDifficulty.SelectedValue;

                Problem problem = new Problem(title, description, difficultyId, points, targetDatabase, masterQuery, userID);

                if (isEditMode)
                {
                    problem.ProblemID = problemID;
                    ProblemBL.UpdateProblem(problem);
                    ProblemBL.DeleteTagsByProblemID(problem.ProblemID);
                    ProblemBL.DeleteCheckedTables(problem.ProblemID); // Clear old table mappings before saving new ones
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

                // Get the list of Checked Tables from the TreeView
                List<string> tablesToSave = GetCheckedTableNames();

                // Save the checked tables to the database for this problem
                if (tablesToSave.Count > 0)
                {
                    ProblemBL.SaveCheckedTables(problem.ProblemID, tablesToSave);
                }

                MessageBox.Show("Problem saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            if (string.IsNullOrWhiteSpace(targetDatabase) || string.IsNullOrWhiteSpace(masterQuery))
            {
                MessageBox.Show("Please select database and fill the master query fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if(!HasCheckedTables()) return; // If validation fails, exit the method early

                // Get the list of allowed tables for this problem
                List<string> allowedTableNames = GetCheckedTableNames();

                DataTable dt = QueryRunnerBL.ExecuteQuery(targetDatabase, masterQuery, allowedTableNames);
                if (dt == null)
                {
                    MessageBox.Show("The query did not return any results. Please ensure your master query is correct and returns a valid result set.", "Verification Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

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