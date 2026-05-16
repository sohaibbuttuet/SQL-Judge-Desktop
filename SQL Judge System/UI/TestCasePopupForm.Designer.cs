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

        private System.Windows.Forms.Label lblUTestCaseId;
        private System.Windows.Forms.Label lblUProblem;
        private System.Windows.Forms.Label lblUSetupSQL;
        private System.Windows.Forms.Label lblUSolutionQuery;

        private System.Windows.Forms.TextBox txtUTestCaseId;
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
            this.lblAddTitle = new System.Windows.Forms.Label();
            this.lblAProblem = new System.Windows.Forms.Label();
            this.cmbAProblem = new System.Windows.Forms.ComboBox();
            this.lblASetupSQL = new System.Windows.Forms.Label();
            this.txtASetupSQL = new System.Windows.Forms.TextBox();
            this.lblASolutionQuery = new System.Windows.Forms.Label();
            this.txtASolutionQuery = new System.Windows.Forms.TextBox();
            this.updatePanel = new System.Windows.Forms.Panel();
            this.lblUpdateTitle = new System.Windows.Forms.Label();
            this.lblUTestCaseId = new System.Windows.Forms.Label();
            this.txtUTestCaseId = new System.Windows.Forms.TextBox();
            this.lblUProblem = new System.Windows.Forms.Label();
            this.cmbUProblem = new System.Windows.Forms.ComboBox();
            this.lblUSetupSQL = new System.Windows.Forms.Label();
            this.txtUSetupSQL = new System.Windows.Forms.TextBox();
            this.lblUSolutionQuery = new System.Windows.Forms.Label();
            this.txtUSolutionQuery = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAClear = new System.Windows.Forms.Button();
            this.btnShowAdd = new System.Windows.Forms.Button();
            this.btnShowUpdate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnUClear = new System.Windows.Forms.Button();
            this.addPanel.SuspendLayout();
            this.updatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addPanel
            // 
            this.addPanel.Controls.Add(this.btnAdd);
            this.addPanel.Controls.Add(this.btnAClear);
            this.addPanel.Controls.Add(this.lblAddTitle);
            this.addPanel.Controls.Add(this.lblAProblem);
            this.addPanel.Controls.Add(this.cmbAProblem);
            this.addPanel.Controls.Add(this.lblASetupSQL);
            this.addPanel.Controls.Add(this.txtASetupSQL);
            this.addPanel.Controls.Add(this.lblASolutionQuery);
            this.addPanel.Controls.Add(this.txtASolutionQuery);
            this.addPanel.Location = new System.Drawing.Point(30, 60);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(520, 380);
            this.addPanel.TabIndex = 2;
            // 
            // lblAddTitle
            // 
            this.lblAddTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddTitle.Location = new System.Drawing.Point(190, 10);
            this.lblAddTitle.Name = "lblAddTitle";
            this.lblAddTitle.Size = new System.Drawing.Size(141, 23);
            this.lblAddTitle.TabIndex = 0;
            this.lblAddTitle.Text = "Add Test Case";
            // 
            // lblAProblem
            // 
            this.lblAProblem.Location = new System.Drawing.Point(20, 54);
            this.lblAProblem.Name = "lblAProblem";
            this.lblAProblem.Size = new System.Drawing.Size(100, 14);
            this.lblAProblem.TabIndex = 1;
            this.lblAProblem.Text = "Problem";
            // 
            // cmbAProblem
            // 
            this.cmbAProblem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAProblem.Location = new System.Drawing.Point(20, 73);
            this.cmbAProblem.Name = "cmbAProblem";
            this.cmbAProblem.Size = new System.Drawing.Size(450, 21);
            this.cmbAProblem.TabIndex = 2;
            // 
            // lblASetupSQL
            // 
            this.lblASetupSQL.Location = new System.Drawing.Point(20, 104);
            this.lblASetupSQL.Name = "lblASetupSQL";
            this.lblASetupSQL.Size = new System.Drawing.Size(100, 17);
            this.lblASetupSQL.TabIndex = 3;
            this.lblASetupSQL.Text = "Setup SQL";
            // 
            // txtASetupSQL
            // 
            this.txtASetupSQL.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtASetupSQL.Location = new System.Drawing.Point(20, 123);
            this.txtASetupSQL.Multiline = true;
            this.txtASetupSQL.Name = "txtASetupSQL";
            this.txtASetupSQL.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtASetupSQL.Size = new System.Drawing.Size(450, 80);
            this.txtASetupSQL.TabIndex = 4;
            // 
            // lblASolutionQuery
            // 
            this.lblASolutionQuery.Location = new System.Drawing.Point(20, 214);
            this.lblASolutionQuery.Name = "lblASolutionQuery";
            this.lblASolutionQuery.Size = new System.Drawing.Size(100, 17);
            this.lblASolutionQuery.TabIndex = 5;
            this.lblASolutionQuery.Text = "Solution Query";
            // 
            // txtASolutionQuery
            // 
            this.txtASolutionQuery.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtASolutionQuery.Location = new System.Drawing.Point(20, 233);
            this.txtASolutionQuery.Multiline = true;
            this.txtASolutionQuery.Name = "txtASolutionQuery";
            this.txtASolutionQuery.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtASolutionQuery.Size = new System.Drawing.Size(450, 80);
            this.txtASolutionQuery.TabIndex = 6;
            // 
            // updatePanel
            // 
            this.updatePanel.Controls.Add(this.btnUpdate);
            this.updatePanel.Controls.Add(this.btnUClear);
            this.updatePanel.Controls.Add(this.lblUpdateTitle);
            this.updatePanel.Controls.Add(this.lblUTestCaseId);
            this.updatePanel.Controls.Add(this.txtUTestCaseId);
            this.updatePanel.Controls.Add(this.lblUProblem);
            this.updatePanel.Controls.Add(this.cmbUProblem);
            this.updatePanel.Controls.Add(this.lblUSetupSQL);
            this.updatePanel.Controls.Add(this.txtUSetupSQL);
            this.updatePanel.Controls.Add(this.lblUSolutionQuery);
            this.updatePanel.Controls.Add(this.txtUSolutionQuery);
            this.updatePanel.Location = new System.Drawing.Point(30, 60);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Size = new System.Drawing.Size(520, 380);
            this.updatePanel.TabIndex = 3;
            this.updatePanel.Visible = false;
            // 
            // lblUpdateTitle
            // 
            this.lblUpdateTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblUpdateTitle.Location = new System.Drawing.Point(185, 10);
            this.lblUpdateTitle.Name = "lblUpdateTitle";
            this.lblUpdateTitle.Size = new System.Drawing.Size(151, 23);
            this.lblUpdateTitle.TabIndex = 0;
            this.lblUpdateTitle.Text = "Update Test Case";
            // 
            // lblUTestCaseId
            // 
            this.lblUTestCaseId.Location = new System.Drawing.Point(20, 40);
            this.lblUTestCaseId.Name = "lblUTestCaseId";
            this.lblUTestCaseId.Size = new System.Drawing.Size(100, 23);
            this.lblUTestCaseId.TabIndex = 1;
            this.lblUTestCaseId.Text = "Test Case ID";
            // 
            // txtUTestCaseId
            // 
            this.txtUTestCaseId.Location = new System.Drawing.Point(20, 63);
            this.txtUTestCaseId.Name = "txtUTestCaseId";
            this.txtUTestCaseId.Size = new System.Drawing.Size(450, 20);
            this.txtUTestCaseId.TabIndex = 2;
            // 
            // lblUProblem
            // 
            this.lblUProblem.Location = new System.Drawing.Point(20, 90);
            this.lblUProblem.Name = "lblUProblem";
            this.lblUProblem.Size = new System.Drawing.Size(100, 23);
            this.lblUProblem.TabIndex = 3;
            this.lblUProblem.Text = "Problem";
            // 
            // cmbUProblem
            // 
            this.cmbUProblem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUProblem.Location = new System.Drawing.Point(20, 113);
            this.cmbUProblem.Name = "cmbUProblem";
            this.cmbUProblem.Size = new System.Drawing.Size(450, 21);
            this.cmbUProblem.TabIndex = 4;
            // 
            // lblUSetupSQL
            // 
            this.lblUSetupSQL.Location = new System.Drawing.Point(20, 140);
            this.lblUSetupSQL.Name = "lblUSetupSQL";
            this.lblUSetupSQL.Size = new System.Drawing.Size(100, 23);
            this.lblUSetupSQL.TabIndex = 5;
            this.lblUSetupSQL.Text = "Setup SQL";
            // 
            // txtUSetupSQL
            // 
            this.txtUSetupSQL.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtUSetupSQL.Location = new System.Drawing.Point(20, 163);
            this.txtUSetupSQL.Multiline = true;
            this.txtUSetupSQL.Name = "txtUSetupSQL";
            this.txtUSetupSQL.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtUSetupSQL.Size = new System.Drawing.Size(450, 70);
            this.txtUSetupSQL.TabIndex = 6;
            // 
            // lblUSolutionQuery
            // 
            this.lblUSolutionQuery.Location = new System.Drawing.Point(20, 235);
            this.lblUSolutionQuery.Name = "lblUSolutionQuery";
            this.lblUSolutionQuery.Size = new System.Drawing.Size(100, 23);
            this.lblUSolutionQuery.TabIndex = 7;
            this.lblUSolutionQuery.Text = "Solution Query";
            // 
            // txtUSolutionQuery
            // 
            this.txtUSolutionQuery.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtUSolutionQuery.Location = new System.Drawing.Point(20, 258);
            this.txtUSolutionQuery.Multiline = true;
            this.txtUSolutionQuery.Name = "txtUSolutionQuery";
            this.txtUSolutionQuery.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtUSolutionQuery.Size = new System.Drawing.Size(450, 70);
            this.txtUSolutionQuery.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(20, 337);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnAClear
            // 
            this.btnAClear.BackColor = System.Drawing.Color.IndianRed;
            this.btnAClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAClear.ForeColor = System.Drawing.Color.White;
            this.btnAClear.Location = new System.Drawing.Point(120, 337);
            this.btnAClear.Name = "btnAClear";
            this.btnAClear.Size = new System.Drawing.Size(75, 23);
            this.btnAClear.TabIndex = 10;
            this.btnAClear.Text = "Clear";
            this.btnAClear.UseVisualStyleBackColor = false;
            // 
            // btnShowAdd
            // 
            this.btnShowAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnShowAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAdd.ForeColor = System.Drawing.Color.White;
            this.btnShowAdd.Location = new System.Drawing.Point(30, 21);
            this.btnShowAdd.Name = "btnShowAdd";
            this.btnShowAdd.Size = new System.Drawing.Size(98, 23);
            this.btnShowAdd.TabIndex = 4;
            this.btnShowAdd.Text = "Add Test Case";
            this.btnShowAdd.UseVisualStyleBackColor = false;
            this.btnShowAdd.Click += new System.EventHandler(this.btnShowAdd_Click);
            // 
            // btnShowUpdate
            // 
            this.btnShowUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnShowUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowUpdate.ForeColor = System.Drawing.Color.White;
            this.btnShowUpdate.Location = new System.Drawing.Point(186, 21);
            this.btnShowUpdate.Name = "btnShowUpdate";
            this.btnShowUpdate.Size = new System.Drawing.Size(98, 23);
            this.btnShowUpdate.TabIndex = 5;
            this.btnShowUpdate.Text = "Update Test Case";
            this.btnShowUpdate.UseVisualStyleBackColor = false;
            this.btnShowUpdate.Click += new System.EventHandler(this.btnShowUpdate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(20, 341);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnUClear
            // 
            this.btnUClear.BackColor = System.Drawing.Color.IndianRed;
            this.btnUClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUClear.ForeColor = System.Drawing.Color.White;
            this.btnUClear.Location = new System.Drawing.Point(120, 341);
            this.btnUClear.Name = "btnUClear";
            this.btnUClear.Size = new System.Drawing.Size(75, 23);
            this.btnUClear.TabIndex = 12;
            this.btnUClear.Text = "Clear";
            this.btnUClear.UseVisualStyleBackColor = false;
            // 
            // TestCasePopupForm
            // 
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.btnShowAdd);
            this.Controls.Add(this.btnShowUpdate);
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
        private System.Windows.Forms.Button btnShowAdd;
        private System.Windows.Forms.Button btnShowUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnUClear;
    }
}