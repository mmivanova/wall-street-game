using System;
using System.Windows.Forms;
using WallStreet.Models;
using WallStreet.Services.UserServices;

namespace WallStreet.Forms
{
    public partial class MainPageForm : Form
    {
        private readonly IUserService userService = new UserService();
        private readonly User user;
       
        public MainPageForm(string username)
        {
            InitializeComponent();
            this.user = userService.GetUser(username);
        }

        private void btnRanking_Click(object sender, EventArgs e)
        {

        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            var accountForm = new ProfileForm(user);
            accountForm.Closed += (s, args) => this.Close();
            accountForm.Show();
        }
    }
}
