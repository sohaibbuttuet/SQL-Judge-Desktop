using System.Windows.Forms;

namespace SQL_Judge_System.UI
{
    partial class AuthForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnMainAction = new System.Windows.Forms.Button();
            this.lnkToggle = new System.Windows.Forms.LinkLabel();
            this.pnlStudentExtra = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblRegNo = new System.Windows.Forms.Label();
            this.txtRegNo = new System.Windows.Forms.TextBox();
            this.lblSkill = new System.Windows.Forms.Label();
            this.cmbSkillLevel = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.pnlStudentExtra.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblTitle.Location = new System.Drawing.Point(50, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Sign In";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(50, 80);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 23);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email Address";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(50, 105);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(50, 150);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(100, 23);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(50, 175);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(300, 20);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnMainAction
            // 
            this.btnMainAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnMainAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainAction.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnMainAction.ForeColor = System.Drawing.Color.White;
            this.btnMainAction.Location = new System.Drawing.Point(0, 0);
            this.btnMainAction.Name = "btnMainAction";
            this.btnMainAction.Size = new System.Drawing.Size(300, 45);
            this.btnMainAction.TabIndex = 6;
            this.btnMainAction.Text = "LOGIN";
            this.btnMainAction.UseVisualStyleBackColor = false;
            this.btnMainAction.Click += new System.EventHandler(this.btnMainAction_Click);
            // 
            // lnkToggle
            // 
            this.lnkToggle.Location = new System.Drawing.Point(0, 0);
            this.lnkToggle.Name = "lnkToggle";
            this.lnkToggle.Size = new System.Drawing.Size(300, 20);
            this.lnkToggle.TabIndex = 7;
            this.lnkToggle.TabStop = true;
            this.lnkToggle.Text = "Don\'t have an account? Sign Up";
            this.lnkToggle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkToggle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkToggle_LinkClicked);
            // 
            // pnlStudentExtra
            // 
            this.pnlStudentExtra.Controls.Add(this.lblName);
            this.pnlStudentExtra.Controls.Add(this.txtName);
            this.pnlStudentExtra.Controls.Add(this.lblRegNo);
            this.pnlStudentExtra.Controls.Add(this.txtRegNo);
            this.pnlStudentExtra.Controls.Add(this.lblSkill);
            this.pnlStudentExtra.Controls.Add(this.cmbSkillLevel);
            this.pnlStudentExtra.Location = new System.Drawing.Point(50, 220);
            this.pnlStudentExtra.Name = "pnlStudentExtra";
            this.pnlStudentExtra.Size = new System.Drawing.Size(320, 250);
            this.pnlStudentExtra.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 23);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Full Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(0, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(300, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblRegNo
            // 
            this.lblRegNo.Location = new System.Drawing.Point(0, 65);
            this.lblRegNo.Name = "lblRegNo";
            this.lblRegNo.Size = new System.Drawing.Size(110, 23);
            this.lblRegNo.TabIndex = 2;
            this.lblRegNo.Text = "Registration Number";
            // 
            // txtRegNo
            // 
            this.txtRegNo.Location = new System.Drawing.Point(0, 90);
            this.txtRegNo.Name = "txtRegNo";
            this.txtRegNo.Size = new System.Drawing.Size(300, 20);
            this.txtRegNo.TabIndex = 3;
            // 
            // lblSkill
            // 
            this.lblSkill.Location = new System.Drawing.Point(0, 130);
            this.lblSkill.Name = "lblSkill";
            this.lblSkill.Size = new System.Drawing.Size(100, 23);
            this.lblSkill.TabIndex = 4;
            this.lblSkill.Text = "Skill Level";
            // 
            // cmbSkillLevel
            // 
            this.cmbSkillLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSkillLevel.Items.AddRange(new object[] {
            "Beginner",
            "Intermediate",
            "Expert"});
            this.cmbSkillLevel.Location = new System.Drawing.Point(0, 155);
            this.cmbSkillLevel.Name = "cmbSkillLevel";
            this.cmbSkillLevel.Size = new System.Drawing.Size(300, 21);
            this.cmbSkillLevel.TabIndex = 5;
            // 
            // lblRole
            // 
            this.lblRole.Location = new System.Drawing.Point(0, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(100, 23);
            this.lblRole.TabIndex = 0;
            // 
            // cmbRole
            // 
            this.cmbRole.Location = new System.Drawing.Point(0, 0);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(121, 21);
            this.cmbRole.TabIndex = 0;
            // 
            // AuthForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.pnlStudentExtra);
            this.Controls.Add(this.btnMainAction);
            this.Controls.Add(this.lnkToggle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentication";
            this.pnlStudentExtra.ResumeLayout(false);
            this.pnlStudentExtra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitle, lblEmail, lblPassword, lblName, lblRegNo, lblSkill, lblRole;
        private System.Windows.Forms.TextBox txtEmail, txtPassword, txtName, txtRegNo;
        private System.Windows.Forms.ComboBox cmbSkillLevel, cmbRole;
        private System.Windows.Forms.Button btnMainAction;
        private System.Windows.Forms.LinkLabel lnkToggle;
        private System.Windows.Forms.Panel pnlStudentExtra;
    }
}