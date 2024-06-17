using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZInput;

namespace Pacman_with_Windows_form
{
    public partial class Form1 : Form
    {
        GameGrid grid = new GameGrid("maze.txt", 24, 70);
        GameCell start ;
        PacmanPlayer pacman ;


        public Form1()
        {
            InitializeComponent();
        }
        public PictureBox p1;
        public void printMaze(GameGrid grid)
        {
            for (int i = 0; i < 70; i++)
            {
                for (int j = 0; j < 24; j++)
                {
                    GameCell cell = grid.gameCell1(i, j);
                    cell.picture.Left = i * 20;
                    cell.picture.Top = j * 20;
                    cell.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                    p1 = cell.picture;
                    this.Controls.Add(p1);
                }

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            start = new GameCell(12, 22, grid);
             

            printMaze(grid);
        }
        public void createPacman(GameCell cell)
        {
            PictureBox p1 = new PictureBox();
            Image img = Pacman_with_Windows_form.Properties.Resources.pacman_open;
            p1.Image = img;
            p1.BackColor = Color.Transparent;
            p1.Width = 20;
            p1.Height = 20;
            p1.Top = 12*20; ;
            p1.Left = 22 * 20;
            pacman = new PacmanPlayer(img, cell);
            cell.grid.Grid[cell.X, cell.Y] = cell;
            this.Controls.Add(p1);

        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                moveGameObject(pacman, GameDirection.Up);
            }

            if (Keyboard.IsKeyPressed(Key.DownArrow))
            {
                moveGameObject(pacman, GameDirection.Down);

            }

            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                moveGameObject(pacman, GameDirection.Right);

            }

            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                moveGameObject(pacman, GameDirection.Left);

            }
        }

        // check pacman objecgt and paallet collisiojn
      public  static void moveGameObject(GameObject gameObject, GameDirection direction)
        {
            GameCell nextCell = gameObject.CurrentCell.nextCell(direction);
            if (nextCell != null)
            {
                nextCell.Grid = gameObject.CurrentCell.Grid;
                GameObject newGO = new GameObject(' ', GameObjectType.None);
                GameCell currentCell = gameObject.CurrentCell;
                //  GhostDL.clearGameCellContent(currentCell, newGO);
                gameObject.CurrentCell = nextCell;
                // here
                nextCell.grid.Grid[nextCell.X, nextCell.Y] = nextCell;
                // GhostDL.printGameObject(gameObject);
            }
        }
    }
}
