using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EZInput;
namespace Task03
{
  public  class Pacman
    {
        public int x;
        public int y;
        public int score;
      

        public Pacman(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.score = 0;
         
            Grid.maze[x, y].value = 'P';
        }

        public void remove()
        {
            Grid.maze[x, y].value = ' ';
            Console.SetCursorPosition(y, x);
            Console.Write(' ');
        }

        public void printScore()
        {
            Console.SetCursorPosition(0, 30);
            Console.Write("Score: " + score);
        }

        public void move()
        {
            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                if (Grid.maze[x, y-1].value != '#')
                {
                    y--;
                }
            }

            else if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                if (Grid.maze[x, y+1].value != '#')
                {
                    y++;
                }
            }

            else if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                if (Grid.maze[x-1, y].value != '#')
                {
                    x--;
                }
            }

            else if (Keyboard.IsKeyPressed(Key.DownArrow))
            {
                if (Grid.maze[x+1, y].value != '#')
                {
                    x++;
                }
            }
        }

        public void draw()
        {
            if (Grid.maze[x, y] != null)
            {
                Grid.maze[x, y].value = 'P';
                Console.SetCursorPosition(y, x);
                Console.Write("P");
            }
        }
        public void test1()
        {
            if(Grid.maze[x,y+1].value=='%')
            {
                Grid.maze[x, y + 1].value = ' ';
                score++;
            }
        }

    }
}
