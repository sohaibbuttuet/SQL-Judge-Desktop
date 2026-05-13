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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSubmissions = new System.Windows.Forms.Button();
            this.btnContestLeaderboard = new System.Windows.Forms.Button();
            this.btn_contests = new System.Windows.Forms.Button();
            this.btnTestCases = new System.Windows.Forms.Button();
            this.btn_problems = new System.Windows.Forms.Button();
            this.btn_students = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlProblems = new System.Windows.Forms.Panel();
            this.dgvProblems = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblInActProbValue = new System.Windows.Forms.Label();
            this.lblInActProb = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
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
            this.tlpnlContest = new System.Windows.Forms.TableLayoutPanel();
            this.dgvContest = new System.Windows.Forms.DataGridView();
            this.btnAddContest = new System.Windows.Forms.Button();
            this.btnUpdContest = new System.Windows.Forms.Button();
            this.btnToggleContest = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlnactiveStudents = new System.Windows.Forms.Panel();
            this.lblinactstdValue = new System.Windows.Forms.Label();
            this.lblinactstd = new System.Windows.Forms.Label();
            this.pnlStudent = new System.Windows.Forms.Panel();
            this.pnlstd = new System.Windows.Forms.Panel();
            this.tlpnlStudents = new System.Windows.Forms.TableLayoutPanel();
            this.pnlActiveStudents = new System.Windows.Forms.Panel();
            this.lblactstdValue = new System.Windows.Forms.Label();
            this.lblactstd = new System.Windows.Forms.Label();
            this.pnlTotalSudents = new System.Windows.Forms.Panel();
            this.lbl_stdValue = new System.Windows.Forms.Label();
            this.lblstd = new System.Windows.Forms.Label();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.btntoggleStd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlsubmissions = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlsubmissionsCards = new System.Windows.Forms.Panel();
            this.dgvSubmiisions = new System.Windows.Forms.DataGridView();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.pnlTestCases = new System.Windows.Forms.Panel();
            this.btnAddTestCase = new System.Windows.Forms.Button();
            this.btnUpdateTestCase = new System.Windows.Forms.Button();
            this.btnToggleTestCase = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.totalTestCases = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.InActiveTestCases = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.ActTestCases = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.dgvTestCases = new System.Windows.Forms.DataGridView();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.tlpnlSubmission = new System.Windows.Forms.TableLayoutPanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.totalsubValue = new System.Windows.Forms.Label();
            this.lblSubmissions = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.RegSubValue = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.AccSubValue = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.dgvAdmins = new System.Windows.Forms.DataGridView();
            this.pnladmin = new System.Windows.Forms.Panel();
            this.tlpnlAdmin = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTotalStudents = new System.Windows.Forms.Panel();
            this.lblTotalStd = new System.Windows.Forms.Label();
            this.lblStdValue = new System.Windows.Forms.Label();
            this.pnlTotalContests = new System.Windows.Forms.Panel();
            this.lblTotalContests = new System.Windows.Forms.Label();
            this.lblContestValue = new System.Windows.Forms.Label();
            this.pnlTotalProblems = new System.Windows.Forms.Panel();
            this.lblTotalProblems = new System.Windows.Forms.Label();
            this.lblProblemValue = new System.Windows.Forms.Label();
            this.pnlTotalAdmins = new System.Windows.Forms.Panel();
            this.lblTotalAdmins = new System.Windows.Forms.Label();
            this.lbladminValue = new System.Windows.Forms.Label();
            this.btnToggleAdmin = new System.Windows.Forms.Button();
            this.btnUpdateAdmin = new System.Windows.Forms.Button();
            this.btnAddAdmin = new System.Windows.Forms.Button();
            this.pnlSuperAdmin = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.ContestValue = new System.Windows.Forms.Label();
            this.pnlTotalContest = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.ActContestValue = new System.Windows.Forms.Label();
            this.pnlactContest = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.InActcontestValue = new System.Windows.Forms.Label();
            this.pnlinactContest = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.UpcommingContestValue = new System.Windows.Forms.Label();
            this.pnlUpcommingContest = new System.Windows.Forms.Panel();
            this.pnlSidebar.SuspendLayout();
            this.pnlProblems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProblems)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlTotalProb.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnlContest.SuspendLayout();
            this.ContestCards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContest)).BeginInit();
            this.panel11.SuspendLayout();
            this.pnlnactiveStudents.SuspendLayout();
            this.pnlStudent.SuspendLayout();
            this.pnlstd.SuspendLayout();
            this.tlpnlStudents.SuspendLayout();
            this.pnlActiveStudents.SuspendLayout();
            this.pnlTotalSudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.panel3.SuspendLayout();
            this.pnlsubmissions.SuspendLayout();
            this.pnlsubmissionsCards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubmiisions)).BeginInit();
            this.panel13.SuspendLayout();
            this.pnlTestCases.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestCases)).BeginInit();
            this.panel17.SuspendLayout();
            this.tlpnlSubmission.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel12.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmins)).BeginInit();
            this.pnladmin.SuspendLayout();
            this.tlpnlAdmin.SuspendLayout();
            this.pnlTotalStudents.SuspendLayout();
            this.pnlTotalContests.SuspendLayout();
            this.pnlTotalProblems.SuspendLayout();
            this.pnlTotalAdmins.SuspendLayout();
            this.pnlSuperAdmin.SuspendLayout();
            this.pnlTotalContest.SuspendLayout();
            this.pnlactContest.SuspendLayout();
            this.pnlinactContest.SuspendLayout();
            this.pnlUpcommingContest.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlSidebar.Controls.Add(this.btnSettings);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.btnSubmissions);
            this.pnlSidebar.Controls.Add(this.btnContestLeaderboard);
            this.pnlSidebar.Controls.Add(this.btn_contests);
            this.pnlSidebar.Controls.Add(this.btnTestCases);
            this.pnlSidebar.Controls.Add(this.btn_problems);
            this.pnlSidebar.Controls.Add(this.btn_students);
            this.pnlSidebar.Controls.Add(this.btnAdmin);
            this.pnlSidebar.Controls.Add(this.btnHome);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(200, 561);
            this.pnlSidebar.TabIndex = 1;
            // 
            // btnSettings
            // 
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(0, 461);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(200, 50);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "Settings";
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 511);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 50);
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
            this.btnSubmissions.Location = new System.Drawing.Point(0, 350);
            this.btnSubmissions.Name = "btnSubmissions";
            this.btnSubmissions.Size = new System.Drawing.Size(200, 50);
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
            this.btnContestLeaderboard.Location = new System.Drawing.Point(0, 300);
            this.btnContestLeaderboard.Name = "btnContestLeaderboard";
            this.btnContestLeaderboard.Size = new System.Drawing.Size(200, 50);
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
            this.btn_contests.Location = new System.Drawing.Point(0, 250);
            this.btn_contests.Name = "btn_contests";
            this.btn_contests.Size = new System.Drawing.Size(200, 50);
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
            this.btnTestCases.Location = new System.Drawing.Point(0, 200);
            this.btnTestCases.Name = "btnTestCases";
            this.btnTestCases.Size = new System.Drawing.Size(200, 50);
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
            this.btn_problems.Location = new System.Drawing.Point(0, 150);
            this.btn_problems.Name = "btn_problems";
            this.btn_problems.Size = new System.Drawing.Size(200, 50);
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
            this.btn_students.Location = new System.Drawing.Point(0, 100);
            this.btn_students.Name = "btn_students";
            this.btn_students.Size = new System.Drawing.Size(200, 50);
            this.btn_students.TabIndex = 1;
            this.btn_students.Text = "Manage Students";
            this.btn_students.Click += new System.EventHandler(this.btn_students_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Location = new System.Drawing.Point(0, 50);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(200, 50);
            this.btnAdmin.TabIndex = 10;
            this.btnAdmin.Text = "Manage Admins";
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(200, 50);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "Home";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlProblems
            // 
            this.pnlProblems.Controls.Add(this.dgvProblems);
            this.pnlProblems.Controls.Add(this.panel1);
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
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProblems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvProblems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProblems.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvProblems.Location = new System.Drawing.Point(25, 292);
            this.dgvProblems.Name = "dgvProblems";
            this.dgvProblems.RowHeadersWidth = 35;
            this.dgvProblems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProblems.Size = new System.Drawing.Size(754, 248);
            this.dgvProblems.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.pnlTotalProb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 164);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblInActProbValue);
            this.panel2.Controls.Add(this.lblInActProb);
            this.panel2.Location = new System.Drawing.Point(572, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 130);
            this.panel2.TabIndex = 2;
            // 
            // lblInActProbValue
            // 
            this.lblInActProbValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInActProbValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblInActProbValue.Location = new System.Drawing.Point(0, 23);
            this.lblInActProbValue.Name = "lblInActProbValue";
            this.lblInActProbValue.Size = new System.Drawing.Size(148, 105);
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
            this.lblInActProb.Size = new System.Drawing.Size(148, 23);
            this.lblInActProb.TabIndex = 1;
            this.lblInActProb.Text = "Inactive Problems";
            this.lblInActProb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblActProbValue);
            this.panel4.Controls.Add(this.lblActProb);
            this.panel4.Location = new System.Drawing.Point(335, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 130);
            this.panel4.TabIndex = 2;
            // 
            // lblActProbValue
            // 
            this.lblActProbValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActProbValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblActProbValue.Location = new System.Drawing.Point(0, 23);
            this.lblActProbValue.Name = "lblActProbValue";
            this.lblActProbValue.Size = new System.Drawing.Size(148, 105);
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
            this.lblActProb.Size = new System.Drawing.Size(148, 23);
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
            this.pnlTotalProb.Location = new System.Drawing.Point(98, 17);
            this.pnlTotalProb.Name = "pnlTotalProb";
            this.pnlTotalProb.Size = new System.Drawing.Size(150, 130);
            this.pnlTotalProb.TabIndex = 0;
            // 
            // lblTotalProbValue
            // 
            this.lblTotalProbValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalProbValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTotalProbValue.Location = new System.Drawing.Point(0, 23);
            this.lblTotalProbValue.Name = "lblTotalProbValue";
            this.lblTotalProbValue.Size = new System.Drawing.Size(148, 105);
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
            this.lblTotalProb.Size = new System.Drawing.Size(148, 23);
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
            this.pnlContest.Controls.Add(this.btnToggleContest);
            this.pnlContest.Controls.Add(this.panel11);
            this.pnlContest.Location = new System.Drawing.Point(199, 2);
            this.pnlContest.Name = "pnlContest";
            this.pnlContest.Size = new System.Drawing.Size(805, 557);
            this.pnlContest.TabIndex = 6;
            // 
            // ContestCards
            // 
            this.ContestCards.BackColor = System.Drawing.Color.White;
            this.ContestCards.Controls.Add(this.tlpnlContest);
            this.ContestCards.Controls.Add(this.pnlUpcommingContest);
            this.ContestCards.Controls.Add(this.pnlinactContest);
            this.ContestCards.Controls.Add(this.pnlactContest);
            this.ContestCards.Controls.Add(this.pnlTotalContest);
            this.ContestCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContestCards.Location = new System.Drawing.Point(0, 50);
            this.ContestCards.Name = "ContestCards";
            this.ContestCards.Size = new System.Drawing.Size(805, 164);
            this.ContestCards.TabIndex = 13;
            // 
            // tlpnlContest
            // 
            this.tlpnlContest.ColumnCount = 4;
            this.tlpnlContest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpnlContest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpnlContest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpnlContest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpnlContest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpnlContest.Location = new System.Drawing.Point(0, 0);
            this.tlpnlContest.Name = "tlpnlContest";
            this.tlpnlContest.Padding = new System.Windows.Forms.Padding(10);
            this.tlpnlContest.RowCount = 1;
            this.tlpnlContest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpnlContest.Size = new System.Drawing.Size(805, 164);
            this.tlpnlContest.TabIndex = 4;
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
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvContest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContest.DefaultCellStyle = dataGridViewCellStyle17;
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
            // btnToggleContest
            // 
            this.btnToggleContest.BackColor = System.Drawing.Color.IndianRed;
            this.btnToggleContest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleContest.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnToggleContest.ForeColor = System.Drawing.Color.White;
            this.btnToggleContest.Location = new System.Drawing.Point(327, 227);
            this.btnToggleContest.Name = "btnToggleContest";
            this.btnToggleContest.Size = new System.Drawing.Size(140, 41);
            this.btnToggleContest.TabIndex = 10;
            this.btnToggleContest.Text = "Toggle Status";
            this.btnToggleContest.UseVisualStyleBackColor = false;
            this.btnToggleContest.Click += new System.EventHandler(this.btnToggleContest_Click);
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
            // pnlnactiveStudents
            // 
            this.pnlnactiveStudents.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlnactiveStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlnactiveStudents.Controls.Add(this.lblinactstdValue);
            this.pnlnactiveStudents.Controls.Add(this.lblinactstd);
            this.pnlnactiveStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlnactiveStudents.Location = new System.Drawing.Point(542, 20);
            this.pnlnactiveStudents.Margin = new System.Windows.Forms.Padding(10);
            this.pnlnactiveStudents.Name = "pnlnactiveStudents";
            this.pnlnactiveStudents.Size = new System.Drawing.Size(243, 124);
            this.pnlnactiveStudents.TabIndex = 0;
            // 
            // lblinactstdValue
            // 
            this.lblinactstdValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblinactstdValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblinactstdValue.Location = new System.Drawing.Point(0, 30);
            this.lblinactstdValue.Name = "lblinactstdValue";
            this.lblinactstdValue.Size = new System.Drawing.Size(241, 92);
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
            this.lblinactstd.Size = new System.Drawing.Size(241, 30);
            this.lblinactstd.TabIndex = 1;
            this.lblinactstd.Text = "Inactive Students";
            this.lblinactstd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.pnlStudent.TabIndex = 10;
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
            this.tlpnlStudents.Controls.Add(this.pnlActiveStudents, 0, 0);
            this.tlpnlStudents.Controls.Add(this.pnlTotalSudents, 1, 0);
            this.tlpnlStudents.Controls.Add(this.pnlnactiveStudents, 2, 0);
            this.tlpnlStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpnlStudents.Location = new System.Drawing.Point(0, 0);
            this.tlpnlStudents.Name = "tlpnlStudents";
            this.tlpnlStudents.Padding = new System.Windows.Forms.Padding(10);
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
            this.pnlActiveStudents.Location = new System.Drawing.Point(20, 20);
            this.pnlActiveStudents.Margin = new System.Windows.Forms.Padding(10);
            this.pnlActiveStudents.Name = "pnlActiveStudents";
            this.pnlActiveStudents.Size = new System.Drawing.Size(241, 124);
            this.pnlActiveStudents.TabIndex = 2;
            // 
            // lblactstdValue
            // 
            this.lblactstdValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblactstdValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblactstdValue.Location = new System.Drawing.Point(0, 30);
            this.lblactstdValue.Name = "lblactstdValue";
            this.lblactstdValue.Size = new System.Drawing.Size(239, 92);
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
            this.lblactstd.Size = new System.Drawing.Size(239, 30);
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
            this.pnlTotalSudents.Location = new System.Drawing.Point(281, 20);
            this.pnlTotalSudents.Margin = new System.Windows.Forms.Padding(10);
            this.pnlTotalSudents.Name = "pnlTotalSudents";
            this.pnlTotalSudents.Size = new System.Drawing.Size(241, 124);
            this.pnlTotalSudents.TabIndex = 4;
            // 
            // lbl_stdValue
            // 
            this.lbl_stdValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_stdValue.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stdValue.Location = new System.Drawing.Point(0, 30);
            this.lbl_stdValue.Name = "lbl_stdValue";
            this.lbl_stdValue.Size = new System.Drawing.Size(239, 92);
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
            this.lblstd.Size = new System.Drawing.Size(239, 30);
            this.lblstd.TabIndex = 1;
            this.lblstd.Text = "Total Students";
            this.lblstd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudents.DefaultCellStyle = dataGridViewCellStyle19;
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
            // pnlsubmissions
            // 
            this.pnlsubmissions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlsubmissions.Controls.Add(this.label1);
            this.pnlsubmissions.Controls.Add(this.pnlsubmissionsCards);
            this.pnlsubmissions.Controls.Add(this.dgvSubmiisions);
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
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
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
            // dgvSubmiisions
            // 
            this.dgvSubmiisions.AllowUserToAddRows = false;
            this.dgvSubmiisions.AllowUserToDeleteRows = false;
            this.dgvSubmiisions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSubmiisions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubmiisions.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubmiisions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvSubmiisions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubmiisions.DefaultCellStyle = dataGridViewCellStyle21;
            this.dgvSubmiisions.Location = new System.Drawing.Point(25, 285);
            this.dgvSubmiisions.Name = "dgvSubmiisions";
            this.dgvSubmiisions.ReadOnly = true;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubmiisions.RowHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvSubmiisions.RowHeadersWidth = 35;
            this.dgvSubmiisions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSubmiisions.Size = new System.Drawing.Size(752, 247);
            this.dgvSubmiisions.TabIndex = 7;
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
            this.pnlTestCases.Controls.Add(this.panel7);
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
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Controls.Add(this.panel14);
            this.panel7.Controls.Add(this.panel16);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 50);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(805, 180);
            this.panel7.TabIndex = 11;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.totalTestCases);
            this.panel10.Controls.Add(this.label10);
            this.panel10.Location = new System.Drawing.Point(67, 27);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(150, 130);
            this.panel10.TabIndex = 4;
            // 
            // totalTestCases
            // 
            this.totalTestCases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalTestCases.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTestCases.Location = new System.Drawing.Point(0, 30);
            this.totalTestCases.Name = "totalTestCases";
            this.totalTestCases.Size = new System.Drawing.Size(148, 98);
            this.totalTestCases.TabIndex = 0;
            this.totalTestCases.Text = "5";
            this.totalTestCases.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 30);
            this.label10.TabIndex = 1;
            this.label10.Text = "Total Test Cases";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.Controls.Add(this.InActiveTestCases);
            this.panel14.Controls.Add(this.label13);
            this.panel14.Location = new System.Drawing.Point(587, 23);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(150, 130);
            this.panel14.TabIndex = 0;
            // 
            // InActiveTestCases
            // 
            this.InActiveTestCases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InActiveTestCases.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.InActiveTestCases.Location = new System.Drawing.Point(0, 30);
            this.InActiveTestCases.Name = "InActiveTestCases";
            this.InActiveTestCases.Size = new System.Drawing.Size(148, 98);
            this.InActiveTestCases.TabIndex = 0;
            this.InActiveTestCases.Text = "215";
            this.InActiveTestCases.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(148, 30);
            this.label13.TabIndex = 1;
            this.label13.Text = "Inactive Test Cases";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel16.Controls.Add(this.ActTestCases);
            this.panel16.Controls.Add(this.label19);
            this.panel16.Location = new System.Drawing.Point(327, 28);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(150, 130);
            this.panel16.TabIndex = 2;
            // 
            // ActTestCases
            // 
            this.ActTestCases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActTestCases.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.ActTestCases.Location = new System.Drawing.Point(0, 30);
            this.ActTestCases.Name = "ActTestCases";
            this.ActTestCases.Size = new System.Drawing.Size(148, 98);
            this.ActTestCases.TabIndex = 0;
            this.ActTestCases.Text = "3";
            this.ActTestCases.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.Dock = System.Windows.Forms.DockStyle.Top;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(0, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(148, 30);
            this.label19.TabIndex = 1;
            this.label19.Text = "Active Test Cases";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTestCases.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgvTestCases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTestCases.DefaultCellStyle = dataGridViewCellStyle24;
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
            // tlpnlSubmission
            // 
            this.tlpnlSubmission.ColumnCount = 3;
            this.tlpnlSubmission.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpnlSubmission.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpnlSubmission.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpnlSubmission.Controls.Add(this.panel12, 0, 0);
            this.tlpnlSubmission.Controls.Add(this.panel9, 1, 0);
            this.tlpnlSubmission.Controls.Add(this.panel8, 0, 0);
            this.tlpnlSubmission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpnlSubmission.Location = new System.Drawing.Point(0, 0);
            this.tlpnlSubmission.Margin = new System.Windows.Forms.Padding(20);
            this.tlpnlSubmission.Name = "tlpnlSubmission";
            this.tlpnlSubmission.Padding = new System.Windows.Forms.Padding(25);
            this.tlpnlSubmission.RowCount = 1;
            this.tlpnlSubmission.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpnlSubmission.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpnlSubmission.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpnlSubmission.Size = new System.Drawing.Size(805, 180);
            this.tlpnlSubmission.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.totalsubValue);
            this.panel8.Controls.Add(this.lblSubmissions);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(28, 28);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(245, 124);
            this.panel8.TabIndex = 5;
            // 
            // totalsubValue
            // 
            this.totalsubValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalsubValue.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalsubValue.Location = new System.Drawing.Point(0, 30);
            this.totalsubValue.Name = "totalsubValue";
            this.totalsubValue.Size = new System.Drawing.Size(243, 92);
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
            this.lblSubmissions.Size = new System.Drawing.Size(243, 30);
            this.lblSubmissions.TabIndex = 1;
            this.lblSubmissions.Text = "Total Submissions";
            this.lblSubmissions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.RegSubValue);
            this.panel9.Controls.Add(this.label11);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(530, 28);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(247, 124);
            this.panel9.TabIndex = 6;
            // 
            // RegSubValue
            // 
            this.RegSubValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegSubValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.RegSubValue.Location = new System.Drawing.Point(0, 30);
            this.RegSubValue.Name = "RegSubValue";
            this.RegSubValue.Size = new System.Drawing.Size(245, 92);
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
            this.label11.Size = new System.Drawing.Size(245, 30);
            this.label11.TabIndex = 1;
            this.label11.Text = "Rejected";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Controls.Add(this.AccSubValue);
            this.panel12.Controls.Add(this.label15);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(279, 28);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(245, 124);
            this.panel12.TabIndex = 7;
            // 
            // AccSubValue
            // 
            this.AccSubValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AccSubValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.AccSubValue.Location = new System.Drawing.Point(0, 30);
            this.AccSubValue.Name = "AccSubValue";
            this.AccSubValue.Size = new System.Drawing.Size(243, 92);
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
            this.label15.Size = new System.Drawing.Size(243, 30);
            this.label15.TabIndex = 1;
            this.label15.Text = "Accepted ";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.pnlHeader.Controls.Add(this.lblMainTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(805, 50);
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
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdmins.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvAdmins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdmins.DefaultCellStyle = dataGridViewCellStyle26;
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
            this.pnladmin.Location = new System.Drawing.Point(0, 50);
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
            this.tlpnlAdmin.Padding = new System.Windows.Forms.Padding(10);
            this.tlpnlAdmin.RowCount = 1;
            this.tlpnlAdmin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpnlAdmin.Size = new System.Drawing.Size(805, 180);
            this.tlpnlAdmin.TabIndex = 1;
            // 
            // pnlTotalStudents
            // 
            this.pnlTotalStudents.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTotalStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalStudents.Controls.Add(this.lblStdValue);
            this.pnlTotalStudents.Controls.Add(this.lblTotalStd);
            this.pnlTotalStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTotalStudents.Location = new System.Drawing.Point(608, 20);
            this.pnlTotalStudents.Margin = new System.Windows.Forms.Padding(10);
            this.pnlTotalStudents.Name = "pnlTotalStudents";
            this.pnlTotalStudents.Size = new System.Drawing.Size(177, 140);
            this.pnlTotalStudents.TabIndex = 2;
            // 
            // lblTotalStd
            // 
            this.lblTotalStd.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalStd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalStd.Location = new System.Drawing.Point(0, 0);
            this.lblTotalStd.Name = "lblTotalStd";
            this.lblTotalStd.Size = new System.Drawing.Size(175, 30);
            this.lblTotalStd.TabIndex = 1;
            this.lblTotalStd.Text = "Total Students";
            this.lblTotalStd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblStdValue
            // 
            this.lblStdValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStdValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblStdValue.Location = new System.Drawing.Point(0, 30);
            this.lblStdValue.Name = "lblStdValue";
            this.lblStdValue.Size = new System.Drawing.Size(175, 108);
            this.lblStdValue.TabIndex = 0;
            this.lblStdValue.Text = "3";
            this.lblStdValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTotalContests
            // 
            this.pnlTotalContests.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTotalContests.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalContests.Controls.Add(this.lblContestValue);
            this.pnlTotalContests.Controls.Add(this.lblTotalContests);
            this.pnlTotalContests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTotalContests.Location = new System.Drawing.Point(412, 20);
            this.pnlTotalContests.Margin = new System.Windows.Forms.Padding(10);
            this.pnlTotalContests.Name = "pnlTotalContests";
            this.pnlTotalContests.Size = new System.Drawing.Size(176, 140);
            this.pnlTotalContests.TabIndex = 1;
            // 
            // lblTotalContests
            // 
            this.lblTotalContests.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalContests.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalContests.Location = new System.Drawing.Point(0, 0);
            this.lblTotalContests.Name = "lblTotalContests";
            this.lblTotalContests.Size = new System.Drawing.Size(174, 30);
            this.lblTotalContests.TabIndex = 1;
            this.lblTotalContests.Text = "Total Contests";
            this.lblTotalContests.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblContestValue
            // 
            this.lblContestValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblContestValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblContestValue.Location = new System.Drawing.Point(0, 30);
            this.lblContestValue.Name = "lblContestValue";
            this.lblContestValue.Size = new System.Drawing.Size(174, 108);
            this.lblContestValue.TabIndex = 0;
            this.lblContestValue.Text = "1,250";
            this.lblContestValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTotalProblems
            // 
            this.pnlTotalProblems.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTotalProblems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalProblems.Controls.Add(this.lblProblemValue);
            this.pnlTotalProblems.Controls.Add(this.lblTotalProblems);
            this.pnlTotalProblems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTotalProblems.Location = new System.Drawing.Point(216, 20);
            this.pnlTotalProblems.Margin = new System.Windows.Forms.Padding(10);
            this.pnlTotalProblems.Name = "pnlTotalProblems";
            this.pnlTotalProblems.Size = new System.Drawing.Size(176, 140);
            this.pnlTotalProblems.TabIndex = 0;
            // 
            // lblTotalProblems
            // 
            this.lblTotalProblems.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalProblems.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalProblems.Location = new System.Drawing.Point(0, 0);
            this.lblTotalProblems.Name = "lblTotalProblems";
            this.lblTotalProblems.Size = new System.Drawing.Size(174, 30);
            this.lblTotalProblems.TabIndex = 1;
            this.lblTotalProblems.Text = "Total Problems";
            this.lblTotalProblems.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblProblemValue
            // 
            this.lblProblemValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProblemValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblProblemValue.Location = new System.Drawing.Point(0, 30);
            this.lblProblemValue.Name = "lblProblemValue";
            this.lblProblemValue.Size = new System.Drawing.Size(174, 108);
            this.lblProblemValue.TabIndex = 0;
            this.lblProblemValue.Text = "215";
            this.lblProblemValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTotalAdmins
            // 
            this.pnlTotalAdmins.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTotalAdmins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalAdmins.Controls.Add(this.lbladminValue);
            this.pnlTotalAdmins.Controls.Add(this.lblTotalAdmins);
            this.pnlTotalAdmins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTotalAdmins.Location = new System.Drawing.Point(20, 20);
            this.pnlTotalAdmins.Margin = new System.Windows.Forms.Padding(10);
            this.pnlTotalAdmins.Name = "pnlTotalAdmins";
            this.pnlTotalAdmins.Size = new System.Drawing.Size(176, 140);
            this.pnlTotalAdmins.TabIndex = 4;
            // 
            // lblTotalAdmins
            // 
            this.lblTotalAdmins.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalAdmins.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalAdmins.Location = new System.Drawing.Point(0, 0);
            this.lblTotalAdmins.Name = "lblTotalAdmins";
            this.lblTotalAdmins.Size = new System.Drawing.Size(174, 30);
            this.lblTotalAdmins.TabIndex = 1;
            this.lblTotalAdmins.Text = "Total Admins";
            this.lblTotalAdmins.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbladminValue
            // 
            this.lbladminValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbladminValue.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladminValue.Location = new System.Drawing.Point(0, 30);
            this.lbladminValue.Name = "lbladminValue";
            this.lbladminValue.Size = new System.Drawing.Size(174, 108);
            this.lbladminValue.TabIndex = 0;
            this.lbladminValue.Text = "5";
            this.lbladminValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(803, 23);
            this.label8.TabIndex = 1;
            this.label8.Text = "Total Contests";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ContestValue
            // 
            this.ContestValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContestValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.ContestValue.Location = new System.Drawing.Point(0, 23);
            this.ContestValue.Name = "ContestValue";
            this.ContestValue.Size = new System.Drawing.Size(803, 139);
            this.ContestValue.TabIndex = 0;
            this.ContestValue.Text = "0";
            this.ContestValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTotalContest
            // 
            this.pnlTotalContest.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTotalContest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalContest.Controls.Add(this.ContestValue);
            this.pnlTotalContest.Controls.Add(this.label8);
            this.pnlTotalContest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTotalContest.Location = new System.Drawing.Point(0, 0);
            this.pnlTotalContest.Margin = new System.Windows.Forms.Padding(10);
            this.pnlTotalContest.Name = "pnlTotalContest";
            this.pnlTotalContest.Size = new System.Drawing.Size(805, 164);
            this.pnlTotalContest.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(803, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Active Contests";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ActContestValue
            // 
            this.ActContestValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActContestValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.ActContestValue.Location = new System.Drawing.Point(0, 23);
            this.ActContestValue.Name = "ActContestValue";
            this.ActContestValue.Size = new System.Drawing.Size(803, 139);
            this.ActContestValue.TabIndex = 0;
            this.ActContestValue.Text = "0";
            this.ActContestValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlactContest
            // 
            this.pnlactContest.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlactContest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlactContest.Controls.Add(this.ActContestValue);
            this.pnlactContest.Controls.Add(this.label5);
            this.pnlactContest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlactContest.Location = new System.Drawing.Point(0, 0);
            this.pnlactContest.Margin = new System.Windows.Forms.Padding(10);
            this.pnlactContest.Name = "pnlactContest";
            this.pnlactContest.Size = new System.Drawing.Size(805, 164);
            this.pnlactContest.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(803, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Inactive Contests";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // InActcontestValue
            // 
            this.InActcontestValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InActcontestValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.InActcontestValue.Location = new System.Drawing.Point(0, 23);
            this.InActcontestValue.Name = "InActcontestValue";
            this.InActcontestValue.Size = new System.Drawing.Size(803, 139);
            this.InActcontestValue.TabIndex = 0;
            this.InActcontestValue.Text = "0";
            this.InActcontestValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlinactContest
            // 
            this.pnlinactContest.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlinactContest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlinactContest.Controls.Add(this.InActcontestValue);
            this.pnlinactContest.Controls.Add(this.label3);
            this.pnlinactContest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlinactContest.Location = new System.Drawing.Point(0, 0);
            this.pnlinactContest.Margin = new System.Windows.Forms.Padding(20);
            this.pnlinactContest.Name = "pnlinactContest";
            this.pnlinactContest.Size = new System.Drawing.Size(805, 164);
            this.pnlinactContest.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(803, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Upcomming Contests";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UpcommingContestValue
            // 
            this.UpcommingContestValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpcommingContestValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.UpcommingContestValue.Location = new System.Drawing.Point(0, 23);
            this.UpcommingContestValue.Name = "UpcommingContestValue";
            this.UpcommingContestValue.Size = new System.Drawing.Size(803, 139);
            this.UpcommingContestValue.TabIndex = 0;
            this.UpcommingContestValue.Text = "0";
            this.UpcommingContestValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlUpcommingContest
            // 
            this.pnlUpcommingContest.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlUpcommingContest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUpcommingContest.Controls.Add(this.UpcommingContestValue);
            this.pnlUpcommingContest.Controls.Add(this.label4);
            this.pnlUpcommingContest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUpcommingContest.Location = new System.Drawing.Point(0, 0);
            this.pnlUpcommingContest.Margin = new System.Windows.Forms.Padding(10);
            this.pnlUpcommingContest.Name = "pnlUpcommingContest";
            this.pnlUpcommingContest.Size = new System.Drawing.Size(805, 164);
            this.pnlUpcommingContest.TabIndex = 3;
            // 
            // AdminDashboardUI
            // 
            this.ClientSize = new System.Drawing.Size(1004, 561);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlStudent);
            this.Controls.Add(this.pnlSuperAdmin);
            this.Controls.Add(this.pnlContest);
            this.Controls.Add(this.pnlProblems);
            this.Controls.Add(this.pnlTestCases);
            this.Controls.Add(this.pnlsubmissions);
            this.Name = "AdminDashboardUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlProblems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProblems)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.pnlTotalProb.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.pnlContest.ResumeLayout(false);
            this.ContestCards.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContest)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.pnlnactiveStudents.ResumeLayout(false);
            this.pnlStudent.ResumeLayout(false);
            this.pnlstd.ResumeLayout(false);
            this.tlpnlStudents.ResumeLayout(false);
            this.pnlActiveStudents.ResumeLayout(false);
            this.pnlTotalSudents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlsubmissions.ResumeLayout(false);
            this.pnlsubmissions.PerformLayout();
            this.pnlsubmissionsCards.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubmiisions)).EndInit();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.pnlTestCases.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestCases)).EndInit();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.tlpnlSubmission.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmins)).EndInit();
            this.pnladmin.ResumeLayout(false);
            this.tlpnlAdmin.ResumeLayout(false);
            this.pnlTotalStudents.ResumeLayout(false);
            this.pnlTotalContests.ResumeLayout(false);
            this.pnlTotalProblems.ResumeLayout(false);
            this.pnlTotalAdmins.ResumeLayout(false);
            this.pnlSuperAdmin.ResumeLayout(false);
            this.pnlTotalContest.ResumeLayout(false);
            this.pnlactContest.ResumeLayout(false);
            this.pnlinactContest.ResumeLayout(false);
            this.pnlUpcommingContest.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btn_contests;
        private System.Windows.Forms.Button btn_problems;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnTestCases;
        private System.Windows.Forms.Panel pnlProblems;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblInActProbValue;
        private System.Windows.Forms.Label lblInActProb;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblActProbValue;
        private System.Windows.Forms.Label lblActProb;
        private System.Windows.Forms.Panel pnlTotalProb;
        private System.Windows.Forms.Label lblTotalProbValue;
        private System.Windows.Forms.Label lblTotalProb;
        private System.Windows.Forms.Button btnAddProb;
        private System.Windows.Forms.Button btnUpdateProb;
        private System.Windows.Forms.Button btnToggleProb;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlContest;
        private System.Windows.Forms.DataGridView dgvContest;
        private System.Windows.Forms.Button btnAddContest;
        private System.Windows.Forms.Button btnUpdContest;
        private System.Windows.Forms.Button btnToggleContest;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSubmissions;
        private System.Windows.Forms.Button btnContestLeaderboard;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Panel pnlStudent;
        private System.Windows.Forms.Panel pnlstd;
        private System.Windows.Forms.Panel pnlTotalSudents;
        private System.Windows.Forms.Label lbl_stdValue;
        private System.Windows.Forms.Label lblstd;
        private System.Windows.Forms.Panel pnlnactiveStudents;
        private System.Windows.Forms.Label lblinactstdValue;
        private System.Windows.Forms.Label lblinactstd;
        private System.Windows.Forms.Panel pnlActiveStudents;
        private System.Windows.Forms.Label lblactstdValue;
        private System.Windows.Forms.Label lblactstd;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Button btntoggleStd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlsubmissions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlsubmissionsCards;
        private System.Windows.Forms.DataGridView dgvSubmiisions;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel pnlTestCases;
        private System.Windows.Forms.Button btnAddTestCase;
        private System.Windows.Forms.Button btnUpdateTestCase;
        private System.Windows.Forms.Button btnToggleTestCase;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label totalTestCases;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label InActiveTestCases;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label ActTestCases;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView dgvTestCases;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView dgvProblems;
        private System.Windows.Forms.TableLayoutPanel tlpnlStudents;
        private Panel ContestCards;
        private TableLayoutPanel tlpnlContest;
        private TableLayoutPanel tlpnlSubmission;
        private Panel panel12;
        private Label AccSubValue;
        private Label label15;
        private Panel panel9;
        private Label RegSubValue;
        private Label label11;
        private Panel panel8;
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
        private Panel pnlUpcommingContest;
        private Label UpcommingContestValue;
        private Label label4;
        private Panel pnlinactContest;
        private Label InActcontestValue;
        private Label label3;
        private Panel pnlactContest;
        private Label ActContestValue;
        private Label label5;
        private Panel pnlTotalContest;
        private Label ContestValue;
        private Label label8;
    }
}