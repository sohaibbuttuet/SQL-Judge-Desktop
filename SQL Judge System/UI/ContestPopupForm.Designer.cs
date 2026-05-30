namespace SQL_Judge_System.UI
{
    partial class ContestPopupForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel addPanel;

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

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.addPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.clbAProblem = new System.Windows.Forms.CheckedListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddClear = new System.Windows.Forms.Button();
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
            this.label4 = new System.Windows.Forms.Label();
            this.clbUProblem = new System.Windows.Forms.CheckedListBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnUClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_UStartDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_UEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblUpdateTitle = new System.Windows.Forms.Label();
            this.lblUTitle = new System.Windows.Forms.Label();
            this.txtUTitle = new System.Windows.Forms.TextBox();
            this.lblUDescription = new System.Windows.Forms.Label();
            this.txtUDescription = new System.Windows.Forms.TextBox();
            this.addPanel.SuspendLayout();
            this.updatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addPanel
            // 
            this.addPanel.Controls.Add(this.label3);
            this.addPanel.Controls.Add(this.clbAProblem);
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
            this.addPanel.Location = new System.Drawing.Point(30, 40);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(520, 430);
            this.addPanel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.label3.Location = new System.Drawing.Point(17, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Problems";
            // 
            // clbAProblem
            // 
            this.clbAProblem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.clbAProblem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbAProblem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbAProblem.ForeColor = System.Drawing.Color.White;
            this.clbAProblem.Location = new System.Drawing.Point(20, 256);
            this.clbAProblem.Name = "clbAProblem";
            this.clbAProblem.Size = new System.Drawing.Size(462, 108);
            this.clbAProblem.TabIndex = 13;
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
            this.btnAdd.TabIndex = 11;
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
            this.btnAddClear.Location = new System.Drawing.Point(120, 387);
            this.btnAddClear.Name = "btnAddClear";
            this.btnAddClear.Size = new System.Drawing.Size(75, 23);
            this.btnAddClear.TabIndex = 12;
            this.btnAddClear.Text = "Clear";
            this.btnAddClear.UseVisualStyleBackColor = false;
            this.btnAddClear.Click += new System.EventHandler(this.btnAddClear_Click);
            // 
            // lblAddTitle
            // 
            this.lblAddTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAddTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblAddTitle.Location = new System.Drawing.Point(206, 14);
            this.lblAddTitle.Name = "lblAddTitle";
            this.lblAddTitle.Size = new System.Drawing.Size(109, 23);
            this.lblAddTitle.TabIndex = 0;
            this.lblAddTitle.Text = "Add Contest";
            // 
            // lblTitle
            // 
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 53);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(100, 16);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.Color.White;
            this.txtTitle.Location = new System.Drawing.Point(20, 73);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(462, 23);
            this.txtTitle.TabIndex = 2;
            // 
            // lblDescription
            // 
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblDescription.Location = new System.Drawing.Point(20, 103);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(100, 12);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.White;
            this.txtDescription.Location = new System.Drawing.Point(20, 123);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(462, 50);
            this.txtDescription.TabIndex = 4;
            // 
            // lblStartDate
            // 
            this.lblStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
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
            this.dtStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtStartDate.TabIndex = 6;
            // 
            // lblEndDate
            // 
            this.lblEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblEndDate.Location = new System.Drawing.Point(280, 183);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(100, 17);
            this.lblEndDate.TabIndex = 7;
            this.lblEndDate.Text = "End Date";
            // 
            // dtEndDate
            // 
            this.dtEndDate.Checked = false;
            this.dtEndDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtEndDate.Location = new System.Drawing.Point(280, 203);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(202, 20);
            this.dtEndDate.TabIndex = 8;
            // 
            // updatePanel
            // 
            this.updatePanel.Controls.Add(this.label4);
            this.updatePanel.Controls.Add(this.clbUProblem);
            this.updatePanel.Controls.Add(this.btnUpdate);
            this.updatePanel.Controls.Add(this.btnUClear);
            this.updatePanel.Controls.Add(this.label1);
            this.updatePanel.Controls.Add(this.dtp_UStartDate);
            this.updatePanel.Controls.Add(this.label2);
            this.updatePanel.Controls.Add(this.dtp_UEndDate);
            this.updatePanel.Controls.Add(this.lblUpdateTitle);
            this.updatePanel.Controls.Add(this.lblUTitle);
            this.updatePanel.Controls.Add(this.txtUTitle);
            this.updatePanel.Controls.Add(this.lblUDescription);
            this.updatePanel.Controls.Add(this.txtUDescription);
            this.updatePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.updatePanel.Location = new System.Drawing.Point(32, 40);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Size = new System.Drawing.Size(520, 430);
            this.updatePanel.TabIndex = 4;
            this.updatePanel.Visible = false;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.label4.Location = new System.Drawing.Point(18, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Problems";
            // 
            // clbUProblem
            // 
            this.clbUProblem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.clbUProblem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbUProblem.ForeColor = System.Drawing.Color.White;
            this.clbUProblem.Location = new System.Drawing.Point(21, 258);
            this.clbUProblem.Name = "clbUProblem";
            this.clbUProblem.Size = new System.Drawing.Size(462, 105);
            this.clbUProblem.TabIndex = 19;
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
            this.btnUpdate.Location = new System.Drawing.Point(20, 388);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 17;
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
            this.btnUClear.Location = new System.Drawing.Point(120, 388);
            this.btnUClear.Name = "btnUClear";
            this.btnUClear.Size = new System.Drawing.Size(75, 23);
            this.btnUClear.TabIndex = 18;
            this.btnUClear.Text = "Clear";
            this.btnUClear.UseVisualStyleBackColor = false;
            this.btnUClear.Click += new System.EventHandler(this.btnUClear_Click);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.label1.Location = new System.Drawing.Point(20, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Start Date";
            // 
            // dtp_UStartDate
            // 
            this.dtp_UStartDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.dtp_UStartDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtp_UStartDate.Location = new System.Drawing.Point(20, 206);
            this.dtp_UStartDate.Name = "dtp_UStartDate";
            this.dtp_UStartDate.Size = new System.Drawing.Size(198, 20);
            this.dtp_UStartDate.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.label2.Location = new System.Drawing.Point(279, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "End Date";
            // 
            // dtp_UEndDate
            // 
            this.dtp_UEndDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.dtp_UEndDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtp_UEndDate.Location = new System.Drawing.Point(281, 205);
            this.dtp_UEndDate.Name = "dtp_UEndDate";
            this.dtp_UEndDate.Size = new System.Drawing.Size(199, 20);
            this.dtp_UEndDate.TabIndex = 16;
            // 
            // lblUpdateTitle
            // 
            this.lblUpdateTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblUpdateTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblUpdateTitle.Location = new System.Drawing.Point(195, 14);
            this.lblUpdateTitle.Name = "lblUpdateTitle";
            this.lblUpdateTitle.Size = new System.Drawing.Size(131, 23);
            this.lblUpdateTitle.TabIndex = 0;
            this.lblUpdateTitle.Text = "Update Contest";
            // 
            // lblUTitle
            // 
            this.lblUTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblUTitle.Location = new System.Drawing.Point(20, 49);
            this.lblUTitle.Name = "lblUTitle";
            this.lblUTitle.Size = new System.Drawing.Size(100, 23);
            this.lblUTitle.TabIndex = 3;
            this.lblUTitle.Text = "New Title";
            // 
            // txtUTitle
            // 
            this.txtUTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.txtUTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUTitle.ForeColor = System.Drawing.Color.White;
            this.txtUTitle.Location = new System.Drawing.Point(20, 72);
            this.txtUTitle.Name = "txtUTitle";
            this.txtUTitle.Size = new System.Drawing.Size(460, 20);
            this.txtUTitle.TabIndex = 4;
            // 
            // lblUDescription
            // 
            this.lblUDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblUDescription.Location = new System.Drawing.Point(20, 102);
            this.lblUDescription.Name = "lblUDescription";
            this.lblUDescription.Size = new System.Drawing.Size(100, 23);
            this.lblUDescription.TabIndex = 5;
            this.lblUDescription.Text = "New Description";
            // 
            // txtUDescription
            // 
            this.txtUDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.txtUDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUDescription.ForeColor = System.Drawing.Color.White;
            this.txtUDescription.Location = new System.Drawing.Point(20, 125);
            this.txtUDescription.Multiline = true;
            this.txtUDescription.Name = "txtUDescription";
            this.txtUDescription.Size = new System.Drawing.Size(460, 50);
            this.txtUDescription.TabIndex = 6;
            // 
            // ContestPopupForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(584, 511);
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
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddClear;
        private System.Windows.Forms.Panel updatePanel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnUClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_UStartDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_UEndDate;
        private System.Windows.Forms.Label lblUpdateTitle;
        private System.Windows.Forms.Label lblUTitle;
        private System.Windows.Forms.TextBox txtUTitle;
        private System.Windows.Forms.Label lblUDescription;
        private System.Windows.Forms.TextBox txtUDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox clbAProblem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox clbUProblem;
    }
}