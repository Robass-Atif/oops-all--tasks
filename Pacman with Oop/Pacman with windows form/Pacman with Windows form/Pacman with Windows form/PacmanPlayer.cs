using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Pacman_with_Windows_form
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

    }
}
