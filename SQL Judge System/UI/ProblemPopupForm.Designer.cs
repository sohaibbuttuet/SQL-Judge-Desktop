namespace SQL_Judge_System.UI
{
    partial class ProblemPopupForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.Panel updatePanel;

        // ================= ADD =================
        private System.Windows.Forms.Label lblAddTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblTags;

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cmbDifficulty;
        private System.Windows.Forms.TextBox txtPoints;
        private System.Windows.Forms.CheckedListBox clbAddTags;

        // ================= UPDATE =================
        private System.Windows.Forms.Label lblUpdateTitle;
        private System.Windows.Forms.Label lblUTitle;
        private System.Windows.Forms.Label lblUDescription;
        private System.Windows.Forms.Label lblUDifficulty;
        private System.Windows.Forms.Label lblUPoints;
        private System.Windows.Forms.Label lblUTags;
        private System.Windows.Forms.TextBox txtUTitle;
        private System.Windows.Forms.TextBox txtUDescription;
        private System.Windows.Forms.ComboBox cmbUDifficulty;
        private System.Windows.Forms.TextBox txtUPoints;
        private System.Windows.Forms.CheckedListBox clbUpdateTags;

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
            this.btnAddClear = new System.Windows.Forms.Button();
            this.lblAddTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.cmbDifficulty = new System.Windows.Forms.ComboBox();
            this.lblPoints = new System.Windows.Forms.Label();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.lblTags = new System.Windows.Forms.Label();
            this.clbAddTags = new System.Windows.Forms.CheckedListBox();
            this.updatePanel = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnUClear = new System.Windows.Forms.Button();
            this.lblUpdateTitle = new System.Windows.Forms.Label();
            this.lblUTitle = new System.Windows.Forms.Label();
            this.txtUTitle = new System.Windows.Forms.TextBox();
            this.lblUDescription = new System.Windows.Forms.Label();
            this.txtUDescription = new System.Windows.Forms.TextBox();
            this.lblUDifficulty = new System.Windows.Forms.Label();
            this.cmbUDifficulty = new System.Windows.Forms.ComboBox();
            this.lblUPoints = new System.Windows.Forms.Label();
            this.txtUPoints = new System.Windows.Forms.TextBox();
            this.lblUTags = new System.Windows.Forms.Label();
            this.clbUpdateTags = new System.Windows.Forms.CheckedListBox();
            this.addPanel.SuspendLayout();
            this.updatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addPanel
            // 
            this.addPanel.Controls.Add(this.btnAdd);
            this.addPanel.Controls.Add(this.btnAddClear);
            this.addPanel.Controls.Add(this.lblAddTitle);
            this.addPanel.Controls.Add(this.lblTitle);
            this.addPanel.Controls.Add(this.txtTitle);
            this.addPanel.Controls.Add(this.lblDescription);
            this.addPanel.Controls.Add(this.txtDescription);
            this.addPanel.Controls.Add(this.lblDifficulty);
            this.addPanel.Controls.Add(this.cmbDifficulty);
            this.addPanel.Controls.Add(this.lblPoints);
            this.addPanel.Controls.Add(this.txtPoints);
            this.addPanel.Controls.Add(this.lblTags);
            this.addPanel.Controls.Add(this.clbAddTags);
            this.addPanel.Location = new System.Drawing.Point(31, 31);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(523, 409);
            this.addPanel.TabIndex = 2;
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
            this.btnAdd.Location = new System.Drawing.Point(20, 357);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddClear
            // 
            this.btnAddClear.BackColor = System.Drawing.Color.IndianRed;
            this.btnAddClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddClear.FlatAppearance.BorderSize = 0;
            this.btnAddClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btnAddClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btnAddClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClear.ForeColor = System.Drawing.Color.White;
            this.btnAddClear.Location = new System.Drawing.Point(120, 357);
            this.btnAddClear.Name = "btnAddClear";
            this.btnAddClear.Size = new System.Drawing.Size(75, 23);
            this.btnAddClear.TabIndex = 14;
            this.btnAddClear.Text = "Clear";
            this.btnAddClear.UseVisualStyleBackColor = false;
            this.btnAddClear.Click += new System.EventHandler(this.btnAddClear_Click);
            // 
            // lblAddTitle
            // 
            this.lblAddTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblAddTitle.Location = new System.Drawing.Point(203, 12);
            this.lblAddTitle.Name = "lblAddTitle";
            this.lblAddTitle.Size = new System.Drawing.Size(116, 23);
            this.lblAddTitle.TabIndex = 0;
            this.lblAddTitle.Text = "Add Problem";
            this.lblAddTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 45);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(100, 20);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.ForeColor = System.Drawing.Color.White;
            this.txtTitle.Location = new System.Drawing.Point(20, 66);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(450, 20);
            this.txtTitle.TabIndex = 2;
            // 
            // lblDescription
            // 
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblDescription.Location = new System.Drawing.Point(20, 95);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(100, 18);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.ForeColor = System.Drawing.Color.White;
            this.txtDescription.Location = new System.Drawing.Point(20, 114);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(450, 60);
            this.txtDescription.TabIndex = 4;
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblDifficulty.Location = new System.Drawing.Point(20, 183);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(100, 20);
            this.lblDifficulty.TabIndex = 5;
            this.lblDifficulty.Text = "Difficulty";
            // 
            // cmbDifficulty
            // 
            this.cmbDifficulty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.cmbDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDifficulty.ForeColor = System.Drawing.Color.White;
            this.cmbDifficulty.Location = new System.Drawing.Point(20, 203);
            this.cmbDifficulty.Name = "cmbDifficulty";
            this.cmbDifficulty.Size = new System.Drawing.Size(150, 21);
            this.cmbDifficulty.TabIndex = 6;
            // 
            // lblPoints
            // 
            this.lblPoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblPoints.Location = new System.Drawing.Point(200, 184);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(100, 16);
            this.lblPoints.TabIndex = 7;
            this.lblPoints.Text = "Points";
            // 
            // txtPoints
            // 
            this.txtPoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.txtPoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPoints.ForeColor = System.Drawing.Color.White;
            this.txtPoints.Location = new System.Drawing.Point(200, 203);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.Size = new System.Drawing.Size(100, 20);
            this.txtPoints.TabIndex = 8;
            // 
            // lblTags
            // 
            this.lblTags.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblTags.Location = new System.Drawing.Point(20, 235);
            this.lblTags.Name = "lblTags";
            this.lblTags.Size = new System.Drawing.Size(100, 20);
            this.lblTags.TabIndex = 9;
            this.lblTags.Text = "Tags";
            // 
            // clbAddTags
            // 
            this.clbAddTags.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.clbAddTags.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbAddTags.ForeColor = System.Drawing.Color.White;
            this.clbAddTags.Location = new System.Drawing.Point(20, 256);
            this.clbAddTags.Name = "clbAddTags";
            this.clbAddTags.Size = new System.Drawing.Size(450, 75);
            this.clbAddTags.TabIndex = 10;
            // 
            // updatePanel
            // 
            this.updatePanel.Controls.Add(this.btnUpdate);
            this.updatePanel.Controls.Add(this.btnUClear);
            this.updatePanel.Controls.Add(this.lblUpdateTitle);
            this.updatePanel.Controls.Add(this.lblUTitle);
            this.updatePanel.Controls.Add(this.txtUTitle);
            this.updatePanel.Controls.Add(this.lblUDescription);
            this.updatePanel.Controls.Add(this.txtUDescription);
            this.updatePanel.Controls.Add(this.lblUDifficulty);
            this.updatePanel.Controls.Add(this.cmbUDifficulty);
            this.updatePanel.Controls.Add(this.lblUPoints);
            this.updatePanel.Controls.Add(this.txtUPoints);
            this.updatePanel.Controls.Add(this.lblUTags);
            this.updatePanel.Controls.Add(this.clbUpdateTags);
            this.updatePanel.Location = new System.Drawing.Point(31, 31);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Size = new System.Drawing.Size(523, 409);
            this.updatePanel.TabIndex = 3;
            this.updatePanel.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(20, 361);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnUClear
            // 
            this.btnUClear.BackColor = System.Drawing.Color.IndianRed;
            this.btnUClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUClear.FlatAppearance.BorderSize = 0;
            this.btnUClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btnUClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btnUClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUClear.ForeColor = System.Drawing.Color.White;
            this.btnUClear.Location = new System.Drawing.Point(120, 361);
            this.btnUClear.Name = "btnUClear";
            this.btnUClear.Size = new System.Drawing.Size(75, 23);
            this.btnUClear.TabIndex = 16;
            this.btnUClear.Text = "Clear";
            this.btnUClear.UseVisualStyleBackColor = false;
            this.btnUClear.Click += new System.EventHandler(this.btnUClear_Click);
            // 
            // lblUpdateTitle
            // 
            this.lblUpdateTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblUpdateTitle.Location = new System.Drawing.Point(180, 10);
            this.lblUpdateTitle.Name = "lblUpdateTitle";
            this.lblUpdateTitle.Size = new System.Drawing.Size(162, 23);
            this.lblUpdateTitle.TabIndex = 0;
            this.lblUpdateTitle.Text = "Update Problem";
            this.lblUpdateTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUTitle
            // 
            this.lblUTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblUTitle.Location = new System.Drawing.Point(19, 50);
            this.lblUTitle.Name = "lblUTitle";
            this.lblUTitle.Size = new System.Drawing.Size(100, 15);
            this.lblUTitle.TabIndex = 3;
            this.lblUTitle.Text = "New Title";
            // 
            // txtUTitle
            // 
            this.txtUTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.txtUTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUTitle.ForeColor = System.Drawing.Color.White;
            this.txtUTitle.Location = new System.Drawing.Point(20, 68);
            this.txtUTitle.Name = "txtUTitle";
            this.txtUTitle.Size = new System.Drawing.Size(450, 23);
            this.txtUTitle.TabIndex = 4;
            // 
            // lblUDescription
            // 
            this.lblUDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblUDescription.Location = new System.Drawing.Point(18, 100);
            this.lblUDescription.Name = "lblUDescription";
            this.lblUDescription.Size = new System.Drawing.Size(100, 15);
            this.lblUDescription.TabIndex = 5;
            this.lblUDescription.Text = "Description";
            // 
            // txtUDescription
            // 
            this.txtUDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.txtUDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUDescription.ForeColor = System.Drawing.Color.White;
            this.txtUDescription.Location = new System.Drawing.Point(20, 118);
            this.txtUDescription.Multiline = true;
            this.txtUDescription.Name = "txtUDescription";
            this.txtUDescription.Size = new System.Drawing.Size(450, 60);
            this.txtUDescription.TabIndex = 6;
            // 
            // lblUDifficulty
            // 
            this.lblUDifficulty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblUDifficulty.Location = new System.Drawing.Point(20, 190);
            this.lblUDifficulty.Name = "lblUDifficulty";
            this.lblUDifficulty.Size = new System.Drawing.Size(100, 15);
            this.lblUDifficulty.TabIndex = 7;
            this.lblUDifficulty.Text = "Difficulty";
            // 
            // cmbUDifficulty
            // 
            this.cmbUDifficulty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.cmbUDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUDifficulty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUDifficulty.ForeColor = System.Drawing.Color.White;
            this.cmbUDifficulty.Location = new System.Drawing.Point(20, 208);
            this.cmbUDifficulty.Name = "cmbUDifficulty";
            this.cmbUDifficulty.Size = new System.Drawing.Size(150, 23);
            this.cmbUDifficulty.TabIndex = 8;
            // 
            // lblUPoints
            // 
            this.lblUPoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblUPoints.Location = new System.Drawing.Point(200, 189);
            this.lblUPoints.Name = "lblUPoints";
            this.lblUPoints.Size = new System.Drawing.Size(100, 15);
            this.lblUPoints.TabIndex = 9;
            this.lblUPoints.Text = "Points";
            // 
            // txtUPoints
            // 
            this.txtUPoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.txtUPoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUPoints.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUPoints.ForeColor = System.Drawing.Color.White;
            this.txtUPoints.Location = new System.Drawing.Point(200, 208);
            this.txtUPoints.Name = "txtUPoints";
            this.txtUPoints.Size = new System.Drawing.Size(100, 23);
            this.txtUPoints.TabIndex = 10;
            // 
            // lblUTags
            // 
            this.lblUTags.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblUTags.Location = new System.Drawing.Point(20, 245);
            this.lblUTags.Name = "lblUTags";
            this.lblUTags.Size = new System.Drawing.Size(100, 14);
            this.lblUTags.TabIndex = 11;
            this.lblUTags.Text = "Tags";
            // 
            // clbUpdateTags
            // 
            this.clbUpdateTags.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.clbUpdateTags.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbUpdateTags.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbUpdateTags.ForeColor = System.Drawing.Color.White;
            this.clbUpdateTags.Location = new System.Drawing.Point(20, 263);
            this.clbUpdateTags.Name = "clbUpdateTags";
            this.clbUpdateTags.Size = new System.Drawing.Size(450, 72);
            this.clbUpdateTags.TabIndex = 12;
            // 
            // ProblemPopupForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.addPanel);
            this.Controls.Add(this.updatePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ProblemPopupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Problem Management";
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            this.updatePanel.ResumeLayout(false);
            this.updatePanel.PerformLayout();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnUClear;
    }
}