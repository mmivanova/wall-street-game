using WallStreet.Models;

namespace WallStreet.Repositories.UserRepositories
{
    interface IUserRepository
    {
        User CreateUser(string firstName, string lastName, string email, string username, string password);
        bool IsSuccessfulCreationOfUser(string username);
        User GetUser(string username);
        User GetUser(Account account);
    }
}
