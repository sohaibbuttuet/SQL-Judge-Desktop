using System.Windows.Forms;

namespace SQL_Judge_System.UI
{
    partial class StudentDashboardUI
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.pnlHome = new System.Windows.Forms.Panel();
            this.pnlContentArea = new System.Windows.Forms.Panel();
            this.dgvLeaderboard = new System.Windows.Forms.DataGridView();
            this.lblGridTitle = new System.Windows.Forms.Label();
            this.pnlStatsContainer = new System.Windows.Forms.Panel();
            this.tlpnlStudentDashboard = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSkillLevel = new System.Windows.Forms.Panel();
            this.lblSkillValue = new System.Windows.Forms.Label();
            this.lblSkillLevel = new System.Windows.Forms.Label();
            this.lblSkillBadge = new System.Windows.Forms.Label();
            this.pnlRankCard = new System.Windows.Forms.Panel();
            this.lblRankValue = new System.Windows.Forms.Label();
            this.lblRankTitle = new System.Windows.Forms.Label();
            this.lblRankBadge = new System.Windows.Forms.Label();
            this.pnlSolvedCard = new System.Windows.Forms.Panel();
            this.lblSolvedValue = new System.Windows.Forms.Label();
            this.lblSolvedTitle = new System.Windows.Forms.Label();
            this.lblSolvedBadge = new System.Windows.Forms.Label();
            this.pnlScoreCard = new System.Windows.Forms.Panel();
            this.lblScoreValue = new System.Windows.Forms.Label();
            this.lblScoreTitle = new System.Windows.Forms.Label();
            this.lblScoreBadge = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblOnlineStatus = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlSidebar.SuspendLayout();
            this.pnlSidebarLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlHome.SuspendLayout();
            this.pnlContentArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaderboard)).BeginInit();
            this.pnlStatsContainer.SuspendLayout();
            this.tlpnlStudentDashboard.SuspendLayout();
            this.pnlSkillLevel.SuspendLayout();
            this.pnlRankCard.SuspendLayout();
            this.pnlSolvedCard.SuspendLayout();
            this.pnlScoreCard.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(26)))));
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
            this.pnlSidebar.Size = new System.Drawing.Size(202, 681);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(26)))));
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.btnReport.Size = new System.Drawing.Size(202, 48);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "Generate Report";
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btn_contest
            // 
            this.btn_contest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(26)))));
            this.btn_contest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_contest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_contest.FlatAppearance.BorderSize = 0;
            this.btn_contest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btn_contest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btn_contest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_contest.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btn_contest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.btn_contest.IconChar = FontAwesome.Sharp.IconChar.Trophy;
            this.btn_contest.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.btn_contest.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_contest.IconSize = 20;
            this.btn_contest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_contest.Location = new System.Drawing.Point(0, 166);
            this.btn_contest.Name = "btn_contest";
            this.btn_contest.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btn_contest.Size = new System.Drawing.Size(202, 48);
            this.btn_contest.TabIndex = 3;
            this.btn_contest.Text = "Join Contest";
            this.btn_contest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_contest.UseVisualStyleBackColor = false;
            this.btn_contest.Click += new System.EventHandler(this.btn_contest_Click);
            // 
            // btn_problems
            // 
            this.btn_problems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(26)))));
            this.btn_problems.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.btn_problems.Size = new System.Drawing.Size(202, 48);
            this.btn_problems.TabIndex = 2;
            this.btn_problems.Text = "Solve Problems";
            this.btn_problems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_problems.UseVisualStyleBackColor = false;
            this.btn_problems.Click += new System.EventHandler(this.btn_problems_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(26)))));
            this.btn_home.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.btn_home.Size = new System.Drawing.Size(202, 48);
            this.btn_home.TabIndex = 1;
            this.btn_home.Text = "Home";
            this.btn_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // pnlSidebarLogo
            // 
            this.pnlSidebarLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(26)))));
            this.pnlSidebarLogo.Controls.Add(this.picLogo);
            this.pnlSidebarLogo.Controls.Add(this.lblAppSub);
            this.pnlSidebarLogo.Controls.Add(this.lblAppName);
            this.pnlSidebarLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSidebarLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebarLogo.Name = "pnlSidebarLogo";
            this.pnlSidebarLogo.Size = new System.Drawing.Size(202, 70);
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
            this.btn_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(26)))));
            this.btn_settings.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.btn_settings.Location = new System.Drawing.Point(0, 585);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btn_settings.Size = new System.Drawing.Size(202, 48);
            this.btn_settings.TabIndex = 10;
            this.btn_settings.Text = "Settings";
            this.btn_settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_settings.UseVisualStyleBackColor = false;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(26)))));
            this.btn_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.btn_Logout.Location = new System.Drawing.Point(0, 633);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btn_Logout.Size = new System.Drawing.Size(202, 48);
            this.btn_Logout.TabIndex = 11;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // pnlHome
            // 
            this.pnlHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(26)))));
            this.pnlHome.Controls.Add(this.pnlContentArea);
            this.pnlHome.Controls.Add(this.pnlStatsContainer);
            this.pnlHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHome.Location = new System.Drawing.Point(202, 56);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(982, 625);
            this.pnlHome.TabIndex = 12;
            // 
            // pnlContentArea
            // 
            this.pnlContentArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(26)))));
            this.pnlContentArea.Controls.Add(this.dgvLeaderboard);
            this.pnlContentArea.Controls.Add(this.lblGridTitle);
            this.pnlContentArea.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlContentArea.Location = new System.Drawing.Point(0, 169);
            this.pnlContentArea.Name = "pnlContentArea";
            this.pnlContentArea.Padding = new System.Windows.Forms.Padding(14, 10, 14, 14);
            this.pnlContentArea.Size = new System.Drawing.Size(982, 456);
            this.pnlContentArea.TabIndex = 6;
            // 
            // dgvLeaderboard
            // 
            this.dgvLeaderboard.AllowUserToAddRows = false;
            this.dgvLeaderboard.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(201)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvLeaderboard.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLeaderboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLeaderboard.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.dgvLeaderboard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.dgvLeaderboard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLeaderboard.ColumnHeadersHeight = 38;
            this.dgvLeaderboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(201)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLeaderboard.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLeaderboard.EnableHeadersVisualStyles = false;
            this.dgvLeaderboard.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(47)))));
            this.dgvLeaderboard.Location = new System.Drawing.Point(18, 47);
            this.dgvLeaderboard.MultiSelect = false;
            this.dgvLeaderboard.Name = "dgvLeaderboard";
            this.dgvLeaderboard.ReadOnly = true;
            this.dgvLeaderboard.RowHeadersVisible = false;
            this.dgvLeaderboard.RowTemplate.Height = 36;
            this.dgvLeaderboard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLeaderboard.Size = new System.Drawing.Size(947, 397);
            this.dgvLeaderboard.TabIndex = 1;
            // 
            // lblGridTitle
            // 
            this.lblGridTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGridTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblGridTitle.Location = new System.Drawing.Point(14, 10);
            this.lblGridTitle.Name = "lblGridTitle";
            this.lblGridTitle.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.lblGridTitle.Size = new System.Drawing.Size(954, 31);
            this.lblGridTitle.TabIndex = 0;
            this.lblGridTitle.Text = "Global Leaderboard";
            this.lblGridTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlStatsContainer
            // 
            this.pnlStatsContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(26)))));
            this.pnlStatsContainer.Controls.Add(this.tlpnlStudentDashboard);
            this.pnlStatsContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStatsContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlStatsContainer.Name = "pnlStatsContainer";
            this.pnlStatsContainer.Padding = new System.Windows.Forms.Padding(12, 12, 12, 0);
            this.pnlStatsContainer.Size = new System.Drawing.Size(982, 167);
            this.pnlStatsContainer.TabIndex = 4;
            // 
            // tlpnlStudentDashboard
            // 
            this.tlpnlStudentDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(26)))));
            this.tlpnlStudentDashboard.ColumnCount = 4;
            this.tlpnlStudentDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpnlStudentDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpnlStudentDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpnlStudentDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpnlStudentDashboard.Controls.Add(this.pnlSkillLevel, 0, 0);
            this.tlpnlStudentDashboard.Controls.Add(this.pnlRankCard, 1, 0);
            this.tlpnlStudentDashboard.Controls.Add(this.pnlSolvedCard, 2, 0);
            this.tlpnlStudentDashboard.Controls.Add(this.pnlScoreCard, 3, 0);
            this.tlpnlStudentDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpnlStudentDashboard.Location = new System.Drawing.Point(12, 12);
            this.tlpnlStudentDashboard.Name = "tlpnlStudentDashboard";
            this.tlpnlStudentDashboard.RowCount = 1;
            this.tlpnlStudentDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpnlStudentDashboard.Size = new System.Drawing.Size(958, 155);
            this.tlpnlStudentDashboard.TabIndex = 0;
            // 
            // pnlSkillLevel
            // 
            this.pnlSkillLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.pnlSkillLevel.Controls.Add(this.lblSkillValue);
            this.pnlSkillLevel.Controls.Add(this.lblSkillLevel);
            this.pnlSkillLevel.Controls.Add(this.lblSkillBadge);
            this.pnlSkillLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSkillLevel.Location = new System.Drawing.Point(6, 6);
            this.pnlSkillLevel.Margin = new System.Windows.Forms.Padding(6);
            this.pnlSkillLevel.Name = "pnlSkillLevel";
            this.pnlSkillLevel.Padding = new System.Windows.Forms.Padding(8);
            this.pnlSkillLevel.Size = new System.Drawing.Size(227, 143);
            this.pnlSkillLevel.TabIndex = 0;
            // 
            // lblSkillValue
            // 
            this.lblSkillValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSkillValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblSkillValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(66)))));
            this.lblSkillValue.Location = new System.Drawing.Point(8, 30);
            this.lblSkillValue.Name = "lblSkillValue";
            this.lblSkillValue.Size = new System.Drawing.Size(211, 85);
            this.lblSkillValue.TabIndex = 1;
            this.lblSkillValue.Text = "—";
            this.lblSkillValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSkillLevel
            // 
            this.lblSkillLevel.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSkillLevel.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblSkillLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblSkillLevel.Location = new System.Drawing.Point(8, 8);
            this.lblSkillLevel.Name = "lblSkillLevel";
            this.lblSkillLevel.Size = new System.Drawing.Size(211, 22);
            this.lblSkillLevel.TabIndex = 0;
            this.lblSkillLevel.Text = "SKILL LEVEL";
            this.lblSkillLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSkillBadge
            // 
            this.lblSkillBadge.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSkillBadge.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSkillBadge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(66)))));
            this.lblSkillBadge.Location = new System.Drawing.Point(8, 115);
            this.lblSkillBadge.Name = "lblSkillBadge";
            this.lblSkillBadge.Size = new System.Drawing.Size(211, 20);
            this.lblSkillBadge.TabIndex = 2;
            this.lblSkillBadge.Text = "Getting Started";
            this.lblSkillBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlRankCard
            // 
            this.pnlRankCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.pnlRankCard.Controls.Add(this.lblRankValue);
            this.pnlRankCard.Controls.Add(this.lblRankTitle);
            this.pnlRankCard.Controls.Add(this.lblRankBadge);
            this.pnlRankCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRankCard.Location = new System.Drawing.Point(245, 6);
            this.pnlRankCard.Margin = new System.Windows.Forms.Padding(6);
            this.pnlRankCard.Name = "pnlRankCard";
            this.pnlRankCard.Padding = new System.Windows.Forms.Padding(8);
            this.pnlRankCard.Size = new System.Drawing.Size(227, 143);
            this.pnlRankCard.TabIndex = 1;
            // 
            // lblRankValue
            // 
            this.lblRankValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRankValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblRankValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(111)))), ((int)(((byte)(255)))));
            this.lblRankValue.Location = new System.Drawing.Point(8, 30);
            this.lblRankValue.Name = "lblRankValue";
            this.lblRankValue.Size = new System.Drawing.Size(211, 85);
            this.lblRankValue.TabIndex = 1;
            this.lblRankValue.Text = "—";
            this.lblRankValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRankTitle
            // 
            this.lblRankTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRankTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblRankTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblRankTitle.Location = new System.Drawing.Point(8, 8);
            this.lblRankTitle.Name = "lblRankTitle";
            this.lblRankTitle.Size = new System.Drawing.Size(211, 22);
            this.lblRankTitle.TabIndex = 0;
            this.lblRankTitle.Text = "RANK";
            this.lblRankTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRankBadge
            // 
            this.lblRankBadge.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblRankBadge.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblRankBadge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(111)))), ((int)(((byte)(255)))));
            this.lblRankBadge.Location = new System.Drawing.Point(8, 115);
            this.lblRankBadge.Name = "lblRankBadge";
            this.lblRankBadge.Size = new System.Drawing.Size(211, 20);
            this.lblRankBadge.TabIndex = 2;
            this.lblRankBadge.Text = "Global";
            this.lblRankBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSolvedCard
            // 
            this.pnlSolvedCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.pnlSolvedCard.Controls.Add(this.lblSolvedValue);
            this.pnlSolvedCard.Controls.Add(this.lblSolvedTitle);
            this.pnlSolvedCard.Controls.Add(this.lblSolvedBadge);
            this.pnlSolvedCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSolvedCard.Location = new System.Drawing.Point(484, 6);
            this.pnlSolvedCard.Margin = new System.Windows.Forms.Padding(6);
            this.pnlSolvedCard.Name = "pnlSolvedCard";
            this.pnlSolvedCard.Padding = new System.Windows.Forms.Padding(8);
            this.pnlSolvedCard.Size = new System.Drawing.Size(227, 143);
            this.pnlSolvedCard.TabIndex = 2;
            // 
            // lblSolvedValue
            // 
            this.lblSolvedValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSolvedValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblSolvedValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.lblSolvedValue.Location = new System.Drawing.Point(8, 30);
            this.lblSolvedValue.Name = "lblSolvedValue";
            this.lblSolvedValue.Size = new System.Drawing.Size(211, 85);
            this.lblSolvedValue.TabIndex = 1;
            this.lblSolvedValue.Text = "—";
            this.lblSolvedValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSolvedTitle
            // 
            this.lblSolvedTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSolvedTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblSolvedTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblSolvedTitle.Location = new System.Drawing.Point(8, 8);
            this.lblSolvedTitle.Name = "lblSolvedTitle";
            this.lblSolvedTitle.Size = new System.Drawing.Size(211, 22);
            this.lblSolvedTitle.TabIndex = 0;
            this.lblSolvedTitle.Text = "PROBLEMS SOLVED";
            this.lblSolvedTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSolvedBadge
            // 
            this.lblSolvedBadge.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSolvedBadge.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSolvedBadge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.lblSolvedBadge.Location = new System.Drawing.Point(8, 115);
            this.lblSolvedBadge.Name = "lblSolvedBadge";
            this.lblSolvedBadge.Size = new System.Drawing.Size(211, 20);
            this.lblSolvedBadge.TabIndex = 2;
            this.lblSolvedBadge.Text = "All Time";
            this.lblSolvedBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlScoreCard
            // 
            this.pnlScoreCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.pnlScoreCard.Controls.Add(this.lblScoreValue);
            this.pnlScoreCard.Controls.Add(this.lblScoreTitle);
            this.pnlScoreCard.Controls.Add(this.lblScoreBadge);
            this.pnlScoreCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlScoreCard.Location = new System.Drawing.Point(723, 6);
            this.pnlScoreCard.Margin = new System.Windows.Forms.Padding(6);
            this.pnlScoreCard.Name = "pnlScoreCard";
            this.pnlScoreCard.Padding = new System.Windows.Forms.Padding(8);
            this.pnlScoreCard.Size = new System.Drawing.Size(229, 143);
            this.pnlScoreCard.TabIndex = 3;
            // 
            // lblScoreValue
            // 
            this.lblScoreValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblScoreValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblScoreValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(207)))), ((int)(((byte)(142)))));
            this.lblScoreValue.Location = new System.Drawing.Point(8, 30);
            this.lblScoreValue.Name = "lblScoreValue";
            this.lblScoreValue.Size = new System.Drawing.Size(213, 85);
            this.lblScoreValue.TabIndex = 1;
            this.lblScoreValue.Text = "—";
            this.lblScoreValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScoreTitle
            // 
            this.lblScoreTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblScoreTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblScoreTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblScoreTitle.Location = new System.Drawing.Point(8, 8);
            this.lblScoreTitle.Name = "lblScoreTitle";
            this.lblScoreTitle.Size = new System.Drawing.Size(213, 22);
            this.lblScoreTitle.TabIndex = 0;
            this.lblScoreTitle.Text = "TOTAL SCORE";
            this.lblScoreTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScoreBadge
            // 
            this.lblScoreBadge.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblScoreBadge.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblScoreBadge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(207)))), ((int)(((byte)(142)))));
            this.lblScoreBadge.Location = new System.Drawing.Point(8, 115);
            this.lblScoreBadge.Name = "lblScoreBadge";
            this.lblScoreBadge.Size = new System.Drawing.Size(213, 20);
            this.lblScoreBadge.TabIndex = 2;
            this.lblScoreBadge.Text = "Points";
            this.lblScoreBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(20, 14);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(115, 30);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome!";
            // 
            // lblOnlineStatus
            // 
            this.lblOnlineStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOnlineStatus.AutoSize = true;
            this.lblOnlineStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOnlineStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(207)))), ((int)(((byte)(142)))));
            this.lblOnlineStatus.Location = new System.Drawing.Point(918, 21);
            this.lblOnlineStatus.Name = "lblOnlineStatus";
            this.lblOnlineStatus.Size = new System.Drawing.Size(52, 15);
            this.lblOnlineStatus.TabIndex = 1;
            this.lblOnlineStatus.Text = "● Online";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.pnlHeader.Controls.Add(this.lblOnlineStatus);
            this.pnlHeader.Controls.Add(this.lblWelcome);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(202, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(982, 56);
            this.pnlHeader.TabIndex = 1;
            // 
            // StudentDashboardUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.pnlHome);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "StudentDashboardUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student SQL Judge Workspace";
            this.Load += new System.EventHandler(this.StudentDashboard_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebarLogo.ResumeLayout(false);
            this.pnlSidebarLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlHome.ResumeLayout(false);
            this.pnlContentArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaderboard)).EndInit();
            this.pnlStatsContainer.ResumeLayout(false);
            this.tlpnlStudentDashboard.ResumeLayout(false);
            this.pnlSkillLevel.ResumeLayout(false);
            this.pnlRankCard.ResumeLayout(false);
            this.pnlSolvedCard.ResumeLayout(false);
            this.pnlScoreCard.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        // ── Declarations ─────────────────────────────────────────────────────
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlSidebarLogo;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblAppSub;
        private FontAwesome.Sharp.IconButton btn_home;
        private FontAwesome.Sharp.IconButton btn_problems;
        private FontAwesome.Sharp.IconButton btn_contest;
        private FontAwesome.Sharp.IconButton btnReport;
        private FontAwesome.Sharp.IconButton btn_settings;
        private FontAwesome.Sharp.IconButton btn_Logout;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Panel pnlStatsContainer;
        private System.Windows.Forms.TableLayoutPanel tlpnlStudentDashboard;
        private System.Windows.Forms.Panel pnlSkillLevel;
        private System.Windows.Forms.Label lblSkillValue;
        private System.Windows.Forms.Label lblSkillLevel;
        private System.Windows.Forms.Label lblSkillBadge;
        private System.Windows.Forms.Panel pnlRankCard;
        private System.Windows.Forms.Label lblRankValue;
        private System.Windows.Forms.Label lblRankTitle;
        private System.Windows.Forms.Label lblRankBadge;
        private System.Windows.Forms.Panel pnlSolvedCard;
        private System.Windows.Forms.Label lblSolvedValue;
        private System.Windows.Forms.Label lblSolvedTitle;
        private System.Windows.Forms.Label lblSolvedBadge;
        private System.Windows.Forms.Panel pnlScoreCard;
        private System.Windows.Forms.Label lblScoreValue;
        private System.Windows.Forms.Label lblScoreTitle;
        private System.Windows.Forms.Label lblScoreBadge;
        private Label lblWelcome;
        private Label lblOnlineStatus;
        private Panel pnlHeader;
        private Panel pnlContentArea;
        private DataGridView dgvLeaderboard;
        private Label lblGridTitle;
    }
}