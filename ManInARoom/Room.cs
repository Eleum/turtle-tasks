using System;

namespace ManInARoom
{
    public class Room
    {
        Cell[,] Cells { get; }

        public Room(int dimension)
        {
            if (dimension < 1)
                throw new ArgumentOutOfRangeException();

            Cells = new Cell[dimension, dimension];
        }

        public static Room FillCellsInRoom(Room room)
        {
            var options = new[] { -1, -1, -1, 0 }; // borders 25% chance 
            var borderOptions = new[] { 0, 1 }; // single / multiple
            var borderOptionsSingle = new[] { 0, 1, 2, 3 }; // according to Direction
            var borderOptionsMultiple = new[] { 0, 1 }; // corner / opposite
            var borderOptionsMultipleCorner = new[]
            {
                new Tuple<int, int>(0, 1),
                new Tuple<int, int>(1, 2),
                new Tuple<int, int>(2, 3),
                new Tuple<int, int>(3, 1)
            };

            var borderOptionMultipleOpposite = new[]
            {
                new Tuple<int, int>(0, 2),
                new Tuple<int, int>(1, 3),
            };

            for (int i = 0; i <= room.Cells.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= room.Cells.GetUpperBound(1); j++)
                {
                    var rand = new Random();

                    var option = rand.Next(0, options.Length);
                    if (option < 0)
                    {
                        room.Cells[i, j] = new Cell();
                    }

                    var borderOption = rand.Next(0, borderOptions.Length);
                    if (borderOption == 0)
                    {
                        var border = rand.Next(0, borderOptionsSingle.Length);
                        room.Cells[i, j] = new Cell(border);
                    }
                    else
                    {
                        var borderOptionMultiple = rand.Next(0, borderOptionsMultiple.Length);
                        if (borderOptionMultiple == 0)
                        {
                            var borderOptionMultipleExact = rand.Next(0, borderOptionsMultipleCorner.Length);
                            var pair = borderOptionsMultipleCorner[borderOptionMultipleExact];
                            room.Cells[i, j] = new Cell(pair.Item1, pair.Item2);
                        }
                        else
                        {
                            var borderOptionMultipleExact = rand.Next(0, borderOptionMultipleOpposite.Length);
                            var pair = borderOptionMultipleOpposite[borderOptionMultipleExact];
                            room.Cells[i, j] = new Cell(pair.Item1, pair.Item2);
                        }
                    }

                    var cell = room.Cells[i, j];
                    if (i == 0)
                    {
                        cell.SetBorder(1);
                    }
                    else if(i == room.Cells.GetUpperBound(0))
                    {
                        cell.SetBorder(3);
                    }

                    if (j == 0)
                    {
                        cell.SetBorder(0);
                    }
                    else if (j == room.Cells.GetUpperBound(1))
                    {
                        cell.SetBorder(2);
                    }
                }
            }

            return room;
        }
    }
}
