
namespace SQL_Judge_System.UI
{
    partial class SettingsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.pnlProfileCard = new System.Windows.Forms.Panel();
            this.pnlextrastd = new System.Windows.Forms.Panel();
            this.cmbskill = new System.Windows.Forms.ComboBox();
            this.lblskill = new System.Windows.Forms.Label();
            this.lblregno = new System.Windows.Forms.Label();
            this.txtregno = new System.Windows.Forms.TextBox();
            this.pnlProfileAccent = new System.Windows.Forms.Panel();
            this.lblProfileCardTitle = new System.Windows.Forms.Label();
            this.pnlProfileDivider = new System.Windows.Forms.Panel();
            this.lblSettingsFullName = new System.Windows.Forms.Label();
            this.txtSettingsFullName = new System.Windows.Forms.TextBox();
            this.lblSettingsEmail = new System.Windows.Forms.Label();
            this.txtSettingsEmail = new System.Windows.Forms.TextBox();
            this.lblSettingsRole = new System.Windows.Forms.Label();
            this.txtSettingsRole = new System.Windows.Forms.TextBox();
            this.lblSettingsStatus = new System.Windows.Forms.Label();
            this.txtSettingsStatus = new System.Windows.Forms.TextBox();
            this.lblSettingsCreatedAt = new System.Windows.Forms.Label();
            this.txtSettingsCreatedAt = new System.Windows.Forms.TextBox();
            this.btnSaveProfile = new System.Windows.Forms.Button();
            this.pnlPasswordCard = new System.Windows.Forms.Panel();
            this.pnlPasswordAccent = new System.Windows.Forms.Panel();
            this.lblPasswordCardTitle = new System.Windows.Forms.Label();
            this.pnlPasswordDivider = new System.Windows.Forms.Panel();
            this.lblSecurityTip = new System.Windows.Forms.Label();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblPasswordMatchHint = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlProfileCard.SuspendLayout();
            this.pnlextrastd.SuspendLayout();
            this.pnlPasswordCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(6, 620);
            this.pnlSidebar.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.pnlHeader.Controls.Add(this.lblPageTitle);
            this.pnlHeader.Location = new System.Drawing.Point(6, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(878, 60);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lblPageTitle.Location = new System.Drawing.Point(20, 12);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(300, 35);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "⚙  Settings";
            // 
            // pnlProfileCard
            // 
            this.pnlProfileCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.pnlProfileCard.Controls.Add(this.pnlextrastd);
            this.pnlProfileCard.Controls.Add(this.pnlProfileAccent);
            this.pnlProfileCard.Controls.Add(this.lblProfileCardTitle);
            this.pnlProfileCard.Controls.Add(this.pnlProfileDivider);
            this.pnlProfileCard.Controls.Add(this.lblSettingsFullName);
            this.pnlProfileCard.Controls.Add(this.txtSettingsFullName);
            this.pnlProfileCard.Controls.Add(this.lblSettingsEmail);
            this.pnlProfileCard.Controls.Add(this.txtSettingsEmail);
            this.pnlProfileCard.Controls.Add(this.lblSettingsRole);
            this.pnlProfileCard.Controls.Add(this.txtSettingsRole);
            this.pnlProfileCard.Controls.Add(this.lblSettingsStatus);
            this.pnlProfileCard.Controls.Add(this.txtSettingsStatus);
            this.pnlProfileCard.Controls.Add(this.lblSettingsCreatedAt);
            this.pnlProfileCard.Controls.Add(this.txtSettingsCreatedAt);
            this.pnlProfileCard.Controls.Add(this.btnSaveProfile);
            this.pnlProfileCard.Location = new System.Drawing.Point(26, 80);
            this.pnlProfileCard.Name = "pnlProfileCard";
            this.pnlProfileCard.Size = new System.Drawing.Size(400, 490);
            this.pnlProfileCard.TabIndex = 2;
            // 
            // pnlextrastd
            // 
            this.pnlextrastd.Controls.Add(this.cmbskill);
            this.pnlextrastd.Controls.Add(this.lblskill);
            this.pnlextrastd.Controls.Add(this.lblregno);
            this.pnlextrastd.Controls.Add(this.txtregno);
            this.pnlextrastd.Location = new System.Drawing.Point(20, 116);
            this.pnlextrastd.Name = "pnlextrastd";
            this.pnlextrastd.Size = new System.Drawing.Size(360, 110);
            this.pnlextrastd.TabIndex = 17;
            // 
            // cmbskill
            // 
            this.cmbskill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(26)))));
            this.cmbskill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbskill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.cmbskill.FormattingEnabled = true;
            this.cmbskill.Location = new System.Drawing.Point(0, 84);
            this.cmbskill.Name = "cmbskill";
            this.cmbskill.Size = new System.Drawing.Size(357, 23);
            this.cmbskill.TabIndex = 24;
            // 
            // lblskill
            // 
            this.lblskill.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblskill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblskill.Location = new System.Drawing.Point(0, 57);
            this.lblskill.Name = "lblskill";
            this.lblskill.Size = new System.Drawing.Size(360, 18);
            this.lblskill.TabIndex = 23;
            this.lblskill.Text = "Skill Level";
            // 
            // lblregno
            // 
            this.lblregno.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblregno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblregno.Location = new System.Drawing.Point(0, -1);
            this.lblregno.Name = "lblregno";
            this.lblregno.Size = new System.Drawing.Size(360, 18);
            this.lblregno.TabIndex = 21;
            this.lblregno.Text = "Registration Number";
            // 
            // txtregno
            // 
            this.txtregno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(26)))));
            this.txtregno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtregno.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtregno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.txtregno.Location = new System.Drawing.Point(0, 24);
            this.txtregno.Name = "txtregno";
            this.txtregno.Size = new System.Drawing.Size(360, 25);
            this.txtregno.TabIndex = 22;
            // 
            // pnlProfileAccent
            // 
            this.pnlProfileAccent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.pnlProfileAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlProfileAccent.Name = "pnlProfileAccent";
            this.pnlProfileAccent.Size = new System.Drawing.Size(400, 4);
            this.pnlProfileAccent.TabIndex = 0;
            // 
            // lblProfileCardTitle
            // 
            this.lblProfileCardTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblProfileCardTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.lblProfileCardTitle.Location = new System.Drawing.Point(20, 18);
            this.lblProfileCardTitle.Name = "lblProfileCardTitle";
            this.lblProfileCardTitle.Size = new System.Drawing.Size(350, 26);
            this.lblProfileCardTitle.TabIndex = 1;
            this.lblProfileCardTitle.Text = "Profile Information";
            // 
            // pnlProfileDivider
            // 
            this.pnlProfileDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.pnlProfileDivider.Location = new System.Drawing.Point(20, 48);
            this.pnlProfileDivider.Name = "pnlProfileDivider";
            this.pnlProfileDivider.Size = new System.Drawing.Size(360, 1);
            this.pnlProfileDivider.TabIndex = 2;
            // 
            // lblSettingsFullName
            // 
            this.lblSettingsFullName.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSettingsFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblSettingsFullName.Location = new System.Drawing.Point(20, 60);
            this.lblSettingsFullName.Name = "lblSettingsFullName";
            this.lblSettingsFullName.Size = new System.Drawing.Size(360, 18);
            this.lblSettingsFullName.TabIndex = 3;
            this.lblSettingsFullName.Text = "Full Name";
            // 
            // txtSettingsFullName
            // 
            this.txtSettingsFullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(26)))));
            this.txtSettingsFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSettingsFullName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSettingsFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.txtSettingsFullName.Location = new System.Drawing.Point(20, 81);
            this.txtSettingsFullName.Name = "txtSettingsFullName";
            this.txtSettingsFullName.Size = new System.Drawing.Size(360, 25);
            this.txtSettingsFullName.TabIndex = 4;
            // 
            // lblSettingsEmail
            // 
            this.lblSettingsEmail.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSettingsEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblSettingsEmail.Location = new System.Drawing.Point(20, 236);
            this.lblSettingsEmail.Name = "lblSettingsEmail";
            this.lblSettingsEmail.Size = new System.Drawing.Size(360, 18);
            this.lblSettingsEmail.TabIndex = 5;
            this.lblSettingsEmail.Text = "Email Address";
            // 
            // txtSettingsEmail
            // 
            this.txtSettingsEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(26)))));
            this.txtSettingsEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSettingsEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSettingsEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.txtSettingsEmail.Location = new System.Drawing.Point(20, 257);
            this.txtSettingsEmail.Name = "txtSettingsEmail";
            this.txtSettingsEmail.Size = new System.Drawing.Size(360, 25);
            this.txtSettingsEmail.TabIndex = 6;
            // 
            // lblSettingsRole
            // 
            this.lblSettingsRole.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSettingsRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblSettingsRole.Location = new System.Drawing.Point(20, 291);
            this.lblSettingsRole.Name = "lblSettingsRole";
            this.lblSettingsRole.Size = new System.Drawing.Size(170, 18);
            this.lblSettingsRole.TabIndex = 7;
            this.lblSettingsRole.Text = "Role";
            // 
            // txtSettingsRole
            // 
            this.txtSettingsRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(26)))));
            this.txtSettingsRole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSettingsRole.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.txtSettingsRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.txtSettingsRole.Location = new System.Drawing.Point(20, 312);
            this.txtSettingsRole.Name = "txtSettingsRole";
            this.txtSettingsRole.ReadOnly = true;
            this.txtSettingsRole.Size = new System.Drawing.Size(170, 25);
            this.txtSettingsRole.TabIndex = 8;
            // 
            // lblSettingsStatus
            // 
            this.lblSettingsStatus.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSettingsStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblSettingsStatus.Location = new System.Drawing.Point(210, 291);
            this.lblSettingsStatus.Name = "lblSettingsStatus";
            this.lblSettingsStatus.Size = new System.Drawing.Size(170, 18);
            this.lblSettingsStatus.TabIndex = 9;
            this.lblSettingsStatus.Text = "Status";
            // 
            // txtSettingsStatus
            // 
            this.txtSettingsStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(26)))));
            this.txtSettingsStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSettingsStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.txtSettingsStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(211)))), ((int)(((byte)(153)))));
            this.txtSettingsStatus.Location = new System.Drawing.Point(210, 312);
            this.txtSettingsStatus.Name = "txtSettingsStatus";
            this.txtSettingsStatus.ReadOnly = true;
            this.txtSettingsStatus.Size = new System.Drawing.Size(170, 25);
            this.txtSettingsStatus.TabIndex = 10;
            // 
            // lblSettingsCreatedAt
            // 
            this.lblSettingsCreatedAt.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSettingsCreatedAt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblSettingsCreatedAt.Location = new System.Drawing.Point(20, 347);
            this.lblSettingsCreatedAt.Name = "lblSettingsCreatedAt";
            this.lblSettingsCreatedAt.Size = new System.Drawing.Size(360, 18);
            this.lblSettingsCreatedAt.TabIndex = 11;
            this.lblSettingsCreatedAt.Text = "Member Since";
            // 
            // txtSettingsCreatedAt
            // 
            this.txtSettingsCreatedAt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(26)))));
            this.txtSettingsCreatedAt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSettingsCreatedAt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSettingsCreatedAt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(220)))));
            this.txtSettingsCreatedAt.Location = new System.Drawing.Point(20, 368);
            this.txtSettingsCreatedAt.Name = "txtSettingsCreatedAt";
            this.txtSettingsCreatedAt.ReadOnly = true;
            this.txtSettingsCreatedAt.Size = new System.Drawing.Size(360, 25);
            this.txtSettingsCreatedAt.TabIndex = 12;
            // 
            // btnSaveProfile
            // 
            this.btnSaveProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnSaveProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveProfile.FlatAppearance.BorderSize = 0;
            this.btnSaveProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(82)))), ((int)(((byte)(221)))));
            this.btnSaveProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaveProfile.ForeColor = System.Drawing.Color.White;
            this.btnSaveProfile.Location = new System.Drawing.Point(20, 430);
            this.btnSaveProfile.Name = "btnSaveProfile";
            this.btnSaveProfile.Size = new System.Drawing.Size(360, 40);
            this.btnSaveProfile.TabIndex = 13;
            this.btnSaveProfile.Text = "💾   Save Changes";
            this.btnSaveProfile.UseVisualStyleBackColor = false;
            this.btnSaveProfile.Click += new System.EventHandler(this.btnSaveProfile_Click);
            // 
            // pnlPasswordCard
            // 
            this.pnlPasswordCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.pnlPasswordCard.Controls.Add(this.pnlPasswordAccent);
            this.pnlPasswordCard.Controls.Add(this.lblPasswordCardTitle);
            this.pnlPasswordCard.Controls.Add(this.pnlPasswordDivider);
            this.pnlPasswordCard.Controls.Add(this.lblSecurityTip);
            this.pnlPasswordCard.Controls.Add(this.lblCurrentPassword);
            this.pnlPasswordCard.Controls.Add(this.txtCurrentPassword);
            this.pnlPasswordCard.Controls.Add(this.lblNewPassword);
            this.pnlPasswordCard.Controls.Add(this.txtNewPassword);
            this.pnlPasswordCard.Controls.Add(this.lblConfirmPassword);
            this.pnlPasswordCard.Controls.Add(this.txtConfirmPassword);
            this.pnlPasswordCard.Controls.Add(this.lblPasswordMatchHint);
            this.pnlPasswordCard.Controls.Add(this.btnChangePassword);
            this.pnlPasswordCard.Location = new System.Drawing.Point(454, 80);
            this.pnlPasswordCard.Name = "pnlPasswordCard";
            this.pnlPasswordCard.Size = new System.Drawing.Size(420, 490);
            this.pnlPasswordCard.TabIndex = 3;
            // 
            // pnlPasswordAccent
            // 
            this.pnlPasswordAccent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.pnlPasswordAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlPasswordAccent.Name = "pnlPasswordAccent";
            this.pnlPasswordAccent.Size = new System.Drawing.Size(420, 4);
            this.pnlPasswordAccent.TabIndex = 0;
            // 
            // lblPasswordCardTitle
            // 
            this.lblPasswordCardTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblPasswordCardTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.lblPasswordCardTitle.Location = new System.Drawing.Point(20, 18);
            this.lblPasswordCardTitle.Name = "lblPasswordCardTitle";
            this.lblPasswordCardTitle.Size = new System.Drawing.Size(380, 26);
            this.lblPasswordCardTitle.TabIndex = 1;
            this.lblPasswordCardTitle.Text = "Change Password";
            // 
            // pnlPasswordDivider
            // 
            this.pnlPasswordDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.pnlPasswordDivider.Location = new System.Drawing.Point(20, 48);
            this.pnlPasswordDivider.Name = "pnlPasswordDivider";
            this.pnlPasswordDivider.Size = new System.Drawing.Size(380, 1);
            this.pnlPasswordDivider.TabIndex = 2;
            // 
            // lblSecurityTip
            // 
            this.lblSecurityTip.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSecurityTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblSecurityTip.Location = new System.Drawing.Point(20, 56);
            this.lblSecurityTip.Name = "lblSecurityTip";
            this.lblSecurityTip.Size = new System.Drawing.Size(380, 18);
            this.lblSecurityTip.TabIndex = 3;
            this.lblSecurityTip.Text = "🔒  Use at least 6 characters with a mix of letters and numbers.";
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCurrentPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblCurrentPassword.Location = new System.Drawing.Point(20, 88);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(380, 18);
            this.lblCurrentPassword.TabIndex = 4;
            this.lblCurrentPassword.Text = "Current Password";
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(26)))));
            this.txtCurrentPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCurrentPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.txtCurrentPassword.Location = new System.Drawing.Point(20, 109);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.PasswordChar = '●';
            this.txtCurrentPassword.Size = new System.Drawing.Size(380, 25);
            this.txtCurrentPassword.TabIndex = 5;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblNewPassword.Location = new System.Drawing.Point(20, 154);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(380, 18);
            this.lblNewPassword.TabIndex = 6;
            this.lblNewPassword.Text = "New Password";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(26)))));
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.txtNewPassword.Location = new System.Drawing.Point(20, 175);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '●';
            this.txtNewPassword.Size = new System.Drawing.Size(380, 25);
            this.txtNewPassword.TabIndex = 7;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblConfirmPassword.Location = new System.Drawing.Point(20, 220);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(380, 18);
            this.lblConfirmPassword.TabIndex = 8;
            this.lblConfirmPassword.Text = "Confirm New Password";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(26)))));
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword.Location = new System.Drawing.Point(20, 241);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '●';
            this.txtConfirmPassword.Size = new System.Drawing.Size(380, 25);
            this.txtConfirmPassword.TabIndex = 9;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
            // 
            // lblPasswordMatchHint
            // 
            this.lblPasswordMatchHint.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblPasswordMatchHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(211)))), ((int)(((byte)(153)))));
            this.lblPasswordMatchHint.Location = new System.Drawing.Point(20, 276);
            this.lblPasswordMatchHint.Name = "lblPasswordMatchHint";
            this.lblPasswordMatchHint.Size = new System.Drawing.Size(380, 18);
            this.lblPasswordMatchHint.TabIndex = 10;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(93)))), ((int)(((byte)(113)))));
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(20, 430);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(380, 40);
            this.btnChangePassword.TabIndex = 11;
            this.btnChangePassword.Text = "🔑   Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // SettingsForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(884, 581);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlProfileCard);
            this.Controls.Add(this.pnlPasswordCard);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings — Profile";
            this.Load += new System.EventHandler(this.SettingsPanelUI_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlProfileCard.ResumeLayout(false);
            this.pnlProfileCard.PerformLayout();
            this.pnlextrastd.ResumeLayout(false);
            this.pnlextrastd.PerformLayout();
            this.pnlPasswordCard.ResumeLayout(false);
            this.pnlPasswordCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        // ── Field declarations ───────────────────────────────────────
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblPageTitle;

        private System.Windows.Forms.Panel pnlProfileCard;
        private System.Windows.Forms.Panel pnlProfileAccent;
        private System.Windows.Forms.Panel pnlProfileDivider;
        private System.Windows.Forms.Label lblProfileCardTitle;
        private System.Windows.Forms.Label lblSettingsFullName;
        private System.Windows.Forms.TextBox txtSettingsFullName;
        private System.Windows.Forms.Label lblSettingsEmail;
        private System.Windows.Forms.TextBox txtSettingsEmail;
        private System.Windows.Forms.Label lblSettingsRole;
        private System.Windows.Forms.TextBox txtSettingsRole;
        private System.Windows.Forms.Label lblSettingsStatus;
        private System.Windows.Forms.TextBox txtSettingsStatus;
        private System.Windows.Forms.Label lblSettingsCreatedAt;
        private System.Windows.Forms.TextBox txtSettingsCreatedAt;
        private System.Windows.Forms.Button btnSaveProfile;

        private System.Windows.Forms.Panel pnlPasswordCard;
        private System.Windows.Forms.Panel pnlPasswordAccent;
        private System.Windows.Forms.Panel pnlPasswordDivider;
        private System.Windows.Forms.Label lblPasswordCardTitle;
        private System.Windows.Forms.Label lblSecurityTip;
        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblPasswordMatchHint;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Panel pnlextrastd;
        private System.Windows.Forms.ComboBox cmbskill;
        private System.Windows.Forms.Label lblskill;
        private System.Windows.Forms.Label lblregno;
        private System.Windows.Forms.TextBox txtregno;
    }
}