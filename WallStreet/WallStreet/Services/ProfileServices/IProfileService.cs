using System.Windows.Forms;
using WallStreet.Models;

namespace WallStreet.Services.ProfileServices
{
    interface IProfileService
    {
        void SaveProfilePicture(string path, PictureBox pictureBox, User user);
    }
}
