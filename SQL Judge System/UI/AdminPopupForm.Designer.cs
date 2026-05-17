namespace SQL_Judge_System.UI
{
    partial class AdminPopupForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.Panel editPanel;

        // ================= ADD CONTROLS =================
        private System.Windows.Forms.Label lblAddTitle;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.TextBox txtAddEmail;
        private System.Windows.Forms.TextBox txtAddPassword;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddClear;

        private System.Windows.Forms.Label lblAddName;
        private System.Windows.Forms.Label lblAddEmail;
        private System.Windows.Forms.Label lblAddPassword;

        // ================= EDIT CONTROLS =================
        private System.Windows.Forms.Label lblEditTitle;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnEditClear;

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
            this.lblAddName = new System.Windows.Forms.Label();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.lblAddEmail = new System.Windows.Forms.Label();
            this.txtAddEmail = new System.Windows.Forms.TextBox();
            this.lblAddPassword = new System.Windows.Forms.Label();
            this.txtAddPassword = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddClear = new System.Windows.Forms.Button();
            this.editPanel = new System.Windows.Forms.Panel();
            this.lblEditTitle = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnEditClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEditEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEditPassword = new System.Windows.Forms.TextBox();
            this.addPanel.SuspendLayout();
            this.editPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addPanel
            // 
            this.addPanel.Controls.Add(this.lblAddTitle);
            this.addPanel.Controls.Add(this.lblAddName);
            this.addPanel.Controls.Add(this.txtAddName);
            this.addPanel.Controls.Add(this.lblAddEmail);
            this.addPanel.Controls.Add(this.txtAddEmail);
            this.addPanel.Controls.Add(this.lblAddPassword);
            this.addPanel.Controls.Add(this.txtAddPassword);
            this.addPanel.Controls.Add(this.btnAdd);
            this.addPanel.Controls.Add(this.btnAddClear);
            this.addPanel.Location = new System.Drawing.Point(32, 40);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(370, 280);
            this.addPanel.TabIndex = 2;
            // 
            // lblAddTitle
            // 
            this.lblAddTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAddTitle.Location = new System.Drawing.Point(120, 10);
            this.lblAddTitle.Name = "lblAddTitle";
            this.lblAddTitle.Size = new System.Drawing.Size(100, 23);
            this.lblAddTitle.TabIndex = 0;
            this.lblAddTitle.Text = "Add Admin";
            // 
            // lblAddName
            // 
            this.lblAddName.Location = new System.Drawing.Point(20, 50);
            this.lblAddName.Name = "lblAddName";
            this.lblAddName.Size = new System.Drawing.Size(100, 23);
            this.lblAddName.TabIndex = 1;
            this.lblAddName.Text = "Full Name";
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(20, 73);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(300, 20);
            this.txtAddName.TabIndex = 2;
            // 
            // lblAddEmail
            // 
            this.lblAddEmail.Location = new System.Drawing.Point(20, 100);
            this.lblAddEmail.Name = "lblAddEmail";
            this.lblAddEmail.Size = new System.Drawing.Size(100, 23);
            this.lblAddEmail.TabIndex = 3;
            this.lblAddEmail.Text = "Email";
            // 
            // txtAddEmail
            // 
            this.txtAddEmail.Location = new System.Drawing.Point(20, 123);
            this.txtAddEmail.Name = "txtAddEmail";
            this.txtAddEmail.Size = new System.Drawing.Size(300, 20);
            this.txtAddEmail.TabIndex = 4;
            // 
            // lblAddPassword
            // 
            this.lblAddPassword.Location = new System.Drawing.Point(20, 150);
            this.lblAddPassword.Name = "lblAddPassword";
            this.lblAddPassword.Size = new System.Drawing.Size(100, 23);
            this.lblAddPassword.TabIndex = 5;
            this.lblAddPassword.Text = "Password";
            // 
            // txtAddPassword
            // 
            this.txtAddPassword.Location = new System.Drawing.Point(20, 173);
            this.txtAddPassword.Name = "txtAddPassword";
            this.txtAddPassword.PasswordChar = '*';
            this.txtAddPassword.Size = new System.Drawing.Size(300, 20);
            this.txtAddPassword.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(20, 219);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddClear
            // 
            this.btnAddClear.BackColor = System.Drawing.Color.IndianRed;
            this.btnAddClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClear.ForeColor = System.Drawing.Color.White;
            this.btnAddClear.Location = new System.Drawing.Point(120, 219);
            this.btnAddClear.Name = "btnAddClear";
            this.btnAddClear.Size = new System.Drawing.Size(75, 23);
            this.btnAddClear.TabIndex = 8;
            this.btnAddClear.Text = "Clear";
            this.btnAddClear.UseVisualStyleBackColor = false;
            this.btnAddClear.Click += new System.EventHandler(this.btnAddClear_Click);
            // 
            // editPanel
            // 
            this.editPanel.Controls.Add(this.label1);
            this.editPanel.Controls.Add(this.txtEditName);
            this.editPanel.Controls.Add(this.label2);
            this.editPanel.Controls.Add(this.txtEditEmail);
            this.editPanel.Controls.Add(this.label3);
            this.editPanel.Controls.Add(this.txtEditPassword);
            this.editPanel.Controls.Add(this.lblEditTitle);
            this.editPanel.Controls.Add(this.btnUpdate);
            this.editPanel.Controls.Add(this.btnEditClear);
            this.editPanel.Location = new System.Drawing.Point(32, 40);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(370, 280);
            this.editPanel.TabIndex = 3;
            this.editPanel.Visible = false;
            // 
            // lblEditTitle
            // 
            this.lblEditTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblEditTitle.Location = new System.Drawing.Point(135, 13);
            this.lblEditTitle.Name = "lblEditTitle";
            this.lblEditTitle.Size = new System.Drawing.Size(100, 23);
            this.lblEditTitle.TabIndex = 0;
            this.lblEditTitle.Text = "Edit Admin";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(24, 228);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnEditClear
            // 
            this.btnEditClear.BackColor = System.Drawing.Color.IndianRed;
            this.btnEditClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditClear.ForeColor = System.Drawing.Color.White;
            this.btnEditClear.Location = new System.Drawing.Point(124, 228);
            this.btnEditClear.Name = "btnEditClear";
            this.btnEditClear.Size = new System.Drawing.Size(75, 23);
            this.btnEditClear.TabIndex = 8;
            this.btnEditClear.Text = "Clear";
            this.btnEditClear.UseVisualStyleBackColor = false;
            this.btnEditClear.Click += new System.EventHandler(this.btnEditClear_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(21, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 14);
            this.label1.TabIndex = 9;
            this.label1.Text = "New Full Name";
            // 
            // txtEditName
            // 
            this.txtEditName.Location = new System.Drawing.Point(21, 82);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(300, 20);
            this.txtEditName.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(21, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 14);
            this.label2.TabIndex = 11;
            this.label2.Text = "New Email";
            // 
            // txtEditEmail
            // 
            this.txtEditEmail.Location = new System.Drawing.Point(21, 132);
            this.txtEditEmail.Name = "txtEditEmail";
            this.txtEditEmail.Size = new System.Drawing.Size(300, 20);
            this.txtEditEmail.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(21, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "New Password";
            // 
            // txtEditPassword
            // 
            this.txtEditPassword.Location = new System.Drawing.Point(21, 182);
            this.txtEditPassword.Name = "txtEditPassword";
            this.txtEditPassword.PasswordChar = '*';
            this.txtEditPassword.Size = new System.Drawing.Size(300, 20);
            this.txtEditPassword.TabIndex = 14;
            // 
            // AdminPopupForm
            // 
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.editPanel);
            this.Controls.Add(this.addPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AdminPopupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Manage";
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            this.editPanel.ResumeLayout(false);
            this.editPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEditName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEditEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEditPassword;
    }
}