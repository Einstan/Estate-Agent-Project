using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateAgent
{
    class Property
    {
        private int _propId =0;
        private string _address="";
        private string _propType="";
        private string _town = "";

       
        public Property()
        {

        }
        public string Town
        {
            get { return _town; }
            set { _town = value; }
        }
        public string Propdetails
        {
            get { return Address + ", " + Town; }
        }
        public int PropId
        {
            get { return _propId; }
            set { _propId = value; }
        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public string PropType
        {
            get { return _propType; }
            set { _propType = value; }
        }

        public override string ToString()
        {
            return Address;
        }
    }
}
