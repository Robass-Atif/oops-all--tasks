using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using EZInput;

namespace Task01.BL
{
    class GridBL
    {
        public int rowSize;
        public int columnSize;
        public Cell[,] maze;

        public Grid(int rowSize, int columnSize, string path)
        {
            this.columnSize = columnSize;
            this.rowSize = rowSize;
            maze = new Cell[72, 25];
            StreamReader file = new StreamReader(path);
            if (File.Exists(path))
            {
                int idx = 0;
                int x;
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    x = 0;
                    while (line[x] != ',')
                    {
                        char c = line[x];
                        Cell cell = new Cell(c, x, idx);
                        maze[x, idx] = cell;
                        x++;
                    }
                    idx++;
                }
            }
            file.Close();
        }

        public Cell getLeftCell(Cell cell)
        {
            return maze[cell.x - 1, cell.y];
        }

        public Cell getRightCell(Cell cell)
        {
            return maze[cell.x + 1, cell.y];
        }

        public Cell getDownCell(Cell cell)
        {
            return maze[cell.x, cell.y + 1];
        }

        public Cell getUpCell(Cell cell)
        {
            return maze[cell.x, cell.y - 1];
        }

        public Cell findPacman()
        {
            for (int i = 0; i < 24; i++)
            {
                for (int j = 0; j < 70; j++)
                {
                    if (this.maze[j, i].value == 'P')
                    {
                        return maze[j, i];
                    }
                }
            }
            return null;
        }

        public Cell findGhost(char ghostCharacter)
        {
            for (int i = 0; i < 24; i++)
            {
                for (int j = 0; j < 70; j++)
                {
                    if (this.maze[j, i].value == ghostCharacter)
                    {
                        return maze[j, i];
                    }
                }
            }
            return null;
        }

        public bool isStoppingCondition()
        {
            if (Keyboard.IsKeyPressed(Key.Escape))
            {
                string path = "New Text Document.txt";
                StreamWriter file = new StreamWriter(path, false);
                if (File.Exists(path))
                {
                    for (int i = 0; i < 24; i++)
                    {
                        for (int j = 0; j < 70; j++)
                        {
                            file.Write(maze[j, i].value);
                        }
                        file.WriteLine(",");
                    }
                }
                file.Flush();
                file.Close();
                return true;
            }
            return false;
        }

        public void draw()
        {
            for (int i = 0; i < 24; i++)
            {
                for (int j = 0; j < 70; j++)
                {
                    Console.Write(maze[j, i].value);
                }
                Console.WriteLine();
            }
        }
    }
}
