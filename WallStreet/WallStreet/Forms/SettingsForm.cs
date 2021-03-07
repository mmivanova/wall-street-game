using System;
using System.Windows.Forms;
using WallStreet.Models;
using WallStreet.Services.AccountServices;
using WallStreet.Services.UserServices;

namespace WallStreet.Forms
{
    public partial class SettingsForm : Form
    {
        private readonly User user;
        private readonly IUserService userService = new UserService();
        private readonly IAccountService accountService = new AccountService();

        public SettingsForm(int accountId)
        {
            user = userService.Get(accountId);
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = new LoginForm();
            loginForm.Closed += (s, args) => this.Close();
            loginForm.Show();
        }

        private void btnResetAccount_Click(object sender, EventArgs e)
        {
            accountService.Delete(user.AccountId);
            userService.Delete(user.AccountId);
            this.Hide();
            var registerForm = new RegisterForm();
            registerForm.Closed += (s, args) => this.Close();
            registerForm.Show();
        }

        private void btnSaveGame_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Game saved successfully!");
        }
    }
}
