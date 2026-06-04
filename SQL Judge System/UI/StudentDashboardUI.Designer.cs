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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.pnlContest = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlActionsCard = new System.Windows.Forms.Panel();
            this.btnJoinContest = new System.Windows.Forms.Button();
            this.pnlStatsCard = new System.Windows.Forms.Panel();
            this.pnlStatsBody = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblContestDuration = new System.Windows.Forms.Label();
            this.lblStatDurationCaption = new System.Windows.Forms.Label();
            this.pnlStatTotalPoints = new System.Windows.Forms.Panel();
            this.lblTotalPoints = new System.Windows.Forms.Label();
            this.lblStatPointsCaption = new System.Windows.Forms.Label();
            this.pnlStatTotalProblems = new System.Windows.Forms.Panel();
            this.lblTotalProblems = new System.Windows.Forms.Label();
            this.lblStatProblemsCaption = new System.Windows.Forms.Label();
            this.pnlStatsHeader = new System.Windows.Forms.Panel();
            this.lblStatsTitle = new System.Windows.Forms.Label();
            this.pnlProblemsCard = new System.Windows.Forms.Panel();
            this.grpProblems = new System.Windows.Forms.GroupBox();
            this.dgvContestProblems = new System.Windows.Forms.DataGridView();
            this.pnlDetailsCard = new System.Windows.Forms.Panel();
            this.pnlDetailsBody = new System.Windows.Forms.Panel();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescriptionCaption = new System.Windows.Forms.Label();
            this.pnlDetailRow5 = new System.Windows.Forms.Panel();
            this.lblDurationValue = new System.Windows.Forms.Label();
            this.lblDurationCaption = new System.Windows.Forms.Label();
            this.pnlDetailRow4 = new System.Windows.Forms.Panel();
            this.lblEndDateValue = new System.Windows.Forms.Label();
            this.lblEndDateCaption = new System.Windows.Forms.Label();
            this.pnlDetailRow3 = new System.Windows.Forms.Panel();
            this.lblStartDateValue = new System.Windows.Forms.Label();
            this.lblStartDateCaption = new System.Windows.Forms.Label();
            this.pnlDetailRow1 = new System.Windows.Forms.Panel();
            this.lblContestNameValue = new System.Windows.Forms.Label();
            this.lblContestNameCaption = new System.Windows.Forms.Label();
            this.pnlDetailsHeader = new System.Windows.Forms.Panel();
            this.lblDetailsTitle = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlContestListCard = new System.Windows.Forms.Panel();
            this.dgvContest = new System.Windows.Forms.DataGridView();
            this.pnlSearchRow = new System.Windows.Forms.Panel();
            this.btnsearchContest = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlContestListHeader = new System.Windows.Forms.Panel();
            this.lblContestListTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlHeaderAccent = new System.Windows.Forms.Panel();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblMainTitle = new System.Windows.Forms.Label();
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
            this.pnlContest.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlActionsCard.SuspendLayout();
            this.pnlStatsCard.SuspendLayout();
            this.pnlStatsBody.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlStatTotalPoints.SuspendLayout();
            this.pnlStatTotalProblems.SuspendLayout();
            this.pnlStatsHeader.SuspendLayout();
            this.pnlProblemsCard.SuspendLayout();
            this.grpProblems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContestProblems)).BeginInit();
            this.pnlDetailsCard.SuspendLayout();
            this.pnlDetailsBody.SuspendLayout();
            this.pnlDetailRow5.SuspendLayout();
            this.pnlDetailRow4.SuspendLayout();
            this.pnlDetailRow3.SuspendLayout();
            this.pnlDetailRow1.SuspendLayout();
            this.pnlDetailsHeader.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlContestListCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContest)).BeginInit();
            this.pnlSearchRow.SuspendLayout();
            this.pnlContestListHeader.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.pnlSidebar.Size = new System.Drawing.Size(202, 681);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(56)))));
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
            this.btn_contest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(56)))));
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
            this.btn_problems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(56)))));
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
            this.btn_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(56)))));
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
            this.pnlSidebarLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(56)))));
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
            this.btn_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(56)))));
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
            this.btn_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(56)))));
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
            this.pnlContentArea.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlContentArea.Location = new System.Drawing.Point(0, 225);
            this.pnlContentArea.Name = "pnlContentArea";
            this.pnlContentArea.Padding = new System.Windows.Forms.Padding(14, 10, 14, 14);
            this.pnlContentArea.Size = new System.Drawing.Size(1184, 456);
            this.pnlContentArea.TabIndex = 6;
            // 
            // dgvLeaderboard
            // 
            this.dgvLeaderboard.AllowUserToAddRows = false;
            this.dgvLeaderboard.AllowUserToDeleteRows = false;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(201)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            this.dgvLeaderboard.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvLeaderboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLeaderboard.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.dgvLeaderboard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.dgvLeaderboard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvLeaderboard.ColumnHeadersHeight = 38;
            this.dgvLeaderboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(201)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLeaderboard.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvLeaderboard.EnableHeadersVisualStyles = false;
            this.dgvLeaderboard.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.dgvLeaderboard.Location = new System.Drawing.Point(-2, 47);
            this.dgvLeaderboard.MultiSelect = false;
            this.dgvLeaderboard.Name = "dgvLeaderboard";
            this.dgvLeaderboard.ReadOnly = true;
            this.dgvLeaderboard.RowHeadersVisible = false;
            this.dgvLeaderboard.RowTemplate.Height = 36;
            this.dgvLeaderboard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLeaderboard.Size = new System.Drawing.Size(1187, 409);
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
            this.lblGridTitle.Size = new System.Drawing.Size(1156, 31);
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
            this.pnlStatsContainer.Size = new System.Drawing.Size(1184, 167);
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
            this.tlpnlStudentDashboard.Size = new System.Drawing.Size(1160, 155);
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
            this.pnlSkillLevel.Size = new System.Drawing.Size(278, 143);
            this.pnlSkillLevel.TabIndex = 0;
            // 
            // lblSkillValue
            // 
            this.lblSkillValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSkillValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblSkillValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(66)))));
            this.lblSkillValue.Location = new System.Drawing.Point(8, 30);
            this.lblSkillValue.Name = "lblSkillValue";
            this.lblSkillValue.Size = new System.Drawing.Size(262, 85);
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
            this.lblSkillBadge.Location = new System.Drawing.Point(8, 115);
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
            this.pnlRankCard.Size = new System.Drawing.Size(278, 143);
            this.pnlRankCard.TabIndex = 1;
            // 
            // lblRankValue
            // 
            this.lblRankValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRankValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblRankValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(111)))), ((int)(((byte)(255)))));
            this.lblRankValue.Location = new System.Drawing.Point(8, 30);
            this.lblRankValue.Name = "lblRankValue";
            this.lblRankValue.Size = new System.Drawing.Size(262, 85);
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
            this.lblRankBadge.Location = new System.Drawing.Point(8, 115);
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
            this.pnlSolvedCard.Size = new System.Drawing.Size(278, 143);
            this.pnlSolvedCard.TabIndex = 2;
            // 
            // lblSolvedValue
            // 
            this.lblSolvedValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSolvedValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblSolvedValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.lblSolvedValue.Location = new System.Drawing.Point(8, 30);
            this.lblSolvedValue.Name = "lblSolvedValue";
            this.lblSolvedValue.Size = new System.Drawing.Size(262, 85);
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
            this.lblSolvedBadge.Location = new System.Drawing.Point(8, 115);
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
            this.pnlScoreCard.Size = new System.Drawing.Size(278, 143);
            this.pnlScoreCard.TabIndex = 3;
            // 
            // lblScoreValue
            // 
            this.lblScoreValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblScoreValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblScoreValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(207)))), ((int)(((byte)(142)))));
            this.lblScoreValue.Location = new System.Drawing.Point(8, 30);
            this.lblScoreValue.Name = "lblScoreValue";
            this.lblScoreValue.Size = new System.Drawing.Size(262, 85);
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
            this.lblScoreBadge.Location = new System.Drawing.Point(8, 115);
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
            this.pnlSolveProblem.Location = new System.Drawing.Point(202, 56);
            this.pnlSolveProblem.Name = "pnlSolveProblem";
            this.pnlSolveProblem.Size = new System.Drawing.Size(982, 625);
            this.pnlSolveProblem.TabIndex = 13;
            // 
            // splitMain
            // 
            this.splitMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(0, 0);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.pnlProblemList);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.splitRight);
            this.splitMain.Size = new System.Drawing.Size(982, 625);
            this.splitMain.SplitterDistance = 277;
            this.splitMain.SplitterWidth = 6;
            this.splitMain.TabIndex = 0;
            // 
            // pnlProblemList
            // 
            this.pnlProblemList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.pnlProblemList.Controls.Add(this.dgvProblems);
            this.pnlProblemList.Controls.Add(this.pnlListHeader);
            this.pnlProblemList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProblemList.Location = new System.Drawing.Point(0, 0);
            this.pnlProblemList.Name = "pnlProblemList";
            this.pnlProblemList.Size = new System.Drawing.Size(277, 625);
            this.pnlProblemList.TabIndex = 0;
            // 
            // dgvProblems
            // 
            this.dgvProblems.AllowUserToAddRows = false;
            this.dgvProblems.AllowUserToDeleteRows = false;
            this.dgvProblems.AllowUserToResizeRows = false;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(201)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProblems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvProblems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProblems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.dgvProblems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProblems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.dgvProblems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvProblems.ColumnHeadersHeight = 36;
            this.dgvProblems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProblems.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgvProblems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProblems.EnableHeadersVisualStyles = false;
            this.dgvProblems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.dgvProblems.Location = new System.Drawing.Point(0, 64);
            this.dgvProblems.MultiSelect = false;
            this.dgvProblems.Name = "dgvProblems";
            this.dgvProblems.ReadOnly = true;
            this.dgvProblems.RowHeadersVisible = false;
            this.dgvProblems.RowTemplate.Height = 34;
            this.dgvProblems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProblems.Size = new System.Drawing.Size(277, 561);
            this.dgvProblems.TabIndex = 1;
            this.dgvProblems.SelectionChanged += new System.EventHandler(this.dgvProblems_SelectionChanged);
            // 
            // pnlListHeader
            // 
            this.pnlListHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.pnlListHeader.Controls.Add(this.cmbDifficulty);
            this.pnlListHeader.Controls.Add(this.lblProblemsTitle);
            this.pnlListHeader.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlListHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlListHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlListHeader.Name = "pnlListHeader";
            this.pnlListHeader.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.pnlListHeader.Size = new System.Drawing.Size(277, 64);
            this.pnlListHeader.TabIndex = 0;
            // 
            // cmbDifficulty
            // 
            this.cmbDifficulty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.cmbDifficulty.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmbDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDifficulty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDifficulty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbDifficulty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(201)))), ((int)(((byte)(224)))));
            this.cmbDifficulty.Items.AddRange(new object[] {
            "All",
            "Easy",
            "Medium",
            "Hard"});
            this.cmbDifficulty.Location = new System.Drawing.Point(10, 33);
            this.cmbDifficulty.Name = "cmbDifficulty";
            this.cmbDifficulty.Size = new System.Drawing.Size(257, 23);
            this.cmbDifficulty.TabIndex = 1;
            this.cmbDifficulty.SelectedIndexChanged += new System.EventHandler(this.cmbDifficulty_SelectedIndexChanged);
            // 
            // lblProblemsTitle
            // 
            this.lblProblemsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProblemsTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblProblemsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblProblemsTitle.Location = new System.Drawing.Point(10, 8);
            this.lblProblemsTitle.Name = "lblProblemsTitle";
            this.lblProblemsTitle.Size = new System.Drawing.Size(257, 20);
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
            this.splitRight.Size = new System.Drawing.Size(699, 625);
            this.splitRight.SplitterDistance = 440;
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
            this.pnlEditorArea.Size = new System.Drawing.Size(699, 440);
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
            this.rtbSQLEditor.Size = new System.Drawing.Size(699, 226);
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
            this.pnlEditorActions.Location = new System.Drawing.Point(0, 392);
            this.pnlEditorActions.Name = "pnlEditorActions";
            this.pnlEditorActions.Padding = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.pnlEditorActions.Size = new System.Drawing.Size(699, 48);
            this.pnlEditorActions.TabIndex = 3;
            // 
            // lblLineCol
            // 
            this.lblLineCol.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLineCol.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.lblLineCol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(106)))), ((int)(((byte)(140)))));
            this.lblLineCol.Location = new System.Drawing.Point(569, 6);
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
            this.pnlEditorHeader.Size = new System.Drawing.Size(699, 36);
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
            this.btnClearEditor.Location = new System.Drawing.Point(611, 0);
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
            this.pnlProblemDesc.Size = new System.Drawing.Size(699, 130);
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
            this.pnlOutputArea.Size = new System.Drawing.Size(699, 179);
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
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.dgvOutput.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvOutput.ColumnHeadersHeight = 36;
            this.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOutput.DefaultCellStyle = dataGridViewCellStyle22;
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
            this.dgvOutput.Size = new System.Drawing.Size(699, 143);
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
            this.pnlOutputHeader.Size = new System.Drawing.Size(699, 36);
            this.pnlOutputHeader.TabIndex = 0;
            // 
            // lblResultBadge
            // 
            this.lblResultBadge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResultBadge.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblResultBadge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(207)))), ((int)(((byte)(142)))));
            this.lblResultBadge.Location = new System.Drawing.Point(122, 0);
            this.lblResultBadge.Name = "lblResultBadge";
            this.lblResultBadge.Size = new System.Drawing.Size(489, 36);
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
            this.btnClearOutput.Location = new System.Drawing.Point(611, 0);
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
            this.lblOnlineStatus.Location = new System.Drawing.Point(918, 21);
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
            this.pnlHeader.Location = new System.Drawing.Point(202, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(982, 56);
            this.pnlHeader.TabIndex = 1;
            // 
            // pnlContest
            // 
            this.pnlContest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlContest.Controls.Add(this.pnlContent);
            this.pnlContest.Controls.Add(this.panel2);
            this.pnlContest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContest.Location = new System.Drawing.Point(202, 56);
            this.pnlContest.Name = "pnlContest";
            this.pnlContest.Size = new System.Drawing.Size(982, 625);
            this.pnlContest.TabIndex = 17;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlContent.Controls.Add(this.pnlRight);
            this.pnlContent.Controls.Add(this.pnlLeft);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 53);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(18, 14, 18, 10);
            this.pnlContent.Size = new System.Drawing.Size(982, 572);
            this.pnlContent.TabIndex = 1;
            // 
            // pnlRight
            // 
            this.pnlRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRight.BackColor = System.Drawing.Color.Transparent;
            this.pnlRight.Controls.Add(this.pnlActionsCard);
            this.pnlRight.Controls.Add(this.pnlStatsCard);
            this.pnlRight.Controls.Add(this.pnlProblemsCard);
            this.pnlRight.Controls.Add(this.pnlDetailsCard);
            this.pnlRight.Location = new System.Drawing.Point(296, 14);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(666, 548);
            this.pnlRight.TabIndex = 1;
            // 
            // pnlActionsCard
            // 
            this.pnlActionsCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.pnlActionsCard.Controls.Add(this.btnJoinContest);
            this.pnlActionsCard.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlActionsCard.Location = new System.Drawing.Point(0, 498);
            this.pnlActionsCard.Name = "pnlActionsCard";
            this.pnlActionsCard.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.pnlActionsCard.Size = new System.Drawing.Size(666, 50);
            this.pnlActionsCard.TabIndex = 3;
            // 
            // btnJoinContest
            // 
            this.btnJoinContest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnJoinContest.FlatAppearance.BorderSize = 0;
            this.btnJoinContest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(82)))), ((int)(((byte)(221)))));
            this.btnJoinContest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJoinContest.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnJoinContest.ForeColor = System.Drawing.Color.White;
            this.btnJoinContest.Location = new System.Drawing.Point(10, 9);
            this.btnJoinContest.Name = "btnJoinContest";
            this.btnJoinContest.Size = new System.Drawing.Size(160, 32);
            this.btnJoinContest.TabIndex = 0;
            this.btnJoinContest.Text = "▶  Join Contest";
            this.btnJoinContest.UseVisualStyleBackColor = false;
            this.btnJoinContest.Click += new System.EventHandler(this.btnJoinContest_Click);
            // 
            // pnlStatsCard
            // 
            this.pnlStatsCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.pnlStatsCard.Controls.Add(this.pnlStatsBody);
            this.pnlStatsCard.Controls.Add(this.pnlStatsHeader);
            this.pnlStatsCard.Location = new System.Drawing.Point(0, 433);
            this.pnlStatsCard.Name = "pnlStatsCard";
            this.pnlStatsCard.Size = new System.Drawing.Size(666, 56);
            this.pnlStatsCard.TabIndex = 2;
            // 
            // pnlStatsBody
            // 
            this.pnlStatsBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.pnlStatsBody.Controls.Add(this.panel1);
            this.pnlStatsBody.Controls.Add(this.pnlStatTotalPoints);
            this.pnlStatsBody.Controls.Add(this.pnlStatTotalProblems);
            this.pnlStatsBody.Location = new System.Drawing.Point(0, 28);
            this.pnlStatsBody.Name = "pnlStatsBody";
            this.pnlStatsBody.Size = new System.Drawing.Size(666, 28);
            this.pnlStatsBody.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblContestDuration);
            this.panel1.Controls.Add(this.lblStatDurationCaption);
            this.panel1.Location = new System.Drawing.Point(434, 4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.panel1.Size = new System.Drawing.Size(220, 20);
            this.panel1.TabIndex = 2;
            // 
            // lblContestDuration
            // 
            this.lblContestDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblContestDuration.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblContestDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblContestDuration.Location = new System.Drawing.Point(122, 2);
            this.lblContestDuration.Name = "lblContestDuration";
            this.lblContestDuration.Size = new System.Drawing.Size(86, 16);
            this.lblContestDuration.TabIndex = 1;
            this.lblContestDuration.Text = "—";
            // 
            // lblStatDurationCaption
            // 
            this.lblStatDurationCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblStatDurationCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lblStatDurationCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.lblStatDurationCaption.Location = new System.Drawing.Point(8, 2);
            this.lblStatDurationCaption.Name = "lblStatDurationCaption";
            this.lblStatDurationCaption.Size = new System.Drawing.Size(110, 16);
            this.lblStatDurationCaption.TabIndex = 0;
            this.lblStatDurationCaption.Text = "Contest Duration:";
            // 
            // pnlStatTotalPoints
            // 
            this.pnlStatTotalPoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.pnlStatTotalPoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStatTotalPoints.Controls.Add(this.lblTotalPoints);
            this.pnlStatTotalPoints.Controls.Add(this.lblStatPointsCaption);
            this.pnlStatTotalPoints.Location = new System.Drawing.Point(222, 4);
            this.pnlStatTotalPoints.Name = "pnlStatTotalPoints";
            this.pnlStatTotalPoints.Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.pnlStatTotalPoints.Size = new System.Drawing.Size(198, 20);
            this.pnlStatTotalPoints.TabIndex = 1;
            // 
            // lblTotalPoints
            // 
            this.lblTotalPoints.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPoints.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblTotalPoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblTotalPoints.Location = new System.Drawing.Point(100, 2);
            this.lblTotalPoints.Name = "lblTotalPoints";
            this.lblTotalPoints.Size = new System.Drawing.Size(86, 16);
            this.lblTotalPoints.TabIndex = 1;
            this.lblTotalPoints.Text = "—";
            // 
            // lblStatPointsCaption
            // 
            this.lblStatPointsCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblStatPointsCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lblStatPointsCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.lblStatPointsCaption.Location = new System.Drawing.Point(8, 2);
            this.lblStatPointsCaption.Name = "lblStatPointsCaption";
            this.lblStatPointsCaption.Size = new System.Drawing.Size(88, 16);
            this.lblStatPointsCaption.TabIndex = 0;
            this.lblStatPointsCaption.Text = "Total Points:";
            // 
            // pnlStatTotalProblems
            // 
            this.pnlStatTotalProblems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.pnlStatTotalProblems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStatTotalProblems.Controls.Add(this.lblTotalProblems);
            this.pnlStatTotalProblems.Controls.Add(this.lblStatProblemsCaption);
            this.pnlStatTotalProblems.Location = new System.Drawing.Point(10, 4);
            this.pnlStatTotalProblems.Name = "pnlStatTotalProblems";
            this.pnlStatTotalProblems.Padding = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.pnlStatTotalProblems.Size = new System.Drawing.Size(198, 20);
            this.pnlStatTotalProblems.TabIndex = 0;
            // 
            // lblTotalProblems
            // 
            this.lblTotalProblems.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalProblems.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblTotalProblems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblTotalProblems.Location = new System.Drawing.Point(108, 2);
            this.lblTotalProblems.Name = "lblTotalProblems";
            this.lblTotalProblems.Size = new System.Drawing.Size(76, 16);
            this.lblTotalProblems.TabIndex = 1;
            this.lblTotalProblems.Text = "—";
            // 
            // lblStatProblemsCaption
            // 
            this.lblStatProblemsCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblStatProblemsCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lblStatProblemsCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.lblStatProblemsCaption.Location = new System.Drawing.Point(8, 2);
            this.lblStatProblemsCaption.Name = "lblStatProblemsCaption";
            this.lblStatProblemsCaption.Size = new System.Drawing.Size(96, 16);
            this.lblStatProblemsCaption.TabIndex = 0;
            this.lblStatProblemsCaption.Text = "Total Problems:";
            // 
            // pnlStatsHeader
            // 
            this.pnlStatsHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.pnlStatsHeader.Controls.Add(this.lblStatsTitle);
            this.pnlStatsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStatsHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlStatsHeader.Name = "pnlStatsHeader";
            this.pnlStatsHeader.Padding = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.pnlStatsHeader.Size = new System.Drawing.Size(666, 28);
            this.pnlStatsHeader.TabIndex = 0;
            // 
            // lblStatsTitle
            // 
            this.lblStatsTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblStatsTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblStatsTitle.Location = new System.Drawing.Point(12, 6);
            this.lblStatsTitle.Name = "lblStatsTitle";
            this.lblStatsTitle.Size = new System.Drawing.Size(642, 16);
            this.lblStatsTitle.TabIndex = 0;
            this.lblStatsTitle.Text = "Contest Statistics";
            this.lblStatsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlProblemsCard
            // 
            this.pnlProblemsCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.pnlProblemsCard.Controls.Add(this.grpProblems);
            this.pnlProblemsCard.Location = new System.Drawing.Point(0, 226);
            this.pnlProblemsCard.Name = "pnlProblemsCard";
            this.pnlProblemsCard.Size = new System.Drawing.Size(666, 199);
            this.pnlProblemsCard.TabIndex = 1;
            // 
            // grpProblems
            // 
            this.grpProblems.Controls.Add(this.dgvContestProblems);
            this.grpProblems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpProblems.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpProblems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.grpProblems.Location = new System.Drawing.Point(0, 0);
            this.grpProblems.Name = "grpProblems";
            this.grpProblems.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.grpProblems.Size = new System.Drawing.Size(666, 199);
            this.grpProblems.TabIndex = 0;
            this.grpProblems.TabStop = false;
            this.grpProblems.Text = "Contest Problems";
            // 
            // dgvContestProblems
            // 
            this.dgvContestProblems.AllowUserToAddRows = false;
            this.dgvContestProblems.AllowUserToDeleteRows = false;
            this.dgvContestProblems.AllowUserToResizeRows = false;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.dgvContestProblems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle26;
            this.dgvContestProblems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContestProblems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.dgvContestProblems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvContestProblems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvContestProblems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContestProblems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dgvContestProblems.ColumnHeadersHeight = 30;
            this.dgvContestProblems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle28.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContestProblems.DefaultCellStyle = dataGridViewCellStyle28;
            this.dgvContestProblems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContestProblems.EnableHeadersVisualStyles = false;
            this.dgvContestProblems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.dgvContestProblems.Location = new System.Drawing.Point(10, 25);
            this.dgvContestProblems.MultiSelect = false;
            this.dgvContestProblems.Name = "dgvContestProblems";
            this.dgvContestProblems.ReadOnly = true;
            this.dgvContestProblems.RowHeadersVisible = false;
            this.dgvContestProblems.RowTemplate.Height = 26;
            this.dgvContestProblems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContestProblems.Size = new System.Drawing.Size(646, 166);
            this.dgvContestProblems.TabIndex = 0;
            // 
            // pnlDetailsCard
            // 
            this.pnlDetailsCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDetailsCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.pnlDetailsCard.Controls.Add(this.pnlDetailsBody);
            this.pnlDetailsCard.Controls.Add(this.pnlDetailsHeader);
            this.pnlDetailsCard.Location = new System.Drawing.Point(0, 0);
            this.pnlDetailsCard.Name = "pnlDetailsCard";
            this.pnlDetailsCard.Size = new System.Drawing.Size(666, 218);
            this.pnlDetailsCard.TabIndex = 0;
            // 
            // pnlDetailsBody
            // 
            this.pnlDetailsBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.pnlDetailsBody.Controls.Add(this.txtDescription);
            this.pnlDetailsBody.Controls.Add(this.lblDescriptionCaption);
            this.pnlDetailsBody.Controls.Add(this.pnlDetailRow5);
            this.pnlDetailsBody.Controls.Add(this.pnlDetailRow4);
            this.pnlDetailsBody.Controls.Add(this.pnlDetailRow3);
            this.pnlDetailsBody.Controls.Add(this.pnlDetailRow1);
            this.pnlDetailsBody.Location = new System.Drawing.Point(0, 38);
            this.pnlDetailsBody.Name = "pnlDetailsBody";
            this.pnlDetailsBody.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.pnlDetailsBody.Size = new System.Drawing.Size(666, 180);
            this.pnlDetailsBody.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.txtDescription.Location = new System.Drawing.Point(130, 111);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(524, 65);
            this.txtDescription.TabIndex = 6;
            this.txtDescription.Text = "Select a contest to view its description.";
            // 
            // lblDescriptionCaption
            // 
            this.lblDescriptionCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblDescriptionCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblDescriptionCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.lblDescriptionCaption.Location = new System.Drawing.Point(12, 114);
            this.lblDescriptionCaption.Name = "lblDescriptionCaption";
            this.lblDescriptionCaption.Size = new System.Drawing.Size(110, 16);
            this.lblDescriptionCaption.TabIndex = 5;
            this.lblDescriptionCaption.Text = "Description";
            // 
            // pnlDetailRow5
            // 
            this.pnlDetailRow5.BackColor = System.Drawing.Color.Transparent;
            this.pnlDetailRow5.Controls.Add(this.lblDurationValue);
            this.pnlDetailRow5.Controls.Add(this.lblDurationCaption);
            this.pnlDetailRow5.Location = new System.Drawing.Point(12, 86);
            this.pnlDetailRow5.Name = "pnlDetailRow5";
            this.pnlDetailRow5.Size = new System.Drawing.Size(640, 22);
            this.pnlDetailRow5.TabIndex = 4;
            // 
            // lblDurationValue
            // 
            this.lblDurationValue.BackColor = System.Drawing.Color.Transparent;
            this.lblDurationValue.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblDurationValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblDurationValue.Location = new System.Drawing.Point(118, 3);
            this.lblDurationValue.Name = "lblDurationValue";
            this.lblDurationValue.Size = new System.Drawing.Size(200, 16);
            this.lblDurationValue.TabIndex = 1;
            this.lblDurationValue.Text = "—";
            // 
            // lblDurationCaption
            // 
            this.lblDurationCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblDurationCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblDurationCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.lblDurationCaption.Location = new System.Drawing.Point(0, 3);
            this.lblDurationCaption.Name = "lblDurationCaption";
            this.lblDurationCaption.Size = new System.Drawing.Size(110, 16);
            this.lblDurationCaption.TabIndex = 0;
            this.lblDurationCaption.Text = "Duration";
            // 
            // pnlDetailRow4
            // 
            this.pnlDetailRow4.BackColor = System.Drawing.Color.Transparent;
            this.pnlDetailRow4.Controls.Add(this.lblEndDateValue);
            this.pnlDetailRow4.Controls.Add(this.lblEndDateCaption);
            this.pnlDetailRow4.Location = new System.Drawing.Point(12, 60);
            this.pnlDetailRow4.Name = "pnlDetailRow4";
            this.pnlDetailRow4.Size = new System.Drawing.Size(640, 22);
            this.pnlDetailRow4.TabIndex = 3;
            // 
            // lblEndDateValue
            // 
            this.lblEndDateValue.BackColor = System.Drawing.Color.Transparent;
            this.lblEndDateValue.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblEndDateValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblEndDateValue.Location = new System.Drawing.Point(118, 3);
            this.lblEndDateValue.Name = "lblEndDateValue";
            this.lblEndDateValue.Size = new System.Drawing.Size(300, 16);
            this.lblEndDateValue.TabIndex = 1;
            this.lblEndDateValue.Text = "—";
            // 
            // lblEndDateCaption
            // 
            this.lblEndDateCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblEndDateCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblEndDateCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.lblEndDateCaption.Location = new System.Drawing.Point(0, 3);
            this.lblEndDateCaption.Name = "lblEndDateCaption";
            this.lblEndDateCaption.Size = new System.Drawing.Size(110, 16);
            this.lblEndDateCaption.TabIndex = 0;
            this.lblEndDateCaption.Text = "End Date";
            // 
            // pnlDetailRow3
            // 
            this.pnlDetailRow3.BackColor = System.Drawing.Color.Transparent;
            this.pnlDetailRow3.Controls.Add(this.lblStartDateValue);
            this.pnlDetailRow3.Controls.Add(this.lblStartDateCaption);
            this.pnlDetailRow3.Location = new System.Drawing.Point(12, 34);
            this.pnlDetailRow3.Name = "pnlDetailRow3";
            this.pnlDetailRow3.Size = new System.Drawing.Size(640, 22);
            this.pnlDetailRow3.TabIndex = 2;
            // 
            // lblStartDateValue
            // 
            this.lblStartDateValue.BackColor = System.Drawing.Color.Transparent;
            this.lblStartDateValue.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblStartDateValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblStartDateValue.Location = new System.Drawing.Point(118, 3);
            this.lblStartDateValue.Name = "lblStartDateValue";
            this.lblStartDateValue.Size = new System.Drawing.Size(300, 16);
            this.lblStartDateValue.TabIndex = 1;
            this.lblStartDateValue.Text = "—";
            // 
            // lblStartDateCaption
            // 
            this.lblStartDateCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblStartDateCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblStartDateCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.lblStartDateCaption.Location = new System.Drawing.Point(0, 3);
            this.lblStartDateCaption.Name = "lblStartDateCaption";
            this.lblStartDateCaption.Size = new System.Drawing.Size(110, 16);
            this.lblStartDateCaption.TabIndex = 0;
            this.lblStartDateCaption.Text = "Start Date";
            // 
            // pnlDetailRow1
            // 
            this.pnlDetailRow1.BackColor = System.Drawing.Color.Transparent;
            this.pnlDetailRow1.Controls.Add(this.lblContestNameValue);
            this.pnlDetailRow1.Controls.Add(this.lblContestNameCaption);
            this.pnlDetailRow1.Location = new System.Drawing.Point(12, 8);
            this.pnlDetailRow1.Name = "pnlDetailRow1";
            this.pnlDetailRow1.Size = new System.Drawing.Size(640, 22);
            this.pnlDetailRow1.TabIndex = 0;
            // 
            // lblContestNameValue
            // 
            this.lblContestNameValue.BackColor = System.Drawing.Color.Transparent;
            this.lblContestNameValue.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblContestNameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblContestNameValue.Location = new System.Drawing.Point(118, 3);
            this.lblContestNameValue.Name = "lblContestNameValue";
            this.lblContestNameValue.Size = new System.Drawing.Size(520, 16);
            this.lblContestNameValue.TabIndex = 1;
            this.lblContestNameValue.Text = "—";
            // 
            // lblContestNameCaption
            // 
            this.lblContestNameCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblContestNameCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblContestNameCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.lblContestNameCaption.Location = new System.Drawing.Point(0, 3);
            this.lblContestNameCaption.Name = "lblContestNameCaption";
            this.lblContestNameCaption.Size = new System.Drawing.Size(110, 16);
            this.lblContestNameCaption.TabIndex = 0;
            this.lblContestNameCaption.Text = "Contest Name";
            // 
            // pnlDetailsHeader
            // 
            this.pnlDetailsHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.pnlDetailsHeader.Controls.Add(this.lblDetailsTitle);
            this.pnlDetailsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDetailsHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlDetailsHeader.Name = "pnlDetailsHeader";
            this.pnlDetailsHeader.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.pnlDetailsHeader.Size = new System.Drawing.Size(666, 38);
            this.pnlDetailsHeader.TabIndex = 0;
            // 
            // lblDetailsTitle
            // 
            this.lblDetailsTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblDetailsTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDetailsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblDetailsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblDetailsTitle.Location = new System.Drawing.Point(12, 8);
            this.lblDetailsTitle.Name = "lblDetailsTitle";
            this.lblDetailsTitle.Size = new System.Drawing.Size(642, 22);
            this.lblDetailsTitle.TabIndex = 0;
            this.lblDetailsTitle.Text = "Contest Details";
            this.lblDetailsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlLeft.BackColor = System.Drawing.Color.Transparent;
            this.pnlLeft.Controls.Add(this.pnlContestListCard);
            this.pnlLeft.Location = new System.Drawing.Point(18, 14);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(430, 548);
            this.pnlLeft.TabIndex = 0;
            // 
            // pnlContestListCard
            // 
            this.pnlContestListCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.pnlContestListCard.Controls.Add(this.dgvContest);
            this.pnlContestListCard.Controls.Add(this.pnlSearchRow);
            this.pnlContestListCard.Controls.Add(this.pnlContestListHeader);
            this.pnlContestListCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContestListCard.Location = new System.Drawing.Point(0, 0);
            this.pnlContestListCard.Name = "pnlContestListCard";
            this.pnlContestListCard.Padding = new System.Windows.Forms.Padding(1);
            this.pnlContestListCard.Size = new System.Drawing.Size(430, 548);
            this.pnlContestListCard.TabIndex = 0;
            // 
            // dgvContest
            // 
            this.dgvContest.AllowUserToAddRows = false;
            this.dgvContest.AllowUserToDeleteRows = false;
            this.dgvContest.AllowUserToResizeRows = false;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.dgvContest.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle23;
            this.dgvContest.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.dgvContest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvContest.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvContest.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvContest.ColumnHeadersHeight = 34;
            this.dgvContest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle25.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContest.DefaultCellStyle = dataGridViewCellStyle25;
            this.dgvContest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContest.EnableHeadersVisualStyles = false;
            this.dgvContest.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.dgvContest.Location = new System.Drawing.Point(1, 83);
            this.dgvContest.MultiSelect = false;
            this.dgvContest.Name = "dgvContest";
            this.dgvContest.ReadOnly = true;
            this.dgvContest.RowHeadersVisible = false;
            this.dgvContest.RowTemplate.Height = 30;
            this.dgvContest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContest.Size = new System.Drawing.Size(428, 464);
            this.dgvContest.TabIndex = 2;
            this.dgvContest.SelectionChanged += new System.EventHandler(this.dgvContest_SelectionChanged);
            // 
            // pnlSearchRow
            // 
            this.pnlSearchRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.pnlSearchRow.Controls.Add(this.btnsearchContest);
            this.pnlSearchRow.Controls.Add(this.txtSearch);
            this.pnlSearchRow.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchRow.Location = new System.Drawing.Point(1, 39);
            this.pnlSearchRow.Name = "pnlSearchRow";
            this.pnlSearchRow.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.pnlSearchRow.Size = new System.Drawing.Size(428, 44);
            this.pnlSearchRow.TabIndex = 1;
            // 
            // btnsearchContest
            // 
            this.btnsearchContest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsearchContest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnsearchContest.FlatAppearance.BorderSize = 0;
            this.btnsearchContest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearchContest.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearchContest.ForeColor = System.Drawing.Color.White;
            this.btnsearchContest.Location = new System.Drawing.Point(346, 8);
            this.btnsearchContest.Name = "btnsearchContest";
            this.btnsearchContest.Size = new System.Drawing.Size(72, 26);
            this.btnsearchContest.TabIndex = 1;
            this.btnsearchContest.Text = "⟳ Search";
            this.btnsearchContest.UseVisualStyleBackColor = false;
            this.btnsearchContest.Click += new System.EventHandler(this.btnsearchContest_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.txtSearch.Location = new System.Drawing.Point(10, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(328, 23);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "Search contests here...";
            // 
            // pnlContestListHeader
            // 
            this.pnlContestListHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.pnlContestListHeader.Controls.Add(this.lblContestListTitle);
            this.pnlContestListHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContestListHeader.Location = new System.Drawing.Point(1, 1);
            this.pnlContestListHeader.Name = "pnlContestListHeader";
            this.pnlContestListHeader.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.pnlContestListHeader.Size = new System.Drawing.Size(428, 38);
            this.pnlContestListHeader.TabIndex = 0;
            // 
            // lblContestListTitle
            // 
            this.lblContestListTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblContestListTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblContestListTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContestListTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblContestListTitle.Location = new System.Drawing.Point(12, 8);
            this.lblContestListTitle.Name = "lblContestListTitle";
            this.lblContestListTitle.Size = new System.Drawing.Size(404, 22);
            this.lblContestListTitle.TabIndex = 0;
            this.lblContestListTitle.Text = "Contest List";
            this.lblContestListTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.panel2.Controls.Add(this.pnlHeaderAccent);
            this.panel2.Controls.Add(this.lblSubtitle);
            this.panel2.Controls.Add(this.lblMainTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(28, 16, 28, 0);
            this.panel2.Size = new System.Drawing.Size(982, 53);
            this.panel2.TabIndex = 0;
            // 
            // pnlHeaderAccent
            // 
            this.pnlHeaderAccent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.pnlHeaderAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderAccent.Name = "pnlHeaderAccent";
            this.pnlHeaderAccent.Size = new System.Drawing.Size(4, 80);
            this.pnlHeaderAccent.TabIndex = 2;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblSubtitle.Location = new System.Drawing.Point(30, 29);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(500, 20);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Browse contests and start solving problems";
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblMainTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblMainTitle.Location = new System.Drawing.Point(28, 2);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(500, 32);
            this.lblMainTitle.TabIndex = 0;
            this.lblMainTitle.Text = "Available Contests";
            // 
            // StudentDashboardUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.pnlContest);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvProblems)).EndInit();
            this.pnlListHeader.ResumeLayout(false);
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
            this.pnlContest.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlActionsCard.ResumeLayout(false);
            this.pnlStatsCard.ResumeLayout(false);
            this.pnlStatsBody.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlStatTotalPoints.ResumeLayout(false);
            this.pnlStatTotalProblems.ResumeLayout(false);
            this.pnlStatsHeader.ResumeLayout(false);
            this.pnlProblemsCard.ResumeLayout(false);
            this.grpProblems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContestProblems)).EndInit();
            this.pnlDetailsCard.ResumeLayout(false);
            this.pnlDetailsBody.ResumeLayout(false);
            this.pnlDetailsBody.PerformLayout();
            this.pnlDetailRow5.ResumeLayout(false);
            this.pnlDetailRow4.ResumeLayout(false);
            this.pnlDetailRow3.ResumeLayout(false);
            this.pnlDetailRow1.ResumeLayout(false);
            this.pnlDetailsHeader.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlContestListCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContest)).EndInit();
            this.pnlSearchRow.ResumeLayout(false);
            this.pnlSearchRow.PerformLayout();
            this.pnlContestListHeader.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
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
        private Panel pnlContentArea;
        private DataGridView dgvLeaderboard;
        private Label lblGridTitle;
        private Panel pnlContest;
        private Panel pnlContent;
        private Panel pnlRight;
        private Panel pnlActionsCard;
        private Button btnJoinContest;
        private Panel pnlStatsCard;
        private Panel pnlStatsBody;
        private Panel panel1;
        private Label lblContestDuration;
        private Label lblStatDurationCaption;
        private Panel pnlStatTotalPoints;
        private Label lblTotalPoints;
        private Label lblStatPointsCaption;
        private Panel pnlStatTotalProblems;
        private Label lblTotalProblems;
        private Label lblStatProblemsCaption;
        private Panel pnlStatsHeader;
        private Label lblStatsTitle;
        private Panel pnlProblemsCard;
        private GroupBox grpProblems;
        private DataGridView dgvContestProblems;
        private Panel pnlDetailsCard;
        private Panel pnlDetailsBody;
        private TextBox txtDescription;
        private Label lblDescriptionCaption;
        private Panel pnlDetailRow5;
        private Label lblDurationValue;
        private Label lblDurationCaption;
        private Panel pnlDetailRow4;
        private Label lblEndDateValue;
        private Label lblEndDateCaption;
        private Panel pnlDetailRow3;
        private Label lblStartDateValue;
        private Label lblStartDateCaption;
        private Panel pnlDetailRow1;
        private Label lblContestNameValue;
        private Label lblContestNameCaption;
        private Panel pnlDetailsHeader;
        private Label lblDetailsTitle;
        private Panel pnlLeft;
        private Panel pnlContestListCard;
        private DataGridView dgvContest;
        private Panel pnlSearchRow;
        private Button btnsearchContest;
        private TextBox txtSearch;
        private Panel pnlContestListHeader;
        private Label lblContestListTitle;
        private Panel panel2;
        private Panel pnlHeaderAccent;
        private Label lblSubtitle;
        private Label lblMainTitle;
    }
}