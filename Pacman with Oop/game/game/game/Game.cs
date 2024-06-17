using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace game
{
  public   class Game
    {
        public static GameObject getBlankGameObject()
        {
            GameObject blankGameObject = new GameObject(GameObjectType.None, game.Properties.Resources.simplebox);
            return blankGameObject;
        }
        public static Image imageOfChar(char c)
        {
            if(c=='|'  )
            {
                return game.Properties.Resources.vertical;
            }
            if (c=='%'|| c=='#')
            {
                return game.Properties.Resources.horizontal;

            }
            if(c=='P'|| c=='p')
            {
                return game.Properties.Resources.pacman_open;

            }
            if(c=='G')
            {
                return game.Properties.Resources.ghost_red;

            }
            if(c==' ')
            {
                return game.Properties.Resources.simplebox;

            }
            if(c=='.')
            {
                return game.Properties.Resources.pallet;

            }
                return game.Properties.Resources.simplebox;


        }
    }
}
