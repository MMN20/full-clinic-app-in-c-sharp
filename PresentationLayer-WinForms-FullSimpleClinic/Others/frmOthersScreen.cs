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
    public partial class frmOthersScreen : Form
    {
        public frmOthersScreen()
        {
            InitializeComponent();
            
        }

        // Forms
        frmStatussesScreen frmStatusses = new frmStatussesScreen();
        frmColorsScreen frmColors = new frmColorsScreen();
        // Forms

        private void frmOthersScreen_Load(object sender, EventArgs e)
        {
            frmStatusses.TopLevel = false;
            frmColors.TopLevel = false;

            pnlStatusses.Controls.Add(frmStatusses);
            pnlColors.Controls.Add(frmColors);
            frmStatusses.Show();
            frmColors.Show();

        }
    }
}
