using System.Windows.Forms;

namespace SQL_Judge_System.UI
{
    partial class AdminDashboardUI
    {
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btn_students;
        private System.Windows.Forms.Button btnLogout;

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle53 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle54 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle55 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle56 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle57 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle58 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle59 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle60 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle61 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle62 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle63 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle64 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle65 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSubmissions = new System.Windows.Forms.Button();
            this.btnContestLeaderboard = new System.Windows.Forms.Button();
            this.btn_contests = new System.Windows.Forms.Button();
            this.btnTestCases = new System.Windows.Forms.Button();
            this.btn_problems = new System.Windows.Forms.Button();
            this.btn_students = new System.Windows.Forms.Button();
            this.btn_Admin = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.pnlProblems = new System.Windows.Forms.Panel();
            this.dgvProblems = new System.Windows.Forms.DataGridView();
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
            this.btnAddProb = new System.Windows.Forms.Button();
            this.btnUpdateProb = new System.Windows.Forms.Button();
            this.btnToggleProb = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlContest = new System.Windows.Forms.Panel();
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
            this.btnAddContest = new System.Windows.Forms.Button();
            this.btnUpdContest = new System.Windows.Forms.Button();
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
            this.pnlTestCases = new System.Windows.Forms.Panel();
            this.btnAddTestCase = new System.Windows.Forms.Button();
            this.btnUpdateTestCase = new System.Windows.Forms.Button();
            this.btnToggleTestCase = new System.Windows.Forms.Button();
            this.pnlTestCaseCards = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlInActTestCases = new System.Windows.Forms.Panel();
            this.lblInActiveTestCases = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pnlActTestCases = new System.Windows.Forms.Panel();
            this.lblActTestCases = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.pnlTotalTestCase = new System.Windows.Forms.Panel();
            this.lbltotalTestCases = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvTestCases = new System.Windows.Forms.DataGridView();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.dgvAdmins = new System.Windows.Forms.DataGridView();
            this.pnladmin = new System.Windows.Forms.Panel();
            this.tlpnlAdmin = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTotalAdmins = new System.Windows.Forms.Panel();
            this.lbladminValue = new System.Windows.Forms.Label();
            this.lblTotalAdmins = new System.Windows.Forms.Label();
            this.pnlTotalProblems = new System.Windows.Forms.Panel();
            this.lblProblemValue = new System.Windows.Forms.Label();
            this.lblTotalProblems = new System.Windows.Forms.Label();
            this.pnlTotalContests = new System.Windows.Forms.Panel();
            this.lblContestValue = new System.Windows.Forms.Label();
            this.lblTotalContests = new System.Windows.Forms.Label();
            this.pnlTotalStudents = new System.Windows.Forms.Panel();
            this.lblStdValue = new System.Windows.Forms.Label();
            this.lblTotalStd = new System.Windows.Forms.Label();
            this.btnToggleAdmin = new System.Windows.Forms.Button();
            this.btnUpdateAdmin = new System.Windows.Forms.Button();
            this.btnAddAdmin = new System.Windows.Forms.Button();
            this.pnlSuperAdmin = new System.Windows.Forms.Panel();
            this.pnlStudent = new System.Windows.Forms.Panel();
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
            this.btntoggleStd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.pnlSidebar.SuspendLayout();
            this.pnlProblems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProblems)).BeginInit();
            this.ProblemCards.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlinActProb.SuspendLayout();
            this.pnlActProb.SuspendLayout();
            this.pnlTotalProb.SuspendLayout();
            this.panel5.SuspendLayout();
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
            this.pnlTestCases.SuspendLayout();
            this.pnlTestCaseCards.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnlInActTestCases.SuspendLayout();
            this.pnlActTestCases.SuspendLayout();
            this.pnlTotalTestCase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestCases)).BeginInit();
            this.panel17.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmins)).BeginInit();
            this.pnladmin.SuspendLayout();
            this.tlpnlAdmin.SuspendLayout();
            this.pnlTotalAdmins.SuspendLayout();
            this.pnlTotalProblems.SuspendLayout();
            this.pnlTotalContests.SuspendLayout();
            this.pnlTotalStudents.SuspendLayout();
            this.pnlSuperAdmin.SuspendLayout();
            this.pnlStudent.SuspendLayout();
            this.pnlstd.SuspendLayout();
            this.tlpnlStudents.SuspendLayout();
            this.pnlActiveStudents.SuspendLayout();
            this.pnlTotalSudents.SuspendLayout();
            this.pnlnactiveStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlSidebar.Controls.Add(this.btn_Settings);
            this.pnlSidebar.Controls.Add(this.btnReport);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.btnSubmissions);
            this.pnlSidebar.Controls.Add(this.btnContestLeaderboard);
            this.pnlSidebar.Controls.Add(this.btn_contests);
            this.pnlSidebar.Controls.Add(this.btnTestCases);
            this.pnlSidebar.Controls.Add(this.btn_problems);
            this.pnlSidebar.Controls.Add(this.btn_students);
            this.pnlSidebar.Controls.Add(this.btn_Admin);
            this.pnlSidebar.Controls.Add(this.btn_Home);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(200, 561);
            this.pnlSidebar.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 510);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 51);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSubmissions
            // 
            this.btnSubmissions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubmissions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmissions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmissions.ForeColor = System.Drawing.Color.White;
            this.btnSubmissions.Location = new System.Drawing.Point(0, 357);
            this.btnSubmissions.Name = "btnSubmissions";
            this.btnSubmissions.Size = new System.Drawing.Size(200, 51);
            this.btnSubmissions.TabIndex = 9;
            this.btnSubmissions.Text = "Submissions";
            this.btnSubmissions.Click += new System.EventHandler(this.btnSubmissions_Click);
            // 
            // btnContestLeaderboard
            // 
            this.btnContestLeaderboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContestLeaderboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContestLeaderboard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContestLeaderboard.ForeColor = System.Drawing.Color.White;
            this.btnContestLeaderboard.Location = new System.Drawing.Point(0, 306);
            this.btnContestLeaderboard.Name = "btnContestLeaderboard";
            this.btnContestLeaderboard.Size = new System.Drawing.Size(200, 51);
            this.btnContestLeaderboard.TabIndex = 8;
            this.btnContestLeaderboard.Text = "Contests Leaderboard";
            this.btnContestLeaderboard.Click += new System.EventHandler(this.btnContestLeaderboard_Click);
            // 
            // btn_contests
            // 
            this.btn_contests.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_contests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_contests.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_contests.ForeColor = System.Drawing.Color.White;
            this.btn_contests.Location = new System.Drawing.Point(0, 255);
            this.btn_contests.Name = "btn_contests";
            this.btn_contests.Size = new System.Drawing.Size(200, 51);
            this.btn_contests.TabIndex = 4;
            this.btn_contests.Text = "Manage Contests";
            this.btn_contests.Click += new System.EventHandler(this.btn_contests_Click);
            // 
            // btnTestCases
            // 
            this.btnTestCases.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTestCases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestCases.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestCases.ForeColor = System.Drawing.Color.White;
            this.btnTestCases.Location = new System.Drawing.Point(0, 204);
            this.btnTestCases.Name = "btnTestCases";
            this.btnTestCases.Size = new System.Drawing.Size(200, 51);
            this.btnTestCases.TabIndex = 6;
            this.btnTestCases.Text = "Manage Test Cases";
            this.btnTestCases.Click += new System.EventHandler(this.btnTestCases_Click);
            // 
            // btn_problems
            // 
            this.btn_problems.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_problems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_problems.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_problems.ForeColor = System.Drawing.Color.White;
            this.btn_problems.Location = new System.Drawing.Point(0, 153);
            this.btn_problems.Name = "btn_problems";
            this.btn_problems.Size = new System.Drawing.Size(200, 51);
            this.btn_problems.TabIndex = 3;
            this.btn_problems.Text = "Manage Problems";
            this.btn_problems.Click += new System.EventHandler(this.btn_problems_Click);
            // 
            // btn_students
            // 
            this.btn_students.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_students.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_students.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_students.ForeColor = System.Drawing.Color.White;
            this.btn_students.Location = new System.Drawing.Point(0, 102);
            this.btn_students.Name = "btn_students";
            this.btn_students.Size = new System.Drawing.Size(200, 51);
            this.btn_students.TabIndex = 1;
            this.btn_students.Text = "Manage Students";
            this.btn_students.Click += new System.EventHandler(this.btn_students_Click);
            // 
            // btn_Admin
            // 
            this.btn_Admin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Admin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Admin.ForeColor = System.Drawing.Color.White;
            this.btn_Admin.Location = new System.Drawing.Point(0, 51);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Size = new System.Drawing.Size(200, 51);
            this.btn_Admin.TabIndex = 10;
            this.btn_Admin.Text = "Manage Admins";
            this.btn_Admin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.ForeColor = System.Drawing.Color.White;
            this.btn_Home.Location = new System.Drawing.Point(0, 0);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(200, 51);
            this.btn_Home.TabIndex = 7;
            this.btn_Home.Text = "Home";
            this.btn_Home.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlProblems
            // 
            this.pnlProblems.Controls.Add(this.dgvProblems);
            this.pnlProblems.Controls.Add(this.ProblemCards);
            this.pnlProblems.Controls.Add(this.btnAddProb);
            this.pnlProblems.Controls.Add(this.btnUpdateProb);
            this.pnlProblems.Controls.Add(this.btnToggleProb);
            this.pnlProblems.Controls.Add(this.panel5);
            this.pnlProblems.Location = new System.Drawing.Point(199, 2);
            this.pnlProblems.Name = "pnlProblems";
            this.pnlProblems.Size = new System.Drawing.Size(805, 557);
            this.pnlProblems.TabIndex = 4;
            // 
            // dgvProblems
            // 
            this.dgvProblems.AllowUserToAddRows = false;
            this.dgvProblems.AllowUserToDeleteRows = false;
            this.dgvProblems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProblems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProblems.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle53.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle53.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle53.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle53.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle53.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle53.SelectionForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle53.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProblems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle53;
            this.dgvProblems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle54.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle54.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle54.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle54.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle54.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle54.SelectionForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle54.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProblems.DefaultCellStyle = dataGridViewCellStyle54;
            this.dgvProblems.Location = new System.Drawing.Point(25, 292);
            this.dgvProblems.Name = "dgvProblems";
            this.dgvProblems.RowHeadersWidth = 35;
            this.dgvProblems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProblems.Size = new System.Drawing.Size(754, 248);
            this.dgvProblems.TabIndex = 12;
            // 
            // ProblemCards
            // 
            this.ProblemCards.BackColor = System.Drawing.Color.White;
            this.ProblemCards.Controls.Add(this.tableLayoutPanel1);
            this.ProblemCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProblemCards.Location = new System.Drawing.Point(0, 50);
            this.ProblemCards.Name = "ProblemCards";
            this.ProblemCards.Size = new System.Drawing.Size(805, 164);
            this.ProblemCards.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.pnlinActProb, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlActProb, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlTotalProb, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(805, 164);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // pnlinActProb
            // 
            this.pnlinActProb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlinActProb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlinActProb.Controls.Add(this.lblInActProbValue);
            this.pnlinActProb.Controls.Add(this.lblInActProb);
            this.pnlinActProb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlinActProb.Location = new System.Drawing.Point(545, 13);
            this.pnlinActProb.Margin = new System.Windows.Forms.Padding(10);
            this.pnlinActProb.Name = "pnlinActProb";
            this.pnlinActProb.Size = new System.Drawing.Size(247, 138);
            this.pnlinActProb.TabIndex = 4;
            // 
            // lblInActProbValue
            // 
            this.lblInActProbValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInActProbValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblInActProbValue.Location = new System.Drawing.Point(0, 23);
            this.lblInActProbValue.Name = "lblInActProbValue";
            this.lblInActProbValue.Size = new System.Drawing.Size(245, 113);
            this.lblInActProbValue.TabIndex = 0;
            this.lblInActProbValue.Text = "0";
            this.lblInActProbValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInActProb
            // 
            this.lblInActProb.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInActProb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblInActProb.Location = new System.Drawing.Point(0, 0);
            this.lblInActProb.Name = "lblInActProb";
            this.lblInActProb.Size = new System.Drawing.Size(245, 23);
            this.lblInActProb.TabIndex = 1;
            this.lblInActProb.Text = "Inactive Problems";
            this.lblInActProb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlActProb
            // 
            this.pnlActProb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlActProb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlActProb.Controls.Add(this.lblActProbValue);
            this.pnlActProb.Controls.Add(this.lblActProb);
            this.pnlActProb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlActProb.Location = new System.Drawing.Point(279, 13);
            this.pnlActProb.Margin = new System.Windows.Forms.Padding(10);
            this.pnlActProb.Name = "pnlActProb";
            this.pnlActProb.Size = new System.Drawing.Size(246, 138);
            this.pnlActProb.TabIndex = 3;
            // 
            // lblActProbValue
            // 
            this.lblActProbValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActProbValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblActProbValue.Location = new System.Drawing.Point(0, 23);
            this.lblActProbValue.Name = "lblActProbValue";
            this.lblActProbValue.Size = new System.Drawing.Size(244, 113);
            this.lblActProbValue.TabIndex = 0;
            this.lblActProbValue.Text = "0";
            this.lblActProbValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblActProb
            // 
            this.lblActProb.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblActProb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblActProb.Location = new System.Drawing.Point(0, 0);
            this.lblActProb.Name = "lblActProb";
            this.lblActProb.Size = new System.Drawing.Size(244, 23);
            this.lblActProb.TabIndex = 1;
            this.lblActProb.Text = "Active Problems";
            this.lblActProb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlTotalProb
            // 
            this.pnlTotalProb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTotalProb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalProb.Controls.Add(this.lblTotalProbValue);
            this.pnlTotalProb.Controls.Add(this.lblTotalProb);
            this.pnlTotalProb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTotalProb.Location = new System.Drawing.Point(13, 13);
            this.pnlTotalProb.Margin = new System.Windows.Forms.Padding(10);
            this.pnlTotalProb.Name = "pnlTotalProb";
            this.pnlTotalProb.Size = new System.Drawing.Size(246, 138);
            this.pnlTotalProb.TabIndex = 1;
            // 
            // lblTotalProbValue
            // 
            this.lblTotalProbValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalProbValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTotalProbValue.Location = new System.Drawing.Point(0, 23);
            this.lblTotalProbValue.Name = "lblTotalProbValue";
            this.lblTotalProbValue.Size = new System.Drawing.Size(244, 113);
            this.lblTotalProbValue.TabIndex = 0;
            this.lblTotalProbValue.Text = "0";
            this.lblTotalProbValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalProb
            // 
            this.lblTotalProb.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalProb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalProb.Location = new System.Drawing.Point(0, 0);
            this.lblTotalProb.Name = "lblTotalProb";
            this.lblTotalProb.Size = new System.Drawing.Size(244, 23);
            this.lblTotalProb.TabIndex = 1;
            this.lblTotalProb.Text = "Total Problems";
            this.lblTotalProb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAddProb
            // 
            this.btnAddProb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnAddProb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAddProb.ForeColor = System.Drawing.Color.White;
            this.btnAddProb.Location = new System.Drawing.Point(17, 227);
            this.btnAddProb.Name = "btnAddProb";
            this.btnAddProb.Size = new System.Drawing.Size(140, 41);
            this.btnAddProb.TabIndex = 8;
            this.btnAddProb.Text = "Add Problem";
            this.btnAddProb.UseVisualStyleBackColor = false;
            this.btnAddProb.Click += new System.EventHandler(this.btnAddProb_Click);
            // 
            // btnUpdateProb
            // 
            this.btnUpdateProb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnUpdateProb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateProb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdateProb.ForeColor = System.Drawing.Color.White;
            this.btnUpdateProb.Location = new System.Drawing.Point(172, 227);
            this.btnUpdateProb.Name = "btnUpdateProb";
            this.btnUpdateProb.Size = new System.Drawing.Size(140, 41);
            this.btnUpdateProb.TabIndex = 9;
            this.btnUpdateProb.Text = "Update Problem";
            this.btnUpdateProb.UseVisualStyleBackColor = false;
            this.btnUpdateProb.Click += new System.EventHandler(this.btnUpdateProb_Click);
            // 
            // btnToggleProb
            // 
            this.btnToggleProb.BackColor = System.Drawing.Color.IndianRed;
            this.btnToggleProb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleProb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnToggleProb.ForeColor = System.Drawing.Color.White;
            this.btnToggleProb.Location = new System.Drawing.Point(327, 227);
            this.btnToggleProb.Name = "btnToggleProb";
            this.btnToggleProb.Size = new System.Drawing.Size(140, 41);
            this.btnToggleProb.TabIndex = 10;
            this.btnToggleProb.Text = "Toggle Status";
            this.btnToggleProb.UseVisualStyleBackColor = false;
            this.btnToggleProb.Click += new System.EventHandler(this.btnToggleProb_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
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
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Manage Problems";
            // 
            // pnlContest
            // 
            this.pnlContest.Controls.Add(this.ContestCards);
            this.pnlContest.Controls.Add(this.dgvContest);
            this.pnlContest.Controls.Add(this.btnAddContest);
            this.pnlContest.Controls.Add(this.btnUpdContest);
            this.pnlContest.Controls.Add(this.panel11);
            this.pnlContest.Location = new System.Drawing.Point(199, 2);
            this.pnlContest.Name = "pnlContest";
            this.pnlContest.Size = new System.Drawing.Size(805, 557);
            this.pnlContest.TabIndex = 6;
            // 
            // ContestCards
            // 
            this.ContestCards.BackColor = System.Drawing.Color.White;
            this.ContestCards.Controls.Add(this.tlpContest);
            this.ContestCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContestCards.Location = new System.Drawing.Point(0, 50);
            this.ContestCards.Name = "ContestCards";
            this.ContestCards.Size = new System.Drawing.Size(805, 164);
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
            this.tlpContest.Location = new System.Drawing.Point(0, 0);
            this.tlpContest.Name = "tlpContest";
            this.tlpContest.RowCount = 1;
            this.tlpContest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContest.Size = new System.Drawing.Size(805, 164);
            this.tlpContest.TabIndex = 20;
            // 
            // pnlinactContest
            // 
            this.pnlinactContest.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlinactContest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlinactContest.Controls.Add(this.lblInActcontestValue);
            this.pnlinactContest.Controls.Add(this.label3);
            this.pnlinactContest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlinactContest.Location = new System.Drawing.Point(412, 10);
            this.pnlinactContest.Margin = new System.Windows.Forms.Padding(10);
            this.pnlinactContest.Name = "pnlinactContest";
            this.pnlinactContest.Size = new System.Drawing.Size(181, 144);
            this.pnlinactContest.TabIndex = 23;
            // 
            // lblInActcontestValue
            // 
            this.lblInActcontestValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInActcontestValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblInActcontestValue.Location = new System.Drawing.Point(0, 23);
            this.lblInActcontestValue.Name = "lblInActcontestValue";
            this.lblInActcontestValue.Size = new System.Drawing.Size(179, 119);
            this.lblInActcontestValue.TabIndex = 0;
            this.lblInActcontestValue.Text = "0";
            this.lblInActcontestValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Inactive Contests";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlTotalContest
            // 
            this.pnlTotalContest.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTotalContest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalContest.Controls.Add(this.lblTotalContestValue);
            this.pnlTotalContest.Controls.Add(this.label8);
            this.pnlTotalContest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTotalContest.Location = new System.Drawing.Point(10, 10);
            this.pnlTotalContest.Margin = new System.Windows.Forms.Padding(10);
            this.pnlTotalContest.Name = "pnlTotalContest";
            this.pnlTotalContest.Size = new System.Drawing.Size(181, 144);
            this.pnlTotalContest.TabIndex = 22;
            // 
            // lblTotalContestValue
            // 
            this.lblTotalContestValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalContestValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTotalContestValue.Location = new System.Drawing.Point(0, 23);
            this.lblTotalContestValue.Name = "lblTotalContestValue";
            this.lblTotalContestValue.Size = new System.Drawing.Size(179, 119);
            this.lblTotalContestValue.TabIndex = 0;
            this.lblTotalContestValue.Text = "0";
            this.lblTotalContestValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 23);
            this.label8.TabIndex = 1;
            this.label8.Text = "Total Contests";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlactContest
            // 
            this.pnlactContest.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlactContest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlactContest.Controls.Add(this.lblActContestValue);
            this.pnlactContest.Controls.Add(this.label5);
            this.pnlactContest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlactContest.Location = new System.Drawing.Point(211, 10);
            this.pnlactContest.Margin = new System.Windows.Forms.Padding(10);
            this.pnlactContest.Name = "pnlactContest";
            this.pnlactContest.Size = new System.Drawing.Size(181, 144);
            this.pnlactContest.TabIndex = 21;
            // 
            // lblActContestValue
            // 
            this.lblActContestValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActContestValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblActContestValue.Location = new System.Drawing.Point(0, 23);
            this.lblActContestValue.Name = "lblActContestValue";
            this.lblActContestValue.Size = new System.Drawing.Size(179, 119);
            this.lblActContestValue.TabIndex = 0;
            this.lblActContestValue.Text = "0";
            this.lblActContestValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Active Contests";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlUpcommingContest
            // 
            this.pnlUpcommingContest.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlUpcommingContest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUpcommingContest.Controls.Add(this.lblUpcommingContestValue);
            this.pnlUpcommingContest.Controls.Add(this.label4);
            this.pnlUpcommingContest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUpcommingContest.Location = new System.Drawing.Point(613, 10);
            this.pnlUpcommingContest.Margin = new System.Windows.Forms.Padding(10);
            this.pnlUpcommingContest.Name = "pnlUpcommingContest";
            this.pnlUpcommingContest.Size = new System.Drawing.Size(182, 144);
            this.pnlUpcommingContest.TabIndex = 20;
            // 
            // lblUpcommingContestValue
            // 
            this.lblUpcommingContestValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUpcommingContestValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblUpcommingContestValue.Location = new System.Drawing.Point(0, 23);
            this.lblUpcommingContestValue.Name = "lblUpcommingContestValue";
            this.lblUpcommingContestValue.Size = new System.Drawing.Size(180, 119);
            this.lblUpcommingContestValue.TabIndex = 0;
            this.lblUpcommingContestValue.Text = "0";
            this.lblUpcommingContestValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Upcomming Contests";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvContest
            // 
            this.dgvContest.AllowUserToAddRows = false;
            this.dgvContest.AllowUserToDeleteRows = false;
            this.dgvContest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContest.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle55.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle55.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle55.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle55.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle55.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle55.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle55.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle55;
            this.dgvContest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle56.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle56.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle56.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle56.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle56.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle56.SelectionForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle56.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContest.DefaultCellStyle = dataGridViewCellStyle56;
            this.dgvContest.Location = new System.Drawing.Point(17, 285);
            this.dgvContest.MultiSelect = false;
            this.dgvContest.Name = "dgvContest";
            this.dgvContest.ReadOnly = true;
            this.dgvContest.RowHeadersWidth = 35;
            this.dgvContest.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvContest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContest.Size = new System.Drawing.Size(770, 255);
            this.dgvContest.TabIndex = 7;
            // 
            // btnAddContest
            // 
            this.btnAddContest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnAddContest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddContest.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAddContest.ForeColor = System.Drawing.Color.White;
            this.btnAddContest.Location = new System.Drawing.Point(17, 227);
            this.btnAddContest.Name = "btnAddContest";
            this.btnAddContest.Size = new System.Drawing.Size(140, 41);
            this.btnAddContest.TabIndex = 8;
            this.btnAddContest.Text = "Create Contest";
            this.btnAddContest.UseVisualStyleBackColor = false;
            this.btnAddContest.Click += new System.EventHandler(this.btnAddContest_Click);
            // 
            // btnUpdContest
            // 
            this.btnUpdContest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnUpdContest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdContest.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdContest.ForeColor = System.Drawing.Color.White;
            this.btnUpdContest.Location = new System.Drawing.Point(172, 227);
            this.btnUpdContest.Name = "btnUpdContest";
            this.btnUpdContest.Size = new System.Drawing.Size(140, 41);
            this.btnUpdContest.TabIndex = 9;
            this.btnUpdContest.Text = "Update Contest";
            this.btnUpdContest.UseVisualStyleBackColor = false;
            this.btnUpdContest.Click += new System.EventHandler(this.btnUpdContest_Click);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
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
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Manage Contests";
            // 
            // pnlsubmissions
            // 
            this.pnlsubmissions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlsubmissions.Controls.Add(this.label1);
            this.pnlsubmissions.Controls.Add(this.pnlsubmissionsCards);
            this.pnlsubmissions.Controls.Add(this.dgvSubmissions);
            this.pnlsubmissions.Controls.Add(this.panel13);
            this.pnlsubmissions.Location = new System.Drawing.Point(199, 2);
            this.pnlsubmissions.Name = "pnlsubmissions";
            this.pnlsubmissions.Size = new System.Drawing.Size(805, 557);
            this.pnlsubmissions.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Submissions View";
            // 
            // pnlsubmissionsCards
            // 
            this.pnlsubmissionsCards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlsubmissionsCards.BackColor = System.Drawing.Color.White;
            this.pnlsubmissionsCards.Controls.Add(this.tlpnlSubmission);
            this.pnlsubmissionsCards.Location = new System.Drawing.Point(0, 50);
            this.pnlsubmissionsCards.Name = "pnlsubmissionsCards";
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
            this.tlpnlSubmission.Location = new System.Drawing.Point(0, 0);
            this.tlpnlSubmission.Name = "tlpnlSubmission";
            this.tlpnlSubmission.RowCount = 1;
            this.tlpnlSubmission.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpnlSubmission.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpnlSubmission.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpnlSubmission.Size = new System.Drawing.Size(805, 180);
            this.tlpnlSubmission.TabIndex = 5;
            // 
            // pnlAccSub
            // 
            this.pnlAccSub.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlAccSub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAccSub.Controls.Add(this.AccSubValue);
            this.pnlAccSub.Controls.Add(this.label15);
            this.pnlAccSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAccSub.Location = new System.Drawing.Point(278, 10);
            this.pnlAccSub.Margin = new System.Windows.Forms.Padding(10);
            this.pnlAccSub.Name = "pnlAccSub";
            this.pnlAccSub.Size = new System.Drawing.Size(248, 160);
            this.pnlAccSub.TabIndex = 7;
            // 
            // AccSubValue
            // 
            this.AccSubValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AccSubValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.AccSubValue.Location = new System.Drawing.Point(0, 30);
            this.AccSubValue.Name = "AccSubValue";
            this.AccSubValue.Size = new System.Drawing.Size(246, 128);
            this.AccSubValue.TabIndex = 0;
            this.AccSubValue.Text = "3";
            this.AccSubValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Dock = System.Windows.Forms.DockStyle.Top;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(246, 30);
            this.label15.TabIndex = 1;
            this.label15.Text = "Accepted Submissions";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlRegSub
            // 
            this.pnlRegSub.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlRegSub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRegSub.Controls.Add(this.RegSubValue);
            this.pnlRegSub.Controls.Add(this.label11);
            this.pnlRegSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegSub.Location = new System.Drawing.Point(546, 10);
            this.pnlRegSub.Margin = new System.Windows.Forms.Padding(10);
            this.pnlRegSub.Name = "pnlRegSub";
            this.pnlRegSub.Size = new System.Drawing.Size(249, 160);
            this.pnlRegSub.TabIndex = 6;
            // 
            // RegSubValue
            // 
            this.RegSubValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegSubValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.RegSubValue.Location = new System.Drawing.Point(0, 30);
            this.RegSubValue.Name = "RegSubValue";
            this.RegSubValue.Size = new System.Drawing.Size(247, 128);
            this.RegSubValue.TabIndex = 0;
            this.RegSubValue.Text = "215";
            this.RegSubValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(247, 30);
            this.label11.TabIndex = 1;
            this.label11.Text = "Rejected Submissions";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlTotalSub
            // 
            this.pnlTotalSub.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTotalSub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalSub.Controls.Add(this.totalsubValue);
            this.pnlTotalSub.Controls.Add(this.lblSubmissions);
            this.pnlTotalSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTotalSub.Location = new System.Drawing.Point(10, 10);
            this.pnlTotalSub.Margin = new System.Windows.Forms.Padding(10);
            this.pnlTotalSub.Name = "pnlTotalSub";
            this.pnlTotalSub.Size = new System.Drawing.Size(248, 160);
            this.pnlTotalSub.TabIndex = 5;
            // 
            // totalsubValue
            // 
            this.totalsubValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalsubValue.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalsubValue.Location = new System.Drawing.Point(0, 30);
            this.totalsubValue.Name = "totalsubValue";
            this.totalsubValue.Size = new System.Drawing.Size(246, 128);
            this.totalsubValue.TabIndex = 0;
            this.totalsubValue.Text = "5";
            this.totalsubValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubmissions
            // 
            this.lblSubmissions.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSubmissions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSubmissions.Location = new System.Drawing.Point(0, 0);
            this.lblSubmissions.Name = "lblSubmissions";
            this.lblSubmissions.Size = new System.Drawing.Size(246, 30);
            this.lblSubmissions.TabIndex = 1;
            this.lblSubmissions.Text = "Total Submissions";
            this.lblSubmissions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvSubmissions
            // 
            this.dgvSubmissions.AllowUserToAddRows = false;
            this.dgvSubmissions.AllowUserToDeleteRows = false;
            this.dgvSubmissions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSubmissions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubmissions.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle57.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle57.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle57.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle57.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle57.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle57.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle57.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubmissions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle57;
            this.dgvSubmissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle58.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle58.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle58.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle58.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle58.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle58.SelectionForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle58.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubmissions.DefaultCellStyle = dataGridViewCellStyle58;
            this.dgvSubmissions.Location = new System.Drawing.Point(25, 285);
            this.dgvSubmissions.Name = "dgvSubmissions";
            this.dgvSubmissions.ReadOnly = true;
            dataGridViewCellStyle59.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle59.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle59.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle59.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle59.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle59.SelectionForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle59.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubmissions.RowHeadersDefaultCellStyle = dataGridViewCellStyle59;
            this.dgvSubmissions.RowHeadersWidth = 35;
            this.dgvSubmissions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSubmissions.Size = new System.Drawing.Size(752, 247);
            this.dgvSubmissions.TabIndex = 7;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel13.Controls.Add(this.label17);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(803, 50);
            this.panel13.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(21, 13);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(235, 24);
            this.label17.TabIndex = 1;
            this.label17.Text = "Submissions Dashboard";
            // 
            // pnlTestCases
            // 
            this.pnlTestCases.Controls.Add(this.btnAddTestCase);
            this.pnlTestCases.Controls.Add(this.btnUpdateTestCase);
            this.pnlTestCases.Controls.Add(this.btnToggleTestCase);
            this.pnlTestCases.Controls.Add(this.pnlTestCaseCards);
            this.pnlTestCases.Controls.Add(this.dgvTestCases);
            this.pnlTestCases.Controls.Add(this.panel17);
            this.pnlTestCases.Location = new System.Drawing.Point(199, 2);
            this.pnlTestCases.Name = "pnlTestCases";
            this.pnlTestCases.Size = new System.Drawing.Size(805, 557);
            this.pnlTestCases.TabIndex = 12;
            // 
            // btnAddTestCase
            // 
            this.btnAddTestCase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnAddTestCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTestCase.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAddTestCase.ForeColor = System.Drawing.Color.White;
            this.btnAddTestCase.Location = new System.Drawing.Point(25, 245);
            this.btnAddTestCase.Name = "btnAddTestCase";
            this.btnAddTestCase.Size = new System.Drawing.Size(140, 41);
            this.btnAddTestCase.TabIndex = 12;
            this.btnAddTestCase.Text = "Add Test Case";
            this.btnAddTestCase.UseVisualStyleBackColor = false;
            this.btnAddTestCase.Click += new System.EventHandler(this.btnAddTestCase_Click);
            // 
            // btnUpdateTestCase
            // 
            this.btnUpdateTestCase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnUpdateTestCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateTestCase.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdateTestCase.ForeColor = System.Drawing.Color.White;
            this.btnUpdateTestCase.Location = new System.Drawing.Point(180, 245);
            this.btnUpdateTestCase.Name = "btnUpdateTestCase";
            this.btnUpdateTestCase.Size = new System.Drawing.Size(140, 41);
            this.btnUpdateTestCase.TabIndex = 13;
            this.btnUpdateTestCase.Text = "Update Test Case";
            this.btnUpdateTestCase.UseVisualStyleBackColor = false;
            this.btnUpdateTestCase.Click += new System.EventHandler(this.btnUpdateTestCase_Click);
            // 
            // btnToggleTestCase
            // 
            this.btnToggleTestCase.BackColor = System.Drawing.Color.IndianRed;
            this.btnToggleTestCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleTestCase.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnToggleTestCase.ForeColor = System.Drawing.Color.White;
            this.btnToggleTestCase.Location = new System.Drawing.Point(335, 245);
            this.btnToggleTestCase.Name = "btnToggleTestCase";
            this.btnToggleTestCase.Size = new System.Drawing.Size(140, 41);
            this.btnToggleTestCase.TabIndex = 14;
            this.btnToggleTestCase.Text = "Toggle Status";
            this.btnToggleTestCase.UseVisualStyleBackColor = false;
            this.btnToggleTestCase.Click += new System.EventHandler(this.btnToggleTestCase_Click);
            // 
            // pnlTestCaseCards
            // 
            this.pnlTestCaseCards.BackColor = System.Drawing.Color.White;
            this.pnlTestCaseCards.Controls.Add(this.tableLayoutPanel2);
            this.pnlTestCaseCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTestCaseCards.Location = new System.Drawing.Point(0, 50);
            this.pnlTestCaseCards.Name = "pnlTestCaseCards";
            this.pnlTestCaseCards.Size = new System.Drawing.Size(805, 180);
            this.pnlTestCaseCards.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.pnlInActTestCases, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.pnlActTestCases, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pnlTotalTestCase, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(805, 180);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // pnlInActTestCases
            // 
            this.pnlInActTestCases.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlInActTestCases.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInActTestCases.Controls.Add(this.lblInActiveTestCases);
            this.pnlInActTestCases.Controls.Add(this.label13);
            this.pnlInActTestCases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInActTestCases.Location = new System.Drawing.Point(546, 10);
            this.pnlInActTestCases.Margin = new System.Windows.Forms.Padding(10);
            this.pnlInActTestCases.Name = "pnlInActTestCases";
            this.pnlInActTestCases.Size = new System.Drawing.Size(249, 160);
            this.pnlInActTestCases.TabIndex = 7;
            // 
            // lblInActiveTestCases
            // 
            this.lblInActiveTestCases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInActiveTestCases.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblInActiveTestCases.Location = new System.Drawing.Point(0, 30);
            this.lblInActiveTestCases.Name = "lblInActiveTestCases";
            this.lblInActiveTestCases.Size = new System.Drawing.Size(247, 128);
            this.lblInActiveTestCases.TabIndex = 0;
            this.lblInActiveTestCases.Text = "215";
            this.lblInActiveTestCases.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(247, 30);
            this.label13.TabIndex = 1;
            this.label13.Text = "Inactive Test Cases";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlActTestCases
            // 
            this.pnlActTestCases.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlActTestCases.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlActTestCases.Controls.Add(this.lblActTestCases);
            this.pnlActTestCases.Controls.Add(this.label19);
            this.pnlActTestCases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlActTestCases.Location = new System.Drawing.Point(278, 10);
            this.pnlActTestCases.Margin = new System.Windows.Forms.Padding(10);
            this.pnlActTestCases.Name = "pnlActTestCases";
            this.pnlActTestCases.Size = new System.Drawing.Size(248, 160);
            this.pnlActTestCases.TabIndex = 6;
            // 
            // lblActTestCases
            // 
            this.lblActTestCases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActTestCases.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblActTestCases.Location = new System.Drawing.Point(0, 30);
            this.lblActTestCases.Name = "lblActTestCases";
            this.lblActTestCases.Size = new System.Drawing.Size(246, 128);
            this.lblActTestCases.TabIndex = 0;
            this.lblActTestCases.Text = "3";
            this.lblActTestCases.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.Dock = System.Windows.Forms.DockStyle.Top;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(0, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(246, 30);
            this.label19.TabIndex = 1;
            this.label19.Text = "Active Test Cases";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlTotalTestCase
            // 
            this.pnlTotalTestCase.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTotalTestCase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalTestCase.Controls.Add(this.lbltotalTestCases);
            this.pnlTotalTestCase.Controls.Add(this.label10);
            this.pnlTotalTestCase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTotalTestCase.Location = new System.Drawing.Point(10, 10);
            this.pnlTotalTestCase.Margin = new System.Windows.Forms.Padding(10);
            this.pnlTotalTestCase.Name = "pnlTotalTestCase";
            this.pnlTotalTestCase.Size = new System.Drawing.Size(248, 160);
            this.pnlTotalTestCase.TabIndex = 5;
            // 
            // lbltotalTestCases
            // 
            this.lbltotalTestCases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbltotalTestCases.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalTestCases.Location = new System.Drawing.Point(0, 30);
            this.lbltotalTestCases.Name = "lbltotalTestCases";
            this.lbltotalTestCases.Size = new System.Drawing.Size(246, 128);
            this.lbltotalTestCases.TabIndex = 0;
            this.lbltotalTestCases.Text = "5";
            this.lbltotalTestCases.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(246, 30);
            this.label10.TabIndex = 1;
            this.label10.Text = "Total Test Cases";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvTestCases
            // 
            this.dgvTestCases.AllowUserToAddRows = false;
            this.dgvTestCases.AllowUserToDeleteRows = false;
            this.dgvTestCases.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTestCases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTestCases.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle60.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle60.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle60.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle60.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle60.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle60.SelectionForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle60.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTestCases.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle60;
            this.dgvTestCases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle61.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle61.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle61.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle61.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle61.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle61.SelectionForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle61.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTestCases.DefaultCellStyle = dataGridViewCellStyle61;
            this.dgvTestCases.Location = new System.Drawing.Point(25, 298);
            this.dgvTestCases.Name = "dgvTestCases";
            this.dgvTestCases.ReadOnly = true;
            this.dgvTestCases.RowHeadersWidth = 35;
            this.dgvTestCases.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTestCases.Size = new System.Drawing.Size(754, 238);
            this.dgvTestCases.TabIndex = 7;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel17.Controls.Add(this.label20);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel17.Location = new System.Drawing.Point(0, 0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(805, 50);
            this.panel17.TabIndex = 6;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(21, 13);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(220, 24);
            this.label20.TabIndex = 1;
            this.label20.Text = "Test Cases Dashboard";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.pnlHeader.Controls.Add(this.lblMainTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(805, 48);
            this.pnlHeader.TabIndex = 6;
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblMainTitle.ForeColor = System.Drawing.Color.White;
            this.lblMainTitle.Location = new System.Drawing.Point(21, 13);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(239, 24);
            this.lblMainTitle.TabIndex = 1;
            this.lblMainTitle.Text = "Super Admin Dashboard";
            // 
            // dgvAdmins
            // 
            this.dgvAdmins.AllowUserToAddRows = false;
            this.dgvAdmins.AllowUserToDeleteRows = false;
            this.dgvAdmins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAdmins.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdmins.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle62.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle62.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle62.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle62.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle62.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle62.SelectionForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle62.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdmins.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle62;
            this.dgvAdmins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle63.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle63.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle63.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle63.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle63.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle63.SelectionForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle63.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdmins.DefaultCellStyle = dataGridViewCellStyle63;
            this.dgvAdmins.Location = new System.Drawing.Point(25, 298);
            this.dgvAdmins.MultiSelect = false;
            this.dgvAdmins.Name = "dgvAdmins";
            this.dgvAdmins.ReadOnly = true;
            this.dgvAdmins.RowHeadersWidth = 35;
            this.dgvAdmins.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdmins.Size = new System.Drawing.Size(754, 236);
            this.dgvAdmins.TabIndex = 7;
            // 
            // pnladmin
            // 
            this.pnladmin.BackColor = System.Drawing.Color.White;
            this.pnladmin.Controls.Add(this.tlpnlAdmin);
            this.pnladmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnladmin.Location = new System.Drawing.Point(0, 48);
            this.pnladmin.Name = "pnladmin";
            this.pnladmin.Size = new System.Drawing.Size(805, 180);
            this.pnladmin.TabIndex = 11;
            // 
            // tlpnlAdmin
            // 
            this.tlpnlAdmin.ColumnCount = 4;
            this.tlpnlAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpnlAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpnlAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpnlAdmin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpnlAdmin.Controls.Add(this.pnlTotalAdmins, 0, 0);
            this.tlpnlAdmin.Controls.Add(this.pnlTotalProblems, 1, 0);
            this.tlpnlAdmin.Controls.Add(this.pnlTotalContests, 2, 0);
            this.tlpnlAdmin.Controls.Add(this.pnlTotalStudents, 3, 0);
            this.tlpnlAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpnlAdmin.Location = new System.Drawing.Point(0, 0);
            this.tlpnlAdmin.Name = "tlpnlAdmin";
            this.tlpnlAdmin.RowCount = 1;
            this.tlpnlAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpnlAdmin.Size = new System.Drawing.Size(805, 180);
            this.tlpnlAdmin.TabIndex = 1;
            // 
            // pnlTotalAdmins
            // 
            this.pnlTotalAdmins.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTotalAdmins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalAdmins.Controls.Add(this.lbladminValue);
            this.pnlTotalAdmins.Controls.Add(this.lblTotalAdmins);
            this.pnlTotalAdmins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTotalAdmins.Location = new System.Drawing.Point(10, 10);
            this.pnlTotalAdmins.Margin = new System.Windows.Forms.Padding(10);
            this.pnlTotalAdmins.Name = "pnlTotalAdmins";
            this.pnlTotalAdmins.Size = new System.Drawing.Size(181, 160);
            this.pnlTotalAdmins.TabIndex = 4;
            // 
            // lbladminValue
            // 
            this.lbladminValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbladminValue.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladminValue.Location = new System.Drawing.Point(0, 30);
            this.lbladminValue.Name = "lbladminValue";
            this.lbladminValue.Size = new System.Drawing.Size(179, 128);
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
            this.lblTotalAdmins.Size = new System.Drawing.Size(179, 30);
            this.lblTotalAdmins.TabIndex = 1;
            this.lblTotalAdmins.Text = "Total Admins";
            this.lblTotalAdmins.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlTotalProblems
            // 
            this.pnlTotalProblems.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTotalProblems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalProblems.Controls.Add(this.lblProblemValue);
            this.pnlTotalProblems.Controls.Add(this.lblTotalProblems);
            this.pnlTotalProblems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTotalProblems.Location = new System.Drawing.Point(211, 10);
            this.pnlTotalProblems.Margin = new System.Windows.Forms.Padding(10);
            this.pnlTotalProblems.Name = "pnlTotalProblems";
            this.pnlTotalProblems.Size = new System.Drawing.Size(181, 160);
            this.pnlTotalProblems.TabIndex = 0;
            // 
            // lblProblemValue
            // 
            this.lblProblemValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProblemValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblProblemValue.Location = new System.Drawing.Point(0, 30);
            this.lblProblemValue.Name = "lblProblemValue";
            this.lblProblemValue.Size = new System.Drawing.Size(179, 128);
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
            this.lblTotalProblems.Size = new System.Drawing.Size(179, 30);
            this.lblTotalProblems.TabIndex = 1;
            this.lblTotalProblems.Text = "Total Problems";
            this.lblTotalProblems.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlTotalContests
            // 
            this.pnlTotalContests.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTotalContests.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalContests.Controls.Add(this.lblContestValue);
            this.pnlTotalContests.Controls.Add(this.lblTotalContests);
            this.pnlTotalContests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTotalContests.Location = new System.Drawing.Point(412, 10);
            this.pnlTotalContests.Margin = new System.Windows.Forms.Padding(10);
            this.pnlTotalContests.Name = "pnlTotalContests";
            this.pnlTotalContests.Size = new System.Drawing.Size(181, 160);
            this.pnlTotalContests.TabIndex = 1;
            // 
            // lblContestValue
            // 
            this.lblContestValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblContestValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblContestValue.Location = new System.Drawing.Point(0, 30);
            this.lblContestValue.Name = "lblContestValue";
            this.lblContestValue.Size = new System.Drawing.Size(179, 128);
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
            this.lblTotalContests.Size = new System.Drawing.Size(179, 30);
            this.lblTotalContests.TabIndex = 1;
            this.lblTotalContests.Text = "Total Contests";
            this.lblTotalContests.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlTotalStudents
            // 
            this.pnlTotalStudents.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTotalStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalStudents.Controls.Add(this.lblStdValue);
            this.pnlTotalStudents.Controls.Add(this.lblTotalStd);
            this.pnlTotalStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTotalStudents.Location = new System.Drawing.Point(613, 10);
            this.pnlTotalStudents.Margin = new System.Windows.Forms.Padding(10);
            this.pnlTotalStudents.Name = "pnlTotalStudents";
            this.pnlTotalStudents.Size = new System.Drawing.Size(182, 160);
            this.pnlTotalStudents.TabIndex = 2;
            // 
            // lblStdValue
            // 
            this.lblStdValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStdValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblStdValue.Location = new System.Drawing.Point(0, 30);
            this.lblStdValue.Name = "lblStdValue";
            this.lblStdValue.Size = new System.Drawing.Size(180, 128);
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
            this.lblTotalStd.Size = new System.Drawing.Size(180, 30);
            this.lblTotalStd.TabIndex = 1;
            this.lblTotalStd.Text = "Total Students";
            this.lblTotalStd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnToggleAdmin
            // 
            this.btnToggleAdmin.BackColor = System.Drawing.Color.IndianRed;
            this.btnToggleAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleAdmin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnToggleAdmin.ForeColor = System.Drawing.Color.White;
            this.btnToggleAdmin.Location = new System.Drawing.Point(335, 245);
            this.btnToggleAdmin.Name = "btnToggleAdmin";
            this.btnToggleAdmin.Size = new System.Drawing.Size(140, 41);
            this.btnToggleAdmin.TabIndex = 14;
            this.btnToggleAdmin.Text = "Toggle Status";
            this.btnToggleAdmin.UseVisualStyleBackColor = false;
            this.btnToggleAdmin.Click += new System.EventHandler(this.btnToggleAdmin_Click);
            // 
            // btnUpdateAdmin
            // 
            this.btnUpdateAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnUpdateAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateAdmin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdateAdmin.ForeColor = System.Drawing.Color.White;
            this.btnUpdateAdmin.Location = new System.Drawing.Point(180, 245);
            this.btnUpdateAdmin.Name = "btnUpdateAdmin";
            this.btnUpdateAdmin.Size = new System.Drawing.Size(140, 41);
            this.btnUpdateAdmin.TabIndex = 13;
            this.btnUpdateAdmin.Text = "Update Admin";
            this.btnUpdateAdmin.UseVisualStyleBackColor = false;
            this.btnUpdateAdmin.Click += new System.EventHandler(this.btnUpdateAdmin_Click);
            // 
            // btnAddAdmin
            // 
            this.btnAddAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnAddAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAdmin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAddAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAddAdmin.Location = new System.Drawing.Point(25, 245);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.Size = new System.Drawing.Size(140, 41);
            this.btnAddAdmin.TabIndex = 12;
            this.btnAddAdmin.Text = "Add Admin";
            this.btnAddAdmin.UseVisualStyleBackColor = false;
            this.btnAddAdmin.Click += new System.EventHandler(this.btnAddAdmin_Click);
            // 
            // pnlSuperAdmin
            // 
            this.pnlSuperAdmin.Controls.Add(this.btnAddAdmin);
            this.pnlSuperAdmin.Controls.Add(this.btnUpdateAdmin);
            this.pnlSuperAdmin.Controls.Add(this.btnToggleAdmin);
            this.pnlSuperAdmin.Controls.Add(this.pnladmin);
            this.pnlSuperAdmin.Controls.Add(this.dgvAdmins);
            this.pnlSuperAdmin.Controls.Add(this.pnlHeader);
            this.pnlSuperAdmin.Location = new System.Drawing.Point(199, 2);
            this.pnlSuperAdmin.Name = "pnlSuperAdmin";
            this.pnlSuperAdmin.Size = new System.Drawing.Size(805, 557);
            this.pnlSuperAdmin.TabIndex = 9;
            // 
            // pnlStudent
            // 
            this.pnlStudent.Controls.Add(this.pnlstd);
            this.pnlStudent.Controls.Add(this.dgvStudents);
            this.pnlStudent.Controls.Add(this.btntoggleStd);
            this.pnlStudent.Controls.Add(this.panel3);
            this.pnlStudent.Location = new System.Drawing.Point(199, 2);
            this.pnlStudent.Name = "pnlStudent";
            this.pnlStudent.Size = new System.Drawing.Size(805, 557);
            this.pnlStudent.TabIndex = 13;
            // 
            // pnlstd
            // 
            this.pnlstd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlstd.BackColor = System.Drawing.Color.White;
            this.pnlstd.Controls.Add(this.tlpnlStudents);
            this.pnlstd.Location = new System.Drawing.Point(0, 50);
            this.pnlstd.Name = "pnlstd";
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
            this.tlpnlStudents.Location = new System.Drawing.Point(0, 0);
            this.tlpnlStudents.Name = "tlpnlStudents";
            this.tlpnlStudents.RowCount = 1;
            this.tlpnlStudents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpnlStudents.Size = new System.Drawing.Size(805, 164);
            this.tlpnlStudents.TabIndex = 0;
            // 
            // pnlActiveStudents
            // 
            this.pnlActiveStudents.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlActiveStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlActiveStudents.Controls.Add(this.lblactstdValue);
            this.pnlActiveStudents.Controls.Add(this.lblactstd);
            this.pnlActiveStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlActiveStudents.Location = new System.Drawing.Point(278, 10);
            this.pnlActiveStudents.Margin = new System.Windows.Forms.Padding(10);
            this.pnlActiveStudents.Name = "pnlActiveStudents";
            this.pnlActiveStudents.Size = new System.Drawing.Size(248, 144);
            this.pnlActiveStudents.TabIndex = 2;
            // 
            // lblactstdValue
            // 
            this.lblactstdValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblactstdValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblactstdValue.Location = new System.Drawing.Point(0, 30);
            this.lblactstdValue.Name = "lblactstdValue";
            this.lblactstdValue.Size = new System.Drawing.Size(246, 112);
            this.lblactstdValue.TabIndex = 0;
            this.lblactstdValue.Text = "3";
            this.lblactstdValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblactstd
            // 
            this.lblactstd.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblactstd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblactstd.Location = new System.Drawing.Point(0, 0);
            this.lblactstd.Name = "lblactstd";
            this.lblactstd.Size = new System.Drawing.Size(246, 30);
            this.lblactstd.TabIndex = 1;
            this.lblactstd.Text = "Active Students";
            this.lblactstd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlTotalSudents
            // 
            this.pnlTotalSudents.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTotalSudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalSudents.Controls.Add(this.lbl_stdValue);
            this.pnlTotalSudents.Controls.Add(this.lblstd);
            this.pnlTotalSudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTotalSudents.Location = new System.Drawing.Point(10, 10);
            this.pnlTotalSudents.Margin = new System.Windows.Forms.Padding(10);
            this.pnlTotalSudents.Name = "pnlTotalSudents";
            this.pnlTotalSudents.Size = new System.Drawing.Size(248, 144);
            this.pnlTotalSudents.TabIndex = 4;
            // 
            // lbl_stdValue
            // 
            this.lbl_stdValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_stdValue.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stdValue.Location = new System.Drawing.Point(0, 30);
            this.lbl_stdValue.Name = "lbl_stdValue";
            this.lbl_stdValue.Size = new System.Drawing.Size(246, 112);
            this.lbl_stdValue.TabIndex = 0;
            this.lbl_stdValue.Text = "5";
            this.lbl_stdValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblstd
            // 
            this.lblstd.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblstd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblstd.Location = new System.Drawing.Point(0, 0);
            this.lblstd.Name = "lblstd";
            this.lblstd.Size = new System.Drawing.Size(246, 30);
            this.lblstd.TabIndex = 1;
            this.lblstd.Text = "Total Students";
            this.lblstd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlnactiveStudents
            // 
            this.pnlnactiveStudents.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlnactiveStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlnactiveStudents.Controls.Add(this.lblinactstdValue);
            this.pnlnactiveStudents.Controls.Add(this.lblinactstd);
            this.pnlnactiveStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlnactiveStudents.Location = new System.Drawing.Point(546, 10);
            this.pnlnactiveStudents.Margin = new System.Windows.Forms.Padding(10);
            this.pnlnactiveStudents.Name = "pnlnactiveStudents";
            this.pnlnactiveStudents.Size = new System.Drawing.Size(249, 144);
            this.pnlnactiveStudents.TabIndex = 0;
            // 
            // lblinactstdValue
            // 
            this.lblinactstdValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblinactstdValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblinactstdValue.Location = new System.Drawing.Point(0, 30);
            this.lblinactstdValue.Name = "lblinactstdValue";
            this.lblinactstdValue.Size = new System.Drawing.Size(247, 112);
            this.lblinactstdValue.TabIndex = 0;
            this.lblinactstdValue.Text = "215";
            this.lblinactstdValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblinactstd
            // 
            this.lblinactstd.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblinactstd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblinactstd.Location = new System.Drawing.Point(0, 0);
            this.lblinactstd.Name = "lblinactstd";
            this.lblinactstd.Size = new System.Drawing.Size(247, 30);
            this.lblinactstd.TabIndex = 1;
            this.lblinactstd.Text = "Inactive Students";
            this.lblinactstd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle64.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle64.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle64.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle64.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle64.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle64.SelectionForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle64.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle64;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle65.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle65.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle65.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle65.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle65.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle65.SelectionForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle65.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudents.DefaultCellStyle = dataGridViewCellStyle65;
            this.dgvStudents.Location = new System.Drawing.Point(19, 276);
            this.dgvStudents.MultiSelect = false;
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RowHeadersWidth = 35;
            this.dgvStudents.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(770, 266);
            this.dgvStudents.TabIndex = 11;
            // 
            // btntoggleStd
            // 
            this.btntoggleStd.BackColor = System.Drawing.Color.IndianRed;
            this.btntoggleStd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntoggleStd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntoggleStd.ForeColor = System.Drawing.Color.White;
            this.btntoggleStd.Location = new System.Drawing.Point(19, 227);
            this.btntoggleStd.Name = "btntoggleStd";
            this.btntoggleStd.Size = new System.Drawing.Size(138, 40);
            this.btntoggleStd.TabIndex = 13;
            this.btntoggleStd.Text = "Toggle Status";
            this.btntoggleStd.UseVisualStyleBackColor = false;
            this.btntoggleStd.Click += new System.EventHandler(this.btntoggleStd_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
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
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Manage Students";
            // 
            // btnReport
            // 
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Location = new System.Drawing.Point(0, 408);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(200, 51);
            this.btnReport.TabIndex = 11;
            this.btnReport.Text = "Generate Report";
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btn_Settings
            // 
            this.btn_Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Settings.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Settings.ForeColor = System.Drawing.Color.White;
            this.btn_Settings.Location = new System.Drawing.Point(0, 459);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(200, 51);
            this.btn_Settings.TabIndex = 12;
            this.btn_Settings.Text = "Settings";
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // AdminDashboardUI
            // 
            this.ClientSize = new System.Drawing.Size(1004, 561);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlSuperAdmin);
            this.Controls.Add(this.pnlContest);
            this.Controls.Add(this.pnlProblems);
            this.Controls.Add(this.pnlTestCases);
            this.Controls.Add(this.pnlsubmissions);
            this.Controls.Add(this.pnlStudent);
            this.Name = "AdminDashboardUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlProblems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProblems)).EndInit();
            this.ProblemCards.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlinActProb.ResumeLayout(false);
            this.pnlActProb.ResumeLayout(false);
            this.pnlTotalProb.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
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
            this.pnlTestCases.ResumeLayout(false);
            this.pnlTestCaseCards.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnlInActTestCases.ResumeLayout(false);
            this.pnlActTestCases.ResumeLayout(false);
            this.pnlTotalTestCase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestCases)).EndInit();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmins)).EndInit();
            this.pnladmin.ResumeLayout(false);
            this.tlpnlAdmin.ResumeLayout(false);
            this.pnlTotalAdmins.ResumeLayout(false);
            this.pnlTotalProblems.ResumeLayout(false);
            this.pnlTotalContests.ResumeLayout(false);
            this.pnlTotalStudents.ResumeLayout(false);
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
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btn_contests;
        private System.Windows.Forms.Button btn_problems;
        private System.Windows.Forms.Button btnTestCases;
        private System.Windows.Forms.Panel pnlProblems;
        private System.Windows.Forms.Panel ProblemCards;
        private System.Windows.Forms.Button btnAddProb;
        private System.Windows.Forms.Button btnUpdateProb;
        private System.Windows.Forms.Button btnToggleProb;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Panel pnlContest;
        private System.Windows.Forms.DataGridView dgvContest;
        private System.Windows.Forms.Button btnAddContest;
        private System.Windows.Forms.Button btnUpdContest;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSubmissions;
        private System.Windows.Forms.Button btnContestLeaderboard;
        private System.Windows.Forms.Button btn_Admin;
        private System.Windows.Forms.Panel pnlsubmissions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlsubmissionsCards;
        private System.Windows.Forms.DataGridView dgvSubmissions;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel pnlTestCases;
        private System.Windows.Forms.Button btnAddTestCase;
        private System.Windows.Forms.Button btnUpdateTestCase;
        private System.Windows.Forms.Button btnToggleTestCase;
        private System.Windows.Forms.Panel pnlTestCaseCards;
        private System.Windows.Forms.DataGridView dgvTestCases;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView dgvProblems;
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
        private Label lblMainTitle;
        private DataGridView dgvAdmins;
        private Panel pnladmin;
        private TableLayoutPanel tlpnlAdmin;
        private Panel pnlTotalAdmins;
        private Label lbladminValue;
        private Label lblTotalAdmins;
        private Panel pnlTotalProblems;
        private Label lblProblemValue;
        private Label lblTotalProblems;
        private Panel pnlTotalContests;
        private Label lblContestValue;
        private Label lblTotalContests;
        private Panel pnlTotalStudents;
        private Label lblStdValue;
        private Label lblTotalStd;
        private Button btnToggleAdmin;
        private Button btnUpdateAdmin;
        private Button btnAddAdmin;
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
        private TableLayoutPanel tableLayoutPanel2;
        private Panel pnlInActTestCases;
        private Label lblInActiveTestCases;
        private Label label13;
        private Panel pnlActTestCases;
        private Label lblActTestCases;
        private Label label19;
        private Panel pnlTotalTestCase;
        private Label lbltotalTestCases;
        private Label label10;
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
        private Button btntoggleStd;
        private Panel panel3;
        private Label label2;
        private Button btnReport;
        private Button btn_Settings;
    }
}