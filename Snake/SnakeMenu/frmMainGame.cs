using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SnakeMenu
{
    public partial class frmMainGame : Form
    {
         
        string snakeDirection = "LEFT";//Init variable
        bool keyClicked = false;
        
        Random generator = new Random(); //random number generator
        int fruitX, fruitY; // variables for fruit placement
        int bonusFruitX , bonusFruitY, spawnFruit; // declares bonus fruits
        public int highScoreCounter = 0; //Variable for score
        int bonusscoretime = 0;
        
        PictureBox[] tail = new PictureBox[768]; // Creating tail array
        int tailIndex = 2;

        public frmMainGame()
        {
            for (int i = 0; i < tail.Length; i++) // Creating and setup of each picturebox in the tail array
            {
                tail[i] = new PictureBox();
                tail[i].Size = new Size(20, 20);
                tail[i].BackColor = Color.Black;
                tail[i].Visible = false;
            }
            Controls.Add(tail[0]);
            Controls.Add(tail[1]);
            tail[0].Visible = true;    //Making the first two tailbits visible
            tail[1].Visible = true;

            InitializeComponent();
            GetControls(); //Get controls to use for steering snake.
       
            KeyDown += new KeyEventHandler(frmMainGame_KeyDown); // Create KeyEventHandler for key presses.
            PlaceRandomFruit(); //To place random fruit
        }

        //Method for snakemovement
        private void SnakeGameEngine_Tick(object sender, EventArgs e)
        {
            keyClicked = false;
            CheckDirectionOrCollision();
            bonusscoretime++;
            label1.Text = Convert.ToString(bonusscoretime);
            if (bonusscoretime == 30)
            {
                picBonusFruit.Visible = false;
                bonusFruitX = -100;
                bonusFruitY = -100;
                picBonusFruit.Location = new Point((bonusFruitX), (bonusFruitY));
            }
            
            // PlaceRandomFruit(); //Testing random fruit generator

        }

        //Method for pressed key events
        private void frmMainGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.P && SnakeGameEngine.Enabled == true)
            {
                SnakeGameEngine.Stop();
                MessageBox.Show("Game paused. Press OK to continue.");          //Pause event.
            }
            else
            {
                SnakeGameEngine.Start();
            }

            if (e.KeyValue == Convert.ToChar(lstControls.Items[0]) && snakeDirection != "DOWN" && keyClicked == false) //Direction becomes UP.
            {
                snakeDirection = "UP";
                keyClicked = true;     //Making sure that only one key is pressed per tick
            }
            else if (e.KeyValue == Convert.ToChar(lstControls.Items[1]) && snakeDirection != "UP" && keyClicked == false) //Direction becomes DOWN.
            {
                snakeDirection = "DOWN";
                keyClicked = true;     //Making sure that only one key is pressed per tick
            }
            else if (e.KeyValue == Convert.ToChar(lstControls.Items[2]) && snakeDirection != "RIGHT" && keyClicked == false)//Direction becomes LEFT.
            {
                snakeDirection = "LEFT";
                keyClicked = true;     //Making sure that only one key is pressed per tick
            }
            else if (e.KeyValue == Convert.ToChar(lstControls.Items[3]) && snakeDirection != "LEFT" && keyClicked == false)//Direction becomes RIGHT.
            {
                snakeDirection = "RIGHT";
                keyClicked = true;     //Making sure that only one key is pressed per tick
            }
        }

        //Method for direction and collisions
        private void CheckDirectionOrCollision()
        {
            //Check for collision in walls or in snake
            if (picSnakeHead.Location.X > 620 || picSnakeHead.Location.X < 0 || picSnakeHead.Location.Y < 40 || picSnakeHead.Location.Y > 500)
            {
                SnakeGameEngine.Enabled = false;
                FruitTimer.Enabled = false;
                SavingScore(lblHighscore.Text);
                frmGameOver frmGameOver = new frmGameOver();
                frmGameOver.Show();                
            }
            for (int i = 0; i < tail.Length; i++)
            {
                if (picSnakeHead.Location == tail[i].Location && tail[i].Visible == true)
                {
                    SnakeGameEngine.Enabled = false;
                    FruitTimer.Enabled = false;
                    SavingScore(lblHighscore.Text);
                    frmGameOver frmGameOver = new frmGameOver();
                    frmGameOver.Show();
                }                
            }

            //Code for making the snake move
            if (snakeDirection == "UP")
            {
                for (int i = tail.Length - 1; i > 0; i--)   //Loop that makes the tail follow the head
                {
                    tail[i].Location = new Point(tail[i - 1].Location.X, tail[i - 1].Location.Y);
                }
                tail[0].Location = new Point(picSnakeHead.Location.X, picSnakeHead.Location.Y);
                picSnakeHead.Location = new Point(picSnakeHead.Location.X, picSnakeHead.Location.Y - 20);
            }
            else if (snakeDirection == "DOWN")
            {
                for (int i = tail.Length - 1; i > 0; i--)   //Loop that makes the tail follow the head
                {
                    tail[i].Location = new Point(tail[i - 1].Location.X, tail[i - 1].Location.Y);
                }
                tail[0].Location = new Point(picSnakeHead.Location.X, picSnakeHead.Location.Y);
                picSnakeHead.Location = new Point(picSnakeHead.Location.X, picSnakeHead.Location.Y + 20);
            }
            else if (snakeDirection == "RIGHT")
            {
                for (int i = tail.Length - 1; i > 0; i--)   //Loop that makes the tail follow the head
                {
                    tail[i].Location = new Point(tail[i - 1].Location.X, tail[i - 1].Location.Y);
                }
                tail[0].Location = new Point(picSnakeHead.Location.X, picSnakeHead.Location.Y);
                picSnakeHead.Location = new Point(picSnakeHead.Location.X + 20, picSnakeHead.Location.Y);
            }
            else if (snakeDirection == "LEFT")
            {
                for (int i = tail.Length - 1; i > 0; i--)   //Loop that makes the tail follow the head
                {
                    tail[i].Location = new Point(tail[i - 1].Location.X, tail[i - 1].Location.Y);
                }
                tail[0].Location = new Point(picSnakeHead.Location.X, picSnakeHead.Location.Y);
                picSnakeHead.Location = new Point(picSnakeHead.Location.X - 20, picSnakeHead.Location.Y);
            }

        }

        //Method for fetching controls from the Control.txt file.
        private void GetControls()
        {
            try // Try if there is a file.
            {
                StreamReader loadControls = new StreamReader("Controls.txt"); //Creating Reader object.
                string check = loadControls.ReadLine();
                while (check != null)
                {
                    lstControls.Items.Add(check);
                    check = loadControls.ReadLine();
                }
                loadControls.Close();
            }
            catch (FileNotFoundException) // If Controls.txt not found.
            {
                lstControls.Items.Add("W");
                lstControls.Items.Add("S");       //Set controls to standard keys.
                lstControls.Items.Add("A");
                lstControls.Items.Add("D");
            }
        }

        //method for placing a random fruit
        private void PlaceRandomFruit()
        {
            bool flagga;
            picFruit.Visible = true;
                do // loop that loops trough every position in the tail and checks that its not the same as the randomized position for the new fruit.
                {
                    fruitX = (generator.Next(0, 31)*20);
                    fruitY = (generator.Next(2, 25)*20);
                    flagga = true;

                    for (int j = 0; j < tail.Length; j++)
                    {
                        if (tail[j].Location.X == fruitX && tail[j].Location.Y == fruitY && tail[j].Visible == true || picSnakeHead.Location.X == fruitX && picSnakeHead.Location.Y == fruitY
                            || fruitX == bonusFruitX && fruitY == bonusFruitY)
                        {
                            flagga = false;
                        }
                    }
                }
                while (flagga == false);
            picFruit.Location = new Point(fruitX, fruitY);
        }
        //method for placing the bonus fruit 
        private void PlaceBonusFruit()
        {
            bonusscoretime = 0;
            bool flagga;
            picBonusFruit.Visible = true;
                do // loop that loops trough every position in the tail and checks that its not the same as the randomized position for the new fruit.
                {
                    bonusFruitX = (generator.Next(0, 31) *20);
                    bonusFruitY = (generator.Next(2, 25) *20);
                    flagga = true;

                    for (int j = 0; j < tail.Length; j++)
                    {
                        if (tail[j].Location.X == bonusFruitX && tail[j].Location.Y == bonusFruitY && tail[j].Visible == true || picSnakeHead.Location.X == bonusFruitX && picSnakeHead.Location.Y == bonusFruitY
                            || fruitX == bonusFruitX && fruitY == bonusFruitY)
                        {
                            flagga = false;
                        }
                    }
                }
                while (flagga == false);
            picBonusFruit.Location = new Point((bonusFruitX), (bonusFruitY));
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SnakeGameEngine.Stop();
            Form frmSnakeMenu = new frmSnakeMenu();
            this.Close();
            frmSnakeMenu.Show();
        }

        private void FruitTimer_Tick(object sender, EventArgs e)
        {
            if (picSnakeHead.Location.X == fruitX && picSnakeHead.Location.Y == fruitY)  //Collision with fruit and giving of points
            {
                spawnFruit++;
                PlaceRandomFruit();
                Controls.Add(tail[tailIndex]); //Add a tailbit to the snake
                tail[tailIndex].Visible = true;
                tailIndex++;
                highScoreCounter += 10; //Give the player 10 points for each fruit "eaten"
                SnakeGameEngine.Interval = Convert.ToInt32(SnakeGameEngine.Interval * 0.98); // increase of speed for each fruit eaten. NEEDS BALLANCE
                lblHighscore.Text = Convert.ToString(highScoreCounter);
                if (spawnFruit >= 10 && picBonusFruit.Visible == false)
                {
                    spawnFruit = 0;
                    PlaceBonusFruit();
                } 
            }

            if (picSnakeHead.Location.X == bonusFruitX && picSnakeHead.Location.Y == bonusFruitY) //Collision with bonus fruit, giving of points and slowing timer
            {
                bonusFruitX = -100;
                bonusFruitY = -100;
                picBonusFruit.Visible = false;
                picBonusFruit.Location = new Point((bonusFruitX), (bonusFruitY));
                SnakeGameEngine.Interval += 15;
                highScoreCounter += (100/ bonusscoretime);
                lblHighscore.Text = Convert.ToString(highScoreCounter);
            }
        }

        private void SavingScore(string score)
        
        {
            StreamWriter sw = File.CreateText("score.txt");
            if (score == null)
            {
                sw.WriteLine("0");
            }
            else
            {
                sw.WriteLine(score);
            } sw.Close();
        
            }
    }
}
