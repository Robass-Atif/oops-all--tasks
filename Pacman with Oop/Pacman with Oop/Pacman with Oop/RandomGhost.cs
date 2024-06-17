using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman_with_Oop
{
   public  class RandomGhost:Ghost
    {
        GameCell next;
        public RandomGhost(Char displayCharcter, GameCell curr, GameObjectType g) : base(displayCharcter, curr, g)
        {
            
        }
        public RandomGhost(char displayCharacter, GameObjectType g) : base(displayCharacter, g)
        {
        }
        public override GameCell move()
        {
            int value = ghostDirection();
            if(value==0)
            {
                next = currentCell.nextCell(GameDirection.Left);
                if (next != null)
                {
                    next.Grid = currentCell.Grid;

                    return next;
                }
                else
                {
                   
                    return null;

                }
            }
            else if(value==1)
            {
                next = currentCell.nextCell(GameDirection.Right);
                if (next != null)
                {
                    next.Grid = currentCell.Grid;

                    return next;
                }
                else
                {
                    return null;
                }

            }
            else if(value==2)
            {
                next = currentCell.nextCell(GameDirection.Up);
                if (next != null)
                {
                    next.Grid = currentCell.Grid;

                    return next;
                }
                else
                {
                    
                    return null;

                }
            }
            else
            {
                next = currentCell.nextCell(GameDirection.Down);
                if (next != null)
                {
                    next.Grid = currentCell.Grid;

                    return next;
                }
                else
                {
                    
                    return null;

                }
            }
        }
        static int ghostDirection()
        {
            Random r = new Random();
            int value = r.Next(4);
            return value;
        }
    }
}
