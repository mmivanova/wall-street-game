namespace WallStreet.Forms
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            this.btnNewPlayer = new System.Windows.Forms.Button();
            this.bntLogIn = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pbWelcomePage = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblWallStreet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbWelcomePage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewPlayer
            // 
            this.btnNewPlayer.BackColor = System.Drawing.Color.LawnGreen;
            this.btnNewPlayer.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnNewPlayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNewPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewPlayer.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPlayer.Location = new System.Drawing.Point(430, 87);
            this.btnNewPlayer.Name = "btnNewPlayer";
            this.btnNewPlayer.Size = new System.Drawing.Size(234, 69);
            this.btnNewPlayer.TabIndex = 0;
            this.btnNewPlayer.Text = "New Player";
            this.btnNewPlayer.UseVisualStyleBackColor = false;
            this.btnNewPlayer.Click += new System.EventHandler(this.btnNewPlayer_Click);
            // 
            // bntLogIn
            // 
            this.bntLogIn.BackColor = System.Drawing.Color.LawnGreen;
            this.bntLogIn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.bntLogIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bntLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bntLogIn.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntLogIn.Location = new System.Drawing.Point(430, 184);
            this.bntLogIn.Name = "bntLogIn";
            this.bntLogIn.Size = new System.Drawing.Size(234, 69);
            this.bntLogIn.TabIndex = 1;
            this.bntLogIn.Text = "Log in";
            this.bntLogIn.UseVisualStyleBackColor = false;
            this.bntLogIn.Click += new System.EventHandler(this.bntLogIn_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.OrangeRed;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(430, 287);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(234, 69);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbWelcomePage
            // 
            this.pbWelcomePage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbWelcomePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbWelcomePage.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbWelcomePage.Image = ((System.Drawing.Image)(resources.GetObject("pbWelcomePage.Image")));
            this.pbWelcomePage.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbWelcomePage.InitialImage")));
            this.pbWelcomePage.Location = new System.Drawing.Point(23, 12);
            this.pbWelcomePage.Name = "pbWelcomePage";
            this.pbWelcomePage.Size = new System.Drawing.Size(480, 388);
            this.pbWelcomePage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWelcomePage.TabIndex = 3;
            this.pbWelcomePage.TabStop = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(33, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(247, 50);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Welcome to";
            // 
            // lblWallStreet
            // 
            this.lblWallStreet.AutoSize = true;
            this.lblWallStreet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblWallStreet.Font = new System.Drawing.Font("Modern No. 20", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWallStreet.Location = new System.Drawing.Point(1, 57);
            this.lblWallStreet.Name = "lblWallStreet";
            this.lblWallStreet.Size = new System.Drawing.Size(345, 70);
            this.lblWallStreet.TabIndex = 5;
            this.lblWallStreet.Text = "Wall Street";
            // 
            // WelcomeForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(692, 412);
            this.Controls.Add(this.lblWallStreet);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.bntLogIn);
            this.Controls.Add(this.btnNewPlayer);
            this.Controls.Add(this.pbWelcomePage);
            this.Name = "WelcomeForm";
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.pbWelcomePage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button btnNewPlayer;
        private System.Windows.Forms.Button bntLogIn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbWelcomePage;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblWallStreet;
    }
}