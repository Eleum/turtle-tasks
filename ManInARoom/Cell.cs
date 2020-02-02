using System.Linq;

namespace ManInARoom
{
    public class Cell
    {
        Border[] Borders { get; } = new Border[] { new Border(), new Border(), new Border(), new Border() };

        public Cell(params int[] borders)
        {
            var realBorders = borders.Where((x, idx) => x >= 0 && x <= 3).Distinct();

            foreach(var border in realBorders)
            {
                Borders[border].IsPassable = false;
            }
        }

        public Border[] SetBorder(int border)
        {
            Borders[border].IsPassable = false;
            return Borders;
        }
    }
}
