using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Task01.BL
{
   public class PacmanBL
    {
        public int x;
        public int y;
        public int score;
        GridBL mazeGrid;
        public PacmanBL(int x,int y,GridBL mazeGrid)
        {
            this.x = x;
            this.y = y;
            this.mazeGrid = mazeGrid;
        }
        public void remove()
        {

            Console.SetCursorPosition(y, x);
            Console.Write(" ");

        }
        public void draw()
        {

        }
        public void moveLeft(CellBL current,CellBL next)
        {

        }
        public void moveRight(CellBL current, CellBL next)
        {

        }
        public void moveDown(CellBL current, CellBL next)
        {

        }
        public void moveUp(CellBL current, CellBL next)
        {

        }
        public void move()
        {

        }
        public void printScore()
        {

        }

    }
}
