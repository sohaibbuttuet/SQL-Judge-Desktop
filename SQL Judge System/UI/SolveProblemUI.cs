using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SQL_Judge_System.UI
{
    public partial class SolveProblemUI : Form
    {
        private int studentID;
        public SolveProblemUI(int studentID)
        {
            InitializeComponent();

            this.studentID = studentID;

            // Smooth Rendering
            this.DoubleBuffered = true;
            this.KeyPreview = true;

            // Optional startup setup
            SetupUI();
        }

        // =========================================================
        // UI SETUP
        // =========================================================
        private void SetupUI()
        {
            // Difficulty Combo Default
            if (cmbDifficulty.Items.Count > 0)
                cmbDifficulty.SelectedIndex = 0;

            // SQL Editor Default
            rtbSQLEditor.Text =
@"-- Write your SQL query here

SELECT * FROM Users;";

            // Status
            lblOnlineStatus.Text = "● Online";

            // Result badge
            lblResultBadge.Text = "";

            // Cursor for Buttons
            SetButtonCursor(this);

            // Grid Setup
            SetupGrid(dgvProblems);
            SetupGrid(dgvOutput);
        }

        private void SetupGrid(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;

            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.EnableHeadersVisualStyles = false;

            dgv.BackgroundColor = Color.FromArgb(32, 37, 63);
            dgv.GridColor = Color.FromArgb(46, 52, 88);

            dgv.DefaultCellStyle.BackColor =
                Color.FromArgb(32, 37, 63);

            dgv.DefaultCellStyle.ForeColor =
                Color.FromArgb(220, 223, 255);

            dgv.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(45, 52, 86);

            dgv.DefaultCellStyle.SelectionForeColor =
                Color.White;

            dgv.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(24, 29, 56);

            dgv.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.FromArgb(139, 146, 184);

            dgv.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);

            dgv.ColumnHeadersHeight = 36;
        }

        private void SetButtonCursor(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is Button)
                    c.Cursor = Cursors.Hand;

                SetButtonCursor(c);
            }
        }

        // =========================================================
        // FORM LOAD
        // =========================================================
        private void SolveProblemUI_Load(object sender, EventArgs e)
        {
            LoadProblems();
        }

        // =========================================================
        // LOAD PROBLEMS
        // =========================================================
        private void LoadProblems()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Title");
            dt.Columns.Add("Difficulty");

            dt.Rows.Add("1", "Select All Users", "Easy");
            dt.Rows.Add("2", "Top Customers", "Medium");
            dt.Rows.Add("3", "Monthly Sales Report", "Hard");

            dgvProblems.DataSource = dt;
        }

        // =========================================================
        // PROBLEM SELECTION
        // =========================================================
        private void dgvProblems_SelectionChanged(
            object sender,
            EventArgs e)
        {
            if (dgvProblems.CurrentRow == null)
                return;

            string title =
                dgvProblems.CurrentRow.Cells["Title"].Value.ToString();

            string difficulty =
                dgvProblems.CurrentRow.Cells["Difficulty"].Value.ToString();

            lblProblemName.Text = title;
            lblDifficultyBadge.Text = difficulty;

            rtbProblemDesc.Text =
@"Write an SQL query according to the problem statement.

Requirements:
- Use proper SQL syntax
- Return correct records
- Optimize your query if possible";
        }

        // =========================================================
        // RUN QUERY
        // =========================================================
        private void btnRunQuery_Click(object sender, EventArgs e)
        {
            try
            {
                string query = rtbSQLEditor.Text.Trim();

                if (string.IsNullOrWhiteSpace(query))
                {
                    MessageBox.Show(
                        "Please write an SQL query.",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // Demo Output Table
                DataTable dt = new DataTable();

                dt.Columns.Add("ID");
                dt.Columns.Add("Name");
                dt.Columns.Add("Email");

                dt.Rows.Add("1", "Ali", "ali@gmail.com");
                dt.Rows.Add("2", "Ahmed", "ahmed@gmail.com");

                dgvOutput.DataSource = dt;

                lblResultBadge.ForeColor =
                    Color.FromArgb(62, 207, 142);

                lblResultBadge.Text =
                    $"Query Executed Successfully • {dt.Rows.Count} rows";
            }
            catch (Exception ex)
            {
                lblResultBadge.ForeColor =
                    Color.FromArgb(224, 90, 90);

                lblResultBadge.Text = "Execution Failed";

                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // SUBMIT QUERY
        // =========================================================
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(rtbSQLEditor.Text))
                {
                    MessageBox.Show(
                        "Query cannot be empty.",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                MessageBox.Show(
                    "Solution submitted successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // CLEAR EDITOR
        // =========================================================
        private void btnClearEditor_Click(
            object sender,
            EventArgs e)
        {
            rtbSQLEditor.Clear();

            rtbSQLEditor.Text =
@"-- Write your SQL query here

SELECT ";
        }

        // =========================================================
        // CLEAR OUTPUT
        // =========================================================
        private void btnClearOutput_Click(
            object sender,
            EventArgs e)
        {
            dgvOutput.DataSource = null;
            dgvOutput.Rows.Clear();
            dgvOutput.Columns.Clear();

            lblResultBadge.Text = "";
        }

        // =========================================================
        // FILTER DIFFICULTY
        // =========================================================
        private void cmbDifficulty_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            // Future filtering logic
        }

        // =========================================================
        // SQL EDITOR LINE/COLUMN
        // =========================================================
        private void rtbSQLEditor_KeyUp(
            object sender,
            KeyEventArgs e)
        {
            int index = rtbSQLEditor.SelectionStart;

            int line =
                rtbSQLEditor.GetLineFromCharIndex(index);

            int column =
                index -
                rtbSQLEditor.GetFirstCharIndexFromLine(line);

            lblLineCol.Text =
                $"Ln {line + 1}, Col {column + 1}";
        }

        // =========================================================
        // NAVIGATION BUTTONS
        // =========================================================
        private void btn_home_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Navigate to Home");
        }

        private void btn_contest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Navigate to Contest");
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Generate Report");
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open Settings");
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to logout?",
                    "Logout",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}