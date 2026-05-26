namespace SQL_Judge_System.UI
{
    partial class ContestUI
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tmrCountdown = new System.Windows.Forms.Timer(this.components);
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnReport = new FontAwesome.Sharp.IconButton();
            this.btn_contest = new FontAwesome.Sharp.IconButton();
            this.btn_problems = new FontAwesome.Sharp.IconButton();
            this.btn_home = new FontAwesome.Sharp.IconButton();
            this.pnlSidebarLogo = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblAppSub = new System.Windows.Forms.Label();
            this.lblAppName = new System.Windows.Forms.Label();
            this.btn_settings = new FontAwesome.Sharp.IconButton();
            this.btn_Logout = new FontAwesome.Sharp.IconButton();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblOnlineStatus = new System.Windows.Forms.Label();
            this.pnlTimerBox = new System.Windows.Forms.Panel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblTimerIcon = new System.Windows.Forms.Label();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.pnlContestBrowser = new System.Windows.Forms.Panel();
            this.dgvContests = new System.Windows.Forms.DataGridView();
            this.pnlJoinBar = new System.Windows.Forms.Panel();
            this.lblContestStatus = new System.Windows.Forms.Label();
            this.btnJoinContest = new FontAwesome.Sharp.IconButton();
            this.pnlBrowserHeader = new System.Windows.Forms.Panel();
            this.cmbContestFilter = new System.Windows.Forms.ComboBox();
            this.lblBrowserTitle = new System.Windows.Forms.Label();
            this.splitRight = new System.Windows.Forms.SplitContainer();
            this.pnlContestDetail = new System.Windows.Forms.Panel();
            this.dgvContestProblems = new System.Windows.Forms.DataGridView();
            this.pnlProblemListHeader = new System.Windows.Forms.Panel();
            this.lblProblemListTitle = new System.Windows.Forms.Label();
            this.pnlContestInfo = new System.Windows.Forms.Panel();
            this.tlpContestStats = new System.Windows.Forms.TableLayoutPanel();
            this.pnlStatParticipants = new System.Windows.Forms.Panel();
            this.lblStatParticipants = new System.Windows.Forms.Label();
            this.lblStatParticipantsV = new System.Windows.Forms.Label();
            this.pnlStatProblems = new System.Windows.Forms.Panel();
            this.pnlStatDuration = new System.Windows.Forms.Panel();
            this.pnlStatScore = new System.Windows.Forms.Panel();
            this.lblContestDesc = new System.Windows.Forms.Label();
            this.lblContestMeta = new System.Windows.Forms.Label();
            this.lblContestName = new System.Windows.Forms.Label();
            this.pnlLeaderboard = new System.Windows.Forms.Panel();
            this.dgvLeaderboard = new System.Windows.Forms.DataGridView();
            this.pnlLeaderHeader = new System.Windows.Forms.Panel();
            this.btnRefreshLB = new FontAwesome.Sharp.IconButton();
            this.lblLeaderTitle = new System.Windows.Forms.Label();
            this.lblStatProblems = new System.Windows.Forms.Label();
            this.lblStatProblemsV = new System.Windows.Forms.Label();
            this.lblStatDuration = new System.Windows.Forms.Label();
            this.lblStatDurationV = new System.Windows.Forms.Label();
            this.lblStatScore = new System.Windows.Forms.Label();
            this.lblStatScoreV = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlSidebarLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlTimerBox.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.pnlContestBrowser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContests)).BeginInit();
            this.pnlJoinBar.SuspendLayout();
            this.pnlBrowserHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitRight)).BeginInit();
            this.splitRight.Panel1.SuspendLayout();
            this.splitRight.Panel2.SuspendLayout();
            this.splitRight.SuspendLayout();
            this.pnlContestDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContestProblems)).BeginInit();
            this.pnlProblemListHeader.SuspendLayout();
            this.pnlContestInfo.SuspendLayout();
            this.tlpContestStats.SuspendLayout();
            this.pnlStatParticipants.SuspendLayout();
            this.pnlLeaderboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaderboard)).BeginInit();
            this.pnlLeaderHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrCountdown
            // 
            this.tmrCountdown.Interval = 1000;
            this.tmrCountdown.Tick += new System.EventHandler(this.tmrCountdown_Tick);
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(56)))));
            this.pnlSidebar.Controls.Add(this.btnReport);
            this.pnlSidebar.Controls.Add(this.btn_contest);
            this.pnlSidebar.Controls.Add(this.btn_problems);
            this.pnlSidebar.Controls.Add(this.btn_home);
            this.pnlSidebar.Controls.Add(this.pnlSidebarLogo);
            this.pnlSidebar.Controls.Add(this.btn_settings);
            this.pnlSidebar.Controls.Add(this.btn_Logout);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(200, 700);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(56)))));
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.btnReport.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            this.btnReport.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.btnReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReport.IconSize = 20;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(0, 214);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnReport.Size = new System.Drawing.Size(200, 48);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "Generate Report";
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btn_contest
            // 
            this.btn_contest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btn_contest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_contest.FlatAppearance.BorderSize = 0;
            this.btn_contest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btn_contest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btn_contest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_contest.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btn_contest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(111)))), ((int)(((byte)(255)))));
            this.btn_contest.IconChar = FontAwesome.Sharp.IconChar.Trophy;
            this.btn_contest.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(111)))), ((int)(((byte)(255)))));
            this.btn_contest.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_contest.IconSize = 20;
            this.btn_contest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_contest.Location = new System.Drawing.Point(0, 166);
            this.btn_contest.Name = "btn_contest";
            this.btn_contest.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btn_contest.Size = new System.Drawing.Size(200, 48);
            this.btn_contest.TabIndex = 3;
            this.btn_contest.Text = "Join Contest";
            this.btn_contest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_contest.UseVisualStyleBackColor = false;
            // 
            // btn_problems
            // 
            this.btn_problems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(56)))));
            this.btn_problems.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_problems.FlatAppearance.BorderSize = 0;
            this.btn_problems.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btn_problems.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btn_problems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_problems.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btn_problems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.btn_problems.IconChar = FontAwesome.Sharp.IconChar.Code;
            this.btn_problems.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.btn_problems.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_problems.IconSize = 20;
            this.btn_problems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_problems.Location = new System.Drawing.Point(0, 118);
            this.btn_problems.Name = "btn_problems";
            this.btn_problems.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btn_problems.Size = new System.Drawing.Size(200, 48);
            this.btn_problems.TabIndex = 2;
            this.btn_problems.Text = "Solve Problems";
            this.btn_problems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_problems.UseVisualStyleBackColor = false;
            this.btn_problems.Click += new System.EventHandler(this.btn_problems_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(56)))));
            this.btn_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btn_home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btn_home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.btn_home.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.btn_home.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.btn_home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_home.IconSize = 20;
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Location = new System.Drawing.Point(0, 70);
            this.btn_home.Name = "btn_home";
            this.btn_home.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btn_home.Size = new System.Drawing.Size(200, 48);
            this.btn_home.TabIndex = 1;
            this.btn_home.Text = "Home";
            this.btn_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // pnlSidebarLogo
            // 
            this.pnlSidebarLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(56)))));
            this.pnlSidebarLogo.Controls.Add(this.picLogo);
            this.pnlSidebarLogo.Controls.Add(this.lblAppSub);
            this.pnlSidebarLogo.Controls.Add(this.lblAppName);
            this.pnlSidebarLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSidebarLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebarLogo.Name = "pnlSidebarLogo";
            this.pnlSidebarLogo.Size = new System.Drawing.Size(200, 70);
            this.pnlSidebarLogo.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Location = new System.Drawing.Point(8, 13);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(44, 44);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 3;
            this.picLogo.TabStop = false;
            // 
            // lblAppSub
            // 
            this.lblAppSub.AutoSize = true;
            this.lblAppSub.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblAppSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblAppSub.Location = new System.Drawing.Point(72, 40);
            this.lblAppSub.Name = "lblAppSub";
            this.lblAppSub.Size = new System.Drawing.Size(82, 15);
            this.lblAppSub.TabIndex = 1;
            this.lblAppSub.Text = "Student Portal";
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblAppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(111)))), ((int)(((byte)(255)))));
            this.lblAppName.Location = new System.Drawing.Point(65, 12);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(110, 28);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "SQL Judge";
            // 
            // btn_settings
            // 
            this.btn_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(56)))));
            this.btn_settings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_settings.FlatAppearance.BorderSize = 0;
            this.btn_settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btn_settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btn_settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.btn_settings.IconChar = FontAwesome.Sharp.IconChar.Gears;
            this.btn_settings.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.btn_settings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_settings.IconSize = 20;
            this.btn_settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_settings.Location = new System.Drawing.Point(0, 604);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btn_settings.Size = new System.Drawing.Size(200, 48);
            this.btn_settings.TabIndex = 10;
            this.btn_settings.Text = "Settings";
            this.btn_settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_settings.UseVisualStyleBackColor = false;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(56)))));
            this.btn_Logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Logout.FlatAppearance.BorderSize = 0;
            this.btn_Logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btn_Logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btn_Logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btn_Logout.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.btn_Logout.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btn_Logout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Logout.IconSize = 20;
            this.btn_Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Logout.Location = new System.Drawing.Point(0, 652);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btn_Logout.Size = new System.Drawing.Size(200, 48);
            this.btn_Logout.TabIndex = 11;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.pnlHeader.Controls.Add(this.lblOnlineStatus);
            this.pnlHeader.Controls.Add(this.pnlTimerBox);
            this.pnlHeader.Controls.Add(this.lblPageTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(200, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1004, 56);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblOnlineStatus
            // 
            this.lblOnlineStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOnlineStatus.AutoSize = true;
            this.lblOnlineStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOnlineStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(207)))), ((int)(((byte)(142)))));
            this.lblOnlineStatus.Location = new System.Drawing.Point(950, 20);
            this.lblOnlineStatus.Name = "lblOnlineStatus";
            this.lblOnlineStatus.Size = new System.Drawing.Size(52, 15);
            this.lblOnlineStatus.TabIndex = 2;
            this.lblOnlineStatus.Text = "● Online";
            // 
            // pnlTimerBox
            // 
            this.pnlTimerBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTimerBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(56)))));
            this.pnlTimerBox.Controls.Add(this.lblTimer);
            this.pnlTimerBox.Controls.Add(this.lblTimerIcon);
            this.pnlTimerBox.Location = new System.Drawing.Point(820, 10);
            this.pnlTimerBox.Name = "pnlTimerBox";
            this.pnlTimerBox.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.pnlTimerBox.Size = new System.Drawing.Size(120, 36);
            this.pnlTimerBox.TabIndex = 1;
            this.pnlTimerBox.Visible = false;
            // 
            // lblTimer
            // 
            this.lblTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTimer.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.lblTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(66)))));
            this.lblTimer.Location = new System.Drawing.Point(36, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(76, 36);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "00:00:00";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTimerIcon
            // 
            this.lblTimerIcon.AutoSize = true;
            this.lblTimerIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTimerIcon.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblTimerIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(66)))));
            this.lblTimerIcon.Location = new System.Drawing.Point(8, 0);
            this.lblTimerIcon.Name = "lblTimerIcon";
            this.lblTimerIcon.Size = new System.Drawing.Size(28, 20);
            this.lblTimerIcon.TabIndex = 1;
            this.lblTimerIcon.Text = "⏱";
            this.lblTimerIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.White;
            this.lblPageTitle.Location = new System.Drawing.Point(20, 14);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(103, 30);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "Contests";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.pnlMain.Controls.Add(this.splitMain);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(200, 56);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(10);
            this.pnlMain.Size = new System.Drawing.Size(1004, 644);
            this.pnlMain.TabIndex = 2;
            // 
            // splitMain
            // 
            this.splitMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(10, 10);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.pnlContestBrowser);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.splitRight);
            this.splitMain.Size = new System.Drawing.Size(984, 624);
            this.splitMain.SplitterDistance = 793;
            this.splitMain.SplitterWidth = 6;
            this.splitMain.TabIndex = 0;
            // 
            // pnlContestBrowser
            // 
            this.pnlContestBrowser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.pnlContestBrowser.Controls.Add(this.dgvContests);
            this.pnlContestBrowser.Controls.Add(this.pnlJoinBar);
            this.pnlContestBrowser.Controls.Add(this.pnlBrowserHeader);
            this.pnlContestBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContestBrowser.Location = new System.Drawing.Point(0, 0);
            this.pnlContestBrowser.Name = "pnlContestBrowser";
            this.pnlContestBrowser.Size = new System.Drawing.Size(793, 624);
            this.pnlContestBrowser.TabIndex = 0;
            // 
            // dgvContests
            // 
            this.dgvContests.AllowUserToAddRows = false;
            this.dgvContests.AllowUserToDeleteRows = false;
            this.dgvContests.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(201)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvContests.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContests.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.dgvContests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.dgvContests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvContests.ColumnHeadersHeight = 36;
            this.dgvContests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(201)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContests.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvContests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContests.EnableHeadersVisualStyles = false;
            this.dgvContests.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.dgvContests.Location = new System.Drawing.Point(0, 64);
            this.dgvContests.MultiSelect = false;
            this.dgvContests.Name = "dgvContests";
            this.dgvContests.ReadOnly = true;
            this.dgvContests.RowHeadersVisible = false;
            this.dgvContests.RowTemplate.Height = 34;
            this.dgvContests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContests.Size = new System.Drawing.Size(793, 504);
            this.dgvContests.TabIndex = 1;
            this.dgvContests.SelectionChanged += new System.EventHandler(this.dgvContests_SelectionChanged);
            // 
            // pnlJoinBar
            // 
            this.pnlJoinBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(56)))));
            this.pnlJoinBar.Controls.Add(this.lblContestStatus);
            this.pnlJoinBar.Controls.Add(this.btnJoinContest);
            this.pnlJoinBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlJoinBar.Location = new System.Drawing.Point(0, 568);
            this.pnlJoinBar.Name = "pnlJoinBar";
            this.pnlJoinBar.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.pnlJoinBar.Size = new System.Drawing.Size(793, 56);
            this.pnlJoinBar.TabIndex = 2;
            // 
            // lblContestStatus
            // 
            this.lblContestStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblContestStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblContestStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblContestStatus.Location = new System.Drawing.Point(140, 8);
            this.lblContestStatus.Name = "lblContestStatus";
            this.lblContestStatus.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.lblContestStatus.Size = new System.Drawing.Size(643, 40);
            this.lblContestStatus.TabIndex = 1;
            this.lblContestStatus.Text = "Select a contest";
            this.lblContestStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnJoinContest
            // 
            this.btnJoinContest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(111)))), ((int)(((byte)(255)))));
            this.btnJoinContest.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnJoinContest.Enabled = false;
            this.btnJoinContest.FlatAppearance.BorderSize = 0;
            this.btnJoinContest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(82)))), ((int)(((byte)(210)))));
            this.btnJoinContest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnJoinContest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJoinContest.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnJoinContest.ForeColor = System.Drawing.Color.White;
            this.btnJoinContest.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.btnJoinContest.IconColor = System.Drawing.Color.White;
            this.btnJoinContest.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnJoinContest.IconSize = 16;
            this.btnJoinContest.Location = new System.Drawing.Point(10, 8);
            this.btnJoinContest.Name = "btnJoinContest";
            this.btnJoinContest.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnJoinContest.Size = new System.Drawing.Size(130, 40);
            this.btnJoinContest.TabIndex = 0;
            this.btnJoinContest.Text = "Join Contest";
            this.btnJoinContest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnJoinContest.UseVisualStyleBackColor = false;
            this.btnJoinContest.Click += new System.EventHandler(this.btnJoinContest_Click);
            // 
            // pnlBrowserHeader
            // 
            this.pnlBrowserHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.pnlBrowserHeader.Controls.Add(this.cmbContestFilter);
            this.pnlBrowserHeader.Controls.Add(this.lblBrowserTitle);
            this.pnlBrowserHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBrowserHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlBrowserHeader.Name = "pnlBrowserHeader";
            this.pnlBrowserHeader.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.pnlBrowserHeader.Size = new System.Drawing.Size(793, 64);
            this.pnlBrowserHeader.TabIndex = 0;
            // 
            // cmbContestFilter
            // 
            this.cmbContestFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.cmbContestFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbContestFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbContestFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbContestFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(201)))), ((int)(((byte)(224)))));
            this.cmbContestFilter.Items.AddRange(new object[] {
            "All",
            "Open",
            "Upcoming",
            "Ended"});
            this.cmbContestFilter.Location = new System.Drawing.Point(10, 36);
            this.cmbContestFilter.Name = "cmbContestFilter";
            this.cmbContestFilter.Size = new System.Drawing.Size(280, 23);
            this.cmbContestFilter.TabIndex = 1;
            this.cmbContestFilter.SelectedIndexChanged += new System.EventHandler(this.cmbContestFilter_SelectedIndexChanged);
            // 
            // lblBrowserTitle
            // 
            this.lblBrowserTitle.AutoSize = true;
            this.lblBrowserTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblBrowserTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblBrowserTitle.Location = new System.Drawing.Point(10, 10);
            this.lblBrowserTitle.Name = "lblBrowserTitle";
            this.lblBrowserTitle.Size = new System.Drawing.Size(138, 20);
            this.lblBrowserTitle.TabIndex = 0;
            this.lblBrowserTitle.Text = "Available Contests";
            // 
            // splitRight
            // 
            this.splitRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.splitRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitRight.Location = new System.Drawing.Point(0, 0);
            this.splitRight.Name = "splitRight";
            this.splitRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitRight.Panel1
            // 
            this.splitRight.Panel1.Controls.Add(this.pnlContestDetail);
            // 
            // splitRight.Panel2
            // 
            this.splitRight.Panel2.Controls.Add(this.pnlLeaderboard);
            this.splitRight.Size = new System.Drawing.Size(185, 624);
            this.splitRight.SplitterDistance = 443;
            this.splitRight.SplitterWidth = 6;
            this.splitRight.TabIndex = 0;
            // 
            // pnlContestDetail
            // 
            this.pnlContestDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.pnlContestDetail.Controls.Add(this.dgvContestProblems);
            this.pnlContestDetail.Controls.Add(this.pnlProblemListHeader);
            this.pnlContestDetail.Controls.Add(this.pnlContestInfo);
            this.pnlContestDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContestDetail.Location = new System.Drawing.Point(0, 0);
            this.pnlContestDetail.Name = "pnlContestDetail";
            this.pnlContestDetail.Size = new System.Drawing.Size(185, 443);
            this.pnlContestDetail.TabIndex = 0;
            // 
            // dgvContestProblems
            // 
            this.dgvContestProblems.AllowUserToAddRows = false;
            this.dgvContestProblems.AllowUserToDeleteRows = false;
            this.dgvContestProblems.AllowUserToResizeRows = false;
            this.dgvContestProblems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContestProblems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.dgvContestProblems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvContestProblems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvContestProblems.ColumnHeadersHeight = 34;
            this.dgvContestProblems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(201)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContestProblems.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvContestProblems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContestProblems.EnableHeadersVisualStyles = false;
            this.dgvContestProblems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.dgvContestProblems.Location = new System.Drawing.Point(0, 196);
            this.dgvContestProblems.Name = "dgvContestProblems";
            this.dgvContestProblems.ReadOnly = true;
            this.dgvContestProblems.RowHeadersVisible = false;
            this.dgvContestProblems.RowTemplate.Height = 32;
            this.dgvContestProblems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContestProblems.Size = new System.Drawing.Size(185, 247);
            this.dgvContestProblems.TabIndex = 2;
            this.dgvContestProblems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContestProblems_CellDoubleClick);
            // 
            // pnlProblemListHeader
            // 
            this.pnlProblemListHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.pnlProblemListHeader.Controls.Add(this.lblProblemListTitle);
            this.pnlProblemListHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProblemListHeader.Location = new System.Drawing.Point(0, 160);
            this.pnlProblemListHeader.Name = "pnlProblemListHeader";
            this.pnlProblemListHeader.Padding = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.pnlProblemListHeader.Size = new System.Drawing.Size(185, 36);
            this.pnlProblemListHeader.TabIndex = 1;
            // 
            // lblProblemListTitle
            // 
            this.lblProblemListTitle.AutoSize = true;
            this.lblProblemListTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblProblemListTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblProblemListTitle.Location = new System.Drawing.Point(12, 8);
            this.lblProblemListTitle.Name = "lblProblemListTitle";
            this.lblProblemListTitle.Size = new System.Drawing.Size(117, 17);
            this.lblProblemListTitle.TabIndex = 0;
            this.lblProblemListTitle.Text = "Contest Problems";
            // 
            // pnlContestInfo
            // 
            this.pnlContestInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(56)))));
            this.pnlContestInfo.Controls.Add(this.tlpContestStats);
            this.pnlContestInfo.Controls.Add(this.lblContestDesc);
            this.pnlContestInfo.Controls.Add(this.lblContestMeta);
            this.pnlContestInfo.Controls.Add(this.lblContestName);
            this.pnlContestInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContestInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlContestInfo.Name = "pnlContestInfo";
            this.pnlContestInfo.Padding = new System.Windows.Forms.Padding(14, 10, 14, 10);
            this.pnlContestInfo.Size = new System.Drawing.Size(185, 160);
            this.pnlContestInfo.TabIndex = 0;
            // 
            // tlpContestStats
            // 
            this.tlpContestStats.BackColor = System.Drawing.Color.Transparent;
            this.tlpContestStats.ColumnCount = 4;
            this.tlpContestStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpContestStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpContestStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpContestStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpContestStats.Controls.Add(this.pnlStatParticipants, 0, 0);
            this.tlpContestStats.Controls.Add(this.pnlStatProblems, 1, 0);
            this.tlpContestStats.Controls.Add(this.pnlStatDuration, 2, 0);
            this.tlpContestStats.Controls.Add(this.pnlStatScore, 3, 0);
            this.tlpContestStats.Location = new System.Drawing.Point(14, 94);
            this.tlpContestStats.Name = "tlpContestStats";
            this.tlpContestStats.RowCount = 1;
            this.tlpContestStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContestStats.Size = new System.Drawing.Size(670, 56);
            this.tlpContestStats.TabIndex = 3;
            // 
            // pnlStatParticipants
            // 
            this.pnlStatParticipants.Controls.Add(this.lblStatParticipants);
            this.pnlStatParticipants.Controls.Add(this.lblStatParticipantsV);
            this.pnlStatParticipants.Location = new System.Drawing.Point(3, 3);
            this.pnlStatParticipants.Name = "pnlStatParticipants";
            this.pnlStatParticipants.Size = new System.Drawing.Size(161, 50);
            this.pnlStatParticipants.TabIndex = 0;
            // 
            // lblStatParticipants
            // 
            this.lblStatParticipants.Location = new System.Drawing.Point(0, 0);
            this.lblStatParticipants.Name = "lblStatParticipants";
            this.lblStatParticipants.Size = new System.Drawing.Size(100, 23);
            this.lblStatParticipants.TabIndex = 0;
            // 
            // lblStatParticipantsV
            // 
            this.lblStatParticipantsV.Location = new System.Drawing.Point(0, 0);
            this.lblStatParticipantsV.Name = "lblStatParticipantsV";
            this.lblStatParticipantsV.Size = new System.Drawing.Size(100, 23);
            this.lblStatParticipantsV.TabIndex = 0;
            // 
            // pnlStatProblems
            // 
            this.pnlStatProblems.Location = new System.Drawing.Point(170, 3);
            this.pnlStatProblems.Name = "pnlStatProblems";
            this.pnlStatProblems.Size = new System.Drawing.Size(161, 50);
            this.pnlStatProblems.TabIndex = 1;
            // 
            // pnlStatDuration
            // 
            this.pnlStatDuration.Location = new System.Drawing.Point(337, 3);
            this.pnlStatDuration.Name = "pnlStatDuration";
            this.pnlStatDuration.Size = new System.Drawing.Size(161, 50);
            this.pnlStatDuration.TabIndex = 2;
            // 
            // pnlStatScore
            // 
            this.pnlStatScore.Location = new System.Drawing.Point(504, 3);
            this.pnlStatScore.Name = "pnlStatScore";
            this.pnlStatScore.Size = new System.Drawing.Size(163, 50);
            this.pnlStatScore.TabIndex = 3;
            // 
            // lblContestDesc
            // 
            this.lblContestDesc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblContestDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(201)))), ((int)(((byte)(224)))));
            this.lblContestDesc.Location = new System.Drawing.Point(14, 54);
            this.lblContestDesc.Name = "lblContestDesc";
            this.lblContestDesc.Size = new System.Drawing.Size(670, 36);
            this.lblContestDesc.TabIndex = 2;
            // 
            // lblContestMeta
            // 
            this.lblContestMeta.AutoSize = true;
            this.lblContestMeta.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblContestMeta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblContestMeta.Location = new System.Drawing.Point(14, 34);
            this.lblContestMeta.Name = "lblContestMeta";
            this.lblContestMeta.Size = new System.Drawing.Size(0, 15);
            this.lblContestMeta.TabIndex = 1;
            // 
            // lblContestName
            // 
            this.lblContestName.AutoSize = true;
            this.lblContestName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblContestName.ForeColor = System.Drawing.Color.White;
            this.lblContestName.Location = new System.Drawing.Point(14, 10);
            this.lblContestName.Name = "lblContestName";
            this.lblContestName.Size = new System.Drawing.Size(274, 25);
            this.lblContestName.TabIndex = 0;
            this.lblContestName.Text = "Select a contest to view details";
            // 
            // pnlLeaderboard
            // 
            this.pnlLeaderboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.pnlLeaderboard.Controls.Add(this.dgvLeaderboard);
            this.pnlLeaderboard.Controls.Add(this.pnlLeaderHeader);
            this.pnlLeaderboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeaderboard.Location = new System.Drawing.Point(0, 0);
            this.pnlLeaderboard.Name = "pnlLeaderboard";
            this.pnlLeaderboard.Size = new System.Drawing.Size(185, 175);
            this.pnlLeaderboard.TabIndex = 0;
            // 
            // dgvLeaderboard
            // 
            this.dgvLeaderboard.AllowUserToAddRows = false;
            this.dgvLeaderboard.AllowUserToDeleteRows = false;
            this.dgvLeaderboard.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLeaderboard.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.dgvLeaderboard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLeaderboard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLeaderboard.ColumnHeadersHeight = 34;
            this.dgvLeaderboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(201)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLeaderboard.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvLeaderboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLeaderboard.EnableHeadersVisualStyles = false;
            this.dgvLeaderboard.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.dgvLeaderboard.Location = new System.Drawing.Point(0, 36);
            this.dgvLeaderboard.Name = "dgvLeaderboard";
            this.dgvLeaderboard.ReadOnly = true;
            this.dgvLeaderboard.RowHeadersVisible = false;
            this.dgvLeaderboard.RowTemplate.Height = 32;
            this.dgvLeaderboard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLeaderboard.Size = new System.Drawing.Size(185, 139);
            this.dgvLeaderboard.TabIndex = 1;
            // 
            // pnlLeaderHeader
            // 
            this.pnlLeaderHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.pnlLeaderHeader.Controls.Add(this.btnRefreshLB);
            this.pnlLeaderHeader.Controls.Add(this.lblLeaderTitle);
            this.pnlLeaderHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLeaderHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlLeaderHeader.Name = "pnlLeaderHeader";
            this.pnlLeaderHeader.Padding = new System.Windows.Forms.Padding(12, 0, 8, 0);
            this.pnlLeaderHeader.Size = new System.Drawing.Size(185, 36);
            this.pnlLeaderHeader.TabIndex = 0;
            // 
            // btnRefreshLB
            // 
            this.btnRefreshLB.BackColor = System.Drawing.Color.Transparent;
            this.btnRefreshLB.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRefreshLB.FlatAppearance.BorderSize = 0;
            this.btnRefreshLB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btnRefreshLB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshLB.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnRefreshLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.btnRefreshLB.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.btnRefreshLB.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.btnRefreshLB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRefreshLB.IconSize = 14;
            this.btnRefreshLB.Location = new System.Drawing.Point(97, 0);
            this.btnRefreshLB.Name = "btnRefreshLB";
            this.btnRefreshLB.Size = new System.Drawing.Size(80, 36);
            this.btnRefreshLB.TabIndex = 1;
            this.btnRefreshLB.Text = "Refresh";
            this.btnRefreshLB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefreshLB.UseVisualStyleBackColor = false;
            this.btnRefreshLB.Click += new System.EventHandler(this.btnRefreshLB_Click);
            // 
            // lblLeaderTitle
            // 
            this.lblLeaderTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblLeaderTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblLeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblLeaderTitle.Location = new System.Drawing.Point(12, 0);
            this.lblLeaderTitle.Name = "lblLeaderTitle";
            this.lblLeaderTitle.Size = new System.Drawing.Size(160, 36);
            this.lblLeaderTitle.TabIndex = 0;
            this.lblLeaderTitle.Text = "  Contest Leaderboard";
            this.lblLeaderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatProblems
            // 
            this.lblStatProblems.Location = new System.Drawing.Point(0, 0);
            this.lblStatProblems.Name = "lblStatProblems";
            this.lblStatProblems.Size = new System.Drawing.Size(100, 23);
            this.lblStatProblems.TabIndex = 0;
            // 
            // lblStatProblemsV
            // 
            this.lblStatProblemsV.Location = new System.Drawing.Point(0, 0);
            this.lblStatProblemsV.Name = "lblStatProblemsV";
            this.lblStatProblemsV.Size = new System.Drawing.Size(100, 23);
            this.lblStatProblemsV.TabIndex = 0;
            // 
            // lblStatDuration
            // 
            this.lblStatDuration.Location = new System.Drawing.Point(0, 0);
            this.lblStatDuration.Name = "lblStatDuration";
            this.lblStatDuration.Size = new System.Drawing.Size(100, 23);
            this.lblStatDuration.TabIndex = 0;
            // 
            // lblStatDurationV
            // 
            this.lblStatDurationV.Location = new System.Drawing.Point(0, 0);
            this.lblStatDurationV.Name = "lblStatDurationV";
            this.lblStatDurationV.Size = new System.Drawing.Size(100, 23);
            this.lblStatDurationV.TabIndex = 0;
            // 
            // lblStatScore
            // 
            this.lblStatScore.Location = new System.Drawing.Point(0, 0);
            this.lblStatScore.Name = "lblStatScore";
            this.lblStatScore.Size = new System.Drawing.Size(100, 23);
            this.lblStatScore.TabIndex = 0;
            // 
            // lblStatScoreV
            // 
            this.lblStatScoreV.Location = new System.Drawing.Point(0, 0);
            this.lblStatScoreV.Name = "lblStatScoreV";
            this.lblStatScoreV.Size = new System.Drawing.Size(100, 23);
            this.lblStatScoreV.TabIndex = 0;
            // 
            // ContestUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1204, 700);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "ContestUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL Judge — Contests";
            this.Load += new System.EventHandler(this.ContestUI_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebarLogo.ResumeLayout(false);
            this.pnlSidebarLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlTimerBox.ResumeLayout(false);
            this.pnlTimerBox.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.pnlContestBrowser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContests)).EndInit();
            this.pnlJoinBar.ResumeLayout(false);
            this.pnlBrowserHeader.ResumeLayout(false);
            this.pnlBrowserHeader.PerformLayout();
            this.splitRight.Panel1.ResumeLayout(false);
            this.splitRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitRight)).EndInit();
            this.splitRight.ResumeLayout(false);
            this.pnlContestDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContestProblems)).EndInit();
            this.pnlProblemListHeader.ResumeLayout(false);
            this.pnlProblemListHeader.PerformLayout();
            this.pnlContestInfo.ResumeLayout(false);
            this.pnlContestInfo.PerformLayout();
            this.tlpContestStats.ResumeLayout(false);
            this.pnlStatParticipants.ResumeLayout(false);
            this.pnlLeaderboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaderboard)).EndInit();
            this.pnlLeaderHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        // ── Declarations ─────────────────────────────────────────────────────
        private System.Windows.Forms.Timer tmrCountdown;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlSidebarLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblAppSub;
        private FontAwesome.Sharp.IconButton btn_home;
        private FontAwesome.Sharp.IconButton btn_problems;
        private FontAwesome.Sharp.IconButton btn_contest;
        private FontAwesome.Sharp.IconButton btnReport;
        private FontAwesome.Sharp.IconButton btn_settings;
        private FontAwesome.Sharp.IconButton btn_Logout;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Panel pnlTimerBox;
        private System.Windows.Forms.Label lblTimerIcon;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblOnlineStatus;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.Panel pnlContestBrowser;
        private System.Windows.Forms.Panel pnlBrowserHeader;
        private System.Windows.Forms.Label lblBrowserTitle;
        private System.Windows.Forms.ComboBox cmbContestFilter;
        private System.Windows.Forms.DataGridView dgvContests;
        private System.Windows.Forms.Panel pnlJoinBar;
        private FontAwesome.Sharp.IconButton btnJoinContest;
        private System.Windows.Forms.Label lblContestStatus;
        private System.Windows.Forms.SplitContainer splitRight;
        private System.Windows.Forms.Panel pnlContestDetail;
        private System.Windows.Forms.Panel pnlContestInfo;
        private System.Windows.Forms.Label lblContestName;
        private System.Windows.Forms.Label lblContestMeta;
        private System.Windows.Forms.Label lblContestDesc;
        private System.Windows.Forms.TableLayoutPanel tlpContestStats;
        private System.Windows.Forms.Panel pnlStatParticipants;
        private System.Windows.Forms.Label lblStatParticipants;
        private System.Windows.Forms.Label lblStatParticipantsV;
        private System.Windows.Forms.Panel pnlStatProblems;
        private System.Windows.Forms.Label lblStatProblems;
        private System.Windows.Forms.Label lblStatProblemsV;
        private System.Windows.Forms.Panel pnlStatDuration;
        private System.Windows.Forms.Label lblStatDuration;
        private System.Windows.Forms.Label lblStatDurationV;
        private System.Windows.Forms.Panel pnlStatScore;
        private System.Windows.Forms.Label lblStatScore;
        private System.Windows.Forms.Label lblStatScoreV;
        private System.Windows.Forms.Panel pnlProblemListHeader;
        private System.Windows.Forms.Label lblProblemListTitle;
        private System.Windows.Forms.DataGridView dgvContestProblems;
        private System.Windows.Forms.Panel pnlLeaderboard;
        private System.Windows.Forms.Panel pnlLeaderHeader;
        private System.Windows.Forms.Label lblLeaderTitle;
        private FontAwesome.Sharp.IconButton btnRefreshLB;
        private System.Windows.Forms.DataGridView dgvLeaderboard;
    }
}