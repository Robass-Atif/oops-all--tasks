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

namespace Pacman_Game
{
    public partial class Form1 : Form
    {
        PictureBox player;
        ProgressBar playerHealth;
        public int metroidTimer = 0;
        public int metroidTime = 10;
        public bool isEnemyBlackActive = true;
        public bool isEnemyBoxActive = true;

        public List<PictureBox> mettroids = new List<PictureBox>();
        public List<PictureBox> enemyFires = new List<PictureBox>();
        public string enemyBlackDirection = "right";
        public string enemydirection = "left";
        public List<PictureBox> fires = new List<PictureBox>();
        public PictureBox enemyBox;
        public PictureBox enemyBlack;
        public int timer3 = 0;
        public int timer2 = 0;
        public int enemyTime = 5;
        public int timer = 0;
        private Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }
        public void start()
        {
            this.Controls.Clear();
            timer1.Enabled = true;

            timer3 = 0;
         timer2 = 0;
         enemyTime = 5;
         timer = 0;
        isEnemyBoxActive = true;
            isEnemyBlackActive = true;
            enemydirection = "left";
            enemyBlackDirection = "right";
            metroidTimer = 0;
            metroidTime = 10;
            
            createPlayer();
            enemyBlack = createEnemy(Pacman_Game.Properties.Resources.enemyBlack2);
            enemyBox = createEnemy(Pacman_Game.Properties.Resources.enemyGreen2);
            this.Controls.Add(enemyBlack);
            this.Controls.Add(enemyBox);
           
        }
        
        
       


        private void Form1_Load(object sender, EventArgs e)
        {
            createPlayer();

            enemyBlack = createEnemy(Pacman_Game.Properties.Resources.enemyBlack2);
            enemyBox = createEnemy(Pacman_Game.Properties.Resources.enemyGreen2);
            this.Controls.Add(enemyBlack);
            this.Controls.Add(enemyBox);

        }
        public void createPlayer()
        {
            playerHealth = new ProgressBar();
            playerHealth.Enabled = true;
            playerHealth.Visible = true;
            playerHealth.Value = 100;
             player = new PictureBox();
            Image img = Pacman_Game.Properties.Resources.playerShip1_blue;
            int left = (this.Width / 2)-20;
            int top = this.Height - 150;

            player.Left = left;
            player.Top = top;
            player.Height = img.Height;
            player.Width = img.Width;

            player.Image = img;
            player.BackColor = Color.Transparent;
            playerHealth.Left = player.Left;
            playerHealth.Top = player.Top + player.Height+10;
            this.Controls.Add(player);
            this.Controls.Add(playerHealth);

        }
        
        private PictureBox createEnemy(Image img)
        {
            PictureBox enemy = new PictureBox();
            int left = rand.Next(30, this.Width);
            int top = rand.Next(10, img.Height + 10);

            enemy.Left = left;
            enemy.Top = Top;
            enemy.Height = img.Height;
            enemy.Width = img.Width;

            enemy.Image = img;
            enemy.BackColor = Color.Transparent;
            return enemy;
        }
        
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Keyboard.IsKeyPressed(Key.RightArrow))
            {
                player.Left = player.Left + 25;
            }
            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                player.Left = player.Left - 25;

            }
            if (timer == 2)
            {
                if (Keyboard.IsKeyPressed(Key.Space))
                {
                    PictureBox fire = new PictureBox();
                    Image fireImage = Pacman_Game.Properties.Resources.laserBlue01;
                    fire = createFire(player, fireImage);

                    fires.Add(fire);
                    this.Controls.Add(fire);

                }
                timer = 0;
                
            }
            foreach(PictureBox bullet in fires )
            {
                bullet.Top = bullet.Top - 20;
            }
            for(int i=0;i<fires.Count;i++)
            {
                 if(fires[i].Bottom<0)
                {
                    fires.Remove(fires[i]);
                }
            }
            moveEnemy(enemyBlack, ref enemyBlackDirection);
            moveEnemy(enemyBox, ref enemydirection);
            timer++;
            timer3++;
            timer2++;
            if(timer2>=enemyTime)
            {
                Image img = Pacman_Game.Properties.Resources.laserRed03;
                PictureBox fire = createFire(enemyBlack, img);

                enemyFires.Add(fire);
                this.Controls.Add(fire);

                timer2 = 0;
            }
            
            for (int i = 0; i < enemyFires.Count; i++)
            {
                if (enemyFires[i].Bottom < 0)
                {
                   
                    enemyFires.Remove(fires[i]);
                }
            }

            if (timer3 >= enemyTime)
            {
                Image img = Pacman_Game.Properties.Resources.laserRed03;
                PictureBox fire = createFire(enemyBox, img);

                enemyFires.Add(fire);
                this.Controls.Add(fire);

                timer3 = 0;
            }

            moveEnemyBullet();
          
    
            // collosion detection pf player bullet with enemy
            foreach (PictureBox bullet in fires)
            {
                if (bullet.Bounds.IntersectsWith(enemyBlack.Bounds))
                {
                    enemyBlack.Hide();
                    isEnemyBlackActive = false;
                    bullet.Visible = false;
                }
                if (bullet.Bounds.IntersectsWith(enemyBox.Bounds))
                {
                    enemyBox.Hide();
                    isEnemyBoxActive = false;


                    bullet.Visible = false;

                }
            }
            

            //metroid 
            metroidTimer++;
            if(metroidTimer>=metroidTime)
            {
                Image img = Pacman_Game.Properties.Resources.meteorBrown_small1;
                PictureBox metroid = createmetroid(img);
                mettroids.Add(metroid);
                this.Controls.Add(metroid);
                metroidTimer = 0;
            }
            //metroid movement
            foreach(PictureBox metroid in mettroids)
            {
                moveMetroid(metroid);
            }
            //remove metroid from list
            for (int i = 0; i < mettroids.Count; i++)
            {
                if (mettroids[i].Bottom < 0)
                {
                    mettroids.Remove(fires[i]);
                }
            }
            //metroid collosion 


            // player bullet coolision with metroid

            //movement of progress bar
            playerHealth.Left = player.Left;
            //endGame
            if (!isEnemyBlackActive && !isEnemyBoxActive)
            {
                timer1.Enabled = false;
                EndGame end = new EndGame();
                DialogResult result= end.ShowDialog();
                if(result==DialogResult.OK)
                {
                    start();
                }
                else
                {
                    this.Close();
                }

            }

        }
        public void moveEnemyBullet()
        {
            foreach (PictureBox bullet in enemyFires)
            {
                bullet.Top = bullet.Top + 20;
            }
        }
        public void moveMetroid(PictureBox m)
        {
            m.Top = m.Top + 15;
        }
        public PictureBox createmetroid(Image fireImage)
        {
            PictureBox fire = new PictureBox();

            fire.Image = fireImage;
            fire.Width = fireImage.Width;
            fire.Height = fireImage.Height;
            fire.BackColor = Color.Transparent;
            fire.Top = 5;
            int width = rand.Next(0,this.Width);
            fire.Left = width;

           
            return fire;
        }
        
       

        private void moveEnemy(PictureBox enemy,ref string enemyDirection)
        {
            if(enemyDirection=="right")
            {
                enemy.Left = enemy.Left + 20;
            }
           else if (enemyDirection == "left")
            {
                enemy.Left = enemy.Left - 20;
            }
            if((enemy.Left+enemy.Width)>this.Width)
            {
                enemyDirection = "left";
            }
            if(enemy.Left<=2)
            {
                enemyDirection = "right";

            }
        }
        private PictureBox createFire(PictureBox source,Image fireImage)
        {
            PictureBox fire = new PictureBox();
            
            fire.Image = fireImage;
            fire.Width = fireImage.Width;
            fire.Height = fireImage.Height;
            fire.BackColor = Color.Transparent;
            System.Drawing.Point firePoint;
                firePoint= new System.Drawing.Point();
            firePoint.X = source.Left + (source.Width / 5) + 18;
            firePoint.Y = source.Top;
            fire.Location = firePoint;
            return fire;
        }

        private void progressBar1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
