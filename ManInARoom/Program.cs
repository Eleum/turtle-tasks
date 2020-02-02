using System;

namespace ManInARoom
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new Player();
            player.Direction = Direction.Right;

            var room = new Room(7);
            Room.FillCellsInRoom(room);
        }
    }
}
