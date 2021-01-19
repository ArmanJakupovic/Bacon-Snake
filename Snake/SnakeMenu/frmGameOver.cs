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
    public partial class frmGameOver : Form
    {
        frmSnakeMenu frmMain = new frmSnakeMenu();
        int highscore;
        StreamReader scoresw = new StreamReader("score.txt");


        List<string> Names = new List<string>();
        List<int> Score = new List<int>();
        public frmGameOver()
        {
            InitializeComponent();
            highscore = Convert.ToInt32(scoresw.ReadLine());
            scoresw.Close();
            lblHighscore.Text = ("You got " + highscore.ToString());
            btnok.MouseEnter += new EventHandler(btnok_MouseHover);//* code for the graphical part of the buttons for mouse over and mouse out
            btnok.MouseLeave += new EventHandler(btnok_MouseMove);
           
            StreamReader sr = new StreamReader(@"highscore.txt");

            while (sr.EndOfStream == false)
            {
                string[] str = sr.ReadLine().Split(' ');
                Names.Add(str[0]);
                Score.Add(Convert.ToInt32(str[1]));
            }
            sr.Close();
        
        }
        void btnok_MouseMove(object sender, EventArgs e)
        {
            this.btnok.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.ok));
        }

        void btnok_MouseHover(object sender, EventArgs e)
        {
            this.btnok.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.okover));
        }
        
        private void btnok_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Score.Count; i++)
            {
                if (Score[i] < highscore)
                {
                    Names.Insert(i, txtName.Text);
                    Score.Insert(i, highscore);
                    StreamWriter sw = new StreamWriter(@"highscore.txt");
                    for (int u = 0; u < 5; u++)
                    {
                        sw.WriteLine(Names[u] + " " + Convert.ToString(Score[u]));
                    }
                    MessageBox.Show("Congrats you made it into the Highscore");
                    sw.Close();
                    frmMain.highscoreupdate();
                    break;
                }
                else if (i == 5)
                {
                    MessageBox.Show("You didn't make to the list");
                    break;
                }
            }
            
            frmMain.Show();
            frmMain.Refresh();
            this.Close();
        }
    }
}