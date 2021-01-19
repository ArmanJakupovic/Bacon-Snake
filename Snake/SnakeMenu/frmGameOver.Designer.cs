namespace SnakeMenu
{
    partial class frmGameOver
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
            this.btnok = new System.Windows.Forms.Button();
            this.lblentername = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblHighscore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnok
            // 
            this.btnok.BackgroundImage = global::SnakeMenu.Properties.Resources.ok;
            this.btnok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnok.Location = new System.Drawing.Point(147, 200);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(125, 50);
            this.btnok.TabIndex = 0;
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // lblentername
            // 
            this.lblentername.AutoSize = true;
            this.lblentername.BackColor = System.Drawing.Color.White;
            this.lblentername.Location = new System.Drawing.Point(46, 196);
            this.lblentername.Name = "lblentername";
            this.lblentername.Size = new System.Drawing.Size(87, 13);
            this.lblentername.TabIndex = 1;
            this.lblentername.Text = "Enter your name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(41, 216);
            this.txtName.MaxLength = 3;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 2;
            // 
            // lblHighscore
            // 
            this.lblHighscore.AutoSize = true;
            this.lblHighscore.BackColor = System.Drawing.Color.White;
            this.lblHighscore.Location = new System.Drawing.Point(120, 132);
            this.lblHighscore.Name = "lblHighscore";
            this.lblHighscore.Size = new System.Drawing.Size(53, 13);
            this.lblHighscore.TabIndex = 3;
            this.lblHighscore.Text = "highscore";
            // 
            // frmGameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SnakeMenu.Properties.Resources.GAMEOVER;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.ControlBox = false;
            this.Controls.Add(this.lblHighscore);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblentername);
            this.Controls.Add(this.btnok);
            this.Name = "frmGameOver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GAME OVER!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Label lblentername;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblHighscore;
    }
}