using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman_with_Oop
{
   public class VerticalGhost:Ghost
    {
        GameDirection direction;

        public VerticalGhost(Char displayCharcter, GameCell curr, GameObjectType g,GameDirection d) : base(displayCharcter, curr, g)
        {
            this.direction = d;
        }
        public VerticalGhost(char displayCharacter, GameObjectType g) : base(displayCharacter, g)
        {
        }
        public override GameCell move()
        {
            GameCell next;
            if (direction == GameDirection.Up)
            {
                next = currentCell.nextCell(direction);
                if (next != null)
                {
                    next.Grid = currentCell.Grid;

                    return next;
                }
                else
                {
                    
                    direction = GameDirection.Down;
                    return null;

                }
            }
            else if (direction == GameDirection.Down)
            {
                next = currentCell.nextCell(direction);
                if (next != null)
                {
                    next.Grid = currentCell.Grid;
                    return next;
                }
                else
                {
                    direction = GameDirection.Up;
                    return null;
                }
            }
            return null;


        }
    }

    
}
