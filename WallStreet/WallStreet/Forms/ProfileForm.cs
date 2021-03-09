using System.Windows.Forms;
using WallStreet.Models;
using WallStreet.Services.ProfileServices;
using WallStreet.Services.UserServices;

namespace WallStreet.Forms
{
    public partial class ProfileForm : Form
    {
        private readonly User user;
        private readonly IUserService userService = new UserService();
        private readonly IProfileService profileService = new ProfileService();

        public ProfileForm(Account account)
        {
            InitializeComponent();
            this.user = userService.Get(account.AccountId);
            tbFirstName.TabStop = false;
            tbFirstName.Text = user.FirstName;
            tbLastName.Text = user.LastName;
            tbEmail.Text = user.Email;
            tbMoney.Text = user.Money + "$";
            tbStockCapacity.Text = user.StockCapacity + "/100";
            lblUsername.Text = account.Username;
            pbProfilePicture.BackgroundImageLayout = ImageLayout.Zoom;
            pbProfilePicture.BackgroundImage = user.ProfilePicture;
        }

        private void btnBackToMain_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            var mainPage = new MainPageForm(user.AccountId);
            mainPage.Closed += (s, args) => this.Close();
            mainPage.Show();
        }

        private void btnUpdateProfilePicture_Click(object sender, System.EventArgs e)
        {
            profileService.SaveProfilePicture(lblImagePath.Text, pbProfilePicture, user);
        }

        private void btnSettings_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            var settingsPage = new SettingsForm(user.AccountId);
            settingsPage.Closed += (s, args) => this.Close();
            settingsPage.Show();
        }

        private void btnMyStocks_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            var myStocksForm = new MyStocksForm(user.AccountId);
            myStocksForm.Closed += (s, args) => this.Close();
            myStocksForm.Show();
        }

    }
}
