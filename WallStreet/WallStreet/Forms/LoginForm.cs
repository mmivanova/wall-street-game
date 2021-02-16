using System;
using System.Windows.Forms;
using WallStreet.Services.AccountServices;

namespace WallStreet.Forms
{
    public partial class LoginForm : Form
    {
        private readonly IAccountService accountService = new AccountService();

        bool usernameTextBoxFirstClick = true;
        bool passwordTextBoxFirstClick = true;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = tbUsername.Text;
            var password = tbPassword.Text;
            bool isExistingAccount = accountService.IsExistingAccount(username, password);

            if (isExistingAccount)
            {
                this.Hide();
                var mainPage = new MainPageForm(username);
                mainPage.Closed += (s, args) => this.Close();
                mainPage.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Try again!");
            }
        }

        private void tbUsername_Click(object sender, EventArgs e)
        {
            if (usernameTextBoxFirstClick)
            {
                tbUsername.Text = String.Empty;
                usernameTextBoxFirstClick = false;
            }
        }

        private void tbPassword_Click(object sender, EventArgs e)
        {
            if (passwordTextBoxFirstClick)
            {
                tbPassword.Text = String.Empty;
                passwordTextBoxFirstClick = false;
            }
        }

        private void btnCreateAnAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            var registerForm = new RegisterForm();
            registerForm.Closed += (s, args) => this.Close();
            registerForm.Show();
        }

        private void CheckEnterKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
