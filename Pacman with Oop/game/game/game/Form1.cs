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

namespace game
{
    public partial class Form1 : Form
    {
        GameGrid grid = new GameGrid("maze.txt", 24, 70);
        GameCell start;
        PacmanPlayer pacman;
        GameCell startGhost;
        Horizontal_Ghost HGhost;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GameObject objects= grid.getGameObject('p');

            start = new GameCell(12, 22, objects);
            start.grid = grid;
            createPacman(start);
            startGhost = new GameCell(15, 45, grid);
            createGhost(startGhost);

            printMaze(grid);

        }
        public void createPacman(GameCell cell)
        {
            //PictureBox p1 = new PictureBox();
            //Image img = game.Properties.Resources.pacman_open;
            //p1.Image = img;
            //p1.BackColor = Color.Transparent;
            //p1.Width = 15;
            //p1.Height = 15;
            //p1.Top = 22 * 15; ;
            //p1.Left = 12 * 15;
            
            //cell.picture.Image = img;
          

            pacman = new PacmanPlayer(img, cell);
            cell.grid.Grid[cell.X, cell.Y] = cell;
            this.Controls.Add(p1);

        }
        public void createGhost(GameCell cell)
        {
            PictureBox p1 = new PictureBox();
            Image img = game.Properties.Resources.pacman_open;
            p1.Image = img;
            p1.BackColor = Color.Transparent;
            p1.Width = 15;
            p1.Height = 15;
            p1.Top = 22 * 15; ;
            p1.Left = 12 * 15;

            cell.picture.Image = img;

            HGhost=new Horizontal_Ghost(img, cell);
            cell.grid.Grid[cell.X, cell.Y] = cell;
            this.Controls.Add(p1);
        }
        PictureBox p1 = new PictureBox();
        public void printMaze(GameGrid grid)
        {
            for (int i = 0; i < 24; i++)
            {
                for (int j = 0; j < 70; j++)
                {
                    GameCell cell = grid.gameCell1(i, j);
                    cell.picture.Left = j * 15;
                    cell.picture.Top = i * 15;
                    cell.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                    p1 = cell.picture;
                    this.Controls.Add(p1);
                }

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                pacman.moveGameObject( GameDirection.Up);
            }

            if (Keyboard.IsKeyPressed(Key.DownArrow))
            {
                pacman.moveGameObject( GameDirection.Down);

            }

            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                pacman.moveGameObject( GameDirection.Right);

            }

            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
              pacman.moveGameObject( GameDirection.Left);

            }
           // GhostDL.move();
        }
        //public static void moveGameObject(GameObject gameObject, GameDirection direction)
        //{
        //    GameCell nextCell = gameObject.CurrentCell.nextCell(direction);
        //    if (nextCell != null)
        //    {
        //        nextCell.Grid = gameObject.CurrentCell.Grid;
        //        GameObject newGO = new GameObject(' ', GameObjectType.None);
        //        newGO.img = game.Properties.Resources.simplebox;
        //        GameCell currentCell = gameObject.CurrentCell;
                
        //        gameObject.CurrentCell = nextCell;
        //        nextCell.grid.Grid[nextCell.X, nextCell.Y] = nextCell;

               
        //    }
        //}

    }
}
