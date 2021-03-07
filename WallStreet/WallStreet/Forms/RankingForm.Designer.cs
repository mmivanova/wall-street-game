
namespace WallStreet.Forms
{
    partial class RankingForm
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
            this.lvRank = new System.Windows.Forms.ListView();
            this.Player = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Money = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvRank
            // 
            this.lvRank.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Player,
            this.Money});
            this.lvRank.HideSelection = false;
            this.lvRank.Location = new System.Drawing.Point(82, 67);
            this.lvRank.Name = "lvRank";
            this.lvRank.Size = new System.Drawing.Size(587, 310);
            this.lvRank.TabIndex = 0;
            this.lvRank.UseCompatibleStateImageBehavior = false;
            this.lvRank.View = System.Windows.Forms.View.List;
            // 
            // Player
            // 
            this.Player.Text = "";
            // 
            // Money
            // 
            this.Money.Text = "";
            // 
            // RankingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvRank);
            this.Name = "RankingForm";
            this.Text = "RankingForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvRank;
        private System.Windows.Forms.ColumnHeader Player;
        private System.Windows.Forms.ColumnHeader Money;
    }
}