namespace SQL_Judge_System.UI
{
    partial class AdminDashboard
    {
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btn_users;
        private System.Windows.Forms.Button btn_students;
        private System.Windows.Forms.Button btnLogout;

        private void InitializeComponent()
        {
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btn_contests = new System.Windows.Forms.Button();
            this.btn_problems = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btn_students = new System.Windows.Forms.Button();
            this.btn_users = new System.Windows.Forms.Button();
            this.dgvLeaderboard = new System.Windows.Forms.DataGridView();
            this.pnlStatsContainer = new System.Windows.Forms.Panel();
            this.pnlSkillLevel = new System.Windows.Forms.Panel();
            this.lbladminValue = new System.Windows.Forms.Label();
            this.lblTotalAdmins = new System.Windows.Forms.Label();
            this.pnlSolvedCard = new System.Windows.Forms.Panel();
            this.lblProblemValue = new System.Windows.Forms.Label();
            this.lblTotalProblems = new System.Windows.Forms.Label();
            this.pnlScoreCard = new System.Windows.Forms.Panel();
            this.lblContestValue = new System.Windows.Forms.Label();
            this.lblTotalContests = new System.Windows.Forms.Label();
            this.pnlRankCard = new System.Windows.Forms.Panel();
            this.lblStdValue = new System.Windows.Forms.Label();
            this.lblTotalStd = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblGridTitle = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaderboard)).BeginInit();
            this.pnlStatsContainer.SuspendLayout();
            this.pnlSkillLevel.SuspendLayout();
            this.pnlSolvedCard.SuspendLayout();
            this.pnlScoreCard.SuspendLayout();
            this.pnlRankCard.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlSidebar.Controls.Add(this.btnSettings);
            this.pnlSidebar.Controls.Add(this.btn_contests);
            this.pnlSidebar.Controls.Add(this.btn_problems);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.btn_students);
            this.pnlSidebar.Controls.Add(this.btn_users);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(200, 561);
            this.pnlSidebar.TabIndex = 1;
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(0, 461);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(200, 50);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "Settings";
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btn_contests
            // 
            this.btn_contests.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_contests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_contests.ForeColor = System.Drawing.Color.White;
            this.btn_contests.Location = new System.Drawing.Point(0, 150);
            this.btn_contests.Name = "btn_contests";
            this.btn_contests.Size = new System.Drawing.Size(200, 50);
            this.btn_contests.TabIndex = 4;
            this.btn_contests.Text = "Manage Contests";
            this.btn_contests.Click += new System.EventHandler(this.btn_contests_Click);
            // 
            // btn_problems
            // 
            this.btn_problems.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_problems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_problems.ForeColor = System.Drawing.Color.White;
            this.btn_problems.Location = new System.Drawing.Point(0, 100);
            this.btn_problems.Name = "btn_problems";
            this.btn_problems.Size = new System.Drawing.Size(200, 50);
            this.btn_problems.TabIndex = 3;
            this.btn_problems.Text = "Manage Problems";
            this.btn_problems.Click += new System.EventHandler(this.btn_problems_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 511);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 50);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // btn_students
            // 
            this.btn_students.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_students.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_students.ForeColor = System.Drawing.Color.White;
            this.btn_students.Location = new System.Drawing.Point(0, 50);
            this.btn_students.Name = "btn_students";
            this.btn_students.Size = new System.Drawing.Size(200, 50);
            this.btn_students.TabIndex = 1;
            this.btn_students.Text = "Manage Students";
            this.btn_students.Click += new System.EventHandler(this.btn_students_Click);
            // 
            // btn_users
            // 
            this.btn_users.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_users.ForeColor = System.Drawing.Color.White;
            this.btn_users.Location = new System.Drawing.Point(0, 0);
            this.btn_users.Name = "btn_users";
            this.btn_users.Size = new System.Drawing.Size(200, 50);
            this.btn_users.TabIndex = 2;
            this.btn_users.Text = "Manage Users";
            this.btn_users.Click += new System.EventHandler(this.btn_users_Click);
            // 
            // dgvLeaderboard
            // 
            this.dgvLeaderboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLeaderboard.BackgroundColor = System.Drawing.Color.White;
            this.dgvLeaderboard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLeaderboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeaderboard.Location = new System.Drawing.Point(224, 317);
            this.dgvLeaderboard.Name = "dgvLeaderboard";
            this.dgvLeaderboard.Size = new System.Drawing.Size(754, 211);
            this.dgvLeaderboard.TabIndex = 3;
            // 
            // pnlStatsContainer
            // 
            this.pnlStatsContainer.BackColor = System.Drawing.Color.White;
            this.pnlStatsContainer.Controls.Add(this.pnlSkillLevel);
            this.pnlStatsContainer.Controls.Add(this.pnlSolvedCard);
            this.pnlStatsContainer.Controls.Add(this.pnlScoreCard);
            this.pnlStatsContainer.Controls.Add(this.pnlRankCard);
            this.pnlStatsContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStatsContainer.Location = new System.Drawing.Point(200, 50);
            this.pnlStatsContainer.Name = "pnlStatsContainer";
            this.pnlStatsContainer.Size = new System.Drawing.Size(804, 180);
            this.pnlStatsContainer.TabIndex = 4;
            // 
            // pnlSkillLevel
            // 
            this.pnlSkillLevel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSkillLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSkillLevel.Controls.Add(this.lbladminValue);
            this.pnlSkillLevel.Controls.Add(this.lblTotalAdmins);
            this.pnlSkillLevel.Location = new System.Drawing.Point(38, 26);
            this.pnlSkillLevel.Name = "pnlSkillLevel";
            this.pnlSkillLevel.Size = new System.Drawing.Size(150, 130);
            this.pnlSkillLevel.TabIndex = 4;
            // 
            // lbladminValue
            // 
            this.lbladminValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbladminValue.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladminValue.Location = new System.Drawing.Point(0, 30);
            this.lbladminValue.Name = "lbladminValue";
            this.lbladminValue.Size = new System.Drawing.Size(148, 98);
            this.lbladminValue.TabIndex = 0;
            this.lbladminValue.Text = "5";
            this.lbladminValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalAdmins
            // 
            this.lblTotalAdmins.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalAdmins.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalAdmins.Location = new System.Drawing.Point(0, 0);
            this.lblTotalAdmins.Name = "lblTotalAdmins";
            this.lblTotalAdmins.Size = new System.Drawing.Size(148, 30);
            this.lblTotalAdmins.TabIndex = 1;
            this.lblTotalAdmins.Text = "Total Admins";
            this.lblTotalAdmins.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlSolvedCard
            // 
            this.pnlSolvedCard.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSolvedCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSolvedCard.Controls.Add(this.lblProblemValue);
            this.pnlSolvedCard.Controls.Add(this.lblTotalProblems);
            this.pnlSolvedCard.Location = new System.Drawing.Point(424, 25);
            this.pnlSolvedCard.Name = "pnlSolvedCard";
            this.pnlSolvedCard.Size = new System.Drawing.Size(150, 130);
            this.pnlSolvedCard.TabIndex = 0;
            // 
            // lblProblemValue
            // 
            this.lblProblemValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProblemValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblProblemValue.Location = new System.Drawing.Point(0, 30);
            this.lblProblemValue.Name = "lblProblemValue";
            this.lblProblemValue.Size = new System.Drawing.Size(148, 98);
            this.lblProblemValue.TabIndex = 0;
            this.lblProblemValue.Text = "215";
            this.lblProblemValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalProblems
            // 
            this.lblTotalProblems.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalProblems.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalProblems.Location = new System.Drawing.Point(0, 0);
            this.lblTotalProblems.Name = "lblTotalProblems";
            this.lblTotalProblems.Size = new System.Drawing.Size(148, 30);
            this.lblTotalProblems.TabIndex = 1;
            this.lblTotalProblems.Text = "Total Problems";
            this.lblTotalProblems.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlScoreCard
            // 
            this.pnlScoreCard.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlScoreCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlScoreCard.Controls.Add(this.lblContestValue);
            this.pnlScoreCard.Controls.Add(this.lblTotalContests);
            this.pnlScoreCard.Location = new System.Drawing.Point(617, 27);
            this.pnlScoreCard.Name = "pnlScoreCard";
            this.pnlScoreCard.Size = new System.Drawing.Size(150, 130);
            this.pnlScoreCard.TabIndex = 1;
            // 
            // lblContestValue
            // 
            this.lblContestValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblContestValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblContestValue.Location = new System.Drawing.Point(0, 30);
            this.lblContestValue.Name = "lblContestValue";
            this.lblContestValue.Size = new System.Drawing.Size(148, 98);
            this.lblContestValue.TabIndex = 0;
            this.lblContestValue.Text = "1,250";
            this.lblContestValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalContests
            // 
            this.lblTotalContests.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalContests.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalContests.Location = new System.Drawing.Point(0, 0);
            this.lblTotalContests.Name = "lblTotalContests";
            this.lblTotalContests.Size = new System.Drawing.Size(148, 30);
            this.lblTotalContests.TabIndex = 1;
            this.lblTotalContests.Text = "Total Contests";
            this.lblTotalContests.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlRankCard
            // 
            this.pnlRankCard.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlRankCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRankCard.Controls.Add(this.lblStdValue);
            this.pnlRankCard.Controls.Add(this.lblTotalStd);
            this.pnlRankCard.Location = new System.Drawing.Point(231, 23);
            this.pnlRankCard.Name = "pnlRankCard";
            this.pnlRankCard.Size = new System.Drawing.Size(150, 130);
            this.pnlRankCard.TabIndex = 2;
            // 
            // lblStdValue
            // 
            this.lblStdValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStdValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblStdValue.Location = new System.Drawing.Point(0, 30);
            this.lblStdValue.Name = "lblStdValue";
            this.lblStdValue.Size = new System.Drawing.Size(148, 98);
            this.lblStdValue.TabIndex = 0;
            this.lblStdValue.Text = "3";
            this.lblStdValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalStd
            // 
            this.lblTotalStd.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalStd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalStd.Location = new System.Drawing.Point(0, 0);
            this.lblTotalStd.Name = "lblTotalStd";
            this.lblTotalStd.Size = new System.Drawing.Size(148, 30);
            this.lblTotalStd.TabIndex = 1;
            this.lblTotalStd.Text = "Total Students";
            this.lblTotalStd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(314, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(177, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Admin Dashboard";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(200, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(804, 50);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblGridTitle
            // 
            this.lblGridTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblGridTitle.Location = new System.Drawing.Point(219, 267);
            this.lblGridTitle.Name = "lblGridTitle";
            this.lblGridTitle.Size = new System.Drawing.Size(300, 30);
            this.lblGridTitle.TabIndex = 5;
            this.lblGridTitle.Text = "Global Leaderboard";
            // 
            // AdminDashboard
            // 
            this.ClientSize = new System.Drawing.Size(1004, 561);
            this.Controls.Add(this.lblGridTitle);
            this.Controls.Add(this.pnlStatsContainer);
            this.Controls.Add(this.dgvLeaderboard);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaderboard)).EndInit();
            this.pnlStatsContainer.ResumeLayout(false);
            this.pnlSkillLevel.ResumeLayout(false);
            this.pnlSolvedCard.ResumeLayout(false);
            this.pnlScoreCard.ResumeLayout(false);
            this.pnlRankCard.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btn_contests;
        private System.Windows.Forms.Button btn_problems;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.DataGridView dgvLeaderboard;
        private System.Windows.Forms.Panel pnlStatsContainer;
        private System.Windows.Forms.Panel pnlSkillLevel;
        private System.Windows.Forms.Label lbladminValue;
        private System.Windows.Forms.Label lblTotalAdmins;
        private System.Windows.Forms.Panel pnlSolvedCard;
        private System.Windows.Forms.Label lblProblemValue;
        private System.Windows.Forms.Label lblTotalProblems;
        private System.Windows.Forms.Panel pnlScoreCard;
        private System.Windows.Forms.Label lblContestValue;
        private System.Windows.Forms.Label lblTotalContests;
        private System.Windows.Forms.Panel pnlRankCard;
        private System.Windows.Forms.Label lblStdValue;
        private System.Windows.Forms.Label lblTotalStd;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblGridTitle;
    }
}