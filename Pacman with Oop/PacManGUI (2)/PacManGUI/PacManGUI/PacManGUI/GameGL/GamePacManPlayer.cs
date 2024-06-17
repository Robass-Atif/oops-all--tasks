using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using PacManGUI;

namespace PacMan.GameGL
{
  public  class GamePacManPlayer : GameObject
    {
        
        public GamePacManPlayer(Image image,GameCell startCell):base (GameObjectType.PLAYER,image) {
            this.CurrentCell = startCell;
        }
        public void move(GameDirection direction) {
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell= currentCell.nextCell(direction);
            
            if (nextCell.currentGameObject.GameObjectType == GameObjectType.REWARD)
            {
                Game.score++;
            }
            this.CurrentCell = nextCell;
            if (currentCell != nextCell) {
                
                currentCell.setGameObject(Game.getBlankGameObject());

            }
          //  return nextCell;
        }

    }

    
}
