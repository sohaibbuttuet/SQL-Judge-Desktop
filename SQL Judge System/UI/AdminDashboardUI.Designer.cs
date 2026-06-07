using System.Windows.Forms;

namespace SQL_Judge_System.UI
{
    partial class AdminDashboardUI
    {
        private System.Windows.Forms.Panel pnlSidebar;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btn_Settings = new FontAwesome.Sharp.IconButton();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.btnReport = new FontAwesome.Sharp.IconButton();
            this.btnSubmissions = new FontAwesome.Sharp.IconButton();
            this.btn_contests = new FontAwesome.Sharp.IconButton();
            this.btn_problems = new FontAwesome.Sharp.IconButton();
            this.btn_students = new FontAwesome.Sharp.IconButton();
            this.btn_Admin = new FontAwesome.Sharp.IconButton();
            this.btn_Home = new FontAwesome.Sharp.IconButton();
            this.pnlSidebarLogo = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblAppSub = new System.Windows.Forms.Label();
            this.lblAppName = new System.Windows.Forms.Label();
            this.pnlContest = new System.Windows.Forms.Panel();
            this.btnUpdContest = new FontAwesome.Sharp.IconButton();
            this.btnAddContest = new FontAwesome.Sharp.IconButton();
            this.ContestCards = new System.Windows.Forms.Panel();
            this.tlpContest = new System.Windows.Forms.TableLayoutPanel();
            this.pnlinactContest = new System.Windows.Forms.Panel();
            this.lblInActcontestValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlTotalContest = new System.Windows.Forms.Panel();
            this.lblTotalContestValue = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlactContest = new System.Windows.Forms.Panel();
            this.lblActContestValue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlUpcommingContest = new System.Windows.Forms.Panel();
            this.lblUpcommingContestValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvContest = new System.Windows.Forms.DataGridView();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlsubmissions = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlsubmissionsCards = new System.Windows.Forms.Panel();
            this.tlpnlSubmission = new System.Windows.Forms.TableLayoutPanel();
            this.pnlAccSub = new System.Windows.Forms.Panel();
            this.AccSubValue = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pnlRegSub = new System.Windows.Forms.Panel();
            this.RegSubValue = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlTotalSub = new System.Windows.Forms.Panel();
            this.totalsubValue = new System.Windows.Forms.Label();
            this.lblSubmissions = new System.Windows.Forms.Label();
            this.dgvSubmissions = new System.Windows.Forms.DataGridView();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblSuperAdmin = new System.Windows.Forms.Label();
            this.dgvAdmins = new System.Windows.Forms.DataGridView();
            this.pnladmin = new System.Windows.Forms.Panel();
            this.tlpnlAdmin = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTotalAdmins = new System.Windows.Forms.Panel();
            this.lbladminValue = new System.Windows.Forms.Label();
            this.lblTotalAdmins = new System.Windows.Forms.Label();
            this.pnlActiveAdmins = new System.Windows.Forms.Panel();
            this.lblActAdminsValue = new System.Windows.Forms.Label();
            this.lblActAdmins = new System.Windows.Forms.Label();
            this.pnlinActiveAdmins = new System.Windows.Forms.Panel();
            this.lblinActAdminsValue = new System.Windows.Forms.Label();
            this.lblinActAdmins = new System.Windows.Forms.Label();
            this.pnlTotalSuperAdmins = new System.Windows.Forms.Panel();
            this.lblsuperAdminValue = new System.Windows.Forms.Label();
            this.lblTotalSuperAdmin = new System.Windows.Forms.Label();
            this.pnlSuperAdmin = new System.Windows.Forms.Panel();
            this.btnToggleAdmin = new FontAwesome.Sharp.IconButton();
            this.btnUpdateAdmin = new FontAwesome.Sharp.IconButton();
            this.btnAddAdmin = new FontAwesome.Sharp.IconButton();
            this.pnlStudent = new System.Windows.Forms.Panel();
            this.btntoggleStd = new FontAwesome.Sharp.IconButton();
            this.pnlstd = new System.Windows.Forms.Panel();
            this.tlpnlStudents = new System.Windows.Forms.TableLayoutPanel();
            this.pnlActiveStudents = new System.Windows.Forms.Panel();
            this.lblactstdValue = new System.Windows.Forms.Label();
            this.lblactstd = new System.Windows.Forms.Label();
            this.pnlTotalSudents = new System.Windows.Forms.Panel();
            this.lbl_stdValue = new System.Windows.Forms.Label();
            this.lblstd = new System.Windows.Forms.Label();
            this.pnlnactiveStudents = new System.Windows.Forms.Panel();
            this.lblinactstdValue = new System.Windows.Forms.Label();
            this.lblinactstd = new System.Windows.Forms.Label();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.lblGridTitle = new System.Windows.Forms.Label();
            this.pnlHomeCards = new System.Windows.Forms.Panel();
            this.tlpnlHomeCards = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTotalUsersValue = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblInactiveUsersValue = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblActiveUsersValue = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.dgv_Users = new System.Windows.Forms.DataGridView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.ProblemCards = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlinActProb = new System.Windows.Forms.Panel();
            this.lblInActProbValue = new System.Windows.Forms.Label();
            this.lblInActProb = new System.Windows.Forms.Label();
            this.pnlActProb = new System.Windows.Forms.Panel();
            this.lblActProbValue = new System.Windows.Forms.Label();
            this.lblActProb = new System.Windows.Forms.Label();
            this.pnlTotalProb = new System.Windows.Forms.Panel();
            this.lblTotalProbValue = new System.Windows.Forms.Label();
            this.lblTotalProb = new System.Windows.Forms.Label();
            this.dgvProblems = new System.Windows.Forms.DataGridView();
            this.btnAddProb = new FontAwesome.Sharp.IconButton();
            this.btnUpdateProb = new FontAwesome.Sharp.IconButton();
            this.btnToggleProb = new FontAwesome.Sharp.IconButton();
            this.pnlProblems = new System.Windows.Forms.Panel();
            this.pnlSidebar.SuspendLayout();
            this.pnlSidebarLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlContest.SuspendLayout();
            this.ContestCards.SuspendLayout();
            this.tlpContest.SuspendLayout();
            this.pnlinactContest.SuspendLayout();
            this.pnlTotalContest.SuspendLayout();
            this.pnlactContest.SuspendLayout();
            this.pnlUpcommingContest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContest)).BeginInit();
            this.panel11.SuspendLayout();
            this.pnlsubmissions.SuspendLayout();
            this.pnlsubmissionsCards.SuspendLayout();
            this.tlpnlSubmission.SuspendLayout();
            this.pnlAccSub.SuspendLayout();
            this.pnlRegSub.SuspendLayout();
            this.pnlTotalSub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubmissions)).BeginInit();
            this.panel13.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmins)).BeginInit();
            this.pnladmin.SuspendLayout();
            this.tlpnlAdmin.SuspendLayout();
            this.pnlTotalAdmins.SuspendLayout();
            this.pnlActiveAdmins.SuspendLayout();
            this.pnlinActiveAdmins.SuspendLayout();
            this.pnlTotalSuperAdmins.SuspendLayout();
            this.pnlSuperAdmin.SuspendLayout();
            this.pnlStudent.SuspendLayout();
            this.pnlstd.SuspendLayout();
            this.tlpnlStudents.SuspendLayout();
            this.pnlActiveStudents.SuspendLayout();
            this.pnlTotalSudents.SuspendLayout();
            this.pnlnactiveStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.panel3.SuspendLayout();
            this.pnlHome.SuspendLayout();
            this.pnlHomeCards.SuspendLayout();
            this.tlpnlHomeCards.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Users)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel5.SuspendLayout();
            this.ProblemCards.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlinActProb.SuspendLayout();
            this.pnlActProb.SuspendLayout();
            this.pnlTotalProb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProblems)).BeginInit();
            this.pnlProblems.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(26)))));
            this.pnlSidebar.Controls.Add(this.btn_Settings);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.btnReport);
            this.pnlSidebar.Controls.Add(this.btnSubmissions);
            this.pnlSidebar.Controls.Add(this.btn_contests);
            this.pnlSidebar.Controls.Add(this.btn_problems);
            this.pnlSidebar.Controls.Add(this.btn_students);
            this.pnlSidebar.Controls.Add(this.btn_Admin);
            this.pnlSidebar.Controls.Add(this.btn_Home);
            this.pnlSidebar.Controls.Add(this.pnlSidebarLogo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(200, 601);
            this.pnlSidebar.TabIndex = 1;
            // 
            // btn_Settings
            // 
            this.btn_Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Settings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Settings.FlatAppearance.BorderSize = 0;
            this.btn_Settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btn_Settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Settings.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.btn_Settings.IconChar = FontAwesome.Sharp.IconChar.Gears;
            this.btn_Settings.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.btn_Settings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Settings.IconSize = 24;
            this.btn_Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Settings.Location = new System.Drawing.Point(0, 505);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btn_Settings.Size = new System.Drawing.Size(200, 48);
            this.btn_Settings.TabIndex = 24;
            this.btn_Settings.Text = "Settings";
            this.btn_Settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Settings.UseVisualStyleBackColor = true;
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.btnLogout.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.IconSize = 24;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 553);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(200, 48);
            this.btnLogout.TabIndex = 25;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnReport
            // 
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.btnReport.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.btnReport.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.btnReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReport.IconSize = 24;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(0, 358);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnReport.Size = new System.Drawing.Size(200, 48);
            this.btnReport.TabIndex = 22;
            this.btnReport.Text = "Reports";
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnSubmissions
            // 
            this.btnSubmissions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmissions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubmissions.FlatAppearance.BorderSize = 0;
            this.btnSubmissions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btnSubmissions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btnSubmissions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmissions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmissions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.btnSubmissions.IconChar = FontAwesome.Sharp.IconChar.Code;
            this.btnSubmissions.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.btnSubmissions.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSubmissions.IconSize = 24;
            this.btnSubmissions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmissions.Location = new System.Drawing.Point(0, 310);
            this.btnSubmissions.Name = "btnSubmissions";
            this.btnSubmissions.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnSubmissions.Size = new System.Drawing.Size(200, 48);
            this.btnSubmissions.TabIndex = 21;
            this.btnSubmissions.Text = "Submissions";
            this.btnSubmissions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSubmissions.UseVisualStyleBackColor = true;
            this.btnSubmissions.Click += new System.EventHandler(this.btnSubmissions_Click);
            // 
            // btn_contests
            // 
            this.btn_contests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_contests.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_contests.FlatAppearance.BorderSize = 0;
            this.btn_contests.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btn_contests.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btn_contests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_contests.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_contests.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.btn_contests.IconChar = FontAwesome.Sharp.IconChar.Trophy;
            this.btn_contests.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.btn_contests.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_contests.IconSize = 24;
            this.btn_contests.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_contests.Location = new System.Drawing.Point(0, 262);
            this.btn_contests.Name = "btn_contests";
            this.btn_contests.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btn_contests.Size = new System.Drawing.Size(200, 48);
            this.btn_contests.TabIndex = 19;
            this.btn_contests.Text = "Manage Contests";
            this.btn_contests.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_contests.UseVisualStyleBackColor = true;
            this.btn_contests.Click += new System.EventHandler(this.btn_contests_Click);
            // 
            // btn_problems
            // 
            this.btn_problems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_problems.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_problems.FlatAppearance.BorderSize = 0;
            this.btn_problems.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btn_problems.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btn_problems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_problems.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_problems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.btn_problems.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btn_problems.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.btn_problems.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_problems.IconSize = 24;
            this.btn_problems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_problems.Location = new System.Drawing.Point(0, 214);
            this.btn_problems.Name = "btn_problems";
            this.btn_problems.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btn_problems.Size = new System.Drawing.Size(200, 48);
            this.btn_problems.TabIndex = 18;
            this.btn_problems.Text = "Manage Problems";
            this.btn_problems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_problems.UseVisualStyleBackColor = true;
            this.btn_problems.Click += new System.EventHandler(this.btn_problems_Click);
            // 
            // btn_students
            // 
            this.btn_students.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_students.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_students.FlatAppearance.BorderSize = 0;
            this.btn_students.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btn_students.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btn_students.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_students.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_students.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.btn_students.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            this.btn_students.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.btn_students.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_students.IconSize = 24;
            this.btn_students.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_students.Location = new System.Drawing.Point(0, 166);
            this.btn_students.Name = "btn_students";
            this.btn_students.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btn_students.Size = new System.Drawing.Size(200, 48);
            this.btn_students.TabIndex = 17;
            this.btn_students.Text = "Manage Students";
            this.btn_students.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_students.UseVisualStyleBackColor = true;
            this.btn_students.Click += new System.EventHandler(this.btn_students_Click);
            // 
            // btn_Admin
            // 
            this.btn_Admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Admin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Admin.FlatAppearance.BorderSize = 0;
            this.btn_Admin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btn_Admin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btn_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Admin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Admin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.btn_Admin.IconChar = FontAwesome.Sharp.IconChar.RankingStar;
            this.btn_Admin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.btn_Admin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Admin.IconSize = 24;
            this.btn_Admin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Admin.Location = new System.Drawing.Point(0, 118);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btn_Admin.Size = new System.Drawing.Size(200, 48);
            this.btn_Admin.TabIndex = 26;
            this.btn_Admin.Text = "Manage Admins";
            this.btn_Admin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Admin.UseVisualStyleBackColor = true;
            this.btn_Admin.Click += new System.EventHandler(this.btn_Admin_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btn_Home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.btn_Home.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.btn_Home.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.btn_Home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Home.IconSize = 24;
            this.btn_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.Location = new System.Drawing.Point(0, 70);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btn_Home.Size = new System.Drawing.Size(200, 48);
            this.btn_Home.TabIndex = 16;
            this.btn_Home.Text = "Home";
            this.btn_Home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Home.UseVisualStyleBackColor = true;
            this.btn_Home.Click += new System.EventHandler(this.btnHome_Click);
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
            this.pnlSidebarLogo.Size = new System.Drawing.Size(200, 70);
            this.pnlSidebarLogo.TabIndex = 27;
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
            this.lblAppSub.Location = new System.Drawing.Point(72, 41);
            this.lblAppSub.Name = "lblAppSub";
            this.lblAppSub.Size = new System.Drawing.Size(77, 15);
            this.lblAppSub.TabIndex = 1;
            this.lblAppSub.Text = "Admin Portal";
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
            // pnlContest
            // 
            this.pnlContest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(26)))));
            this.pnlContest.Controls.Add(this.btnUpdContest);
            this.pnlContest.Controls.Add(this.btnAddContest);
            this.pnlContest.Controls.Add(this.ContestCards);
            this.pnlContest.Controls.Add(this.dgvContest);
            this.pnlContest.Controls.Add(this.panel11);
            this.pnlContest.Location = new System.Drawing.Point(199, 2);
            this.pnlContest.Name = "pnlContest";
            this.pnlContest.Size = new System.Drawing.Size(805, 599);
            this.pnlContest.TabIndex = 6;
            // 
            // btnUpdContest
            // 
            this.btnUpdContest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnUpdContest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdContest.FlatAppearance.BorderSize = 0;
            this.btnUpdContest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btnUpdContest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btnUpdContest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdContest.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdContest.ForeColor = System.Drawing.Color.White;
            this.btnUpdContest.IconChar = FontAwesome.Sharp.IconChar.PenAlt;
            this.btnUpdContest.IconColor = System.Drawing.Color.White;
            this.btnUpdContest.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdContest.IconSize = 18;
            this.btnUpdContest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdContest.Location = new System.Drawing.Point(192, 230);
            this.btnUpdContest.Name = "btnUpdContest";
            this.btnUpdContest.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUpdContest.Size = new System.Drawing.Size(151, 41);
            this.btnUpdContest.TabIndex = 29;
            this.btnUpdContest.Text = "Update Contest";
            this.btnUpdContest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdContest.UseVisualStyleBackColor = false;
            this.btnUpdContest.Click += new System.EventHandler(this.btnUpdContest_Click);
            // 
            // btnAddContest
            // 
            this.btnAddContest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnAddContest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddContest.FlatAppearance.BorderSize = 0;
            this.btnAddContest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btnAddContest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btnAddContest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddContest.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddContest.ForeColor = System.Drawing.Color.White;
            this.btnAddContest.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnAddContest.IconColor = System.Drawing.Color.White;
            this.btnAddContest.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddContest.IconSize = 20;
            this.btnAddContest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddContest.Location = new System.Drawing.Point(26, 230);
            this.btnAddContest.Name = "btnAddContest";
            this.btnAddContest.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAddContest.Size = new System.Drawing.Size(151, 41);
            this.btnAddContest.TabIndex = 26;
            this.btnAddContest.Text = "Add Contest";
            this.btnAddContest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddContest.UseVisualStyleBackColor = false;
            this.btnAddContest.Click += new System.EventHandler(this.btnAddContest_Click);
            // 
            // ContestCards
            // 
            this.ContestCards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(26)))));
            this.ContestCards.Controls.Add(this.tlpContest);
            this.ContestCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContestCards.Location = new System.Drawing.Point(0, 50);
            this.ContestCards.Name = "ContestCards";
            this.ContestCards.Padding = new System.Windows.Forms.Padding(12, 12, 12, 0);
            this.ContestCards.Size = new System.Drawing.Size(805, 165);
            this.ContestCards.TabIndex = 13;
            // 
            // tlpContest
            // 
            this.tlpContest.ColumnCount = 4;
            this.tlpContest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpContest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpContest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpContest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpContest.Controls.Add(this.pnlinactContest, 2, 0);
            this.tlpContest.Controls.Add(this.pnlTotalContest, 0, 0);
            this.tlpContest.Controls.Add(this.pnlactContest, 1, 0);
            this.tlpContest.Controls.Add(this.pnlUpcommingContest, 3, 0);
            this.tlpContest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContest.Location = new System.Drawing.Point(12, 12);
            this.tlpContest.Name = "tlpContest";
            this.tlpContest.RowCount = 1;
            this.tlpContest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContest.Size = new System.Drawing.Size(781, 153);
            this.tlpContest.TabIndex = 20;
            // 
            // pnlinactContest
            // 
            this.pnlinactContest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.pnlinactContest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlinactContest.Controls.Add(this.lblInActcontestValue);
            this.pnlinactContest.Controls.Add(this.label3);
            this.pnlinactContest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlinactContest.Location = new System.Drawing.Point(405, 15);
            this.pnlinactContest.Margin = new System.Windows.Forms.Padding(15);
            this.pnlinactContest.Name = "pnlinactContest";
            this.pnlinactContest.Padding = new System.Windows.Forms.Padding(12);
            this.pnlinactContest.Size = new System.Drawing.Size(165, 123);
            this.pnlinactContest.TabIndex = 23;
            // 
            // lblInActcontestValue
            // 
            this.lblInActcontestValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInActcontestValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblInActcontestValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.lblInActcontestValue.Location = new System.Drawing.Point(12, 35);
            this.lblInActcontestValue.Name = "lblInActcontestValue";
            this.lblInActcontestValue.Size = new System.Drawing.Size(139, 74);
            this.lblInActcontestValue.TabIndex = 0;
            this.lblInActcontestValue.Text = "0";
            this.lblInActcontestValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "INACTIVE CONTESTS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTotalContest
            // 
            this.pnlTotalContest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.pnlTotalContest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalContest.Controls.Add(this.lblTotalContestValue);
            this.pnlTotalContest.Controls.Add(this.label8);
            this.pnlTotalContest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTotalContest.Location = new System.Drawing.Point(15, 15);
            this.pnlTotalContest.Margin = new System.Windows.Forms.Padding(15);
            this.pnlTotalContest.Name = "pnlTotalContest";
            this.pnlTotalContest.Padding = new System.Windows.Forms.Padding(12);
            this.pnlTotalContest.Size = new System.Drawing.Size(165, 123);
            this.pnlTotalContest.TabIndex = 22;
            // 
            // lblTotalContestValue
            // 
            this.lblTotalContestValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalContestValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTotalContestValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(66)))));
            this.lblTotalContestValue.Location = new System.Drawing.Point(12, 35);
            this.lblTotalContestValue.Name = "lblTotalContestValue";
            this.lblTotalContestValue.Size = new System.Drawing.Size(139, 74);
            this.lblTotalContestValue.TabIndex = 0;
            this.lblTotalContestValue.Text = "0";
            this.lblTotalContestValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.label8.Location = new System.Drawing.Point(12, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 23);
            this.label8.TabIndex = 1;
            this.label8.Text = "TOTAL CONTESTS";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlactContest
            // 
            this.pnlactContest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.pnlactContest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlactContest.Controls.Add(this.lblActContestValue);
            this.pnlactContest.Controls.Add(this.label5);
            this.pnlactContest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlactContest.Location = new System.Drawing.Point(210, 15);
            this.pnlactContest.Margin = new System.Windows.Forms.Padding(15);
            this.pnlactContest.Name = "pnlactContest";
            this.pnlactContest.Padding = new System.Windows.Forms.Padding(12);
            this.pnlactContest.Size = new System.Drawing.Size(165, 123);
            this.pnlactContest.TabIndex = 21;
            // 
            // lblActContestValue
            // 
            this.lblActContestValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActContestValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblActContestValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(111)))), ((int)(((byte)(255)))));
            this.lblActContestValue.Location = new System.Drawing.Point(12, 35);
            this.lblActContestValue.Name = "lblActContestValue";
            this.lblActContestValue.Size = new System.Drawing.Size(139, 74);
            this.lblActContestValue.TabIndex = 0;
            this.lblActContestValue.Text = "0";
            this.lblActContestValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.label5.Location = new System.Drawing.Point(12, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "ACTIVE CONTESTS";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlUpcommingContest
            // 
            this.pnlUpcommingContest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.pnlUpcommingContest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUpcommingContest.Controls.Add(this.lblUpcommingContestValue);
            this.pnlUpcommingContest.Controls.Add(this.label4);
            this.pnlUpcommingContest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUpcommingContest.Location = new System.Drawing.Point(600, 15);
            this.pnlUpcommingContest.Margin = new System.Windows.Forms.Padding(15);
            this.pnlUpcommingContest.Name = "pnlUpcommingContest";
            this.pnlUpcommingContest.Padding = new System.Windows.Forms.Padding(12);
            this.pnlUpcommingContest.Size = new System.Drawing.Size(166, 123);
            this.pnlUpcommingContest.TabIndex = 20;
            // 
            // lblUpcommingContestValue
            // 
            this.lblUpcommingContestValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUpcommingContestValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblUpcommingContestValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(207)))), ((int)(((byte)(142)))));
            this.lblUpcommingContestValue.Location = new System.Drawing.Point(12, 35);
            this.lblUpcommingContestValue.Name = "lblUpcommingContestValue";
            this.lblUpcommingContestValue.Size = new System.Drawing.Size(140, 74);
            this.lblUpcommingContestValue.TabIndex = 0;
            this.lblUpcommingContestValue.Text = "0";
            this.lblUpcommingContestValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "UPCOMMING CONTESTS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvContest
            // 
            this.dgvContest.AllowUserToAddRows = false;
            this.dgvContest.AllowUserToDeleteRows = false;
            this.dgvContest.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(201)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvContest.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContest.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.dgvContest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvContest.ColumnHeadersHeight = 38;
            this.dgvContest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(201)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContest.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvContest.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(47)))));
            this.dgvContest.Location = new System.Drawing.Point(0, 285);
            this.dgvContest.MultiSelect = false;
            this.dgvContest.Name = "dgvContest";
            this.dgvContest.ReadOnly = true;
            this.dgvContest.RowHeadersWidth = 35;
            this.dgvContest.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvContest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContest.Size = new System.Drawing.Size(805, 314);
            this.dgvContest.TabIndex = 7;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.panel11.Controls.Add(this.label9);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(805, 50);
            this.panel11.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.label9.Location = new System.Drawing.Point(12, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Manage Contests";
            // 
            // pnlsubmissions
            // 
            this.pnlsubmissions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(26)))));
            this.pnlsubmissions.Controls.Add(this.label1);
            this.pnlsubmissions.Controls.Add(this.pnlsubmissionsCards);
            this.pnlsubmissions.Controls.Add(this.dgvSubmissions);
            this.pnlsubmissions.Controls.Add(this.panel13);
            this.pnlsubmissions.Location = new System.Drawing.Point(199, 2);
            this.pnlsubmissions.Name = "pnlsubmissions";
            this.pnlsubmissions.Size = new System.Drawing.Size(805, 599);
            this.pnlsubmissions.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.label1.Location = new System.Drawing.Point(4, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "SUBMISSIONS VIEW";
            // 
            // pnlsubmissionsCards
            // 
            this.pnlsubmissionsCards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(26)))));
            this.pnlsubmissionsCards.Controls.Add(this.tlpnlSubmission);
            this.pnlsubmissionsCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlsubmissionsCards.Location = new System.Drawing.Point(0, 50);
            this.pnlsubmissionsCards.Name = "pnlsubmissionsCards";
            this.pnlsubmissionsCards.Padding = new System.Windows.Forms.Padding(12, 12, 12, 0);
            this.pnlsubmissionsCards.Size = new System.Drawing.Size(805, 180);
            this.pnlsubmissionsCards.TabIndex = 11;
            // 
            // tlpnlSubmission
            // 
            this.tlpnlSubmission.ColumnCount = 3;
            this.tlpnlSubmission.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpnlSubmission.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpnlSubmission.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpnlSubmission.Controls.Add(this.pnlAccSub, 1, 0);
            this.tlpnlSubmission.Controls.Add(this.pnlRegSub, 2, 0);
            this.tlpnlSubmission.Controls.Add(this.pnlTotalSub, 0, 0);
            this.tlpnlSubmission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpnlSubmission.Location = new System.Drawing.Point(12, 12);
            this.tlpnlSubmission.Name = "tlpnlSubmission";
            this.tlpnlSubmission.RowCount = 1;
            this.tlpnlSubmission.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpnlSubmission.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpnlSubmission.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpnlSubmission.Size = new System.Drawing.Size(781, 168);
            this.tlpnlSubmission.TabIndex = 5;
            // 
            // pnlAccSub
            // 
            this.pnlAccSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.pnlAccSub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAccSub.Controls.Add(this.AccSubValue);
            this.pnlAccSub.Controls.Add(this.label15);
            this.pnlAccSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAccSub.Location = new System.Drawing.Point(275, 15);
            this.pnlAccSub.Margin = new System.Windows.Forms.Padding(15);
            this.pnlAccSub.Name = "pnlAccSub";
            this.pnlAccSub.Padding = new System.Windows.Forms.Padding(12);
            this.pnlAccSub.Size = new System.Drawing.Size(230, 138);
            this.pnlAccSub.TabIndex = 7;
            // 
            // AccSubValue
            // 
            this.AccSubValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AccSubValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.AccSubValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.AccSubValue.Location = new System.Drawing.Point(12, 42);
            this.AccSubValue.Name = "AccSubValue";
            this.AccSubValue.Size = new System.Drawing.Size(204, 82);
            this.AccSubValue.TabIndex = 0;
            this.AccSubValue.Text = "3";
            this.AccSubValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Dock = System.Windows.Forms.DockStyle.Top;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.label15.Location = new System.Drawing.Point(12, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(204, 30);
            this.label15.TabIndex = 1;
            this.label15.Text = "ACCEPTED SUBMISSIONS";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlRegSub
            // 
            this.pnlRegSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.pnlRegSub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRegSub.Controls.Add(this.RegSubValue);
            this.pnlRegSub.Controls.Add(this.label11);
            this.pnlRegSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegSub.Location = new System.Drawing.Point(535, 15);
            this.pnlRegSub.Margin = new System.Windows.Forms.Padding(15);
            this.pnlRegSub.Name = "pnlRegSub";
            this.pnlRegSub.Padding = new System.Windows.Forms.Padding(12);
            this.pnlRegSub.Size = new System.Drawing.Size(231, 138);
            this.pnlRegSub.TabIndex = 6;
            // 
            // RegSubValue
            // 
            this.RegSubValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegSubValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.RegSubValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(207)))), ((int)(((byte)(142)))));
            this.RegSubValue.Location = new System.Drawing.Point(12, 42);
            this.RegSubValue.Name = "RegSubValue";
            this.RegSubValue.Size = new System.Drawing.Size(205, 82);
            this.RegSubValue.TabIndex = 0;
            this.RegSubValue.Text = "215";
            this.RegSubValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.label11.Location = new System.Drawing.Point(12, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(205, 30);
            this.label11.TabIndex = 1;
            this.label11.Text = "REJECTED SUBMISSIONS";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTotalSub
            // 
            this.pnlTotalSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.pnlTotalSub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalSub.Controls.Add(this.totalsubValue);
            this.pnlTotalSub.Controls.Add(this.lblSubmissions);
            this.pnlTotalSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTotalSub.Location = new System.Drawing.Point(15, 15);
            this.pnlTotalSub.Margin = new System.Windows.Forms.Padding(15);
            this.pnlTotalSub.Name = "pnlTotalSub";
            this.pnlTotalSub.Padding = new System.Windows.Forms.Padding(12);
            this.pnlTotalSub.Size = new System.Drawing.Size(230, 138);
            this.pnlTotalSub.TabIndex = 5;
            // 
            // totalsubValue
            // 
            this.totalsubValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalsubValue.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalsubValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(111)))), ((int)(((byte)(255)))));
            this.totalsubValue.Location = new System.Drawing.Point(12, 42);
            this.totalsubValue.Name = "totalsubValue";
            this.totalsubValue.Size = new System.Drawing.Size(204, 82);
            this.totalsubValue.TabIndex = 0;
            this.totalsubValue.Text = "5";
            this.totalsubValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubmissions
            // 
            this.lblSubmissions.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSubmissions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubmissions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblSubmissions.Location = new System.Drawing.Point(12, 12);
            this.lblSubmissions.Name = "lblSubmissions";
            this.lblSubmissions.Size = new System.Drawing.Size(204, 30);
            this.lblSubmissions.TabIndex = 1;
            this.lblSubmissions.Text = "TOTAL SUBMISSIONS";
            this.lblSubmissions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvSubmissions
            // 
            this.dgvSubmissions.AllowUserToAddRows = false;
            this.dgvSubmissions.AllowUserToDeleteRows = false;
            this.dgvSubmissions.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(201)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvSubmissions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSubmissions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSubmissions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubmissions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.dgvSubmissions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubmissions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSubmissions.ColumnHeadersHeight = 38;
            this.dgvSubmissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(201)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubmissions.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSubmissions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(47)))));
            this.dgvSubmissions.Location = new System.Drawing.Point(-1, 273);
            this.dgvSubmissions.MultiSelect = false;
            this.dgvSubmissions.Name = "dgvSubmissions";
            this.dgvSubmissions.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubmissions.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSubmissions.RowHeadersVisible = false;
            this.dgvSubmissions.RowHeadersWidth = 35;
            this.dgvSubmissions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSubmissions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubmissions.Size = new System.Drawing.Size(807, 327);
            this.dgvSubmissions.TabIndex = 7;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.panel13.Controls.Add(this.label17);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(805, 50);
            this.panel13.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.label17.Location = new System.Drawing.Point(21, 13);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(235, 24);
            this.label17.TabIndex = 1;
            this.label17.Text = "Submissions Dashboard";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.pnlHeader.Controls.Add(this.lblSuperAdmin);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(805, 48);
            this.pnlHeader.TabIndex = 6;
            // 
            // lblSuperAdmin
            // 
            this.lblSuperAdmin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuperAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblSuperAdmin.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblSuperAdmin.Location = new System.Drawing.Point(21, 12);
            this.lblSuperAdmin.Name = "lblSuperAdmin";
            this.lblSuperAdmin.Size = new System.Drawing.Size(185, 25);
            this.lblSuperAdmin.TabIndex = 1;
            this.lblSuperAdmin.Text = "Admins Dashboard";
            // 
            // dgvAdmins
            // 
            this.dgvAdmins.AllowUserToAddRows = false;
            this.dgvAdmins.AllowUserToDeleteRows = false;
            this.dgvAdmins.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(201)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAdmins.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvAdmins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAdmins.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdmins.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.dgvAdmins.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdmins.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvAdmins.ColumnHeadersHeight = 38;
            this.dgvAdmins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(201)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdmins.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvAdmins.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(47)))));
            this.dgvAdmins.Location = new System.Drawing.Point(0, 278);
            this.dgvAdmins.MultiSelect = false;
            this.dgvAdmins.Name = "dgvAdmins";
            this.dgvAdmins.ReadOnly = true;
            this.dgvAdmins.RowHeadersWidth = 35;
            this.dgvAdmins.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdmins.Size = new System.Drawing.Size(805, 321);
            this.dgvAdmins.TabIndex = 7;
            // 
            // pnladmin
            // 
            this.pnladmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(26)))));
            this.pnladmin.Controls.Add(this.tlpnlAdmin);
            this.pnladmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnladmin.Location = new System.Drawing.Point(0, 48);
            this.pnladmin.Name = "pnladmin";
            this.pnladmin.Padding = new System.Windows.Forms.Padding(12, 12, 12, 0);
            this.pnladmin.Size = new System.Drawing.Size(805, 153);
            this.pnladmin.TabIndex = 11;
            // 
            // tlpnlAdmin
            // 
            this.tlpnlAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(26)))));
            this.tlpnlAdmin.ColumnCount = 4;
            this.tlpnlAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpnlAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpnlAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpnlAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpnlAdmin.Controls.Add(this.pnlTotalAdmins, 0, 0);
            this.tlpnlAdmin.Controls.Add(this.pnlActiveAdmins, 2, 0);
            this.tlpnlAdmin.Controls.Add(this.pnlinActiveAdmins, 3, 0);
            this.tlpnlAdmin.Controls.Add(this.pnlTotalSuperAdmins, 1, 0);
            this.tlpnlAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpnlAdmin.Location = new System.Drawing.Point(12, 12);
            this.tlpnlAdmin.Name = "tlpnlAdmin";
            this.tlpnlAdmin.RowCount = 1;
            this.tlpnlAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpnlAdmin.Size = new System.Drawing.Size(781, 141);
            this.tlpnlAdmin.TabIndex = 1;
            // 
            // pnlTotalAdmins
            // 
            this.pnlTotalAdmins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.pnlTotalAdmins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalAdmins.Controls.Add(this.lbladminValue);
            this.pnlTotalAdmins.Controls.Add(this.lblTotalAdmins);
            this.pnlTotalAdmins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTotalAdmins.Location = new System.Drawing.Point(15, 15);
            this.pnlTotalAdmins.Margin = new System.Windows.Forms.Padding(15);
            this.pnlTotalAdmins.Name = "pnlTotalAdmins";
            this.pnlTotalAdmins.Padding = new System.Windows.Forms.Padding(12);
            this.pnlTotalAdmins.Size = new System.Drawing.Size(165, 111);
            this.pnlTotalAdmins.TabIndex = 4;
            // 
            // lbladminValue
            // 
            this.lbladminValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbladminValue.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladminValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(66)))));
            this.lbladminValue.Location = new System.Drawing.Point(12, 42);
            this.lbladminValue.Name = "lbladminValue";
            this.lbladminValue.Size = new System.Drawing.Size(139, 55);
            this.lbladminValue.TabIndex = 0;
            this.lbladminValue.Text = "__";
            this.lbladminValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalAdmins
            // 
            this.lblTotalAdmins.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalAdmins.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAdmins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblTotalAdmins.Location = new System.Drawing.Point(12, 12);
            this.lblTotalAdmins.Name = "lblTotalAdmins";
            this.lblTotalAdmins.Size = new System.Drawing.Size(139, 30);
            this.lblTotalAdmins.TabIndex = 1;
            this.lblTotalAdmins.Text = "TOTAL ADMINS";
            this.lblTotalAdmins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlActiveAdmins
            // 
            this.pnlActiveAdmins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.pnlActiveAdmins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlActiveAdmins.Controls.Add(this.lblActAdminsValue);
            this.pnlActiveAdmins.Controls.Add(this.lblActAdmins);
            this.pnlActiveAdmins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlActiveAdmins.Location = new System.Drawing.Point(405, 15);
            this.pnlActiveAdmins.Margin = new System.Windows.Forms.Padding(15);
            this.pnlActiveAdmins.Name = "pnlActiveAdmins";
            this.pnlActiveAdmins.Padding = new System.Windows.Forms.Padding(12);
            this.pnlActiveAdmins.Size = new System.Drawing.Size(165, 111);
            this.pnlActiveAdmins.TabIndex = 0;
            // 
            // lblActAdminsValue
            // 
            this.lblActAdminsValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActAdminsValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblActAdminsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.lblActAdminsValue.Location = new System.Drawing.Point(12, 42);
            this.lblActAdminsValue.Name = "lblActAdminsValue";
            this.lblActAdminsValue.Size = new System.Drawing.Size(139, 55);
            this.lblActAdminsValue.TabIndex = 0;
            this.lblActAdminsValue.Text = "__";
            this.lblActAdminsValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblActAdmins
            // 
            this.lblActAdmins.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblActAdmins.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActAdmins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblActAdmins.Location = new System.Drawing.Point(12, 12);
            this.lblActAdmins.Name = "lblActAdmins";
            this.lblActAdmins.Size = new System.Drawing.Size(139, 30);
            this.lblActAdmins.TabIndex = 1;
            this.lblActAdmins.Text = "ACTIVE ADMINS";
            this.lblActAdmins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlinActiveAdmins
            // 
            this.pnlinActiveAdmins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.pnlinActiveAdmins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlinActiveAdmins.Controls.Add(this.lblinActAdminsValue);
            this.pnlinActiveAdmins.Controls.Add(this.lblinActAdmins);
            this.pnlinActiveAdmins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlinActiveAdmins.Location = new System.Drawing.Point(600, 15);
            this.pnlinActiveAdmins.Margin = new System.Windows.Forms.Padding(15);
            this.pnlinActiveAdmins.Name = "pnlinActiveAdmins";
            this.pnlinActiveAdmins.Padding = new System.Windows.Forms.Padding(12);
            this.pnlinActiveAdmins.Size = new System.Drawing.Size(166, 111);
            this.pnlinActiveAdmins.TabIndex = 1;
            // 
            // lblinActAdminsValue
            // 
            this.lblinActAdminsValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblinActAdminsValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblinActAdminsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(207)))), ((int)(((byte)(142)))));
            this.lblinActAdminsValue.Location = new System.Drawing.Point(12, 42);
            this.lblinActAdminsValue.Name = "lblinActAdminsValue";
            this.lblinActAdminsValue.Size = new System.Drawing.Size(140, 55);
            this.lblinActAdminsValue.TabIndex = 0;
            this.lblinActAdminsValue.Text = "__";
            this.lblinActAdminsValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblinActAdmins
            // 
            this.lblinActAdmins.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblinActAdmins.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinActAdmins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblinActAdmins.Location = new System.Drawing.Point(12, 12);
            this.lblinActAdmins.Name = "lblinActAdmins";
            this.lblinActAdmins.Size = new System.Drawing.Size(140, 30);
            this.lblinActAdmins.TabIndex = 1;
            this.lblinActAdmins.Text = "INACTIVE ADMINS";
            this.lblinActAdmins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTotalSuperAdmins
            // 
            this.pnlTotalSuperAdmins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.pnlTotalSuperAdmins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalSuperAdmins.Controls.Add(this.lblsuperAdminValue);
            this.pnlTotalSuperAdmins.Controls.Add(this.lblTotalSuperAdmin);
            this.pnlTotalSuperAdmins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTotalSuperAdmins.Location = new System.Drawing.Point(210, 15);
            this.pnlTotalSuperAdmins.Margin = new System.Windows.Forms.Padding(15);
            this.pnlTotalSuperAdmins.Name = "pnlTotalSuperAdmins";
            this.pnlTotalSuperAdmins.Padding = new System.Windows.Forms.Padding(12);
            this.pnlTotalSuperAdmins.Size = new System.Drawing.Size(165, 111);
            this.pnlTotalSuperAdmins.TabIndex = 2;
            // 
            // lblsuperAdminValue
            // 
            this.lblsuperAdminValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblsuperAdminValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblsuperAdminValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(111)))), ((int)(((byte)(255)))));
            this.lblsuperAdminValue.Location = new System.Drawing.Point(12, 42);
            this.lblsuperAdminValue.Name = "lblsuperAdminValue";
            this.lblsuperAdminValue.Size = new System.Drawing.Size(139, 55);
            this.lblsuperAdminValue.TabIndex = 0;
            this.lblsuperAdminValue.Text = "__";
            this.lblsuperAdminValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalSuperAdmin
            // 
            this.lblTotalSuperAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalSuperAdmin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSuperAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblTotalSuperAdmin.Location = new System.Drawing.Point(12, 12);
            this.lblTotalSuperAdmin.Name = "lblTotalSuperAdmin";
            this.lblTotalSuperAdmin.Size = new System.Drawing.Size(139, 30);
            this.lblTotalSuperAdmin.TabIndex = 1;
            this.lblTotalSuperAdmin.Text = "SUPER ADMINS";
            this.lblTotalSuperAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSuperAdmin
            // 
            this.pnlSuperAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(26)))));
            this.pnlSuperAdmin.Controls.Add(this.btnToggleAdmin);
            this.pnlSuperAdmin.Controls.Add(this.btnUpdateAdmin);
            this.pnlSuperAdmin.Controls.Add(this.btnAddAdmin);
            this.pnlSuperAdmin.Controls.Add(this.pnladmin);
            this.pnlSuperAdmin.Controls.Add(this.dgvAdmins);
            this.pnlSuperAdmin.Controls.Add(this.pnlHeader);
            this.pnlSuperAdmin.Location = new System.Drawing.Point(199, 2);
            this.pnlSuperAdmin.Name = "pnlSuperAdmin";
            this.pnlSuperAdmin.Size = new System.Drawing.Size(805, 599);
            this.pnlSuperAdmin.TabIndex = 9;
            // 
            // btnToggleAdmin
            // 
            this.btnToggleAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.btnToggleAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToggleAdmin.FlatAppearance.BorderSize = 0;
            this.btnToggleAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btnToggleAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btnToggleAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleAdmin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggleAdmin.ForeColor = System.Drawing.Color.White;
            this.btnToggleAdmin.IconChar = FontAwesome.Sharp.IconChar.ToggleOn;
            this.btnToggleAdmin.IconColor = System.Drawing.Color.White;
            this.btnToggleAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnToggleAdmin.IconSize = 18;
            this.btnToggleAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToggleAdmin.Location = new System.Drawing.Point(341, 219);
            this.btnToggleAdmin.Name = "btnToggleAdmin";
            this.btnToggleAdmin.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnToggleAdmin.Size = new System.Drawing.Size(136, 41);
            this.btnToggleAdmin.TabIndex = 27;
            this.btnToggleAdmin.Text = "Toggle Status";
            this.btnToggleAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnToggleAdmin.UseVisualStyleBackColor = false;
            this.btnToggleAdmin.Click += new System.EventHandler(this.btnToggleAdmin_Click);
            // 
            // btnUpdateAdmin
            // 
            this.btnUpdateAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnUpdateAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateAdmin.FlatAppearance.BorderSize = 0;
            this.btnUpdateAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btnUpdateAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btnUpdateAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateAdmin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAdmin.ForeColor = System.Drawing.Color.White;
            this.btnUpdateAdmin.IconChar = FontAwesome.Sharp.IconChar.PenAlt;
            this.btnUpdateAdmin.IconColor = System.Drawing.Color.White;
            this.btnUpdateAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdateAdmin.IconSize = 18;
            this.btnUpdateAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateAdmin.Location = new System.Drawing.Point(184, 219);
            this.btnUpdateAdmin.Name = "btnUpdateAdmin";
            this.btnUpdateAdmin.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUpdateAdmin.Size = new System.Drawing.Size(136, 41);
            this.btnUpdateAdmin.TabIndex = 26;
            this.btnUpdateAdmin.Text = "Update Admin";
            this.btnUpdateAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateAdmin.UseVisualStyleBackColor = false;
            this.btnUpdateAdmin.Click += new System.EventHandler(this.btnUpdateAdmin_Click);
            // 
            // btnAddAdmin
            // 
            this.btnAddAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnAddAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAdmin.FlatAppearance.BorderSize = 0;
            this.btnAddAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btnAddAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btnAddAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAdmin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAddAdmin.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnAddAdmin.IconColor = System.Drawing.Color.White;
            this.btnAddAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddAdmin.IconSize = 20;
            this.btnAddAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAdmin.Location = new System.Drawing.Point(27, 219);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAddAdmin.Size = new System.Drawing.Size(136, 41);
            this.btnAddAdmin.TabIndex = 25;
            this.btnAddAdmin.Text = "Add Admin";
            this.btnAddAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddAdmin.UseVisualStyleBackColor = false;
            this.btnAddAdmin.Click += new System.EventHandler(this.btnAddAdmin_Click);
            // 
            // pnlStudent
            // 
            this.pnlStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(26)))));
            this.pnlStudent.Controls.Add(this.btntoggleStd);
            this.pnlStudent.Controls.Add(this.pnlstd);
            this.pnlStudent.Controls.Add(this.dgvStudents);
            this.pnlStudent.Controls.Add(this.panel3);
            this.pnlStudent.Location = new System.Drawing.Point(199, 2);
            this.pnlStudent.Name = "pnlStudent";
            this.pnlStudent.Size = new System.Drawing.Size(805, 598);
            this.pnlStudent.TabIndex = 13;
            // 
            // btntoggleStd
            // 
            this.btntoggleStd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.btntoggleStd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntoggleStd.FlatAppearance.BorderSize = 0;
            this.btntoggleStd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btntoggleStd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btntoggleStd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntoggleStd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntoggleStd.ForeColor = System.Drawing.Color.White;
            this.btntoggleStd.IconChar = FontAwesome.Sharp.IconChar.ToggleOn;
            this.btntoggleStd.IconColor = System.Drawing.Color.White;
            this.btntoggleStd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btntoggleStd.IconSize = 18;
            this.btntoggleStd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntoggleStd.Location = new System.Drawing.Point(27, 226);
            this.btntoggleStd.Name = "btntoggleStd";
            this.btntoggleStd.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btntoggleStd.Size = new System.Drawing.Size(136, 41);
            this.btntoggleStd.TabIndex = 31;
            this.btntoggleStd.Text = "Toggle Status";
            this.btntoggleStd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btntoggleStd.UseVisualStyleBackColor = false;
            this.btntoggleStd.Click += new System.EventHandler(this.btntoggleStd_Click);
            // 
            // pnlstd
            // 
            this.pnlstd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(26)))));
            this.pnlstd.Controls.Add(this.tlpnlStudents);
            this.pnlstd.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlstd.Location = new System.Drawing.Point(0, 50);
            this.pnlstd.Name = "pnlstd";
            this.pnlstd.Padding = new System.Windows.Forms.Padding(12, 12, 12, 0);
            this.pnlstd.Size = new System.Drawing.Size(805, 164);
            this.pnlstd.TabIndex = 14;
            // 
            // tlpnlStudents
            // 
            this.tlpnlStudents.ColumnCount = 3;
            this.tlpnlStudents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpnlStudents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpnlStudents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpnlStudents.Controls.Add(this.pnlActiveStudents, 1, 0);
            this.tlpnlStudents.Controls.Add(this.pnlTotalSudents, 0, 0);
            this.tlpnlStudents.Controls.Add(this.pnlnactiveStudents, 2, 0);
            this.tlpnlStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpnlStudents.Location = new System.Drawing.Point(12, 12);
            this.tlpnlStudents.Name = "tlpnlStudents";
            this.tlpnlStudents.RowCount = 1;
            this.tlpnlStudents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpnlStudents.Size = new System.Drawing.Size(781, 152);
            this.tlpnlStudents.TabIndex = 0;
            // 
            // pnlActiveStudents
            // 
            this.pnlActiveStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.pnlActiveStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlActiveStudents.Controls.Add(this.lblactstdValue);
            this.pnlActiveStudents.Controls.Add(this.lblactstd);
            this.pnlActiveStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlActiveStudents.Location = new System.Drawing.Point(275, 15);
            this.pnlActiveStudents.Margin = new System.Windows.Forms.Padding(15);
            this.pnlActiveStudents.Name = "pnlActiveStudents";
            this.pnlActiveStudents.Padding = new System.Windows.Forms.Padding(12);
            this.pnlActiveStudents.Size = new System.Drawing.Size(230, 122);
            this.pnlActiveStudents.TabIndex = 2;
            // 
            // lblactstdValue
            // 
            this.lblactstdValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblactstdValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblactstdValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.lblactstdValue.Location = new System.Drawing.Point(12, 42);
            this.lblactstdValue.Name = "lblactstdValue";
            this.lblactstdValue.Size = new System.Drawing.Size(204, 66);
            this.lblactstdValue.TabIndex = 0;
            this.lblactstdValue.Text = "3";
            this.lblactstdValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblactstd
            // 
            this.lblactstd.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblactstd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblactstd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblactstd.Location = new System.Drawing.Point(12, 12);
            this.lblactstd.Name = "lblactstd";
            this.lblactstd.Size = new System.Drawing.Size(204, 30);
            this.lblactstd.TabIndex = 1;
            this.lblactstd.Text = "ACTIVE STUDENTS";
            this.lblactstd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTotalSudents
            // 
            this.pnlTotalSudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.pnlTotalSudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalSudents.Controls.Add(this.lbl_stdValue);
            this.pnlTotalSudents.Controls.Add(this.lblstd);
            this.pnlTotalSudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTotalSudents.Location = new System.Drawing.Point(15, 15);
            this.pnlTotalSudents.Margin = new System.Windows.Forms.Padding(15);
            this.pnlTotalSudents.Name = "pnlTotalSudents";
            this.pnlTotalSudents.Padding = new System.Windows.Forms.Padding(12);
            this.pnlTotalSudents.Size = new System.Drawing.Size(230, 122);
            this.pnlTotalSudents.TabIndex = 4;
            // 
            // lbl_stdValue
            // 
            this.lbl_stdValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_stdValue.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stdValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(111)))), ((int)(((byte)(255)))));
            this.lbl_stdValue.Location = new System.Drawing.Point(12, 42);
            this.lbl_stdValue.Name = "lbl_stdValue";
            this.lbl_stdValue.Size = new System.Drawing.Size(204, 66);
            this.lbl_stdValue.TabIndex = 0;
            this.lbl_stdValue.Text = "5";
            this.lbl_stdValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblstd
            // 
            this.lblstd.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblstd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblstd.Location = new System.Drawing.Point(12, 12);
            this.lblstd.Name = "lblstd";
            this.lblstd.Size = new System.Drawing.Size(204, 30);
            this.lblstd.TabIndex = 1;
            this.lblstd.Text = "TOTAL STUDENTS";
            this.lblstd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlnactiveStudents
            // 
            this.pnlnactiveStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.pnlnactiveStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlnactiveStudents.Controls.Add(this.lblinactstdValue);
            this.pnlnactiveStudents.Controls.Add(this.lblinactstd);
            this.pnlnactiveStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlnactiveStudents.Location = new System.Drawing.Point(535, 15);
            this.pnlnactiveStudents.Margin = new System.Windows.Forms.Padding(15);
            this.pnlnactiveStudents.Name = "pnlnactiveStudents";
            this.pnlnactiveStudents.Padding = new System.Windows.Forms.Padding(12);
            this.pnlnactiveStudents.Size = new System.Drawing.Size(231, 122);
            this.pnlnactiveStudents.TabIndex = 0;
            // 
            // lblinactstdValue
            // 
            this.lblinactstdValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblinactstdValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblinactstdValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(207)))), ((int)(((byte)(142)))));
            this.lblinactstdValue.Location = new System.Drawing.Point(12, 42);
            this.lblinactstdValue.Name = "lblinactstdValue";
            this.lblinactstdValue.Size = new System.Drawing.Size(205, 66);
            this.lblinactstdValue.TabIndex = 0;
            this.lblinactstdValue.Text = "215";
            this.lblinactstdValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblinactstd
            // 
            this.lblinactstd.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblinactstd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinactstd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblinactstd.Location = new System.Drawing.Point(12, 12);
            this.lblinactstd.Name = "lblinactstd";
            this.lblinactstd.Size = new System.Drawing.Size(205, 30);
            this.lblinactstd.TabIndex = 1;
            this.lblinactstd.Text = "INACTIVE STUDENTS";
            this.lblinactstd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(201)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            this.dgvStudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.dgvStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvStudents.ColumnHeadersHeight = 38;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(201)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudents.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvStudents.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(47)))));
            this.dgvStudents.Location = new System.Drawing.Point(-1, 276);
            this.dgvStudents.MultiSelect = false;
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RowHeadersWidth = 35;
            this.dgvStudents.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(805, 320);
            this.dgvStudents.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(805, 50);
            this.panel3.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Manage Students";
            // 
            // pnlHome
            // 
            this.pnlHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(26)))));
            this.pnlHome.Controls.Add(this.lblGridTitle);
            this.pnlHome.Controls.Add(this.pnlHomeCards);
            this.pnlHome.Controls.Add(this.dgv_Users);
            this.pnlHome.Controls.Add(this.panel9);
            this.pnlHome.Location = new System.Drawing.Point(199, 2);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(805, 598);
            this.pnlHome.TabIndex = 14;
            // 
            // lblGridTitle
            // 
            this.lblGridTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblGridTitle.Location = new System.Drawing.Point(4, 226);
            this.lblGridTitle.Name = "lblGridTitle";
            this.lblGridTitle.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.lblGridTitle.Size = new System.Drawing.Size(99, 23);
            this.lblGridTitle.TabIndex = 15;
            this.lblGridTitle.Text = "USERS VIEW";
            this.lblGridTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlHomeCards
            // 
            this.pnlHomeCards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(26)))));
            this.pnlHomeCards.Controls.Add(this.tlpnlHomeCards);
            this.pnlHomeCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHomeCards.Location = new System.Drawing.Point(0, 56);
            this.pnlHomeCards.Name = "pnlHomeCards";
            this.pnlHomeCards.Padding = new System.Windows.Forms.Padding(12, 12, 12, 0);
            this.pnlHomeCards.Size = new System.Drawing.Size(805, 153);
            this.pnlHomeCards.TabIndex = 11;
            // 
            // tlpnlHomeCards
            // 
            this.tlpnlHomeCards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(26)))));
            this.tlpnlHomeCards.ColumnCount = 3;
            this.tlpnlHomeCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpnlHomeCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpnlHomeCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpnlHomeCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpnlHomeCards.Controls.Add(this.panel4, 0, 0);
            this.tlpnlHomeCards.Controls.Add(this.panel6, 2, 0);
            this.tlpnlHomeCards.Controls.Add(this.panel8, 1, 0);
            this.tlpnlHomeCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpnlHomeCards.Location = new System.Drawing.Point(12, 12);
            this.tlpnlHomeCards.Name = "tlpnlHomeCards";
            this.tlpnlHomeCards.RowCount = 1;
            this.tlpnlHomeCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpnlHomeCards.Size = new System.Drawing.Size(781, 141);
            this.tlpnlHomeCards.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblTotalUsersValue);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(15, 15);
            this.panel4.Margin = new System.Windows.Forms.Padding(15);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(12);
            this.panel4.Size = new System.Drawing.Size(230, 111);
            this.panel4.TabIndex = 4;
            // 
            // lblTotalUsersValue
            // 
            this.lblTotalUsersValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalUsersValue.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalUsersValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(111)))), ((int)(((byte)(255)))));
            this.lblTotalUsersValue.Location = new System.Drawing.Point(12, 42);
            this.lblTotalUsersValue.Name = "lblTotalUsersValue";
            this.lblTotalUsersValue.Size = new System.Drawing.Size(204, 55);
            this.lblTotalUsersValue.TabIndex = 0;
            this.lblTotalUsersValue.Text = "—";
            this.lblTotalUsersValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.label12.Location = new System.Drawing.Point(12, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(204, 30);
            this.label12.TabIndex = 1;
            this.label12.Text = "TOTAL USERS";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.lblInactiveUsersValue);
            this.panel6.Controls.Add(this.label16);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(535, 15);
            this.panel6.Margin = new System.Windows.Forms.Padding(15);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(12);
            this.panel6.Size = new System.Drawing.Size(231, 111);
            this.panel6.TabIndex = 0;
            // 
            // lblInactiveUsersValue
            // 
            this.lblInactiveUsersValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInactiveUsersValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblInactiveUsersValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(207)))), ((int)(((byte)(142)))));
            this.lblInactiveUsersValue.Location = new System.Drawing.Point(12, 42);
            this.lblInactiveUsersValue.Name = "lblInactiveUsersValue";
            this.lblInactiveUsersValue.Size = new System.Drawing.Size(205, 55);
            this.lblInactiveUsersValue.TabIndex = 0;
            this.lblInactiveUsersValue.Text = "—";
            this.lblInactiveUsersValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Dock = System.Windows.Forms.DockStyle.Top;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.label16.Location = new System.Drawing.Point(12, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(205, 30);
            this.label16.TabIndex = 1;
            this.label16.Text = "INACTIVE USERS";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.lblActiveUsersValue);
            this.panel8.Controls.Add(this.label23);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(275, 15);
            this.panel8.Margin = new System.Windows.Forms.Padding(15);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(12);
            this.panel8.Size = new System.Drawing.Size(230, 111);
            this.panel8.TabIndex = 2;
            // 
            // lblActiveUsersValue
            // 
            this.lblActiveUsersValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActiveUsersValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblActiveUsersValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.lblActiveUsersValue.Location = new System.Drawing.Point(12, 42);
            this.lblActiveUsersValue.Name = "lblActiveUsersValue";
            this.lblActiveUsersValue.Size = new System.Drawing.Size(204, 55);
            this.lblActiveUsersValue.TabIndex = 0;
            this.lblActiveUsersValue.Text = "—";
            this.lblActiveUsersValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.Dock = System.Windows.Forms.DockStyle.Top;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.label23.Location = new System.Drawing.Point(12, 12);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(204, 30);
            this.label23.TabIndex = 1;
            this.label23.Text = "ACTIVE USERS";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_Users
            // 
            this.dgv_Users.AllowUserToAddRows = false;
            this.dgv_Users.AllowUserToDeleteRows = false;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(201)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Users.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_Users.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Users.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.dgv_Users.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgv_Users.ColumnHeadersHeight = 38;
            this.dgv_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(201)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Users.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgv_Users.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(47)))));
            this.dgv_Users.Location = new System.Drawing.Point(0, 260);
            this.dgv_Users.MultiSelect = false;
            this.dgv_Users.Name = "dgv_Users";
            this.dgv_Users.ReadOnly = true;
            this.dgv_Users.RowHeadersVisible = false;
            this.dgv_Users.RowHeadersWidth = 35;
            this.dgv_Users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Users.Size = new System.Drawing.Size(805, 338);
            this.dgv_Users.TabIndex = 7;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.panel9.Controls.Add(this.lblMainTitle);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(805, 56);
            this.panel9.TabIndex = 6;
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblMainTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblMainTitle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblMainTitle.Location = new System.Drawing.Point(23, 11);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(500, 34);
            this.lblMainTitle.TabIndex = 1;
            this.lblMainTitle.Text = "Welcome, Admin!";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.panel5.Controls.Add(this.label7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(805, 50);
            this.panel5.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.label7.Location = new System.Drawing.Point(12, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Manage Problems";
            // 
            // ProblemCards
            // 
            this.ProblemCards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(26)))));
            this.ProblemCards.Controls.Add(this.tableLayoutPanel1);
            this.ProblemCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProblemCards.Location = new System.Drawing.Point(0, 50);
            this.ProblemCards.Name = "ProblemCards";
            this.ProblemCards.Padding = new System.Windows.Forms.Padding(12, 12, 12, 0);
            this.ProblemCards.Size = new System.Drawing.Size(805, 165);
            this.ProblemCards.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(26)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.pnlinActProb, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlActProb, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlTotalProb, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(781, 153);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // pnlinActProb
            // 
            this.pnlinActProb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.pnlinActProb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlinActProb.Controls.Add(this.lblInActProbValue);
            this.pnlinActProb.Controls.Add(this.lblInActProb);
            this.pnlinActProb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlinActProb.Location = new System.Drawing.Point(535, 15);
            this.pnlinActProb.Margin = new System.Windows.Forms.Padding(15);
            this.pnlinActProb.Name = "pnlinActProb";
            this.pnlinActProb.Padding = new System.Windows.Forms.Padding(12);
            this.pnlinActProb.Size = new System.Drawing.Size(231, 123);
            this.pnlinActProb.TabIndex = 4;
            // 
            // lblInActProbValue
            // 
            this.lblInActProbValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInActProbValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblInActProbValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(207)))), ((int)(((byte)(142)))));
            this.lblInActProbValue.Location = new System.Drawing.Point(12, 35);
            this.lblInActProbValue.Name = "lblInActProbValue";
            this.lblInActProbValue.Size = new System.Drawing.Size(205, 74);
            this.lblInActProbValue.TabIndex = 0;
            this.lblInActProbValue.Text = "0";
            this.lblInActProbValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInActProb
            // 
            this.lblInActProb.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInActProb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInActProb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblInActProb.Location = new System.Drawing.Point(12, 12);
            this.lblInActProb.Name = "lblInActProb";
            this.lblInActProb.Size = new System.Drawing.Size(205, 23);
            this.lblInActProb.TabIndex = 1;
            this.lblInActProb.Text = "INACTIVE PROBLEMS";
            this.lblInActProb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlActProb
            // 
            this.pnlActProb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.pnlActProb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlActProb.Controls.Add(this.lblActProbValue);
            this.pnlActProb.Controls.Add(this.lblActProb);
            this.pnlActProb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlActProb.Location = new System.Drawing.Point(275, 15);
            this.pnlActProb.Margin = new System.Windows.Forms.Padding(15);
            this.pnlActProb.Name = "pnlActProb";
            this.pnlActProb.Padding = new System.Windows.Forms.Padding(12);
            this.pnlActProb.Size = new System.Drawing.Size(230, 123);
            this.pnlActProb.TabIndex = 3;
            // 
            // lblActProbValue
            // 
            this.lblActProbValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActProbValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblActProbValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.lblActProbValue.Location = new System.Drawing.Point(12, 35);
            this.lblActProbValue.Name = "lblActProbValue";
            this.lblActProbValue.Size = new System.Drawing.Size(204, 74);
            this.lblActProbValue.TabIndex = 0;
            this.lblActProbValue.Text = "0";
            this.lblActProbValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblActProb
            // 
            this.lblActProb.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblActProb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActProb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblActProb.Location = new System.Drawing.Point(12, 12);
            this.lblActProb.Name = "lblActProb";
            this.lblActProb.Size = new System.Drawing.Size(204, 23);
            this.lblActProb.TabIndex = 1;
            this.lblActProb.Text = "ACTIVE PROBLEMS";
            this.lblActProb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTotalProb
            // 
            this.pnlTotalProb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.pnlTotalProb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalProb.Controls.Add(this.lblTotalProbValue);
            this.pnlTotalProb.Controls.Add(this.lblTotalProb);
            this.pnlTotalProb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTotalProb.Location = new System.Drawing.Point(15, 15);
            this.pnlTotalProb.Margin = new System.Windows.Forms.Padding(15);
            this.pnlTotalProb.Name = "pnlTotalProb";
            this.pnlTotalProb.Padding = new System.Windows.Forms.Padding(12);
            this.pnlTotalProb.Size = new System.Drawing.Size(230, 123);
            this.pnlTotalProb.TabIndex = 1;
            // 
            // lblTotalProbValue
            // 
            this.lblTotalProbValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalProbValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTotalProbValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(111)))), ((int)(((byte)(255)))));
            this.lblTotalProbValue.Location = new System.Drawing.Point(12, 35);
            this.lblTotalProbValue.Name = "lblTotalProbValue";
            this.lblTotalProbValue.Size = new System.Drawing.Size(204, 74);
            this.lblTotalProbValue.TabIndex = 0;
            this.lblTotalProbValue.Text = "0";
            this.lblTotalProbValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalProb
            // 
            this.lblTotalProb.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalProb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblTotalProb.Location = new System.Drawing.Point(12, 12);
            this.lblTotalProb.Name = "lblTotalProb";
            this.lblTotalProb.Size = new System.Drawing.Size(204, 23);
            this.lblTotalProb.TabIndex = 1;
            this.lblTotalProb.Text = "TOTAL PROBLEMS";
            this.lblTotalProb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvProblems
            // 
            this.dgvProblems.AllowUserToAddRows = false;
            this.dgvProblems.AllowUserToDeleteRows = false;
            this.dgvProblems.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(201)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProblems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvProblems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProblems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProblems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.dgvProblems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProblems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvProblems.ColumnHeadersHeight = 38;
            this.dgvProblems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(201)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProblems.DefaultCellStyle = dataGridViewCellStyle19;
            this.dgvProblems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(47)))));
            this.dgvProblems.Location = new System.Drawing.Point(0, 292);
            this.dgvProblems.Name = "dgvProblems";
            this.dgvProblems.ReadOnly = true;
            this.dgvProblems.RowHeadersWidth = 35;
            this.dgvProblems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProblems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProblems.Size = new System.Drawing.Size(805, 307);
            this.dgvProblems.TabIndex = 12;
            // 
            // btnAddProb
            // 
            this.btnAddProb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnAddProb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProb.FlatAppearance.BorderSize = 0;
            this.btnAddProb.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btnAddProb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btnAddProb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProb.ForeColor = System.Drawing.Color.White;
            this.btnAddProb.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnAddProb.IconColor = System.Drawing.Color.White;
            this.btnAddProb.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddProb.IconSize = 20;
            this.btnAddProb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProb.Location = new System.Drawing.Point(26, 233);
            this.btnAddProb.Name = "btnAddProb";
            this.btnAddProb.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAddProb.Size = new System.Drawing.Size(136, 41);
            this.btnAddProb.TabIndex = 28;
            this.btnAddProb.Text = "Add Problem";
            this.btnAddProb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddProb.UseVisualStyleBackColor = false;
            this.btnAddProb.Click += new System.EventHandler(this.btnAddProb_Click);
            // 
            // btnUpdateProb
            // 
            this.btnUpdateProb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnUpdateProb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateProb.FlatAppearance.BorderSize = 0;
            this.btnUpdateProb.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btnUpdateProb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btnUpdateProb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateProb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProb.ForeColor = System.Drawing.Color.White;
            this.btnUpdateProb.IconChar = FontAwesome.Sharp.IconChar.PenAlt;
            this.btnUpdateProb.IconColor = System.Drawing.Color.White;
            this.btnUpdateProb.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdateProb.IconSize = 18;
            this.btnUpdateProb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateProb.Location = new System.Drawing.Point(180, 233);
            this.btnUpdateProb.Name = "btnUpdateProb";
            this.btnUpdateProb.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUpdateProb.Size = new System.Drawing.Size(151, 41);
            this.btnUpdateProb.TabIndex = 29;
            this.btnUpdateProb.Text = "Update Problem";
            this.btnUpdateProb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateProb.UseVisualStyleBackColor = false;
            this.btnUpdateProb.Click += new System.EventHandler(this.btnUpdateProb_Click);
            // 
            // btnToggleProb
            // 
            this.btnToggleProb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.btnToggleProb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToggleProb.FlatAppearance.BorderSize = 0;
            this.btnToggleProb.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btnToggleProb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btnToggleProb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleProb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggleProb.ForeColor = System.Drawing.Color.White;
            this.btnToggleProb.IconChar = FontAwesome.Sharp.IconChar.ToggleOn;
            this.btnToggleProb.IconColor = System.Drawing.Color.White;
            this.btnToggleProb.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnToggleProb.IconSize = 18;
            this.btnToggleProb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToggleProb.Location = new System.Drawing.Point(349, 233);
            this.btnToggleProb.Name = "btnToggleProb";
            this.btnToggleProb.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnToggleProb.Size = new System.Drawing.Size(136, 41);
            this.btnToggleProb.TabIndex = 30;
            this.btnToggleProb.Text = "Toggle Status";
            this.btnToggleProb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnToggleProb.UseVisualStyleBackColor = false;
            this.btnToggleProb.Click += new System.EventHandler(this.btnToggleProb_Click);
            // 
            // pnlProblems
            // 
            this.pnlProblems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(26)))));
            this.pnlProblems.Controls.Add(this.btnToggleProb);
            this.pnlProblems.Controls.Add(this.btnUpdateProb);
            this.pnlProblems.Controls.Add(this.btnAddProb);
            this.pnlProblems.Controls.Add(this.dgvProblems);
            this.pnlProblems.Controls.Add(this.ProblemCards);
            this.pnlProblems.Controls.Add(this.panel5);
            this.pnlProblems.Location = new System.Drawing.Point(199, 2);
            this.pnlProblems.Name = "pnlProblems";
            this.pnlProblems.Size = new System.Drawing.Size(805, 599);
            this.pnlProblems.TabIndex = 4;
            // 
            // AdminDashboardUI
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1004, 601);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlSuperAdmin);
            this.Controls.Add(this.pnlContest);
            this.Controls.Add(this.pnlProblems);
            this.Controls.Add(this.pnlsubmissions);
            this.Controls.Add(this.pnlStudent);
            this.Controls.Add(this.pnlHome);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminDashboardUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings — Profile";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebarLogo.ResumeLayout(false);
            this.pnlSidebarLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlContest.ResumeLayout(false);
            this.ContestCards.ResumeLayout(false);
            this.tlpContest.ResumeLayout(false);
            this.pnlinactContest.ResumeLayout(false);
            this.pnlTotalContest.ResumeLayout(false);
            this.pnlactContest.ResumeLayout(false);
            this.pnlUpcommingContest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContest)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.pnlsubmissions.ResumeLayout(false);
            this.pnlsubmissions.PerformLayout();
            this.pnlsubmissionsCards.ResumeLayout(false);
            this.tlpnlSubmission.ResumeLayout(false);
            this.pnlAccSub.ResumeLayout(false);
            this.pnlRegSub.ResumeLayout(false);
            this.pnlTotalSub.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubmissions)).EndInit();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmins)).EndInit();
            this.pnladmin.ResumeLayout(false);
            this.tlpnlAdmin.ResumeLayout(false);
            this.pnlTotalAdmins.ResumeLayout(false);
            this.pnlActiveAdmins.ResumeLayout(false);
            this.pnlinActiveAdmins.ResumeLayout(false);
            this.pnlTotalSuperAdmins.ResumeLayout(false);
            this.pnlSuperAdmin.ResumeLayout(false);
            this.pnlStudent.ResumeLayout(false);
            this.pnlstd.ResumeLayout(false);
            this.tlpnlStudents.ResumeLayout(false);
            this.pnlActiveStudents.ResumeLayout(false);
            this.pnlTotalSudents.ResumeLayout(false);
            this.pnlnactiveStudents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlHome.ResumeLayout(false);
            this.pnlHomeCards.ResumeLayout(false);
            this.tlpnlHomeCards.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Users)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ProblemCards.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlinActProb.ResumeLayout(false);
            this.pnlActProb.ResumeLayout(false);
            this.pnlTotalProb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProblems)).EndInit();
            this.pnlProblems.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Panel pnlContest;
        private System.Windows.Forms.DataGridView dgvContest;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlsubmissions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlsubmissionsCards;
        private System.Windows.Forms.DataGridView dgvSubmissions;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label17;
        private Panel ContestCards;
        private TableLayoutPanel tlpnlSubmission;
        private Panel pnlAccSub;
        private Label AccSubValue;
        private Label label15;
        private Panel pnlRegSub;
        private Label RegSubValue;
        private Label label11;
        private Panel pnlTotalSub;
        private Label totalsubValue;
        private Label lblSubmissions;
        private Panel pnlHeader;
        private DataGridView dgvAdmins;
        private Panel pnladmin;
        private TableLayoutPanel tlpnlAdmin;
        private Panel pnlTotalAdmins;
        private Label lbladminValue;
        private Label lblTotalAdmins;
        private Panel pnlActiveAdmins;
        private Label lblActAdminsValue;
        private Label lblActAdmins;
        private Panel pnlinActiveAdmins;
        private Label lblinActAdminsValue;
        private Label lblinActAdmins;
        private Panel pnlTotalSuperAdmins;
        private Label lblsuperAdminValue;
        private Label lblTotalSuperAdmin;
        private Panel pnlSuperAdmin;
        private TableLayoutPanel tlpContest;
        private Panel pnlinactContest;
        private Label lblInActcontestValue;
        private Label label3;
        private Panel pnlTotalContest;
        private Label lblTotalContestValue;
        private Label label8;
        private Panel pnlUpcommingContest;
        private Label lblUpcommingContestValue;
        private Label label4;
        private Panel pnlactContest;
        private Label lblActContestValue;
        private Label label5;
        private Panel pnlStudent;
        private Panel pnlstd;
        private TableLayoutPanel tlpnlStudents;
        private Panel pnlActiveStudents;
        private Label lblactstdValue;
        private Label lblactstd;
        private Panel pnlTotalSudents;
        private Label lbl_stdValue;
        private Label lblstd;
        private Panel pnlnactiveStudents;
        private Label lblinactstdValue;
        private Label lblinactstd;
        private DataGridView dgvStudents;
        private Panel panel3;
        private Label label2;
        private Label lblSuperAdmin;
        private FontAwesome.Sharp.IconButton btn_Home;
        private FontAwesome.Sharp.IconButton btn_students;
        private FontAwesome.Sharp.IconButton btn_problems;
        private FontAwesome.Sharp.IconButton btn_contests;
        private FontAwesome.Sharp.IconButton btnSubmissions;
        private FontAwesome.Sharp.IconButton btnReport;
        private FontAwesome.Sharp.IconButton btn_Settings;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnAddAdmin;
        private FontAwesome.Sharp.IconButton btnUpdateAdmin;
        private FontAwesome.Sharp.IconButton btnToggleAdmin;
        private FontAwesome.Sharp.IconButton btnAddContest;
        private FontAwesome.Sharp.IconButton btnUpdContest;
        private FontAwesome.Sharp.IconButton btntoggleStd;
        private Panel pnlHome;
        private Panel pnlHomeCards;
        private TableLayoutPanel tlpnlHomeCards;
        private Panel panel4;
        private Label lblTotalUsersValue;
        private Label label12;
        private Panel panel6;
        private Label lblInactiveUsersValue;
        private Label label16;
        private Panel panel8;
        private Label lblActiveUsersValue;
        private Label label23;
        private DataGridView dgv_Users;
        private Panel panel9;
        private Label lblMainTitle;
        private FontAwesome.Sharp.IconButton btn_Admin;
        private Panel pnlSidebarLogo;
        private PictureBox picLogo;
        private Label lblAppSub;
        private Label lblAppName;
        private Panel panel5;
        private Label label7;
        private Panel ProblemCards;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel pnlinActProb;
        private Label lblInActProbValue;
        private Label lblInActProb;
        private Panel pnlActProb;
        private Label lblActProbValue;
        private Label lblActProb;
        private Panel pnlTotalProb;
        private Label lblTotalProbValue;
        private Label lblTotalProb;
        private DataGridView dgvProblems;
        private FontAwesome.Sharp.IconButton btnAddProb;
        private FontAwesome.Sharp.IconButton btnUpdateProb;
        private FontAwesome.Sharp.IconButton btnToggleProb;
        private Panel pnlProblems;
        private Label lblGridTitle;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}