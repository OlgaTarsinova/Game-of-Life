using System;
using System.Collections.Generic;
using System.Text;

namespace Game_of_Life
{
  
        public abstract class RuleSet
        {
            //access modifiers which are used to restrict unwanted data manipulation by external programs or classes.
            protected int _maxX = 0;
            protected int _maxY = 0;
            protected int[,] _field;
            //parameters of the different variables; copy of the game field because cells are moving 
            /// <summary>
            /// Instantiates the RuleSet with a copy of the game field, and the maximum X,Y boundaries.
            /// </summary>
            /// <param name="field">int[][] game field</param>
            /// <param name="maxX">Maximum X boundary</param>
            /// <param name="maxY">Maximum Y boundary</param>
            public RuleSet(int[,] field, int maxX, int maxY)
            {
                _field = field;
                _maxX = maxX;
                _maxY = maxY;
            }
            /// <summary>
            /// Returns the number of neighbors for a cell at X,Y.
            /// </summary>
            /// <param name="x">X coordinate of cell to check</param>
            /// <param name="y">Y coordinate of cell to check</param>
            /// <returns>number of neighbors</returns>
            protected int GetNumberOfNeighbors(int x, int y)
            {
                // Returns the number of neighbors for a specific coordinate.
                int neighbors = 0;
                if (x + 1 < _maxX && _field[x + 1, y] == 1)
                {
                    neighbors++;
                }
                if (x - 1 >= 0 && _field[x - 1, y] == 1)
                {
                    neighbors++;
                }
                if (y + 1 < _maxY && _field[x, y + 1] == 1)
                {
                    neighbors++;
                }
                if (y - 1 >= 0 && _field[x, y - 1] == 1)
                {
                    neighbors++;
                }
                // diaganols
                if (x + 1 < _maxX && y + 1 < _maxY && _field[x + 1, y + 1] == 1)
                {
                    neighbors++;
                }
                if (x + 1 < _maxX && y - 1 >= 0 && _field[x + 1, y - 1] == 1)
                {
                    neighbors++;
                }
                if (x - 1 >= 0 && y + 1 < _maxY && _field[x - 1, y + 1] == 1)
                {
                    neighbors++;
                }
                if (x - 1 >= 0 && y - 1 >= 0 && _field[x - 1, y - 1] == 1)
                {
                    neighbors++;
                }
                return neighbors;
            }
            /// <summary>
            /// Executes one generation of the game field, causing cells to live, die, or give birth.
            /// </summary>
            public void Tick()
            {
                int[,] field2 = TickAlgorithm();
                // Copy field = field2.
                Array.Copy(field2, _field, field2.Length);
            }
            /// <returns>int[][] new game field</returns>
            protected abstract int[,] TickAlgorithm();
        }
    }

// при старте игры пользователь может в ручную вбить размер поля 
