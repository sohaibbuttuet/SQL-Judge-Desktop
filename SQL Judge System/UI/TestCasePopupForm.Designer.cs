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
        private System.Windows.Forms.Label lblASolutionQuery;

        private System.Windows.Forms.ComboBox cmbAProblem;
        private System.Windows.Forms.TextBox txtASolutionQuery;

        // ================= UPDATE PANEL =================
        private System.Windows.Forms.Label lblUpdateTitle;
        private System.Windows.Forms.Label lblUProblem;
        private System.Windows.Forms.Label lblUSolutionQuery;
        private System.Windows.Forms.ComboBox cmbUProblem;
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
            this.txtATestName = new System.Windows.Forms.TextBox();
            this.txtTestCseName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAClear = new System.Windows.Forms.Button();
            this.lblAddTitle = new System.Windows.Forms.Label();
            this.lblAProblem = new System.Windows.Forms.Label();
            this.cmbAProblem = new System.Windows.Forms.ComboBox();
            this.lblASolutionQuery = new System.Windows.Forms.Label();
            this.txtASolutionQuery = new System.Windows.Forms.TextBox();
            this.updatePanel = new System.Windows.Forms.Panel();
            this.txtUTestName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnUClear = new System.Windows.Forms.Button();
            this.lblUpdateTitle = new System.Windows.Forms.Label();
            this.lblUProblem = new System.Windows.Forms.Label();
            this.cmbUProblem = new System.Windows.Forms.ComboBox();
            this.lblUSolutionQuery = new System.Windows.Forms.Label();
            this.txtUSolutionQuery = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSetupSQL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsetupSQL = new System.Windows.Forms.TextBox();
            this.addPanel.SuspendLayout();
            this.updatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addPanel
            // 
            this.addPanel.Controls.Add(this.label2);
            this.addPanel.Controls.Add(this.txtSetupSQL);
            this.addPanel.Controls.Add(this.txtATestName);
            this.addPanel.Controls.Add(this.txtTestCseName);
            this.addPanel.Controls.Add(this.btnAdd);
            this.addPanel.Controls.Add(this.btnAClear);
            this.addPanel.Controls.Add(this.lblAddTitle);
            this.addPanel.Controls.Add(this.lblAProblem);
            this.addPanel.Controls.Add(this.cmbAProblem);
            this.addPanel.Controls.Add(this.lblASolutionQuery);
            this.addPanel.Controls.Add(this.txtASolutionQuery);
            this.addPanel.Location = new System.Drawing.Point(27, 23);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(473, 441);
            this.addPanel.TabIndex = 2;
            // 
            // txtATestName
            // 
            this.txtATestName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.txtATestName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtATestName.ForeColor = System.Drawing.Color.White;
            this.txtATestName.Location = new System.Drawing.Point(20, 75);
            this.txtATestName.Name = "txtATestName";
            this.txtATestName.Size = new System.Drawing.Size(415, 20);
            this.txtATestName.TabIndex = 12;
            // 
            // txtTestCseName
            // 
            this.txtTestCseName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.txtTestCseName.Location = new System.Drawing.Point(22, 57);
            this.txtTestCseName.Name = "txtTestCseName";
            this.txtTestCseName.Size = new System.Drawing.Size(100, 14);
            this.txtTestCseName.TabIndex = 11;
            this.txtTestCseName.Text = "Test Case Name";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(20, 387);
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
            this.btnAClear.FlatAppearance.BorderSize = 0;
            this.btnAClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btnAClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btnAClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAClear.ForeColor = System.Drawing.Color.White;
            this.btnAClear.Location = new System.Drawing.Point(120, 387);
            this.btnAClear.Name = "btnAClear";
            this.btnAClear.Size = new System.Drawing.Size(75, 23);
            this.btnAClear.TabIndex = 10;
            this.btnAClear.Text = "Clear";
            this.btnAClear.UseVisualStyleBackColor = false;
            this.btnAClear.Click += new System.EventHandler(this.btnAClear_Click);
            // 
            // lblAddTitle
            // 
            this.lblAddTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblAddTitle.Location = new System.Drawing.Point(166, 15);
            this.lblAddTitle.Name = "lblAddTitle";
            this.lblAddTitle.Size = new System.Drawing.Size(141, 23);
            this.lblAddTitle.TabIndex = 0;
            this.lblAddTitle.Text = "Add Test Case";
            this.lblAddTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAProblem
            // 
            this.lblAProblem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblAProblem.Location = new System.Drawing.Point(20, 103);
            this.lblAProblem.Name = "lblAProblem";
            this.lblAProblem.Size = new System.Drawing.Size(100, 14);
            this.lblAProblem.TabIndex = 1;
            this.lblAProblem.Text = "Problem";
            // 
            // cmbAProblem
            // 
            this.cmbAProblem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.cmbAProblem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbAProblem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAProblem.Location = new System.Drawing.Point(20, 122);
            this.cmbAProblem.Name = "cmbAProblem";
            this.cmbAProblem.Size = new System.Drawing.Size(415, 21);
            this.cmbAProblem.TabIndex = 2;
            // 
            // lblASolutionQuery
            // 
            this.lblASolutionQuery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblASolutionQuery.Location = new System.Drawing.Point(20, 263);
            this.lblASolutionQuery.Name = "lblASolutionQuery";
            this.lblASolutionQuery.Size = new System.Drawing.Size(100, 17);
            this.lblASolutionQuery.TabIndex = 5;
            this.lblASolutionQuery.Text = "Solution Query";
            // 
            // txtASolutionQuery
            // 
            this.txtASolutionQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.txtASolutionQuery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtASolutionQuery.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtASolutionQuery.ForeColor = System.Drawing.Color.White;
            this.txtASolutionQuery.Location = new System.Drawing.Point(20, 282);
            this.txtASolutionQuery.Multiline = true;
            this.txtASolutionQuery.Name = "txtASolutionQuery";
            this.txtASolutionQuery.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtASolutionQuery.Size = new System.Drawing.Size(415, 80);
            this.txtASolutionQuery.TabIndex = 6;
            // 
            // updatePanel
            // 
            this.updatePanel.Controls.Add(this.label3);
            this.updatePanel.Controls.Add(this.txtUsetupSQL);
            this.updatePanel.Controls.Add(this.txtUTestName);
            this.updatePanel.Controls.Add(this.label1);
            this.updatePanel.Controls.Add(this.btnUpdate);
            this.updatePanel.Controls.Add(this.btnUClear);
            this.updatePanel.Controls.Add(this.lblUpdateTitle);
            this.updatePanel.Controls.Add(this.lblUProblem);
            this.updatePanel.Controls.Add(this.cmbUProblem);
            this.updatePanel.Controls.Add(this.lblUSolutionQuery);
            this.updatePanel.Controls.Add(this.txtUSolutionQuery);
            this.updatePanel.Location = new System.Drawing.Point(27, 23);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Size = new System.Drawing.Size(473, 441);
            this.updatePanel.TabIndex = 3;
            this.updatePanel.Visible = false;
            // 
            // txtUTestName
            // 
            this.txtUTestName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.txtUTestName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUTestName.Location = new System.Drawing.Point(20, 83);
            this.txtUTestName.Name = "txtUTestName";
            this.txtUTestName.Size = new System.Drawing.Size(415, 20);
            this.txtUTestName.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.label1.Location = new System.Drawing.Point(19, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 14);
            this.label1.TabIndex = 13;
            this.label1.Text = "Test Case New Name";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(20, 387);
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
            this.btnUClear.Location = new System.Drawing.Point(120, 387);
            this.btnUClear.Name = "btnUClear";
            this.btnUClear.Size = new System.Drawing.Size(75, 23);
            this.btnUClear.TabIndex = 12;
            this.btnUClear.Text = "Clear";
            this.btnUClear.UseVisualStyleBackColor = false;
            this.btnUClear.Click += new System.EventHandler(this.btnUClear_Click);
            // 
            // lblUpdateTitle
            // 
            this.lblUpdateTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblUpdateTitle.Location = new System.Drawing.Point(166, 19);
            this.lblUpdateTitle.Name = "lblUpdateTitle";
            this.lblUpdateTitle.Size = new System.Drawing.Size(140, 23);
            this.lblUpdateTitle.TabIndex = 0;
            this.lblUpdateTitle.Text = "Update Test Case";
            this.lblUpdateTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUProblem
            // 
            this.lblUProblem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblUProblem.Location = new System.Drawing.Point(20, 112);
            this.lblUProblem.Name = "lblUProblem";
            this.lblUProblem.Size = new System.Drawing.Size(100, 11);
            this.lblUProblem.TabIndex = 3;
            this.lblUProblem.Text = "Problem";
            // 
            // cmbUProblem
            // 
            this.cmbUProblem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.cmbUProblem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUProblem.Location = new System.Drawing.Point(20, 130);
            this.cmbUProblem.Name = "cmbUProblem";
            this.cmbUProblem.Size = new System.Drawing.Size(413, 21);
            this.cmbUProblem.TabIndex = 4;
            // 
            // lblUSolutionQuery
            // 
            this.lblUSolutionQuery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblUSolutionQuery.Location = new System.Drawing.Point(20, 268);
            this.lblUSolutionQuery.Name = "lblUSolutionQuery";
            this.lblUSolutionQuery.Size = new System.Drawing.Size(100, 14);
            this.lblUSolutionQuery.TabIndex = 7;
            this.lblUSolutionQuery.Text = "Solution Query";
            // 
            // txtUSolutionQuery
            // 
            this.txtUSolutionQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.txtUSolutionQuery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUSolutionQuery.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtUSolutionQuery.Location = new System.Drawing.Point(20, 285);
            this.txtUSolutionQuery.Multiline = true;
            this.txtUSolutionQuery.Name = "txtUSolutionQuery";
            this.txtUSolutionQuery.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtUSolutionQuery.Size = new System.Drawing.Size(413, 70);
            this.txtUSolutionQuery.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.label2.Location = new System.Drawing.Point(20, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Setup SQL";
            // 
            // txtSetupSQL
            // 
            this.txtSetupSQL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.txtSetupSQL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSetupSQL.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtSetupSQL.ForeColor = System.Drawing.Color.White;
            this.txtSetupSQL.Location = new System.Drawing.Point(20, 172);
            this.txtSetupSQL.Multiline = true;
            this.txtSetupSQL.Name = "txtSetupSQL";
            this.txtSetupSQL.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSetupSQL.Size = new System.Drawing.Size(415, 80);
            this.txtSetupSQL.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.label3.Location = new System.Drawing.Point(17, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 14);
            this.label3.TabIndex = 15;
            this.label3.Text = "Setup SQL";
            // 
            // txtUsetupSQL
            // 
            this.txtUsetupSQL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.txtUsetupSQL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsetupSQL.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtUsetupSQL.Location = new System.Drawing.Point(20, 182);
            this.txtUsetupSQL.Multiline = true;
            this.txtUsetupSQL.Name = "txtUsetupSQL";
            this.txtUsetupSQL.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtUsetupSQL.Size = new System.Drawing.Size(413, 70);
            this.txtUsetupSQL.TabIndex = 16;
            // 
            // TestCasePopupForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(527, 486);
            this.Controls.Add(this.updatePanel);
            this.Controls.Add(this.addPanel);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSetupSQL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsetupSQL;
    }
}