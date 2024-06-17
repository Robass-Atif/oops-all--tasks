using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace game
{
  public   class GameCell
    {
        protected int x;
        protected int y;
        protected GameObject currentGameObject;
        public  PictureBox picture;
        public const int height = 15;
        public const int width = 15;
        
        public GameGrid grid;
        
        public GameCell() { }
        public GameCell(int x,int y,GameGrid grid)
        {
            this.x = x;
            this.y = y;
            this.Grid = grid;
            this.picture = new PictureBox();
            picture.Width = width;
            picture.Height = height;
        }
        public GameCell(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public  GameCell(int x,int y,GameObject game)
        {
            picture = new PictureBox();
            this.x = x;
            this.y = y;
            this.currentGameObject = game;
            this.picture.Image = game.img;
            picture.Width = width;
            picture.Height = height;
           
        }

        public int Y { get => y; set => y = value; }
        public int X { get => x; set => x = value; }
        public GameObject CurrentGameObject { get => currentGameObject; set => currentGameObject = value; }
        public GameGrid Grid { get => grid; set => grid = value; }

        public  GameCell nextCell(GameDirection direction)
        {
            GameCell cell = new GameCell();
            if (direction==GameDirection.Right)
            {
                cell=grid.Grid[this.x, this.y + 1]; 
            }
            else if (direction == GameDirection.Left && this.y > 0)
            {
                cell = grid.Grid[this.x, this.y-1];

            }
            else if (direction == GameDirection.Up)
            {
                cell = grid.Grid[this.x-1, this.y ];

            }
            else if (direction == GameDirection.Down)
            {
                cell = grid.Grid[this.x+1, this.y];

            }
            if (okTOMove(cell)) { return cell; }
            return this;
        }
        public bool okTOMove(GameCell cell)
        {
            if(cell.currentGameObject.Type==GameObjectType.None || cell.currentGameObject.Type==GameObjectType.Reward || cell.CurrentGameObject.Type==GameObjectType.Player)
            {
                return true;
            }
            return false;
        }

    }
}
