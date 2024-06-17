using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Pacman_with_Windows_form
{
    public class GameGrid
    {
        private  GameCell[,] grid = new GameCell[23, 70];
        private int row;
        private int col;

        public GameCell[,] Grid { get => grid; set => grid = value; }
        public int Row { get => row; set => row = value; }
        public int Col { get => col; set => col = value; }

        public GameGrid(string fileName, int row, int col)
        {

            this.Row = row;
            this.Col = col;
            loadGrid(fileName);

        }

        public  void loadGrid(string fileName)
        {
            if (File.Exists(fileName))
            {

                StreamReader file = new StreamReader(fileName);
                string data;
                int row = 0;
                while ((data = file.ReadLine()) != null)
                {
                    for (int col = 0; col < data.Count(); col++)
                    {
                        GameObject objects= getGameObject(data[col]);
                        objects.img = Game.imageOfChar(objects.DisplayCharacter);
                        GameCell cell = new GameCell(row, col,objects);

                        Grid[row, col] = cell;

                    }
                    row++;
                }
                file.Close();
            }

            

        }
        
        public GameObject getGameObject(char letter)
        {
            if (letter == ' ') { return (new GameObject(letter,GameObjectType.None)); }
            else if (letter == '.') { return (new GameObject(letter, GameObjectType.Reward)); }
            else if (letter == 'P') { return (new GameObject(letter, GameObjectType.Player)); }
            else if (letter == 'G') { return (new GameObject(letter, GameObjectType.Enemy)); }
            else { return (new GameObject(letter, GameObjectType.Wall)); }

        }
        public GameCell gameCell1(int x, int y)
        {
             return this.grid[x, y];
            
        }
        
    }
}
