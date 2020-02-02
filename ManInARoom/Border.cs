using System;
using System.Collections.Generic;
using System.Text;

namespace ManInARoom
{
    public class Border
    {
        public bool IsPassable { get; set; }

        public Border(bool isPassable = true)
        {
            IsPassable = IsPassable;
        }
    }
}
