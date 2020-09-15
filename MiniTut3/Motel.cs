using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTut3
{
    class Motel
    {
        private string _name = "";
        private string _address = "";
        private string _phoneNo = "";

        /// <summary>
        /// gets and sets the name of the motel
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// gets and sets the address of the motel
        /// </summary>
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        /// <summary>
        /// gets and sets the phone number of the motel
        /// </summary>
        public string PhoneNo
        {
            get { return _phoneNo; }
            set { _phoneNo = value; }
        }

        /// <summary>
        /// Initialises the object to the values passed in
        /// </summary>
        /// <param name="name">The name of the motel</param>
        /// <param name="address">The address of the motel</param>
        /// <param name="phoneNo">The phone number of the motel</param>
        public Motel(string name, string address, string phoneNo)
        {
            Name = name;
            Address = address;
            PhoneNo = phoneNo;
        }
    }
}
