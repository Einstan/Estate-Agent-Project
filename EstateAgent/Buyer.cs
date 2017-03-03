using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateAgent
{
    class Buyer
    {
        private int _buyerId = 0;
        private string _BfName = "";
        private string _BlName = "";
        private string _BuyerAddress = "";
        private int _BphoneNum = 0;
        public Buyer()
        {

        }
        public string Buyerdetails
        {
            get { return BfName + " " + BlName + "\tContact: " + BphoneNum; }
        }
        public int BuyerId
        {
            get { return _buyerId; }
            set { _buyerId = value; }
        }
        

        public string BfName
        {
            get { return _BfName; }
            set { _BfName = value; }
        }
        

        public string BlName
        {
            get { return _BlName; }
            set { _BlName = value; }
        }
        

        public string BuyerAddress
        {
            get { return _BuyerAddress; }
            set { _BuyerAddress = value; }
        }
        

        public int BphoneNum
        {
            get { return _BphoneNum; }
            set { _BphoneNum = value; }
        }
        public override string ToString()
        {
            return BfName + " " + BlName + " " + BphoneNum;
        }
    }
}
