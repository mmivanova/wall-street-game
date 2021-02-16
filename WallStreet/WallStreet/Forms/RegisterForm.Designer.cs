namespace WallStreet.Forms
{
    partial class RegisterForm
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
            this.lblRegistration = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnRegisterNow = new System.Windows.Forms.Button();
            this.btnBackToWelcomeForm = new System.Windows.Forms.Button();
            this.lblInvalidFirstName = new System.Windows.Forms.Label();
            this.lblInvalidLastName = new System.Windows.Forms.Label();
            this.lblInvalidEmail = new System.Windows.Forms.Label();
            this.lblInvalidUsername = new System.Windows.Forms.Label();
            this.lblInvalidPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRegistration
            // 
            this.lblRegistration.AutoSize = true;
            this.lblRegistration.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistration.Location = new System.Drawing.Point(137, 50);
            this.lblRegistration.Name = "lblRegistration";
            this.lblRegistration.Size = new System.Drawing.Size(326, 62);
            this.lblRegistration.TabIndex = 0;
            this.lblRegistration.Text = "Registration";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(182, 180);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(236, 22);
            this.tbFirstName.TabIndex = 1;
            this.tbFirstName.Text = "First name";
            this.tbFirstName.Click += new System.EventHandler(this.tbFirstName_Click);
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(182, 225);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(236, 22);
            this.tbLastName.TabIndex = 2;
            this.tbLastName.Text = "Last name";
            this.tbLastName.Click += new System.EventHandler(this.tbLastName_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(182, 270);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(236, 22);
            this.tbEmail.TabIndex = 3;
            this.tbEmail.Text = "E-mail";
            this.tbEmail.Click += new System.EventHandler(this.tbEmail_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(182, 315);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(236, 22);
            this.tbUsername.TabIndex = 4;
            this.tbUsername.Text = "Username";
            this.tbUsername.Click += new System.EventHandler(this.tbUsername_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(182, 360);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(236, 22);
            this.tbPassword.TabIndex = 5;
            this.tbPassword.Text = "Password";
            this.tbPassword.Click += new System.EventHandler(this.tbPassword_Click);
            // 
            // btnRegisterNow
            // 
            this.btnRegisterNow.BackColor = System.Drawing.Color.LightGreen;
            this.btnRegisterNow.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnRegisterNow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegisterNow.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterNow.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnRegisterNow.Location = new System.Drawing.Point(212, 405);
            this.btnRegisterNow.Name = "btnRegisterNow";
            this.btnRegisterNow.Size = new System.Drawing.Size(175, 52);
            this.btnRegisterNow.TabIndex = 6;
            this.btnRegisterNow.Text = "Register Now";
            this.btnRegisterNow.UseVisualStyleBackColor = false;
            this.btnRegisterNow.Click += new System.EventHandler(this.btnRegisterNow_Click);
            // 
            // btnBackToWelcomeForm
            // 
            this.btnBackToWelcomeForm.BackColor = System.Drawing.Color.Honeydew;
            this.btnBackToWelcomeForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBackToWelcomeForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBackToWelcomeForm.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToWelcomeForm.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnBackToWelcomeForm.Location = new System.Drawing.Point(12, 489);
            this.btnBackToWelcomeForm.Name = "btnBackToWelcomeForm";
            this.btnBackToWelcomeForm.Size = new System.Drawing.Size(175, 52);
            this.btnBackToWelcomeForm.TabIndex = 7;
            this.btnBackToWelcomeForm.Text = "Back";
            this.btnBackToWelcomeForm.UseVisualStyleBackColor = false;
            this.btnBackToWelcomeForm.Click += new System.EventHandler(this.btnBackToWelcomeForm_Click);
            // 
            // lblInvalidFirstName
            // 
            this.lblInvalidFirstName.AutoSize = true;
            this.lblInvalidFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblInvalidFirstName.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidFirstName.Location = new System.Drawing.Point(179, 205);
            this.lblInvalidFirstName.Name = "lblInvalidFirstName";
            this.lblInvalidFirstName.Size = new System.Drawing.Size(0, 17);
            this.lblInvalidFirstName.TabIndex = 8;
            // 
            // lblInvalidLastName
            // 
            this.lblInvalidLastName.AutoSize = true;
            this.lblInvalidLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblInvalidLastName.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidLastName.Location = new System.Drawing.Point(179, 250);
            this.lblInvalidLastName.Name = "lblInvalidLastName";
            this.lblInvalidLastName.Size = new System.Drawing.Size(0, 17);
            this.lblInvalidLastName.TabIndex = 9;
            // 
            // lblInvalidEmail
            // 
            this.lblInvalidEmail.AutoSize = true;
            this.lblInvalidEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblInvalidEmail.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidEmail.Location = new System.Drawing.Point(179, 295);
            this.lblInvalidEmail.Name = "lblInvalidEmail";
            this.lblInvalidEmail.Size = new System.Drawing.Size(0, 17);
            this.lblInvalidEmail.TabIndex = 10;
            // 
            // lblInvalidUsername
            // 
            this.lblInvalidUsername.AutoSize = true;
            this.lblInvalidUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblInvalidUsername.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidUsername.Location = new System.Drawing.Point(179, 340);
            this.lblInvalidUsername.Name = "lblInvalidUsername";
            this.lblInvalidUsername.Size = new System.Drawing.Size(0, 17);
            this.lblInvalidUsername.TabIndex = 11;
            // 
            // lblInvalidPassword
            // 
            this.lblInvalidPassword.AutoSize = true;
            this.lblInvalidPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblInvalidPassword.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidPassword.Location = new System.Drawing.Point(179, 385);
            this.lblInvalidPassword.Name = "lblInvalidPassword";
            this.lblInvalidPassword.Size = new System.Drawing.Size(0, 17);
            this.lblInvalidPassword.TabIndex = 12;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.lblInvalidPassword);
            this.Controls.Add(this.lblInvalidUsername);
            this.Controls.Add(this.lblInvalidEmail);
            this.Controls.Add(this.lblInvalidLastName);
            this.Controls.Add(this.lblInvalidFirstName);
            this.Controls.Add(this.btnBackToWelcomeForm);
            this.Controls.Add(this.btnRegisterNow);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lblRegistration);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistration;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnRegisterNow;
        private System.Windows.Forms.Button btnBackToWelcomeForm;
        private System.Windows.Forms.Label lblInvalidPassword;
        private System.Windows.Forms.Label lblInvalidUsername;
        private System.Windows.Forms.Label lblInvalidEmail;
        private System.Windows.Forms.Label lblInvalidLastName;
        private System.Windows.Forms.Label lblInvalidFirstName;
    }
}