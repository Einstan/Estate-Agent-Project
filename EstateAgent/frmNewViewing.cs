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
    public partial class frmNewViewing : Form
    {
        private string propertyDisplay;
        private List<Buyer> listOfBuyers = new List<Buyer>();
        private List<string> bookedTimes = new List<string>();
        private List<string> availableTimes = new List<String>();
        private int highestId = 0;
        private string timeSelected = "";
        private string conn;
        private MySqlConnection connect;

        public frmNewViewing()
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmNewViewing_Load(object sender, EventArgs e)
        {
            string tempSelectedPropString = Variables.SelectedProp;
            int tempSelectedProp = Int32.Parse(tempSelectedPropString);

            getBookedTimes(tempSelectedProp, Variables.SelectedDate);
            RemoveBookedTimesFromList();
            populateBuyersList();
            
            label1.Text = "Date: " + Variables.SelectedDate;
            getSelectedProperty();
            lblProperty.Text = "Property: " + propertyDisplay;
        }

        private void comboBoxAvailableTimes_SelectedIndexChanged(object sender, EventArgs e)
        {
            timeSelected = comboBoxAvailableTimes.Text;
            
        }
        void getBookedTimes(int id, string date)
        {
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select time from viewing where propertyID=@id and date=@date;";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Connection = connect;
            MySqlDataReader vRdr = cmd.ExecuteReader();

            while (vRdr.Read())
            {
                string tempTime = "";
                
                tempTime = vRdr["time"].ToString();

                bookedTimes.Add(tempTime);
            }
        }
        void RemoveBookedTimesFromList()
        {
            List<string> tempBookedTimes = new List<string>();
            List<string> tempTimes = new List<string>();
            string [] arrayTimes = new string[]{};
            string [] arrayBookedTimes = new string[]{};
            string[] availableTimes = new string[] { };

            tempTimes = new List<string>(Variables._arrayTimes);
            tempBookedTimes = new List<string>(bookedTimes);
            arrayTimes = tempTimes.ToArray();
            arrayBookedTimes = tempBookedTimes.ToArray();

            IEnumerable<string> tempNewTimes = tempTimes.Except(tempBookedTimes);
            availableTimes = tempNewTimes.ToArray();

            comboBoxAvailableTimes.DataSource = availableTimes;

        }
       
        public void getSelectedProperty()
        {
            foreach(Property prop in Variables._propList)
            {
                if(prop.PropId == Convert.ToInt32(Variables.SelectedProp))
                {
                    propertyDisplay = prop.Address.ToString();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmViewings frmCalled = new frmViewings();
            this.Close();
            frmCalled.Show();
        }
        void populateBuyersList()
        {
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select * from buyer";
            cmd.Connection = connect;
            MySqlDataReader vRdr = cmd.ExecuteReader();

            while (vRdr.Read())
            {
                Buyer buyer = new Buyer();
                buyer.BuyerId = Convert.ToInt32(vRdr["buyerID"]);
                buyer.BfName = vRdr["fName"].ToString();
                buyer.BlName = vRdr["lName"].ToString();
                buyer.BuyerAddress = vRdr["address"].ToString();
                buyer.BphoneNum = Convert.ToInt32(vRdr["phoneNo"]);
                listOfBuyers.Add(buyer);

            }
            
            lstBuyers.DataSource = listOfBuyers;
            lstBuyers.DisplayMember = "Buyerdetails";
            lstBuyers.ValueMember = "buyerID";
        }

        private void lstBuyers_SelectedIndexChanged(object sender, EventArgs e)
        {

            Variables.SelectedBuyer = lstBuyers.SelectedValue.ToString();
            
           
        }
        private void btnCreateViewing_Click(object sender, EventArgs e)
        {
            setHighestId();
            
            
            Console.WriteLine(highestId);
            string tempSelectedBuyerString = Variables.SelectedBuyer;
            int tempSelectedBuyer = Int32.Parse(tempSelectedBuyerString);

            string tempSelectedPropString = Variables.SelectedProp;
            int tempSelectedProp = Int32.Parse(tempSelectedPropString);

            Console.WriteLine(tempSelectedBuyer);
            

            createViewing(32023, tempSelectedBuyer, tempSelectedProp, Variables.SelectedDate, timeSelected);
        }
        void setHighestId()
        {
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select MAX(viewingNo) from viewing";
            cmd.Connection = connect;
            MySqlDataReader vRdr = cmd.ExecuteReader();
            while(vRdr.Read())
            {
                //highestId = Convert.ToInt32(vRdr["viewingNo"]);
            }
            highestId++;

        }
        void createViewing(int viewNo, int viewBuyerId, int viewPropId, string viewDate, string viewTime)
        {
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "insert into viewing (viewingNo, buyerID, propertyID, date, time) values (@viewingNo, @buyerID, @propertyID, @date, @time)";
            cmd.Parameters.AddWithValue("@viewingNo", viewNo);
            cmd.Parameters.AddWithValue("@buyerID", viewBuyerId);
            cmd.Parameters.AddWithValue("@propertyID", viewPropId);
            cmd.Parameters.AddWithValue("@date", viewDate);
            cmd.Parameters.AddWithValue("@time", viewTime);
            cmd.Connection = connect;
            cmd.ExecuteNonQuery();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddBuyer formCalled = new frmAddBuyer();
            formCalled.Show();
            this.Close();
        }

       

    }
}
