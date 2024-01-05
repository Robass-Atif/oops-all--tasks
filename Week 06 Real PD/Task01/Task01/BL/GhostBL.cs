using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01.BL
{
    public class GhostBL
    {
        public int x;
        public int y;
        string ghostDirection;
        char ghostCharacter;
        float speed;
        char previousItem;
        float deltaChange;
        GridBL mazeGrid;
        public GhostBL(int x, int y, char ghostCharacter, string ghostDirection, float speed, char previousItem, GridBL mazeGrid)
        {
            this.x = x;
            this.y = y;
            this.ghostCharacter = ghostCharacter;
            this.ghostDirection = ghostDirection;
            this.speed = speed;
            this.previousItem = previousItem;

            this.mazeGrid = mazeGrid;
        }
        public void changeDelta()
        {
            deltaChange = deltaChange + speed;

        }
        public float getDelta()
        {
            return deltaChange;
        }
        public void move()
        {

            if (ghostCharacter == 'H')
            {
                moveHorizontal();
            }

            else if (ghostCharacter == 'V')
            {
                moveVertical();
            }

            else if (ghostCharacter == 'R')
            {
                moveRandom();
            }

        }
        public void moveHorizontal()
        {
            if (ghostDirection == "left")
            {
                if (mazeGrid.maze[x, y + 1].value == ' ' || mazeGrid.maze[x, y + 1].value == '-' || mazeGrid.maze[x, y + 1].value == 'P')
                {
                    y++;
                    previousItem = mazeGrid.maze[x, y].value;
                }
                else if (mazeGrid.maze[x, y + 1].value == '|' || mazeGrid.maze[x, y + 1].value != '%' || mazeGrid.maze[x, y + 1].value == '#')
                {

                    ghostDirection = "right";

                }
            }
            if (ghostDirection == "right")
            {
                if (mazeGrid.maze[x, y - 1].value == ' ' || mazeGrid.maze[x, y - 1].value == '-' || mazeGrid.maze[x, y - 1].value == 'P')
                {
                    y--;
                    previousItem = mazeGrid.maze[x, y].value;
                }
                else if (mazeGrid.maze[x, y - 1].value == '|' || mazeGrid.maze[x, y - 1].value == '%' || mazeGrid.maze[x, y - 1].value == '#')
                {
                    ghostDirection = "left";
                }
            }
        }
        public void setDirection(string Direction)
        {
            ghostDirection = Direction;
        }
        public string getDirection()
        {
            return ghostDirection;
        }

        public void remove()
        {
            Console.SetCursorPosition(y, x);
            Console.Write(previousItem);
        }
        public void draw()
        {
            Console.SetCursorPosition(y, x);
            Console.Write(ghostCharacter);
        }
        public void getCharacter()
        {

        }
        public void setDeltaZero()
        {
            deltaChange = 0;
        }
        public void moveRandom()
        {
            int value = generateRandom();
            if (value == 1)
            {
                if (mazeGrid.maze[x, y + 1].value == ' ' || mazeGrid.maze[x, y + 1].value == '-' || mazeGrid.maze[x, y + 1].value == 'P')
                {
                    y++;
                    previousItem = mazeGrid.maze[x, y].value;
                }
            }
            else if (value == 2)
            {
                if (mazeGrid.maze[x, y - 1].value == ' ' || mazeGrid.maze[x, y - 1].value == '-' || mazeGrid.maze[x, y - 1].value == 'P')
                {
                    y--;
                    previousItem = mazeGrid.maze[x, y].value;

                }
            }
            else if (value == 3)
            {
                if (mazeGrid.maze[x + 1, y].value == ' ' || mazeGrid.maze[x + 1, y].value == '-' || mazeGrid.maze[x + 1, y].value == 'P')
                {
                    x++;
                    previousItem = mazeGrid.maze[x, y].value;

                }
            }
            else if (value == 4)
            {
                if (mazeGrid.maze[x - 1, y].value == ' ' || mazeGrid.maze[x - 1, y].value == '-' || mazeGrid.maze[x + 1, y].value == 'P')
                {
                    x--;
                    previousItem = mazeGrid.maze[x, y].value;

                }
            }
        }
        public void moveSmart()
        {

        }
        public double distance(CellBL current, CellBL pacman)
        {
            
            return  Math.Sqrt(Math.Pow((current.x - pacman.x), 2) + Math.Pow((current.y - pacman.y), 2));
        }
        public  int generateRandom()
        {
            Random r = new Random();
            int value = r.Next(5);
            return value;
        }
        public void moveVertical()
        {
            if (ghostDirection == "up")
            {
                if (mazeGrid.maze[x - 1, y].value == ' ' || mazeGrid.maze[x - 1, y].value == '-' || mazeGrid.maze[x + 1, y].value == 'P')
                {
                    x--;
                    previousItem = mazeGrid.maze[x, y].value;
                }
                else
                {

                    ghostDirection = "down";

                }
            }
            if (ghostDirection == "down")
            {
                if (mazeGrid.maze[x + 1, y].value == ' ' || mazeGrid.maze[x + 1, y].value == '-' || mazeGrid.maze[x + 1, y].value == 'P')
                {
                    x++;
                    previousItem = mazeGrid.maze[x, y].value;
                }
                else
                {
                    ghostDirection = "up";

                }
            }
        }
        
    }
}
