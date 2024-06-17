using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman_with_Oop
{
   public  class GhostDL
    {
        public static List<Ghost> ghosts = new List<Ghost>();
        public static void move()
        {
            for(int i=0;i<ghosts.Count;i++)
            {
              
              GameCell nextCell=  ghosts[i].move();
                if (nextCell != null)
                {
                    GameObject newGO = new GameObject(' ', GameObjectType.None);
                    GameCell currentCell = ghosts[i].CurrentCell;
                    GhostDL.clearGameCellContent(currentCell, newGO);
                    ghosts[i].CurrentCell = nextCell;
                    GhostDL.printGameObject(ghosts[i]);

                }
            }
        }
        static void moveGameObject(GameObject gameObject, GameDirection direction)
        {
            GameCell nextCell = gameObject.CurrentCell.nextCell(direction);
            if (nextCell != null)
            {
                nextCell.Grid = gameObject.CurrentCell.Grid;
                GameObject newGO = new GameObject(' ', GameObjectType.None);
                GameCell currentCell = gameObject.CurrentCell;
                GhostDL.clearGameCellContent(currentCell, newGO);
                gameObject.CurrentCell = nextCell;
                GhostDL.printGameObject(gameObject);
            }
        }

        public static void printGameObject(GameObject object1)
        {
            Console.SetCursorPosition(object1.CurrentCell.Y, object1.CurrentCell.X);
            Console.Write( object1.DisplayCharacter);

        }
        public static void clearGameCellContent(GameCell gameCell, GameObject newGameObject)
        {
            gameCell.CurrentGameObject = newGameObject;
            Console.SetCursorPosition(gameCell.Y, gameCell.X);
            Console.Write(newGameObject.DisplayCharacter);

        }
    }
}
