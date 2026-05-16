namespace SQL_Judge_System.UI
{
    partial class ContestPopupForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.Panel updatePanel;

        // ================= ADD CONTEST =================
        private System.Windows.Forms.Label lblAddTitle;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.DateTimePicker dtEndDate;

        // ================= UPDATE CONTEST =================
        private System.Windows.Forms.Label lblUpdateTitle;

        private System.Windows.Forms.Label lblContestId;
        private System.Windows.Forms.Label lblUTitle;
        private System.Windows.Forms.Label lblUDescription;

        private System.Windows.Forms.TextBox txtContestId;
        private System.Windows.Forms.TextBox txtUTitle;
        private System.Windows.Forms.TextBox txtUDescription;

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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.updatePanel = new System.Windows.Forms.Panel();
            this.lblUpdateTitle = new System.Windows.Forms.Label();
            this.lblContestId = new System.Windows.Forms.Label();
            this.txtContestId = new System.Windows.Forms.TextBox();
            this.lblUTitle = new System.Windows.Forms.Label();
            this.txtUTitle = new System.Windows.Forms.TextBox();
            this.lblUDescription = new System.Windows.Forms.Label();
            this.txtUDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnUClear = new System.Windows.Forms.Button();
            this.btnSwitchAdd = new System.Windows.Forms.Button();
            this.btnSwitchEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddClear = new System.Windows.Forms.Button();
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
            this.addPanel.Controls.Add(this.lblStartDate);
            this.addPanel.Controls.Add(this.dtStartDate);
            this.addPanel.Controls.Add(this.lblEndDate);
            this.addPanel.Controls.Add(this.dtEndDate);
            this.addPanel.Location = new System.Drawing.Point(30, 60);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(420, 330);
            this.addPanel.TabIndex = 2;
            // 
            // lblAddTitle
            // 
            this.lblAddTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAddTitle.Location = new System.Drawing.Point(156, 10);
            this.lblAddTitle.Name = "lblAddTitle";
            this.lblAddTitle.Size = new System.Drawing.Size(109, 23);
            this.lblAddTitle.TabIndex = 0;
            this.lblAddTitle.Text = "Add Contest";
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
            this.txtTitle.Size = new System.Drawing.Size(350, 20);
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
            this.txtDescription.Size = new System.Drawing.Size(350, 50);
            this.txtDescription.TabIndex = 4;
            // 
            // lblStartDate
            // 
            this.lblStartDate.Location = new System.Drawing.Point(20, 183);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(100, 20);
            this.lblStartDate.TabIndex = 5;
            this.lblStartDate.Text = "Start Date";
            // 
            // dtStartDate
            // 
            this.dtStartDate.Checked = false;
            this.dtStartDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtStartDate.Location = new System.Drawing.Point(20, 203);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(150, 20);
            this.dtStartDate.TabIndex = 6;
            // 
            // lblEndDate
            // 
            this.lblEndDate.Location = new System.Drawing.Point(200, 183);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(100, 17);
            this.lblEndDate.TabIndex = 7;
            this.lblEndDate.Text = "End Date";
            // 
            // dtEndDate
            // 
            this.dtEndDate.Checked = false;
            this.dtEndDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtEndDate.Location = new System.Drawing.Point(200, 203);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(170, 20);
            this.dtEndDate.TabIndex = 8;
            // 
            // updatePanel
            // 
            this.updatePanel.Controls.Add(this.btnUpdate);
            this.updatePanel.Controls.Add(this.btnUClear);
            this.updatePanel.Controls.Add(this.label1);
            this.updatePanel.Controls.Add(this.dateTimePicker1);
            this.updatePanel.Controls.Add(this.label2);
            this.updatePanel.Controls.Add(this.dateTimePicker2);
            this.updatePanel.Controls.Add(this.lblUpdateTitle);
            this.updatePanel.Controls.Add(this.lblContestId);
            this.updatePanel.Controls.Add(this.txtContestId);
            this.updatePanel.Controls.Add(this.lblUTitle);
            this.updatePanel.Controls.Add(this.txtUTitle);
            this.updatePanel.Controls.Add(this.lblUDescription);
            this.updatePanel.Controls.Add(this.txtUDescription);
            this.updatePanel.Location = new System.Drawing.Point(30, 60);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Size = new System.Drawing.Size(420, 330);
            this.updatePanel.TabIndex = 3;
            this.updatePanel.Visible = false;
            // 
            // lblUpdateTitle
            // 
            this.lblUpdateTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblUpdateTitle.Location = new System.Drawing.Point(145, 10);
            this.lblUpdateTitle.Name = "lblUpdateTitle";
            this.lblUpdateTitle.Size = new System.Drawing.Size(131, 23);
            this.lblUpdateTitle.TabIndex = 0;
            this.lblUpdateTitle.Text = "Update Contest";
            // 
            // lblContestId
            // 
            this.lblContestId.Location = new System.Drawing.Point(20, 45);
            this.lblContestId.Name = "lblContestId";
            this.lblContestId.Size = new System.Drawing.Size(100, 23);
            this.lblContestId.TabIndex = 1;
            this.lblContestId.Text = "Contest ID (Search)";
            // 
            // txtContestId
            // 
            this.txtContestId.Location = new System.Drawing.Point(20, 68);
            this.txtContestId.Name = "txtContestId";
            this.txtContestId.Size = new System.Drawing.Size(350, 20);
            this.txtContestId.TabIndex = 2;
            // 
            // lblUTitle
            // 
            this.lblUTitle.Location = new System.Drawing.Point(20, 95);
            this.lblUTitle.Name = "lblUTitle";
            this.lblUTitle.Size = new System.Drawing.Size(100, 23);
            this.lblUTitle.TabIndex = 3;
            this.lblUTitle.Text = "New Title";
            // 
            // txtUTitle
            // 
            this.txtUTitle.Location = new System.Drawing.Point(20, 118);
            this.txtUTitle.Name = "txtUTitle";
            this.txtUTitle.Size = new System.Drawing.Size(350, 20);
            this.txtUTitle.TabIndex = 4;
            // 
            // lblUDescription
            // 
            this.lblUDescription.Location = new System.Drawing.Point(20, 145);
            this.lblUDescription.Name = "lblUDescription";
            this.lblUDescription.Size = new System.Drawing.Size(100, 23);
            this.lblUDescription.TabIndex = 5;
            this.lblUDescription.Text = "New Description";
            // 
            // txtUDescription
            // 
            this.txtUDescription.Location = new System.Drawing.Point(20, 168);
            this.txtUDescription.Multiline = true;
            this.txtUDescription.Name = "txtUDescription";
            this.txtUDescription.Size = new System.Drawing.Size(350, 50);
            this.txtUDescription.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Start Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.Location = new System.Drawing.Point(20, 247);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(157, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(203, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "End Date";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker2.Location = new System.Drawing.Point(201, 246);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(169, 20);
            this.dateTimePicker2.TabIndex = 16;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(20, 288);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnUClear
            // 
            this.btnUClear.BackColor = System.Drawing.Color.IndianRed;
            this.btnUClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUClear.ForeColor = System.Drawing.Color.White;
            this.btnUClear.Location = new System.Drawing.Point(120, 288);
            this.btnUClear.Name = "btnUClear";
            this.btnUClear.Size = new System.Drawing.Size(75, 23);
            this.btnUClear.TabIndex = 18;
            this.btnUClear.Text = "Clear";
            this.btnUClear.UseVisualStyleBackColor = false;
            // 
            // btnSwitchAdd
            // 
            this.btnSwitchAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnSwitchAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSwitchAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitchAdd.ForeColor = System.Drawing.Color.White;
            this.btnSwitchAdd.Location = new System.Drawing.Point(30, 21);
            this.btnSwitchAdd.Name = "btnSwitchAdd";
            this.btnSwitchAdd.Size = new System.Drawing.Size(95, 23);
            this.btnSwitchAdd.TabIndex = 4;
            this.btnSwitchAdd.Text = "Add Contest";
            this.btnSwitchAdd.UseVisualStyleBackColor = false;
            this.btnSwitchAdd.Click += new System.EventHandler(this.btnSwitchAdd_Click);
            // 
            // btnSwitchEdit
            // 
            this.btnSwitchEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnSwitchEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSwitchEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitchEdit.ForeColor = System.Drawing.Color.White;
            this.btnSwitchEdit.Location = new System.Drawing.Point(150, 21);
            this.btnSwitchEdit.Name = "btnSwitchEdit";
            this.btnSwitchEdit.Size = new System.Drawing.Size(95, 23);
            this.btnSwitchEdit.TabIndex = 5;
            this.btnSwitchEdit.Text = "Update Contest";
            this.btnSwitchEdit.UseVisualStyleBackColor = false;
            this.btnSwitchEdit.Click += new System.EventHandler(this.btnSwitchEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(20, 260);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnAddClear
            // 
            this.btnAddClear.BackColor = System.Drawing.Color.IndianRed;
            this.btnAddClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClear.ForeColor = System.Drawing.Color.White;
            this.btnAddClear.Location = new System.Drawing.Point(120, 260);
            this.btnAddClear.Name = "btnAddClear";
            this.btnAddClear.Size = new System.Drawing.Size(75, 23);
            this.btnAddClear.TabIndex = 12;
            this.btnAddClear.Text = "Clear";
            this.btnAddClear.UseVisualStyleBackColor = false;
            // 
            // ContestPopupForm
            // 
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.btnSwitchAdd);
            this.Controls.Add(this.btnSwitchEdit);
            this.Controls.Add(this.updatePanel);
            this.Controls.Add(this.addPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ContestPopupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contest Management";
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            this.updatePanel.ResumeLayout(false);
            this.updatePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnUClear;
        private System.Windows.Forms.Button btnSwitchAdd;
        private System.Windows.Forms.Button btnSwitchEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddClear;
    }
}