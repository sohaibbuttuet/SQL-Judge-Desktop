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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_contest = new System.Windows.Forms.Button();
            this.btn_problems = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlStatsContainer = new System.Windows.Forms.Panel();
            this.tlpnlStudentDashboard = new System.Windows.Forms.TableLayoutPanel();
            this.pnlRankCard = new System.Windows.Forms.Panel();
            this.lblRankValue = new System.Windows.Forms.Label();
            this.lblRankTitle = new System.Windows.Forms.Label();
            this.pnlScoreCard = new System.Windows.Forms.Panel();
            this.lblScoreValue = new System.Windows.Forms.Label();
            this.lblScoreTitle = new System.Windows.Forms.Label();
            this.pnlSolvedCard = new System.Windows.Forms.Panel();
            this.lblSolvedValue = new System.Windows.Forms.Label();
            this.lblSolvedTitle = new System.Windows.Forms.Label();
            this.pnlSkillLevel = new System.Windows.Forms.Panel();
            this.lblSkillValue = new System.Windows.Forms.Label();
            this.lblSkillLevel = new System.Windows.Forms.Label();
            this.dgvLeaderboard = new System.Windows.Forms.DataGridView();
            this.lblGridTitle = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.pnlSidebar.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlStatsContainer.SuspendLayout();
            this.tlpnlStudentDashboard.SuspendLayout();
            this.pnlRankCard.SuspendLayout();
            this.pnlScoreCard.SuspendLayout();
            this.pnlSolvedCard.SuspendLayout();
            this.pnlSkillLevel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaderboard)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlSidebar.Controls.Add(this.btn_settings);
            this.pnlSidebar.Controls.Add(this.btnReport);
            this.pnlSidebar.Controls.Add(this.btn_Logout);
            this.pnlSidebar.Controls.Add(this.btn_contest);
            this.pnlSidebar.Controls.Add(this.btn_problems);
            this.pnlSidebar.Controls.Add(this.btn_home);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(200, 561);
            this.pnlSidebar.TabIndex = 4;
            // 
            // btn_Logout
            // 
            this.btn_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.White;
            this.btn_Logout.Location = new System.Drawing.Point(0, 511);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(200, 50);
            this.btn_Logout.TabIndex = 0;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_contest
            // 
            this.btn_contest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_contest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_contest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_contest.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_contest.ForeColor = System.Drawing.Color.White;
            this.btn_contest.Location = new System.Drawing.Point(0, 100);
            this.btn_contest.Name = "btn_contest";
            this.btn_contest.Size = new System.Drawing.Size(200, 50);
            this.btn_contest.TabIndex = 2;
            this.btn_contest.Text = "  Join Contest";
            this.btn_contest.Click += new System.EventHandler(this.btn_contest_Click);
            // 
            // btn_problems
            // 
            this.btn_problems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_problems.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_problems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_problems.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_problems.ForeColor = System.Drawing.Color.White;
            this.btn_problems.Location = new System.Drawing.Point(0, 50);
            this.btn_problems.Name = "btn_problems";
            this.btn_problems.Size = new System.Drawing.Size(200, 50);
            this.btn_problems.TabIndex = 3;
            this.btn_problems.Text = "  Solve Problems";
            this.btn_problems.Click += new System.EventHandler(this.btn_problems_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.pnlHeader.Controls.Add(this.lblWelcome);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.ForeColor = System.Drawing.Color.White;
            this.pnlHeader.Location = new System.Drawing.Point(200, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(804, 60);
            this.pnlHeader.TabIndex = 3;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.Location = new System.Drawing.Point(20, 8);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(500, 45);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, Alice Smith!";
            // 
            // pnlStatsContainer
            // 
            this.pnlStatsContainer.BackColor = System.Drawing.Color.White;
            this.pnlStatsContainer.Controls.Add(this.tlpnlStudentDashboard);
            this.pnlStatsContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStatsContainer.Location = new System.Drawing.Point(200, 60);
            this.pnlStatsContainer.Name = "pnlStatsContainer";
            this.pnlStatsContainer.Size = new System.Drawing.Size(804, 180);
            this.pnlStatsContainer.TabIndex = 2;
            // 
            // tlpnlStudentDashboard
            // 
            this.tlpnlStudentDashboard.ColumnCount = 4;
            this.tlpnlStudentDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpnlStudentDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpnlStudentDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpnlStudentDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpnlStudentDashboard.Controls.Add(this.pnlRankCard, 1, 0);
            this.tlpnlStudentDashboard.Controls.Add(this.pnlScoreCard, 3, 0);
            this.tlpnlStudentDashboard.Controls.Add(this.pnlSolvedCard, 2, 0);
            this.tlpnlStudentDashboard.Controls.Add(this.pnlSkillLevel, 0, 0);
            this.tlpnlStudentDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpnlStudentDashboard.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tlpnlStudentDashboard.Location = new System.Drawing.Point(0, 0);
            this.tlpnlStudentDashboard.Name = "tlpnlStudentDashboard";
            this.tlpnlStudentDashboard.RowCount = 1;
            this.tlpnlStudentDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpnlStudentDashboard.Size = new System.Drawing.Size(804, 180);
            this.tlpnlStudentDashboard.TabIndex = 5;
            // 
            // pnlRankCard
            // 
            this.pnlRankCard.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlRankCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRankCard.Controls.Add(this.lblRankValue);
            this.pnlRankCard.Controls.Add(this.lblRankTitle);
            this.pnlRankCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRankCard.Location = new System.Drawing.Point(211, 10);
            this.pnlRankCard.Margin = new System.Windows.Forms.Padding(10);
            this.pnlRankCard.Name = "pnlRankCard";
            this.pnlRankCard.Size = new System.Drawing.Size(181, 160);
            this.pnlRankCard.TabIndex = 8;
            // 
            // lblRankValue
            // 
            this.lblRankValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRankValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblRankValue.Location = new System.Drawing.Point(0, 30);
            this.lblRankValue.Name = "lblRankValue";
            this.lblRankValue.Size = new System.Drawing.Size(179, 128);
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
            this.lblRankTitle.Size = new System.Drawing.Size(179, 30);
            this.lblRankTitle.TabIndex = 1;
            this.lblRankTitle.Text = "Rank";
            this.lblRankTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlScoreCard
            // 
            this.pnlScoreCard.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlScoreCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlScoreCard.Controls.Add(this.lblScoreValue);
            this.pnlScoreCard.Controls.Add(this.lblScoreTitle);
            this.pnlScoreCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlScoreCard.Location = new System.Drawing.Point(613, 10);
            this.pnlScoreCard.Margin = new System.Windows.Forms.Padding(10);
            this.pnlScoreCard.Name = "pnlScoreCard";
            this.pnlScoreCard.Size = new System.Drawing.Size(181, 160);
            this.pnlScoreCard.TabIndex = 7;
            // 
            // lblScoreValue
            // 
            this.lblScoreValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblScoreValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblScoreValue.Location = new System.Drawing.Point(0, 30);
            this.lblScoreValue.Name = "lblScoreValue";
            this.lblScoreValue.Size = new System.Drawing.Size(179, 128);
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
            this.lblScoreTitle.Size = new System.Drawing.Size(179, 30);
            this.lblScoreTitle.TabIndex = 1;
            this.lblScoreTitle.Text = "Total Score";
            this.lblScoreTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlSolvedCard
            // 
            this.pnlSolvedCard.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSolvedCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSolvedCard.Controls.Add(this.lblSolvedValue);
            this.pnlSolvedCard.Controls.Add(this.lblSolvedTitle);
            this.pnlSolvedCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSolvedCard.Location = new System.Drawing.Point(412, 10);
            this.pnlSolvedCard.Margin = new System.Windows.Forms.Padding(10);
            this.pnlSolvedCard.Name = "pnlSolvedCard";
            this.pnlSolvedCard.Size = new System.Drawing.Size(181, 160);
            this.pnlSolvedCard.TabIndex = 6;
            // 
            // lblSolvedValue
            // 
            this.lblSolvedValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSolvedValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblSolvedValue.Location = new System.Drawing.Point(0, 30);
            this.lblSolvedValue.Name = "lblSolvedValue";
            this.lblSolvedValue.Size = new System.Drawing.Size(179, 128);
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
            this.lblSolvedTitle.Size = new System.Drawing.Size(179, 30);
            this.lblSolvedTitle.TabIndex = 1;
            this.lblSolvedTitle.Text = "Problems Solved";
            this.lblSolvedTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlSkillLevel
            // 
            this.pnlSkillLevel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSkillLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSkillLevel.Controls.Add(this.lblSkillValue);
            this.pnlSkillLevel.Controls.Add(this.lblSkillLevel);
            this.pnlSkillLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSkillLevel.Location = new System.Drawing.Point(10, 10);
            this.pnlSkillLevel.Margin = new System.Windows.Forms.Padding(10);
            this.pnlSkillLevel.Name = "pnlSkillLevel";
            this.pnlSkillLevel.Size = new System.Drawing.Size(181, 160);
            this.pnlSkillLevel.TabIndex = 5;
            // 
            // lblSkillValue
            // 
            this.lblSkillValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSkillValue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkillValue.Location = new System.Drawing.Point(0, 30);
            this.lblSkillValue.Name = "lblSkillValue";
            this.lblSkillValue.Size = new System.Drawing.Size(179, 128);
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
            this.lblSkillLevel.Size = new System.Drawing.Size(179, 30);
            this.lblSkillLevel.TabIndex = 1;
            this.lblSkillLevel.Text = "Skill Level";
            this.lblSkillLevel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvLeaderboard
            // 
            this.dgvLeaderboard.AllowUserToAddRows = false;
            this.dgvLeaderboard.AllowUserToDeleteRows = false;
            this.dgvLeaderboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLeaderboard.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLeaderboard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvLeaderboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLeaderboard.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvLeaderboard.Location = new System.Drawing.Point(220, 291);
            this.dgvLeaderboard.Name = "dgvLeaderboard";
            this.dgvLeaderboard.RowHeadersVisible = false;
            this.dgvLeaderboard.Size = new System.Drawing.Size(754, 258);
            this.dgvLeaderboard.TabIndex = 0;
            // 
            // lblGridTitle
            // 
            this.lblGridTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGridTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGridTitle.Location = new System.Drawing.Point(220, 257);
            this.lblGridTitle.Name = "lblGridTitle";
            this.lblGridTitle.Size = new System.Drawing.Size(198, 30);
            this.lblGridTitle.TabIndex = 1;
            this.lblGridTitle.Text = "Global Leaderboard";
            // 
            // btnReport
            // 
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Location = new System.Drawing.Point(0, 150);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(200, 50);
            this.btnReport.TabIndex = 5;
            this.btnReport.Text = "Generate Report";
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_settings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settings.ForeColor = System.Drawing.Color.White;
            this.btn_settings.Location = new System.Drawing.Point(0, 461);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(200, 50);
            this.btn_settings.TabIndex = 6;
            this.btn_settings.Text = "Settings";
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_home
            // 
            this.btn_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.Location = new System.Drawing.Point(0, 0);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(200, 50);
            this.btn_home.TabIndex = 1;
            this.btn_home.Text = "Home";
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // StudentDashboardUI
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
            this.Name = "StudentDashboardUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Portal";
            this.Load += new System.EventHandler(this.StudentDashboard_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlStatsContainer.ResumeLayout(false);
            this.tlpnlStudentDashboard.ResumeLayout(false);
            this.pnlRankCard.ResumeLayout(false);
            this.pnlScoreCard.ResumeLayout(false);
            this.pnlSolvedCard.ResumeLayout(false);
            this.pnlSkillLevel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaderboard)).EndInit();
            this.ResumeLayout(false);

        }

        // Declarations
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btn_problems;
        private System.Windows.Forms.Button btn_contest;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlStatsContainer;
        private System.Windows.Forms.DataGridView dgvLeaderboard;
        private System.Windows.Forms.Label lblGridTitle;
        private System.Windows.Forms.TableLayoutPanel tlpnlStudentDashboard;
        private System.Windows.Forms.Panel pnlRankCard;
        private System.Windows.Forms.Label lblRankValue;
        private System.Windows.Forms.Label lblRankTitle;
        private System.Windows.Forms.Panel pnlScoreCard;
        private System.Windows.Forms.Label lblScoreValue;
        private System.Windows.Forms.Label lblScoreTitle;
        private System.Windows.Forms.Panel pnlSolvedCard;
        private System.Windows.Forms.Label lblSolvedValue;
        private System.Windows.Forms.Label lblSolvedTitle;
        private System.Windows.Forms.Panel pnlSkillLevel;
        private System.Windows.Forms.Label lblSkillValue;
        private System.Windows.Forms.Label lblSkillLevel;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_home;
    }
}