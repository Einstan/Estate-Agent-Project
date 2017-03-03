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
    public partial class frmRecordOffer : Form
    {
        public frmRecordOffer()
        {
            InitializeComponent();
        }

        private void btnAddBuyer_Click(object sender, EventArgs e)
        {
            frmAddBuyer formCalled = new frmAddBuyer();
            formCalled.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Offer has been submited..");
            txtBoxOfferAmt.Clear();
        }

        private void txtBoxOfferAmt_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmRecordOffer_Load(object sender, EventArgs e)
        {

        }
    }
}
