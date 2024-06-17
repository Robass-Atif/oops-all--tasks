using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacMan.GameGL;
using System.Windows.Forms;
using System.Drawing;

namespace PacManGUI
{
  public  class Horizontal_Ghost:Ghost
    {
        public Horizontal_Ghost(Image image, GameCell startCell) : base(GameObjectType.ENEMY, image)
        {
            this.CurrentCell = startCell;
            this.direction = GameDirection.Right;
           
            objects = Game.getBlankGameObject();
            a = Game.getBlankGameObject();
        }

        public   GameDirection direction;
        public GameObject objects;
        public GameCell previous;
        public GameObject a;
        
        public override void move()
        {
            
            if (direction == GameDirection.Left)
            {
                GameCell currentCell = this.CurrentCell;
                GameCell nextCell = currentCell.nextCell(direction);
                a = nextCell.currentGameObject;
                if (nextCell.currentGameObject.GameObjectType == GameObjectType.PLAYER)
                {
                    Game.flag = true;
                }
                else
                {
                    this.CurrentCell = nextCell;
                    if (currentCell != nextCell)
                    {
                        currentCell.setGameObject(objects);
                        objects = nextCell.currentGameObject;
                        objects = a;


                    }
                    else
                    {
                        direction = GameDirection.Right;
                        a = Game.getBlankGameObject();

                    }
                }

            }
            else if (direction == GameDirection.Right)
            {

                GameCell currentCell = this.CurrentCell;
                GameCell nextCell = currentCell.nextCell(direction);
                if (nextCell.currentGameObject.GameObjectType == GameObjectType.PLAYER)
                {
                    Game.flag = true;
                }
                else
                {
                    a = nextCell.currentGameObject;
                    this.CurrentCell = nextCell;
                    if (currentCell != nextCell)
                    {
                        currentCell.setGameObject(objects);

                        objects = nextCell.currentGameObject;
                        objects = a;


                    }
                    else
                    {
                        direction = GameDirection.Left;
                        a = Game.getBlankGameObject();


                    }
                }
            }


        }

    }
}
