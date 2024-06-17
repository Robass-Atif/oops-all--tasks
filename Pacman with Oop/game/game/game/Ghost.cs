using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace game
{
   public abstract class Ghost:GameObject
    {
        char previous;
        public Ghost(Char displayCharcter, GameCell curr, GameObjectType g):base(displayCharcter,curr,g) 
        {
            
        }
        public Ghost(char displayCharacter, GameObjectType g):base (displayCharacter,g)
        {

        }
        public Ghost(Image img,GameCell cell):base (img,cell)
        {

        }
        public abstract void move();
    }
}
