using System.Drawing;

namespace WallStreet.Models
{
    public class User
    {
        public int UserId { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public Account Account { get; private set; }
        public Bitmap ProfilePicture { get; set; }

        public User(string firstName, string lastName, string email, Account account)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Account = account;
        }
    }
}
