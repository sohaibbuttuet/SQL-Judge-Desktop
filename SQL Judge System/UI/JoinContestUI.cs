using SQL_Judge_System.BL;
using SQL_Judge_System.DL;
using SQL_Judge_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;

namespace SQL_Judge_System.UI
{
    public partial class JoinContestUI : Form
    {
        private readonly int studentID;
        private DataTable dtAllContest;
        private DateTime? contestEndTime = null;
        private Timer clockTimer = new Timer {Interval = 1000 };

        public JoinContestUI(int studentID)
        {
            this.studentID = studentID;
            InitializeComponent();
            LoadContests();
        }

        // Load Contest
        private void LoadContests()
        {
            try
            {
                this.dtAllContest = ContestBL.GetContests();
                LoadContest(this.dtAllContest);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading contests: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadContest(DataTable dt)
        {
            dgvContest.DataSource = dt;

            if (dgvContest.Columns.Count > 0)
            {
                // Hide unneccessry columns safely
                string[] columnsToHide = { "ContestID", "Duration", "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy" };

                foreach (string col in columnsToHide)
                {
                    if (dgvContest.Columns.Contains(col))
                        dgvContest.Columns[col].Visible = false;
                }

                dgvContest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                SafeColumn(dgvContest, "Title", "Title", 100);
                SafeColumn(dgvContest, "TotalParticipants", "Participants", 50);
                SafeColumn(dgvContest, "StartDate", "Start Date", 50);
                SafeColumn(dgvContest, "EndDate", "End Date", 50);
                SafeColumn(dgvContest, "ContestStatus", "Status", 50);
            }
        }

        // Load Contest Details
        private void dgvContest_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvContest.CurrentRow == null || dgvContest.CurrentRow.Index < 0)
                return;

            try
            {
                int contestID = Convert.ToInt32(dgvContest.CurrentRow.Cells["ContestID"].Value);
                lblParticipantsValue.Text = dgvContest.CurrentRow.Cells["TotalParticipants"].Value.ToString();
                lblContestStatusValue.Text = dgvContest.CurrentRow.Cells["ContestStatus"].Value.ToString();

                LoadContestDetails(contestID);
                LoadContestProblems(contestID);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error handling selection: {ex.Message}", "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void LoadContestDetails(int contestID)
        {
            try
            {
                Contest contest = ContestBL.GetContestByID(contestID);

                if (contest != null)
                {
                    lblContestTitle.Text = contest.Title;
                    lblBadgeStartValue.Text = "Start: " + contest.StartDate.ToString("g");
                    lblBadgeEndValue.Text = "End: " + contest.EndDate.ToString("g");
                    txtContestDescription.Text = contest.Description;
                    lblBadgeDurationValue.Text = $"{contest.Duration} mins";
                    lblAttemptsValue.Text = SubmissionBL.GetContestAttempts(studentID, contestID).ToString();
                    lblRankValue.Text = "";

                    if (ContestBL.IsContestFullySolved(studentID, contestID))
                    {
                        lblLastSubmissionValue.Text = "Solved";
                        lblLastSubmissionValue.ForeColor = Color.Green;
                    }
                    else if (ContestBL.IsContestPartiallyPassed(studentID, contestID))
                    {
                        lblLastSubmissionValue.Text = "Attempted";
                        lblLastSubmissionValue.ForeColor = Color.Orange;
                    }
                    else
                    {
                        lblLastSubmissionValue.Text = "Not Attempted";
                        lblLastSubmissionValue.ForeColor = Color.Gray;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading contest details: {ex.Message}", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadContestProblems(int contestID)
        {
            try
            {
                DataTable contestProblems = ProblemBL.GetContestProblems(contestID);
                dgvContestProblems.DataSource = contestProblems;
                dgvContestProblems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                if (dgvContestProblems.Columns.Contains("ProblemID"))
                    dgvContestProblems.Columns["ProblemID"].Visible = false;

                SafeColumn(dgvContestProblems, "Title", "Title", 150);
                SafeColumn(dgvContestProblems, "DifficultyName", "Difficulty", 50);
                SafeColumn(dgvContestProblems, "Points", "Points", 50);

                if (contestProblems != null)
                {
                    object sumobj = contestProblems.Compute("Sum(Points)", "");
                    lblBadgeTotalPointsValue.Text = sumobj != DBNull.Value ? sumobj.ToString() + " pts" : "0 pts";
                    lblBadgeTotalProblemsValue.Text = contestProblems.Rows.Count.ToString() + " Problems";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading problems: {ex.Message}", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Combined Filter Engine (Handles both search keyword AND dropdown simultaneously)
        private void ApplyFilters()
        {
            if (dtAllContest == null) return;

            try
            {
                List<string> filterExpressions = new List<string>();

                // 1. Status Dropdown Filter
                string statusFilter = cmbStatusFilter.Text;
                if (!string.IsNullOrEmpty(statusFilter) && statusFilter != "All Contests")
                {
                    filterExpressions.Add($"ContestStatus = '{statusFilter.Replace("'", "''")}'");
                }

                // 2. Text Search Filter
                string searchKeyword = txtContestSearch.Text.Trim();
                if (!string.IsNullOrWhiteSpace(searchKeyword) &&
                    !searchKeyword.StartsWith("Search contests...", StringComparison.OrdinalIgnoreCase))
                {
                    filterExpressions.Add($"Title LIKE '%{searchKeyword.Replace("'", "''")}%'");
                }

                // Combine filters or reset if empty
                DataView dv = new DataView(dtAllContest);
                if (filterExpressions.Count > 0)
                {
                    dv.RowFilter = string.Join(" AND ", filterExpressions);
                }
                else
                {
                    dv.RowFilter = ""; // Clears filters
                }

                LoadContest(dv.ToTable());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error filtering contests: {ex.Message}", "Filtering Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void cmbStatusFilter_SelectedValueChanged(object sender, EventArgs e) => ApplyFilters();
        private void cmbStatusFilter_TextChanged(object sender, EventArgs e) => ApplyFilters();

        // Button Events
        private void btnJoinContest_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvContest.CurrentRow == null)
                {
                    MessageBox.Show("Please select a contest.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int contestID = Convert.ToInt32(dgvContest.CurrentRow.Cells["ContestID"].Value);

                // ---- BLOCK IF CONTEST COMPLETELY SOLVED BY STUDENT ----
                if (ContestBL.IsContestFullySolved(studentID, contestID))
                {
                    MessageBox.Show("You have already solved all the problems in this contest with a perfect score! Re-entry is restricted.",
                                    "Contest Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Register the participant in the database
                ContestParticipant contestParticipant = new ContestParticipant(contestID, studentID);
                ContestBL.AddContestParticipent(contestParticipant);

                MessageBox.Show("You have successfully joined the contest! Your workspace has been configured.", "Contest Started", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error " + ex.Message,
                    "Database Engine Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void btnStartContest_Click(object sender, EventArgs e)
        {
            if (dgvContest.CurrentRow == null)
            {
                MessageBox.Show("Please select a contest from the table first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int contestID = Convert.ToInt32(dgvContest.CurrentRow.Cells["ContestID"].Value);

                // ---- BLOCK IF CONTEST COMPLETELY SOLVED BY STUDENT ----
                if (ContestBL.IsContestFullySolved(studentID, contestID))
                {
                    MessageBox.Show("You have already solved all the problems in this contest with a perfect score! Re-entry is restricted.",
                                    "Contest Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // 1. Has the student registered in the contest
                ContestParticipant cp = new ContestParticipant(contestID, studentID);
                if (!ContestBL.IsParticipantRegistered(cp))
                {
                    MessageBox.Show("Please click the 'Join Contest' button first to register your student profile before starting.", "Registration Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Contest c = ContestBL.GetContestByID(contestID);
                if (c == null) return;

                DateTime now = DateTime.Now;

                // 2. Has the contest start started
                if (now < c.StartDate)
                {
                    MessageBox.Show($"This contest hasn't started yet!\n\nScheduled Start Time: {c.StartDate.ToString("g")}", "Contest Locked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 3. Has the Contest Ended
                if (now > c.EndDate)
                {
                    MessageBox.Show("This contest has already completed its scheduled date run. Submissions are closed.", "Contest Finished", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 4. Smart Time Calculation Rule:
                // A student's time limit is governed by the contest duration
                // However, they cannot exceed the hard closing boundary of the contest itself!
                // 5. Calculate and save the shared dynamic end time globally on this form
                DateTime strategicEndTime = now.AddMinutes(c.Duration);
                if (strategicEndTime > c.EndDate)
                {
                    strategicEndTime = c.EndDate;
                }

                this.contestEndTime = strategicEndTime;

                // 6. Start this form's local label clock countdown ticker
                btnStartContest.Enabled = false; // Disable button so they can't click it twice

                // 7. Hand over control to the workspace passing the exact same target time
                this.Hide();

                // This opens SolveProblem Form, passing it the exact same deadline time, keeping both windows completely in sync.
                using (SolveProblemUI problemSolver = new SolveProblemUI(this.studentID, contestID, strategicEndTime))
                {
                    problemSolver.ShowDialog(); // Display your workspace as a modal dialog safely
                }

                // Re-enable interface components on control fallback return transitions
                btnStartContest.Enabled = true;
                this.Show();
                LoadContests();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to set up workspace thread: {ex.Message}", "System Layout Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Clean up leaks if form gets closed while timer is ticking
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (clockTimer != null)
            {
                clockTimer.Stop();
                clockTimer.Dispose();
            }
            base.OnFormClosing(e);
        }

        // Helping Function
        private void SafeColumn(DataGridView dgv, string col, string header, int weight)
        {
            if (dgv.Columns.Contains(col))
            {
                dgv.Columns[col].HeaderText = header;
                dgv.Columns[col].FillWeight = weight;
            }
        }        
    }
}