using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\DELL\\Desktop\\OOPs task\\Week 06 Real PD\\Task03\\Task03\\Task03\\abc.txt";
            Grid mazeGrid = new Grid(24, 71, path);

            Grid.test();
            Pacman player = new Pacman(9, 13);

            Ghost ghost1 = new Ghost(15, 39, 'H', "Left", 0.1F, ' ' );
            Ghost ghost2 = new Ghost(20, 57, 'V', "Up", 0.2F, ' ');
            //Ghost ghost3 = new Ghost(19, 26, 'R', "Up", 0.1F, ' ', mazeGrid);
            Ghost ghost4 = new Ghost(18, 21, 'C', "Up", 0.5F, ' ');

            List<Ghost> enemies = new List<Ghost>();
            enemies.Add(ghost1);
            enemies.Add(ghost2);
            //enemies.Add(ghost3);
            enemies.Add(ghost4);

            Grid.draw();
            player.draw();

            bool gameRunning = true;

            while (gameRunning == true)
            {
                Thread.Sleep(90);
                player.test1();
                player.printScore();
                player.remove();
                player.move();
                player.draw();

                foreach (Ghost g in enemies)
                {
                    g.remove();
                    g.move();
                    g.draw();
                }

                if (Grid.isStoppingCondition())
                {
                    gameRunning = false;
                }
            }
            Console.ReadKey();

        }
    }
}
