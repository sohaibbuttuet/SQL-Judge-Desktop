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
    public partial class ContestPopupForm : Form
    {
        public ContestPopupForm()
        {
            InitializeComponent();

            // Default View
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

        private void btnSwitchAdd_Click(object sender, EventArgs e)
        {
            ShowAddPanel();
        }

        private void btnSwitchEdit_Click(object sender, EventArgs e)
        {
            ShowUpdatePanel();
        }
    }
}
