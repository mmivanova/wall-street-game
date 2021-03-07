using System.Drawing;

namespace WallStreet.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int AccountId { get; set; }
        public decimal Money { get; set; }
        public int StockCapacity { get; set; }
        public Bitmap ProfilePicture { get; set; }

        public User()
        {
            
        }

        public User(string firstName, string lastName, string email, int accountId)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.AccountId = accountId;
            this.Money = 10000;
            this.StockCapacity = 100;
        }
    }
}
