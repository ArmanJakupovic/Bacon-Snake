using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SnakeMenu
{
    public partial class frmAboutGame : Form
    {
        public frmAboutGame()
        {
            InitializeComponent();
            btnBck.MouseEnter += new EventHandler(btnBck_MouseHover); //code calling the neccessary methods on mouse over and mouse on button.
            btnBck.MouseLeave += new EventHandler(btnBck_MouseMove);
        }

        void btnBck_MouseMove(object sender, EventArgs e)
        {
            this.btnBck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.backoff));
        } //Change picture for button
        void btnBck_MouseHover(object sender, EventArgs e)
        {
            this.btnBck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.backon));

        } //Change picture for button
        private void btnBck_Click(object sender, EventArgs e)
        {
            Form frmSnakeMenu = new frmSnakeMenu(); // code for showing and hiding forms e g, show the "game play part of the game, hide the menu"
            frmSnakeMenu.Show();
            this.Hide();

        }
    }
}
