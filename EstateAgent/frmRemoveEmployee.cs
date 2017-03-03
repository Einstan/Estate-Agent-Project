using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstateAgent
{
    public partial class frmRemoveEmployee : Form
    {
        public frmRemoveEmployee()
        {
            InitializeComponent();
        }

        private void lstBoxAllEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMoveRight_Click(object sender, EventArgs e)
        {

        }

        private void btnMoveLeft_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            this.Close();
        }

        private void lstBoxSelected_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmRemoveEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
