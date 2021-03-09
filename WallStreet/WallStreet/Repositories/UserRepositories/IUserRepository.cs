using System.Collections.Generic;
using WallStreet.Models;

namespace WallStreet.Repositories.UserRepositories
{
    internal interface IUserRepository
    {
        List<User> GetAll();
        User Create(string firstName, string lastName, string email, int accountId);
        bool IsSuccessfulCreationOfUser(string username);
        User Get(string email);
        User GetByUserId(int userId);
        User Get(int accountId);
        void Delete(int accountId);
        void Update(string email, User user);
    }
}
