namespace SnakeMenu
{
    partial class frmMainGame
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
            this.components = new System.ComponentModel.Container();
            this.SnakeGameEngine = new System.Windows.Forms.Timer(this.components);
            this.picSnakeHead = new System.Windows.Forms.PictureBox();
            this.picFruit = new System.Windows.Forms.PictureBox();
            this.lstControls = new System.Windows.Forms.ListBox();
            this.lblHighscore = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.FruitTimer = new System.Windows.Forms.Timer(this.components);
            this.picBonusFruit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSnakeHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFruit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBonusFruit)).BeginInit();
            this.SuspendLayout();
            // 
            // SnakeGameEngine
            // 
            this.SnakeGameEngine.Enabled = true;
            this.SnakeGameEngine.Interval = 200;
            this.SnakeGameEngine.Tick += new System.EventHandler(this.SnakeGameEngine_Tick);
            // 
            // picSnakeHead
            // 
            this.picSnakeHead.BackColor = System.Drawing.Color.Black;
            this.picSnakeHead.Location = new System.Drawing.Point(600, 400);
            this.picSnakeHead.Name = "picSnakeHead";
            this.picSnakeHead.Size = new System.Drawing.Size(20, 20);
            this.picSnakeHead.TabIndex = 0;
            this.picSnakeHead.TabStop = false;
            // 
            // picFruit
            // 
            this.picFruit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.picFruit.Location = new System.Drawing.Point(220, 300);
            this.picFruit.Name = "picFruit";
            this.picFruit.Size = new System.Drawing.Size(20, 20);
            this.picFruit.TabIndex = 3;
            this.picFruit.TabStop = false;
            this.picFruit.Visible = false;
            // 
            // lstControls
            // 
            this.lstControls.FormattingEnabled = true;
            this.lstControls.Location = new System.Drawing.Point(584, 49);
            this.lstControls.Name = "lstControls";
            this.lstControls.Size = new System.Drawing.Size(44, 82);
            this.lstControls.TabIndex = 4;
            this.lstControls.Visible = false;
            // 
            // lblHighscore
            // 
            this.lblHighscore.AutoSize = true;
            this.lblHighscore.BackColor = System.Drawing.Color.Gray;
            this.lblHighscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighscore.ForeColor = System.Drawing.Color.Black;
            this.lblHighscore.Location = new System.Drawing.Point(552, 9);
            this.lblHighscore.Name = "lblHighscore";
            this.lblHighscore.Size = new System.Drawing.Size(18, 20);
            this.lblHighscore.TabIndex = 5;
            this.lblHighscore.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 40);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(463, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Score:";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Control;
            this.btnBack.Location = new System.Drawing.Point(12, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(95, 28);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back to Menu";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FruitTimer
            // 
            this.FruitTimer.Enabled = true;
            this.FruitTimer.Interval = 1;
            this.FruitTimer.Tick += new System.EventHandler(this.FruitTimer_Tick);
            // 
            // picBonusFruit
            // 
            this.picBonusFruit.BackColor = System.Drawing.Color.Purple;
            this.picBonusFruit.Location = new System.Drawing.Point(301, 260);
            this.picBonusFruit.Name = "picBonusFruit";
            this.picBonusFruit.Size = new System.Drawing.Size(20, 20);
            this.picBonusFruit.TabIndex = 9;
            this.picBonusFruit.TabStop = false;
            this.picBonusFruit.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // frmMainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SnakeMenu.Properties.Resources.snakeGrid2;
            this.ClientSize = new System.Drawing.Size(640, 520);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHighscore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picBonusFruit);
            this.Controls.Add(this.lstControls);
            this.Controls.Add(this.picSnakeHead);
            this.Controls.Add(this.picFruit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(640, 520);
            this.MinimumSize = new System.Drawing.Size(640, 520);
            this.Name = "frmMainGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BacoN Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMainGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picSnakeHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFruit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBonusFruit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer SnakeGameEngine;
        private System.Windows.Forms.PictureBox picSnakeHead;
        public System.Windows.Forms.PictureBox picFruit;
        private System.Windows.Forms.ListBox lstControls;
        private System.Windows.Forms.Label lblHighscore;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Timer FruitTimer;
        public System.Windows.Forms.PictureBox picBonusFruit;
        private System.Windows.Forms.Label label1;
    }
}