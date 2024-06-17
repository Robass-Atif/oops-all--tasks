using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace game
{
  public  class Horizontal_Ghost:Ghost
    {

        public Horizontal_Ghost(Char displayCharcter, GameCell curr, GameObjectType g,GameDirection d):base(displayCharcter,curr,g)
        {
            this.direction = d;
        }
        public Horizontal_Ghost (char displayCharacter, GameObjectType g):base(displayCharacter,g)
        {
        }
        public Horizontal_Ghost(Image img, GameCell cell) : base(img, cell)
        {

        }
        public   GameDirection direction;
        
        public override void move()
        {
            
            if (direction == GameDirection.Left)
            {
                GameCell nextCell = this.CurrentCell.nextCell(direction);



                if (nextCell != null)
                {
                    nextCell.grid = this.currentCell.grid;

                    this.currentCell = nextCell;

                    this.currentCell.CurrentGameObject = Game.getBlankGameObject();
                }


            }
            else if (direction == GameDirection.Right)
            {
                GameCell nextCell = this.CurrentCell.nextCell(direction);



                if (nextCell != null)
                {
                    nextCell.grid = this.currentCell.grid;

                    this.currentCell = nextCell;

                    this.currentCell.CurrentGameObject = Game.getBlankGameObject();
                }



            }
        }

    }
}
