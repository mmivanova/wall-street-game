using System.Drawing;
using System.Windows.Forms;
using WallStreet.Models;

namespace WallStreet.Repositories.ProfileRepositories
{
    class ProfileRepository : IProfileRepository
    {
        public void SaveProfilePicture(string path, PictureBox pictureBox, User user)
        {
            OpenFileDialog opnfd = new OpenFileDialog
            {
                Title = "Choose new profile picture",
                Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif"
            };
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                path = opnfd.FileName;
                pictureBox.BackgroundImage = new Bitmap(path);
                user.ProfilePicture = (Bitmap)pictureBox.BackgroundImage;
                pictureBox.BackgroundImageLayout = ImageLayout.Zoom;
                // File.Copy(lblImagePath.Text, Path.Combine(@"D:\uni-plovdiv\Programs\WallStreet\WallStreet\ProfilePictures", Path.GetFileName(lblImagePath.Text)), true);
            }
        }
    }
}
