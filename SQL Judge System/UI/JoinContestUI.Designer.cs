namespace SQL_Judge_System.UI
{
    partial class JoinContestUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            // ── Color palette (identical to SolveProblemUI) ───────────────
            // Background canvas  : FromArgb(10,  14,  26)   — #0A0E1A
            // Main card surface  : FromArgb(17,  24,  39)   — #111827
            // Inner card / panel : FromArgb(24,  33,  47)   — #18212F
            // Deep input bg      : FromArgb(13,  17,  27)   — #0D111B
            // Alt row tint       : FromArgb(20,  28,  41)   — #141C29
            // Green accent       : FromArgb(16,  185, 129)  — #10B981
            // Indigo action      : FromArgb(79,  70,  229)  — #4F46E5
            // Amber warning      : FromArgb(245, 158, 11)   — #F59E0B
            // Border / separator : FromArgb(31,  41,  55)   — #1F2937
            // Header row bg      : FromArgb(17,  24,  39)   — #111827
            // Text primary       : FromArgb(209, 213, 219)  — #D1D5DB
            // Text muted         : FromArgb(107, 114, 128)  — #6B7280
            // Text dimmed        : FromArgb(75,  85,  99)   — #4B5563
            // Text subtle        : FromArgb(55,  65,  81)   — #374151
            // Text bright        : FromArgb(240, 253, 244)  — #F0FDF4

            // ── Top-level containers ──────────────────────────────────────
            this.pnlFormBackground = new System.Windows.Forms.Panel();
            this.pnlMainCard = new System.Windows.Forms.Panel();

            // ── Header bar ───────────────────────────────────────────────
            this.pnlHeaderBar = new System.Windows.Forms.Panel();
            this.pnlHeaderLeftAccent = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblFormSubtitle = new System.Windows.Forms.Label();
            this.pnlHeaderStats = new System.Windows.Forms.Panel();
            this.pnlStatCountdown = new System.Windows.Forms.Panel();
            this.lblCountdownCaption = new System.Windows.Forms.Label();
            this.lblCountdownValue = new System.Windows.Forms.Label();
            this.pnlStatParticipants = new System.Windows.Forms.Panel();
            this.lblParticipantsCaption = new System.Windows.Forms.Label();
            this.lblParticipantsValue = new System.Windows.Forms.Label();
            this.pnlStatContestStatus = new System.Windows.Forms.Panel();
            this.lblContestStatusCaption = new System.Windows.Forms.Label();
            this.lblContestStatusValue = new System.Windows.Forms.Label();
            this.pnlStatLastSubmission = new System.Windows.Forms.Panel();
            this.lblLastSubmissionCaption = new System.Windows.Forms.Label();
            this.lblLastSubmissionValue = new System.Windows.Forms.Label();

            // ── Body — three-column layout ────────────────────────────────
            this.pnlBody = new System.Windows.Forms.Panel();

            // ── LEFT COLUMN: Contest list ─────────────────────────────────
            this.pnlLeftColumn = new System.Windows.Forms.Panel();
            this.pnlContestListCard = new System.Windows.Forms.Panel();
            this.pnlContestListHeader = new System.Windows.Forms.Panel();
            this.pnlContestListAccent = new System.Windows.Forms.Panel();
            this.lblContestListTitle = new System.Windows.Forms.Label();
            this.btnRefreshContests = new System.Windows.Forms.Button();
            this.pnlContestFilters = new System.Windows.Forms.Panel();
            this.txtContestSearch = new System.Windows.Forms.TextBox();
            this.cmbStatusFilter = new System.Windows.Forms.ComboBox();
            this.dgvContestList = new System.Windows.Forms.DataGridView();
            this.colContestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContestDifficulty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContestStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContestProblems = new System.Windows.Forms.DataGridViewTextBoxColumn();

            // ── CENTER COLUMN: Contest detail + Problems grid ─────────────
            this.pnlCenterColumn = new System.Windows.Forms.Panel();

            // Contest detail card (top-center)
            this.pnlContestDetailCard = new System.Windows.Forms.Panel();
            this.pnlContestDetailHeader = new System.Windows.Forms.Panel();
            this.pnlContestDetailAccent = new System.Windows.Forms.Panel();
            this.lblContestDetailTitle = new System.Windows.Forms.Label();
            this.pnlContestDetailBadges = new System.Windows.Forms.Panel();
            this.pnlBadgeStartDate = new System.Windows.Forms.Panel();
            this.lblBadgeStartIcon = new System.Windows.Forms.Label();
            this.lblBadgeStartValue = new System.Windows.Forms.Label();
            this.pnlBadgeEndDate = new System.Windows.Forms.Panel();
            this.lblBadgeEndIcon = new System.Windows.Forms.Label();
            this.lblBadgeEndValue = new System.Windows.Forms.Label();
            this.pnlBadgeDuration = new System.Windows.Forms.Panel();
            this.lblBadgeDurationIcon = new System.Windows.Forms.Label();
            this.lblBadgeDurationValue = new System.Windows.Forms.Label();
            this.pnlBadgeTotalProblems = new System.Windows.Forms.Panel();
            this.lblBadgeTotalProblemsIcon = new System.Windows.Forms.Label();
            this.lblBadgeTotalProblemsValue = new System.Windows.Forms.Label();
            this.pnlBadgeTotalPoints = new System.Windows.Forms.Panel();
            this.lblBadgeTotalPointsIcon = new System.Windows.Forms.Label();
            this.lblBadgeTotalPointsValue = new System.Windows.Forms.Label();
            this.txtContestDescription = new System.Windows.Forms.RichTextBox();

            // Contest problems grid (center-center)
            this.pnlContestProblemsCard = new System.Windows.Forms.Panel();
            this.pnlContestProblemsHeader = new System.Windows.Forms.Panel();
            this.pnlContestProblemsAccent = new System.Windows.Forms.Panel();
            this.lblContestProblemsTitle = new System.Windows.Forms.Label();
            this.lblContestProblemsHint = new System.Windows.Forms.Label();
            this.dgvContestProblems = new System.Windows.Forms.DataGridView();
            this.colProblemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProblemDifficulty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProblemPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProblemSolvedStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();

            // Contest progress indicator (bottom of center, above bottom strip)
            this.pnlProgressCard = new System.Windows.Forms.Panel();
            this.pnlProgressHeader = new System.Windows.Forms.Panel();
            this.pnlProgressAccent = new System.Windows.Forms.Panel();
            this.lblProgressTitle = new System.Windows.Forms.Label();
            this.lblProgressFraction = new System.Windows.Forms.Label();
            this.pnlProgressBody = new System.Windows.Forms.Panel();
            this.pnlProgressTrack = new System.Windows.Forms.Panel();
            this.pnlProgressFill = new System.Windows.Forms.Panel();
            this.lblProgressPercent = new System.Windows.Forms.Label();

            // ── RIGHT COLUMN: Problem detail card ─────────────────────────
            this.pnlRightColumn = new System.Windows.Forms.Panel();
            this.pnlProblemDetailCard = new System.Windows.Forms.Panel();
            this.pnlProblemDetailHeader = new System.Windows.Forms.Panel();
            this.pnlProblemDetailAccent = new System.Windows.Forms.Panel();
            this.lblProblemDetailTitle = new System.Windows.Forms.Label();
            this.pnlProblemDetailBadges = new System.Windows.Forms.Panel();
            this.pnlProbDiffBadge = new System.Windows.Forms.Panel();
            this.lblProbDiffIcon = new System.Windows.Forms.Label();
            this.lblProbDiffValue = new System.Windows.Forms.Label();
            this.pnlProbPointsBadge = new System.Windows.Forms.Panel();
            this.lblProbPointsIcon = new System.Windows.Forms.Label();
            this.lblProbPointsValue = new System.Windows.Forms.Label();
            this.pnlProbDetailBody = new System.Windows.Forms.Panel();
            this.lblProbTagsCaption = new System.Windows.Forms.Label();
            this.lblProbTagsValue = new System.Windows.Forms.Label();
            this.lblProbDescCaption = new System.Windows.Forms.Label();
            this.txtProblemShortDesc = new System.Windows.Forms.RichTextBox();
            this.lblProbConstraintsCaption = new System.Windows.Forms.Label();
            this.txtProblemConstraints = new System.Windows.Forms.RichTextBox();
            this.lblProbAllowedDbCaption = new System.Windows.Forms.Label();
            this.lblProbAllowedDbValue = new System.Windows.Forms.Label();
            this.pnlProbSolvedStatus = new System.Windows.Forms.Panel();
            this.pnlProbSolvedAccent = new System.Windows.Forms.Panel();
            this.lblProbSolvedStatusCaption = new System.Windows.Forms.Label();
            this.lblProbSolvedStatusValue = new System.Windows.Forms.Label();

            // ── Bottom action strip ───────────────────────────────────────
            this.pnlBottomStrip = new System.Windows.Forms.Panel();
            this.pnlBottomStripTopLine = new System.Windows.Forms.Panel();
            this.pnlBottomLeft = new System.Windows.Forms.Panel();
            this.pnlInfoTimeRemaining = new System.Windows.Forms.Panel();
            this.lblTimeRemainingCaption = new System.Windows.Forms.Label();
            this.lblTimeRemainingValue = new System.Windows.Forms.Label();
            this.pnlInfoRank = new System.Windows.Forms.Panel();
            this.lblRankCaption = new System.Windows.Forms.Label();
            this.lblRankValue = new System.Windows.Forms.Label();
            this.pnlInfoAttempts = new System.Windows.Forms.Panel();
            this.lblAttemptsCaption = new System.Windows.Forms.Label();
            this.lblAttemptsValue = new System.Windows.Forms.Label();
            this.pnlBottomRight = new System.Windows.Forms.Panel();
            this.lnkContestRules = new System.Windows.Forms.LinkLabel();
            this.btnViewLeaderboard = new System.Windows.Forms.Button();
            this.btnStartContest = new System.Windows.Forms.Button();
            this.btnJoinContest = new System.Windows.Forms.Button();

            // ── Footer bar ────────────────────────────────────────────────
            this.pnlFooterBar = new System.Windows.Forms.Panel();
            this.pnlFooterTopLine = new System.Windows.Forms.Panel();
            this.lblFooterHint = new System.Windows.Forms.Label();
            this.lblFooterInfo = new System.Windows.Forms.Label();

            // ══════════════════════════════════════════════════════════════
            // Suspend all layouts
            // ══════════════════════════════════════════════════════════════
            this.pnlFormBackground.SuspendLayout();
            this.pnlMainCard.SuspendLayout();
            this.pnlHeaderBar.SuspendLayout();
            this.pnlHeaderStats.SuspendLayout();
            this.pnlStatCountdown.SuspendLayout();
            this.pnlStatParticipants.SuspendLayout();
            this.pnlStatContestStatus.SuspendLayout();
            this.pnlStatLastSubmission.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlLeftColumn.SuspendLayout();
            this.pnlContestListCard.SuspendLayout();
            this.pnlContestListHeader.SuspendLayout();
            this.pnlContestFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContestList)).BeginInit();
            this.pnlCenterColumn.SuspendLayout();
            this.pnlContestDetailCard.SuspendLayout();
            this.pnlContestDetailHeader.SuspendLayout();
            this.pnlContestDetailBadges.SuspendLayout();
            this.pnlBadgeStartDate.SuspendLayout();
            this.pnlBadgeEndDate.SuspendLayout();
            this.pnlBadgeDuration.SuspendLayout();
            this.pnlBadgeTotalProblems.SuspendLayout();
            this.pnlBadgeTotalPoints.SuspendLayout();
            this.pnlContestProblemsCard.SuspendLayout();
            this.pnlContestProblemsHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContestProblems)).BeginInit();
            this.pnlProgressCard.SuspendLayout();
            this.pnlProgressHeader.SuspendLayout();
            this.pnlProgressBody.SuspendLayout();
            this.pnlProgressTrack.SuspendLayout();
            this.pnlRightColumn.SuspendLayout();
            this.pnlProblemDetailCard.SuspendLayout();
            this.pnlProblemDetailHeader.SuspendLayout();
            this.pnlProblemDetailBadges.SuspendLayout();
            this.pnlProbDiffBadge.SuspendLayout();
            this.pnlProbPointsBadge.SuspendLayout();
            this.pnlProbDetailBody.SuspendLayout();
            this.pnlProbSolvedStatus.SuspendLayout();
            this.pnlBottomStrip.SuspendLayout();
            this.pnlBottomLeft.SuspendLayout();
            this.pnlInfoTimeRemaining.SuspendLayout();
            this.pnlInfoRank.SuspendLayout();
            this.pnlInfoAttempts.SuspendLayout();
            this.pnlBottomRight.SuspendLayout();
            this.pnlFooterBar.SuspendLayout();
            this.SuspendLayout();

            // ══════════════════════════════════════════════════════════════
            //  pnlFormBackground
            // ══════════════════════════════════════════════════════════════
            this.pnlFormBackground.BackColor = System.Drawing.Color.FromArgb(10, 14, 26);
            this.pnlFormBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlFormBackground.Name = "pnlFormBackground";
            this.pnlFormBackground.Padding = new System.Windows.Forms.Padding(12);
            this.pnlFormBackground.Size = new System.Drawing.Size(1184, 681);
            this.pnlFormBackground.TabIndex = 0;
            this.pnlFormBackground.Controls.Add(this.pnlMainCard);

            // ══════════════════════════════════════════════════════════════
            //  pnlMainCard
            // ══════════════════════════════════════════════════════════════
            this.pnlMainCard.BackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.pnlMainCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainCard.Location = new System.Drawing.Point(12, 12);
            this.pnlMainCard.Name = "pnlMainCard";
            this.pnlMainCard.Size = new System.Drawing.Size(1160, 657);
            this.pnlMainCard.TabIndex = 0;
            this.pnlMainCard.Controls.Add(this.pnlBody);
            this.pnlMainCard.Controls.Add(this.pnlFooterBar);
            this.pnlMainCard.Controls.Add(this.pnlHeaderBar);

            // ══════════════════════════════════════════════════════════════
            //  pnlHeaderBar
            // ══════════════════════════════════════════════════════════════
            this.pnlHeaderBar.BackColor = System.Drawing.Color.FromArgb(10, 14, 26);
            this.pnlHeaderBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderBar.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderBar.Name = "pnlHeaderBar";
            this.pnlHeaderBar.Size = new System.Drawing.Size(1160, 64);
            this.pnlHeaderBar.TabIndex = 0;
            this.pnlHeaderBar.Controls.Add(this.pnlHeaderStats);
            this.pnlHeaderBar.Controls.Add(this.lblFormSubtitle);
            this.pnlHeaderBar.Controls.Add(this.lblFormTitle);
            this.pnlHeaderBar.Controls.Add(this.pnlHeaderLeftAccent);

            // pnlHeaderLeftAccent
            this.pnlHeaderLeftAccent.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.pnlHeaderLeftAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderLeftAccent.Name = "pnlHeaderLeftAccent";
            this.pnlHeaderLeftAccent.Size = new System.Drawing.Size(4, 64);
            this.pnlHeaderLeftAccent.TabIndex = 3;

            // lblFormTitle
            this.lblFormTitle.AutoSize = false;
            this.lblFormTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(240, 253, 244);
            this.lblFormTitle.Location = new System.Drawing.Point(18, 10);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(380, 26);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "SQL Contest Arena";

            // lblFormSubtitle
            this.lblFormSubtitle.AutoSize = false;
            this.lblFormSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFormSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormSubtitle.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblFormSubtitle.Location = new System.Drawing.Point(20, 40);
            this.lblFormSubtitle.Name = "lblFormSubtitle";
            this.lblFormSubtitle.Size = new System.Drawing.Size(380, 18);
            this.lblFormSubtitle.TabIndex = 1;
            this.lblFormSubtitle.Text = "Browse, join, and compete in SQL contests";

            // ── Header stats cluster (right-aligned) ──────────────────────
            this.pnlHeaderStats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeaderStats.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeaderStats.Location = new System.Drawing.Point(590, 14);
            this.pnlHeaderStats.Name = "pnlHeaderStats";
            this.pnlHeaderStats.Size = new System.Drawing.Size(562, 36);
            this.pnlHeaderStats.TabIndex = 2;
            this.pnlHeaderStats.Controls.Add(this.pnlStatLastSubmission);
            this.pnlHeaderStats.Controls.Add(this.pnlStatContestStatus);
            this.pnlHeaderStats.Controls.Add(this.pnlStatParticipants);
            this.pnlHeaderStats.Controls.Add(this.pnlStatCountdown);

            // pnlStatCountdown
            this.pnlStatCountdown.BackColor = System.Drawing.Color.FromArgb(24, 33, 47);
            this.pnlStatCountdown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStatCountdown.Location = new System.Drawing.Point(0, 4);
            this.pnlStatCountdown.Name = "pnlStatCountdown";
            this.pnlStatCountdown.Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.pnlStatCountdown.Size = new System.Drawing.Size(138, 28);
            this.pnlStatCountdown.TabIndex = 0;
            this.pnlStatCountdown.Controls.Add(this.lblCountdownValue);
            this.pnlStatCountdown.Controls.Add(this.lblCountdownCaption);

            this.lblCountdownCaption.AutoSize = false;
            this.lblCountdownCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblCountdownCaption.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblCountdownCaption.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblCountdownCaption.Location = new System.Drawing.Point(8, 2);
            this.lblCountdownCaption.Name = "lblCountdownCaption";
            this.lblCountdownCaption.Size = new System.Drawing.Size(90, 10);
            this.lblCountdownCaption.TabIndex = 0;
            this.lblCountdownCaption.Text = "COUNTDOWN";

            this.lblCountdownValue.AutoSize = false;
            this.lblCountdownValue.BackColor = System.Drawing.Color.Transparent;
            this.lblCountdownValue.Font = new System.Drawing.Font("Consolas", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCountdownValue.ForeColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.lblCountdownValue.Location = new System.Drawing.Point(8, 13);
            this.lblCountdownValue.Name = "lblCountdownValue";
            this.lblCountdownValue.Size = new System.Drawing.Size(118, 14);
            this.lblCountdownValue.TabIndex = 1;
            this.lblCountdownValue.Text = "--:--:--";

            // pnlStatParticipants
            this.pnlStatParticipants.BackColor = System.Drawing.Color.FromArgb(24, 33, 47);
            this.pnlStatParticipants.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStatParticipants.Location = new System.Drawing.Point(148, 4);
            this.pnlStatParticipants.Name = "pnlStatParticipants";
            this.pnlStatParticipants.Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.pnlStatParticipants.Size = new System.Drawing.Size(138, 28);
            this.pnlStatParticipants.TabIndex = 1;
            this.pnlStatParticipants.Controls.Add(this.lblParticipantsValue);
            this.pnlStatParticipants.Controls.Add(this.lblParticipantsCaption);

            this.lblParticipantsCaption.AutoSize = false;
            this.lblParticipantsCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblParticipantsCaption.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblParticipantsCaption.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblParticipantsCaption.Location = new System.Drawing.Point(8, 2);
            this.lblParticipantsCaption.Name = "lblParticipantsCaption";
            this.lblParticipantsCaption.Size = new System.Drawing.Size(110, 10);
            this.lblParticipantsCaption.TabIndex = 0;
            this.lblParticipantsCaption.Text = "PARTICIPANTS";

            this.lblParticipantsValue.AutoSize = false;
            this.lblParticipantsValue.BackColor = System.Drawing.Color.Transparent;
            this.lblParticipantsValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblParticipantsValue.ForeColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.lblParticipantsValue.Location = new System.Drawing.Point(8, 13);
            this.lblParticipantsValue.Name = "lblParticipantsValue";
            this.lblParticipantsValue.Size = new System.Drawing.Size(118, 14);
            this.lblParticipantsValue.TabIndex = 1;
            this.lblParticipantsValue.Text = "0";

            // pnlStatContestStatus
            this.pnlStatContestStatus.BackColor = System.Drawing.Color.FromArgb(24, 33, 47);
            this.pnlStatContestStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStatContestStatus.Location = new System.Drawing.Point(296, 4);
            this.pnlStatContestStatus.Name = "pnlStatContestStatus";
            this.pnlStatContestStatus.Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.pnlStatContestStatus.Size = new System.Drawing.Size(124, 28);
            this.pnlStatContestStatus.TabIndex = 2;
            this.pnlStatContestStatus.Controls.Add(this.lblContestStatusValue);
            this.pnlStatContestStatus.Controls.Add(this.lblContestStatusCaption);

            this.lblContestStatusCaption.AutoSize = false;
            this.lblContestStatusCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblContestStatusCaption.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblContestStatusCaption.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblContestStatusCaption.Location = new System.Drawing.Point(8, 2);
            this.lblContestStatusCaption.Name = "lblContestStatusCaption";
            this.lblContestStatusCaption.Size = new System.Drawing.Size(90, 10);
            this.lblContestStatusCaption.TabIndex = 0;
            this.lblContestStatusCaption.Text = "STATUS";

            this.lblContestStatusValue.AutoSize = false;
            this.lblContestStatusValue.BackColor = System.Drawing.Color.Transparent;
            this.lblContestStatusValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblContestStatusValue.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblContestStatusValue.Location = new System.Drawing.Point(8, 13);
            this.lblContestStatusValue.Name = "lblContestStatusValue";
            this.lblContestStatusValue.Size = new System.Drawing.Size(104, 14);
            this.lblContestStatusValue.TabIndex = 1;
            this.lblContestStatusValue.Text = "—";

            // pnlStatLastSubmission
            this.pnlStatLastSubmission.BackColor = System.Drawing.Color.FromArgb(24, 33, 47);
            this.pnlStatLastSubmission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStatLastSubmission.Location = new System.Drawing.Point(430, 4);
            this.pnlStatLastSubmission.Name = "pnlStatLastSubmission";
            this.pnlStatLastSubmission.Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.pnlStatLastSubmission.Size = new System.Drawing.Size(130, 28);
            this.pnlStatLastSubmission.TabIndex = 3;
            this.pnlStatLastSubmission.Controls.Add(this.lblLastSubmissionValue);
            this.pnlStatLastSubmission.Controls.Add(this.lblLastSubmissionCaption);

            this.lblLastSubmissionCaption.AutoSize = false;
            this.lblLastSubmissionCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblLastSubmissionCaption.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblLastSubmissionCaption.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblLastSubmissionCaption.Location = new System.Drawing.Point(8, 2);
            this.lblLastSubmissionCaption.Name = "lblLastSubmissionCaption";
            this.lblLastSubmissionCaption.Size = new System.Drawing.Size(112, 10);
            this.lblLastSubmissionCaption.TabIndex = 0;
            this.lblLastSubmissionCaption.Text = "LAST SUBMISSION";

            this.lblLastSubmissionValue.AutoSize = false;
            this.lblLastSubmissionValue.BackColor = System.Drawing.Color.Transparent;
            this.lblLastSubmissionValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblLastSubmissionValue.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblLastSubmissionValue.Location = new System.Drawing.Point(8, 13);
            this.lblLastSubmissionValue.Name = "lblLastSubmissionValue";
            this.lblLastSubmissionValue.Size = new System.Drawing.Size(110, 14);
            this.lblLastSubmissionValue.TabIndex = 1;
            this.lblLastSubmissionValue.Text = "—";

            // ══════════════════════════════════════════════════════════════
            //  pnlFooterBar
            // ══════════════════════════════════════════════════════════════
            this.pnlFooterBar.BackColor = System.Drawing.Color.FromArgb(10, 14, 26);
            this.pnlFooterBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooterBar.Location = new System.Drawing.Point(0, 632);
            this.pnlFooterBar.Name = "pnlFooterBar";
            this.pnlFooterBar.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.pnlFooterBar.Size = new System.Drawing.Size(1160, 25);
            this.pnlFooterBar.TabIndex = 2;
            this.pnlFooterBar.Controls.Add(this.lblFooterInfo);
            this.pnlFooterBar.Controls.Add(this.lblFooterHint);
            this.pnlFooterBar.Controls.Add(this.pnlFooterTopLine);

            this.pnlFooterTopLine.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.pnlFooterTopLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFooterTopLine.Location = new System.Drawing.Point(16, 0);
            this.pnlFooterTopLine.Name = "pnlFooterTopLine";
            this.pnlFooterTopLine.Size = new System.Drawing.Size(1128, 1);
            this.pnlFooterTopLine.TabIndex = 2;

            this.lblFooterHint.AutoSize = false;
            this.lblFooterHint.BackColor = System.Drawing.Color.Transparent;
            this.lblFooterHint.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblFooterHint.ForeColor = System.Drawing.Color.FromArgb(75, 85, 99);
            this.lblFooterHint.Location = new System.Drawing.Point(16, 5);
            this.lblFooterHint.Name = "lblFooterHint";
            this.lblFooterHint.Size = new System.Drawing.Size(580, 16);
            this.lblFooterHint.TabIndex = 0;
            this.lblFooterHint.Text = "ℹ  Select a contest to view details, then double-click a problem to inspect it.";

            this.lblFooterInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFooterInfo.AutoSize = false;
            this.lblFooterInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblFooterInfo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblFooterInfo.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            this.lblFooterInfo.Location = new System.Drawing.Point(700, 5);
            this.lblFooterInfo.Name = "lblFooterInfo";
            this.lblFooterInfo.Size = new System.Drawing.Size(444, 16);
            this.lblFooterInfo.TabIndex = 1;
            this.lblFooterInfo.Text = "SQL Judge System  ·  Contest Arena  ·  All times are server local time";
            this.lblFooterInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // ══════════════════════════════════════════════════════════════
            //  pnlBody  — full fill between header and footer
            // ══════════════════════════════════════════════════════════════
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 64);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Padding = new System.Windows.Forms.Padding(10, 8, 10, 6);
            this.pnlBody.Size = new System.Drawing.Size(1160, 568);
            this.pnlBody.TabIndex = 1;
            this.pnlBody.Controls.Add(this.pnlRightColumn);
            this.pnlBody.Controls.Add(this.pnlCenterColumn);
            this.pnlBody.Controls.Add(this.pnlLeftColumn);
            this.pnlBody.Controls.Add(this.pnlBottomStrip);

            // ══════════════════════════════════════════════════════════════
            //  LEFT COLUMN  — Contest list (238 px wide)
            // ══════════════════════════════════════════════════════════════
            this.pnlLeftColumn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlLeftColumn.BackColor = System.Drawing.Color.Transparent;
            this.pnlLeftColumn.Location = new System.Drawing.Point(10, 8);
            this.pnlLeftColumn.Name = "pnlLeftColumn";
            this.pnlLeftColumn.Size = new System.Drawing.Size(238, 480);
            this.pnlLeftColumn.TabIndex = 0;
            this.pnlLeftColumn.Controls.Add(this.pnlContestListCard);

            // pnlContestListCard
            this.pnlContestListCard.BackColor = System.Drawing.Color.FromArgb(24, 33, 47);
            this.pnlContestListCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContestListCard.Location = new System.Drawing.Point(0, 0);
            this.pnlContestListCard.Name = "pnlContestListCard";
            this.pnlContestListCard.Size = new System.Drawing.Size(238, 480);
            this.pnlContestListCard.TabIndex = 0;
            this.pnlContestListCard.Controls.Add(this.dgvContestList);
            this.pnlContestListCard.Controls.Add(this.pnlContestFilters);
            this.pnlContestListCard.Controls.Add(this.pnlContestListHeader);

            // pnlContestListHeader
            this.pnlContestListHeader.BackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.pnlContestListHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContestListHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlContestListHeader.Name = "pnlContestListHeader";
            this.pnlContestListHeader.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.pnlContestListHeader.Size = new System.Drawing.Size(238, 34);
            this.pnlContestListHeader.TabIndex = 0;
            this.pnlContestListHeader.Controls.Add(this.btnRefreshContests);
            this.pnlContestListHeader.Controls.Add(this.lblContestListTitle);
            this.pnlContestListHeader.Controls.Add(this.pnlContestListAccent);

            this.pnlContestListAccent.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.pnlContestListAccent.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlContestListAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlContestListAccent.Name = "pnlContestListAccent";
            this.pnlContestListAccent.Size = new System.Drawing.Size(3, 34);
            this.pnlContestListAccent.TabIndex = 2;

            this.lblContestListTitle.AutoSize = false;
            this.lblContestListTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblContestListTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblContestListTitle.ForeColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.lblContestListTitle.Location = new System.Drawing.Point(12, 0);
            this.lblContestListTitle.Name = "lblContestListTitle";
            this.lblContestListTitle.Size = new System.Drawing.Size(130, 34);
            this.lblContestListTitle.TabIndex = 0;
            this.lblContestListTitle.Text = "Contests";
            this.lblContestListTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // btnRefreshContests  — icon-style small button
            this.btnRefreshContests.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshContests.BackColor = System.Drawing.Color.FromArgb(24, 33, 47);
            this.btnRefreshContests.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.btnRefreshContests.FlatAppearance.BorderSize = 1;
            this.btnRefreshContests.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.btnRefreshContests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshContests.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefreshContests.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.btnRefreshContests.Location = new System.Drawing.Point(196, 6);
            this.btnRefreshContests.Name = "btnRefreshContests";
            this.btnRefreshContests.Size = new System.Drawing.Size(34, 22);
            this.btnRefreshContests.TabIndex = 1;
            this.btnRefreshContests.Text = "⟳";
            this.btnRefreshContests.UseVisualStyleBackColor = false;

            // pnlContestFilters
            this.pnlContestFilters.BackColor = System.Drawing.Color.FromArgb(24, 33, 47);
            this.pnlContestFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContestFilters.Location = new System.Drawing.Point(0, 34);
            this.pnlContestFilters.Name = "pnlContestFilters";
            this.pnlContestFilters.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.pnlContestFilters.Size = new System.Drawing.Size(238, 60);
            this.pnlContestFilters.TabIndex = 1;
            this.pnlContestFilters.Controls.Add(this.cmbStatusFilter);
            this.pnlContestFilters.Controls.Add(this.txtContestSearch);

            this.txtContestSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContestSearch.BackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.txtContestSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContestSearch.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtContestSearch.ForeColor = System.Drawing.Color.FromArgb(156, 163, 175);
            this.txtContestSearch.Location = new System.Drawing.Point(8, 6);
            this.txtContestSearch.Name = "txtContestSearch";
            this.txtContestSearch.Size = new System.Drawing.Size(222, 22);
            this.txtContestSearch.TabIndex = 0;
            this.txtContestSearch.Text = "Search contests...";

            this.cmbStatusFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStatusFilter.BackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.cmbStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStatusFilter.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.cmbStatusFilter.ForeColor = System.Drawing.Color.FromArgb(156, 163, 175);
            this.cmbStatusFilter.Location = new System.Drawing.Point(8, 33);
            this.cmbStatusFilter.Name = "cmbStatusFilter";
            this.cmbStatusFilter.Size = new System.Drawing.Size(222, 22);
            this.cmbStatusFilter.TabIndex = 1;
            this.cmbStatusFilter.Items.AddRange(new object[] {
                "All Contests",
                "Upcoming",
                "Active",
                "Finished"
            });
            this.cmbStatusFilter.SelectedIndex = 0;

            // dgvContestList
            this.dgvContestList.AllowUserToAddRows = false;
            this.dgvContestList.AllowUserToDeleteRows = false;
            this.dgvContestList.AllowUserToResizeRows = false;
            this.dgvContestList.BackgroundColor = System.Drawing.Color.FromArgb(24, 33, 47);
            this.dgvContestList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvContestList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvContestList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvContestList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvContestList.ColumnHeadersHeight = 28;
            this.dgvContestList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContestList.EnableHeadersVisualStyles = false;
            this.dgvContestList.GridColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.dgvContestList.Location = new System.Drawing.Point(0, 94);
            this.dgvContestList.MultiSelect = false;
            this.dgvContestList.Name = "dgvContestList";
            this.dgvContestList.ReadOnly = true;
            this.dgvContestList.RowHeadersVisible = false;
            this.dgvContestList.RowTemplate.Height = 28;
            this.dgvContestList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvContestList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContestList.Size = new System.Drawing.Size(238, 386);
            this.dgvContestList.TabIndex = 2;

            this.dgvContestList.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.dgvContestList.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(75, 85, 99);
            this.dgvContestList.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 7.5F, System.Drawing.FontStyle.Bold);
            this.dgvContestList.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.dgvContestList.ColumnHeadersDefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(75, 85, 99);

            this.dgvContestList.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(24, 33, 47);
            this.dgvContestList.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(156, 163, 175);
            this.dgvContestList.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.dgvContestList.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.dgvContestList.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.dgvContestList.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dgvContestList.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(20, 28, 41);
            this.dgvContestList.AlternatingRowsDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(156, 163, 175);

            // Contest list columns
            this.colContestName.HeaderText = "Contest";
            this.colContestName.Name = "colContestName";
            this.colContestName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colContestName.FillWeight = 48;
            this.colContestName.MinimumWidth = 70;

            this.colContestDifficulty.HeaderText = "Level";
            this.colContestDifficulty.Name = "colContestDifficulty";
            this.colContestDifficulty.Width = 46;
            this.colContestDifficulty.MinimumWidth = 40;
            this.colContestDifficulty.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;

            this.colContestStatus.HeaderText = "Status";
            this.colContestStatus.Name = "colContestStatus";
            this.colContestStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colContestStatus.FillWeight = 30;
            this.colContestStatus.MinimumWidth = 52;
            this.colContestStatus.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;

            this.colContestProblems.HeaderText = "Probs";
            this.colContestProblems.Name = "colContestProblems";
            this.colContestProblems.Width = 40;
            this.colContestProblems.MinimumWidth = 36;
            this.colContestProblems.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;

            this.dgvContestList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colContestName,
                this.colContestDifficulty,
                this.colContestStatus,
                this.colContestProblems
            });

            // ══════════════════════════════════════════════════════════════
            //  CENTER COLUMN
            // ══════════════════════════════════════════════════════════════
            this.pnlCenterColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCenterColumn.BackColor = System.Drawing.Color.Transparent;
            this.pnlCenterColumn.Location = new System.Drawing.Point(256, 8);
            this.pnlCenterColumn.Name = "pnlCenterColumn";
            this.pnlCenterColumn.Size = new System.Drawing.Size(614, 480);
            this.pnlCenterColumn.TabIndex = 1;
            this.pnlCenterColumn.Controls.Add(this.pnlProgressCard);
            this.pnlCenterColumn.Controls.Add(this.pnlContestProblemsCard);
            this.pnlCenterColumn.Controls.Add(this.pnlContestDetailCard);

            // ── Contest Detail Card (top of center, 152 px tall) ──────────
            this.pnlContestDetailCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContestDetailCard.BackColor = System.Drawing.Color.FromArgb(24, 33, 47);
            this.pnlContestDetailCard.Location = new System.Drawing.Point(0, 0);
            this.pnlContestDetailCard.Name = "pnlContestDetailCard";
            this.pnlContestDetailCard.Size = new System.Drawing.Size(614, 152);
            this.pnlContestDetailCard.TabIndex = 0;
            this.pnlContestDetailCard.Controls.Add(this.txtContestDescription);
            this.pnlContestDetailCard.Controls.Add(this.pnlContestDetailBadges);
            this.pnlContestDetailCard.Controls.Add(this.pnlContestDetailHeader);
            // pnlContestDetailHeader
            this.pnlContestDetailHeader.BackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.pnlContestDetailHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContestDetailHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlContestDetailHeader.Name = "pnlContestDetailHeader";
            this.pnlContestDetailHeader.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.pnlContestDetailHeader.Size = new System.Drawing.Size(614, 34);
            this.pnlContestDetailHeader.TabIndex = 0;
            this.pnlContestDetailHeader.Controls.Add(this.lblContestDetailTitle);
            this.pnlContestDetailHeader.Controls.Add(this.pnlContestDetailAccent);

            this.pnlContestDetailAccent.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.pnlContestDetailAccent.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlContestDetailAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlContestDetailAccent.Name = "pnlContestDetailAccent";
            this.pnlContestDetailAccent.Size = new System.Drawing.Size(3, 34);
            this.pnlContestDetailAccent.TabIndex = 1;

            this.lblContestDetailTitle.AutoSize = false;
            this.lblContestDetailTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblContestDetailTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblContestDetailTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblContestDetailTitle.ForeColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.lblContestDetailTitle.Location = new System.Drawing.Point(3, 0);
            this.lblContestDetailTitle.Name = "lblContestDetailTitle";
            this.lblContestDetailTitle.Size = new System.Drawing.Size(601, 34);
            this.lblContestDetailTitle.TabIndex = 0;
            this.lblContestDetailTitle.Text = "Select a contest to view details";
            this.lblContestDetailTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblContestDetailTitle.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);

            // pnlContestDetailBadges  — five info-badge pills
            this.pnlContestDetailBadges.BackColor = System.Drawing.Color.FromArgb(24, 33, 47);
            this.pnlContestDetailBadges.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContestDetailBadges.Location = new System.Drawing.Point(0, 34);
            this.pnlContestDetailBadges.Name = "pnlContestDetailBadges";
            this.pnlContestDetailBadges.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.pnlContestDetailBadges.Size = new System.Drawing.Size(614, 32);
            this.pnlContestDetailBadges.TabIndex = 1;
            this.pnlContestDetailBadges.Controls.Add(this.pnlBadgeTotalPoints);
            this.pnlContestDetailBadges.Controls.Add(this.pnlBadgeTotalProblems);
            this.pnlContestDetailBadges.Controls.Add(this.pnlBadgeDuration);
            this.pnlContestDetailBadges.Controls.Add(this.pnlBadgeEndDate);
            this.pnlContestDetailBadges.Controls.Add(this.pnlBadgeStartDate);

            // helper method — badge panel builder (inlined for each badge)
            // pnlBadgeStartDate
            this.pnlBadgeStartDate.BackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.pnlBadgeStartDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBadgeStartDate.Location = new System.Drawing.Point(10, 5);
            this.pnlBadgeStartDate.Name = "pnlBadgeStartDate";
            this.pnlBadgeStartDate.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.pnlBadgeStartDate.Size = new System.Drawing.Size(110, 22);
            this.pnlBadgeStartDate.TabIndex = 0;
            this.pnlBadgeStartDate.Controls.Add(this.lblBadgeStartValue);
            this.pnlBadgeStartDate.Controls.Add(this.lblBadgeStartIcon);

            this.lblBadgeStartIcon.AutoSize = false;
            this.lblBadgeStartIcon.BackColor = System.Drawing.Color.Transparent;
            this.lblBadgeStartIcon.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblBadgeStartIcon.ForeColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.lblBadgeStartIcon.Location = new System.Drawing.Point(5, 2);
            this.lblBadgeStartIcon.Name = "lblBadgeStartIcon";
            this.lblBadgeStartIcon.Size = new System.Drawing.Size(14, 16);
            this.lblBadgeStartIcon.TabIndex = 0;
            this.lblBadgeStartIcon.Text = "▶";
            this.lblBadgeStartIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblBadgeStartValue.AutoSize = false;
            this.lblBadgeStartValue.BackColor = System.Drawing.Color.Transparent;
            this.lblBadgeStartValue.Font = new System.Drawing.Font("Segoe UI Semibold", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblBadgeStartValue.ForeColor = System.Drawing.Color.FromArgb(156, 163, 175);
            this.lblBadgeStartValue.Location = new System.Drawing.Point(21, 2);
            this.lblBadgeStartValue.Name = "lblBadgeStartValue";
            this.lblBadgeStartValue.Size = new System.Drawing.Size(84, 16);
            this.lblBadgeStartValue.TabIndex = 1;
            this.lblBadgeStartValue.Text = "Start: —";

            // pnlBadgeEndDate
            this.pnlBadgeEndDate.BackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.pnlBadgeEndDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBadgeEndDate.Location = new System.Drawing.Point(128, 5);
            this.pnlBadgeEndDate.Name = "pnlBadgeEndDate";
            this.pnlBadgeEndDate.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.pnlBadgeEndDate.Size = new System.Drawing.Size(110, 22);
            this.pnlBadgeEndDate.TabIndex = 1;
            this.pnlBadgeEndDate.Controls.Add(this.lblBadgeEndValue);
            this.pnlBadgeEndDate.Controls.Add(this.lblBadgeEndIcon);

            this.lblBadgeEndIcon.AutoSize = false;
            this.lblBadgeEndIcon.BackColor = System.Drawing.Color.Transparent;
            this.lblBadgeEndIcon.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblBadgeEndIcon.ForeColor = System.Drawing.Color.FromArgb(245, 158, 11);
            this.lblBadgeEndIcon.Location = new System.Drawing.Point(5, 2);
            this.lblBadgeEndIcon.Name = "lblBadgeEndIcon";
            this.lblBadgeEndIcon.Size = new System.Drawing.Size(14, 16);
            this.lblBadgeEndIcon.TabIndex = 0;
            this.lblBadgeEndIcon.Text = "■";
            this.lblBadgeEndIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblBadgeEndValue.AutoSize = false;
            this.lblBadgeEndValue.BackColor = System.Drawing.Color.Transparent;
            this.lblBadgeEndValue.Font = new System.Drawing.Font("Segoe UI Semibold", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblBadgeEndValue.ForeColor = System.Drawing.Color.FromArgb(156, 163, 175);
            this.lblBadgeEndValue.Location = new System.Drawing.Point(21, 2);
            this.lblBadgeEndValue.Name = "lblBadgeEndValue";
            this.lblBadgeEndValue.Size = new System.Drawing.Size(84, 16);
            this.lblBadgeEndValue.TabIndex = 1;
            this.lblBadgeEndValue.Text = "End: —";

            // pnlBadgeDuration
            this.pnlBadgeDuration.BackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.pnlBadgeDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBadgeDuration.Location = new System.Drawing.Point(246, 5);
            this.pnlBadgeDuration.Name = "pnlBadgeDuration";
            this.pnlBadgeDuration.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.pnlBadgeDuration.Size = new System.Drawing.Size(94, 22);
            this.pnlBadgeDuration.TabIndex = 2;
            this.pnlBadgeDuration.Controls.Add(this.lblBadgeDurationValue);
            this.pnlBadgeDuration.Controls.Add(this.lblBadgeDurationIcon);

            this.lblBadgeDurationIcon.AutoSize = false;
            this.lblBadgeDurationIcon.BackColor = System.Drawing.Color.Transparent;
            this.lblBadgeDurationIcon.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblBadgeDurationIcon.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblBadgeDurationIcon.Location = new System.Drawing.Point(5, 2);
            this.lblBadgeDurationIcon.Name = "lblBadgeDurationIcon";
            this.lblBadgeDurationIcon.Size = new System.Drawing.Size(14, 16);
            this.lblBadgeDurationIcon.TabIndex = 0;
            this.lblBadgeDurationIcon.Text = "⏱";
            this.lblBadgeDurationIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblBadgeDurationValue.AutoSize = false;
            this.lblBadgeDurationValue.BackColor = System.Drawing.Color.Transparent;
            this.lblBadgeDurationValue.Font = new System.Drawing.Font("Segoe UI Semibold", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblBadgeDurationValue.ForeColor = System.Drawing.Color.FromArgb(156, 163, 175);
            this.lblBadgeDurationValue.Location = new System.Drawing.Point(21, 2);
            this.lblBadgeDurationValue.Name = "lblBadgeDurationValue";
            this.lblBadgeDurationValue.Size = new System.Drawing.Size(68, 16);
            this.lblBadgeDurationValue.TabIndex = 1;
            this.lblBadgeDurationValue.Text = "—";

            // pnlBadgeTotalProblems
            this.pnlBadgeTotalProblems.BackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.pnlBadgeTotalProblems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBadgeTotalProblems.Location = new System.Drawing.Point(348, 5);
            this.pnlBadgeTotalProblems.Name = "pnlBadgeTotalProblems";
            this.pnlBadgeTotalProblems.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.pnlBadgeTotalProblems.Size = new System.Drawing.Size(100, 22);
            this.pnlBadgeTotalProblems.TabIndex = 3;
            this.pnlBadgeTotalProblems.Controls.Add(this.lblBadgeTotalProblemsValue);
            this.pnlBadgeTotalProblems.Controls.Add(this.lblBadgeTotalProblemsIcon);

            this.lblBadgeTotalProblemsIcon.AutoSize = false;
            this.lblBadgeTotalProblemsIcon.BackColor = System.Drawing.Color.Transparent;
            this.lblBadgeTotalProblemsIcon.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblBadgeTotalProblemsIcon.ForeColor = System.Drawing.Color.FromArgb(79, 70, 229);
            this.lblBadgeTotalProblemsIcon.Location = new System.Drawing.Point(5, 2);
            this.lblBadgeTotalProblemsIcon.Name = "lblBadgeTotalProblemsIcon";
            this.lblBadgeTotalProblemsIcon.Size = new System.Drawing.Size(14, 16);
            this.lblBadgeTotalProblemsIcon.TabIndex = 0;
            this.lblBadgeTotalProblemsIcon.Text = "≡";
            this.lblBadgeTotalProblemsIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblBadgeTotalProblemsValue.AutoSize = false;
            this.lblBadgeTotalProblemsValue.BackColor = System.Drawing.Color.Transparent;
            this.lblBadgeTotalProblemsValue.Font = new System.Drawing.Font("Segoe UI Semibold", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblBadgeTotalProblemsValue.ForeColor = System.Drawing.Color.FromArgb(156, 163, 175);
            this.lblBadgeTotalProblemsValue.Location = new System.Drawing.Point(21, 2);
            this.lblBadgeTotalProblemsValue.Name = "lblBadgeTotalProblemsValue";
            this.lblBadgeTotalProblemsValue.Size = new System.Drawing.Size(74, 16);
            this.lblBadgeTotalProblemsValue.TabIndex = 1;
            this.lblBadgeTotalProblemsValue.Text = "0 Problems";

            // pnlBadgeTotalPoints
            this.pnlBadgeTotalPoints.BackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.pnlBadgeTotalPoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBadgeTotalPoints.Location = new System.Drawing.Point(456, 5);
            this.pnlBadgeTotalPoints.Name = "pnlBadgeTotalPoints";
            this.pnlBadgeTotalPoints.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.pnlBadgeTotalPoints.Size = new System.Drawing.Size(92, 22);
            this.pnlBadgeTotalPoints.TabIndex = 4;
            this.pnlBadgeTotalPoints.Controls.Add(this.lblBadgeTotalPointsValue);
            this.pnlBadgeTotalPoints.Controls.Add(this.lblBadgeTotalPointsIcon);

            this.lblBadgeTotalPointsIcon.AutoSize = false;
            this.lblBadgeTotalPointsIcon.BackColor = System.Drawing.Color.Transparent;
            this.lblBadgeTotalPointsIcon.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblBadgeTotalPointsIcon.ForeColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.lblBadgeTotalPointsIcon.Location = new System.Drawing.Point(5, 2);
            this.lblBadgeTotalPointsIcon.Name = "lblBadgeTotalPointsIcon";
            this.lblBadgeTotalPointsIcon.Size = new System.Drawing.Size(14, 16);
            this.lblBadgeTotalPointsIcon.TabIndex = 0;
            this.lblBadgeTotalPointsIcon.Text = "★";
            this.lblBadgeTotalPointsIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblBadgeTotalPointsValue.AutoSize = false;
            this.lblBadgeTotalPointsValue.BackColor = System.Drawing.Color.Transparent;
            this.lblBadgeTotalPointsValue.Font = new System.Drawing.Font("Segoe UI Semibold", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblBadgeTotalPointsValue.ForeColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.lblBadgeTotalPointsValue.Location = new System.Drawing.Point(21, 2);
            this.lblBadgeTotalPointsValue.Name = "lblBadgeTotalPointsValue";
            this.lblBadgeTotalPointsValue.Size = new System.Drawing.Size(66, 16);
            this.lblBadgeTotalPointsValue.TabIndex = 1;
            this.lblBadgeTotalPointsValue.Text = "0 pts";

            // txtContestDescription
            this.txtContestDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContestDescription.BackColor = System.Drawing.Color.FromArgb(24, 33, 47);
            this.txtContestDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContestDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtContestDescription.ForeColor = System.Drawing.Color.FromArgb(156, 163, 175);
            this.txtContestDescription.Location = new System.Drawing.Point(10, 72);
            this.txtContestDescription.Name = "txtContestDescription";
            this.txtContestDescription.ReadOnly = true;
            this.txtContestDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtContestDescription.Size = new System.Drawing.Size(604, 72);
            this.txtContestDescription.TabIndex = 2;
            this.txtContestDescription.Text = "Contest description will appear here when you select a contest from the list on the left.";

            // ── Contest Problems Card ─────────────────────────────────────
            this.pnlContestProblemsCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContestProblemsCard.BackColor = System.Drawing.Color.FromArgb(24, 33, 47);
            this.pnlContestProblemsCard.Location = new System.Drawing.Point(0, 158);
            this.pnlContestProblemsCard.Name = "pnlContestProblemsCard";
            this.pnlContestProblemsCard.Size = new System.Drawing.Size(614, 264);
            this.pnlContestProblemsCard.TabIndex = 1;
            this.pnlContestProblemsCard.Controls.Add(this.dgvContestProblems);
            this.pnlContestProblemsCard.Controls.Add(this.pnlContestProblemsHeader);

            // pnlContestProblemsHeader
            this.pnlContestProblemsHeader.BackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.pnlContestProblemsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContestProblemsHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlContestProblemsHeader.Name = "pnlContestProblemsHeader";
            this.pnlContestProblemsHeader.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.pnlContestProblemsHeader.Size = new System.Drawing.Size(614, 32);
            this.pnlContestProblemsHeader.TabIndex = 0;
            this.pnlContestProblemsHeader.Controls.Add(this.lblContestProblemsHint);
            this.pnlContestProblemsHeader.Controls.Add(this.lblContestProblemsTitle);
            this.pnlContestProblemsHeader.Controls.Add(this.pnlContestProblemsAccent);

            this.pnlContestProblemsAccent.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.pnlContestProblemsAccent.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlContestProblemsAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlContestProblemsAccent.Name = "pnlContestProblemsAccent";
            this.pnlContestProblemsAccent.Size = new System.Drawing.Size(3, 32);
            this.pnlContestProblemsAccent.TabIndex = 2;

            this.lblContestProblemsTitle.AutoSize = false;
            this.lblContestProblemsTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblContestProblemsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblContestProblemsTitle.ForeColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.lblContestProblemsTitle.Location = new System.Drawing.Point(12, 0);
            this.lblContestProblemsTitle.Name = "lblContestProblemsTitle";
            this.lblContestProblemsTitle.Size = new System.Drawing.Size(200, 32);
            this.lblContestProblemsTitle.TabIndex = 0;
            this.lblContestProblemsTitle.Text = "Contest Problems";
            this.lblContestProblemsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.lblContestProblemsHint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContestProblemsHint.AutoSize = false;
            this.lblContestProblemsHint.BackColor = System.Drawing.Color.Transparent;
            this.lblContestProblemsHint.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblContestProblemsHint.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81);
            this.lblContestProblemsHint.Location = new System.Drawing.Point(320, 0);
            this.lblContestProblemsHint.Name = "lblContestProblemsHint";
            this.lblContestProblemsHint.Size = new System.Drawing.Size(284, 32);
            this.lblContestProblemsHint.TabIndex = 1;
            this.lblContestProblemsHint.Text = "Double-click a row to view full problem details →";
            this.lblContestProblemsHint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // dgvContestProblems
            this.dgvContestProblems.AllowUserToAddRows = false;
            this.dgvContestProblems.AllowUserToDeleteRows = false;
            this.dgvContestProblems.AllowUserToResizeRows = false;
            this.dgvContestProblems.BackgroundColor = System.Drawing.Color.FromArgb(24, 33, 47);
            this.dgvContestProblems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvContestProblems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvContestProblems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvContestProblems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvContestProblems.ColumnHeadersHeight = 28;
            this.dgvContestProblems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContestProblems.EnableHeadersVisualStyles = false;
            this.dgvContestProblems.GridColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.dgvContestProblems.Location = new System.Drawing.Point(0, 32);
            this.dgvContestProblems.MultiSelect = false;
            this.dgvContestProblems.Name = "dgvContestProblems";
            this.dgvContestProblems.ReadOnly = true;
            this.dgvContestProblems.RowHeadersVisible = false;
            this.dgvContestProblems.RowTemplate.Height = 28;
            this.dgvContestProblems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvContestProblems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContestProblems.Size = new System.Drawing.Size(614, 232);
            this.dgvContestProblems.TabIndex = 1;

            this.dgvContestProblems.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.dgvContestProblems.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(75, 85, 99);
            this.dgvContestProblems.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 7.5F, System.Drawing.FontStyle.Bold);
            this.dgvContestProblems.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.dgvContestProblems.ColumnHeadersDefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(75, 85, 99);

            this.dgvContestProblems.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(24, 33, 47);
            this.dgvContestProblems.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(156, 163, 175);
            this.dgvContestProblems.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.dgvContestProblems.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.dgvContestProblems.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.dgvContestProblems.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dgvContestProblems.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(20, 28, 41);
            this.dgvContestProblems.AlternatingRowsDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(156, 163, 175);

            this.colProblemName.HeaderText = "Problem Name";
            this.colProblemName.Name = "colProblemName";
            this.colProblemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProblemName.FillWeight = 48;
            this.colProblemName.MinimumWidth = 80;

            this.colProblemDifficulty.HeaderText = "Difficulty";
            this.colProblemDifficulty.Name = "colProblemDifficulty";
            this.colProblemDifficulty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProblemDifficulty.FillWeight = 18;
            this.colProblemDifficulty.MinimumWidth = 56;
            this.colProblemDifficulty.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;

            this.colProblemPoints.HeaderText = "Points";
            this.colProblemPoints.Name = "colProblemPoints";
            this.colProblemPoints.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProblemPoints.FillWeight = 14;
            this.colProblemPoints.MinimumWidth = 46;
            this.colProblemPoints.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;

            this.colProblemSolvedStatus.HeaderText = "Status";
            this.colProblemSolvedStatus.Name = "colProblemSolvedStatus";
            this.colProblemSolvedStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProblemSolvedStatus.FillWeight = 20;
            this.colProblemSolvedStatus.MinimumWidth = 64;
            this.colProblemSolvedStatus.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;

            this.dgvContestProblems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colProblemName,
                this.colProblemDifficulty,
                this.colProblemPoints,
                this.colProblemSolvedStatus
            });

            // ── Progress Card (bottom of center) ─────────────────────────
            this.pnlProgressCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProgressCard.BackColor = System.Drawing.Color.FromArgb(24, 33, 47);
            this.pnlProgressCard.Location = new System.Drawing.Point(0, 428);
            this.pnlProgressCard.Name = "pnlProgressCard";
            this.pnlProgressCard.Size = new System.Drawing.Size(614, 52);
            this.pnlProgressCard.TabIndex = 2;
            this.pnlProgressCard.Controls.Add(this.pnlProgressBody);
            this.pnlProgressCard.Controls.Add(this.pnlProgressHeader);

            // pnlProgressHeader
            this.pnlProgressHeader.BackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.pnlProgressHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProgressHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlProgressHeader.Name = "pnlProgressHeader";
            this.pnlProgressHeader.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.pnlProgressHeader.Size = new System.Drawing.Size(614, 24);
            this.pnlProgressHeader.TabIndex = 0;
            this.pnlProgressHeader.Controls.Add(this.lblProgressFraction);
            this.pnlProgressHeader.Controls.Add(this.lblProgressTitle);
            this.pnlProgressHeader.Controls.Add(this.pnlProgressAccent);

            this.pnlProgressAccent.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.pnlProgressAccent.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlProgressAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlProgressAccent.Name = "pnlProgressAccent";
            this.pnlProgressAccent.Size = new System.Drawing.Size(3, 24);
            this.pnlProgressAccent.TabIndex = 2;

            this.lblProgressTitle.AutoSize = false;
            this.lblProgressTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblProgressTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblProgressTitle.ForeColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.lblProgressTitle.Location = new System.Drawing.Point(12, 0);
            this.lblProgressTitle.Name = "lblProgressTitle";
            this.lblProgressTitle.Size = new System.Drawing.Size(200, 24);
            this.lblProgressTitle.TabIndex = 0;
            this.lblProgressTitle.Text = "Contest Progress";
            this.lblProgressTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.lblProgressFraction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProgressFraction.AutoSize = false;
            this.lblProgressFraction.BackColor = System.Drawing.Color.Transparent;
            this.lblProgressFraction.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lblProgressFraction.ForeColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.lblProgressFraction.Location = new System.Drawing.Point(450, 0);
            this.lblProgressFraction.Name = "lblProgressFraction";
            this.lblProgressFraction.Size = new System.Drawing.Size(154, 24);
            this.lblProgressFraction.TabIndex = 1;
            this.lblProgressFraction.Text = "0 / 0 solved";
            this.lblProgressFraction.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // pnlProgressBody — track + fill bar + percent label
            this.pnlProgressBody.BackColor = System.Drawing.Color.FromArgb(24, 33, 47);
            this.pnlProgressBody.Location = new System.Drawing.Point(0, 24);
            this.pnlProgressBody.Name = "pnlProgressBody";
            this.pnlProgressBody.Padding = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.pnlProgressBody.Size = new System.Drawing.Size(614, 28);
            this.pnlProgressBody.TabIndex = 1;
            this.pnlProgressBody.Controls.Add(this.lblProgressPercent);
            this.pnlProgressBody.Controls.Add(this.pnlProgressTrack);

            this.pnlProgressTrack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProgressTrack.BackColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.pnlProgressTrack.Location = new System.Drawing.Point(10, 8);
            this.pnlProgressTrack.Name = "pnlProgressTrack";
            this.pnlProgressTrack.Size = new System.Drawing.Size(554, 10);
            this.pnlProgressTrack.TabIndex = 0;
            this.pnlProgressTrack.Controls.Add(this.pnlProgressFill);

            this.pnlProgressFill.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.pnlProgressFill.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlProgressFill.Location = new System.Drawing.Point(0, 0);
            this.pnlProgressFill.Name = "pnlProgressFill";
            this.pnlProgressFill.Size = new System.Drawing.Size(0, 10);
            this.pnlProgressFill.TabIndex = 0;

            this.lblProgressPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProgressPercent.AutoSize = false;
            this.lblProgressPercent.BackColor = System.Drawing.Color.Transparent;
            this.lblProgressPercent.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblProgressPercent.ForeColor = System.Drawing.Color.FromArgb(75, 85, 99);
            this.lblProgressPercent.Location = new System.Drawing.Point(568, 4);
            this.lblProgressPercent.Name = "lblProgressPercent";
            this.lblProgressPercent.Size = new System.Drawing.Size(36, 18);
            this.lblProgressPercent.TabIndex = 1;
            this.lblProgressPercent.Text = "0%";
            this.lblProgressPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // ══════════════════════════════════════════════════════════════
            //  RIGHT COLUMN — Problem Detail Card (228 px wide)
            // ══════════════════════════════════════════════════════════════
            this.pnlRightColumn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRightColumn.BackColor = System.Drawing.Color.Transparent;
            this.pnlRightColumn.Location = new System.Drawing.Point(878, 8);
            this.pnlRightColumn.Name = "pnlRightColumn";
            this.pnlRightColumn.Size = new System.Drawing.Size(270, 480);
            this.pnlRightColumn.TabIndex = 2;
            this.pnlRightColumn.Controls.Add(this.pnlProblemDetailCard);

            // pnlProblemDetailCard
            this.pnlProblemDetailCard.BackColor = System.Drawing.Color.FromArgb(24, 33, 47);
            this.pnlProblemDetailCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProblemDetailCard.Location = new System.Drawing.Point(0, 0);
            this.pnlProblemDetailCard.Name = "pnlProblemDetailCard";
            this.pnlProblemDetailCard.Size = new System.Drawing.Size(270, 480);
            this.pnlProblemDetailCard.TabIndex = 0;
            this.pnlProblemDetailCard.Controls.Add(this.pnlProbSolvedStatus);
            this.pnlProblemDetailCard.Controls.Add(this.pnlProbDetailBody);
            this.pnlProblemDetailCard.Controls.Add(this.pnlProblemDetailBadges);
            this.pnlProblemDetailCard.Controls.Add(this.pnlProblemDetailHeader);

            // pnlProblemDetailHeader
            this.pnlProblemDetailHeader.BackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.pnlProblemDetailHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProblemDetailHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlProblemDetailHeader.Name = "pnlProblemDetailHeader";
            this.pnlProblemDetailHeader.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.pnlProblemDetailHeader.Size = new System.Drawing.Size(270, 34);
            this.pnlProblemDetailHeader.TabIndex = 0;
            this.pnlProblemDetailHeader.Controls.Add(this.lblProblemDetailTitle);
            this.pnlProblemDetailHeader.Controls.Add(this.pnlProblemDetailAccent);

            this.pnlProblemDetailAccent.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.pnlProblemDetailAccent.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlProblemDetailAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlProblemDetailAccent.Name = "pnlProblemDetailAccent";
            this.pnlProblemDetailAccent.Size = new System.Drawing.Size(3, 34);
            this.pnlProblemDetailAccent.TabIndex = 1;

            this.lblProblemDetailTitle.AutoSize = false;
            this.lblProblemDetailTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblProblemDetailTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProblemDetailTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblProblemDetailTitle.ForeColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.lblProblemDetailTitle.Location = new System.Drawing.Point(3, 0);
            this.lblProblemDetailTitle.Name = "lblProblemDetailTitle";
            this.lblProblemDetailTitle.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.lblProblemDetailTitle.Size = new System.Drawing.Size(259, 34);
            this.lblProblemDetailTitle.TabIndex = 0;
            this.lblProblemDetailTitle.Text = "Problem Details";
            this.lblProblemDetailTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // pnlProblemDetailBadges — difficulty + points pills
            this.pnlProblemDetailBadges.BackColor = System.Drawing.Color.FromArgb(24, 33, 47);
            this.pnlProblemDetailBadges.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProblemDetailBadges.Location = new System.Drawing.Point(0, 34);
            this.pnlProblemDetailBadges.Name = "pnlProblemDetailBadges";
            this.pnlProblemDetailBadges.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.pnlProblemDetailBadges.Size = new System.Drawing.Size(270, 32);
            this.pnlProblemDetailBadges.TabIndex = 1;
            this.pnlProblemDetailBadges.Controls.Add(this.pnlProbPointsBadge);
            this.pnlProblemDetailBadges.Controls.Add(this.pnlProbDiffBadge);

            // pnlProbDiffBadge
            this.pnlProbDiffBadge.BackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.pnlProbDiffBadge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProbDiffBadge.Location = new System.Drawing.Point(10, 5);
            this.pnlProbDiffBadge.Name = "pnlProbDiffBadge";
            this.pnlProbDiffBadge.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.pnlProbDiffBadge.Size = new System.Drawing.Size(110, 22);
            this.pnlProbDiffBadge.TabIndex = 0;
            this.pnlProbDiffBadge.Controls.Add(this.lblProbDiffValue);
            this.pnlProbDiffBadge.Controls.Add(this.lblProbDiffIcon);

            this.lblProbDiffIcon.AutoSize = false;
            this.lblProbDiffIcon.BackColor = System.Drawing.Color.Transparent;
            this.lblProbDiffIcon.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblProbDiffIcon.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblProbDiffIcon.Location = new System.Drawing.Point(5, 2);
            this.lblProbDiffIcon.Name = "lblProbDiffIcon";
            this.lblProbDiffIcon.Size = new System.Drawing.Size(14, 16);
            this.lblProbDiffIcon.TabIndex = 0;
            this.lblProbDiffIcon.Text = "◈";
            this.lblProbDiffIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblProbDiffValue.AutoSize = false;
            this.lblProbDiffValue.BackColor = System.Drawing.Color.Transparent;
            this.lblProbDiffValue.Font = new System.Drawing.Font("Segoe UI Semibold", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblProbDiffValue.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblProbDiffValue.Location = new System.Drawing.Point(21, 2);
            this.lblProbDiffValue.Name = "lblProbDiffValue";
            this.lblProbDiffValue.Size = new System.Drawing.Size(84, 16);
            this.lblProbDiffValue.TabIndex = 1;
            this.lblProbDiffValue.Text = "—";

            // pnlProbPointsBadge
            this.pnlProbPointsBadge.BackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.pnlProbPointsBadge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProbPointsBadge.Location = new System.Drawing.Point(128, 5);
            this.pnlProbPointsBadge.Name = "pnlProbPointsBadge";
            this.pnlProbPointsBadge.Padding = new System.Windows.Forms.Padding(5, 1, 5, 1);
            this.pnlProbPointsBadge.Size = new System.Drawing.Size(88, 22);
            this.pnlProbPointsBadge.TabIndex = 1;
            this.pnlProbPointsBadge.Controls.Add(this.lblProbPointsValue);
            this.pnlProbPointsBadge.Controls.Add(this.lblProbPointsIcon);

            this.lblProbPointsIcon.AutoSize = false;
            this.lblProbPointsIcon.BackColor = System.Drawing.Color.Transparent;
            this.lblProbPointsIcon.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblProbPointsIcon.ForeColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.lblProbPointsIcon.Location = new System.Drawing.Point(5, 2);
            this.lblProbPointsIcon.Name = "lblProbPointsIcon";
            this.lblProbPointsIcon.Size = new System.Drawing.Size(14, 16);
            this.lblProbPointsIcon.TabIndex = 0;
            this.lblProbPointsIcon.Text = "★";
            this.lblProbPointsIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblProbPointsValue.AutoSize = false;
            this.lblProbPointsValue.BackColor = System.Drawing.Color.Transparent;
            this.lblProbPointsValue.Font = new System.Drawing.Font("Segoe UI Semibold", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblProbPointsValue.ForeColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.lblProbPointsValue.Location = new System.Drawing.Point(21, 2);
            this.lblProbPointsValue.Name = "lblProbPointsValue";
            this.lblProbPointsValue.Size = new System.Drawing.Size(62, 16);
            this.lblProbPointsValue.TabIndex = 1;
            this.lblProbPointsValue.Text = "— pts";

            // pnlProbDetailBody — tags, description, constraints, allowed DB
            this.pnlProbDetailBody.BackColor = System.Drawing.Color.FromArgb(24, 33, 47);
            this.pnlProbDetailBody.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProbDetailBody.Location = new System.Drawing.Point(0, 66);
            this.pnlProbDetailBody.Name = "pnlProbDetailBody";
            this.pnlProbDetailBody.Padding = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.pnlProbDetailBody.Size = new System.Drawing.Size(270, 346);
            this.pnlProbDetailBody.TabIndex = 2;
            this.pnlProbDetailBody.Controls.Add(this.lblProbAllowedDbValue);
            this.pnlProbDetailBody.Controls.Add(this.lblProbAllowedDbCaption);
            this.pnlProbDetailBody.Controls.Add(this.txtProblemConstraints);
            this.pnlProbDetailBody.Controls.Add(this.lblProbConstraintsCaption);
            this.pnlProbDetailBody.Controls.Add(this.txtProblemShortDesc);
            this.pnlProbDetailBody.Controls.Add(this.lblProbDescCaption);
            this.pnlProbDetailBody.Controls.Add(this.lblProbTagsValue);
            this.pnlProbDetailBody.Controls.Add(this.lblProbTagsCaption);

            // Tags row
            this.lblProbTagsCaption.AutoSize = false;
            this.lblProbTagsCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblProbTagsCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblProbTagsCaption.ForeColor = System.Drawing.Color.FromArgb(75, 85, 99);
            this.lblProbTagsCaption.Location = new System.Drawing.Point(10, 6);
            this.lblProbTagsCaption.Name = "lblProbTagsCaption";
            this.lblProbTagsCaption.Size = new System.Drawing.Size(50, 14);
            this.lblProbTagsCaption.TabIndex = 0;
            this.lblProbTagsCaption.Text = "TAGS";

            this.lblProbTagsValue.AutoSize = false;
            this.lblProbTagsValue.BackColor = System.Drawing.Color.Transparent;
            this.lblProbTagsValue.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblProbTagsValue.ForeColor = System.Drawing.Color.FromArgb(156, 163, 175);
            this.lblProbTagsValue.Location = new System.Drawing.Point(10, 22);
            this.lblProbTagsValue.Name = "lblProbTagsValue";
            this.lblProbTagsValue.Size = new System.Drawing.Size(248, 18);
            this.lblProbTagsValue.TabIndex = 1;
            this.lblProbTagsValue.Text = "—";

            // Description section
            this.lblProbDescCaption.AutoSize = false;
            this.lblProbDescCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblProbDescCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblProbDescCaption.ForeColor = System.Drawing.Color.FromArgb(75, 85, 99);
            this.lblProbDescCaption.Location = new System.Drawing.Point(10, 46);
            this.lblProbDescCaption.Name = "lblProbDescCaption";
            this.lblProbDescCaption.Size = new System.Drawing.Size(100, 14);
            this.lblProbDescCaption.TabIndex = 2;
            this.lblProbDescCaption.Text = "DESCRIPTION";

            this.txtProblemShortDesc.BackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.txtProblemShortDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProblemShortDesc.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtProblemShortDesc.ForeColor = System.Drawing.Color.FromArgb(156, 163, 175);
            this.txtProblemShortDesc.Location = new System.Drawing.Point(10, 62);
            this.txtProblemShortDesc.Name = "txtProblemShortDesc";
            this.txtProblemShortDesc.ReadOnly = true;
            this.txtProblemShortDesc.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtProblemShortDesc.Size = new System.Drawing.Size(248, 82);
            this.txtProblemShortDesc.TabIndex = 3;
            this.txtProblemShortDesc.Text = "Select a problem from the grid to view its description.";

            // Constraints section
            this.lblProbConstraintsCaption.AutoSize = false;
            this.lblProbConstraintsCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblProbConstraintsCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblProbConstraintsCaption.ForeColor = System.Drawing.Color.FromArgb(75, 85, 99);
            this.lblProbConstraintsCaption.Location = new System.Drawing.Point(10, 150);
            this.lblProbConstraintsCaption.Name = "lblProbConstraintsCaption";
            this.lblProbConstraintsCaption.Size = new System.Drawing.Size(100, 14);
            this.lblProbConstraintsCaption.TabIndex = 4;
            this.lblProbConstraintsCaption.Text = "CONSTRAINTS";

            this.txtProblemConstraints.BackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.txtProblemConstraints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProblemConstraints.Font = new System.Drawing.Font("Consolas", 8F);
            this.txtProblemConstraints.ForeColor = System.Drawing.Color.FromArgb(156, 163, 175);
            this.txtProblemConstraints.Location = new System.Drawing.Point(10, 166);
            this.txtProblemConstraints.Name = "txtProblemConstraints";
            this.txtProblemConstraints.ReadOnly = true;
            this.txtProblemConstraints.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtProblemConstraints.Size = new System.Drawing.Size(248, 110);
            this.txtProblemConstraints.TabIndex = 5;
            this.txtProblemConstraints.Text = "—";

            // Allowed DB row
            this.lblProbAllowedDbCaption.AutoSize = false;
            this.lblProbAllowedDbCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblProbAllowedDbCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblProbAllowedDbCaption.ForeColor = System.Drawing.Color.FromArgb(75, 85, 99);
            this.lblProbAllowedDbCaption.Location = new System.Drawing.Point(10, 282);
            this.lblProbAllowedDbCaption.Name = "lblProbAllowedDbCaption";
            this.lblProbAllowedDbCaption.Size = new System.Drawing.Size(120, 14);
            this.lblProbAllowedDbCaption.TabIndex = 6;
            this.lblProbAllowedDbCaption.Text = "ALLOWED DATABASE";

            this.lblProbAllowedDbValue.AutoSize = false;
            this.lblProbAllowedDbValue.BackColor = System.Drawing.Color.Transparent;
            this.lblProbAllowedDbValue.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblProbAllowedDbValue.ForeColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.lblProbAllowedDbValue.Location = new System.Drawing.Point(10, 298);
            this.lblProbAllowedDbValue.Name = "lblProbAllowedDbValue";
            this.lblProbAllowedDbValue.Size = new System.Drawing.Size(248, 18);
            this.lblProbAllowedDbValue.TabIndex = 7;
            this.lblProbAllowedDbValue.Text = "—";

            // pnlProbSolvedStatus — coloured strip at bottom of card
            this.pnlProbSolvedStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlProbSolvedStatus.BackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.pnlProbSolvedStatus.Location = new System.Drawing.Point(0, 444);
            this.pnlProbSolvedStatus.Name = "pnlProbSolvedStatus";
            this.pnlProbSolvedStatus.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.pnlProbSolvedStatus.Size = new System.Drawing.Size(270, 36);
            this.pnlProbSolvedStatus.TabIndex = 3;
            this.pnlProbSolvedStatus.Controls.Add(this.lblProbSolvedStatusValue);
            this.pnlProbSolvedStatus.Controls.Add(this.lblProbSolvedStatusCaption);
            this.pnlProbSolvedStatus.Controls.Add(this.pnlProbSolvedAccent);

            this.pnlProbSolvedAccent.BackColor = System.Drawing.Color.FromArgb(245, 158, 11);
            this.pnlProbSolvedAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProbSolvedAccent.Location = new System.Drawing.Point(10, 0);
            this.pnlProbSolvedAccent.Name = "pnlProbSolvedAccent";
            this.pnlProbSolvedAccent.Size = new System.Drawing.Size(250, 1);
            this.pnlProbSolvedAccent.TabIndex = 2;

            this.lblProbSolvedStatusCaption.AutoSize = false;
            this.lblProbSolvedStatusCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblProbSolvedStatusCaption.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblProbSolvedStatusCaption.ForeColor = System.Drawing.Color.FromArgb(75, 85, 99);
            this.lblProbSolvedStatusCaption.Location = new System.Drawing.Point(10, 8);
            this.lblProbSolvedStatusCaption.Name = "lblProbSolvedStatusCaption";
            this.lblProbSolvedStatusCaption.Size = new System.Drawing.Size(100, 20);
            this.lblProbSolvedStatusCaption.TabIndex = 0;
            this.lblProbSolvedStatusCaption.Text = "YOUR STATUS";
            this.lblProbSolvedStatusCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.lblProbSolvedStatusValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProbSolvedStatusValue.AutoSize = false;
            this.lblProbSolvedStatusValue.BackColor = System.Drawing.Color.Transparent;
            this.lblProbSolvedStatusValue.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblProbSolvedStatusValue.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblProbSolvedStatusValue.Location = new System.Drawing.Point(120, 8);
            this.lblProbSolvedStatusValue.Name = "lblProbSolvedStatusValue";
            this.lblProbSolvedStatusValue.Size = new System.Drawing.Size(140, 20);
            this.lblProbSolvedStatusValue.TabIndex = 1;
            this.lblProbSolvedStatusValue.Text = "Not Attempted";
            this.lblProbSolvedStatusValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // ══════════════════════════════════════════════════════════════
            //  BOTTOM STRIP — info tiles + action buttons
            // ══════════════════════════════════════════════════════════════
            this.pnlBottomStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBottomStrip.BackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.pnlBottomStrip.Location = new System.Drawing.Point(10, 494);
            this.pnlBottomStrip.Name = "pnlBottomStrip";
            this.pnlBottomStrip.Size = new System.Drawing.Size(1138, 60);
            this.pnlBottomStrip.TabIndex = 3;
            this.pnlBottomStrip.Controls.Add(this.pnlBottomRight);
            this.pnlBottomStrip.Controls.Add(this.pnlBottomLeft);
            this.pnlBottomStrip.Controls.Add(this.pnlBottomStripTopLine);

            this.pnlBottomStripTopLine.BackColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.pnlBottomStripTopLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBottomStripTopLine.Location = new System.Drawing.Point(0, 0);
            this.pnlBottomStripTopLine.Name = "pnlBottomStripTopLine";
            this.pnlBottomStripTopLine.Size = new System.Drawing.Size(1138, 1);
            this.pnlBottomStripTopLine.TabIndex = 2;

            // pnlBottomLeft — info tiles
            this.pnlBottomLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlBottomLeft.BackColor = System.Drawing.Color.Transparent;
            this.pnlBottomLeft.Location = new System.Drawing.Point(0, 2);
            this.pnlBottomLeft.Name = "pnlBottomLeft";
            this.pnlBottomLeft.Size = new System.Drawing.Size(580, 58);
            this.pnlBottomLeft.TabIndex = 0;
            this.pnlBottomLeft.Controls.Add(this.pnlInfoAttempts);
            this.pnlBottomLeft.Controls.Add(this.pnlInfoRank);
            this.pnlBottomLeft.Controls.Add(this.pnlInfoTimeRemaining);

            // pnlInfoTimeRemaining
            this.pnlInfoTimeRemaining.BackColor = System.Drawing.Color.FromArgb(24, 33, 47);
            this.pnlInfoTimeRemaining.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfoTimeRemaining.Location = new System.Drawing.Point(4, 10);
            this.pnlInfoTimeRemaining.Name = "pnlInfoTimeRemaining";
            this.pnlInfoTimeRemaining.Padding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.pnlInfoTimeRemaining.Size = new System.Drawing.Size(174, 38);
            this.pnlInfoTimeRemaining.TabIndex = 0;
            this.pnlInfoTimeRemaining.Controls.Add(this.lblTimeRemainingValue);
            this.pnlInfoTimeRemaining.Controls.Add(this.lblTimeRemainingCaption);

            this.lblTimeRemainingCaption.AutoSize = false;
            this.lblTimeRemainingCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeRemainingCaption.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblTimeRemainingCaption.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblTimeRemainingCaption.Location = new System.Drawing.Point(10, 3);
            this.lblTimeRemainingCaption.Name = "lblTimeRemainingCaption";
            this.lblTimeRemainingCaption.Size = new System.Drawing.Size(130, 12);
            this.lblTimeRemainingCaption.TabIndex = 0;
            this.lblTimeRemainingCaption.Text = "TIME REMAINING";

            this.lblTimeRemainingValue.AutoSize = false;
            this.lblTimeRemainingValue.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeRemainingValue.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.lblTimeRemainingValue.ForeColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.lblTimeRemainingValue.Location = new System.Drawing.Point(10, 17);
            this.lblTimeRemainingValue.Name = "lblTimeRemainingValue";
            this.lblTimeRemainingValue.Size = new System.Drawing.Size(150, 18);
            this.lblTimeRemainingValue.TabIndex = 1;
            this.lblTimeRemainingValue.Text = "--:--:--";

            // pnlInfoRank
            this.pnlInfoRank.BackColor = System.Drawing.Color.FromArgb(24, 33, 47);
            this.pnlInfoRank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfoRank.Location = new System.Drawing.Point(186, 10);
            this.pnlInfoRank.Name = "pnlInfoRank";
            this.pnlInfoRank.Padding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.pnlInfoRank.Size = new System.Drawing.Size(138, 38);
            this.pnlInfoRank.TabIndex = 1;
            this.pnlInfoRank.Controls.Add(this.lblRankValue);
            this.pnlInfoRank.Controls.Add(this.lblRankCaption);

            this.lblRankCaption.AutoSize = false;
            this.lblRankCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblRankCaption.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblRankCaption.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblRankCaption.Location = new System.Drawing.Point(10, 3);
            this.lblRankCaption.Name = "lblRankCaption";
            this.lblRankCaption.Size = new System.Drawing.Size(80, 12);
            this.lblRankCaption.TabIndex = 0;
            this.lblRankCaption.Text = "MY RANK";

            this.lblRankValue.AutoSize = false;
            this.lblRankValue.BackColor = System.Drawing.Color.Transparent;
            this.lblRankValue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblRankValue.ForeColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.lblRankValue.Location = new System.Drawing.Point(10, 17);
            this.lblRankValue.Name = "lblRankValue";
            this.lblRankValue.Size = new System.Drawing.Size(116, 18);
            this.lblRankValue.TabIndex = 1;
            this.lblRankValue.Text = "—";

            // pnlInfoAttempts
            this.pnlInfoAttempts.BackColor = System.Drawing.Color.FromArgb(24, 33, 47);
            this.pnlInfoAttempts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfoAttempts.Location = new System.Drawing.Point(332, 10);
            this.pnlInfoAttempts.Name = "pnlInfoAttempts";
            this.pnlInfoAttempts.Padding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.pnlInfoAttempts.Size = new System.Drawing.Size(138, 38);
            this.pnlInfoAttempts.TabIndex = 2;
            this.pnlInfoAttempts.Controls.Add(this.lblAttemptsValue);
            this.pnlInfoAttempts.Controls.Add(this.lblAttemptsCaption);

            this.lblAttemptsCaption.AutoSize = false;
            this.lblAttemptsCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblAttemptsCaption.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblAttemptsCaption.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblAttemptsCaption.Location = new System.Drawing.Point(10, 3);
            this.lblAttemptsCaption.Name = "lblAttemptsCaption";
            this.lblAttemptsCaption.Size = new System.Drawing.Size(90, 12);
            this.lblAttemptsCaption.TabIndex = 0;
            this.lblAttemptsCaption.Text = "MY ATTEMPTS";

            this.lblAttemptsValue.AutoSize = false;
            this.lblAttemptsValue.BackColor = System.Drawing.Color.Transparent;
            this.lblAttemptsValue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblAttemptsValue.ForeColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.lblAttemptsValue.Location = new System.Drawing.Point(10, 17);
            this.lblAttemptsValue.Name = "lblAttemptsValue";
            this.lblAttemptsValue.Size = new System.Drawing.Size(116, 18);
            this.lblAttemptsValue.TabIndex = 1;
            this.lblAttemptsValue.Text = "0";

            // pnlBottomRight — action buttons + rules link
            this.pnlBottomRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBottomRight.BackColor = System.Drawing.Color.Transparent;
            this.pnlBottomRight.Location = new System.Drawing.Point(584, 4);
            this.pnlBottomRight.Name = "pnlBottomRight";
            this.pnlBottomRight.Size = new System.Drawing.Size(554, 56);
            this.pnlBottomRight.TabIndex = 1;
            this.pnlBottomRight.Controls.Add(this.lnkContestRules);
            this.pnlBottomRight.Controls.Add(this.btnViewLeaderboard);
            this.pnlBottomRight.Controls.Add(this.btnStartContest);
            this.pnlBottomRight.Controls.Add(this.btnJoinContest);

            // btnJoinContest — primary CTA (green)
            this.btnJoinContest.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.btnJoinContest.FlatAppearance.BorderSize = 0;
            this.btnJoinContest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(5, 150, 105);
            this.btnJoinContest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJoinContest.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnJoinContest.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.btnJoinContest.Location = new System.Drawing.Point(0, 12);
            this.btnJoinContest.Name = "btnJoinContest";
            this.btnJoinContest.Size = new System.Drawing.Size(140, 32);
            this.btnJoinContest.TabIndex = 0;
            this.btnJoinContest.Text = "✚  Join Contest";
            this.btnJoinContest.UseVisualStyleBackColor = false;

            // btnStartContest — secondary CTA (indigo)
            this.btnStartContest.BackColor = System.Drawing.Color.FromArgb(79, 70, 229);
            this.btnStartContest.FlatAppearance.BorderSize = 0;
            this.btnStartContest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(67, 56, 202);
            this.btnStartContest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartContest.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnStartContest.ForeColor = System.Drawing.Color.White;
            this.btnStartContest.Location = new System.Drawing.Point(150, 12);
            this.btnStartContest.Name = "btnStartContest";
            this.btnStartContest.Size = new System.Drawing.Size(148, 32);
            this.btnStartContest.TabIndex = 1;
            this.btnStartContest.Text = "▶  Start Contest";
            this.btnStartContest.UseVisualStyleBackColor = false;

            // btnViewLeaderboard — outlined ghost button
            this.btnViewLeaderboard.BackColor = System.Drawing.Color.FromArgb(24, 33, 47);
            this.btnViewLeaderboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(55, 65, 81);
            this.btnViewLeaderboard.FlatAppearance.BorderSize = 1;
            this.btnViewLeaderboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.btnViewLeaderboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewLeaderboard.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnViewLeaderboard.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.btnViewLeaderboard.Location = new System.Drawing.Point(308, 12);
            this.btnViewLeaderboard.Name = "btnViewLeaderboard";
            this.btnViewLeaderboard.Size = new System.Drawing.Size(166, 32);
            this.btnViewLeaderboard.TabIndex = 2;
            this.btnViewLeaderboard.Text = "🏆  View Leaderboard";
            this.btnViewLeaderboard.UseVisualStyleBackColor = false;

            // lnkContestRules
            this.lnkContestRules.ActiveLinkColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.lnkContestRules.AutoSize = false;
            this.lnkContestRules.BackColor = System.Drawing.Color.Transparent;
            this.lnkContestRules.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lnkContestRules.LinkColor = System.Drawing.Color.FromArgb(75, 85, 99);
            this.lnkContestRules.Location = new System.Drawing.Point(484, 20);
            this.lnkContestRules.Name = "lnkContestRules";
            this.lnkContestRules.Size = new System.Drawing.Size(70, 18);
            this.lnkContestRules.TabIndex = 3;
            this.lnkContestRules.TabStop = true;
            this.lnkContestRules.Text = "Contest Rules";
            this.lnkContestRules.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkContestRules.VisitedLinkColor = System.Drawing.Color.FromArgb(55, 65, 81);

            // ══════════════════════════════════════════════════════════════
            //  JoinContestUI — the Form itself
            // ══════════════════════════════════════════════════════════════
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(10, 14, 26);
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.pnlFormBackground);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1024, 620);
            this.Name = "JoinContestUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL Judge System — Contest Arena";

            // ══════════════════════════════════════════════════════════════
            //  Resume all layouts
            // ══════════════════════════════════════════════════════════════
            this.pnlFooterBar.ResumeLayout(false);
            this.pnlBottomRight.ResumeLayout(false);
            this.pnlInfoAttempts.ResumeLayout(false);
            this.pnlInfoRank.ResumeLayout(false);
            this.pnlInfoTimeRemaining.ResumeLayout(false);
            this.pnlBottomLeft.ResumeLayout(false);
            this.pnlBottomStrip.ResumeLayout(false);
            this.pnlProbSolvedStatus.ResumeLayout(false);
            this.pnlProbDetailBody.ResumeLayout(false);
            this.pnlProbPointsBadge.ResumeLayout(false);
            this.pnlProbDiffBadge.ResumeLayout(false);
            this.pnlProblemDetailBadges.ResumeLayout(false);
            this.pnlProblemDetailHeader.ResumeLayout(false);
            this.pnlProblemDetailCard.ResumeLayout(false);
            this.pnlRightColumn.ResumeLayout(false);
            this.pnlProgressTrack.ResumeLayout(false);
            this.pnlProgressBody.ResumeLayout(false);
            this.pnlProgressHeader.ResumeLayout(false);
            this.pnlProgressCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContestProblems)).EndInit();
            this.pnlContestProblemsHeader.ResumeLayout(false);
            this.pnlContestProblemsCard.ResumeLayout(false);
            this.pnlBadgeTotalPoints.ResumeLayout(false);
            this.pnlBadgeTotalProblems.ResumeLayout(false);
            this.pnlBadgeDuration.ResumeLayout(false);
            this.pnlBadgeEndDate.ResumeLayout(false);
            this.pnlBadgeStartDate.ResumeLayout(false);
            this.pnlContestDetailBadges.ResumeLayout(false);
            this.pnlContestDetailHeader.ResumeLayout(false);
            this.pnlContestDetailCard.ResumeLayout(false);
            this.pnlCenterColumn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContestList)).EndInit();
            this.pnlContestFilters.ResumeLayout(false);
            this.pnlContestFilters.PerformLayout();
            this.pnlContestListHeader.ResumeLayout(false);
            this.pnlContestListCard.ResumeLayout(false);
            this.pnlLeftColumn.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlStatLastSubmission.ResumeLayout(false);
            this.pnlStatContestStatus.ResumeLayout(false);
            this.pnlStatParticipants.ResumeLayout(false);
            this.pnlStatCountdown.ResumeLayout(false);
            this.pnlHeaderStats.ResumeLayout(false);
            this.pnlHeaderBar.ResumeLayout(false);
            this.pnlMainCard.ResumeLayout(false);
            this.pnlFormBackground.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        // ──────────────────────────────────────────────────────────────────
        //  Control field declarations
        // ──────────────────────────────────────────────────────────────────

        // Top-level containers
        private System.Windows.Forms.Panel pnlFormBackground;
        private System.Windows.Forms.Panel pnlMainCard;

        // Header bar
        private System.Windows.Forms.Panel pnlHeaderBar;
        private System.Windows.Forms.Panel pnlHeaderLeftAccent;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblFormSubtitle;
        private System.Windows.Forms.Panel pnlHeaderStats;
        private System.Windows.Forms.Panel pnlStatCountdown;
        private System.Windows.Forms.Label lblCountdownCaption;
        private System.Windows.Forms.Label lblCountdownValue;
        private System.Windows.Forms.Panel pnlStatParticipants;
        private System.Windows.Forms.Label lblParticipantsCaption;
        private System.Windows.Forms.Label lblParticipantsValue;
        private System.Windows.Forms.Panel pnlStatContestStatus;
        private System.Windows.Forms.Label lblContestStatusCaption;
        private System.Windows.Forms.Label lblContestStatusValue;
        private System.Windows.Forms.Panel pnlStatLastSubmission;
        private System.Windows.Forms.Label lblLastSubmissionCaption;
        private System.Windows.Forms.Label lblLastSubmissionValue;

        // Footer bar
        private System.Windows.Forms.Panel pnlFooterBar;
        private System.Windows.Forms.Panel pnlFooterTopLine;
        private System.Windows.Forms.Label lblFooterHint;
        private System.Windows.Forms.Label lblFooterInfo;

        // Body
        private System.Windows.Forms.Panel pnlBody;

        // Left column — contest list
        private System.Windows.Forms.Panel pnlLeftColumn;
        private System.Windows.Forms.Panel pnlContestListCard;
        private System.Windows.Forms.Panel pnlContestListHeader;
        private System.Windows.Forms.Panel pnlContestListAccent;
        private System.Windows.Forms.Label lblContestListTitle;
        private System.Windows.Forms.Button btnRefreshContests;
        private System.Windows.Forms.Panel pnlContestFilters;
        private System.Windows.Forms.TextBox txtContestSearch;
        private System.Windows.Forms.ComboBox cmbStatusFilter;
        private System.Windows.Forms.DataGridView dgvContestList;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContestDifficulty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContestStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContestProblems;

        // Center column
        private System.Windows.Forms.Panel pnlCenterColumn;

        // Contest detail card
        private System.Windows.Forms.Panel pnlContestDetailCard;
        private System.Windows.Forms.Panel pnlContestDetailHeader;
        private System.Windows.Forms.Panel pnlContestDetailAccent;
        private System.Windows.Forms.Label lblContestDetailTitle;
        private System.Windows.Forms.Panel pnlContestDetailBadges;
        private System.Windows.Forms.Panel pnlBadgeStartDate;
        private System.Windows.Forms.Label lblBadgeStartIcon;
        private System.Windows.Forms.Label lblBadgeStartValue;
        private System.Windows.Forms.Panel pnlBadgeEndDate;
        private System.Windows.Forms.Label lblBadgeEndIcon;
        private System.Windows.Forms.Label lblBadgeEndValue;
        private System.Windows.Forms.Panel pnlBadgeDuration;
        private System.Windows.Forms.Label lblBadgeDurationIcon;
        private System.Windows.Forms.Label lblBadgeDurationValue;
        private System.Windows.Forms.Panel pnlBadgeTotalProblems;
        private System.Windows.Forms.Label lblBadgeTotalProblemsIcon;
        private System.Windows.Forms.Label lblBadgeTotalProblemsValue;
        private System.Windows.Forms.Panel pnlBadgeTotalPoints;
        private System.Windows.Forms.Label lblBadgeTotalPointsIcon;
        private System.Windows.Forms.Label lblBadgeTotalPointsValue;
        private System.Windows.Forms.RichTextBox txtContestDescription;

        // Contest problems grid
        private System.Windows.Forms.Panel pnlContestProblemsCard;
        private System.Windows.Forms.Panel pnlContestProblemsHeader;
        private System.Windows.Forms.Panel pnlContestProblemsAccent;
        private System.Windows.Forms.Label lblContestProblemsTitle;
        private System.Windows.Forms.Label lblContestProblemsHint;
        private System.Windows.Forms.DataGridView dgvContestProblems;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProblemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProblemDifficulty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProblemPoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProblemSolvedStatus;

        // Progress card
        private System.Windows.Forms.Panel pnlProgressCard;
        private System.Windows.Forms.Panel pnlProgressHeader;
        private System.Windows.Forms.Panel pnlProgressAccent;
        private System.Windows.Forms.Label lblProgressTitle;
        private System.Windows.Forms.Label lblProgressFraction;
        private System.Windows.Forms.Panel pnlProgressBody;
        private System.Windows.Forms.Panel pnlProgressTrack;
        private System.Windows.Forms.Panel pnlProgressFill;
        private System.Windows.Forms.Label lblProgressPercent;

        // Right column — problem detail card
        private System.Windows.Forms.Panel pnlRightColumn;
        private System.Windows.Forms.Panel pnlProblemDetailCard;
        private System.Windows.Forms.Panel pnlProblemDetailHeader;
        private System.Windows.Forms.Panel pnlProblemDetailAccent;
        private System.Windows.Forms.Label lblProblemDetailTitle;
        private System.Windows.Forms.Panel pnlProblemDetailBadges;
        private System.Windows.Forms.Panel pnlProbDiffBadge;
        private System.Windows.Forms.Label lblProbDiffIcon;
        private System.Windows.Forms.Label lblProbDiffValue;
        private System.Windows.Forms.Panel pnlProbPointsBadge;
        private System.Windows.Forms.Label lblProbPointsIcon;
        private System.Windows.Forms.Label lblProbPointsValue;
        private System.Windows.Forms.Panel pnlProbDetailBody;
        private System.Windows.Forms.Label lblProbTagsCaption;
        private System.Windows.Forms.Label lblProbTagsValue;
        private System.Windows.Forms.Label lblProbDescCaption;
        private System.Windows.Forms.RichTextBox txtProblemShortDesc;
        private System.Windows.Forms.Label lblProbConstraintsCaption;
        private System.Windows.Forms.RichTextBox txtProblemConstraints;
        private System.Windows.Forms.Label lblProbAllowedDbCaption;
        private System.Windows.Forms.Label lblProbAllowedDbValue;
        private System.Windows.Forms.Panel pnlProbSolvedStatus;
        private System.Windows.Forms.Panel pnlProbSolvedAccent;
        private System.Windows.Forms.Label lblProbSolvedStatusCaption;
        private System.Windows.Forms.Label lblProbSolvedStatusValue;

        // Bottom strip — info tiles + action buttons
        private System.Windows.Forms.Panel pnlBottomStrip;
        private System.Windows.Forms.Panel pnlBottomStripTopLine;
        private System.Windows.Forms.Panel pnlBottomLeft;
        private System.Windows.Forms.Panel pnlInfoTimeRemaining;
        private System.Windows.Forms.Label lblTimeRemainingCaption;
        private System.Windows.Forms.Label lblTimeRemainingValue;
        private System.Windows.Forms.Panel pnlInfoRank;
        private System.Windows.Forms.Label lblRankCaption;
        private System.Windows.Forms.Label lblRankValue;
        private System.Windows.Forms.Panel pnlInfoAttempts;
        private System.Windows.Forms.Label lblAttemptsCaption;
        private System.Windows.Forms.Label lblAttemptsValue;
        private System.Windows.Forms.Panel pnlBottomRight;
        private System.Windows.Forms.Button btnJoinContest;
        private System.Windows.Forms.Button btnStartContest;
        private System.Windows.Forms.Button btnViewLeaderboard;
        private System.Windows.Forms.LinkLabel lnkContestRules;
    }
}


