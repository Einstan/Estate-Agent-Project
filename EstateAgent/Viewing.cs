using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EstateAgent
{
    class Viewing
    {
        private string _vDate = "";
        private string _vTime = "";
        private int _vID = 0;
        private int _vPropID = 0;
        private int _vBuyerID = 0;

        private string _BuyerFName = "";
        private string _BuyerLName = "";

        private string conn;
        private MySqlConnection connect;

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
        public string Viewdetails
        {
            get { return _BuyerFName + " " + _BuyerLName; }
        }
        public string VDate
        {
            get { return _vDate; }
            set { _vDate = value; }
        }
        public string VTime
        {
            get { return _vTime; }
            set { _vTime = value; }
        }
        public int VID
        {
            get { return _vID; }
            set { _vID = value; }
        }
        public int VPropID
        {
            get { return _vPropID; }
            set { _vPropID = value; }
        }
        public int VBuyerID
        {
            get { return _vBuyerID; }
            set { _vBuyerID = value; }
        }
        public override string ToString()
        {
            return VTime+" "+VPropID+" "+VBuyerID;
        }
        /*public void getBuyerDetailsForViewing(int buyerid)
        {
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select fName,lName from buyer where buyerID=@buyerID";
            cmd.Parameters.AddWithValue("@buyerID", buyerid);
            cmd.Connection = connect;
            MySqlDataReader vRdr = cmd.ExecuteReader();

            while(vRdr.Read())
            {
                _BuyerFName = vRdr["fName"].ToString();
                _BuyerLName = vRdr["lname"].ToString();
            }
        }*/


    }
}
