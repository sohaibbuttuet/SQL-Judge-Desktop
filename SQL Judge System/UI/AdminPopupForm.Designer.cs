namespace SQL_Judge_System.UI
{
    partial class AdminPopupForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.Panel editPanel;

        private System.Windows.Forms.Button btnSwitchAdd;
        private System.Windows.Forms.Button btnSwitchEdit;

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
        private System.Windows.Forms.TextBox txtEditEmail;
        private System.Windows.Forms.TextBox txtEditName;
        private System.Windows.Forms.TextBox txtEditPassword;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnEditClear;

        private System.Windows.Forms.Label lblEditEmail;
        private System.Windows.Forms.Label lblEditName;
        private System.Windows.Forms.Label lblEditPassword;

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
            this.lblEditEmail = new System.Windows.Forms.Label();
            this.txtEditEmail = new System.Windows.Forms.TextBox();
            this.lblEditName = new System.Windows.Forms.Label();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.lblEditPassword = new System.Windows.Forms.Label();
            this.txtEditPassword = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnEditClear = new System.Windows.Forms.Button();
            this.btnSwitchAdd = new System.Windows.Forms.Button();
            this.btnSwitchEdit = new System.Windows.Forms.Button();
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
            this.addPanel.Location = new System.Drawing.Point(30, 60);
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
            this.btnAdd.Location = new System.Drawing.Point(20, 210);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnAddClear
            // 
            this.btnAddClear.BackColor = System.Drawing.Color.IndianRed;
            this.btnAddClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClear.ForeColor = System.Drawing.Color.White;
            this.btnAddClear.Location = new System.Drawing.Point(120, 210);
            this.btnAddClear.Name = "btnAddClear";
            this.btnAddClear.Size = new System.Drawing.Size(75, 23);
            this.btnAddClear.TabIndex = 8;
            this.btnAddClear.Text = "Clear";
            this.btnAddClear.UseVisualStyleBackColor = false;
            // 
            // editPanel
            // 
            this.editPanel.Controls.Add(this.lblEditTitle);
            this.editPanel.Controls.Add(this.lblEditEmail);
            this.editPanel.Controls.Add(this.txtEditEmail);
            this.editPanel.Controls.Add(this.lblEditName);
            this.editPanel.Controls.Add(this.txtEditName);
            this.editPanel.Controls.Add(this.lblEditPassword);
            this.editPanel.Controls.Add(this.txtEditPassword);
            this.editPanel.Controls.Add(this.btnUpdate);
            this.editPanel.Controls.Add(this.btnEditClear);
            this.editPanel.Location = new System.Drawing.Point(30, 60);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(370, 280);
            this.editPanel.TabIndex = 3;
            this.editPanel.Visible = false;
            // 
            // lblEditTitle
            // 
            this.lblEditTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblEditTitle.Location = new System.Drawing.Point(120, 10);
            this.lblEditTitle.Name = "lblEditTitle";
            this.lblEditTitle.Size = new System.Drawing.Size(100, 23);
            this.lblEditTitle.TabIndex = 0;
            this.lblEditTitle.Text = "Edit Admin";
            // 
            // lblEditEmail
            // 
            this.lblEditEmail.Location = new System.Drawing.Point(20, 50);
            this.lblEditEmail.Name = "lblEditEmail";
            this.lblEditEmail.Size = new System.Drawing.Size(100, 23);
            this.lblEditEmail.TabIndex = 1;
            this.lblEditEmail.Text = "Email (Search)";
            // 
            // txtEditEmail
            // 
            this.txtEditEmail.Location = new System.Drawing.Point(20, 73);
            this.txtEditEmail.Name = "txtEditEmail";
            this.txtEditEmail.Size = new System.Drawing.Size(300, 20);
            this.txtEditEmail.TabIndex = 2;
            // 
            // lblEditName
            // 
            this.lblEditName.Location = new System.Drawing.Point(20, 100);
            this.lblEditName.Name = "lblEditName";
            this.lblEditName.Size = new System.Drawing.Size(100, 23);
            this.lblEditName.TabIndex = 3;
            this.lblEditName.Text = "Full Name";
            // 
            // txtEditName
            // 
            this.txtEditName.Location = new System.Drawing.Point(20, 123);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(300, 20);
            this.txtEditName.TabIndex = 4;
            // 
            // lblEditPassword
            // 
            this.lblEditPassword.Location = new System.Drawing.Point(20, 150);
            this.lblEditPassword.Name = "lblEditPassword";
            this.lblEditPassword.Size = new System.Drawing.Size(100, 23);
            this.lblEditPassword.TabIndex = 5;
            this.lblEditPassword.Text = "New Password";
            // 
            // txtEditPassword
            // 
            this.txtEditPassword.Location = new System.Drawing.Point(20, 173);
            this.txtEditPassword.Name = "txtEditPassword";
            this.txtEditPassword.PasswordChar = '*';
            this.txtEditPassword.Size = new System.Drawing.Size(300, 20);
            this.txtEditPassword.TabIndex = 6;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(20, 210);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnEditClear
            // 
            this.btnEditClear.BackColor = System.Drawing.Color.IndianRed;
            this.btnEditClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditClear.ForeColor = System.Drawing.Color.White;
            this.btnEditClear.Location = new System.Drawing.Point(120, 210);
            this.btnEditClear.Name = "btnEditClear";
            this.btnEditClear.Size = new System.Drawing.Size(75, 23);
            this.btnEditClear.TabIndex = 8;
            this.btnEditClear.Text = "Clear";
            this.btnEditClear.UseVisualStyleBackColor = false;
            // 
            // btnSwitchAdd
            // 
            this.btnSwitchAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnSwitchAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSwitchAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitchAdd.ForeColor = System.Drawing.Color.White;
            this.btnSwitchAdd.Location = new System.Drawing.Point(30, 20);
            this.btnSwitchAdd.Name = "btnSwitchAdd";
            this.btnSwitchAdd.Size = new System.Drawing.Size(75, 23);
            this.btnSwitchAdd.TabIndex = 0;
            this.btnSwitchAdd.Text = "Add Admin";
            this.btnSwitchAdd.UseVisualStyleBackColor = false;
            this.btnSwitchAdd.Click += new System.EventHandler(this.btnSwitchAdd_Click);
            // 
            // btnSwitchEdit
            // 
            this.btnSwitchEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnSwitchEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSwitchEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitchEdit.ForeColor = System.Drawing.Color.White;
            this.btnSwitchEdit.Location = new System.Drawing.Point(141, 20);
            this.btnSwitchEdit.Name = "btnSwitchEdit";
            this.btnSwitchEdit.Size = new System.Drawing.Size(75, 23);
            this.btnSwitchEdit.TabIndex = 1;
            this.btnSwitchEdit.Text = "Edit Admin";
            this.btnSwitchEdit.UseVisualStyleBackColor = false;
            this.btnSwitchEdit.Click += new System.EventHandler(this.btnSwitchEdit_Click);
            // 
            // AdminPopupForm
            // 
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.btnSwitchAdd);
            this.Controls.Add(this.btnSwitchEdit);
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
    }
}