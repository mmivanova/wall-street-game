
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
            this.btnBackToMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvRank
            // 
            this.lvRank.HideSelection = false;
            this.lvRank.Location = new System.Drawing.Point(12, 12);
            this.lvRank.Name = "lvRank";
            this.lvRank.Size = new System.Drawing.Size(417, 310);
            this.lvRank.TabIndex = 0;
            this.lvRank.UseCompatibleStateImageBehavior = false;
            this.lvRank.View = System.Windows.Forms.View.List;
            this.lvRank.SelectedIndexChanged += new System.EventHandler(this.lvRank_SelectedIndexChanged);
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.BackColor = System.Drawing.Color.YellowGreen;
            this.btnBackToMain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBackToMain.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMain.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnBackToMain.Location = new System.Drawing.Point(12, 393);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(102, 45);
            this.btnBackToMain.TabIndex = 16;
            this.btnBackToMain.Text = "Back";
            this.btnBackToMain.UseVisualStyleBackColor = false;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // RankingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 450);
            this.Controls.Add(this.btnBackToMain);
            this.Controls.Add(this.lvRank);
            this.Name = "RankingForm";
            this.Text = "RankingForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvRank;
        private System.Windows.Forms.Button btnBackToMain;
    }
}