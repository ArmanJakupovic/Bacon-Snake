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
    public partial class frmHowTo : Form
    {
        //Init variables
        char snakeUp = Convert.ToChar(Keys.W);
        char snakeDown = Convert.ToChar(Keys.S);
        char snakeLeft = Convert.ToChar(Keys.A);
        char snakeRight = Convert.ToChar(Keys.D);
        
        frmControlInput SetKey = new frmControlInput(); // Create communication between frmHowTo and frmControlInput

        public frmHowTo()
        {
            InitializeComponent();
            GetControls();

            btnBck.MouseEnter += new EventHandler(btnBck_MouseHover); //code calling the neccessary methods on mouse over and mouse on button.
            btnBck.MouseLeave += new EventHandler(btnBck_MouseMove);

            SetKey.KeyDown += new KeyEventHandler(SetKey_KeyDown); //Creating KeyEventHandler for Keydown Event
        }

        //code that dictates what happens when mouse is over and out of image.
        void btnBck_MouseMove(object sender, EventArgs e)
        {
            this.btnBck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.backoff));
        }

        void btnBck_MouseHover(object sender, EventArgs e)
        {
            this.btnBck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.backon));

        }

        private void btnBck_Click(object sender, EventArgs e)
        {
            StreamWriter saveControls = File.CreateText("Controls.txt");
            saveControls.WriteLine(snakeUp);
            saveControls.WriteLine(snakeDown);
            saveControls.WriteLine(snakeLeft);
            saveControls.WriteLine(snakeRight);
            saveControls.Close();
            Form frmSnakeMenu = new frmSnakeMenu(); // code for showing and hiding forms e g, show the "game play part of the game, hide the menu"
            frmSnakeMenu.Show();
            this.Hide();
        }

        //Change KeyUp.
        public void picUpMotion_Click(object sender, EventArgs e)
        {
            SetKey.keyToHandle = Convert.ToChar(Keys.Up);   //keyToHandle gets Up value to check which button was pressed.
            SetKey.ShowDialog();                            //Pops-up frmControlInput.
        }

        //Change KeyDown.
        private void picDownMotion_Click(object sender, EventArgs e)
        {
            SetKey.keyToHandle = Convert.ToChar(Keys.Down);
            SetKey.ShowDialog();
        }

        //Change KeyLeft.
        private void picLeftMotion_Click(object sender, EventArgs e)
        {
            SetKey.keyToHandle = Convert.ToChar(Keys.Left);
            SetKey.ShowDialog();
        }

        //Change KeyRight.
        private void picRightMotion_Click(object sender, EventArgs e)
        {
            SetKey.keyToHandle = Convert.ToChar(Keys.Right);
            SetKey.ShowDialog();
        }

        private void SetKey_KeyDown(object sender, KeyEventArgs e) // KeyEvent for chaning the controls.
        {
            if (e.KeyCode == Keys.P) //Making sure the player can't choose P.
            {
                MessageBox.Show("P is used for Pause. Therefor an unavaible choice.");
            }
            else
            {
                if (SetKey.keyToHandle == Convert.ToChar(Keys.Up)) //Assign the pressed key to Control UP.
                {
                    snakeUp = Convert.ToChar(e.KeyCode);
                    picUpMotion.Image = (Image)Properties.Resources.ResourceManager.GetObject(snakeUp.ToString());//Changing button image.
                    SetKey.Hide();
                }
                else if (SetKey.keyToHandle == Convert.ToChar(Keys.Down))//Assign the pressed key to Control DOWN.
                {
                    snakeDown = Convert.ToChar(e.KeyCode);
                    picDownMotion.Image = (Image)Properties.Resources.ResourceManager.GetObject(snakeDown.ToString());//Changing button image.
                    SetKey.Hide();
                }
                else if (SetKey.keyToHandle == Convert.ToChar(Keys.Left))//Assign the pressed key to Control LEFT.
                {
                    snakeLeft = Convert.ToChar(e.KeyCode);
                    picLeftMotion.Image = (Image)Properties.Resources.ResourceManager.GetObject(snakeLeft.ToString());//Changing button image.
                    SetKey.Hide();
                }
                else if (SetKey.keyToHandle == Convert.ToChar(Keys.Right))//Assign the pressed key to Control RIGTH.
                {
                    snakeRight = Convert.ToChar(e.KeyCode);
                    picRightMotion.Image = (Image)Properties.Resources.ResourceManager.GetObject(snakeRight.ToString()); //Changing button image.
                    SetKey.Hide();
                }
            }
        }

        private void GetControls()
        {
            try // Try if there is a file.
            {
                StreamReader loadControls = new StreamReader("Controls.txt"); //Creating Reader object.
                snakeUp = Convert.ToChar(loadControls.ReadLine());
                snakeDown = Convert.ToChar(loadControls.ReadLine());
                snakeLeft = Convert.ToChar(loadControls.ReadLine());
                snakeRight = Convert.ToChar(loadControls.ReadLine());
                loadControls.Close();
                picUpMotion.Image = (Image)Properties.Resources.ResourceManager.GetObject(snakeUp.ToString());
                picDownMotion.Image = (Image)Properties.Resources.ResourceManager.GetObject(snakeDown.ToString());
                picLeftMotion.Image = (Image)Properties.Resources.ResourceManager.GetObject(snakeLeft.ToString());
                picRightMotion.Image = (Image)Properties.Resources.ResourceManager.GetObject(snakeRight.ToString());
                
            }
            catch (FileNotFoundException) // If Controls.txt not found.
            {
                picUpMotion.Image = Properties.Resources.W;
                picDownMotion.Image = Properties.Resources.S;      //Set controls to standard keys.
                picLeftMotion.Image = Properties.Resources.A;
                picRightMotion.Image = Properties.Resources.D;
            }
        }

        private void picBtnPause_Click(object sender, EventArgs e)
        {
            MessageBox.Show("P is not changeable");
        }

    }
}
