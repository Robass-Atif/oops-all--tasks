using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Task01.BL;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\DELL\\Desktop\\OOPs task\\Week 06 Real PD\\Task01\\Task01\\abc.txt";
            GridBL mazeGrid = new GridBL(24, 71, path);
            //Player
            PacmanBL player = new PacmanBL(9, 32, mazeGrid);
            //Ghost
            GhostBL ghost1 = new GhostBL(15, 39, 'H', "left", 0.1F, ' ', mazeGrid);
            GhostBL ghost2 = new GhostBL(20, 57, 'V', "up", 0.2F, ' ', mazeGrid);
            GhostBL ghost3 = new GhostBL(19, 26, 'R', "up", 1F, ' ', mazeGrid);
            GhostBL ghost4 = new GhostBL(18, 21, 'C', "up", 0.5F, ' ', mazeGrid);
            //list
            List<GhostBL> enemies = new List<GhostBL>();
            enemies.Add(ghost1);
            enemies.Add(ghost2);
            enemies.Add(ghost3);
            enemies.Add(ghost4);

            mazeGrid.drawMaze();
            player.draw();

            bool gameRunnng = true;
            while(gameRunnng)
            {
                Thread.Sleep(90);

                player.printScore();
                player.remove();
                player.move();
                player.draw();

                foreach(GhostBL g in enemies)
                {
                    g.remove();
                    g.move();
                    g.draw();
                }
                if(mazeGrid.isStoppingCondition())
                {
                    gameRunnng = false;
                }
            }

            Console.ReadKey();
        }
    }
}
