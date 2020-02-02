using System;

namespace ManInARoom
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new Player();
            player.Direction = Direction.Right;

            var area = new Area(7);
        }
    }
}
