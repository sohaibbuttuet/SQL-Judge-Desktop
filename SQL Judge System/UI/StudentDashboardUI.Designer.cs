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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.pnlSolveProblem = new System.Windows.Forms.Panel();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.pnlProblemList = new System.Windows.Forms.Panel();
            this.dgvProblems = new System.Windows.Forms.DataGridView();
            this.pnlListHeader = new System.Windows.Forms.Panel();
            this.cmbDifficulty = new System.Windows.Forms.ComboBox();
            this.lblProblemsTitle = new System.Windows.Forms.Label();
            this.splitRight = new System.Windows.Forms.SplitContainer();
            this.pnlEditorArea = new System.Windows.Forms.Panel();
            this.rtbSQLEditor = new System.Windows.Forms.RichTextBox();
            this.pnlEditorActions = new System.Windows.Forms.Panel();
            this.lblLineCol = new System.Windows.Forms.Label();
            this.btnSubmit = new FontAwesome.Sharp.IconButton();
            this.btnRunQuery = new FontAwesome.Sharp.IconButton();
            this.pnlEditorHeader = new System.Windows.Forms.Panel();
            this.btnClearEditor = new FontAwesome.Sharp.IconButton();
            this.lblEditorTitle = new System.Windows.Forms.Label();
            this.pnlProblemDesc = new System.Windows.Forms.Panel();
            this.lblDifficultyBadge = new System.Windows.Forms.Label();
            this.lblProblemName = new System.Windows.Forms.Label();
            this.rtbProblemDesc = new System.Windows.Forms.RichTextBox();
            this.pnlOutputArea = new System.Windows.Forms.Panel();
            this.dgvOutput = new System.Windows.Forms.DataGridView();
            this.pnlOutputHeader = new System.Windows.Forms.Panel();
            this.lblResultBadge = new System.Windows.Forms.Label();
            this.btnClearOutput = new FontAwesome.Sharp.IconButton();
            this.lblOutputTitle = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblOnlineStatus = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.tvSchema = new System.Windows.Forms.TreeView();
            this.lblDifficulty = new System.Windows.Forms.Label();
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
            this.pnlSolveProblem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.pnlProblemList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProblems)).BeginInit();
            this.pnlListHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitRight)).BeginInit();
            this.splitRight.Panel1.SuspendLayout();
            this.splitRight.Panel2.SuspendLayout();
            this.splitRight.SuspendLayout();
            this.pnlEditorArea.SuspendLayout();
            this.pnlEditorActions.SuspendLayout();
            this.pnlEditorHeader.SuspendLayout();
            this.pnlProblemDesc.SuspendLayout();
            this.pnlOutputArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).BeginInit();
            this.pnlOutputHeader.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
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
            this.pnlSidebar.Size = new System.Drawing.Size(220, 681);
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
            this.btnReport.Size = new System.Drawing.Size(220, 48);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "Generate Report";
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btn_contest
            // 
            this.btn_contest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(56)))));
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
            this.btn_contest.Size = new System.Drawing.Size(220, 48);
            this.btn_contest.TabIndex = 3;
            this.btn_contest.Text = "Join Contest";
            this.btn_contest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_contest.UseVisualStyleBackColor = false;
            this.btn_contest.Click += new System.EventHandler(this.btn_contest_Click);
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
            this.btn_problems.Size = new System.Drawing.Size(220, 48);
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
            this.btn_home.Size = new System.Drawing.Size(220, 48);
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
            this.pnlSidebarLogo.Size = new System.Drawing.Size(220, 70);
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
            this.btn_settings.Location = new System.Drawing.Point(0, 585);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btn_settings.Size = new System.Drawing.Size(220, 48);
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
            this.btn_Logout.Location = new System.Drawing.Point(0, 633);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btn_Logout.Size = new System.Drawing.Size(220, 48);
            this.btn_Logout.TabIndex = 11;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // pnlHome
            // 
            this.pnlHome.Controls.Add(this.pnlContentArea);
            this.pnlHome.Controls.Add(this.pnlStatsContainer);
            this.pnlHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHome.Location = new System.Drawing.Point(0, 0);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(1184, 681);
            this.pnlHome.TabIndex = 12;
            // 
            // pnlContentArea
            // 
            this.pnlContentArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.pnlContentArea.Controls.Add(this.dgvLeaderboard);
            this.pnlContentArea.Controls.Add(this.lblGridTitle);
            this.pnlContentArea.Location = new System.Drawing.Point(0, 165);
            this.pnlContentArea.Name = "pnlContentArea";
            this.pnlContentArea.Padding = new System.Windows.Forms.Padding(14, 10, 14, 14);
            this.pnlContentArea.Size = new System.Drawing.Size(1001, 479);
            this.pnlContentArea.TabIndex = 5;
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
            this.dgvLeaderboard.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
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
            this.dgvLeaderboard.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.dgvLeaderboard.Location = new System.Drawing.Point(0, 47);
            this.dgvLeaderboard.Name = "dgvLeaderboard";
            this.dgvLeaderboard.ReadOnly = true;
            this.dgvLeaderboard.RowHeadersVisible = false;
            this.dgvLeaderboard.RowTemplate.Height = 36;
            this.dgvLeaderboard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLeaderboard.Size = new System.Drawing.Size(964, 413);
            this.dgvLeaderboard.TabIndex = 1;
            // 
            // lblGridTitle
            // 
            this.lblGridTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblGridTitle.Location = new System.Drawing.Point(0, 10);
            this.lblGridTitle.Name = "lblGridTitle";
            this.lblGridTitle.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.lblGridTitle.Size = new System.Drawing.Size(961, 31);
            this.lblGridTitle.TabIndex = 0;
            this.lblGridTitle.Text = "Global Leaderboard";
            this.lblGridTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlStatsContainer
            // 
            this.pnlStatsContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.pnlStatsContainer.Controls.Add(this.tlpnlStudentDashboard);
            this.pnlStatsContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStatsContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlStatsContainer.Name = "pnlStatsContainer";
            this.pnlStatsContainer.Padding = new System.Windows.Forms.Padding(12, 12, 12, 0);
            this.pnlStatsContainer.Size = new System.Drawing.Size(1184, 165);
            this.pnlStatsContainer.TabIndex = 4;
            // 
            // tlpnlStudentDashboard
            // 
            this.tlpnlStudentDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
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
            this.tlpnlStudentDashboard.Size = new System.Drawing.Size(1160, 153);
            this.tlpnlStudentDashboard.TabIndex = 0;
            // 
            // pnlSkillLevel
            // 
            this.pnlSkillLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.pnlSkillLevel.Controls.Add(this.lblSkillValue);
            this.pnlSkillLevel.Controls.Add(this.lblSkillLevel);
            this.pnlSkillLevel.Controls.Add(this.lblSkillBadge);
            this.pnlSkillLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSkillLevel.Location = new System.Drawing.Point(6, 6);
            this.pnlSkillLevel.Margin = new System.Windows.Forms.Padding(6);
            this.pnlSkillLevel.Name = "pnlSkillLevel";
            this.pnlSkillLevel.Padding = new System.Windows.Forms.Padding(8);
            this.pnlSkillLevel.Size = new System.Drawing.Size(278, 141);
            this.pnlSkillLevel.TabIndex = 0;
            // 
            // lblSkillValue
            // 
            this.lblSkillValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSkillValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblSkillValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(66)))));
            this.lblSkillValue.Location = new System.Drawing.Point(8, 30);
            this.lblSkillValue.Name = "lblSkillValue";
            this.lblSkillValue.Size = new System.Drawing.Size(262, 83);
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
            this.lblSkillLevel.Size = new System.Drawing.Size(262, 22);
            this.lblSkillLevel.TabIndex = 0;
            this.lblSkillLevel.Text = "SKILL LEVEL";
            this.lblSkillLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSkillBadge
            // 
            this.lblSkillBadge.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSkillBadge.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSkillBadge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(66)))));
            this.lblSkillBadge.Location = new System.Drawing.Point(8, 113);
            this.lblSkillBadge.Name = "lblSkillBadge";
            this.lblSkillBadge.Size = new System.Drawing.Size(262, 20);
            this.lblSkillBadge.TabIndex = 2;
            this.lblSkillBadge.Text = "Getting Started";
            this.lblSkillBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlRankCard
            // 
            this.pnlRankCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.pnlRankCard.Controls.Add(this.lblRankValue);
            this.pnlRankCard.Controls.Add(this.lblRankTitle);
            this.pnlRankCard.Controls.Add(this.lblRankBadge);
            this.pnlRankCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRankCard.Location = new System.Drawing.Point(296, 6);
            this.pnlRankCard.Margin = new System.Windows.Forms.Padding(6);
            this.pnlRankCard.Name = "pnlRankCard";
            this.pnlRankCard.Padding = new System.Windows.Forms.Padding(8);
            this.pnlRankCard.Size = new System.Drawing.Size(278, 141);
            this.pnlRankCard.TabIndex = 1;
            // 
            // lblRankValue
            // 
            this.lblRankValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRankValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblRankValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(111)))), ((int)(((byte)(255)))));
            this.lblRankValue.Location = new System.Drawing.Point(8, 30);
            this.lblRankValue.Name = "lblRankValue";
            this.lblRankValue.Size = new System.Drawing.Size(262, 83);
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
            this.lblRankTitle.Size = new System.Drawing.Size(262, 22);
            this.lblRankTitle.TabIndex = 0;
            this.lblRankTitle.Text = "RANK";
            this.lblRankTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRankBadge
            // 
            this.lblRankBadge.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblRankBadge.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblRankBadge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(111)))), ((int)(((byte)(255)))));
            this.lblRankBadge.Location = new System.Drawing.Point(8, 113);
            this.lblRankBadge.Name = "lblRankBadge";
            this.lblRankBadge.Size = new System.Drawing.Size(262, 20);
            this.lblRankBadge.TabIndex = 2;
            this.lblRankBadge.Text = "Global";
            this.lblRankBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSolvedCard
            // 
            this.pnlSolvedCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.pnlSolvedCard.Controls.Add(this.lblSolvedValue);
            this.pnlSolvedCard.Controls.Add(this.lblSolvedTitle);
            this.pnlSolvedCard.Controls.Add(this.lblSolvedBadge);
            this.pnlSolvedCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSolvedCard.Location = new System.Drawing.Point(586, 6);
            this.pnlSolvedCard.Margin = new System.Windows.Forms.Padding(6);
            this.pnlSolvedCard.Name = "pnlSolvedCard";
            this.pnlSolvedCard.Padding = new System.Windows.Forms.Padding(8);
            this.pnlSolvedCard.Size = new System.Drawing.Size(278, 141);
            this.pnlSolvedCard.TabIndex = 2;
            // 
            // lblSolvedValue
            // 
            this.lblSolvedValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSolvedValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblSolvedValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.lblSolvedValue.Location = new System.Drawing.Point(8, 30);
            this.lblSolvedValue.Name = "lblSolvedValue";
            this.lblSolvedValue.Size = new System.Drawing.Size(262, 83);
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
            this.lblSolvedTitle.Size = new System.Drawing.Size(262, 22);
            this.lblSolvedTitle.TabIndex = 0;
            this.lblSolvedTitle.Text = "PROBLEMS SOLVED";
            this.lblSolvedTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSolvedBadge
            // 
            this.lblSolvedBadge.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSolvedBadge.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSolvedBadge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.lblSolvedBadge.Location = new System.Drawing.Point(8, 113);
            this.lblSolvedBadge.Name = "lblSolvedBadge";
            this.lblSolvedBadge.Size = new System.Drawing.Size(262, 20);
            this.lblSolvedBadge.TabIndex = 2;
            this.lblSolvedBadge.Text = "All Time";
            this.lblSolvedBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlScoreCard
            // 
            this.pnlScoreCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.pnlScoreCard.Controls.Add(this.lblScoreValue);
            this.pnlScoreCard.Controls.Add(this.lblScoreTitle);
            this.pnlScoreCard.Controls.Add(this.lblScoreBadge);
            this.pnlScoreCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlScoreCard.Location = new System.Drawing.Point(876, 6);
            this.pnlScoreCard.Margin = new System.Windows.Forms.Padding(6);
            this.pnlScoreCard.Name = "pnlScoreCard";
            this.pnlScoreCard.Padding = new System.Windows.Forms.Padding(8);
            this.pnlScoreCard.Size = new System.Drawing.Size(278, 141);
            this.pnlScoreCard.TabIndex = 3;
            // 
            // lblScoreValue
            // 
            this.lblScoreValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblScoreValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblScoreValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(207)))), ((int)(((byte)(142)))));
            this.lblScoreValue.Location = new System.Drawing.Point(8, 30);
            this.lblScoreValue.Name = "lblScoreValue";
            this.lblScoreValue.Size = new System.Drawing.Size(262, 83);
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
            this.lblScoreTitle.Size = new System.Drawing.Size(262, 22);
            this.lblScoreTitle.TabIndex = 0;
            this.lblScoreTitle.Text = "TOTAL SCORE";
            this.lblScoreTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScoreBadge
            // 
            this.lblScoreBadge.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblScoreBadge.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblScoreBadge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(207)))), ((int)(((byte)(142)))));
            this.lblScoreBadge.Location = new System.Drawing.Point(8, 113);
            this.lblScoreBadge.Name = "lblScoreBadge";
            this.lblScoreBadge.Size = new System.Drawing.Size(262, 20);
            this.lblScoreBadge.TabIndex = 2;
            this.lblScoreBadge.Text = "Points";
            this.lblScoreBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSolveProblem
            // 
            this.pnlSolveProblem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.pnlSolveProblem.Controls.Add(this.splitMain);
            this.pnlSolveProblem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSolveProblem.Location = new System.Drawing.Point(220, 56);
            this.pnlSolveProblem.Name = "pnlSolveProblem";
            this.pnlSolveProblem.Padding = new System.Windows.Forms.Padding(10);
            this.pnlSolveProblem.Size = new System.Drawing.Size(964, 625);
            this.pnlSolveProblem.TabIndex = 13;
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
            this.splitMain.Panel1.Controls.Add(this.pnlProblemList);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.splitRight);
            this.splitMain.Size = new System.Drawing.Size(944, 605);
            this.splitMain.SplitterDistance = 267;
            this.splitMain.SplitterWidth = 6;
            this.splitMain.TabIndex = 0;
            // 
            // pnlProblemList
            // 
            this.pnlProblemList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.pnlProblemList.Controls.Add(this.lblDifficulty);
            this.pnlProblemList.Controls.Add(this.tvSchema);
            this.pnlProblemList.Controls.Add(this.dgvProblems);
            this.pnlProblemList.Controls.Add(this.pnlListHeader);
            this.pnlProblemList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProblemList.Location = new System.Drawing.Point(0, 0);
            this.pnlProblemList.Name = "pnlProblemList";
            this.pnlProblemList.Size = new System.Drawing.Size(267, 605);
            this.pnlProblemList.TabIndex = 0;
            // 
            // dgvProblems
            // 
            this.dgvProblems.AllowUserToAddRows = false;
            this.dgvProblems.AllowUserToDeleteRows = false;
            this.dgvProblems.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(201)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProblems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProblems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProblems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.dgvProblems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProblems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.dgvProblems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProblems.ColumnHeadersHeight = 36;
            this.dgvProblems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProblems.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProblems.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvProblems.EnableHeadersVisualStyles = false;
            this.dgvProblems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.dgvProblems.Location = new System.Drawing.Point(0, 64);
            this.dgvProblems.MultiSelect = false;
            this.dgvProblems.Name = "dgvProblems";
            this.dgvProblems.ReadOnly = true;
            this.dgvProblems.RowHeadersVisible = false;
            this.dgvProblems.RowTemplate.Height = 34;
            this.dgvProblems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProblems.Size = new System.Drawing.Size(267, 262);
            this.dgvProblems.TabIndex = 1;
            this.dgvProblems.SelectionChanged += new System.EventHandler(this.dgvProblems_SelectionChanged);
            // 
            // pnlListHeader
            // 
            this.pnlListHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.pnlListHeader.Controls.Add(this.cmbDifficulty);
            this.pnlListHeader.Controls.Add(this.lblProblemsTitle);
            this.pnlListHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlListHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlListHeader.Name = "pnlListHeader";
            this.pnlListHeader.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.pnlListHeader.Size = new System.Drawing.Size(267, 64);
            this.pnlListHeader.TabIndex = 0;
            // 
            // cmbDifficulty
            // 
            this.cmbDifficulty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.cmbDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDifficulty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDifficulty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbDifficulty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(201)))), ((int)(((byte)(224)))));
            this.cmbDifficulty.Items.AddRange(new object[] {
            "All",
            "Easy",
            "Medium",
            "Hard"});
            this.cmbDifficulty.Location = new System.Drawing.Point(10, 36);
            this.cmbDifficulty.Name = "cmbDifficulty";
            this.cmbDifficulty.Size = new System.Drawing.Size(260, 23);
            this.cmbDifficulty.TabIndex = 1;
            this.cmbDifficulty.SelectedIndexChanged += new System.EventHandler(this.cmbDifficulty_SelectedIndexChanged);
            // 
            // lblProblemsTitle
            // 
            this.lblProblemsTitle.AutoSize = true;
            this.lblProblemsTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblProblemsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblProblemsTitle.Location = new System.Drawing.Point(10, 10);
            this.lblProblemsTitle.Name = "lblProblemsTitle";
            this.lblProblemsTitle.Size = new System.Drawing.Size(75, 20);
            this.lblProblemsTitle.TabIndex = 0;
            this.lblProblemsTitle.Text = "Problems";
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
            this.splitRight.Panel1.Controls.Add(this.pnlEditorArea);
            // 
            // splitRight.Panel2
            // 
            this.splitRight.Panel2.Controls.Add(this.pnlOutputArea);
            this.splitRight.Size = new System.Drawing.Size(671, 605);
            this.splitRight.SplitterDistance = 427;
            this.splitRight.SplitterWidth = 6;
            this.splitRight.TabIndex = 0;
            // 
            // pnlEditorArea
            // 
            this.pnlEditorArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.pnlEditorArea.Controls.Add(this.rtbSQLEditor);
            this.pnlEditorArea.Controls.Add(this.pnlEditorActions);
            this.pnlEditorArea.Controls.Add(this.pnlEditorHeader);
            this.pnlEditorArea.Controls.Add(this.pnlProblemDesc);
            this.pnlEditorArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEditorArea.Location = new System.Drawing.Point(0, 0);
            this.pnlEditorArea.Name = "pnlEditorArea";
            this.pnlEditorArea.Size = new System.Drawing.Size(671, 427);
            this.pnlEditorArea.TabIndex = 0;
            // 
            // rtbSQLEditor
            // 
            this.rtbSQLEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(24)))), ((int)(((byte)(48)))));
            this.rtbSQLEditor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbSQLEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbSQLEditor.Font = new System.Drawing.Font("Consolas", 11F);
            this.rtbSQLEditor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.rtbSQLEditor.Location = new System.Drawing.Point(0, 166);
            this.rtbSQLEditor.Name = "rtbSQLEditor";
            this.rtbSQLEditor.Size = new System.Drawing.Size(671, 213);
            this.rtbSQLEditor.TabIndex = 2;
            this.rtbSQLEditor.Text = "-- Write your SQL query here\nSELECT ";
            this.rtbSQLEditor.WordWrap = false;
            this.rtbSQLEditor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rtbSQLEditor_KeyUp);
            // 
            // pnlEditorActions
            // 
            this.pnlEditorActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(56)))));
            this.pnlEditorActions.Controls.Add(this.lblLineCol);
            this.pnlEditorActions.Controls.Add(this.btnSubmit);
            this.pnlEditorActions.Controls.Add(this.btnRunQuery);
            this.pnlEditorActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlEditorActions.Location = new System.Drawing.Point(0, 379);
            this.pnlEditorActions.Name = "pnlEditorActions";
            this.pnlEditorActions.Padding = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.pnlEditorActions.Size = new System.Drawing.Size(671, 48);
            this.pnlEditorActions.TabIndex = 3;
            // 
            // lblLineCol
            // 
            this.lblLineCol.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLineCol.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.lblLineCol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(106)))), ((int)(((byte)(140)))));
            this.lblLineCol.Location = new System.Drawing.Point(541, 6);
            this.lblLineCol.Name = "lblLineCol";
            this.lblLineCol.Size = new System.Drawing.Size(120, 36);
            this.lblLineCol.TabIndex = 2;
            this.lblLineCol.Text = "Ln 1, Col 1";
            this.lblLineCol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(207)))), ((int)(((byte)(142)))));
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(175)))), ((int)(((byte)(115)))));
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(220)))), ((int)(((byte)(155)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.btnSubmit.IconColor = System.Drawing.Color.White;
            this.btnSubmit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSubmit.IconSize = 14;
            this.btnSubmit.Location = new System.Drawing.Point(120, 6);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnSubmit.Size = new System.Drawing.Size(110, 36);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnRunQuery
            // 
            this.btnRunQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.btnRunQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRunQuery.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRunQuery.FlatAppearance.BorderSize = 0;
            this.btnRunQuery.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.btnRunQuery.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.btnRunQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunQuery.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnRunQuery.ForeColor = System.Drawing.Color.White;
            this.btnRunQuery.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.btnRunQuery.IconColor = System.Drawing.Color.White;
            this.btnRunQuery.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRunQuery.IconSize = 14;
            this.btnRunQuery.Location = new System.Drawing.Point(10, 6);
            this.btnRunQuery.Name = "btnRunQuery";
            this.btnRunQuery.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnRunQuery.Size = new System.Drawing.Size(110, 36);
            this.btnRunQuery.TabIndex = 0;
            this.btnRunQuery.Text = "Run";
            this.btnRunQuery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRunQuery.UseVisualStyleBackColor = false;
            this.btnRunQuery.Click += new System.EventHandler(this.btnRunQuery_Click);
            // 
            // pnlEditorHeader
            // 
            this.pnlEditorHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.pnlEditorHeader.Controls.Add(this.btnClearEditor);
            this.pnlEditorHeader.Controls.Add(this.lblEditorTitle);
            this.pnlEditorHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEditorHeader.Location = new System.Drawing.Point(0, 130);
            this.pnlEditorHeader.Name = "pnlEditorHeader";
            this.pnlEditorHeader.Padding = new System.Windows.Forms.Padding(12, 0, 8, 0);
            this.pnlEditorHeader.Size = new System.Drawing.Size(671, 36);
            this.pnlEditorHeader.TabIndex = 1;
            // 
            // btnClearEditor
            // 
            this.btnClearEditor.BackColor = System.Drawing.Color.Transparent;
            this.btnClearEditor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearEditor.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClearEditor.FlatAppearance.BorderSize = 0;
            this.btnClearEditor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btnClearEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearEditor.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnClearEditor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.btnClearEditor.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnClearEditor.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.btnClearEditor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClearEditor.IconSize = 14;
            this.btnClearEditor.Location = new System.Drawing.Point(583, 0);
            this.btnClearEditor.Name = "btnClearEditor";
            this.btnClearEditor.Size = new System.Drawing.Size(80, 36);
            this.btnClearEditor.TabIndex = 1;
            this.btnClearEditor.Text = "Clear";
            this.btnClearEditor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClearEditor.UseVisualStyleBackColor = false;
            this.btnClearEditor.Click += new System.EventHandler(this.btnClearEditor_Click);
            // 
            // lblEditorTitle
            // 
            this.lblEditorTitle.AutoSize = true;
            this.lblEditorTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblEditorTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblEditorTitle.Location = new System.Drawing.Point(12, 9);
            this.lblEditorTitle.Name = "lblEditorTitle";
            this.lblEditorTitle.Size = new System.Drawing.Size(81, 17);
            this.lblEditorTitle.TabIndex = 0;
            this.lblEditorTitle.Text = "  SQL Editor";
            this.lblEditorTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlProblemDesc
            // 
            this.pnlProblemDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(56)))));
            this.pnlProblemDesc.Controls.Add(this.lblDifficultyBadge);
            this.pnlProblemDesc.Controls.Add(this.lblProblemName);
            this.pnlProblemDesc.Controls.Add(this.rtbProblemDesc);
            this.pnlProblemDesc.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProblemDesc.Location = new System.Drawing.Point(0, 0);
            this.pnlProblemDesc.Name = "pnlProblemDesc";
            this.pnlProblemDesc.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.pnlProblemDesc.Size = new System.Drawing.Size(671, 130);
            this.pnlProblemDesc.TabIndex = 0;
            // 
            // lblDifficultyBadge
            // 
            this.lblDifficultyBadge.AutoSize = true;
            this.lblDifficultyBadge.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblDifficultyBadge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(207)))), ((int)(((byte)(142)))));
            this.lblDifficultyBadge.Location = new System.Drawing.Point(12, 34);
            this.lblDifficultyBadge.Name = "lblDifficultyBadge";
            this.lblDifficultyBadge.Size = new System.Drawing.Size(0, 15);
            this.lblDifficultyBadge.TabIndex = 1;
            // 
            // lblProblemName
            // 
            this.lblProblemName.AutoSize = true;
            this.lblProblemName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblProblemName.ForeColor = System.Drawing.Color.White;
            this.lblProblemName.Location = new System.Drawing.Point(12, 10);
            this.lblProblemName.Name = "lblProblemName";
            this.lblProblemName.Size = new System.Drawing.Size(206, 21);
            this.lblProblemName.TabIndex = 0;
            this.lblProblemName.Text = "Select a problem to begin";
            // 
            // rtbProblemDesc
            // 
            this.rtbProblemDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(56)))));
            this.rtbProblemDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbProblemDesc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.rtbProblemDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(201)))), ((int)(((byte)(224)))));
            this.rtbProblemDesc.Location = new System.Drawing.Point(12, 54);
            this.rtbProblemDesc.Name = "rtbProblemDesc";
            this.rtbProblemDesc.ReadOnly = true;
            this.rtbProblemDesc.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbProblemDesc.Size = new System.Drawing.Size(674, 68);
            this.rtbProblemDesc.TabIndex = 2;
            this.rtbProblemDesc.Text = "";
            // 
            // pnlOutputArea
            // 
            this.pnlOutputArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.pnlOutputArea.Controls.Add(this.dgvOutput);
            this.pnlOutputArea.Controls.Add(this.pnlOutputHeader);
            this.pnlOutputArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOutputArea.Location = new System.Drawing.Point(0, 0);
            this.pnlOutputArea.Name = "pnlOutputArea";
            this.pnlOutputArea.Size = new System.Drawing.Size(671, 172);
            this.pnlOutputArea.TabIndex = 0;
            // 
            // dgvOutput
            // 
            this.dgvOutput.AllowUserToAddRows = false;
            this.dgvOutput.AllowUserToDeleteRows = false;
            this.dgvOutput.AllowUserToResizeRows = false;
            this.dgvOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOutput.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.dgvOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOutput.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.dgvOutput.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvOutput.ColumnHeadersHeight = 36;
            this.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOutput.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOutput.EnableHeadersVisualStyles = false;
            this.dgvOutput.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.dgvOutput.Location = new System.Drawing.Point(0, 36);
            this.dgvOutput.MultiSelect = false;
            this.dgvOutput.Name = "dgvOutput";
            this.dgvOutput.ReadOnly = true;
            this.dgvOutput.RowHeadersVisible = false;
            this.dgvOutput.RowTemplate.Height = 30;
            this.dgvOutput.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOutput.Size = new System.Drawing.Size(671, 136);
            this.dgvOutput.TabIndex = 1;
            // 
            // pnlOutputHeader
            // 
            this.pnlOutputHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.pnlOutputHeader.Controls.Add(this.lblResultBadge);
            this.pnlOutputHeader.Controls.Add(this.btnClearOutput);
            this.pnlOutputHeader.Controls.Add(this.lblOutputTitle);
            this.pnlOutputHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOutputHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlOutputHeader.Name = "pnlOutputHeader";
            this.pnlOutputHeader.Padding = new System.Windows.Forms.Padding(12, 0, 8, 0);
            this.pnlOutputHeader.Size = new System.Drawing.Size(671, 36);
            this.pnlOutputHeader.TabIndex = 0;
            // 
            // lblResultBadge
            // 
            this.lblResultBadge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResultBadge.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblResultBadge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(207)))), ((int)(((byte)(142)))));
            this.lblResultBadge.Location = new System.Drawing.Point(122, 0);
            this.lblResultBadge.Name = "lblResultBadge";
            this.lblResultBadge.Size = new System.Drawing.Size(461, 36);
            this.lblResultBadge.TabIndex = 1;
            this.lblResultBadge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClearOutput
            // 
            this.btnClearOutput.BackColor = System.Drawing.Color.Transparent;
            this.btnClearOutput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearOutput.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClearOutput.FlatAppearance.BorderSize = 0;
            this.btnClearOutput.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btnClearOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearOutput.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnClearOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.btnClearOutput.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnClearOutput.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.btnClearOutput.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClearOutput.IconSize = 14;
            this.btnClearOutput.Location = new System.Drawing.Point(583, 0);
            this.btnClearOutput.Name = "btnClearOutput";
            this.btnClearOutput.Size = new System.Drawing.Size(80, 36);
            this.btnClearOutput.TabIndex = 2;
            this.btnClearOutput.Text = "Clear";
            this.btnClearOutput.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClearOutput.UseVisualStyleBackColor = false;
            this.btnClearOutput.Click += new System.EventHandler(this.btnClearOutput_Click);
            // 
            // lblOutputTitle
            // 
            this.lblOutputTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblOutputTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblOutputTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblOutputTitle.Location = new System.Drawing.Point(12, 0);
            this.lblOutputTitle.Name = "lblOutputTitle";
            this.lblOutputTitle.Size = new System.Drawing.Size(110, 36);
            this.lblOutputTitle.TabIndex = 0;
            this.lblOutputTitle.Text = "  Output";
            this.lblOutputTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.lblOnlineStatus.Location = new System.Drawing.Point(900, 21);
            this.lblOnlineStatus.Name = "lblOnlineStatus";
            this.lblOnlineStatus.Size = new System.Drawing.Size(52, 15);
            this.lblOnlineStatus.TabIndex = 1;
            this.lblOnlineStatus.Text = "● Online";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.pnlHeader.Controls.Add(this.lblOnlineStatus);
            this.pnlHeader.Controls.Add(this.lblWelcome);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(220, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(964, 56);
            this.pnlHeader.TabIndex = 1;
            // 
            // tvSchema
            // 
            this.tvSchema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.tvSchema.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvSchema.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tvSchema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.tvSchema.Location = new System.Drawing.Point(0, 364);
            this.tvSchema.Name = "tvSchema";
            this.tvSchema.Size = new System.Drawing.Size(267, 241);
            this.tvSchema.TabIndex = 2;
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblDifficulty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.lblDifficulty.Location = new System.Drawing.Point(3, 341);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(72, 15);
            this.lblDifficulty.TabIndex = 3;
            this.lblDifficulty.Text = "▸  SCHEMA";
            // 
            // StudentDashboardUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.pnlSolveProblem);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlHome);
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
            this.pnlSolveProblem.ResumeLayout(false);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.pnlProblemList.ResumeLayout(false);
            this.pnlProblemList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProblems)).EndInit();
            this.pnlListHeader.ResumeLayout(false);
            this.pnlListHeader.PerformLayout();
            this.splitRight.Panel1.ResumeLayout(false);
            this.splitRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitRight)).EndInit();
            this.splitRight.ResumeLayout(false);
            this.pnlEditorArea.ResumeLayout(false);
            this.pnlEditorActions.ResumeLayout(false);
            this.pnlEditorHeader.ResumeLayout(false);
            this.pnlEditorHeader.PerformLayout();
            this.pnlProblemDesc.ResumeLayout(false);
            this.pnlProblemDesc.PerformLayout();
            this.pnlOutputArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).EndInit();
            this.pnlOutputHeader.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnlContentArea;
        private System.Windows.Forms.DataGridView dgvLeaderboard;
        private System.Windows.Forms.Label lblGridTitle;
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
        private System.Windows.Forms.Panel pnlSolveProblem;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.Panel pnlProblemList;
        private System.Windows.Forms.DataGridView dgvProblems;
        private System.Windows.Forms.Panel pnlListHeader;
        private System.Windows.Forms.ComboBox cmbDifficulty;
        private System.Windows.Forms.Label lblProblemsTitle;
        private System.Windows.Forms.SplitContainer splitRight;
        private System.Windows.Forms.Panel pnlEditorArea;
        private System.Windows.Forms.RichTextBox rtbSQLEditor;
        private System.Windows.Forms.Panel pnlEditorActions;
        private System.Windows.Forms.Label lblLineCol;
        private FontAwesome.Sharp.IconButton btnSubmit;
        private FontAwesome.Sharp.IconButton btnRunQuery;
        private System.Windows.Forms.Panel pnlEditorHeader;
        private FontAwesome.Sharp.IconButton btnClearEditor;
        private System.Windows.Forms.Label lblEditorTitle;
        private System.Windows.Forms.Panel pnlProblemDesc;
        private System.Windows.Forms.Label lblDifficultyBadge;
        private System.Windows.Forms.Label lblProblemName;
        private System.Windows.Forms.RichTextBox rtbProblemDesc;
        private System.Windows.Forms.Panel pnlOutputArea;
        private System.Windows.Forms.DataGridView dgvOutput;
        private System.Windows.Forms.Panel pnlOutputHeader;
        private System.Windows.Forms.Label lblResultBadge;
        private FontAwesome.Sharp.IconButton btnClearOutput;
        private System.Windows.Forms.Label lblOutputTitle;
        private Label lblWelcome;
        private Label lblOnlineStatus;
        private Panel pnlHeader;
        private TreeView tvSchema;
        private Label lblDifficulty;
    }
}