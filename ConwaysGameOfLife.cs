using System;
using System.Collections.Generic;
using System.Text;

namespace Game_of_Life
{
    public class ConwaysGameOfLife : RuleSet
    {
        public ConwaysGameOfLife(int[,] field, int maxX, int maxY)
            : base(field, maxX, maxY)
        {
        }

        //An override method provides a new implementation of a member that is inherited from a base class.
        protected override int[,] TickAlgorithm()
        {
            int[,] field2 = new int[_maxX, _maxY];
            for (int y = 0; y < _maxY; y++)
            {
                for (int x = 0; x < _maxX; x++)
                {
                    int neighbors = GetNumberOfNeighbors(x, y);
                    if (neighbors == 3)
                    {
                        // cell is born.
                        field2[x, y] = 1;
                        continue;
                    }
                    if (neighbors == 2 || neighbors == 3)
                    {
                        // cell continues.
                        field2[x, y] = _field[x, y];
                        continue;
                    }
                    // cell dies.
                    field2[x, y] = 0;
                }
            }
            return field2;
        }
    }
}
 

