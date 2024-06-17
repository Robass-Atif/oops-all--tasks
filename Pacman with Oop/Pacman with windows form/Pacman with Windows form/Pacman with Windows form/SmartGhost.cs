using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman_with_Windows_form
{
  public  class SmartGhost:Ghost
    {

        public SmartGhost(Char displayCharcter, GameCell curr, GameObjectType g) : base(displayCharcter, curr, g)
        {

        }
        public SmartGhost(char displayCharacter, GameObjectType g) : base(displayCharacter, g)
        {
        }
        public override GameCell move()
        {
            GameCell next;
            double[] distance = new double[4];
           GameCell player=null ;
            if (player != null)
            {
                distance[0] = calculateDistance(this.CurrentCell.X - 1, this.CurrentCell.Y, player);
                distance[1] = calculateDistance(this.CurrentCell.X + 1, this.CurrentCell.Y, player);
                distance[2] = calculateDistance(this.CurrentCell.X, this.CurrentCell.Y - 1, player);
                distance[3] = calculateDistance(this.CurrentCell.X, this.CurrentCell.Y + 1, player);

                if (distance[0] <= distance[1] && distance[0] <= distance[2] && distance[0] <= distance[3])
                {
                    next = currentCell.nextCell(GameDirection.Up);
                    return next;
                }
                else if (distance[1] <= distance[0] && distance[1] <= distance[2] && distance[1] <= distance[3])
                {
                    next = currentCell.nextCell(GameDirection.Down);
                    return next;
                }
                else if (distance[2] <= distance[0] && distance[2] <= distance[1] && distance[2] <= distance[3])
                {
                    next = currentCell.nextCell(GameDirection.Left);
                    return next;
                }
                else
                {
                    next = currentCell.nextCell(GameDirection.Right);
                    return next;
                }
            }
            return null;

        }
        //public static GameCell playerLocation(GameGrid g)
        //{
            
        //    for(int i=0;i<24;i++)
        //    {
        //        for(int j=0;j<70;j++)
        //        {
        //           if( g.Grid[i, j].CurrentGameObject.DisplayCharacter == 'p')
        //            {
        //                return g.Grid[i, j];
        //            }
                    
        //        }
        //    }
        //    return null;

        //}

       public static double calculateDistance(int x,int y,GameCell p)
        {
            return Math.Sqrt(Math.Pow((p.X - x), 2) + Math.Pow((p.Y - y), 2));
        }
    }
}
