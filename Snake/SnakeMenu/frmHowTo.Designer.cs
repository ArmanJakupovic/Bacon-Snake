namespace SnakeMenu
{
    partial class frmHowTo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUp = new System.Windows.Forms.Label();
            this.lblDwn = new System.Windows.Forms.Label();
            this.lblLft = new System.Windows.Forms.Label();
            this.lblRght = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picUpMotion = new System.Windows.Forms.PictureBox();
            this.picDownMotion = new System.Windows.Forms.PictureBox();
            this.picLeftMotion = new System.Windows.Forms.PictureBox();
            this.picRightMotion = new System.Windows.Forms.PictureBox();
            this.btnBck = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picBonusFruit = new System.Windows.Forms.PictureBox();
            this.picFruit = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picBtnPause = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpMotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDownMotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeftMotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRightMotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBonusFruit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFruit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnPause)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUp
            // 
            this.lblUp.AutoSize = true;
            this.lblUp.Location = new System.Drawing.Point(453, 135);
            this.lblUp.Name = "lblUp";
            this.lblUp.Size = new System.Drawing.Size(75, 13);
            this.lblUp.TabIndex = 5;
            this.lblUp.Text = "Steer worm up";
            // 
            // lblDwn
            // 
            this.lblDwn.AutoSize = true;
            this.lblDwn.Location = new System.Drawing.Point(453, 210);
            this.lblDwn.Name = "lblDwn";
            this.lblDwn.Size = new System.Drawing.Size(89, 13);
            this.lblDwn.TabIndex = 6;
            this.lblDwn.Text = "Steer worm down";
            // 
            // lblLft
            // 
            this.lblLft.AutoSize = true;
            this.lblLft.Location = new System.Drawing.Point(453, 280);
            this.lblLft.Name = "lblLft";
            this.lblLft.Size = new System.Drawing.Size(107, 13);
            this.lblLft.TabIndex = 7;
            this.lblLft.Text = "Steer worm to the left";
            // 
            // lblRght
            // 
            this.lblRght.AutoSize = true;
            this.lblRght.Location = new System.Drawing.Point(453, 350);
            this.lblRght.Name = "lblRght";
            this.lblRght.Size = new System.Drawing.Size(113, 13);
            this.lblRght.TabIndex = 8;
            this.lblRght.Text = "Steer worm to the right";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SnakeMenu.Properties.Resources.btnhowtooff;
            this.pictureBox1.Location = new System.Drawing.Point(-8, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // picUpMotion
            // 
            this.picUpMotion.InitialImage = null;
            this.picUpMotion.Location = new System.Drawing.Point(359, 111);
            this.picUpMotion.MaximumSize = new System.Drawing.Size(70, 56);
            this.picUpMotion.MinimumSize = new System.Drawing.Size(70, 56);
            this.picUpMotion.Name = "picUpMotion";
            this.picUpMotion.Size = new System.Drawing.Size(70, 56);
            this.picUpMotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUpMotion.TabIndex = 12;
            this.picUpMotion.TabStop = false;
            this.picUpMotion.Click += new System.EventHandler(this.picUpMotion_Click);
            // 
            // picDownMotion
            // 
            this.picDownMotion.Location = new System.Drawing.Point(359, 184);
            this.picDownMotion.MaximumSize = new System.Drawing.Size(70, 56);
            this.picDownMotion.MinimumSize = new System.Drawing.Size(70, 56);
            this.picDownMotion.Name = "picDownMotion";
            this.picDownMotion.Size = new System.Drawing.Size(70, 56);
            this.picDownMotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDownMotion.TabIndex = 13;
            this.picDownMotion.TabStop = false;
            this.picDownMotion.Click += new System.EventHandler(this.picDownMotion_Click);
            // 
            // picLeftMotion
            // 
            this.picLeftMotion.Location = new System.Drawing.Point(359, 254);
            this.picLeftMotion.MaximumSize = new System.Drawing.Size(70, 56);
            this.picLeftMotion.MinimumSize = new System.Drawing.Size(70, 56);
            this.picLeftMotion.Name = "picLeftMotion";
            this.picLeftMotion.Size = new System.Drawing.Size(70, 56);
            this.picLeftMotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLeftMotion.TabIndex = 14;
            this.picLeftMotion.TabStop = false;
            this.picLeftMotion.Click += new System.EventHandler(this.picLeftMotion_Click);
            // 
            // picRightMotion
            // 
            this.picRightMotion.Location = new System.Drawing.Point(359, 331);
            this.picRightMotion.MaximumSize = new System.Drawing.Size(70, 56);
            this.picRightMotion.MinimumSize = new System.Drawing.Size(70, 56);
            this.picRightMotion.Name = "picRightMotion";
            this.picRightMotion.Size = new System.Drawing.Size(70, 56);
            this.picRightMotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRightMotion.TabIndex = 15;
            this.picRightMotion.TabStop = false;
            this.picRightMotion.Click += new System.EventHandler(this.picRightMotion_Click);
            // 
            // btnBck
            // 
            this.btnBck.BackgroundImage = global::SnakeMenu.Properties.Resources.backoff;
            this.btnBck.Location = new System.Drawing.Point(412, 396);
            this.btnBck.MaximumSize = new System.Drawing.Size(200, 38);
            this.btnBck.MinimumSize = new System.Drawing.Size(200, 38);
            this.btnBck.Name = "btnBck";
            this.btnBck.Size = new System.Drawing.Size(200, 38);
            this.btnBck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnBck.TabIndex = 16;
            this.btnBck.TabStop = false;
            this.btnBck.Click += new System.EventHandler(this.btnBck_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 111);
            this.label1.MaximumSize = new System.Drawing.Size(207, 80);
            this.label1.MinimumSize = new System.Drawing.Size(207, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 52);
            this.label1.TabIndex = 11;
            this.label1.Text = "The purpose of this game is to collect as many points as possible by eating all t" +
                "he fruit. To stay alive you must avoid colliding with yourself and the walls.\n";
            // 
            // picBonusFruit
            // 
            this.picBonusFruit.BackColor = System.Drawing.Color.Purple;
            this.picBonusFruit.Location = new System.Drawing.Point(52, 210);
            this.picBonusFruit.Name = "picBonusFruit";
            this.picBonusFruit.Size = new System.Drawing.Size(30, 30);
            this.picBonusFruit.TabIndex = 17;
            this.picBonusFruit.TabStop = false;
            // 
            // picFruit
            // 
            this.picFruit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.picFruit.Location = new System.Drawing.Point(52, 280);
            this.picFruit.Name = "picFruit";
            this.picFruit.Size = new System.Drawing.Size(30, 30);
            this.picFruit.TabIndex = 18;
            this.picFruit.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 280);
            this.label2.MaximumSize = new System.Drawing.Size(120, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 39);
            this.label2.TabIndex = 19;
            this.label2.Text = "Regular Fruit: Gives you 10 points. Also this fruit will stay until you eat it.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 210);
            this.label3.MaximumSize = new System.Drawing.Size(160, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 52);
            this.label3.TabIndex = 20;
            this.label3.Text = "Special Fruit: This fruit will lower the speed of the Snake and give you extra po" +
                "ints. But hurry up it doesn\'t stay forever!";
            // 
            // picBtnPause
            // 
            this.picBtnPause.Image = global::SnakeMenu.Properties.Resources.P;
            this.picBtnPause.InitialImage = null;
            this.picBtnPause.Location = new System.Drawing.Point(32, 331);
            this.picBtnPause.MaximumSize = new System.Drawing.Size(70, 56);
            this.picBtnPause.MinimumSize = new System.Drawing.Size(70, 56);
            this.picBtnPause.Name = "picBtnPause";
            this.picBtnPause.Size = new System.Drawing.Size(70, 56);
            this.picBtnPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBtnPause.TabIndex = 21;
            this.picBtnPause.TabStop = false;
            this.picBtnPause.Click += new System.EventHandler(this.picBtnPause_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 350);
            this.label4.MaximumSize = new System.Drawing.Size(120, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Pauses the game.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Click the buttons to change your controls.";
            // 
            // frmHowTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(624, 443);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picBtnPause);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picFruit);
            this.Controls.Add(this.picBonusFruit);
            this.Controls.Add(this.btnBck);
            this.Controls.Add(this.picRightMotion);
            this.Controls.Add(this.picLeftMotion);
            this.Controls.Add(this.picDownMotion);
            this.Controls.Add(this.picUpMotion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRght);
            this.Controls.Add(this.lblLft);
            this.Controls.Add(this.lblDwn);
            this.Controls.Add(this.lblUp);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(640, 480);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "frmHowTo";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "How to";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUpMotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDownMotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeftMotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRightMotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBonusFruit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFruit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnPause)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUp;
        private System.Windows.Forms.Label lblDwn;
        private System.Windows.Forms.Label lblLft;
        private System.Windows.Forms.Label lblRght;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picUpMotion;
        private System.Windows.Forms.PictureBox picDownMotion;
        private System.Windows.Forms.PictureBox picLeftMotion;
        private System.Windows.Forms.PictureBox picRightMotion;
        private System.Windows.Forms.PictureBox btnBck;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox picBonusFruit;
        public System.Windows.Forms.PictureBox picFruit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picBtnPause;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}