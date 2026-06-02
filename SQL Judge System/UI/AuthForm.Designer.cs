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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pnlStudentExtra = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblRegNo = new System.Windows.Forms.Label();
            this.txtRegNo = new System.Windows.Forms.TextBox();
            this.lblSkill = new System.Windows.Forms.Label();
            this.cmbSkillLevel = new System.Windows.Forms.ComboBox();
            this.btnMainAction = new System.Windows.Forms.Button();
            this.lnkToggle = new System.Windows.Forms.LinkLabel();
            this.pnlContainer.SuspendLayout();
            this.pnlStudentExtra.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(58)))));
            this.pnlContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContainer.Controls.Add(this.lblTitle);
            this.pnlContainer.Controls.Add(this.lblSubtitle);
            this.pnlContainer.Controls.Add(this.lblEmail);
            this.pnlContainer.Controls.Add(this.txtEmail);
            this.pnlContainer.Controls.Add(this.lblPassword);
            this.pnlContainer.Controls.Add(this.txtPassword);
            this.pnlContainer.Controls.Add(this.pnlStudentExtra);
            this.pnlContainer.Controls.Add(this.btnMainAction);
            this.pnlContainer.Controls.Add(this.lnkToggle);
            this.pnlContainer.Location = new System.Drawing.Point(45, 35);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(430, 650);
            this.pnlContainer.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(40, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(340, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcome Back";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.lblSubtitle.Location = new System.Drawing.Point(40, 75);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(340, 25);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Sign in to continue";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblEmail.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblEmail.Location = new System.Drawing.Point(45, 130);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(120, 25);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email Address";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(45, 160);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(340, 27);
            this.txtEmail.TabIndex = 0;
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPassword.Location = new System.Drawing.Point(45, 215);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(120, 25);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(45, 245);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(340, 27);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // pnlStudentExtra
            // 
            this.pnlStudentExtra.BackColor = System.Drawing.Color.Transparent;
            this.pnlStudentExtra.Controls.Add(this.lblName);
            this.pnlStudentExtra.Controls.Add(this.txtName);
            this.pnlStudentExtra.Controls.Add(this.lblRegNo);
            this.pnlStudentExtra.Controls.Add(this.txtRegNo);
            this.pnlStudentExtra.Controls.Add(this.lblSkill);
            this.pnlStudentExtra.Controls.Add(this.cmbSkillLevel);
            this.pnlStudentExtra.Location = new System.Drawing.Point(45, 305);
            this.pnlStudentExtra.Name = "pnlStudentExtra";
            this.pnlStudentExtra.Size = new System.Drawing.Size(340, 220);
            this.pnlStudentExtra.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(120, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Full Name";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(0, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(340, 27);
            this.txtName.TabIndex = 1;
            // 
            // lblRegNo
            // 
            this.lblRegNo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblRegNo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblRegNo.Location = new System.Drawing.Point(0, 80);
            this.lblRegNo.Name = "lblRegNo";
            this.lblRegNo.Size = new System.Drawing.Size(180, 25);
            this.lblRegNo.TabIndex = 2;
            this.lblRegNo.Text = "Registration Number";
            // 
            // txtRegNo
            // 
            this.txtRegNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.txtRegNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegNo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtRegNo.ForeColor = System.Drawing.Color.White;
            this.txtRegNo.Location = new System.Drawing.Point(0, 110);
            this.txtRegNo.Name = "txtRegNo";
            this.txtRegNo.Size = new System.Drawing.Size(340, 27);
            this.txtRegNo.TabIndex = 3;
            // 
            // lblSkill
            // 
            this.lblSkill.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblSkill.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSkill.Location = new System.Drawing.Point(0, 160);
            this.lblSkill.Name = "lblSkill";
            this.lblSkill.Size = new System.Drawing.Size(120, 25);
            this.lblSkill.TabIndex = 4;
            this.lblSkill.Text = "Skill Level";
            // 
            // cmbSkillLevel
            // 
            this.cmbSkillLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.cmbSkillLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSkillLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSkillLevel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSkillLevel.ForeColor = System.Drawing.Color.White;
            this.cmbSkillLevel.Items.AddRange(new object[] {
            "Beginner",
            "Intermediate",
            "Advanced"});
            this.cmbSkillLevel.Location = new System.Drawing.Point(0, 190);
            this.cmbSkillLevel.Name = "cmbSkillLevel";
            this.cmbSkillLevel.Size = new System.Drawing.Size(340, 25);
            this.cmbSkillLevel.TabIndex = 5;
            // 
            // btnMainAction
            // 
            this.btnMainAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(242)))));
            this.btnMainAction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainAction.FlatAppearance.BorderSize = 0;
            this.btnMainAction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(82)))), ((int)(((byte)(220)))));
            this.btnMainAction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(116)))), ((int)(((byte)(255)))));
            this.btnMainAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainAction.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnMainAction.ForeColor = System.Drawing.Color.White;
            this.btnMainAction.Location = new System.Drawing.Point(45, 545);
            this.btnMainAction.Name = "btnMainAction";
            this.btnMainAction.Size = new System.Drawing.Size(340, 50);
            this.btnMainAction.TabIndex = 5;
            this.btnMainAction.Text = "LOGIN";
            this.btnMainAction.UseVisualStyleBackColor = false;
            this.btnMainAction.Click += new System.EventHandler(this.btnMainAction_Click);
            // 
            // lnkToggle
            // 
            this.lnkToggle.ActiveLinkColor = System.Drawing.Color.White;
            this.lnkToggle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lnkToggle.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.lnkToggle.Location = new System.Drawing.Point(45, 613);
            this.lnkToggle.Name = "lnkToggle";
            this.lnkToggle.Size = new System.Drawing.Size(340, 25);
            this.lnkToggle.TabIndex = 6;
            this.lnkToggle.TabStop = true;
            this.lnkToggle.Text = "Don\'t have an account? Sign Up";
            this.lnkToggle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkToggle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkToggle_LinkClicked);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(520, 720);
            this.Controls.Add(this.pnlContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL Judge System";
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.pnlStudentExtra.ResumeLayout(false);
            this.pnlStudentExtra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;

        private System.Windows.Forms.Panel pnlStudentExtra;

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;

        private System.Windows.Forms.Label lblRegNo;
        private System.Windows.Forms.TextBox txtRegNo;

        private System.Windows.Forms.Label lblSkill;
        private System.Windows.Forms.ComboBox cmbSkillLevel;

        private System.Windows.Forms.Button btnMainAction;
        private System.Windows.Forms.LinkLabel lnkToggle;
    }
}