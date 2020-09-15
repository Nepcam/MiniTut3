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
        private Room _room;

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
        /// Gets the reference to the room.
        /// </summary>
        public Room MotelRoom
        {
            get { return _room; }
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
            _room = null;
        }

        /// <summary>
        /// Gets all information about the motel.
        /// </summary>
        /// <returns>All information as a neatly padded out string</returns>
        public override string ToString()
        {
            return Name.PadRight(20) + Address.PadRight(30) + PhoneNo;
        }

        /// <summary>
        /// Adds a new room to the motel
        /// </summary>
        /// <param name="roomNo">Room number</param>
        /// <param name="roomType">Room type</param>
        /// <param name="capacity">Room capacity</param>
        public void AddRoom(int roomNo, RoomTypes roomType, int capacity)
        {
            _room = new Room(roomNo, roomType, capacity);
        }

        /// <summary>
        /// Gets all information about a room
        /// </summary>
        /// <returns>All information about a room as a neatly padded out string</returns>
        public string GetRoomInfo()
        {
            return _room.ToString();
        }
    }
}
