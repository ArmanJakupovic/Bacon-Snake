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
    public partial class frmSnakeMenu : Form
    {
        public frmSnakeMenu()
        {
            InitializeComponent();

            highscoreupdate();

            btnNewGame.MouseEnter += new EventHandler(btnNewGame_MouseHover);//* code for the graphical part of the buttons for mouse over and mouse out
            btnNewGame.MouseLeave += new EventHandler(btnNewGame_MouseMove);
            btnHelp.MouseEnter += new EventHandler(btnHelp_MouseHover);
            btnHelp.MouseLeave += new EventHandler(btnHelp_MouseMove);
            btnQuit.MouseEnter += new EventHandler(btnQuit_MouseHover);
            btnQuit.MouseLeave += new EventHandler(btnQuit_MouseMove);
            btnProject.MouseEnter += new EventHandler(btnProject_MouseHover);
            btnProject.MouseLeave += new EventHandler(btnProject_MouseMove);//*
           



            //*        Code for the graphical part of the buttons for mouse over and out 
        }

        void btnNewGame_MouseMove(object sender, EventArgs e)
        {
            this.btnNewGame.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btnStartoff));
        }

        void btnNewGame_MouseHover(object sender, EventArgs e)
        {
            this.btnNewGame.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btnStarton));

        }

        void btnNewGame_Keymark(object sender, EventArgs e)
        {
            this.btnNewGame.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btnStarton));

        }

        void btnHelp_MouseMove(object sender, EventArgs e)
        {
            this.btnHelp.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btnhowtoon));

        }

        void btnHelp_MouseHover(object sender, EventArgs e)
        {
            this.btnHelp.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btnhowtooff));

        }

        void btnProject_MouseMove(object sender, EventArgs e)
        {
            this.btnProject.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btnprojectoff));

        }

        void btnProject_MouseHover(object sender, EventArgs e)
        {
            this.btnProject.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btnprojecton));

        }

        void btnQuit_MouseMove(object sender, EventArgs e)
        {
            this.btnQuit.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btnquitoff));

        }

        void btnQuit_MouseHover(object sender, EventArgs e)
        {
            this.btnQuit.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.btnquiton));

        }

        //*        Code for the graphical part of the buttons for mouse over and out
        private void btnQuit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
            //*  Closes the application

        }

        private void btnProject_Click_1(object sender, EventArgs e)
        {

            Form frmAboutGame = new frmAboutGame(); // code for showing and hiding forms e g, show the "game play part of the game, hide the menu"
            frmAboutGame.Show();
            this.Hide();
        }

        private void btnNewGame_Click_1(object sender, EventArgs e)
        {

            Form frmMainGame = new frmMainGame(); // code for showing and hiding forms e g, show the "game play part of the game, hide the menu"
            frmMainGame.Show();
            this.Hide();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

            Form frmHowto = new frmHowTo(); // code for showing and hiding forms e g, show the "game play part of the game" and hide the menu
            frmHowto.Show();
            this.Hide();
        }

        public void highscoreupdate()
        {
            try
            {
                StreamReader streamReader = new StreamReader("Highscore.txt");
                lblHighscore.Text = streamReader.ReadToEnd(); //* loads the highcsore to a label
                streamReader.Close();
                this.Refresh();
                lblHighscore.BackColor = Color.Transparent;
            }
            catch
            {
                string ni = "Hej 0\r\nHej 0\r\nHej 0\r\nHej 0\r\nHej 0"; // needed for the forloop in gameover or else it crashess
                
                File.WriteAllText(@"Highscore.txt", ni.ToString());
              
                StreamReader streamReader = new StreamReader("Highscore.txt");
                lblHighscore.Text = streamReader.ReadToEnd(); //* loads the highcsore to a label
                streamReader.Close();

                lblHighscore.BackColor = Color.Transparent;
                this.Refresh();
            }

        }   // method that reads the highscore
    }
}
