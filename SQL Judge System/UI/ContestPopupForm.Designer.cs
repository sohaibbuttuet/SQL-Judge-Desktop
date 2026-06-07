namespace SQL_Judge_System.UI
{
    partial class ContestPopupForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlContest;

        // ================= ADD CONTEST =================
        private System.Windows.Forms.Label lblHeading;

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
            this.pnlContest = new System.Windows.Forms.Panel();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clbProblem = new System.Windows.Forms.CheckedListBox();
            this.btnSaveProblem = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.pnlContest.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContest
            // 
            this.pnlContest.Controls.Add(this.txtDuration);
            this.pnlContest.Controls.Add(this.label1);
            this.pnlContest.Controls.Add(this.label3);
            this.pnlContest.Controls.Add(this.clbProblem);
            this.pnlContest.Controls.Add(this.btnSaveProblem);
            this.pnlContest.Controls.Add(this.btnClear);
            this.pnlContest.Controls.Add(this.lblHeading);
            this.pnlContest.Controls.Add(this.lblTitle);
            this.pnlContest.Controls.Add(this.txtTitle);
            this.pnlContest.Controls.Add(this.lblDescription);
            this.pnlContest.Controls.Add(this.txtDescription);
            this.pnlContest.Controls.Add(this.lblStartDate);
            this.pnlContest.Controls.Add(this.dtStartDate);
            this.pnlContest.Controls.Add(this.lblEndDate);
            this.pnlContest.Controls.Add(this.dtEndDate);
            this.pnlContest.Location = new System.Drawing.Point(30, 40);
            this.pnlContest.Name = "pnlContest";
            this.pnlContest.Size = new System.Drawing.Size(520, 459);
            this.pnlContest.TabIndex = 2;
            // 
            // txtDuration
            // 
            this.txtDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.txtDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDuration.Location = new System.Drawing.Point(20, 247);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(462, 20);
            this.txtDuration.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.label1.Location = new System.Drawing.Point(20, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Duration";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.label3.Location = new System.Drawing.Point(17, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Problems";
            // 
            // clbProblem
            // 
            this.clbProblem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.clbProblem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbProblem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbProblem.ForeColor = System.Drawing.Color.White;
            this.clbProblem.Location = new System.Drawing.Point(20, 294);
            this.clbProblem.Name = "clbProblem";
            this.clbProblem.Size = new System.Drawing.Size(462, 108);
            this.clbProblem.TabIndex = 13;
            // 
            // btnSaveProblem
            // 
            this.btnSaveProblem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnSaveProblem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveProblem.FlatAppearance.BorderSize = 0;
            this.btnSaveProblem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btnSaveProblem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btnSaveProblem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveProblem.ForeColor = System.Drawing.Color.White;
            this.btnSaveProblem.Location = new System.Drawing.Point(20, 421);
            this.btnSaveProblem.Name = "btnSaveProblem";
            this.btnSaveProblem.Size = new System.Drawing.Size(75, 23);
            this.btnSaveProblem.TabIndex = 11;
            this.btnSaveProblem.Text = "Save";
            this.btnSaveProblem.UseVisualStyleBackColor = false;
            this.btnSaveProblem.Click += new System.EventHandler(this.btnSaveProblem_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(69)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(120, 421);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(146)))), ((int)(((byte)(184)))));
            this.lblHeading.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblHeading.Location = new System.Drawing.Point(0, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(520, 37);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Contest Management";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
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
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
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
            // ContestPopupForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(584, 511);
            this.Controls.Add(this.pnlContest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ContestPopupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contest Management";
            this.pnlContest.ResumeLayout(false);
            this.pnlContest.PerformLayout();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Button btnSaveProblem;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox clbProblem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDuration;
    }
}