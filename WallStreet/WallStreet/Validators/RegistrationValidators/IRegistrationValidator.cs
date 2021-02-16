using System.ComponentModel;

namespace WallStreet.Validators.RegistrationValidators
{
    interface IRegistrationValidator
    {
        bool IsValidFirstName(string firstName);
        bool IsValidLastName(string lastName);
        bool IsValidEmail(string email);
        bool IsValidUsername(string username);
        bool IsValidPassword(string password);
    }
}
