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
    public partial class frmClients : Form
    {
        MySqlDataAdapter adapter;
        DataTable dt = new DataTable();
        MySqlCommand cmd;
        private string conn;
        private MySqlConnection connect;

        public frmClients()
        {
            InitializeComponent();
        }
        // DB connection
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
        // initialize RadioButtons
        private void initRadioButtons()
        {
            radioBtnClients.Checked = true;
            radioBtnOwners.Checked = false;
        }
        // Load Form
        private void frmClients_Load(object sender, EventArgs e)
        {
            initRadioButtons();
            
            
        }
        // Populate method to fill the Clients datagrid
        private void populate(string id, string fname, string lname, string address, string phonenum)
        {
            dataGridClients.Rows.Add(id, fname, lname, address, phonenum);
        }
        // Displays the clients in the data grid
        void listClients()
        {
            dataGridClients.Rows.Clear();
            db_connection();

            string sql = "Select * from buyer";
            MySqlCommand cmd = new MySqlCommand(sql, connect);
            try
            {

                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString());
                }
                connect.Close();

                //clear dt
                dt.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connect.Close();
            }

        }
        // ADD Client to DB
        private void add(string fname, string lname, string address, string pNum)
        {
            db_connection();
            string sql = "Insert into buyer(fName,lName,address,phoneNo) Values(@fname, @lname, @address,@pNum)";
            MySqlCommand cmd = new MySqlCommand(sql, connect);
            // add params
            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue("@lname", lname);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@pNum", pNum);

            try
            {
                db_connection();
                if(cmd.ExecuteNonQuery()>0)
                {
                    clearTextBox();
                    MessageBox.Show("Successfully Inserted!");
                }
                connect.Close();

                listClients();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                connect.Close();
            }

        }
        // UPDATE Client in DB
        private void update(int id, string fname, string lname, string address, string phoneNum)
        {
            db_connection();
            string sql = "UPDATE buyer set fName = '" + fname + "',lName = '" + lname + "',address='" + address + "',phoneNo='" + phoneNum + "' where buyerID =" + id + "";
            MySqlCommand cmd = new MySqlCommand(sql, connect);

            try
            {
                adapter = new MySqlDataAdapter(cmd);
                adapter.UpdateCommand = connect.CreateCommand();
                adapter.UpdateCommand.CommandText = sql;

                if(adapter.UpdateCommand.ExecuteNonQuery()>0)
                {
                    clearTextBox();
                    MessageBox.Show("Successfully Updated!");
                }
                connect.Close();

                listClients();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                connect.Close();
            }
        }
        // DELETE Client from DB
        private void delete(int id)
        {
            db_connection();
            string sql = "delete from buyer where buyerID = " + id + "";
            cmd = new MySqlCommand(sql, connect);

            try
            {
                db_connection();

                adapter = new MySqlDataAdapter(cmd);

                adapter.DeleteCommand = connect.CreateCommand();

                adapter.DeleteCommand.CommandText = sql;

                if(MessageBox.Show("Are you Sure?", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==DialogResult.OK)
                {
                    if(cmd.ExecuteNonQuery()>0)
                    {
                        clearTextBox();
                        MessageBox.Show("Successfully Deleted");
                    }
                }
                connect.Close();

                listClients();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // Clear textboxes
        private void clearTextBox()
        {
            txtFName.Text = "";
            txtLName.Text = "";
            txtAddress.Text = "";
            txtPNum.Text = "";
        }

        // Set Text Boxes with selected row information
        private void dataGridClients_Click(object sender, EventArgs e)
        {
            txtFName.Text = dataGridClients.SelectedRows[0].Cells[1].Value.ToString();
            txtLName.Text = dataGridClients.SelectedRows[0].Cells[2].Value.ToString();
            txtAddress.Text = dataGridClients.SelectedRows[0].Cells[3].Value.ToString();
            txtPNum.Text = dataGridClients.SelectedRows[0].Cells[4].Value.ToString();
        }
        private void dataGridClients_MouseClick(object sender, MouseEventArgs e)
        {
            
        }// CODE NOT USED

        // Add Button Click
        private void btnAddClients_Click(object sender, EventArgs e)
        {
            add(txtFName.Text, txtLName.Text, txtAddress.Text, txtPNum.Text);
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            
        }// CODE NOT USED

        private void btnRemove_Click(object sender, EventArgs e)
        {
            String selected = dataGridClients.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(selected);
            delete(id);
        }

        // Update buuton Click
        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            String selected = dataGridClients.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(selected);
            
            update(id, txtFName.Text, txtLName.Text, txtAddress.Text, txtPNum.Text);
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }// CODE NOT USED

        // Radio buttons change
        private void radioBtnClients_CheckedChanged(object sender, EventArgs e)
        {
            panelClients.Visible = true;
            panelOwners.Visible = false;
            lblHeader.Text = "Clients";
            listClients();
            txtFName.Text = dataGridClients.SelectedRows[0].Cells[1].Value.ToString();
            txtLName.Text = dataGridClients.SelectedRows[0].Cells[2].Value.ToString();
            txtAddress.Text = dataGridClients.SelectedRows[0].Cells[3].Value.ToString();
            txtPNum.Text = dataGridClients.SelectedRows[0].Cells[4].Value.ToString();


        }

        private void radioBtnOwners_CheckedChanged(object sender, EventArgs e)
        {
            panelClients.Visible = false;
            panelOwners.Visible = true;
            listOwners();
            lblHeader.Text = "Property Owners";
            txtPanelOwnersAddress.Text = dataGridOwners.SelectedRows[0].Cells[3].Value.ToString();
            txtPanelOwnersFName.Text = dataGridOwners.SelectedRows[0].Cells[1].Value.ToString();
            txtPanelOwnersLName.Text = dataGridOwners.SelectedRows[0].Cells[2].Value.ToString();
            txtPanelOwnersPhone.Text = dataGridOwners.SelectedRows[0].Cells[4].Value.ToString(); 
        }
        
        // OWNERS PANEL METHODS

        // populate owners
        private void populateOwners(string id, string fname, string lname, string address, string phonenum)
        {
            dataGridOwners.Rows.Add(id, fname, lname, address, phonenum);
        }
        // Display onwers in a datagrid
        private void listOwners()
        {
            dataGridOwners.Rows.Clear();
            db_connection();

            string sql = "Select * from owner";
            MySqlCommand cmd = new MySqlCommand(sql, connect);
            try
            {

                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    populateOwners(row[5].ToString(),row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString());
                }
                connect.Close();

                //clear dt
                dt.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connect.Close();
            }
        }
        // ADD Owners to DB
        private void addOwner(string fname, string lname, string address, string pNum)
        {
            db_connection();
            string sql = "Insert into owner(Fname,LName,address,PhoneNo) Values(@fname, @lname, @address,@pNum)";
            MySqlCommand cmd = new MySqlCommand(sql, connect);
            // add params
            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue("@lname", lname);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@pNum", pNum);

            try
            {
                db_connection();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    clearTextBoxOwners();
                    MessageBox.Show("Successfully Inserted!");
                }
                connect.Close();

                listOwners();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connect.Close();
            }

        }
        // UPDATE Owner in DB
        private void updateOwner(int id, string fname, string lname, string address, string phoneNum)
        {
            db_connection();
            string sql = "UPDATE owner SET Fname = '" + fname + "',LName = '" + lname + "',address='" + address + "',PhoneNo='" + phoneNum + "' WHERE ownerID =" + id + "";
            MySqlCommand cmd = new MySqlCommand(sql, connect);

            try
            {
                
                adapter = new MySqlDataAdapter(cmd);
                adapter.UpdateCommand = connect.CreateCommand();
                adapter.UpdateCommand.CommandText = sql;

                if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    clearTextBoxOwners();
                    MessageBox.Show("Successfully Updated!");
                }
                connect.Close();

                listOwners();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connect.Close();
            }
        }
        // Clear Owner Textboxes
        private void clearTextBoxOwners()
        {
            txtPanelOwnersAddress.Text = "";
            txtPanelOwnersFName.Text = "";
            txtPanelOwnersLName.Text = "";
            txtPanelOwnersPhone.Text = "";
             
        }
        // Owners ADD button Click
        private void btnPanelOwnersAdd_Click(object sender, EventArgs e)
        {
            addOwner(txtPanelOwnersFName.Text, txtPanelOwnersLName.Text, txtPanelOwnersAddress.Text, txtPanelOwnersPhone.Text);
        }
        //Owners UPDATE button Click
        private void btnPanelOwnersUpdate_Click(object sender, EventArgs e)
        {
            String selected = dataGridOwners.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(selected);

            updateOwner(id, txtPanelOwnersFName.Text, txtPanelOwnersLName.Text, txtPanelOwnersAddress.Text, txtPanelOwnersPhone.Text);
        }
        // Set Text Boxes with selected row information
        private void dataGridOwners_MouseClick(object sender, MouseEventArgs e)
        {
            txtPanelOwnersAddress.Text = dataGridOwners.SelectedRows[0].Cells[3].Value.ToString();
            txtPanelOwnersFName.Text = dataGridOwners.SelectedRows[0].Cells[1].Value.ToString();
            txtPanelOwnersLName.Text = dataGridOwners.SelectedRows[0].Cells[2].Value.ToString();
            txtPanelOwnersPhone.Text = dataGridOwners.SelectedRows[0].Cells[4].Value.ToString(); 
        }

        // EXIT Button
        private void button1_Click_1(object sender, EventArgs e)
        {
            frmMain fc = new frmMain();
            fc.Show();
            this.Close();
        }

        // EXIT Button
        private void btnExit_Click(object sender, EventArgs e)
        {
            frmMain fc = new frmMain();
            fc.Show();
            this.Close();
        }

        private void dataGridClients_MouseClick_1(object sender, MouseEventArgs e)
        {

        }

       

        

    }
}
