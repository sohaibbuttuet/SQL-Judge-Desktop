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
        private System.Windows.Forms.Label lblProblemId;
        private System.Windows.Forms.Label lblUTitle;
        private System.Windows.Forms.Label lblUDescription;
        private System.Windows.Forms.Label lblUDifficulty;
        private System.Windows.Forms.Label lblUPoints;
        private System.Windows.Forms.Label lblUTags;

        private System.Windows.Forms.TextBox txtProblemId;
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
            this.lblProblemId = new System.Windows.Forms.Label();
            this.txtProblemId = new System.Windows.Forms.TextBox();
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
            this.btnShowAdd = new System.Windows.Forms.Button();
            this.btnShowUpdate = new System.Windows.Forms.Button();
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
            this.addPanel.Location = new System.Drawing.Point(30, 60);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(520, 430);
            this.addPanel.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(20, 366);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnAddClear
            // 
            this.btnAddClear.BackColor = System.Drawing.Color.IndianRed;
            this.btnAddClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClear.ForeColor = System.Drawing.Color.White;
            this.btnAddClear.Location = new System.Drawing.Point(120, 366);
            this.btnAddClear.Name = "btnAddClear";
            this.btnAddClear.Size = new System.Drawing.Size(75, 23);
            this.btnAddClear.TabIndex = 14;
            this.btnAddClear.Text = "Clear";
            this.btnAddClear.UseVisualStyleBackColor = false;
            // 
            // lblAddTitle
            // 
            this.lblAddTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddTitle.Location = new System.Drawing.Point(191, 10);
            this.lblAddTitle.Name = "lblAddTitle";
            this.lblAddTitle.Size = new System.Drawing.Size(138, 23);
            this.lblAddTitle.TabIndex = 0;
            this.lblAddTitle.Text = "Add Problem";
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(20, 50);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(100, 23);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(20, 73);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(450, 20);
            this.txtTitle.TabIndex = 2;
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(20, 100);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(100, 23);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(20, 123);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(450, 60);
            this.txtDescription.TabIndex = 4;
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.Location = new System.Drawing.Point(20, 190);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(100, 23);
            this.lblDifficulty.TabIndex = 5;
            this.lblDifficulty.Text = "Difficulty";
            // 
            // cmbDifficulty
            // 
            this.cmbDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDifficulty.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.cmbDifficulty.Location = new System.Drawing.Point(20, 213);
            this.cmbDifficulty.Name = "cmbDifficulty";
            this.cmbDifficulty.Size = new System.Drawing.Size(150, 21);
            this.cmbDifficulty.TabIndex = 6;
            // 
            // lblPoints
            // 
            this.lblPoints.Location = new System.Drawing.Point(200, 190);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(100, 23);
            this.lblPoints.TabIndex = 7;
            this.lblPoints.Text = "Points";
            // 
            // txtPoints
            // 
            this.txtPoints.Location = new System.Drawing.Point(200, 213);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.Size = new System.Drawing.Size(100, 20);
            this.txtPoints.TabIndex = 8;
            // 
            // lblTags
            // 
            this.lblTags.Location = new System.Drawing.Point(20, 240);
            this.lblTags.Name = "lblTags";
            this.lblTags.Size = new System.Drawing.Size(100, 23);
            this.lblTags.TabIndex = 9;
            this.lblTags.Text = "Tags";
            // 
            // clbAddTags
            // 
            this.clbAddTags.Location = new System.Drawing.Point(20, 263);
            this.clbAddTags.Name = "clbAddTags";
            this.clbAddTags.Size = new System.Drawing.Size(450, 79);
            this.clbAddTags.TabIndex = 10;
            // 
            // updatePanel
            // 
            this.updatePanel.Controls.Add(this.btnUpdate);
            this.updatePanel.Controls.Add(this.btnUClear);
            this.updatePanel.Controls.Add(this.lblUpdateTitle);
            this.updatePanel.Controls.Add(this.lblProblemId);
            this.updatePanel.Controls.Add(this.txtProblemId);
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
            this.updatePanel.Location = new System.Drawing.Point(30, 60);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Size = new System.Drawing.Size(520, 430);
            this.updatePanel.TabIndex = 3;
            this.updatePanel.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(20, 392);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnUClear
            // 
            this.btnUClear.BackColor = System.Drawing.Color.IndianRed;
            this.btnUClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUClear.ForeColor = System.Drawing.Color.White;
            this.btnUClear.Location = new System.Drawing.Point(120, 392);
            this.btnUClear.Name = "btnUClear";
            this.btnUClear.Size = new System.Drawing.Size(75, 23);
            this.btnUClear.TabIndex = 16;
            this.btnUClear.Text = "Clear";
            this.btnUClear.UseVisualStyleBackColor = false;
            // 
            // lblUpdateTitle
            // 
            this.lblUpdateTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateTitle.Location = new System.Drawing.Point(179, 10);
            this.lblUpdateTitle.Name = "lblUpdateTitle";
            this.lblUpdateTitle.Size = new System.Drawing.Size(162, 23);
            this.lblUpdateTitle.TabIndex = 0;
            this.lblUpdateTitle.Text = "Update Problem";
            // 
            // lblProblemId
            // 
            this.lblProblemId.Location = new System.Drawing.Point(20, 36);
            this.lblProblemId.Name = "lblProblemId";
            this.lblProblemId.Size = new System.Drawing.Size(100, 23);
            this.lblProblemId.TabIndex = 1;
            this.lblProblemId.Text = "Problem ID";
            // 
            // txtProblemId
            // 
            this.txtProblemId.Location = new System.Drawing.Point(20, 59);
            this.txtProblemId.Name = "txtProblemId";
            this.txtProblemId.Size = new System.Drawing.Size(450, 20);
            this.txtProblemId.TabIndex = 2;
            // 
            // lblUTitle
            // 
            this.lblUTitle.Location = new System.Drawing.Point(20, 86);
            this.lblUTitle.Name = "lblUTitle";
            this.lblUTitle.Size = new System.Drawing.Size(100, 23);
            this.lblUTitle.TabIndex = 3;
            this.lblUTitle.Text = "Title";
            // 
            // txtUTitle
            // 
            this.txtUTitle.Location = new System.Drawing.Point(20, 109);
            this.txtUTitle.Name = "txtUTitle";
            this.txtUTitle.Size = new System.Drawing.Size(450, 20);
            this.txtUTitle.TabIndex = 4;
            // 
            // lblUDescription
            // 
            this.lblUDescription.Location = new System.Drawing.Point(20, 136);
            this.lblUDescription.Name = "lblUDescription";
            this.lblUDescription.Size = new System.Drawing.Size(100, 23);
            this.lblUDescription.TabIndex = 5;
            this.lblUDescription.Text = "Description";
            // 
            // txtUDescription
            // 
            this.txtUDescription.Location = new System.Drawing.Point(20, 159);
            this.txtUDescription.Multiline = true;
            this.txtUDescription.Name = "txtUDescription";
            this.txtUDescription.Size = new System.Drawing.Size(450, 60);
            this.txtUDescription.TabIndex = 6;
            // 
            // lblUDifficulty
            // 
            this.lblUDifficulty.Location = new System.Drawing.Point(20, 226);
            this.lblUDifficulty.Name = "lblUDifficulty";
            this.lblUDifficulty.Size = new System.Drawing.Size(100, 23);
            this.lblUDifficulty.TabIndex = 7;
            this.lblUDifficulty.Text = "Difficulty";
            // 
            // cmbUDifficulty
            // 
            this.cmbUDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUDifficulty.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.cmbUDifficulty.Location = new System.Drawing.Point(20, 249);
            this.cmbUDifficulty.Name = "cmbUDifficulty";
            this.cmbUDifficulty.Size = new System.Drawing.Size(150, 21);
            this.cmbUDifficulty.TabIndex = 8;
            // 
            // lblUPoints
            // 
            this.lblUPoints.Location = new System.Drawing.Point(200, 226);
            this.lblUPoints.Name = "lblUPoints";
            this.lblUPoints.Size = new System.Drawing.Size(100, 23);
            this.lblUPoints.TabIndex = 9;
            this.lblUPoints.Text = "Points";
            // 
            // txtUPoints
            // 
            this.txtUPoints.Location = new System.Drawing.Point(200, 249);
            this.txtUPoints.Name = "txtUPoints";
            this.txtUPoints.Size = new System.Drawing.Size(100, 20);
            this.txtUPoints.TabIndex = 10;
            // 
            // lblUTags
            // 
            this.lblUTags.Location = new System.Drawing.Point(20, 276);
            this.lblUTags.Name = "lblUTags";
            this.lblUTags.Size = new System.Drawing.Size(100, 23);
            this.lblUTags.TabIndex = 11;
            this.lblUTags.Text = "Tags";
            // 
            // clbUpdateTags
            // 
            this.clbUpdateTags.Location = new System.Drawing.Point(20, 299);
            this.clbUpdateTags.Name = "clbUpdateTags";
            this.clbUpdateTags.Size = new System.Drawing.Size(450, 79);
            this.clbUpdateTags.TabIndex = 12;
            // 
            // btnShowAdd
            // 
            this.btnShowAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnShowAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAdd.ForeColor = System.Drawing.Color.White;
            this.btnShowAdd.Location = new System.Drawing.Point(30, 21);
            this.btnShowAdd.Name = "btnShowAdd";
            this.btnShowAdd.Size = new System.Drawing.Size(95, 23);
            this.btnShowAdd.TabIndex = 4;
            this.btnShowAdd.Text = "Add Problem";
            this.btnShowAdd.UseVisualStyleBackColor = false;
            this.btnShowAdd.Click += new System.EventHandler(this.btnShowAdd_Click);
            // 
            // btnShowUpdate
            // 
            this.btnShowUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnShowUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowUpdate.ForeColor = System.Drawing.Color.White;
            this.btnShowUpdate.Location = new System.Drawing.Point(150, 21);
            this.btnShowUpdate.Name = "btnShowUpdate";
            this.btnShowUpdate.Size = new System.Drawing.Size(95, 23);
            this.btnShowUpdate.TabIndex = 5;
            this.btnShowUpdate.Text = "Update Problem";
            this.btnShowUpdate.UseVisualStyleBackColor = false;
            this.btnShowUpdate.Click += new System.EventHandler(this.btnShowUpdate_Click);
            // 
            // ProblemPopupForm
            // 
            this.ClientSize = new System.Drawing.Size(584, 511);
            this.Controls.Add(this.btnShowAdd);
            this.Controls.Add(this.btnShowUpdate);
            this.Controls.Add(this.updatePanel);
            this.Controls.Add(this.addPanel);
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

        private System.Windows.Forms.Button btnShowAdd;
        private System.Windows.Forms.Button btnShowUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnUClear;
    }
}