using WallStreet.Models;

namespace WallStreet.Services.UserServices
{
    interface IUserService
    {
        User CreateUser(string firstName, string lastName, string email, string username, string password);
        bool IsSuccessfulCreationOfUser(string username);
        User GetUser(string username);
        User GetUser(Account account);
    }
}
