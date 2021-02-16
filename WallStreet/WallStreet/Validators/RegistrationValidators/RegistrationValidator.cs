using System.Text.RegularExpressions;
using WallStreet.Services.AccountServices;

namespace WallStreet.Validators.RegistrationValidators
{
    class RegistrationValidator : IRegistrationValidator
    {
        private readonly IAccountService accountService = new AccountService();


        public bool IsValidEmail(string email)
        {
            bool isValidEmail = true;
            string pattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            Regex regex = new Regex(pattern);
            if (string.IsNullOrWhiteSpace(email) || !regex.IsMatch(email) || email.Length > 50 )
            {
                isValidEmail = false;
            }
            return isValidEmail;
        }

        public bool IsValidFirstName(string firstName)
        {
            bool isValidFirstName = true;
            string pattern = @"[a-zA-Z]{2,}";
            Regex regex = new Regex(pattern);
            if (string.IsNullOrWhiteSpace(firstName) || !regex.IsMatch(firstName) || firstName.Length > 50)
            {
                isValidFirstName = false;
            }
            return isValidFirstName;
        }

        public bool IsValidLastName(string lastName)
        {
            bool isValidLastName = true;
            string pattern = @"[a-zA-Z]{2,}";
            Regex regex = new Regex(pattern);
            if (string.IsNullOrWhiteSpace(lastName) || !regex.IsMatch(lastName) || lastName.Length > 50)
            {
                isValidLastName = false;
            }
            return isValidLastName;
        }

        public bool IsValidPassword(string password)
        {
            bool isValidPassword = true;
            if (password.Length > 25)
            {
                isValidPassword = false;
            }
            return isValidPassword;
        }

        public bool IsValidUsername(string username)
        {
            bool isValidUsername = true;
            if (accountService.GetAll().Find(a=> a.Username.Equals(username)) != null || username.Length > 25)
            {
                isValidUsername = false;
            }
            return isValidUsername;
        }
    }
}
