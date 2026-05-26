using System;
using System.Drawing;
using System.Windows.Forms;

namespace SQL_Judge_System.UI
{
    public partial class ContestUI : Form
    {
        private TimeSpan remainingTime;
        private int studentID;

        public ContestUI(int studentID)
        {
            InitializeComponent();
            this.studentID = studentID;
        }

        // =====================================================
        // FORM LOAD
        // =====================================================
        private void ContestUI_Load(object sender, EventArgs e)
        {
            cmbContestFilter.SelectedIndex = 0;

            BuildStatCard(pnlStatParticipants, lblStatParticipants, lblStatParticipantsV,
                "PARTICIPANTS", "—", Color.FromArgb(56, 182, 255));

            BuildStatCard(pnlStatProblems, lblStatProblems, lblStatProblemsV,
                "PROBLEMS", "—", Color.FromArgb(124, 111, 255));

            BuildStatCard(pnlStatDuration, lblStatDuration, lblStatDurationV,
                "DURATION", "—", Color.FromArgb(245, 158, 66));

            BuildStatCard(pnlStatScore, lblStatScore, lblStatScoreV,
                "MAX SCORE", "—", Color.FromArgb(62, 207, 142));
        }

        // =====================================================
        // TIMER
        // =====================================================
        private void tmrCountdown_Tick(object sender, EventArgs e)
        {
            if (remainingTime.TotalSeconds > 0)
            {
                remainingTime = remainingTime.Subtract(TimeSpan.FromSeconds(1));
                lblTimer.Text = remainingTime.ToString(@"hh\:mm\:ss");
            }
            else
            {
                tmrCountdown.Stop();
                lblTimer.Text = "00:00:00";
                lblContestStatus.Text = "Contest Ended";
                btnJoinContest.Enabled = false;
            }
        }

        private void BuildStatCard(Panel panel, Label lblTitle, Label lblVal, string titleText, string valText, Color accent)
        {
            panel.BackColor = Color.FromArgb(32, 37, 63);
            panel.Dock = DockStyle.Fill;
            panel.Margin = new Padding(3);
            panel.Padding = new Padding(6, 4, 6, 4);

            lblTitle.AutoSize = false;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(139, 146, 184);
            lblTitle.Size = new Size(100, 16);
            lblTitle.Text = titleText;
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            lblVal.AutoSize = false;
            lblVal.Dock = DockStyle.Fill;
            lblVal.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblVal.ForeColor = accent;
            lblVal.Text = valText;
            lblVal.TextAlign = ContentAlignment.MiddleCenter;

            panel.Controls.Add(lblVal);
            panel.Controls.Add(lblTitle);
        }

        // =====================================================
        // SIDEBAR BUTTONS
        // =====================================================
        private void btn_home_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Home clicked");
        }

        private void btn_problems_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Problems clicked");
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Report clicked");
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Settings clicked");
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // =====================================================
        // FILTER CHANGE
        // =====================================================
        private void cmbContestFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filter = cmbContestFilter.SelectedItem.ToString();
            lblContestStatus.Text = "Filter: " + filter;

            // TODO: Load contests from DB based on filter
        }

        // =====================================================
        // CONTEST SELECTION
        // =====================================================
        private void dgvContests_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvContests.CurrentRow == null)
                return;

            btnJoinContest.Enabled = true;
            lblContestStatus.Text = "Contest selected";

            // Demo values (replace with DB later)
            lblContestName.Text = "Sample Contest";
            lblContestMeta.Text = "Starts soon • Beginner level";
            lblContestDesc.Text = "This is a demo contest description.";

            lblStatParticipantsV.Text = "120";
            lblStatProblemsV.Text = "5";
            lblStatDurationV.Text = "1h 30m";
            lblStatScoreV.Text = "500";
        }

        // =====================================================
        // JOIN CONTEST
        // =====================================================
        private void btnJoinContest_Click(object sender, EventArgs e)
        {
            pnlTimerBox.Visible = true;

            remainingTime = new TimeSpan(1, 30, 0);
            lblTimer.Text = remainingTime.ToString(@"hh\:mm\:ss");

            tmrCountdown.Start();

            lblContestStatus.Text = "Contest Started";
        }

        // =====================================================
        // PROBLEM DOUBLE CLICK
        // =====================================================
        private void dgvContestProblems_CellDoubleClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            MessageBox.Show("Open problem editor here");
        }

        // =====================================================
        // LEADERBOARD REFRESH
        // =====================================================
        private void btnRefreshLB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Leaderboard refreshed");
        }
    }
}