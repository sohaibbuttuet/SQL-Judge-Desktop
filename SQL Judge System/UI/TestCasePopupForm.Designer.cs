namespace SQL_Judge_System.UI
{
    partial class TestCasePopupForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.Panel updatePanel;

        // ================= ADD PANEL =================
        private System.Windows.Forms.Label lblAddTitle;

        private System.Windows.Forms.Label lblAProblem;
        private System.Windows.Forms.Label lblASetupSQL;
        private System.Windows.Forms.Label lblASolutionQuery;

        private System.Windows.Forms.ComboBox cmbAProblem;
        private System.Windows.Forms.TextBox txtASetupSQL;
        private System.Windows.Forms.TextBox txtASolutionQuery;

        // ================= UPDATE PANEL =================
        private System.Windows.Forms.Label lblUpdateTitle;
        private System.Windows.Forms.Label lblUProblem;
        private System.Windows.Forms.Label lblUSetupSQL;
        private System.Windows.Forms.Label lblUSolutionQuery;
        private System.Windows.Forms.ComboBox cmbUProblem;
        private System.Windows.Forms.TextBox txtUSetupSQL;
        private System.Windows.Forms.TextBox txtUSolutionQuery;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.addPanel = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAClear = new System.Windows.Forms.Button();
            this.lblAddTitle = new System.Windows.Forms.Label();
            this.lblAProblem = new System.Windows.Forms.Label();
            this.cmbAProblem = new System.Windows.Forms.ComboBox();
            this.lblASetupSQL = new System.Windows.Forms.Label();
            this.txtASetupSQL = new System.Windows.Forms.TextBox();
            this.lblASolutionQuery = new System.Windows.Forms.Label();
            this.txtASolutionQuery = new System.Windows.Forms.TextBox();
            this.updatePanel = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnUClear = new System.Windows.Forms.Button();
            this.lblUpdateTitle = new System.Windows.Forms.Label();
            this.lblUProblem = new System.Windows.Forms.Label();
            this.cmbUProblem = new System.Windows.Forms.ComboBox();
            this.lblUSetupSQL = new System.Windows.Forms.Label();
            this.txtUSetupSQL = new System.Windows.Forms.TextBox();
            this.lblUSolutionQuery = new System.Windows.Forms.Label();
            this.txtUSolutionQuery = new System.Windows.Forms.TextBox();
            this.txtTestCseName = new System.Windows.Forms.Label();
            this.txtATestName = new System.Windows.Forms.TextBox();
            this.txtUTestName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addPanel.SuspendLayout();
            this.updatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addPanel
            // 
            this.addPanel.Controls.Add(this.txtATestName);
            this.addPanel.Controls.Add(this.txtTestCseName);
            this.addPanel.Controls.Add(this.btnAdd);
            this.addPanel.Controls.Add(this.btnAClear);
            this.addPanel.Controls.Add(this.lblAddTitle);
            this.addPanel.Controls.Add(this.lblAProblem);
            this.addPanel.Controls.Add(this.cmbAProblem);
            this.addPanel.Controls.Add(this.lblASetupSQL);
            this.addPanel.Controls.Add(this.txtASetupSQL);
            this.addPanel.Controls.Add(this.lblASolutionQuery);
            this.addPanel.Controls.Add(this.txtASolutionQuery);
            this.addPanel.Location = new System.Drawing.Point(26, 28);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(564, 417);
            this.addPanel.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(20, 375);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAClear
            // 
            this.btnAClear.BackColor = System.Drawing.Color.IndianRed;
            this.btnAClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAClear.ForeColor = System.Drawing.Color.White;
            this.btnAClear.Location = new System.Drawing.Point(120, 375);
            this.btnAClear.Name = "btnAClear";
            this.btnAClear.Size = new System.Drawing.Size(75, 23);
            this.btnAClear.TabIndex = 10;
            this.btnAClear.Text = "Clear";
            this.btnAClear.UseVisualStyleBackColor = false;
            this.btnAClear.Click += new System.EventHandler(this.btnAClear_Click);
            // 
            // lblAddTitle
            // 
            this.lblAddTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddTitle.Location = new System.Drawing.Point(212, 14);
            this.lblAddTitle.Name = "lblAddTitle";
            this.lblAddTitle.Size = new System.Drawing.Size(141, 23);
            this.lblAddTitle.TabIndex = 0;
            this.lblAddTitle.Text = "Add Test Case";
            // 
            // lblAProblem
            // 
            this.lblAProblem.Location = new System.Drawing.Point(20, 97);
            this.lblAProblem.Name = "lblAProblem";
            this.lblAProblem.Size = new System.Drawing.Size(100, 14);
            this.lblAProblem.TabIndex = 1;
            this.lblAProblem.Text = "Problem";
            // 
            // cmbAProblem
            // 
            this.cmbAProblem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAProblem.Location = new System.Drawing.Point(20, 116);
            this.cmbAProblem.Name = "cmbAProblem";
            this.cmbAProblem.Size = new System.Drawing.Size(506, 21);
            this.cmbAProblem.TabIndex = 2;
            // 
            // lblASetupSQL
            // 
            this.lblASetupSQL.Location = new System.Drawing.Point(20, 147);
            this.lblASetupSQL.Name = "lblASetupSQL";
            this.lblASetupSQL.Size = new System.Drawing.Size(100, 17);
            this.lblASetupSQL.TabIndex = 3;
            this.lblASetupSQL.Text = "Setup SQL";
            // 
            // txtASetupSQL
            // 
            this.txtASetupSQL.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtASetupSQL.Location = new System.Drawing.Point(20, 166);
            this.txtASetupSQL.Multiline = true;
            this.txtASetupSQL.Name = "txtASetupSQL";
            this.txtASetupSQL.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtASetupSQL.Size = new System.Drawing.Size(506, 80);
            this.txtASetupSQL.TabIndex = 4;
            // 
            // lblASolutionQuery
            // 
            this.lblASolutionQuery.Location = new System.Drawing.Point(20, 257);
            this.lblASolutionQuery.Name = "lblASolutionQuery";
            this.lblASolutionQuery.Size = new System.Drawing.Size(100, 17);
            this.lblASolutionQuery.TabIndex = 5;
            this.lblASolutionQuery.Text = "Solution Query";
            // 
            // txtASolutionQuery
            // 
            this.txtASolutionQuery.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtASolutionQuery.Location = new System.Drawing.Point(20, 276);
            this.txtASolutionQuery.Multiline = true;
            this.txtASolutionQuery.Name = "txtASolutionQuery";
            this.txtASolutionQuery.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtASolutionQuery.Size = new System.Drawing.Size(506, 80);
            this.txtASolutionQuery.TabIndex = 6;
            // 
            // updatePanel
            // 
            this.updatePanel.Controls.Add(this.txtUTestName);
            this.updatePanel.Controls.Add(this.label1);
            this.updatePanel.Controls.Add(this.btnUpdate);
            this.updatePanel.Controls.Add(this.btnUClear);
            this.updatePanel.Controls.Add(this.lblUpdateTitle);
            this.updatePanel.Controls.Add(this.lblUProblem);
            this.updatePanel.Controls.Add(this.cmbUProblem);
            this.updatePanel.Controls.Add(this.lblUSetupSQL);
            this.updatePanel.Controls.Add(this.txtUSetupSQL);
            this.updatePanel.Controls.Add(this.lblUSolutionQuery);
            this.updatePanel.Controls.Add(this.txtUSolutionQuery);
            this.updatePanel.Location = new System.Drawing.Point(26, 28);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Size = new System.Drawing.Size(564, 417);
            this.updatePanel.TabIndex = 3;
            this.updatePanel.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(20, 365);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnUClear
            // 
            this.btnUClear.BackColor = System.Drawing.Color.IndianRed;
            this.btnUClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUClear.ForeColor = System.Drawing.Color.White;
            this.btnUClear.Location = new System.Drawing.Point(120, 365);
            this.btnUClear.Name = "btnUClear";
            this.btnUClear.Size = new System.Drawing.Size(75, 23);
            this.btnUClear.TabIndex = 12;
            this.btnUClear.Text = "Clear";
            this.btnUClear.UseVisualStyleBackColor = false;
            this.btnUClear.Click += new System.EventHandler(this.btnUClear_Click);
            // 
            // lblUpdateTitle
            // 
            this.lblUpdateTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateTitle.Location = new System.Drawing.Point(207, 19);
            this.lblUpdateTitle.Name = "lblUpdateTitle";
            this.lblUpdateTitle.Size = new System.Drawing.Size(166, 23);
            this.lblUpdateTitle.TabIndex = 0;
            this.lblUpdateTitle.Text = "Update Test Case";
            // 
            // lblUProblem
            // 
            this.lblUProblem.Location = new System.Drawing.Point(20, 112);
            this.lblUProblem.Name = "lblUProblem";
            this.lblUProblem.Size = new System.Drawing.Size(100, 11);
            this.lblUProblem.TabIndex = 3;
            this.lblUProblem.Text = "Problem";
            // 
            // cmbUProblem
            // 
            this.cmbUProblem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUProblem.Location = new System.Drawing.Point(20, 130);
            this.cmbUProblem.Name = "cmbUProblem";
            this.cmbUProblem.Size = new System.Drawing.Size(504, 21);
            this.cmbUProblem.TabIndex = 4;
            // 
            // lblUSetupSQL
            // 
            this.lblUSetupSQL.Location = new System.Drawing.Point(20, 163);
            this.lblUSetupSQL.Name = "lblUSetupSQL";
            this.lblUSetupSQL.Size = new System.Drawing.Size(100, 15);
            this.lblUSetupSQL.TabIndex = 5;
            this.lblUSetupSQL.Text = "Setup SQL";
            // 
            // txtUSetupSQL
            // 
            this.txtUSetupSQL.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtUSetupSQL.Location = new System.Drawing.Point(20, 180);
            this.txtUSetupSQL.Multiline = true;
            this.txtUSetupSQL.Name = "txtUSetupSQL";
            this.txtUSetupSQL.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtUSetupSQL.Size = new System.Drawing.Size(504, 70);
            this.txtUSetupSQL.TabIndex = 6;
            // 
            // lblUSolutionQuery
            // 
            this.lblUSolutionQuery.Location = new System.Drawing.Point(20, 259);
            this.lblUSolutionQuery.Name = "lblUSolutionQuery";
            this.lblUSolutionQuery.Size = new System.Drawing.Size(100, 14);
            this.lblUSolutionQuery.TabIndex = 7;
            this.lblUSolutionQuery.Text = "Solution Query";
            // 
            // txtUSolutionQuery
            // 
            this.txtUSolutionQuery.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtUSolutionQuery.Location = new System.Drawing.Point(20, 275);
            this.txtUSolutionQuery.Multiline = true;
            this.txtUSolutionQuery.Name = "txtUSolutionQuery";
            this.txtUSolutionQuery.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtUSolutionQuery.Size = new System.Drawing.Size(504, 70);
            this.txtUSolutionQuery.TabIndex = 8;
            // 
            // txtTestCseName
            // 
            this.txtTestCseName.Location = new System.Drawing.Point(22, 51);
            this.txtTestCseName.Name = "txtTestCseName";
            this.txtTestCseName.Size = new System.Drawing.Size(100, 14);
            this.txtTestCseName.TabIndex = 11;
            this.txtTestCseName.Text = "Test Case Name";
            // 
            // txtATestName
            // 
            this.txtATestName.Location = new System.Drawing.Point(20, 69);
            this.txtATestName.Name = "txtATestName";
            this.txtATestName.Size = new System.Drawing.Size(506, 20);
            this.txtATestName.TabIndex = 12;
            // 
            // txtUTestName
            // 
            this.txtUTestName.Location = new System.Drawing.Point(20, 82);
            this.txtUTestName.Name = "txtUTestName";
            this.txtUTestName.Size = new System.Drawing.Size(506, 20);
            this.txtUTestName.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(19, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 14);
            this.label1.TabIndex = 13;
            this.label1.Text = "Test Case New Name";
            // 
            // TestCasePopupForm
            // 
            this.ClientSize = new System.Drawing.Size(617, 472);
            this.Controls.Add(this.addPanel);
            this.Controls.Add(this.updatePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TestCasePopupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Case Management";
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            this.updatePanel.ResumeLayout(false);
            this.updatePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnUClear;
        private System.Windows.Forms.TextBox txtATestName;
        private System.Windows.Forms.Label txtTestCseName;
        private System.Windows.Forms.TextBox txtUTestName;
        private System.Windows.Forms.Label label1;
    }
}