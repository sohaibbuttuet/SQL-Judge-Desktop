using MySqlX.XDevAPI.Relational;
using SQL_Judge_System.BL;
using SQL_Judge_System.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SQL_Judge_System.UI
{
    public partial class SolveProblemUI : Form
    {
        private readonly int studentID;
        public SolveProblemUI(int studentID)
        {
            InitializeComponent();

            this.studentID = studentID;

            cmbDifficulty.SelectedIndex = 0;

            // Smooth Rendering
            this.DoubleBuffered = true;
            this.KeyPreview = true;
        }

        // Load Problems according to filter
        private void cmbDifficulty_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Prevent error during initial loading
                if (cmbDifficulty.SelectedIndex == -1)
                    return;

                string difficultyName = cmbDifficulty.Text;

                if (difficultyName == "All")
                    LoadProblems(ProblemBL.GetAllProblems());
                else if (difficultyName == "Easy")
                    LoadProblems(ProblemBL.GetEasyProblems());
                else if (difficultyName == "Medium")
                    LoadProblems(ProblemBL.GetMediumProblems());
                else if (difficultyName == "Hard")
                    LoadProblems(ProblemBL.GetHardProblems());
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load problems.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void LoadProblems(DataTable dt)
        {
            try
            {
                dgvProblems.DataSource = dt;

                dgvProblems.Columns["ProblemID"].FillWeight = 20;
                dgvProblems.Columns["Title"].FillWeight = 80;
                dgvProblems.Columns["DifficultyName"].FillWeight = 30;

                dgvProblems.Columns["ProblemID"].HeaderText = "ID";
                dgvProblems.Columns["Title"].HeaderText = "Title";
                dgvProblems.Columns["DifficultyName"].HeaderText = "Difficulty Level";
            }
            catch(Exception)
            {
                MessageBox.Show("Unable to load problems. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
        private void dgvProblems_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvProblems.CurrentRow == null)
                    return;

                int problemID = Convert.ToInt32(dgvProblems.CurrentRow.Cells["ProblemID"].Value);
                string title = dgvProblems.CurrentRow.Cells["Title"].Value.ToString();
                string difficulty = dgvProblems.CurrentRow.Cells["DifficultyName"].Value.ToString();
                string description = ProblemBL.GetDescriptionByID(problemID);

                lblProblemName.Text = title;
                lblDifficultyBadge.Text = difficulty;
                rtbProblemDesc.Text = description;
            }
            catch
            {
                lblProblemName.Text = "Error Loading Problem";
                lblDifficultyBadge.Text = "";
                rtbProblemDesc.Text = "Unable to load description.";
            }
        }

        private void btnRunQuery_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProblems.CurrentRow == null)
                {
                    MessageBox.Show("Please select a problem.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int problemID = Convert.ToInt32(dgvProblems.CurrentRow.Cells["ProblemID"].Value);

                string query = rtbSQLEditor.Text.Trim();
                if (string.IsNullOrWhiteSpace(query))
                {
                    MessageBox.Show("Please write an SQL query.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataTable dt = QueryRunnerBL.GetOutput(problemID, query);

                dgvOutput.DataSource = dt;

                lblResultBadge.ForeColor = Color.FromArgb(62, 207, 142); // green colour
                lblResultBadge.Text = $"Output generated • {dt.Rows.Count} rows";
            }
            catch (Exception ex)
            {
                dgvOutput.DataSource = null;

                lblResultBadge.ForeColor = Color.FromArgb(224, 90, 90);  // red colour
                lblResultBadge.Text = "SQL Error: " + ex.Message;
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {}
        //    try
        //    {
        //        if (dgvProblems.CurrentRow == null)
        //        {
        //            MessageBox.Show("Please select a problem.", "Warning",
        //                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return;
        //        }
        //        int problemID = Convert.ToInt32(dgvProblems.CurrentRow.Cells["ProblemID"].Value);

        //        string query = rtbSQLEditor.Text.Trim();
        //        if (string.IsNullOrWhiteSpace(query))
        //        {
        //            MessageBox.Show("Please write an SQL query.", "Warning",
        //                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return;
        //        }

        //        // Create Submission
        //        Submission submission = new Submission(studentID, problemID, query);

        //        SubmissionBL.CreateSubmission(submission);

        //        MessageBox.Show(
        //            "Solution submitted successfully!",
        //            "Success",
        //            MessageBoxButtons.OK,
        //            MessageBoxIcon.Information);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(
        //            ex.Message,
        //            "Error",
        //            MessageBoxButtons.OK,
        //            MessageBoxIcon.Error);
        //    }
        //}
        private void btnClearEditor_Click(object sender, EventArgs e)
        {
            rtbSQLEditor.Clear();

            rtbSQLEditor.Text = "-- Write your SQL query here SELECT ";
        }
        private void btnClearOutput_Click(object sender, EventArgs e)
        {
            dgvOutput.DataSource = null;
            dgvOutput.Rows.Clear();
            dgvOutput.Columns.Clear();

            lblResultBadge.Text = "";
        }
        private void rtbSQLEditor_KeyUp(object sender, KeyEventArgs e)
        {
            int index = rtbSQLEditor.SelectionStart;

            int line = rtbSQLEditor.GetLineFromCharIndex(index);

            int column = index - rtbSQLEditor.GetFirstCharIndexFromLine(line);

            lblLineCol.Text = $"Ln {line + 1}, Col {column + 1}";
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