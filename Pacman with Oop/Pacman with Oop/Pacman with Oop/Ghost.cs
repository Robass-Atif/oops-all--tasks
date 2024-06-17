using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman_with_Oop
{
   public abstract class Ghost:GameObject
    {
        public Ghost(Char displayCharcter, GameCell curr, GameObjectType g):base(displayCharcter,curr,g) 
        {
            
        }
        public Ghost(char displayCharacter, GameObjectType g):base (displayCharacter,g)
        {

        }
        public abstract GameCell move();
    }
}
