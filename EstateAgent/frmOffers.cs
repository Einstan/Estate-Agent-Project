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
    public partial class frmOffers : Form
    {
        public frmOffers()
        {
            InitializeComponent();
        }

        private void frmOffers_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            this.Close();
        }

        private void btnRecordOffer_Click(object sender, EventArgs e)
        {
            frmRecordOffer formCalled = new frmRecordOffer();
            formCalled.Show();
            this.Close();
        }
    }
}
