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
    public partial class frmUpdateStaff : Form
    {
        private string conn;
        private MySqlConnection connect;

        public frmUpdateStaff()
        {
            InitializeComponent();
            fillListBox();
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
        void fillListBox()
        {
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select * from employee";
            cmd.Connection = connect;
            MySqlDataReader employee = cmd.ExecuteReader();

            try
            {

                while (employee.Read())
                {
                    string fname = employee.GetString("fName"); //name is coming from database
                    string lname = employee.GetString("sName");
                    staffList.Items.Add(fname + "\t" + lname);
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            frmUpdateStaffDetails formCalled = new frmUpdateStaffDetails();
            formCalled.Show();
            this.Close();
        }

        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelUpdateStaff_Click(object sender, EventArgs e)
        {
            frmMain formCalled = new frmMain();
            formCalled.Show();
            this.Close();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            frmAddEmployee formCalled = new frmAddEmployee();
            formCalled.Show();
            this.Close();
        }

        private void staffList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmUpdateStaff_Load(object sender, EventArgs e)
        {

        }
    }
}
