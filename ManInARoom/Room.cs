using System.Linq;

namespace ManInARoom
{
    public class Room
    {
        Border[] Borders { get; } = new Border[4];

        public Room(params int[] borders)
        {
            var realBorders = borders.Where((x, idx) => x >= 0 && x <= 3).Distinct();

            foreach(var border in realBorders)
            {
                Borders[border].IsPassable = false;
            }
        }
    }
}
