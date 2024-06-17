using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace game
{
  public  class PacmanPlayer:GameObject
    {
      public  PacmanPlayer(char dispalyCharacter, GameCell curr ):base(dispalyCharacter,curr,GameObjectType.Player)
        {
            //curr.grid.Grid[curr.X,curr.Y] = curr;
        }
        public PacmanPlayer(Image img,GameCell Cell):base(img,Cell)
        {

        }
        public  void moveGameObject( GameDirection direction)
        {
            
            GameCell nextCell = this.CurrentCell.nextCell(direction);
            


            if (nextCell != null)
            {
                nextCell.grid = this.currentCell.grid;

                nextCell = this.currentCell;

                this.currentCell.CurrentGameObject = Game.getBlankGameObject();
            }
            
        }

    }
}
