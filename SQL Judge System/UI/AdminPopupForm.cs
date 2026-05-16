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
    public partial class AdminPopupForm : Form
    {
        public AdminPopupForm()
        {
            InitializeComponent();

            // default state 
            ShowAddPanel();
        }
        public void ShowAddPanel()
        {
            addPanel.Visible = true;
            editPanel.Visible = false;
        }

        public void ShowEditPanel()
        {
            addPanel.Visible = false;
            editPanel.Visible = true;
        }

        private void btnSwitchEdit_Click(object sender, EventArgs e)
        {
            ShowEditPanel();
        }

        private void btnSwitchAdd_Click(object sender, EventArgs e)
        {
            ShowAddPanel();
        }
    }
}
