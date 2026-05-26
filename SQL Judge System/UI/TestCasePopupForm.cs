using SQL_Judge_System.BL;
using SQL_Judge_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Judge_System.UI
{
    public partial class TestCasePopupForm : Form
    {
        int userID;
        int testCaseID;
        public TestCasePopupForm(int userID)
        {
            InitializeComponent();
            LoadComboBox(cmbAProblem);
            ShowAddPanel();

            this.userID = userID;           
        }
        public TestCasePopupForm(int userID, int testCaseID)
        {
            InitializeComponent();
            LoadComboBox(cmbUProblem);
            ShowUpdatePanel();

            this.userID = userID;
            this.testCaseID = testCaseID;            
        }

        public void ShowAddPanel()
        {
            addPanel.Visible = true;
            updatePanel.Visible = false;
        }
        public void ShowUpdatePanel()
        {
            addPanel.Visible = false;
            updatePanel.Visible = true;
        }
        private void LoadComboBox(ComboBox box)
        {
            try
            {
                box.DataSource = ProblemBL.GetProblems();
                box.DisplayMember = "Title";
                box.ValueMember = "ProblemID";

                box.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading problems:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ================= BUTTON EVENTS =================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string testCaseName = txtATestName.Text;
                string setup = txtASetupSQL.Text;
                string solution = txtASolutionQuery.Text;

                if (cmbAProblem.SelectedValue == null)
                {
                    MessageBox.Show("Please select a problem.");
                }

                int problemID = Convert.ToInt32(cmbAProblem.SelectedValue);

                TestCase testCase = new TestCase(testCaseName, problemID, setup, solution, userID);

                TestCaseBL.AddTestCase(testCase);

                MessageBox.Show("Test case added successfully.");
                ClearAddInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }
        private void btnAClear_Click(object sender, EventArgs e)
        {
            ClearAddInputs();
        }
        private void ClearAddInputs()
        {
            txtASetupSQL.Clear();
            txtASolutionQuery.Clear();
            txtATestName.Clear();
            cmbAProblem.SelectedIndex = -1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string testCaseName = txtUTestName.Text;
                string setup = txtUSetupSQL.Text;
                string solution = txtUSolutionQuery.Text;

                if (cmbUProblem.SelectedValue == null)
                {
                    MessageBox.Show("Please select a problem.");
                }

                int problemID = Convert.ToInt32(cmbAProblem.SelectedValue);

                TestCase testCase = new TestCase(testCaseID, testCaseName, problemID, setup, solution, userID);

                TestCaseBL.UpdateTestCase(testCase);

                MessageBox.Show("Test case Updated successfully.");
                ClearUpdateInputs();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       
        private void btnUClear_Click(object sender, EventArgs e)
        {
            ClearUpdateInputs();
        }
        private void ClearUpdateInputs()
        {
            txtUSetupSQL.Clear();
            txtUSolutionQuery.Clear();
            txtUTestName.Clear();
            cmbUProblem.SelectedIndex = -1;
        }
      
    }
}
