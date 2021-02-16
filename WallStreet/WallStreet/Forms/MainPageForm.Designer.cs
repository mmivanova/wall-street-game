namespace WallStreet.Forms
{
    partial class MainPageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPageForm));
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnStockMarket = new System.Windows.Forms.Button();
            this.btnRanking = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAccount
            // 
            this.btnAccount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAccount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAccount.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAccount.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.Black;
            this.btnAccount.Location = new System.Drawing.Point(12, 12);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(158, 54);
            this.btnAccount.TabIndex = 0;
            this.btnAccount.Text = "Account";
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnStockMarket
            // 
            this.btnStockMarket.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStockMarket.BackColor = System.Drawing.Color.LawnGreen;
            this.btnStockMarket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStockMarket.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnStockMarket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStockMarket.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockMarket.ForeColor = System.Drawing.Color.Black;
            this.btnStockMarket.Location = new System.Drawing.Point(310, 12);
            this.btnStockMarket.Name = "btnStockMarket";
            this.btnStockMarket.Size = new System.Drawing.Size(158, 108);
            this.btnStockMarket.TabIndex = 1;
            this.btnStockMarket.Text = "Stock Market";
            this.btnStockMarket.UseVisualStyleBackColor = false;
            // 
            // btnRanking
            // 
            this.btnRanking.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRanking.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRanking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRanking.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnRanking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRanking.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRanking.ForeColor = System.Drawing.Color.Black;
            this.btnRanking.Location = new System.Drawing.Point(598, 12);
            this.btnRanking.Name = "btnRanking";
            this.btnRanking.Size = new System.Drawing.Size(158, 54);
            this.btnRanking.TabIndex = 2;
            this.btnRanking.Text = "Ranking";
            this.btnRanking.UseVisualStyleBackColor = false;
            this.btnRanking.Click += new System.EventHandler(this.btnRanking_Click);
            // 
            // MainPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(768, 531);
            this.Controls.Add(this.btnRanking);
            this.Controls.Add(this.btnStockMarket);
            this.Controls.Add(this.btnAccount);
            this.DoubleBuffered = true;
            this.Name = "MainPageForm";
            this.Text = "MainPageForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnStockMarket;
        private System.Windows.Forms.Button btnRanking;
    }
}