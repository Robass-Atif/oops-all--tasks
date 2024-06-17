using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Pacman_with_Windows_form
{
  public   class Game
    {
        public static Image imageOfChar(char c)
        {
            if(c=='|'  || c=='#')
            {
                return Pacman_with_Windows_form.Properties.Resources.vertical;
            }
            if (c=='%')
            {
                return Pacman_with_Windows_form.Properties.Resources.horizontal;

            }
            if(c=='P'|| c=='p')
            {
                return Pacman_with_Windows_form.Properties.Resources.pacman_open;

            }
            if(c=='G')
            {
                return Pacman_with_Windows_form.Properties.Resources.ghost_red;

            }
            if(c==' ')
            {
                return Pacman_with_Windows_form.Properties.Resources.simplebox;

            }
            if(c=='.')
            {
                return Pacman_with_Windows_form.Properties.Resources.pallet;

            }
                return Pacman_with_Windows_form.Properties.Resources.simplebox;


        }
    }
}
