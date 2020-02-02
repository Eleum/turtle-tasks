using System;
using System.Collections.Generic;
using System.Text;

namespace ManInARoom
{
    public class Player
    {
        public Direction Direction { get; set; } = Direction.Bottom;

        public Position Position { get; } = new Position();
    }
}
