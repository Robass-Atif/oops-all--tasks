using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman_with_Windows_form
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
     public   GameDirection direction;
        
        public override GameCell move()
        {
            GameCell next;
           if(direction==GameDirection.Left)
            {
                next = currentCell.nextCell(direction);
                if(next!=null)
                {
                    next.Grid = currentCell.Grid;

                    return next; 
                }
                else
                {
                    direction = GameDirection.Right;
                    return null;

                }
            }
           else if(direction==GameDirection.Right)
            {
                next = currentCell.nextCell(direction);
                if (next != null)
                {
                    next.Grid = currentCell.Grid;
                    return next;
                }
                else
                {
                    direction = GameDirection.Left;
                    return null;
                }
            }
                    return null;


        }

    }
}
