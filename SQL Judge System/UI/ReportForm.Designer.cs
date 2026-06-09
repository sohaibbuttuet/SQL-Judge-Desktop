namespace SQL_Judge_System.UI
{
    partial class ReportForm
    {
        private System.ComponentModel.IContainer components = null;

        // ─── Main Layout ───────────────────────────────────────────────────────
        private System.Windows.Forms.TableLayoutPanel mainLayout;

        // ─── Sidebar ──────────────────────────────────────────────────────────
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlSidebarHeader;
        private System.Windows.Forms.Label lblSidebarIcon;
        private System.Windows.Forms.Label lblSidebarTitle;
        private System.Windows.Forms.Label lblSidebarSubtitle;
        private System.Windows.Forms.Panel pnlDivider1;

        private System.Windows.Forms.Panel pnlSidebarFooter;
        private System.Windows.Forms.Button btnExportPDF;
        private System.Windows.Forms.Button btnPrint;

        // ─── Main Content ─────────────────────────────────────────────────────
        private System.Windows.Forms.Panel pnlContent;

        // Report Header
        private System.Windows.Forms.Panel pnlReportHeader;
        private System.Windows.Forms.Panel pnlHeaderLeft;
        private System.Windows.Forms.Label lblReportTitle;
        private System.Windows.Forms.Label lblReportDescription;
        private System.Windows.Forms.Panel pnlHeaderRight;
        private System.Windows.Forms.Label lblDateRangeLabel;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Panel pnlHeaderDivider;

        // Stats Strip
        private System.Windows.Forms.Panel pnlStatsStrip;
        private System.Windows.Forms.Panel pnlStat1;
        private System.Windows.Forms.Label lblStat1Value;
        private System.Windows.Forms.Label lblStat1Label;
        private System.Windows.Forms.Panel pnlStatDiv1;
        private System.Windows.Forms.Panel pnlStat2;
        private System.Windows.Forms.Label lblStat2Value;
        private System.Windows.Forms.Label lblStat2Label;
        private System.Windows.Forms.Panel pnlStatDiv2;
        private System.Windows.Forms.Panel pnlStat3;
        private System.Windows.Forms.Label lblStat3Value;
        private System.Windows.Forms.Label lblStat3Label;
        private System.Windows.Forms.Panel pnlStatDiv3;
        private System.Windows.Forms.Panel pnlStat4;
        private System.Windows.Forms.Label lblStat4Value;
        private System.Windows.Forms.Label lblStat4Label;

        // DataGridView
        private System.Windows.Forms.DataGridView dgvReport;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlStudnet = new System.Windows.Forms.Panel();
            this.btnStudentLeaderboard = new System.Windows.Forms.Button();
            this.btnStudentTopStudents = new System.Windows.Forms.Button();
            this.btnMySubmissions = new System.Windows.Forms.Button();
            this.lblStudentSection = new System.Windows.Forms.Label();
            this.pnlAdminReports = new System.Windows.Forms.Panel();
            this.btnContestLeaderboard = new System.Windows.Forms.Button();
            this.btnTopStudentsReport = new System.Windows.Forms.Button();
            this.btnSubmissionsReport = new System.Windows.Forms.Button();
            this.lblAdminSection = new System.Windows.Forms.Label();
            this.pnlSidebarFooter = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExportPDF = new System.Windows.Forms.Button();
            this.pnlDivider1 = new System.Windows.Forms.Panel();
            this.pnlSidebarHeader = new System.Windows.Forms.Panel();
            this.lblSidebarSubtitle = new System.Windows.Forms.Label();
            this.lblSidebarTitle = new System.Windows.Forms.Label();
            this.lblSidebarIcon = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.pnlStatsStrip = new System.Windows.Forms.Panel();
            this.pnlStat4 = new System.Windows.Forms.Panel();
            this.lblStat4Label = new System.Windows.Forms.Label();
            this.lblStat4Value = new System.Windows.Forms.Label();
            this.pnlStatDiv3 = new System.Windows.Forms.Panel();
            this.pnlStat3 = new System.Windows.Forms.Panel();
            this.lblStat3Label = new System.Windows.Forms.Label();
            this.lblStat3Value = new System.Windows.Forms.Label();
            this.pnlStatDiv2 = new System.Windows.Forms.Panel();
            this.pnlStat2 = new System.Windows.Forms.Panel();
            this.lblStat2Label = new System.Windows.Forms.Label();
            this.lblStat2Value = new System.Windows.Forms.Label();
            this.pnlStatDiv1 = new System.Windows.Forms.Panel();
            this.pnlStat1 = new System.Windows.Forms.Panel();
            this.lblStat1Label = new System.Windows.Forms.Label();
            this.lblStat1Value = new System.Windows.Forms.Label();
            this.pnlHeaderDivider = new System.Windows.Forms.Panel();
            this.pnlReportHeader = new System.Windows.Forms.Panel();
            this.pnlHeaderRight = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblRows = new System.Windows.Forms.Label();
            this.cmbRows = new System.Windows.Forms.ComboBox();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblDateRangeLabel = new System.Windows.Forms.Label();
            this.pnlHeaderLeft = new System.Windows.Forms.Panel();
            this.lblReportDescription = new System.Windows.Forms.Label();
            this.lblReportTitle = new System.Windows.Forms.Label();
            this.mainLayout.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlStudnet.SuspendLayout();
            this.pnlAdminReports.SuspendLayout();
            this.pnlSidebarFooter.SuspendLayout();
            this.pnlSidebarHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.pnlStatsStrip.SuspendLayout();
            this.pnlStat4.SuspendLayout();
            this.pnlStat3.SuspendLayout();
            this.pnlStat2.SuspendLayout();
            this.pnlStat1.SuspendLayout();
            this.pnlReportHeader.SuspendLayout();
            this.pnlHeaderRight.SuspendLayout();
            this.pnlHeaderLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 2;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Controls.Add(this.pnlSidebar, 0, 0);
            this.mainLayout.Controls.Add(this.pnlContent, 1, 0);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Margin = new System.Windows.Forms.Padding(0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 1;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayout.Size = new System.Drawing.Size(1100, 562);
            this.mainLayout.TabIndex = 0;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(30)))));
            this.pnlSidebar.Controls.Add(this.pnlStudnet);
            this.pnlSidebar.Controls.Add(this.pnlAdminReports);
            this.pnlSidebar.Controls.Add(this.pnlSidebarFooter);
            this.pnlSidebar.Controls.Add(this.pnlDivider1);
            this.pnlSidebar.Controls.Add(this.pnlSidebarHeader);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSidebar.Location = new System.Drawing.Point(3, 3);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(254, 556);
            this.pnlSidebar.TabIndex = 0;
            // 
            // pnlStudnet
            // 
            this.pnlStudnet.Controls.Add(this.btnStudentLeaderboard);
            this.pnlStudnet.Controls.Add(this.btnStudentTopStudents);
            this.pnlStudnet.Controls.Add(this.btnMySubmissions);
            this.pnlStudnet.Controls.Add(this.lblStudentSection);
            this.pnlStudnet.Location = new System.Drawing.Point(0, 264);
            this.pnlStudnet.Name = "pnlStudnet";
            this.pnlStudnet.Size = new System.Drawing.Size(254, 221);
            this.pnlStudnet.TabIndex = 17;
            // 
            // btnStudentLeaderboard
            // 
            this.btnStudentLeaderboard.BackColor = System.Drawing.Color.Transparent;
            this.btnStudentLeaderboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudentLeaderboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudentLeaderboard.FlatAppearance.BorderSize = 0;
            this.btnStudentLeaderboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(85)))));
            this.btnStudentLeaderboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.btnStudentLeaderboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentLeaderboard.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnStudentLeaderboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(215)))));
            this.btnStudentLeaderboard.Location = new System.Drawing.Point(0, 122);
            this.btnStudentLeaderboard.Name = "btnStudentLeaderboard";
            this.btnStudentLeaderboard.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnStudentLeaderboard.Size = new System.Drawing.Size(254, 46);
            this.btnStudentLeaderboard.TabIndex = 14;
            this.btnStudentLeaderboard.Text = "  🥇  Contest Leaderboard";
            this.btnStudentLeaderboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentLeaderboard.UseVisualStyleBackColor = false;
            this.btnStudentLeaderboard.Click += new System.EventHandler(this.btnStudentLeaderboard_Click);
            // 
            // btnStudentTopStudents
            // 
            this.btnStudentTopStudents.BackColor = System.Drawing.Color.Transparent;
            this.btnStudentTopStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudentTopStudents.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudentTopStudents.FlatAppearance.BorderSize = 0;
            this.btnStudentTopStudents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(85)))));
            this.btnStudentTopStudents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.btnStudentTopStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentTopStudents.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnStudentTopStudents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(215)))));
            this.btnStudentTopStudents.Location = new System.Drawing.Point(0, 76);
            this.btnStudentTopStudents.Name = "btnStudentTopStudents";
            this.btnStudentTopStudents.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnStudentTopStudents.Size = new System.Drawing.Size(254, 46);
            this.btnStudentTopStudents.TabIndex = 13;
            this.btnStudentTopStudents.Text = "  🏆  Top Students";
            this.btnStudentTopStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentTopStudents.UseVisualStyleBackColor = false;
            this.btnStudentTopStudents.Click += new System.EventHandler(this.btnStudentTopStudents_Click);
            // 
            // btnMySubmissions
            // 
            this.btnMySubmissions.BackColor = System.Drawing.Color.Transparent;
            this.btnMySubmissions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMySubmissions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMySubmissions.FlatAppearance.BorderSize = 0;
            this.btnMySubmissions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(85)))));
            this.btnMySubmissions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.btnMySubmissions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMySubmissions.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnMySubmissions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(215)))));
            this.btnMySubmissions.Location = new System.Drawing.Point(0, 30);
            this.btnMySubmissions.Name = "btnMySubmissions";
            this.btnMySubmissions.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnMySubmissions.Size = new System.Drawing.Size(254, 46);
            this.btnMySubmissions.TabIndex = 12;
            this.btnMySubmissions.Text = "  📄  My Submissions";
            this.btnMySubmissions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMySubmissions.UseVisualStyleBackColor = false;
            this.btnMySubmissions.Click += new System.EventHandler(this.btnMySubmissions_Click);
            // 
            // lblStudentSection
            // 
            this.lblStudentSection.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStudentSection.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblStudentSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.lblStudentSection.Location = new System.Drawing.Point(0, 0);
            this.lblStudentSection.Name = "lblStudentSection";
            this.lblStudentSection.Padding = new System.Windows.Forms.Padding(20, 8, 0, 0);
            this.lblStudentSection.Size = new System.Drawing.Size(254, 30);
            this.lblStudentSection.TabIndex = 15;
            this.lblStudentSection.Text = "STUDENT REPORTS";
            // 
            // pnlAdminReports
            // 
            this.pnlAdminReports.Controls.Add(this.btnContestLeaderboard);
            this.pnlAdminReports.Controls.Add(this.btnTopStudentsReport);
            this.pnlAdminReports.Controls.Add(this.btnSubmissionsReport);
            this.pnlAdminReports.Controls.Add(this.lblAdminSection);
            this.pnlAdminReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAdminReports.Location = new System.Drawing.Point(0, 91);
            this.pnlAdminReports.Name = "pnlAdminReports";
            this.pnlAdminReports.Size = new System.Drawing.Size(254, 170);
            this.pnlAdminReports.TabIndex = 14;
            // 
            // btnContestLeaderboard
            // 
            this.btnContestLeaderboard.BackColor = System.Drawing.Color.Transparent;
            this.btnContestLeaderboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContestLeaderboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContestLeaderboard.FlatAppearance.BorderSize = 0;
            this.btnContestLeaderboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(85)))));
            this.btnContestLeaderboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.btnContestLeaderboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContestLeaderboard.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnContestLeaderboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(215)))));
            this.btnContestLeaderboard.Location = new System.Drawing.Point(0, 122);
            this.btnContestLeaderboard.Name = "btnContestLeaderboard";
            this.btnContestLeaderboard.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnContestLeaderboard.Size = new System.Drawing.Size(254, 46);
            this.btnContestLeaderboard.TabIndex = 14;
            this.btnContestLeaderboard.Text = "  🥇  Contest Leaderboard";
            this.btnContestLeaderboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContestLeaderboard.UseVisualStyleBackColor = false;
            this.btnContestLeaderboard.Click += new System.EventHandler(this.btnContestLeaderboard_Click);
            // 
            // btnTopStudentsReport
            // 
            this.btnTopStudentsReport.BackColor = System.Drawing.Color.Transparent;
            this.btnTopStudentsReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTopStudentsReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTopStudentsReport.FlatAppearance.BorderSize = 0;
            this.btnTopStudentsReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(85)))));
            this.btnTopStudentsReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.btnTopStudentsReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopStudentsReport.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnTopStudentsReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(215)))));
            this.btnTopStudentsReport.Location = new System.Drawing.Point(0, 76);
            this.btnTopStudentsReport.Name = "btnTopStudentsReport";
            this.btnTopStudentsReport.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnTopStudentsReport.Size = new System.Drawing.Size(254, 46);
            this.btnTopStudentsReport.TabIndex = 13;
            this.btnTopStudentsReport.Text = "  🏆  Top Students Report";
            this.btnTopStudentsReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTopStudentsReport.UseVisualStyleBackColor = false;
            this.btnTopStudentsReport.Click += new System.EventHandler(this.btnTopStudentsReport_Click);
            // 
            // btnSubmissionsReport
            // 
            this.btnSubmissionsReport.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmissionsReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmissionsReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubmissionsReport.FlatAppearance.BorderSize = 0;
            this.btnSubmissionsReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(85)))));
            this.btnSubmissionsReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.btnSubmissionsReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmissionsReport.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnSubmissionsReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(215)))));
            this.btnSubmissionsReport.Location = new System.Drawing.Point(0, 30);
            this.btnSubmissionsReport.Name = "btnSubmissionsReport";
            this.btnSubmissionsReport.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnSubmissionsReport.Size = new System.Drawing.Size(254, 46);
            this.btnSubmissionsReport.TabIndex = 12;
            this.btnSubmissionsReport.Text = "  📋  Submissions Report";
            this.btnSubmissionsReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmissionsReport.UseVisualStyleBackColor = false;
            this.btnSubmissionsReport.Click += new System.EventHandler(this.btnSubmissionsReport_Click);
            // 
            // lblAdminSection
            // 
            this.lblAdminSection.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAdminSection.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblAdminSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.lblAdminSection.Location = new System.Drawing.Point(0, 0);
            this.lblAdminSection.Name = "lblAdminSection";
            this.lblAdminSection.Padding = new System.Windows.Forms.Padding(20, 8, 0, 0);
            this.lblAdminSection.Size = new System.Drawing.Size(254, 30);
            this.lblAdminSection.TabIndex = 15;
            this.lblAdminSection.Text = "ADMIN REPORTS";
            // 
            // pnlSidebarFooter
            // 
            this.pnlSidebarFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(35)))));
            this.pnlSidebarFooter.Controls.Add(this.btnPrint);
            this.pnlSidebarFooter.Controls.Add(this.btnExportPDF);
            this.pnlSidebarFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSidebarFooter.Location = new System.Drawing.Point(0, 486);
            this.pnlSidebarFooter.Name = "pnlSidebarFooter";
            this.pnlSidebarFooter.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.pnlSidebarFooter.Size = new System.Drawing.Size(254, 70);
            this.pnlSidebarFooter.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(50)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnPrint.Location = new System.Drawing.Point(128, 14);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(108, 36);
            this.btnPrint.TabIndex = 21;
            this.btnPrint.Text = "🖶  Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExportPDF
            // 
            this.btnExportPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.btnExportPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportPDF.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnExportPDF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(85)))));
            this.btnExportPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportPDF.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnExportPDF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnExportPDF.Location = new System.Drawing.Point(12, 14);
            this.btnExportPDF.Name = "btnExportPDF";
            this.btnExportPDF.Size = new System.Drawing.Size(108, 36);
            this.btnExportPDF.TabIndex = 20;
            this.btnExportPDF.Text = "⬇  Export PDF";
            this.btnExportPDF.UseVisualStyleBackColor = false;
            this.btnExportPDF.Click += new System.EventHandler(this.btnExportPDF_Click);
            // 
            // pnlDivider1
            // 
            this.pnlDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.pnlDivider1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDivider1.Location = new System.Drawing.Point(0, 90);
            this.pnlDivider1.Name = "pnlDivider1";
            this.pnlDivider1.Size = new System.Drawing.Size(254, 1);
            this.pnlDivider1.TabIndex = 12;
            // 
            // pnlSidebarHeader
            // 
            this.pnlSidebarHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.pnlSidebarHeader.Controls.Add(this.lblSidebarSubtitle);
            this.pnlSidebarHeader.Controls.Add(this.lblSidebarTitle);
            this.pnlSidebarHeader.Controls.Add(this.lblSidebarIcon);
            this.pnlSidebarHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSidebarHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebarHeader.Name = "pnlSidebarHeader";
            this.pnlSidebarHeader.Padding = new System.Windows.Forms.Padding(16, 14, 16, 10);
            this.pnlSidebarHeader.Size = new System.Drawing.Size(254, 90);
            this.pnlSidebarHeader.TabIndex = 13;
            // 
            // lblSidebarSubtitle
            // 
            this.lblSidebarSubtitle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSidebarSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.lblSidebarSubtitle.Location = new System.Drawing.Point(64, 40);
            this.lblSidebarSubtitle.Name = "lblSidebarSubtitle";
            this.lblSidebarSubtitle.Size = new System.Drawing.Size(180, 18);
            this.lblSidebarSubtitle.TabIndex = 0;
            this.lblSidebarSubtitle.Text = "Analytics & Insights";
            // 
            // lblSidebarTitle
            // 
            this.lblSidebarTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblSidebarTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.lblSidebarTitle.Location = new System.Drawing.Point(64, 16);
            this.lblSidebarTitle.Name = "lblSidebarTitle";
            this.lblSidebarTitle.Size = new System.Drawing.Size(180, 24);
            this.lblSidebarTitle.TabIndex = 1;
            this.lblSidebarTitle.Text = "Reports Hub";
            // 
            // lblSidebarIcon
            // 
            this.lblSidebarIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.lblSidebarIcon.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold);
            this.lblSidebarIcon.ForeColor = System.Drawing.Color.White;
            this.lblSidebarIcon.Location = new System.Drawing.Point(16, 18);
            this.lblSidebarIcon.Name = "lblSidebarIcon";
            this.lblSidebarIcon.Size = new System.Drawing.Size(40, 40);
            this.lblSidebarIcon.TabIndex = 2;
            this.lblSidebarIcon.Text = "📊";
            this.lblSidebarIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlContent
            // 
            this.pnlContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(25)))));
            this.pnlContent.Controls.Add(this.pnlHeaderDivider);
            this.pnlContent.Controls.Add(this.pnlStatsStrip);
            this.pnlContent.Controls.Add(this.pnlReportHeader);
            this.pnlContent.Controls.Add(this.dgvReport);
            this.pnlContent.Location = new System.Drawing.Point(263, 3);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(834, 556);
            this.pnlContent.TabIndex = 1;
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(90)))));
            this.dgvReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(25)))));
            this.dgvReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvReport.ColumnHeadersHeight = 40;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle9.NullValue = "—";
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReport.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvReport.EnableHeadersVisualStyles = false;
            this.dgvReport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.dgvReport.Location = new System.Drawing.Point(0, 193);
            this.dgvReport.MultiSelect = false;
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.RowHeadersVisible = false;
            this.dgvReport.RowTemplate.Height = 38;
            this.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReport.Size = new System.Drawing.Size(834, 362);
            this.dgvReport.TabIndex = 50;
            // 
            // pnlStatsStrip
            // 
            this.pnlStatsStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStatsStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(30)))));
            this.pnlStatsStrip.Controls.Add(this.pnlStat4);
            this.pnlStatsStrip.Controls.Add(this.pnlStatDiv3);
            this.pnlStatsStrip.Controls.Add(this.pnlStat3);
            this.pnlStatsStrip.Controls.Add(this.pnlStatDiv2);
            this.pnlStatsStrip.Controls.Add(this.pnlStat2);
            this.pnlStatsStrip.Controls.Add(this.pnlStatDiv1);
            this.pnlStatsStrip.Controls.Add(this.pnlStat1);
            this.pnlStatsStrip.Location = new System.Drawing.Point(0, 110);
            this.pnlStatsStrip.Name = "pnlStatsStrip";
            this.pnlStatsStrip.Padding = new System.Windows.Forms.Padding(24, 0, 24, 0);
            this.pnlStatsStrip.Size = new System.Drawing.Size(834, 82);
            this.pnlStatsStrip.TabIndex = 52;
            // 
            // pnlStat4
            // 
            this.pnlStat4.BackColor = System.Drawing.Color.Transparent;
            this.pnlStat4.Controls.Add(this.lblStat4Label);
            this.pnlStat4.Controls.Add(this.lblStat4Value);
            this.pnlStat4.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlStat4.Location = new System.Drawing.Point(537, 0);
            this.pnlStat4.Name = "pnlStat4";
            this.pnlStat4.Padding = new System.Windows.Forms.Padding(16, 14, 8, 14);
            this.pnlStat4.Size = new System.Drawing.Size(197, 82);
            this.pnlStat4.TabIndex = 0;
            // 
            // lblStat4Label
            // 
            this.lblStat4Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStat4Label.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblStat4Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.lblStat4Label.Location = new System.Drawing.Point(16, 44);
            this.lblStat4Label.Name = "lblStat4Label";
            this.lblStat4Label.Size = new System.Drawing.Size(173, 24);
            this.lblStat4Label.TabIndex = 0;
            this.lblStat4Label.Text = "Pending";
            // 
            // lblStat4Value
            // 
            this.lblStat4Value.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStat4Value.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblStat4Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblStat4Value.Location = new System.Drawing.Point(16, 14);
            this.lblStat4Value.Name = "lblStat4Value";
            this.lblStat4Value.Size = new System.Drawing.Size(173, 30);
            this.lblStat4Value.TabIndex = 1;
            this.lblStat4Value.Text = "—";
            this.lblStat4Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlStatDiv3
            // 
            this.pnlStatDiv3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.pnlStatDiv3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlStatDiv3.Location = new System.Drawing.Point(536, 0);
            this.pnlStatDiv3.Name = "pnlStatDiv3";
            this.pnlStatDiv3.Size = new System.Drawing.Size(1, 82);
            this.pnlStatDiv3.TabIndex = 1;
            // 
            // pnlStat3
            // 
            this.pnlStat3.BackColor = System.Drawing.Color.Transparent;
            this.pnlStat3.Controls.Add(this.lblStat3Label);
            this.pnlStat3.Controls.Add(this.lblStat3Value);
            this.pnlStat3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlStat3.Location = new System.Drawing.Point(366, 0);
            this.pnlStat3.Name = "pnlStat3";
            this.pnlStat3.Padding = new System.Windows.Forms.Padding(16, 14, 8, 14);
            this.pnlStat3.Size = new System.Drawing.Size(170, 82);
            this.pnlStat3.TabIndex = 2;
            // 
            // lblStat3Label
            // 
            this.lblStat3Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStat3Label.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblStat3Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.lblStat3Label.Location = new System.Drawing.Point(16, 44);
            this.lblStat3Label.Name = "lblStat3Label";
            this.lblStat3Label.Size = new System.Drawing.Size(146, 24);
            this.lblStat3Label.TabIndex = 0;
            this.lblStat3Label.Text = "Average Score";
            // 
            // lblStat3Value
            // 
            this.lblStat3Value.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStat3Value.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblStat3Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.lblStat3Value.Location = new System.Drawing.Point(16, 14);
            this.lblStat3Value.Name = "lblStat3Value";
            this.lblStat3Value.Size = new System.Drawing.Size(146, 30);
            this.lblStat3Value.TabIndex = 1;
            this.lblStat3Value.Text = "—";
            this.lblStat3Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlStatDiv2
            // 
            this.pnlStatDiv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.pnlStatDiv2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlStatDiv2.Location = new System.Drawing.Point(365, 0);
            this.pnlStatDiv2.Name = "pnlStatDiv2";
            this.pnlStatDiv2.Size = new System.Drawing.Size(1, 82);
            this.pnlStatDiv2.TabIndex = 3;
            // 
            // pnlStat2
            // 
            this.pnlStat2.BackColor = System.Drawing.Color.Transparent;
            this.pnlStat2.Controls.Add(this.lblStat2Label);
            this.pnlStat2.Controls.Add(this.lblStat2Value);
            this.pnlStat2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlStat2.Location = new System.Drawing.Point(195, 0);
            this.pnlStat2.Name = "pnlStat2";
            this.pnlStat2.Padding = new System.Windows.Forms.Padding(16, 14, 8, 14);
            this.pnlStat2.Size = new System.Drawing.Size(170, 82);
            this.pnlStat2.TabIndex = 4;
            // 
            // lblStat2Label
            // 
            this.lblStat2Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStat2Label.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblStat2Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.lblStat2Label.Location = new System.Drawing.Point(16, 44);
            this.lblStat2Label.Name = "lblStat2Label";
            this.lblStat2Label.Size = new System.Drawing.Size(146, 24);
            this.lblStat2Label.TabIndex = 0;
            this.lblStat2Label.Text = "This Period";
            // 
            // lblStat2Value
            // 
            this.lblStat2Value.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStat2Value.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblStat2Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.lblStat2Value.Location = new System.Drawing.Point(16, 14);
            this.lblStat2Value.Name = "lblStat2Value";
            this.lblStat2Value.Size = new System.Drawing.Size(146, 30);
            this.lblStat2Value.TabIndex = 1;
            this.lblStat2Value.Text = "—";
            this.lblStat2Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlStatDiv1
            // 
            this.pnlStatDiv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.pnlStatDiv1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlStatDiv1.Location = new System.Drawing.Point(194, 0);
            this.pnlStatDiv1.Margin = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.pnlStatDiv1.Name = "pnlStatDiv1";
            this.pnlStatDiv1.Size = new System.Drawing.Size(1, 82);
            this.pnlStatDiv1.TabIndex = 5;
            // 
            // pnlStat1
            // 
            this.pnlStat1.BackColor = System.Drawing.Color.Transparent;
            this.pnlStat1.Controls.Add(this.lblStat1Label);
            this.pnlStat1.Controls.Add(this.lblStat1Value);
            this.pnlStat1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlStat1.Location = new System.Drawing.Point(24, 0);
            this.pnlStat1.Name = "pnlStat1";
            this.pnlStat1.Padding = new System.Windows.Forms.Padding(8, 14, 8, 14);
            this.pnlStat1.Size = new System.Drawing.Size(170, 82);
            this.pnlStat1.TabIndex = 6;
            // 
            // lblStat1Label
            // 
            this.lblStat1Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStat1Label.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblStat1Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.lblStat1Label.Location = new System.Drawing.Point(8, 44);
            this.lblStat1Label.Name = "lblStat1Label";
            this.lblStat1Label.Size = new System.Drawing.Size(154, 24);
            this.lblStat1Label.TabIndex = 0;
            this.lblStat1Label.Text = "Total Records";
            // 
            // lblStat1Value
            // 
            this.lblStat1Value.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStat1Value.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblStat1Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.lblStat1Value.Location = new System.Drawing.Point(8, 14);
            this.lblStat1Value.Name = "lblStat1Value";
            this.lblStat1Value.Size = new System.Drawing.Size(154, 30);
            this.lblStat1Value.TabIndex = 1;
            this.lblStat1Value.Text = "—";
            this.lblStat1Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlHeaderDivider
            // 
            this.pnlHeaderDivider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeaderDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.pnlHeaderDivider.Location = new System.Drawing.Point(0, 192);
            this.pnlHeaderDivider.Name = "pnlHeaderDivider";
            this.pnlHeaderDivider.Size = new System.Drawing.Size(834, 1);
            this.pnlHeaderDivider.TabIndex = 53;
            // 
            // pnlReportHeader
            // 
            this.pnlReportHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlReportHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(35)))));
            this.pnlReportHeader.Controls.Add(this.pnlHeaderRight);
            this.pnlReportHeader.Controls.Add(this.pnlHeaderLeft);
            this.pnlReportHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlReportHeader.Name = "pnlReportHeader";
            this.pnlReportHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 14);
            this.pnlReportHeader.Size = new System.Drawing.Size(834, 110);
            this.pnlReportHeader.TabIndex = 54;
            // 
            // pnlHeaderRight
            // 
            this.pnlHeaderRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeaderRight.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeaderRight.Controls.Add(this.btnRefresh);
            this.pnlHeaderRight.Controls.Add(this.lblRows);
            this.pnlHeaderRight.Controls.Add(this.cmbRows);
            this.pnlHeaderRight.Controls.Add(this.dtpTo);
            this.pnlHeaderRight.Controls.Add(this.lblTo);
            this.pnlHeaderRight.Controls.Add(this.dtpFrom);
            this.pnlHeaderRight.Controls.Add(this.lblDateRangeLabel);
            this.pnlHeaderRight.Location = new System.Drawing.Point(365, 16);
            this.pnlHeaderRight.Name = "pnlHeaderRight";
            this.pnlHeaderRight.Size = new System.Drawing.Size(445, 80);
            this.pnlHeaderRight.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(305, 48);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(96, 23);
            this.btnRefresh.TabIndex = 44;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblRows
            // 
            this.lblRows.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblRows.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.lblRows.Location = new System.Drawing.Point(16, 52);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(38, 22);
            this.lblRows.TabIndex = 42;
            this.lblRows.Text = "Rows:";
            // 
            // cmbRows
            // 
            this.cmbRows.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.cmbRows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRows.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbRows.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.cmbRows.Items.AddRange(new object[] {
            "10",
            "25",
            "50",
            "100"});
            this.cmbRows.Location = new System.Drawing.Point(96, 48);
            this.cmbRows.Name = "cmbRows";
            this.cmbRows.Size = new System.Drawing.Size(150, 23);
            this.cmbRows.TabIndex = 43;
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(278, 11);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(150, 24);
            this.dtpTo.TabIndex = 31;
            // 
            // lblTo
            // 
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.lblTo.Location = new System.Drawing.Point(254, 13);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(24, 22);
            this.lblTo.TabIndex = 34;
            this.lblTo.Text = "to";
            this.lblTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpFrom
            // 
            this.dtpFrom.CalendarForeColor = System.Drawing.Color.White;
            this.dtpFrom.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(96, 11);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(150, 24);
            this.dtpFrom.TabIndex = 30;
            // 
            // lblDateRangeLabel
            // 
            this.lblDateRangeLabel.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblDateRangeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.lblDateRangeLabel.Location = new System.Drawing.Point(16, 13);
            this.lblDateRangeLabel.Name = "lblDateRangeLabel";
            this.lblDateRangeLabel.Size = new System.Drawing.Size(80, 22);
            this.lblDateRangeLabel.TabIndex = 35;
            this.lblDateRangeLabel.Text = "Date Range:";
            // 
            // pnlHeaderLeft
            // 
            this.pnlHeaderLeft.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeaderLeft.Controls.Add(this.lblReportDescription);
            this.pnlHeaderLeft.Controls.Add(this.lblReportTitle);
            this.pnlHeaderLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlHeaderLeft.Location = new System.Drawing.Point(24, 16);
            this.pnlHeaderLeft.Name = "pnlHeaderLeft";
            this.pnlHeaderLeft.Size = new System.Drawing.Size(341, 80);
            this.pnlHeaderLeft.TabIndex = 1;
            // 
            // lblReportDescription
            // 
            this.lblReportDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblReportDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.lblReportDescription.Location = new System.Drawing.Point(21, 44);
            this.lblReportDescription.Name = "lblReportDescription";
            this.lblReportDescription.Size = new System.Drawing.Size(298, 22);
            this.lblReportDescription.TabIndex = 0;
            this.lblReportDescription.Text = "Choose from the sidebar to load a report";
            // 
            // lblReportTitle
            // 
            this.lblReportTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblReportTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.lblReportTitle.Location = new System.Drawing.Point(21, 14);
            this.lblReportTitle.Name = "lblReportTitle";
            this.lblReportTitle.Size = new System.Drawing.Size(298, 28);
            this.lblReportTitle.TabIndex = 1;
            this.lblReportTitle.Text = "Select a Report";
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1100, 562);
            this.Controls.Add(this.mainLayout);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(235)))));
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports & Analytics";
            this.mainLayout.ResumeLayout(false);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlStudnet.ResumeLayout(false);
            this.pnlAdminReports.ResumeLayout(false);
            this.pnlSidebarFooter.ResumeLayout(false);
            this.pnlSidebarHeader.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.pnlStatsStrip.ResumeLayout(false);
            this.pnlStat4.ResumeLayout(false);
            this.pnlStat3.ResumeLayout(false);
            this.pnlStat2.ResumeLayout(false);
            this.pnlStat1.ResumeLayout(false);
            this.pnlReportHeader.ResumeLayout(false);
            this.pnlHeaderRight.ResumeLayout(false);
            this.pnlHeaderLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlAdminReports;
        private System.Windows.Forms.Panel pnlStudnet;
        private System.Windows.Forms.Button btnStudentLeaderboard;
        private System.Windows.Forms.Button btnStudentTopStudents;
        private System.Windows.Forms.Button btnMySubmissions;
        private System.Windows.Forms.Label lblStudentSection;
        private System.Windows.Forms.Button btnContestLeaderboard;
        private System.Windows.Forms.Button btnTopStudentsReport;
        private System.Windows.Forms.Button btnSubmissionsReport;
        private System.Windows.Forms.Label lblAdminSection;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.ComboBox cmbRows;
        private System.Windows.Forms.Button btnRefresh;
    }
}