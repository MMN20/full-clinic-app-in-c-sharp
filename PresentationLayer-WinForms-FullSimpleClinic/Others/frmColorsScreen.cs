using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer_WinForms_FullSimpleClinic.Others
{
    public partial class frmColorsScreen : Form
    {
        public frmColorsScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            frmMainScreen.instance.pnlSidePanel.BackColor = btn.BackColor;
            frmMainScreen.instance.pnlTopPanel.BackColor = btn.BackColor;
        }
    }
}
