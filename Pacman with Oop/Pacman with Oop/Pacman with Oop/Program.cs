using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EZInput;


namespace Pacman_with_Oop
{
    class Program
    {
        static void Main(string[] args)
        {
            GameGrid grid = new GameGrid("maze.txt", 24, 70);
            GameCell start = new GameCell(12, 22, grid);
            GameCell horizontal = new GameCell(22, 30, grid);
            Horizontal_Ghost h = new Horizontal_Ghost('G', horizontal, GameObjectType.Enemy,GameDirection.Left);
            GameCell vc = new GameCell(21, 67, grid);
            VerticalGhost v = new VerticalGhost('G',vc,GameObjectType.Enemy,GameDirection.Up) ;
            PacmanPlayer pacman = new PacmanPlayer('p', start);
            GameCell rc = new GameCell(18, 23, grid);
            RandomGhost r = new RandomGhost('G', rc, GameObjectType.Enemy);
            GameCell sc = new GameCell(11, 12, grid);
            SmartGhost s = new SmartGhost('G', sc, GameObjectType.Enemy);
            grid.printMaze();
           
               GhostDL.printGameObject(h);
            GhostDL.printGameObject(pacman);
            GhostDL.printGameObject(v);
            GhostDL.printGameObject(s);

            GhostDL.ghosts.Add(h);
            GhostDL.ghosts.Add(v);
            GhostDL.ghosts.Add(r);
            GhostDL.ghosts.Add(s);



            bool gameRunning = true;
            while (gameRunning)
            {
                Thread.Sleep(90);
                if (Keyboard.IsKeyPressed(Key.UpArrow))
                {
                   moveGameObject(pacman, GameDirection.Up);
                }

                if (Keyboard.IsKeyPressed(Key.DownArrow))
                {
                    moveGameObject( pacman,GameDirection.Down);

                }

                if (Keyboard.IsKeyPressed(Key.RightArrow))
                {
                    moveGameObject(pacman, GameDirection.Right);

                }

                if (Keyboard.IsKeyPressed(Key.LeftArrow))
                {
                    moveGameObject(pacman, GameDirection.Left);

                }
                GhostDL.move();
            }
        }

        static void moveGameObject(GameObject gameObject, GameDirection direction)
        {
            GameCell nextCell = gameObject.CurrentCell.nextCell(direction);
            if (nextCell != null)
            {
                nextCell.Grid = gameObject.CurrentCell.Grid;
                GameObject newGO = new GameObject( ' ',GameObjectType.None);
                GameCell currentCell = gameObject.CurrentCell;
              GhostDL.  clearGameCellContent(currentCell, newGO);
                gameObject.CurrentCell = nextCell;
                nextCell.grid.Grid[nextCell.X,nextCell.Y] = nextCell;
               GhostDL. printGameObject(gameObject);
            }
        }


    }
 }
