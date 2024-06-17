using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
   public  class GhostDL
    {
        public static List<Ghost> ghosts = new List<Ghost>();
        public static void move()
        {
            for(int i=0;i<ghosts.Count;i++)
            {
              
                ghosts[i].move();
                //if (nextCell != null)
                //{
                //    GameObject newGO = new GameObject(' ', GameObjectType.None);
                //    GameCell currentCell = ghosts[i].CurrentCell;
                    
                //    ghosts[i].CurrentCell = nextCell;
                    

                //}
            }
        }
        

        
        
    }
}
