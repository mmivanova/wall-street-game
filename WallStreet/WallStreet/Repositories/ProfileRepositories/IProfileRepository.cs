using System.Windows.Forms;
using WallStreet.Models;

namespace WallStreet.Repositories.ProfileRepositories
{
    interface IProfileRepository
    {
        void SaveProfilePicture(string path, PictureBox pictureBox, User user);
    }
}
