using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationSystem
{
    public partial class frmSave : Form
    {
        public frmSave()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
        }

        private void frmSave_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.Cursor = Cursors.Hand;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
