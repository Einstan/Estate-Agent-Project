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
    public partial class frmViewings : Form
    {
        
        private string conn;
        private MySqlConnection connect;
        MySqlDataAdapter adapter;
        DataTable dt = new DataTable();

        public frmViewings()
        {
            InitializeComponent();

            //datagrid properties
            dataGridProperties.ColumnCount = 4;
            dataGridProperties.Columns[0].Name = "PropertyID";
            dataGridProperties.Columns[1].Name = "House No";
            dataGridProperties.Columns[2].Name = "Address";
            dataGridProperties.Columns[3].Name = "Town";
            

            dataGridProperties.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Selection Mode
            
            dataGridProperties.MultiSelect = false;
            
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
        private void frmViewings_Load(object sender, EventArgs e)
        {
            // display properties
            //fillListBoxWithProperties();
            listProps();

            //Variables.SelectedProp = lstBoxProperties.SelectedValue.ToString();
            

            Console.WriteLine(Variables.SelectedProp);
            // instantiate month calendar
            MonthCalendar ViewingsCalendar = new MonthCalendar();

            // get todays date and assign it to Global variable
            DateTime thisDay = DateTime.Today;
            thisDay.ToShortDateString();
            string td = thisDay.ToString("yyyy-MM-dd");
            Variables.TodaysDate = td;
            Variables.SelectedDate = td;
            

            // setting the calendar min and max date to today and 3 weeks from today
            DateTime lastDate = new DateTime();
            lastDate = thisDay.AddDays(21);
            this.ViewingsCalendar.MinDate = thisDay;
            this.ViewingsCalendar.MaxDate = lastDate;
            //ViewingsCalendar.SelectionStart.Date.ToString("yyyy-MM-dd");

            //Delete viewings from the database that have dates previous to today - deletePastViewings()
            //deletePastViewings();

            // Fill the list box with all the viewings on load
            //---------------------------------------------------------------------------------------------------------------------fillListBoxAllViewings();
        }
       
        // Actions that happen when a different date is selected on the month calendar 
        private void ViewingsCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime sDate = ViewingsCalendar.SelectionStart;
            sDate.ToShortDateString();
            string selectedDate = sDate.ToString("yyyy-MM-dd");
            Variables.SelectedDate = selectedDate;
            // Getting the selected date, clearing the list box, filling list box based on date selected
            Variables._viewingListByDateAndProperty.Clear();

            label1.Text = "Date: " + Variables.SelectedDate;
            
            
            string tempSelectedPropString = Variables.SelectedProp;
            int tempSelectedProp = Int32.Parse(tempSelectedPropString);
            fillListBoxWithViewings(tempSelectedProp, Variables.SelectedDate);
            


        }
        // Create new viewing button
        private void btnAddViewing_Click(object sender, EventArgs e)
        {
            frmNewViewing formCalled = new frmNewViewing();
            formCalled.Show();
            this.Close();
            
        }
        private void btnShowAllViewings_Click(object sender, EventArgs e)
        {
            //label1.Text = "All Viewings";
            //lstViewings.Items.Clear();
            //fillListBoxAllViewings();
        }

        private void lstBoxProperties_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewingsCalendar.SetDate(DateTime.Today);
            Variables.SelectedProp = lstBoxProperties.SelectedValue.ToString();
            
            string tempSelectedPropString = Variables.SelectedProp;
            Console.WriteLine(Variables.SelectedProp);
            // Comment for self - get date instead of prop like in lstViewings
            
            //tempSelectedPropInt = System.Convert.ToInt32(Variables.SelectedProp);
          
            
        }
        // --------------------METHODS--------------------

        // fill Viewings list box using propertyID and date - param = int id, string date
        void fillListBoxWithViewings(int id, string date)
        {
            
            Variables._viewingListByDateAndProperty = new List<Viewing>();
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select * from viewing where propertyID=@id and date=@date;";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Connection = connect;
            MySqlDataReader vRdr = cmd.ExecuteReader();

            while (vRdr.Read())
            {
                Viewing view = new Viewing();
                view.VID = Convert.ToInt32(vRdr["viewingNo"]);
                view.VDate = vRdr["date"].ToString();
                view.VTime = vRdr["time"].ToString();
                view.VPropID = Convert.ToInt32(vRdr["propertyID"]);
                view.VBuyerID = Convert.ToInt32(vRdr["buyerID"]);
                Variables._viewingListByDateAndProperty.Add(view);

            }
            lstViewings.DataSource = Variables._viewingListByDateAndProperty;
            
           
            //lstBoxProperties.DataSource = Variables._propList;
            //lstBoxProperties.DisplayMember = "Address";
            //lstBoxProperties.ValueMember = "PropId";*/

        }

        // fill list box with all viewings
                                                                                                        //void fillListBoxAllViewings()
                                                                                                        //{
                                                                                                        //    db_connection();
                                                                                                        //    MySqlCommand cmd = new MySqlCommand();
                                                                                                        //    cmd.CommandText = "select * from viewings";
                                                                                                        //    cmd.Connection = connect;
                                                                                                        //    MySqlDataReader viewing = cmd.ExecuteReader();

                                                                                                        //    try
                                                                                                        //    {

                                                                                                        //        while (viewing.Read())
                                                                                                        //        {
                                                                                                        //            string sDate = viewing.GetString("date");

                                                                                                        //            string time = viewing.GetString("time");
                                                                                                        //            lstViewings.Items.Add(sDate + "\t" + time);
                                                                                                        //        }
                                                                                                        //    }
                                                                                                        //    catch (Exception es)
                                                                                                        //    {
                                                                                                        //        MessageBox.Show(es.Message);
                                                                                                        //    }
                                                                                                        //}
        // deletes viewings that are past todays date
        /*void deletePastViewings()
        {
            //DateTime today = Convert.ToDateTime(Variables.TodaysDate);
            DateTime thisDay = DateTime.Today;
            string x = thisDay.ToString("yyyy-MM-dd");
            DateTime dt = Convert.ToDateTime(x);
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "delete from viewings where date <'" + thisDay + "'; ";
            cmd.Connection = connect;
            MySqlDataReader viewing = cmd.ExecuteReader();
        }*/
        // filling list box based on date selected
                                                                                                        //void fillListBoxByDate(string date)
                                                                                                        //{
                                                                                                        //    db_connection();
                                                                                                        //    MySqlCommand cmd = new MySqlCommand();
                                                                                                        //    cmd.CommandText = "select * from viewings where date =  '" + date + "'; ";
                                                                                                        //    cmd.Connection = connect;
                                                                                                        //    MySqlDataReader viewing = cmd.ExecuteReader();
                                                                                                        //    try
                                                                                                        //    {

                                                                                                        //        while (viewing.Read())
                                                                                                        //        {
                                                                                                        //            string sDate = viewing.GetString("date"); 
                    
                                                                                                        //            string time = viewing.GetString("time");
                                                                                                        //            lstViewings.Items.Add(sDate + "\t" + time);
                                                                                                        //        }
                                                                                                        //    }
                                                                                                        //    catch (Exception es)
                                                                                                        //    {
                                                                                                        //        MessageBox.Show(es.Message);
                                                                                                        //    }
                                                                                                        //}
        // Get all the properties and display them in a list box
        void fillListBoxWithProperties()
        {
            Variables._propList = new List<Property>();
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select * from property ";
            cmd.Connection = connect;
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Property prop = new Property();
                prop.PropId = Convert.ToInt32(dr["propertyId"]);
                prop.Address = dr["Address"].ToString();
                prop.Town = dr["Town"].ToString();
                prop.PropType = dr["Type"].ToString();
                Variables._propList.Add(prop);
                
            }
            lstBoxProperties.DataSource = Variables._propList;
            lstBoxProperties.DisplayMember = "Propdetails";
            lstBoxProperties.ValueMember = "PropId";

        }
        private void populate(string id, string hNo, string address, string town)
        {
            dataGridProperties.Rows.Add(id, hNo, address, town);
        }
        void listProps()
        {
            dataGridProperties.Rows.Clear();
            db_connection();
            
            string sql = "Select * from property";
            MySqlCommand cmd = new MySqlCommand(sql, connect);
            try
            {
                
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

                foreach(DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString());
                }
                connect.Close();

                //clear dt
                dt.Rows.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                connect.Close();
            }

        }


        
    }
}
