
namespace WallStreet.Forms
{
    partial class BuySellStockForm
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
            this.lblAction = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblStocksToBuy = new System.Windows.Forms.Label();
            this.tbStocksToBuy = new System.Windows.Forms.TextBox();
            this.lblYouhaveThisMoney = new System.Windows.Forms.Label();
            this.tbCurrentMoney = new System.Windows.Forms.TextBox();
            this.lblDollarSign = new System.Windows.Forms.Label();
            this.btnBuySell = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAction.Location = new System.Drawing.Point(23, 23);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(160, 41);
            this.lblAction.TabIndex = 0;
            this.lblAction.Text = "Buy Stocks";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(12, 145);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(522, 25);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Enter the amount of stocks you would like to buy/must be a whole number/";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMessage.UseCompatibleTextRendering = true;
            // 
            // lblStocksToBuy
            // 
            this.lblStocksToBuy.AutoSize = true;
            this.lblStocksToBuy.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStocksToBuy.Location = new System.Drawing.Point(12, 104);
            this.lblStocksToBuy.Name = "lblStocksToBuy";
            this.lblStocksToBuy.Size = new System.Drawing.Size(196, 38);
            this.lblStocksToBuy.TabIndex = 2;
            this.lblStocksToBuy.Text = "Stocks to buy: ";
            // 
            // tbStocksToBuy
            // 
            this.tbStocksToBuy.BackColor = System.Drawing.Color.Honeydew;
            this.tbStocksToBuy.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStocksToBuy.Location = new System.Drawing.Point(224, 108);
            this.tbStocksToBuy.Name = "tbStocksToBuy";
            this.tbStocksToBuy.Size = new System.Drawing.Size(99, 34);
            this.tbStocksToBuy.TabIndex = 3;
            // 
            // lblYouhaveThisMoney
            // 
            this.lblYouhaveThisMoney.AutoSize = true;
            this.lblYouhaveThisMoney.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYouhaveThisMoney.Location = new System.Drawing.Point(14, 185);
            this.lblYouhaveThisMoney.Name = "lblYouhaveThisMoney";
            this.lblYouhaveThisMoney.Size = new System.Drawing.Size(173, 25);
            this.lblYouhaveThisMoney.TabIndex = 4;
            this.lblYouhaveThisMoney.Text = "You currently have ";
            // 
            // tbCurrentMoney
            // 
            this.tbCurrentMoney.BackColor = System.Drawing.Color.Honeydew;
            this.tbCurrentMoney.Enabled = false;
            this.tbCurrentMoney.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurrentMoney.Location = new System.Drawing.Point(193, 184);
            this.tbCurrentMoney.Name = "tbCurrentMoney";
            this.tbCurrentMoney.ReadOnly = true;
            this.tbCurrentMoney.Size = new System.Drawing.Size(130, 30);
            this.tbCurrentMoney.TabIndex = 11;
            this.tbCurrentMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDollarSign
            // 
            this.lblDollarSign.AutoSize = true;
            this.lblDollarSign.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDollarSign.Location = new System.Drawing.Point(329, 185);
            this.lblDollarSign.Name = "lblDollarSign";
            this.lblDollarSign.Size = new System.Drawing.Size(22, 25);
            this.lblDollarSign.TabIndex = 12;
            this.lblDollarSign.Text = "$";
            // 
            // btnBuySell
            // 
            this.btnBuySell.BackColor = System.Drawing.Color.YellowGreen;
            this.btnBuySell.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuySell.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuySell.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnBuySell.Location = new System.Drawing.Point(464, 242);
            this.btnBuySell.Name = "btnBuySell";
            this.btnBuySell.Size = new System.Drawing.Size(102, 45);
            this.btnBuySell.TabIndex = 16;
            this.btnBuySell.Text = "Buy";
            this.btnBuySell.UseVisualStyleBackColor = false;
            this.btnBuySell.Click += new System.EventHandler(this.btnBuySell_Click);
            // 
            // BuySellStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 299);
            this.Controls.Add(this.btnBuySell);
            this.Controls.Add(this.lblDollarSign);
            this.Controls.Add(this.tbCurrentMoney);
            this.Controls.Add(this.lblYouhaveThisMoney);
            this.Controls.Add(this.tbStocksToBuy);
            this.Controls.Add(this.lblStocksToBuy);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblAction);
            this.Name = "BuySellStockForm";
            this.Text = "BuySellStockForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblStocksToBuy;
        private System.Windows.Forms.TextBox tbStocksToBuy;
        private System.Windows.Forms.Label lblYouhaveThisMoney;
        private System.Windows.Forms.TextBox tbCurrentMoney;
        private System.Windows.Forms.Label lblDollarSign;
        private System.Windows.Forms.Button btnBuySell;
    }
}