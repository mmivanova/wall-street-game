using System.Windows.Forms;
using WallStreet.Models;
using WallStreet.Services.ProfileServices;

namespace WallStreet.Forms
{
    public partial class ProfileForm : Form
    {
        private readonly User user;
        private readonly IProfileService profileService = new ProfileService();

        public ProfileForm(User user)
        {
            InitializeComponent();
            this.user = user;
            tbFirstName.TabStop = false;
            tbFirstName.Text = user.FirstName;
            tbLastName.Text = user.LastName;
            tbEmail.Text = user.Email;
            lblUsername.Text = user.Account.Username;
            pbProfilePicture.BackgroundImageLayout = ImageLayout.Zoom;
            pbProfilePicture.BackgroundImage = user.ProfilePicture;
        }

        private void btnBackToMain_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            var mainPage = new MainPageForm(lblUsername.Text);
            mainPage.Closed += (s, args) => this.Close();
            mainPage.Show();
        }

        private void btnUpdateProfilePicture_Click(object sender, System.EventArgs e)
        {
            profileService.SaveProfilePicture(lblImagePath.Text, pbProfilePicture, user);
        }
    }
}
