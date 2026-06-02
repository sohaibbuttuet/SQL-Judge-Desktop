namespace SQL_Judge_System.UI
{
    partial class CreateProblemUI
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.clbTags = new System.Windows.Forms.CheckedListBox();
            this.lblProblemName = new System.Windows.Forms.Label();
            this.txtProblemName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.pnlMetaRow = new System.Windows.Forms.Panel();
            this.pnlDBbox = new System.Windows.Forms.Panel();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.cmbDatabase = new System.Windows.Forms.ComboBox();
            this.pnlDiffBox = new System.Windows.Forms.Panel();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.cmbDifficulty = new System.Windows.Forms.ComboBox();
            this.pnlPointsBox = new System.Windows.Forms.Panel();
            this.lblPoints = new System.Windows.Forms.Label();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.lblTags = new System.Windows.Forms.Label();
            this.lblMasterQuery = new System.Windows.Forms.Label();
            this.pnlQueryContainer = new System.Windows.Forms.Panel();
            this.txtMasterQuery = new System.Windows.Forms.RichTextBox();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblSchema = new System.Windows.Forms.Label();
            this.lblSchemaHint = new System.Windows.Forms.Label();
            this.pnlTreeContainer = new System.Windows.Forms.Panel();
            this.tvSchema = new System.Windows.Forms.TreeView();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblFormSubtitle = new System.Windows.Forms.Label();
            this.lblHeaderDivider = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblStatusBar = new System.Windows.Forms.Label();
            this.pnlBtnSave = new System.Windows.Forms.Panel();
            this.btnSaveProblem = new System.Windows.Forms.Button();
            this.pnlBtnVerify = new System.Windows.Forms.Panel();
            this.btnVerifyMasterQuery = new System.Windows.Forms.Button();
            this.pnlAccentBar = new System.Windows.Forms.Panel();
            this.pnlMain.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlMetaRow.SuspendLayout();
            this.pnlDBbox.SuspendLayout();
            this.pnlDiffBox.SuspendLayout();
            this.pnlPointsBox.SuspendLayout();
            this.pnlQueryContainer.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlTreeContainer.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlBtnSave.SuspendLayout();
            this.pnlBtnVerify.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(56)))));
            this.pnlMain.Controls.Add(this.pnlLeft);
            this.pnlMain.Controls.Add(this.pnlRight);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 75);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(20, 16, 20, 8);
            this.pnlMain.Size = new System.Drawing.Size(1264, 612);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlLeft
            // 
            this.pnlLeft.AutoScroll = true;
            this.pnlLeft.BackColor = System.Drawing.Color.Transparent;
            this.pnlLeft.Controls.Add(this.clbTags);
            this.pnlLeft.Controls.Add(this.lblProblemName);
            this.pnlLeft.Controls.Add(this.txtProblemName);
            this.pnlLeft.Controls.Add(this.lblDescription);
            this.pnlLeft.Controls.Add(this.txtDescription);
            this.pnlLeft.Controls.Add(this.pnlMetaRow);
            this.pnlLeft.Controls.Add(this.lblTags);
            this.pnlLeft.Controls.Add(this.lblMasterQuery);
            this.pnlLeft.Controls.Add(this.pnlQueryContainer);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Location = new System.Drawing.Point(20, 16);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.pnlLeft.Size = new System.Drawing.Size(904, 588);
            this.pnlLeft.TabIndex = 0;
            // 
            // clbTags
            // 
            this.clbTags.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.clbTags.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbTags.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.clbTags.FormattingEnabled = true;
            this.clbTags.Location = new System.Drawing.Point(0, 344);
            this.clbTags.Name = "clbTags";
            this.clbTags.Size = new System.Drawing.Size(820, 160);
            this.clbTags.TabIndex = 12;
            // 
            // lblProblemName
            // 
            this.lblProblemName.AutoSize = true;
            this.lblProblemName.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblProblemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.lblProblemName.Location = new System.Drawing.Point(0, 0);
            this.lblProblemName.Name = "lblProblemName";
            this.lblProblemName.Size = new System.Drawing.Size(123, 15);
            this.lblProblemName.TabIndex = 0;
            this.lblProblemName.Text = "▸  CHALLENGE TITLE";
            // 
            // txtProblemName
            // 
            this.txtProblemName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.txtProblemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProblemName.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtProblemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.txtProblemName.Location = new System.Drawing.Point(0, 20);
            this.txtProblemName.Name = "txtProblemName";
            this.txtProblemName.Size = new System.Drawing.Size(820, 31);
            this.txtProblemName.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.lblDescription.Location = new System.Drawing.Point(0, 64);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(201, 15);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "▸  PROBLEM DESCRIPTION & RULES";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.txtDescription.Location = new System.Drawing.Point(0, 85);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(820, 130);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.Text = "";
            // 
            // pnlMetaRow
            // 
            this.pnlMetaRow.BackColor = System.Drawing.Color.Transparent;
            this.pnlMetaRow.Controls.Add(this.pnlDBbox);
            this.pnlMetaRow.Controls.Add(this.pnlDiffBox);
            this.pnlMetaRow.Controls.Add(this.pnlPointsBox);
            this.pnlMetaRow.Location = new System.Drawing.Point(0, 234);
            this.pnlMetaRow.Name = "pnlMetaRow";
            this.pnlMetaRow.Size = new System.Drawing.Size(820, 76);
            this.pnlMetaRow.TabIndex = 4;
            // 
            // pnlDBbox
            // 
            this.pnlDBbox.Controls.Add(this.lblDatabase);
            this.pnlDBbox.Controls.Add(this.cmbDatabase);
            this.pnlDBbox.Location = new System.Drawing.Point(529, 0);
            this.pnlDBbox.Name = "pnlDBbox";
            this.pnlDBbox.Size = new System.Drawing.Size(255, 76);
            this.pnlDBbox.TabIndex = 13;
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblDatabase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.lblDatabase.Location = new System.Drawing.Point(3, 0);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(130, 15);
            this.lblDatabase.TabIndex = 10;
            this.lblDatabase.Text = "▸  TARGET DATABASE";
            // 
            // cmbDatabase
            // 
            this.cmbDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.cmbDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDatabase.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDatabase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.cmbDatabase.Items.AddRange(new object[] {
            "northwind_judge",
            "dublinbikes_judge"});
            this.cmbDatabase.Location = new System.Drawing.Point(3, 22);
            this.cmbDatabase.Name = "cmbDatabase";
            this.cmbDatabase.Size = new System.Drawing.Size(228, 25);
            this.cmbDatabase.TabIndex = 11;
            this.cmbDatabase.SelectedIndexChanged += new System.EventHandler(this.cmbDatabase_SelectedIndexChanged);
            // 
            // pnlDiffBox
            // 
            this.pnlDiffBox.BackColor = System.Drawing.Color.Transparent;
            this.pnlDiffBox.Controls.Add(this.lblDifficulty);
            this.pnlDiffBox.Controls.Add(this.cmbDifficulty);
            this.pnlDiffBox.Location = new System.Drawing.Point(0, 0);
            this.pnlDiffBox.Name = "pnlDiffBox";
            this.pnlDiffBox.Size = new System.Drawing.Size(220, 76);
            this.pnlDiffBox.TabIndex = 0;
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblDifficulty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.lblDifficulty.Location = new System.Drawing.Point(0, 0);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(88, 15);
            this.lblDifficulty.TabIndex = 0;
            this.lblDifficulty.Text = "▸  DIFFICULTY";
            // 
            // cmbDifficulty
            // 
            this.cmbDifficulty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.cmbDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDifficulty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDifficulty.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDifficulty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.cmbDifficulty.Location = new System.Drawing.Point(0, 22);
            this.cmbDifficulty.Name = "cmbDifficulty";
            this.cmbDifficulty.Size = new System.Drawing.Size(210, 25);
            this.cmbDifficulty.TabIndex = 1;
            // 
            // pnlPointsBox
            // 
            this.pnlPointsBox.BackColor = System.Drawing.Color.Transparent;
            this.pnlPointsBox.Controls.Add(this.lblPoints);
            this.pnlPointsBox.Controls.Add(this.txtPoints);
            this.pnlPointsBox.Location = new System.Drawing.Point(264, 0);
            this.pnlPointsBox.Name = "pnlPointsBox";
            this.pnlPointsBox.Size = new System.Drawing.Size(220, 76);
            this.pnlPointsBox.TabIndex = 1;
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblPoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.lblPoints.Location = new System.Drawing.Point(0, 0);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(106, 15);
            this.lblPoints.TabIndex = 0;
            this.lblPoints.Text = "▸  POINTS VALUE";
            // 
            // txtPoints
            // 
            this.txtPoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.txtPoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPoints.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.txtPoints.Location = new System.Drawing.Point(0, 22);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.Size = new System.Drawing.Size(210, 25);
            this.txtPoints.TabIndex = 1;
            this.txtPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTags
            // 
            this.lblTags.AutoSize = true;
            this.lblTags.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblTags.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.lblTags.Location = new System.Drawing.Point(0, 322);
            this.lblTags.Name = "lblTags";
            this.lblTags.Size = new System.Drawing.Size(112, 15);
            this.lblTags.TabIndex = 5;
            this.lblTags.Text = "▸  PROBLEM TAGS";
            // 
            // lblMasterQuery
            // 
            this.lblMasterQuery.AutoSize = true;
            this.lblMasterQuery.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblMasterQuery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.lblMasterQuery.Location = new System.Drawing.Point(0, 516);
            this.lblMasterQuery.Name = "lblMasterQuery";
            this.lblMasterQuery.Size = new System.Drawing.Size(176, 15);
            this.lblMasterQuery.TabIndex = 10;
            this.lblMasterQuery.Text = "▸  MASTER SOLUTION QUERY";
            // 
            // pnlQueryContainer
            // 
            this.pnlQueryContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.pnlQueryContainer.Controls.Add(this.txtMasterQuery);
            this.pnlQueryContainer.Location = new System.Drawing.Point(0, 537);
            this.pnlQueryContainer.Name = "pnlQueryContainer";
            this.pnlQueryContainer.Padding = new System.Windows.Forms.Padding(2);
            this.pnlQueryContainer.Size = new System.Drawing.Size(820, 135);
            this.pnlQueryContainer.TabIndex = 11;
            // 
            // txtMasterQuery
            // 
            this.txtMasterQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.txtMasterQuery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMasterQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMasterQuery.Font = new System.Drawing.Font("Consolas", 10F);
            this.txtMasterQuery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(213)))), ((int)(((byte)(247)))));
            this.txtMasterQuery.Location = new System.Drawing.Point(2, 2);
            this.txtMasterQuery.Name = "txtMasterQuery";
            this.txtMasterQuery.Size = new System.Drawing.Size(816, 131);
            this.txtMasterQuery.TabIndex = 0;
            this.txtMasterQuery.Text = "";
            this.txtMasterQuery.WordWrap = false;
            this.txtMasterQuery.TextChanged += new System.EventHandler(this.ResetQueryVerification);
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.Transparent;
            this.pnlRight.Controls.Add(this.lblSchema);
            this.pnlRight.Controls.Add(this.lblSchemaHint);
            this.pnlRight.Controls.Add(this.pnlTreeContainer);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(924, 16);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.pnlRight.Size = new System.Drawing.Size(320, 588);
            this.pnlRight.TabIndex = 1;
            // 
            // lblSchema
            // 
            this.lblSchema.AutoSize = true;
            this.lblSchema.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblSchema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.lblSchema.Location = new System.Drawing.Point(0, 0);
            this.lblSchema.Name = "lblSchema";
            this.lblSchema.Size = new System.Drawing.Size(134, 15);
            this.lblSchema.TabIndex = 0;
            this.lblSchema.Text = "▸  SCHEMA VISIBILITY";
            // 
            // lblSchemaHint
            // 
            this.lblSchemaHint.AutoSize = true;
            this.lblSchemaHint.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Italic);
            this.lblSchemaHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(90)))), ((int)(((byte)(111)))));
            this.lblSchemaHint.Location = new System.Drawing.Point(12, 19);
            this.lblSchemaHint.Name = "lblSchemaHint";
            this.lblSchemaHint.Size = new System.Drawing.Size(139, 12);
            this.lblSchemaHint.TabIndex = 1;
            this.lblSchemaHint.Text = "Check items visible to students";
            // 
            // pnlTreeContainer
            // 
            this.pnlTreeContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.pnlTreeContainer.Controls.Add(this.tvSchema);
            this.pnlTreeContainer.Location = new System.Drawing.Point(14, 38);
            this.pnlTreeContainer.Name = "pnlTreeContainer";
            this.pnlTreeContainer.Size = new System.Drawing.Size(293, 382);
            this.pnlTreeContainer.TabIndex = 2;
            // 
            // tvSchema
            // 
            this.tvSchema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.tvSchema.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvSchema.CheckBoxes = true;
            this.tvSchema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvSchema.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tvSchema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.tvSchema.HotTracking = true;
            this.tvSchema.Indent = 20;
            this.tvSchema.ItemHeight = 24;
            this.tvSchema.Location = new System.Drawing.Point(0, 0);
            this.tvSchema.Name = "tvSchema";
            this.tvSchema.Size = new System.Drawing.Size(293, 382);
            this.tvSchema.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.pnlHeader.Controls.Add(this.lblFormTitle);
            this.pnlHeader.Controls.Add(this.lblFormSubtitle);
            this.pnlHeader.Controls.Add(this.lblHeaderDivider);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 3);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(28, 0, 28, 0);
            this.pnlHeader.Size = new System.Drawing.Size(1264, 72);
            this.pnlHeader.TabIndex = 2;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.lblFormTitle.Location = new System.Drawing.Point(28, 14);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(270, 32);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "SQL Problem Designer";
            // 
            // lblFormSubtitle
            // 
            this.lblFormSubtitle.AutoSize = true;
            this.lblFormSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFormSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(142)))), ((int)(((byte)(163)))));
            this.lblFormSubtitle.Location = new System.Drawing.Point(30, 44);
            this.lblFormSubtitle.Name = "lblFormSubtitle";
            this.lblFormSubtitle.Size = new System.Drawing.Size(267, 15);
            this.lblFormSubtitle.TabIndex = 1;
            this.lblFormSubtitle.Text = "Create and configure SQL challenges for students";
            // 
            // lblHeaderDivider
            // 
            this.lblHeaderDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.lblHeaderDivider.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblHeaderDivider.Location = new System.Drawing.Point(28, 71);
            this.lblHeaderDivider.Name = "lblHeaderDivider";
            this.lblHeaderDivider.Size = new System.Drawing.Size(1208, 1);
            this.lblHeaderDivider.TabIndex = 2;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(63)))));
            this.pnlFooter.Controls.Add(this.lblStatusBar);
            this.pnlFooter.Controls.Add(this.pnlBtnSave);
            this.pnlFooter.Controls.Add(this.pnlBtnVerify);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 687);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.pnlFooter.Size = new System.Drawing.Size(1264, 62);
            this.pnlFooter.TabIndex = 1;
            // 
            // lblStatusBar
            // 
            this.lblStatusBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblStatusBar.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblStatusBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(90)))), ((int)(((byte)(111)))));
            this.lblStatusBar.Location = new System.Drawing.Point(20, 10);
            this.lblStatusBar.Name = "lblStatusBar";
            this.lblStatusBar.Size = new System.Drawing.Size(400, 42);
            this.lblStatusBar.TabIndex = 0;
            this.lblStatusBar.Text = "Ready";
            this.lblStatusBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlBtnSave
            // 
            this.pnlBtnSave.BackColor = System.Drawing.Color.Transparent;
            this.pnlBtnSave.Controls.Add(this.btnSaveProblem);
            this.pnlBtnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBtnSave.Location = new System.Drawing.Point(824, 10);
            this.pnlBtnSave.Name = "pnlBtnSave";
            this.pnlBtnSave.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.pnlBtnSave.Size = new System.Drawing.Size(200, 42);
            this.pnlBtnSave.TabIndex = 1;
            // 
            // btnSaveProblem
            // 
            this.btnSaveProblem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(197)))), ((int)(((byte)(134)))));
            this.btnSaveProblem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveProblem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveProblem.FlatAppearance.BorderSize = 0;
            this.btnSaveProblem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnSaveProblem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.btnSaveProblem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveProblem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSaveProblem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.btnSaveProblem.Location = new System.Drawing.Point(0, 0);
            this.btnSaveProblem.Name = "btnSaveProblem";
            this.btnSaveProblem.Size = new System.Drawing.Size(188, 42);
            this.btnSaveProblem.TabIndex = 0;
            this.btnSaveProblem.Text = "✔   SAVE PROBLEM";
            this.btnSaveProblem.UseVisualStyleBackColor = false;
            this.btnSaveProblem.Click += new System.EventHandler(this.btnSaveProblem_Click);
            // 
            // pnlBtnVerify
            // 
            this.pnlBtnVerify.BackColor = System.Drawing.Color.Transparent;
            this.pnlBtnVerify.Controls.Add(this.btnVerifyMasterQuery);
            this.pnlBtnVerify.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBtnVerify.Location = new System.Drawing.Point(1024, 10);
            this.pnlBtnVerify.Name = "pnlBtnVerify";
            this.pnlBtnVerify.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.pnlBtnVerify.Size = new System.Drawing.Size(220, 42);
            this.pnlBtnVerify.TabIndex = 2;
            // 
            // btnVerifyMasterQuery
            // 
            this.btnVerifyMasterQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(56)))));
            this.btnVerifyMasterQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerifyMasterQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVerifyMasterQuery.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(139)))), ((int)(((byte)(253)))));
            this.btnVerifyMasterQuery.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(97)))), ((int)(((byte)(193)))));
            this.btnVerifyMasterQuery.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(97)))), ((int)(((byte)(193)))));
            this.btnVerifyMasterQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerifyMasterQuery.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnVerifyMasterQuery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(139)))), ((int)(((byte)(253)))));
            this.btnVerifyMasterQuery.Location = new System.Drawing.Point(0, 0);
            this.btnVerifyMasterQuery.Name = "btnVerifyMasterQuery";
            this.btnVerifyMasterQuery.Size = new System.Drawing.Size(208, 42);
            this.btnVerifyMasterQuery.TabIndex = 0;
            this.btnVerifyMasterQuery.Text = "⟳   VERIFY QUERY";
            this.btnVerifyMasterQuery.UseVisualStyleBackColor = false;
            this.btnVerifyMasterQuery.Click += new System.EventHandler(this.btnVerifyMasterQuery_Click);
            // 
            // pnlAccentBar
            // 
            this.pnlAccentBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(139)))), ((int)(((byte)(253)))));
            this.pnlAccentBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAccentBar.Location = new System.Drawing.Point(0, 0);
            this.pnlAccentBar.Name = "pnlAccentBar";
            this.pnlAccentBar.Size = new System.Drawing.Size(1264, 3);
            this.pnlAccentBar.TabIndex = 3;
            // 
            // CreateProblemUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1264, 749);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlAccentBar);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "CreateProblemUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Problem Designer — SQL Challenge Builder";
            this.pnlMain.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlMetaRow.ResumeLayout(false);
            this.pnlDBbox.ResumeLayout(false);
            this.pnlDBbox.PerformLayout();
            this.pnlDiffBox.ResumeLayout(false);
            this.pnlDiffBox.PerformLayout();
            this.pnlPointsBox.ResumeLayout(false);
            this.pnlPointsBox.PerformLayout();
            this.pnlQueryContainer.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.pnlTreeContainer.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlBtnSave.ResumeLayout(false);
            this.pnlBtnVerify.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        // ── Field declarations ─────────────────────────────────────────────
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel pnlAccentBar;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblFormSubtitle;
        private System.Windows.Forms.Label lblHeaderDivider;
        private System.Windows.Forms.Label lblProblemName;
        private System.Windows.Forms.TextBox txtProblemName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Panel pnlMetaRow;
        private System.Windows.Forms.Panel pnlDiffBox;
        private System.Windows.Forms.Panel pnlPointsBox;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.ComboBox cmbDifficulty;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.TextBox txtPoints;
        private System.Windows.Forms.Label lblTags;
        private System.Windows.Forms.Label lblMasterQuery;
        private System.Windows.Forms.Panel pnlQueryContainer;
        private System.Windows.Forms.RichTextBox txtMasterQuery;
        private System.Windows.Forms.Label lblSchema;
        private System.Windows.Forms.Label lblSchemaHint;
        private System.Windows.Forms.Panel pnlTreeContainer;
        private System.Windows.Forms.TreeView tvSchema;
        private System.Windows.Forms.Panel pnlBtnVerify;
        private System.Windows.Forms.Button btnVerifyMasterQuery;
        private System.Windows.Forms.Panel pnlBtnSave;
        private System.Windows.Forms.Button btnSaveProblem;
        private System.Windows.Forms.Label lblStatusBar;
        private System.Windows.Forms.CheckedListBox clbTags;
        private System.Windows.Forms.Panel pnlDBbox;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.ComboBox cmbDatabase;
    }
}