using System;
using System.Collections.Generic;
using System.Text;

namespace ManInARoom
{
    public class Area
    {
        Room[,] Rooms { get; }

        public Area(int dimension)
        {
            if (dimension < 1)
                throw new ArgumentOutOfRangeException();

            Rooms = new Room[dimension, dimension];
        }

        public Area FillAreaWithRooms(Area area)
        {
            var options = new[] { -1, -1, -1, -1, 0 }; // borders 20% chance 
            var borderOptions = new[] { 0, 1 }; // single / multiple
            var borderOptionSingle = new[] { 0, 1, 2, 3 }; // according to Direction
            var borderOptionMultiple = new[] { 0, 1 }; // opposite / corner


            return area;
        }
    }
}
