
namespace WallStreet.Forms
{
    partial class MyStocksForm
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
            this.btnBackToProfile = new System.Windows.Forms.Button();
            this.lvMyStocks = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnBackToProfile
            // 
            this.btnBackToProfile.BackColor = System.Drawing.Color.YellowGreen;
            this.btnBackToProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBackToProfile.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToProfile.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnBackToProfile.Location = new System.Drawing.Point(12, 394);
            this.btnBackToProfile.Name = "btnBackToProfile";
            this.btnBackToProfile.Size = new System.Drawing.Size(146, 44);
            this.btnBackToProfile.TabIndex = 15;
            this.btnBackToProfile.Text = "Back";
            this.btnBackToProfile.UseVisualStyleBackColor = false;
            this.btnBackToProfile.Click += new System.EventHandler(this.btnBackToProfile_Click);
            // 
            // lvMyStocks
            // 
            this.lvMyStocks.HideSelection = false;
            this.lvMyStocks.Location = new System.Drawing.Point(5, 12);
            this.lvMyStocks.Name = "lvMyStocks";
            this.lvMyStocks.Size = new System.Drawing.Size(417, 310);
            this.lvMyStocks.TabIndex = 16;
            this.lvMyStocks.UseCompatibleStateImageBehavior = false;
            this.lvMyStocks.View = System.Windows.Forms.View.List;
            // 
            // MyStocksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 450);
            this.Controls.Add(this.lvMyStocks);
            this.Controls.Add(this.btnBackToProfile);
            this.Name = "MyStocksForm";
            this.Text = "MyStocks";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBackToProfile;
        private System.Windows.Forms.ListView lvMyStocks;
    }
}