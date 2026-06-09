using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQL_Judge_System.BL;
using SQL_Judge_System.Models;

// iTextSharp Namespaces
using iTextSharp.text;
using iTextSharp.text.pdf;
using SQL_Judge_System.DL;

namespace SQL_Judge_System.UI
{
    public partial class ReportForm : Form
    {
        private DataTable _currentDataTable;
        private readonly int userID;
        private string _activeReportTitle = "System Operational Report";
        private bool isStudent = false;

        public ReportForm(int userID)
        {
            InitializeComponent();
            this.userID = userID;

            if (UserBL.IsUserStudent(userID))
            {
                isStudent = true;
                pnlAdminReports.Visible = false;
                pnlStudnet.Visible = true;
                pnlStudnet.Dock = DockStyle.Top;
            }
            else
            {
                pnlStudnet.Visible = false;
                pnlAdminReports.Visible = true;
                pnlAdminReports.Dock = DockStyle.Top;
            }
        }

        private void LoadSubmissionsGrid(DataTable dt)
        {
            try
            {
                _currentDataTable = dt;
                dgvReport.DataSource = dt;
                dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                if (dgvReport.Columns.Contains("SubmissionID")) dgvReport.Columns["SubmissionID"].Visible = false;
                if (dgvReport.Columns.Contains("StudentID")) dgvReport.Columns["StudentID"].Visible = false;
                if (dgvReport.Columns.Contains("ProblemID")) dgvReport.Columns["ProblemID"].Visible = false;

                SafeColumn(dgvReport, "StudentName", "Student Name", 50);
                SafeColumn(dgvReport, "ProblemTitle", "Problem Title", 80);
                SafeColumn(dgvReport, "TotalScore", "Total Score", 50);
                SafeColumn(dgvReport, "AttemptNumber", "Attempt #", 30);
                SafeColumn(dgvReport, "SubmittedAt", "Submitted At", 50);
                SafeColumn(dgvReport, "Status", "Status", 50);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load submission data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadContestGrid(DataTable dt)
        {
            try
            {
                _currentDataTable = dt;
                dgvReport.DataSource = dt;
                dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                if (dgvReport.Columns.Contains("ContestID")) dgvReport.Columns["ContestID"].Visible = false;

                SafeColumn(dgvReport, "Title", "Title", 80);
                SafeColumn(dgvReport, "StartDate", "Start Date", 40);
                SafeColumn(dgvReport, "EndDate", "End Date", 40);
                SafeColumn(dgvReport, "TotalParticipants", "Participants", 50);
                SafeColumn(dgvReport, "CreatedBy", "Created By", 50);
                SafeColumn(dgvReport, "UpdatedBy", "Updated By", 50);
                SafeColumn(dgvReport, "CreatedAt", "Created At", 50);
                SafeColumn(dgvReport, "UpdatedAt", "Updated At", 50);
                SafeColumn(dgvReport, "ContestStatus", "Status", 40);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load contest data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadStudentGrid(DataTable dt)
        {
            try
            {
                _currentDataTable = dt;
                dgvReport.DataSource = dt;

                if (dt == null || dt.Columns.Count == 0) return;

                dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                if (dgvReport.Columns.Contains("StudentID")) dgvReport.Columns["StudentID"].Visible = false;
                if (dgvReport.Columns.Contains("UserID")) dgvReport.Columns["UserID"].Visible = false;
                if (dgvReport.Columns.Contains("IsActive")) dgvReport.Columns["IsActive"].Visible = false;
                if (dgvReport.Columns.Contains("CreatedAt")) dgvReport.Columns["CreatedAt"].Visible = false;

                SafeColumn(dgvReport, "GlobalRank", "Global Rank", 50);
                SafeColumn(dgvReport, "FullName", "Student Name", 150);
                SafeColumn(dgvReport, "RegistrationNumber", "Reg No", 80);
                SafeColumn(dgvReport, "LevelName", "Skill Level", 80);
                SafeColumn(dgvReport, "ProblemsSolved", "Solved", 80);
                SafeColumn(dgvReport, "TotalScore", "Score", 80);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying student view: " + ex.Message);
            }
        }
        private void SafeColumn(DataGridView dgv, string col, string header, int weight)
        {
            if (dgv.Columns.Contains(col))
            {
                dgv.Columns[col].HeaderText = header;
                dgv.Columns[col].FillWeight = weight;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            btnExportPDF_Click(sender, e);
        }

        // --- MODERNIZED PDF EXPORT ENGINE ---
        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            if (dgvReport.Rows.Count == 0)
            {
                MessageBox.Show("There is no data available in the grid to export.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF Files (*.pdf)|*.pdf";
                sfd.FileName = "SQL_Judge_Report_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".pdf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // 1. Setup global typography styles
                        iTextSharp.text.Font titleFont = FontFactory.GetFont("Arial", 18, iTextSharp.text.Font.BOLD, new BaseColor(24, 43, 73));
                        iTextSharp.text.Font metaFont = FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.ITALIC, BaseColor.GRAY);
                        iTextSharp.text.Font cardLabelFont = FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.BOLD, new BaseColor(100, 110, 120));
                        iTextSharp.text.Font cardValueFont = FontFactory.GetFont("Arial", 14, iTextSharp.text.Font.BOLD, new BaseColor(24, 43, 73));
                        iTextSharp.text.Font thFont = FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.BOLD, BaseColor.WHITE);
                        iTextSharp.text.Font tdFont = FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                        Document pdfDoc = new Document(PageSize.A4, 25f, 25f, 30f, 30f);

                        using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                        {
                            PdfWriter.GetInstance(pdfDoc, stream);
                            pdfDoc.Open();

                            // 2. Add Top Decorative Branding Header Accent Bar
                            PdfPTable topBar = new PdfPTable(1);
                            topBar.WidthPercentage = 100;
                            PdfPCell barCell = new PdfPCell();
                            barCell.BackgroundColor = new BaseColor(24, 43, 73); // Deep Slate Navy Accent
                            barCell.FixedHeight = 4f;
                            barCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                            topBar.AddCell(barCell);
                            pdfDoc.Add(topBar);
                            pdfDoc.Add(new Paragraph("\n"));

                            // 3. Document Title Block
                            Paragraph titleBlock = new Paragraph(_activeReportTitle, titleFont);
                            titleBlock.Alignment = Element.ALIGN_LEFT;
                            pdfDoc.Add(titleBlock);

                            // 4. Meta Information Strings (Context and Date boundaries)
                            string dateFilterContext = $"Filter Timeline Frame: {dtpFrom.Value:yyyy-MM-dd} to {dtpTo.Value:yyyy-MM-dd}";
                            Paragraph metaInfo = new Paragraph($"Generated on: {DateTime.Now:F} | {dateFilterContext}", metaFont);
                            metaInfo.SpacingAfter = 15f;
                            pdfDoc.Add(metaInfo);

                            // 5. RENDER UPPER PANEL METRIC CARDS (Dynamic 4-Column Grid Layout)
                            PdfPTable cardsGrid = new PdfPTable(4);
                            cardsGrid.WidthPercentage = 100;
                            cardsGrid.SetWidths(new float[] { 25f, 25f, 25f, 25f });

                            string[] labels = { lblStat1Label.Text, lblStat2Label.Text, lblStat3Label.Text, lblStat4Label.Text };
                            string[] values = { lblStat1Value.Text, lblStat2Value.Text, lblStat3Value.Text, lblStat4Value.Text };

                            for (int i = 0; i < 4; i++)
                            {
                                PdfPTable innerCard = new PdfPTable(1);
                                innerCard.WidthPercentage = 100;

                                PdfPCell lblCell = new PdfPCell(new Phrase(labels[i].ToUpper(), cardLabelFont));
                                lblCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                                lblCell.PaddingTop = 8f;
                                lblCell.PaddingLeft = 8f;
                                lblCell.HorizontalAlignment = Element.ALIGN_LEFT;

                                PdfPCell valCell = new PdfPCell(new Phrase(values[i], cardValueFont));
                                valCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                                valCell.PaddingBottom = 8f;
                                valCell.PaddingLeft = 8f;
                                valCell.PaddingTop = 4f;
                                valCell.HorizontalAlignment = Element.ALIGN_LEFT;

                                innerCard.AddCell(lblCell);
                                innerCard.AddCell(valCell);

                                PdfPCell outerCardCell = new PdfPCell(innerCard);
                                outerCardCell.BackgroundColor = new BaseColor(245, 247, 250); // Balanced Light Grey Accent Fills
                                outerCardCell.BorderColor = new BaseColor(220, 224, 230);
                                outerCardCell.BorderWidth = 1f;
                                outerCardCell.Padding = 2f;

                                // Give individual cards spacing padding separation
                                if (i < 3) outerCardCell.PaddingRight = 5f;

                                cardsGrid.AddCell(outerCardCell);
                            }
                            pdfDoc.Add(cardsGrid);
                            pdfDoc.Add(new Paragraph("\n")); // Space spacer block between analytics and records grid

                            // 6. Gather and Parse Column Layout Configurations
                            int visibleColumnCount = 0;
                            List<int> colIndexes = new List<int>();
                            foreach (DataGridViewColumn col in dgvReport.Columns)
                            {
                                if (col.Visible)
                                {
                                    visibleColumnCount++;
                                    colIndexes.Add(col.Index);
                                }
                            }

                            PdfPTable pdfTable = new PdfPTable(visibleColumnCount);
                            pdfTable.WidthPercentage = 100;

                            // 7. Render Styled Formatted Header Data Columns
                            foreach (int idx in colIndexes)
                            {
                                DataGridViewColumn column = dgvReport.Columns[idx];
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, thFont));
                                cell.BackgroundColor = new BaseColor(43, 58, 82); // Muted Dark Table Accent Header
                                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                                cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                                cell.Padding = 7f;
                                cell.BorderColor = new BaseColor(60, 75, 100);
                                pdfTable.AddCell(cell);
                            }

                            // 8. Render Rows with clean Zebra Stripes
                            int rowIndex = 0;
                            foreach (DataGridViewRow row in dgvReport.Rows)
                            {
                                if (row.IsNewRow) continue;

                                BaseColor rowBgColor = (rowIndex % 2 == 0) ? BaseColor.WHITE : new BaseColor(250, 251, 253);

                                foreach (int idx in colIndexes)
                                {
                                    DataGridViewCell cell = row.Cells[idx];
                                    string cellText = cell.Value?.ToString() ?? "";

                                    PdfPCell pdfCell = new PdfPCell(new Phrase(cellText, tdFont));
                                    pdfCell.BackgroundColor = rowBgColor;
                                    pdfCell.Padding = 6f;
                                    pdfCell.BorderColor = new BaseColor(230, 233, 240);
                                    pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;

                                    // Contextual structural alignments based on typical numeric metrics columns
                                    if (cell.OwningColumn.Name.Contains("Score") || cell.OwningColumn.Name.Contains("Solved") || cell.OwningColumn.Name.Contains("Count") || cell.OwningColumn.Name.Contains("Limit"))
                                    {
                                        pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
                                    }
                                    else
                                    {
                                        pdfCell.HorizontalAlignment = Element.ALIGN_LEFT;
                                    }

                                    pdfTable.AddCell(pdfCell);
                                }
                                rowIndex++;
                            }

                            pdfDoc.Add(pdfTable);
                            pdfDoc.Close();
                        }

                        MessageBox.Show("Report exported successfully with matching dashboard cards context to PDF!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred during styled PDF output rendering compilation: " + ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // --- REPORT REGIONS ---
        private void LoadContestRanking()
        {
            if (cmbRows.SelectedItem == null)
            {
                MessageBox.Show("Please select a valid row truncation limit before compiling.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _activeReportTitle = "Examination Contests Engagement Performance Metrics";
                DateTime startDate = dtpFrom.Value.Date;
                DateTime endDate = dtpTo.Value.Date.AddDays(1).AddTicks(-1);
                int limit = Convert.ToInt32(cmbRows.SelectedItem.ToString());

                lblStat1Label.Text = "Total Contests";
                lblStat2Label.Text = "Highest Score";
                lblStat3Label.Text = "Average Score";
                lblStat4Label.Text = "Completion Rate";

                // Fetch un-truncated data table directly first to avoid indexing row errors
                DataTable dtContests = ContestBL.GetContestRanking(limit);
                int totalContests = (dtContests != null) ? dtContests.Rows.Count : 0;

                if (totalContests > 0)
                {
                    // Load grid dynamically via modern functional evaluation loop
                    ExecuteReportLoad(() => dtContests, LoadContestGrid);

                    // Guard metric scalar evaluations with structured fallbacks
                    int highest = SubmissionBL.GetHighestScore(startDate, endDate);
                    double average = SubmissionBL.GetAverageScore(startDate, endDate);
                    double completionRate = SubmissionBL.GetOverallCompletionRate(startDate, endDate);

                    lblStat1Value.Text = totalContests.ToString();
                    lblStat2Value.Text = highest.ToString();
                    lblStat3Value.Text = average.ToString("F2");
                    lblStat4Value.Text = $"{completionRate:F1}%";
                }
                else
                {
                    if (dtContests != null) LoadContestGrid(dtContests);

                    lblStat1Value.Text = "0";
                    lblStat2Value.Text = "0";
                    lblStat3Value.Text = "0.00";
                    lblStat4Value.Text = "0.0%";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load and calculate contest report statistics: " + ex.Message,
                                "Data Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadTopStudents()
        {
            if (cmbRows.SelectedItem == null)
            {
                MessageBox.Show("Please select a valid row truncation limit before compiling.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _activeReportTitle = "Top Performing Students Leaderboard Report";
                DateTime startDate = dtpFrom.Value.Date;
                DateTime endDate = dtpTo.Value.Date.AddDays(1).AddTicks(-1);
                int limit = Convert.ToInt32(cmbRows.SelectedItem.ToString());

                lblStat1Label.Text = "Total Students";
                lblStat2Label.Text = "Contest Registered Students";
                lblStat3Label.Text = "Avg Problems Solved";
                lblStat4Label.Text = "Reporting Period";

                ExecuteReportLoad(() => StudentBL.GetTopStudents(limit, startDate, endDate), LoadStudentGrid);

                int totalReg = StudentBL.GetTotalStudentsRegistered(startDate, endDate);
                int contestActive = SubmissionBL.GetContestRegisteredStudents(startDate, endDate);
                double avgSolved = StudentBL.GetAverageProblemsSolved(startDate, endDate);

                lblStat1Value.Text = totalReg.ToString();
                lblStat2Value.Text = contestActive.ToString();
                lblStat3Value.Text = avgSolved.ToString("F1");
                int totalDays = (dtpTo.Value.Date - startDate).Days + 1;

                lblStat4Label.Text = $"Days Monitored ({startDate:MMM dd} - {dtpTo.Value:MMM dd})";
                lblStat4Value.Text = $"{totalDays} Days";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load and calculate student analytical metrics: " + ex.Message,
                                "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Admin Reports
        private void btnTopStudentsReport_Click(object sender, EventArgs e)
        {
            LoadTopStudents();
        }
        private void btnSubmissionsReport_Click(object sender, EventArgs e)
        {
            if (cmbRows.SelectedItem == null)
            {
                MessageBox.Show("Please select a valid row truncation limit before compiling.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _activeReportTitle = "Platform Submissions Log & Execution Status Report";
                DateTime startDate = dtpFrom.Value.Date;
                DateTime endDate = dtpTo.Value.Date.AddDays(1).AddTicks(-1);
                int limit = Convert.ToInt32(cmbRows.SelectedItem.ToString());

                lblStat1Label.Text = "Total Submissions";
                lblStat2Label.Text = "Pending Submissions";
                lblStat3Label.Text = "Pass Rate %";
                lblStat4Label.Text = "Runtime Error Count";

                // 1. Fetch the raw data table from the Business Logic Layer first
                DataTable dtSubmissions = SubmissionBL.GetSubmissions(limit, startDate, endDate);

                // 2. Use the actual full row count from the database retrieval for calculations
                int totalSubmissions = (dtSubmissions != null) ? dtSubmissions.Rows.Count : 0;

                if (totalSubmissions > 0)
                {
                    // 3. Bind the fetched data using your existing display runner logic
                    ExecuteReportLoad(() => dtSubmissions, LoadSubmissionsGrid);

                    int correctCount = SubmissionBL.GetCorrectSubCount(startDate, endDate);
                    int pendingCount = SubmissionBL.GetPendingStatusCount(startDate, endDate);
                    int runtimeErrors = SubmissionBL.GetRunTimeErrorCount(startDate, endDate);

                    // 4. Calculate the mathematically correct pass rate (capped naturally at 100%)
                    double passRate = ((double)correctCount / totalSubmissions) * 100;

                    // 5. Update UI values cleanly
                    lblStat1Value.Text = totalSubmissions.ToString();
                    lblStat2Value.Text = pendingCount.ToString();
                    lblStat3Value.Text = $"{passRate:F1}%";
                    lblStat4Value.Text = runtimeErrors.ToString();
                }
                else
                {
                    // Clear the grid structural layout safely if no data matches the filters
                    if (dtSubmissions != null) LoadSubmissionsGrid(dtSubmissions);

                    lblStat1Value.Text = "0";
                    lblStat2Value.Text = "0";
                    lblStat3Value.Text = "0.0%";
                    lblStat4Value.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load and sync dashboard analytics: " + ex.Message,
                                "UI Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnContestLeaderboard_Click(object sender, EventArgs e)
        {
            LoadContestRanking();
        }

        // Student Reports
        private void btnMySubmissions_Click(object sender, EventArgs e)
        {
            // 1. Guard Clause: Ensure a row limit selection is made in the combo box
            if (cmbRows.SelectedItem == null)
            {
                MessageBox.Show("Please select a valid row truncation limit before loading your history.",
                                "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Setup structural UI text headings for the export engine context
                _activeReportTitle = "Personal Submission History & Performance Tracking Log";

                lblStat1Label.Text = "Total Submissions";
                lblStat2Label.Text = "Highest Score Achieved";
                lblStat3Label.Text = "Average Score";
                lblStat4Label.Text = "Success Rate";

                // 3. Gather form inputs and evaluate database operational variables
                DateTime startDate = dtpFrom.Value.Date;
                DateTime endDate = dtpTo.Value.Date.AddDays(1).AddTicks(-1); // Captures full end-day details
                int limit = Convert.ToInt32(cmbRows.SelectedItem.ToString());

                // 4. Resolve the StudentID from the logged-in UserID
                int studentID = StudentBL.GetStudentByUserID(userID).StudentID;

                // 5. Fetch and bind the detailed history grid rows
                DataTable dtMySubmissions = SubmissionBL.GetSubmissionsByStudent(studentID, limit, startDate, endDate);
                if (dtMySubmissions != null)
                {
                    ExecuteReportLoad(() => dtMySubmissions, LoadContestGrid);
                }

                // 6. Fetch optimized aggregate metrics directly from the database server
                DataTable dtMetrics = SubmissionBL.GetStudentSubmissionMetrics(studentID, startDate, endDate);

                if (dtMetrics != null && dtMetrics.Rows.Count > 0)
                {
                    DataRow row = dtMetrics.Rows[0];

                    // Assign DB computed summaries directly to your dashboard labels
                    lblStat1Value.Text = row["TotalSubmissions"].ToString();
                    lblStat2Value.Text = row["HighestPoints"].ToString();

                    double avgScore = row["AveragePoints"] != DBNull.Value ? Convert.ToDouble(row["AveragePoints"]) : 0.0;
                    double successRate = row["SuccessRate"] != DBNull.Value ? Convert.ToDouble(row["SuccessRate"]) : 0.0;

                    lblStat3Value.Text = avgScore.ToString("F1");
                    lblStat4Value.Text = $"{successRate:F1}%";
                }
                else
                {
                    // Fallback UI reset parameters if records yield empty null returns
                    lblStat1Value.Text = "0";
                    lblStat2Value.Text = "0";
                    lblStat3Value.Text = "0.0";
                    lblStat4Value.Text = "0.0%";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to pull student performance log tracking parameters: " + ex.Message,
                                "Data Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnStudentTopStudents_Click(object sender, EventArgs e)
        {
           LoadTopStudents();
        }       
        private void btnStudentLeaderboard_Click(object sender, EventArgs e)
        {
            LoadContestRanking();
        }

        private void ExecuteReportLoad(Func<DataTable> dataFetchMethod, Action<DataTable> gridLoadMethod)
        {
            if (cmbRows.SelectedItem == null)
            {
                MessageBox.Show("Please select the number of rows to display.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataTable dt = dataFetchMethod();
                gridLoadMethod(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while compiling the report metrics: " + ex.Message, "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // 1. Guard Clause: Make sure a row limit is selected before trying to reload data
            if (cmbRows.SelectedItem == null)
            {
                MessageBox.Show("Please select a valid row truncation limit before refreshing.",
                                "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Determine which dataset is currently active in the workspace and reload it accordingly
                switch (_activeReportTitle)
                {
                    case "Personal Submission History & Performance Tracking Log":
                        // Simulates a click on the student's personal history workflow pipeline
                        btnMySubmissions_Click(sender, e);
                        break;

                    case "Platform Submissions Log & Execution Status Report":
                        // Reloads the admin submissions log matrix
                        btnSubmissionsReport_Click(sender, e);
                        break;

                    case "Top Performing Students Leaderboard Report":
                        // Reloads the student global ranking system view
                        LoadTopStudents();
                        break;

                    case "Examination Contests Engagement Performance Metrics":
                        // Reloads contest engagement tracking stats
                        LoadContestRanking();
                        break;

                    default:
                        // Fallback catch-all case: if the workspace is blank or altered, clear it or load a base state
                        MessageBox.Show("No active report is currently loaded to refresh. Please select a report type first.",
                                        "Workspace Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected layout context error occurred while refreshing data: " + ex.Message,
                                "Refresh Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}