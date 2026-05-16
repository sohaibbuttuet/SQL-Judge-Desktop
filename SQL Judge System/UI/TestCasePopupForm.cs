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
        public TestCasePopupForm()
        {
            InitializeComponent();

            // default view
            ShowAddPanel();
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

        // ================= BUTTON EVENTS =================

        private void btnShowAdd_Click(object sender, EventArgs e)
        {
            ShowAddPanel();
        }

        private void btnShowUpdate_Click(object sender, EventArgs e)
        {
            ShowUpdatePanel();
        }
    }
}
