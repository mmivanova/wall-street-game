namespace WallStreet.Forms
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            this.lblGeneralInfo = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblWealth = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblStockCapacity = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbMoney = new System.Windows.Forms.TextBox();
            this.tbStockCapacity = new System.Windows.Forms.TextBox();
            this.btnBackToMain = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.pbProfilePicture = new System.Windows.Forms.PictureBox();
            this.btnUpdateProfilePicture = new System.Windows.Forms.Button();
            this.lblImagePath = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGeneralInfo
            // 
            this.lblGeneralInfo.AutoSize = true;
            this.lblGeneralInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneralInfo.Location = new System.Drawing.Point(12, 9);
            this.lblGeneralInfo.Name = "lblGeneralInfo";
            this.lblGeneralInfo.Size = new System.Drawing.Size(266, 32);
            this.lblGeneralInfo.TabIndex = 16;
            this.lblGeneralInfo.Text = "General information";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(17, 64);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(103, 25);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(17, 108);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(103, 25);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(17, 148);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(67, 25);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "E-mail";
            // 
            // lblWealth
            // 
            this.lblWealth.AutoSize = true;
            this.lblWealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWealth.Location = new System.Drawing.Point(13, 251);
            this.lblWealth.Name = "lblWealth";
            this.lblWealth.Size = new System.Drawing.Size(104, 32);
            this.lblWealth.TabIndex = 4;
            this.lblWealth.Text = "Wealth";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.Location = new System.Drawing.Point(17, 295);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(72, 25);
            this.lblMoney.TabIndex = 5;
            this.lblMoney.Text = "Money";
            // 
            // lblStockCapacity
            // 
            this.lblStockCapacity.AutoSize = true;
            this.lblStockCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockCapacity.Location = new System.Drawing.Point(17, 339);
            this.lblStockCapacity.Name = "lblStockCapacity";
            this.lblStockCapacity.Size = new System.Drawing.Size(139, 25);
            this.lblStockCapacity.TabIndex = 6;
            this.lblStockCapacity.Text = "Stock capacity";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(626, 209);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(102, 25);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "Username";
            // 
            // tbFirstName
            // 
            this.tbFirstName.BackColor = System.Drawing.Color.Honeydew;
            this.tbFirstName.Enabled = false;
            this.tbFirstName.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName.Location = new System.Drawing.Point(146, 63);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.ReadOnly = true;
            this.tbFirstName.Size = new System.Drawing.Size(235, 30);
            this.tbFirstName.TabIndex = 9;
            // 
            // tbLastName
            // 
            this.tbLastName.BackColor = System.Drawing.Color.Honeydew;
            this.tbLastName.Enabled = false;
            this.tbLastName.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName.Location = new System.Drawing.Point(146, 103);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.ReadOnly = true;
            this.tbLastName.Size = new System.Drawing.Size(235, 30);
            this.tbLastName.TabIndex = 10;
            this.tbLastName.TabStop = false;
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.Honeydew;
            this.tbEmail.Enabled = false;
            this.tbEmail.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(146, 143);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.ReadOnly = true;
            this.tbEmail.Size = new System.Drawing.Size(235, 30);
            this.tbEmail.TabIndex = 11;
            this.tbEmail.TabStop = false;
            // 
            // tbMoney
            // 
            this.tbMoney.BackColor = System.Drawing.Color.Honeydew;
            this.tbMoney.Enabled = false;
            this.tbMoney.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMoney.Location = new System.Drawing.Point(146, 290);
            this.tbMoney.Name = "tbMoney";
            this.tbMoney.ReadOnly = true;
            this.tbMoney.Size = new System.Drawing.Size(235, 30);
            this.tbMoney.TabIndex = 12;
            this.tbMoney.TabStop = false;
            // 
            // tbStockCapacity
            // 
            this.tbStockCapacity.BackColor = System.Drawing.Color.Honeydew;
            this.tbStockCapacity.Enabled = false;
            this.tbStockCapacity.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStockCapacity.Location = new System.Drawing.Point(173, 334);
            this.tbStockCapacity.Name = "tbStockCapacity";
            this.tbStockCapacity.ReadOnly = true;
            this.tbStockCapacity.Size = new System.Drawing.Size(208, 30);
            this.tbStockCapacity.TabIndex = 13;
            this.tbStockCapacity.TabStop = false;
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.BackColor = System.Drawing.Color.YellowGreen;
            this.btnBackToMain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBackToMain.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMain.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnBackToMain.Location = new System.Drawing.Point(12, 394);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(146, 44);
            this.btnBackToMain.TabIndex = 14;
            this.btnBackToMain.Text = "Back to main";
            this.btnBackToMain.UseVisualStyleBackColor = false;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.YellowGreen;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSettings.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSettings.Location = new System.Drawing.Point(642, 394);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(146, 44);
            this.btnSettings.TabIndex = 15;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // pbProfilePicture
            // 
            this.pbProfilePicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbProfilePicture.BackgroundImage")));
            this.pbProfilePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbProfilePicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbProfilePicture.InitialImage")));
            this.pbProfilePicture.Location = new System.Drawing.Point(554, 25);
            this.pbProfilePicture.Name = "pbProfilePicture";
            this.pbProfilePicture.Size = new System.Drawing.Size(234, 169);
            this.pbProfilePicture.TabIndex = 17;
            this.pbProfilePicture.TabStop = false;
            // 
            // btnUpdateProfilePicture
            // 
            this.btnUpdateProfilePicture.BackColor = System.Drawing.Color.YellowGreen;
            this.btnUpdateProfilePicture.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateProfilePicture.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProfilePicture.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnUpdateProfilePicture.Location = new System.Drawing.Point(577, 237);
            this.btnUpdateProfilePicture.Name = "btnUpdateProfilePicture";
            this.btnUpdateProfilePicture.Size = new System.Drawing.Size(195, 30);
            this.btnUpdateProfilePicture.TabIndex = 18;
            this.btnUpdateProfilePicture.Text = "Update profile picture";
            this.btnUpdateProfilePicture.UseVisualStyleBackColor = false;
            this.btnUpdateProfilePicture.Click += new System.EventHandler(this.btnUpdateProfilePicture_Click);
            // 
            // lblImagePath
            // 
            this.lblImagePath.AutoSize = true;
            this.lblImagePath.Location = new System.Drawing.Point(593, 284);
            this.lblImagePath.Name = "lblImagePath";
            this.lblImagePath.Size = new System.Drawing.Size(0, 17);
            this.lblImagePath.TabIndex = 19;
            this.lblImagePath.Visible = false;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblImagePath);
            this.Controls.Add(this.btnUpdateProfilePicture);
            this.Controls.Add(this.pbProfilePicture);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnBackToMain);
            this.Controls.Add(this.tbStockCapacity);
            this.Controls.Add(this.tbMoney);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblStockCapacity);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblWealth);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblGeneralInfo);
            this.Name = "ProfileForm";
            this.Text = "Profile";
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGeneralInfo;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblWealth;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblStockCapacity;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbMoney;
        private System.Windows.Forms.TextBox tbStockCapacity;
        private System.Windows.Forms.Button btnBackToMain;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.PictureBox pbProfilePicture;
        private System.Windows.Forms.Button btnUpdateProfilePicture;
        private System.Windows.Forms.Label lblImagePath;
    }
}