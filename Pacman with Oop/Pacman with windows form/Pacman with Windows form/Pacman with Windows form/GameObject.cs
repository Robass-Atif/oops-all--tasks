using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace Pacman_with_Windows_form
{
  public   class GameObject
    {
        protected char displayCharacter;
        protected GameCell currentCell;
        protected GameObjectType type;
        public Image img;
        public GameObject(Image img,GameCell cell)
        {
            this.img = img;
            this.currentCell = cell;
        }
        public GameObject(Char displayCharcter,GameCell curr,GameObjectType g)
        {
            this.Type = g;
            this.displayCharacter = displayCharcter;
            this.currentCell = curr;
        }
        public GameObject(char displayCharacter,GameObjectType g)
        {
            this.Type = g;
            this.displayCharacter = displayCharacter;
        }

        public GameCell CurrentCell { get => currentCell; set => currentCell = value; }
        public char DisplayCharacter { get => displayCharacter; set => displayCharacter = value; }
        public GameObjectType Type { get => type; set => type = value; }


    }
}
