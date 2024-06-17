using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using EZInput;
namespace Task03
{
  public  class Grid
    {
        public static Cell[,] maze=new Cell[24,71];
        public static int rowSize;
        public static int colSize;
        public Grid(int row,int col,string path)
        {
            rowSize = row;
            colSize = col;
            StreamReader file = new StreamReader(path);
            string line;
            int row1 = 0;
            if(File.Exists(path))
            {
                while ((line=file.ReadLine()) != null)
                {
                    for(int i=0;i<colSize;i++)
                    {
                        char v = line[i];
                        Cell c = new Cell(row1, i,v);
                        maze[row1, i] = c;
                    }
                    row1++;
                }
                file.Close();
            }
            else
            {
                Console.WriteLine("Enter invalid input ");
            }

        }
        public static Cell getLeftCell(Cell c)
        {
            c.y = c.y - 1;
            return c;
        }
        public static Cell getUpCell(Cell c)
        {
            c.x = c.x - 1;
            return c;
        }
        public static Cell getRightCell(Cell c)
        {
            c.x = c.x +1;
            return c;
        }
        public static Cell getDownCell(Cell c)
        {
            c.x = c.x + 1;
            return c;
        }
        public Cell findPacman()
        {
            for(int i=0;i<rowSize;i++)
            {
                for(int j=0;j<colSize;j++)
                {
                    if(maze[i,j].value=='p')
                    {
                        return maze[i,j];
                    }
                }
            }
            return null;
        }
        public static Cell findGhost(char ghostCharacter)
        {
            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < colSize; j++)
                {
                    if (maze[i, j].value == ghostCharacter)
                    {
                        return maze[i, j];
                    }
                }
            }
            return null;
        }

        public static void draw()
        {
            for(int i=0;i<rowSize;i++)
            {
                for(int j=0;j<colSize;j++)
                {
                    Console.Write(maze[i, j].value);
                }
                Console.WriteLine();
            }
        }
        public static bool isStoppingCondition()
        {
            if (Keyboard.IsKeyPressed(Key.Escape))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void test()
        {
            maze[22, 13].value = '%';
        }
    }
}
