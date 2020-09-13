using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTut3
{
    class Room
    {
        private const decimal LARGE_COST = 125;
        private const decimal STANDARD_COST = 100;
        private const decimal SUIT_COST = 150;

        private int _roomNo;
        private RoomTypes _roomType;
        private int _capacity;

        /// <summary>
        /// Initialise the object to the values passed in
        /// </summary>
        /// <param name="roomNo">The room number of the room</param>
        /// <param name="roomType">The type of room</param>
        /// <param name="capacity">The max capacity of the room</param>
        public Room(int roomNo, RoomTypes roomType, int capacity)
        {
            _roomNo = roomNo;
            _roomType = roomType;
            Capacity = capacity;
        }

        /// <summary>
        /// Gets the room number of the room
        /// </summary>
        public int RoomNo
        {
            get { return _roomNo; }
        }

        /// <summary>
        /// Gets the room type of the room
        /// </summary>
        public RoomTypes RoomType
        {
            get { return _roomType; }
        }

        /// <summary>
        /// Gets and sets the max capacity of the room.
        /// </summary>
        public int Capacity
        {
            get { return _capacity; }
            set 
            {
                if (value >= 1 && value <= 6)
                {
                    _capacity = value;
                }
                else
                {
                    throw new Exception("The capacity must be between 1 and 6 inclusive");
                }
            }
        }

        /// <summary>
        /// Returns back all information about a room
        /// </summary>
        /// <returns>All information as a neatly padded out string</returns>
        public override string ToString()
        {
            return RoomNo.ToString().PadRight(5) + RoomType.ToString().PadRight(10) + Capacity.ToString().PadRight(5) + GetCost().ToString("c");
        }

        /// <summary>
        /// Gets the cost of the room
        /// </summary>
        /// <returns>The cost of the room based on it's type</returns>
        public decimal GetCost()
        {
            decimal cost = STANDARD_COST;
            if(RoomType == RoomTypes.Large)
            {
                cost = LARGE_COST;
            }
            else if(RoomType == RoomTypes.Suite)
            {
                cost = SUIT_COST;
            }

            return cost;
        }
    }
}
