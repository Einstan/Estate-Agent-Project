using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EstateAgent
{
    public partial class frmMain : Form
    {
        private string conn;
        private MySqlConnection connect;

        public frmMain()
        {
            InitializeComponent();
        }
        private void db_connection()
        {
            try
            {
                conn = "Server=localhost;Database=estate;Uid=root;Pwd=;";
                connect = new MySqlConnection(conn);
                connect.Open();
            }
            catch (MySqlException e)
            {
                throw;
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            //instantiate a new form and display it
            frmUpdateStaff formcalled = new frmUpdateStaff();
            formcalled.Show();
            this.Close();
        }

        private void btnOffer_Click(object sender, EventArgs e)
        {
            frmOffers formCalled = new frmOffers();
            formCalled.Show();
            this.Close();
        }

        private void btnProperty_Click(object sender, EventArgs e)
        {

        }

        private void btnProSalesRep_Click(object sender, EventArgs e)
        {
            frmSalesData fc = new frmSalesData();
            fc.Show();
            this.Close();
        }

        private void btnCheckView_Click(object sender, EventArgs e)
        {
            frmViewings2 formCalled = new frmViewings2();
            formCalled.Show();
            this.Close();
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            frmEmail formaCalled = new frmEmail();
            formaCalled.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            frmClients fc = new frmClients();
            fc.Show();
            this.Close();
        }
    }
}
