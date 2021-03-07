using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WallStreet.Models;
using WallStreet.Repositories.ProfileRepositories;

namespace WallStreet.Services.ProfileServices
{
    class ProfileService : IProfileService
    {
        private readonly IProfileRepository profileRepository = new ProfileRepository();

        public void SaveProfilePicture(string path, PictureBox pictureBox, User user)
        {
            profileRepository.SaveProfilePicture(path, pictureBox, user);
        }


    }
}
