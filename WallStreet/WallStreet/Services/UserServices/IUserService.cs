using System.Collections.Generic;
using WallStreet.Models;

namespace WallStreet.Services.UserServices
{
    interface IUserService
    {
        User Create(string firstName, string lastName, string email, int accountId);
        bool IsSuccessfulCreationOfUser(string username);
        // User Get(string email);
        User Get(int accountId);
        List<User> GetAll();
        User GetByUserId(int usesrId);

        void Update(string email, User user);

        void Delete(int accountId);
    }
}
