
namespace WallStreet.Forms
{
    partial class MarketForm
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
            this.lblTesla = new System.Windows.Forms.Label();
            this.lblApple = new System.Windows.Forms.Label();
            this.lblMicrosoft = new System.Windows.Forms.Label();
            this.lblNvidia = new System.Windows.Forms.Label();
            this.lblModerna = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.tbTeslaPrice = new System.Windows.Forms.TextBox();
            this.tbApplePrice = new System.Windows.Forms.TextBox();
            this.tbMicrosoftPrice = new System.Windows.Forms.TextBox();
            this.tbNvidiaPrice = new System.Windows.Forms.TextBox();
            this.tbModernaPrice = new System.Windows.Forms.TextBox();
            this.btnBuyTesla = new System.Windows.Forms.Button();
            this.btnBuyApple = new System.Windows.Forms.Button();
            this.btnBuyMicrosoft = new System.Windows.Forms.Button();
            this.btnBuyNvidia = new System.Windows.Forms.Button();
            this.btnBuyModerna = new System.Windows.Forms.Button();
            this.btnSellTesla = new System.Windows.Forms.Button();
            this.btnSellApple = new System.Windows.Forms.Button();
            this.btnSellMicrosoft = new System.Windows.Forms.Button();
            this.btnSellNvidia = new System.Windows.Forms.Button();
            this.btnSellModerna = new System.Windows.Forms.Button();
            this.btnBackToMarket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTesla
            // 
            this.lblTesla.AutoSize = true;
            this.lblTesla.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTesla.Location = new System.Drawing.Point(55, 102);
            this.lblTesla.Name = "lblTesla";
            this.lblTesla.Size = new System.Drawing.Size(79, 38);
            this.lblTesla.TabIndex = 0;
            this.lblTesla.Text = "TSLA";
            // 
            // lblApple
            // 
            this.lblApple.AutoSize = true;
            this.lblApple.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApple.Location = new System.Drawing.Point(55, 162);
            this.lblApple.Name = "lblApple";
            this.lblApple.Size = new System.Drawing.Size(82, 38);
            this.lblApple.TabIndex = 1;
            this.lblApple.Text = "AAPL";
            // 
            // lblMicrosoft
            // 
            this.lblMicrosoft.AutoSize = true;
            this.lblMicrosoft.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMicrosoft.Location = new System.Drawing.Point(55, 225);
            this.lblMicrosoft.Name = "lblMicrosoft";
            this.lblMicrosoft.Size = new System.Drawing.Size(86, 38);
            this.lblMicrosoft.TabIndex = 2;
            this.lblMicrosoft.Text = "MSFT";
            // 
            // lblNvidia
            // 
            this.lblNvidia.AutoSize = true;
            this.lblNvidia.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNvidia.Location = new System.Drawing.Point(55, 287);
            this.lblNvidia.Name = "lblNvidia";
            this.lblNvidia.Size = new System.Drawing.Size(93, 38);
            this.lblNvidia.TabIndex = 3;
            this.lblNvidia.Text = "NVDA";
            // 
            // lblModerna
            // 
            this.lblModerna.AutoSize = true;
            this.lblModerna.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModerna.Location = new System.Drawing.Point(55, 345);
            this.lblModerna.Name = "lblModerna";
            this.lblModerna.Size = new System.Drawing.Size(98, 38);
            this.lblModerna.TabIndex = 4;
            this.lblModerna.Text = "MRNA";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblStock.Location = new System.Drawing.Point(46, 26);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(98, 45);
            this.lblStock.TabIndex = 5;
            this.lblStock.Text = "Stock";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblPrice.Location = new System.Drawing.Point(227, 26);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(89, 45);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price";
            // 
            // tbTeslaPrice
            // 
            this.tbTeslaPrice.BackColor = System.Drawing.Color.Honeydew;
            this.tbTeslaPrice.Enabled = false;
            this.tbTeslaPrice.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTeslaPrice.Location = new System.Drawing.Point(199, 102);
            this.tbTeslaPrice.Name = "tbTeslaPrice";
            this.tbTeslaPrice.ReadOnly = true;
            this.tbTeslaPrice.Size = new System.Drawing.Size(133, 30);
            this.tbTeslaPrice.TabIndex = 10;
            this.tbTeslaPrice.Text = "598$";
            this.tbTeslaPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbApplePrice
            // 
            this.tbApplePrice.BackColor = System.Drawing.Color.Honeydew;
            this.tbApplePrice.Enabled = false;
            this.tbApplePrice.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApplePrice.Location = new System.Drawing.Point(199, 162);
            this.tbApplePrice.Name = "tbApplePrice";
            this.tbApplePrice.ReadOnly = true;
            this.tbApplePrice.Size = new System.Drawing.Size(133, 30);
            this.tbApplePrice.TabIndex = 11;
            this.tbApplePrice.Text = "121$";
            this.tbApplePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbMicrosoftPrice
            // 
            this.tbMicrosoftPrice.BackColor = System.Drawing.Color.Honeydew;
            this.tbMicrosoftPrice.Enabled = false;
            this.tbMicrosoftPrice.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMicrosoftPrice.Location = new System.Drawing.Point(199, 225);
            this.tbMicrosoftPrice.Name = "tbMicrosoftPrice";
            this.tbMicrosoftPrice.ReadOnly = true;
            this.tbMicrosoftPrice.Size = new System.Drawing.Size(133, 30);
            this.tbMicrosoftPrice.TabIndex = 12;
            this.tbMicrosoftPrice.Text = "232$";
            this.tbMicrosoftPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbNvidiaPrice
            // 
            this.tbNvidiaPrice.BackColor = System.Drawing.Color.Honeydew;
            this.tbNvidiaPrice.Enabled = false;
            this.tbNvidiaPrice.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNvidiaPrice.Location = new System.Drawing.Point(199, 287);
            this.tbNvidiaPrice.Name = "tbNvidiaPrice";
            this.tbNvidiaPrice.ReadOnly = true;
            this.tbNvidiaPrice.Size = new System.Drawing.Size(133, 30);
            this.tbNvidiaPrice.TabIndex = 13;
            this.tbNvidiaPrice.Text = "498$";
            this.tbNvidiaPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbModernaPrice
            // 
            this.tbModernaPrice.BackColor = System.Drawing.Color.Honeydew;
            this.tbModernaPrice.Enabled = false;
            this.tbModernaPrice.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModernaPrice.Location = new System.Drawing.Point(199, 353);
            this.tbModernaPrice.Name = "tbModernaPrice";
            this.tbModernaPrice.ReadOnly = true;
            this.tbModernaPrice.Size = new System.Drawing.Size(133, 30);
            this.tbModernaPrice.TabIndex = 14;
            this.tbModernaPrice.Text = "132$";
            this.tbModernaPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBuyTesla
            // 
            this.btnBuyTesla.BackColor = System.Drawing.Color.YellowGreen;
            this.btnBuyTesla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuyTesla.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyTesla.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnBuyTesla.Location = new System.Drawing.Point(432, 91);
            this.btnBuyTesla.Name = "btnBuyTesla";
            this.btnBuyTesla.Size = new System.Drawing.Size(102, 45);
            this.btnBuyTesla.TabIndex = 15;
            this.btnBuyTesla.Text = "Buy";
            this.btnBuyTesla.UseVisualStyleBackColor = false;
            this.btnBuyTesla.Click += new System.EventHandler(this.btnBuyTesla_Click);
            // 
            // btnBuyApple
            // 
            this.btnBuyApple.BackColor = System.Drawing.Color.YellowGreen;
            this.btnBuyApple.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuyApple.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyApple.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnBuyApple.Location = new System.Drawing.Point(432, 151);
            this.btnBuyApple.Name = "btnBuyApple";
            this.btnBuyApple.Size = new System.Drawing.Size(102, 45);
            this.btnBuyApple.TabIndex = 16;
            this.btnBuyApple.Text = "Buy";
            this.btnBuyApple.UseVisualStyleBackColor = false;
            this.btnBuyApple.Click += new System.EventHandler(this.btnBuyApple_Click);
            // 
            // btnBuyMicrosoft
            // 
            this.btnBuyMicrosoft.BackColor = System.Drawing.Color.YellowGreen;
            this.btnBuyMicrosoft.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuyMicrosoft.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyMicrosoft.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnBuyMicrosoft.Location = new System.Drawing.Point(432, 214);
            this.btnBuyMicrosoft.Name = "btnBuyMicrosoft";
            this.btnBuyMicrosoft.Size = new System.Drawing.Size(102, 45);
            this.btnBuyMicrosoft.TabIndex = 17;
            this.btnBuyMicrosoft.Text = "Buy";
            this.btnBuyMicrosoft.UseVisualStyleBackColor = false;
            this.btnBuyMicrosoft.Click += new System.EventHandler(this.btnBuyMicrosoft_Click);
            // 
            // btnBuyNvidia
            // 
            this.btnBuyNvidia.BackColor = System.Drawing.Color.YellowGreen;
            this.btnBuyNvidia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuyNvidia.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyNvidia.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnBuyNvidia.Location = new System.Drawing.Point(432, 280);
            this.btnBuyNvidia.Name = "btnBuyNvidia";
            this.btnBuyNvidia.Size = new System.Drawing.Size(102, 45);
            this.btnBuyNvidia.TabIndex = 18;
            this.btnBuyNvidia.Text = "Buy";
            this.btnBuyNvidia.UseVisualStyleBackColor = false;
            this.btnBuyNvidia.Click += new System.EventHandler(this.btnBuyNvidia_Click);
            // 
            // btnBuyModerna
            // 
            this.btnBuyModerna.BackColor = System.Drawing.Color.YellowGreen;
            this.btnBuyModerna.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuyModerna.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyModerna.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnBuyModerna.Location = new System.Drawing.Point(432, 345);
            this.btnBuyModerna.Name = "btnBuyModerna";
            this.btnBuyModerna.Size = new System.Drawing.Size(102, 45);
            this.btnBuyModerna.TabIndex = 19;
            this.btnBuyModerna.Text = "Buy";
            this.btnBuyModerna.UseVisualStyleBackColor = false;
            this.btnBuyModerna.Click += new System.EventHandler(this.btnBuyModerna_Click);
            // 
            // btnSellTesla
            // 
            this.btnSellTesla.BackColor = System.Drawing.Color.Red;
            this.btnSellTesla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSellTesla.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellTesla.ForeColor = System.Drawing.Color.Maroon;
            this.btnSellTesla.Location = new System.Drawing.Point(600, 91);
            this.btnSellTesla.Name = "btnSellTesla";
            this.btnSellTesla.Size = new System.Drawing.Size(102, 45);
            this.btnSellTesla.TabIndex = 20;
            this.btnSellTesla.Text = "Sell";
            this.btnSellTesla.UseVisualStyleBackColor = false;
            this.btnSellTesla.Click += new System.EventHandler(this.btnSellTesla_Click);
            // 
            // btnSellApple
            // 
            this.btnSellApple.BackColor = System.Drawing.Color.Red;
            this.btnSellApple.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSellApple.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellApple.ForeColor = System.Drawing.Color.Maroon;
            this.btnSellApple.Location = new System.Drawing.Point(600, 151);
            this.btnSellApple.Name = "btnSellApple";
            this.btnSellApple.Size = new System.Drawing.Size(102, 45);
            this.btnSellApple.TabIndex = 21;
            this.btnSellApple.Text = "Sell";
            this.btnSellApple.UseVisualStyleBackColor = false;
            this.btnSellApple.Click += new System.EventHandler(this.btnSellApple_Click);
            // 
            // btnSellMicrosoft
            // 
            this.btnSellMicrosoft.BackColor = System.Drawing.Color.Red;
            this.btnSellMicrosoft.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSellMicrosoft.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellMicrosoft.ForeColor = System.Drawing.Color.Maroon;
            this.btnSellMicrosoft.Location = new System.Drawing.Point(600, 214);
            this.btnSellMicrosoft.Name = "btnSellMicrosoft";
            this.btnSellMicrosoft.Size = new System.Drawing.Size(102, 45);
            this.btnSellMicrosoft.TabIndex = 22;
            this.btnSellMicrosoft.Text = "Sell";
            this.btnSellMicrosoft.UseVisualStyleBackColor = false;
            this.btnSellMicrosoft.Click += new System.EventHandler(this.btnSellMicrosoft_Click);
            // 
            // btnSellNvidia
            // 
            this.btnSellNvidia.BackColor = System.Drawing.Color.Red;
            this.btnSellNvidia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSellNvidia.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellNvidia.ForeColor = System.Drawing.Color.Maroon;
            this.btnSellNvidia.Location = new System.Drawing.Point(600, 280);
            this.btnSellNvidia.Name = "btnSellNvidia";
            this.btnSellNvidia.Size = new System.Drawing.Size(102, 45);
            this.btnSellNvidia.TabIndex = 23;
            this.btnSellNvidia.Text = "Sell";
            this.btnSellNvidia.UseVisualStyleBackColor = false;
            this.btnSellNvidia.Click += new System.EventHandler(this.btnSellNvidia_Click);
            // 
            // btnSellModerna
            // 
            this.btnSellModerna.BackColor = System.Drawing.Color.Red;
            this.btnSellModerna.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSellModerna.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellModerna.ForeColor = System.Drawing.Color.Maroon;
            this.btnSellModerna.Location = new System.Drawing.Point(600, 345);
            this.btnSellModerna.Name = "btnSellModerna";
            this.btnSellModerna.Size = new System.Drawing.Size(102, 45);
            this.btnSellModerna.TabIndex = 24;
            this.btnSellModerna.Text = "Sell";
            this.btnSellModerna.UseVisualStyleBackColor = false;
            this.btnSellModerna.Click += new System.EventHandler(this.btnSellModerna_Click);
            // 
            // btnBackToMarket
            // 
            this.btnBackToMarket.BackColor = System.Drawing.Color.YellowGreen;
            this.btnBackToMarket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBackToMarket.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMarket.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnBackToMarket.Location = new System.Drawing.Point(12, 418);
            this.btnBackToMarket.Name = "btnBackToMarket";
            this.btnBackToMarket.Size = new System.Drawing.Size(102, 45);
            this.btnBackToMarket.TabIndex = 25;
            this.btnBackToMarket.Text = "Back";
            this.btnBackToMarket.UseVisualStyleBackColor = false;
            this.btnBackToMarket.Click += new System.EventHandler(this.btnBackToMarket_Click);
            // 
            // MarketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.btnBackToMarket);
            this.Controls.Add(this.btnSellModerna);
            this.Controls.Add(this.btnSellNvidia);
            this.Controls.Add(this.btnSellMicrosoft);
            this.Controls.Add(this.btnSellApple);
            this.Controls.Add(this.btnSellTesla);
            this.Controls.Add(this.btnBuyModerna);
            this.Controls.Add(this.btnBuyNvidia);
            this.Controls.Add(this.btnBuyMicrosoft);
            this.Controls.Add(this.btnBuyApple);
            this.Controls.Add(this.btnBuyTesla);
            this.Controls.Add(this.tbModernaPrice);
            this.Controls.Add(this.tbNvidiaPrice);
            this.Controls.Add(this.tbMicrosoftPrice);
            this.Controls.Add(this.tbApplePrice);
            this.Controls.Add(this.tbTeslaPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblModerna);
            this.Controls.Add(this.lblNvidia);
            this.Controls.Add(this.lblMicrosoft);
            this.Controls.Add(this.lblApple);
            this.Controls.Add(this.lblTesla);
            this.Name = "MarketForm";
            this.Text = "MarketForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTesla;
        private System.Windows.Forms.Label lblApple;
        private System.Windows.Forms.Label lblMicrosoft;
        private System.Windows.Forms.Label lblNvidia;
        private System.Windows.Forms.Label lblModerna;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox tbTeslaPrice;
        private System.Windows.Forms.TextBox tbApplePrice;
        private System.Windows.Forms.TextBox tbMicrosoftPrice;
        private System.Windows.Forms.TextBox tbNvidiaPrice;
        private System.Windows.Forms.TextBox tbModernaPrice;
        private System.Windows.Forms.Button btnBuyTesla;
        private System.Windows.Forms.Button btnBuyApple;
        private System.Windows.Forms.Button btnBuyMicrosoft;
        private System.Windows.Forms.Button btnBuyNvidia;
        private System.Windows.Forms.Button btnBuyModerna;
        private System.Windows.Forms.Button btnSellTesla;
        private System.Windows.Forms.Button btnSellApple;
        private System.Windows.Forms.Button btnSellMicrosoft;
        private System.Windows.Forms.Button btnSellNvidia;
        private System.Windows.Forms.Button btnSellModerna;
        private System.Windows.Forms.Button btnBackToMarket;
    }
}