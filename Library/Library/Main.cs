using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void menuStriptMemberRegistration_Click(object sender, EventArgs e)
        {
            frmMemberRegistration frmMember = new frmMemberRegistration();
            frmMember.MdiParent = frmMain.ActiveForm;
            frmMember.WindowState = FormWindowState.Maximized; //full screen open
            frmMember.Show();
        }
    }
}
