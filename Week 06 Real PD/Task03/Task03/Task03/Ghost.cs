using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
  public  class Ghost
    {
        public int x;
        public int y;
        public string ghostDirection;
        public char ghostCharacter;
       public float speed;
        public char previousItem;
        public float deltaChange;
       
        public Ghost(int x, int y, char ghostCharacter, string ghostDirection, float speed, char previous)
        {
            this.x = x;
            this.y = y;
            this.ghostCharacter = ghostCharacter;
            this.ghostDirection = ghostDirection;
            this.speed = speed;
            this.previousItem = previous;
            Grid.maze[x,y].value = ghostCharacter;
            
        }
        public void setDirection(string direction)
        {
            this.ghostDirection = direction;
        }
        public string getDirection()
        {
            return ghostDirection;
        }
        public void setDeltaToZero()
        {
            deltaChange = 0;
        }
        public void remove()
        {
            Grid.maze[x, y].value = ' ';
            Console.SetCursorPosition(y, x);
            Console.Write(" ");
        }
        public void changeDeltaSpeed()
        {
            deltaChange = deltaChange + speed;
        }
        public float getDelta()
        {
            return deltaChange;
        }

        public void move()
        {
            changeDeltaSpeed();

            if (Math.Floor(getDelta()) == 1)
            {
                if (ghostCharacter == 'H')
                {
                    moveHorizontal();
                }

                else if (ghostCharacter == 'V')
                {
                    moveVertical();
                }

                

                else if (ghostCharacter == 'C')
                {
                    moveRandom();
                }
                setDeltaToZero();
            }
        }
        public void moveHorizontal()
        {
            if (getDirection() == "Right")
            {
                if (Grid.maze[x , y+1].value == ' ')
                {
                    Grid.maze[x , y+1].value = ghostCharacter;
                    y++;
                }

                else
                {
                    ghostDirection = "Left";
                }
            }

            if (getDirection() == "Left")
            {
                if (Grid.maze[x , y-1].value == ' ')
                {
                    Grid.maze[x , y-1].value = ghostCharacter;
                    y--;
                }

                else
                {
                    ghostDirection = "Right";
                }
            }
        }
        public void moveVertical()
        {
            if (getDirection() == "Up")
            {
                if (Grid.maze[x-1, y ].value == ' ')
                {
                    x -= 1;
                }

                else
                {
                    ghostDirection = "Down";
                }
            }

            if (getDirection() == "Down")
            {
                if (Grid.maze[x+1, y ].value == ' ')
                {
                    x += 1;
                }

                else
                {
                    ghostDirection = "Up";
                }
            }
        }


        public void moveRandom()
        {
            int random = getRandom();
            if (random % 4 == 0)
            {
                if (Grid.maze[x + 1, y].value == ' ')
                {
                    x += 1;
                }
            }

            else if (random % 4 == 1)
            {
                if (Grid.maze[x - 1, y].value == ' ')
                {
                    x--;
                }
            }

            else if (random % 4 == 2)
            {
                if (Grid.maze[x, y + 1].value == ' ')
                {
                    y++;
                }
            }

            else if (random % 4 == 3)
            {
                if (Grid.maze[x, y - 1].value == ' ')
                {
                    y--;
                }
            }
        }

        public char getCharacter()
        {
            return ghostCharacter;
        }

        public int getRandom()
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next();
            return randomNumber;
        }
        public void draw()
        {
            Grid.maze[x, y].value = ghostCharacter;
            Console.SetCursorPosition(y, x);
            Console.Write(ghostCharacter);
        }
    }
}
