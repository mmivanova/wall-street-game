namespace WallStreet.Forms
{
    partial class SettingsForm
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
            this.btnSaveGame = new System.Windows.Forms.Button();
            this.btnResetAccount = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSaveGame
            // 
            this.btnSaveGame.BackColor = System.Drawing.Color.YellowGreen;
            this.btnSaveGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveGame.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveGame.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSaveGame.Location = new System.Drawing.Point(258, 76);
            this.btnSaveGame.Name = "btnSaveGame";
            this.btnSaveGame.Size = new System.Drawing.Size(256, 73);
            this.btnSaveGame.TabIndex = 0;
            this.btnSaveGame.Text = "Save game";
            this.btnSaveGame.UseVisualStyleBackColor = false;
            this.btnSaveGame.Click += new System.EventHandler(this.btnSaveGame_Click);
            // 
            // btnResetAccount
            // 
            this.btnResetAccount.BackColor = System.Drawing.Color.YellowGreen;
            this.btnResetAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetAccount.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetAccount.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnResetAccount.Location = new System.Drawing.Point(258, 197);
            this.btnResetAccount.Name = "btnResetAccount";
            this.btnResetAccount.Size = new System.Drawing.Size(256, 73);
            this.btnResetAccount.TabIndex = 1;
            this.btnResetAccount.Text = "Reset";
            this.btnResetAccount.UseVisualStyleBackColor = false;
            this.btnResetAccount.Click += new System.EventHandler(this.btnResetAccount_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.YellowGreen;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnLogout.Location = new System.Drawing.Point(258, 320);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(256, 73);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnResetAccount);
            this.Controls.Add(this.btnSaveGame);
            this.Name = "SettingsForm";
            this.Text = " ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaveGame;
        private System.Windows.Forms.Button btnResetAccount;
        private System.Windows.Forms.Button btnLogout;
    }
}