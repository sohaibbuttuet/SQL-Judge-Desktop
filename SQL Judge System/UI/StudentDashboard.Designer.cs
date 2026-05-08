namespace SQL_Judge_System.UI
{
    partial class StudentDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_leaderboard = new System.Windows.Forms.Button();
            this.btn_contest = new System.Windows.Forms.Button();
            this.btn_problems = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlStatsContainer = new System.Windows.Forms.Panel();
            this.pnlSkillLevel = new System.Windows.Forms.Panel();
            this.lblSkillValue = new System.Windows.Forms.Label();
            this.lblSkillLevel = new System.Windows.Forms.Label();
            this.pnlSolvedCard = new System.Windows.Forms.Panel();
            this.lblSolvedValue = new System.Windows.Forms.Label();
            this.lblSolvedTitle = new System.Windows.Forms.Label();
            this.pnlScoreCard = new System.Windows.Forms.Panel();
            this.lblScoreValue = new System.Windows.Forms.Label();
            this.lblScoreTitle = new System.Windows.Forms.Label();
            this.pnlRankCard = new System.Windows.Forms.Panel();
            this.lblRankValue = new System.Windows.Forms.Label();
            this.lblRankTitle = new System.Windows.Forms.Label();
            this.dgvLeaderboard = new System.Windows.Forms.DataGridView();
            this.lblGridTitle = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlStatsContainer.SuspendLayout();
            this.pnlSkillLevel.SuspendLayout();
            this.pnlSolvedCard.SuspendLayout();
            this.pnlScoreCard.SuspendLayout();
            this.pnlRankCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaderboard)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlSidebar.Controls.Add(this.btnSettings);
            this.pnlSidebar.Controls.Add(this.btn_Logout);
            this.pnlSidebar.Controls.Add(this.btn_leaderboard);
            this.pnlSidebar.Controls.Add(this.btn_contest);
            this.pnlSidebar.Controls.Add(this.btn_problems);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(200, 561);
            this.pnlSidebar.TabIndex = 4;
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(0, 461);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(200, 50);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Settings";
            // 
            // btn_Logout
            // 
            this.btn_Logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.ForeColor = System.Drawing.Color.White;
            this.btn_Logout.Location = new System.Drawing.Point(0, 511);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(200, 50);
            this.btn_Logout.TabIndex = 0;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_leaderboard
            // 
            this.btn_leaderboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_leaderboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_leaderboard.ForeColor = System.Drawing.Color.White;
            this.btn_leaderboard.Location = new System.Drawing.Point(0, 120);
            this.btn_leaderboard.Name = "btn_leaderboard";
            this.btn_leaderboard.Size = new System.Drawing.Size(200, 60);
            this.btn_leaderboard.TabIndex = 1;
            this.btn_leaderboard.Text = "  Leaderboard";
            this.btn_leaderboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_leaderboard.Click += new System.EventHandler(this.btn_leaderboard_Click);
            // 
            // btn_contest
            // 
            this.btn_contest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_contest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_contest.ForeColor = System.Drawing.Color.White;
            this.btn_contest.Location = new System.Drawing.Point(0, 60);
            this.btn_contest.Name = "btn_contest";
            this.btn_contest.Size = new System.Drawing.Size(200, 60);
            this.btn_contest.TabIndex = 2;
            this.btn_contest.Text = "  Join Contest";
            this.btn_contest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_contest.Click += new System.EventHandler(this.btn_contest_Click);
            // 
            // btn_problems
            // 
            this.btn_problems.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_problems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_problems.ForeColor = System.Drawing.Color.White;
            this.btn_problems.Location = new System.Drawing.Point(0, 0);
            this.btn_problems.Name = "btn_problems";
            this.btn_problems.Size = new System.Drawing.Size(200, 60);
            this.btn_problems.TabIndex = 3;
            this.btn_problems.Text = "  Solve Problems";
            this.btn_problems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_problems.Click += new System.EventHandler(this.btn_problems_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblWelcome);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(200, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(804, 80);
            this.pnlHeader.TabIndex = 3;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.Location = new System.Drawing.Point(20, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(500, 45);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, Alice Smith!";
            // 
            // pnlStatsContainer
            // 
            this.pnlStatsContainer.BackColor = System.Drawing.Color.White;
            this.pnlStatsContainer.Controls.Add(this.pnlSkillLevel);
            this.pnlStatsContainer.Controls.Add(this.pnlSolvedCard);
            this.pnlStatsContainer.Controls.Add(this.pnlScoreCard);
            this.pnlStatsContainer.Controls.Add(this.pnlRankCard);
            this.pnlStatsContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStatsContainer.Location = new System.Drawing.Point(200, 80);
            this.pnlStatsContainer.Name = "pnlStatsContainer";
            this.pnlStatsContainer.Size = new System.Drawing.Size(804, 180);
            this.pnlStatsContainer.TabIndex = 2;
            // 
            // pnlSkillLevel
            // 
            this.pnlSkillLevel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSkillLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSkillLevel.Controls.Add(this.lblSkillValue);
            this.pnlSkillLevel.Controls.Add(this.lblSkillLevel);
            this.pnlSkillLevel.Location = new System.Drawing.Point(38, 26);
            this.pnlSkillLevel.Name = "pnlSkillLevel";
            this.pnlSkillLevel.Size = new System.Drawing.Size(150, 130);
            this.pnlSkillLevel.TabIndex = 4;
            // 
            // lblSkillValue
            // 
            this.lblSkillValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSkillValue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkillValue.Location = new System.Drawing.Point(0, 30);
            this.lblSkillValue.Name = "lblSkillValue";
            this.lblSkillValue.Size = new System.Drawing.Size(148, 98);
            this.lblSkillValue.TabIndex = 0;
            this.lblSkillValue.Text = "Beginner";
            this.lblSkillValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSkillLevel
            // 
            this.lblSkillLevel.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSkillLevel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSkillLevel.Location = new System.Drawing.Point(0, 0);
            this.lblSkillLevel.Name = "lblSkillLevel";
            this.lblSkillLevel.Size = new System.Drawing.Size(148, 30);
            this.lblSkillLevel.TabIndex = 1;
            this.lblSkillLevel.Text = "Skill Level";
            this.lblSkillLevel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlSolvedCard
            // 
            this.pnlSolvedCard.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSolvedCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSolvedCard.Controls.Add(this.lblSolvedValue);
            this.pnlSolvedCard.Controls.Add(this.lblSolvedTitle);
            this.pnlSolvedCard.Location = new System.Drawing.Point(424, 25);
            this.pnlSolvedCard.Name = "pnlSolvedCard";
            this.pnlSolvedCard.Size = new System.Drawing.Size(150, 130);
            this.pnlSolvedCard.TabIndex = 0;
            // 
            // lblSolvedValue
            // 
            this.lblSolvedValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSolvedValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblSolvedValue.Location = new System.Drawing.Point(0, 30);
            this.lblSolvedValue.Name = "lblSolvedValue";
            this.lblSolvedValue.Size = new System.Drawing.Size(148, 98);
            this.lblSolvedValue.TabIndex = 0;
            this.lblSolvedValue.Text = "215";
            this.lblSolvedValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSolvedTitle
            // 
            this.lblSolvedTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSolvedTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSolvedTitle.Location = new System.Drawing.Point(0, 0);
            this.lblSolvedTitle.Name = "lblSolvedTitle";
            this.lblSolvedTitle.Size = new System.Drawing.Size(148, 30);
            this.lblSolvedTitle.TabIndex = 1;
            this.lblSolvedTitle.Text = "Problems Solved";
            this.lblSolvedTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlScoreCard
            // 
            this.pnlScoreCard.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlScoreCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlScoreCard.Controls.Add(this.lblScoreValue);
            this.pnlScoreCard.Controls.Add(this.lblScoreTitle);
            this.pnlScoreCard.Location = new System.Drawing.Point(617, 27);
            this.pnlScoreCard.Name = "pnlScoreCard";
            this.pnlScoreCard.Size = new System.Drawing.Size(150, 130);
            this.pnlScoreCard.TabIndex = 1;
            // 
            // lblScoreValue
            // 
            this.lblScoreValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblScoreValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblScoreValue.Location = new System.Drawing.Point(0, 30);
            this.lblScoreValue.Name = "lblScoreValue";
            this.lblScoreValue.Size = new System.Drawing.Size(148, 98);
            this.lblScoreValue.TabIndex = 0;
            this.lblScoreValue.Text = "1,250";
            this.lblScoreValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScoreTitle
            // 
            this.lblScoreTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblScoreTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblScoreTitle.Location = new System.Drawing.Point(0, 0);
            this.lblScoreTitle.Name = "lblScoreTitle";
            this.lblScoreTitle.Size = new System.Drawing.Size(148, 30);
            this.lblScoreTitle.TabIndex = 1;
            this.lblScoreTitle.Text = "Total Score";
            this.lblScoreTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlRankCard
            // 
            this.pnlRankCard.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlRankCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRankCard.Controls.Add(this.lblRankValue);
            this.pnlRankCard.Controls.Add(this.lblRankTitle);
            this.pnlRankCard.Location = new System.Drawing.Point(231, 23);
            this.pnlRankCard.Name = "pnlRankCard";
            this.pnlRankCard.Size = new System.Drawing.Size(150, 130);
            this.pnlRankCard.TabIndex = 2;
            // 
            // lblRankValue
            // 
            this.lblRankValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRankValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblRankValue.Location = new System.Drawing.Point(0, 30);
            this.lblRankValue.Name = "lblRankValue";
            this.lblRankValue.Size = new System.Drawing.Size(148, 98);
            this.lblRankValue.TabIndex = 0;
            this.lblRankValue.Text = "#3";
            this.lblRankValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRankTitle
            // 
            this.lblRankTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRankTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRankTitle.Location = new System.Drawing.Point(0, 0);
            this.lblRankTitle.Name = "lblRankTitle";
            this.lblRankTitle.Size = new System.Drawing.Size(148, 30);
            this.lblRankTitle.TabIndex = 1;
            this.lblRankTitle.Text = "Rank";
            this.lblRankTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvLeaderboard
            // 
            this.dgvLeaderboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLeaderboard.BackgroundColor = System.Drawing.Color.White;
            this.dgvLeaderboard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLeaderboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeaderboard.Location = new System.Drawing.Point(220, 320);
            this.dgvLeaderboard.Name = "dgvLeaderboard";
            this.dgvLeaderboard.Size = new System.Drawing.Size(754, 211);
            this.dgvLeaderboard.TabIndex = 0;
            // 
            // lblGridTitle
            // 
            this.lblGridTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblGridTitle.Location = new System.Drawing.Point(220, 280);
            this.lblGridTitle.Name = "lblGridTitle";
            this.lblGridTitle.Size = new System.Drawing.Size(300, 30);
            this.lblGridTitle.TabIndex = 1;
            this.lblGridTitle.Text = "Global Leaderboard";
            // 
            // StudentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1004, 561);
            this.Controls.Add(this.dgvLeaderboard);
            this.Controls.Add(this.lblGridTitle);
            this.Controls.Add(this.pnlStatsContainer);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.MaximizeBox = false;
            this.Name = "StudentDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Portal";
            this.Load += new System.EventHandler(this.StudentDashboard_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlStatsContainer.ResumeLayout(false);
            this.pnlSkillLevel.ResumeLayout(false);
            this.pnlSolvedCard.ResumeLayout(false);
            this.pnlScoreCard.ResumeLayout(false);
            this.pnlRankCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaderboard)).EndInit();
            this.ResumeLayout(false);

        }

        // Declarations
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btn_problems;
        private System.Windows.Forms.Button btn_contest;
        private System.Windows.Forms.Button btn_leaderboard;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlStatsContainer;
        private System.Windows.Forms.Panel pnlRankCard;
        private System.Windows.Forms.Label lblRankTitle;
        private System.Windows.Forms.Label lblRankValue;
        private System.Windows.Forms.Panel pnlScoreCard;
        private System.Windows.Forms.Label lblScoreTitle;
        private System.Windows.Forms.Label lblScoreValue;
        private System.Windows.Forms.Panel pnlSolvedCard;
        private System.Windows.Forms.Label lblSolvedTitle;
        private System.Windows.Forms.Label lblSolvedValue;
        private System.Windows.Forms.DataGridView dgvLeaderboard;
        private System.Windows.Forms.Label lblGridTitle;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel pnlSkillLevel;
        private System.Windows.Forms.Label lblSkillValue;
        private System.Windows.Forms.Label lblSkillLevel;
    }
}