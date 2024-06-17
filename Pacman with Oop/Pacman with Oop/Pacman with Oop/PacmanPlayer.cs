using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman_with_Oop
{
  public  class PacmanPlayer:GameObject
    {
      public  PacmanPlayer(char dispalyCharacter, GameCell curr ):base(dispalyCharacter,curr,GameObjectType.Player)
        {
            //curr.grid.Grid[curr.X,curr.Y] = curr;
        }

    }
}
