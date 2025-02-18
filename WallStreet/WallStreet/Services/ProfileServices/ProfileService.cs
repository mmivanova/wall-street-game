﻿using System.Windows.Forms;
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
