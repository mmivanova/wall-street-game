namespace WallStreet.Models
{
    public class Account
    {
        public int AccountId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Account()
        {
            
        }

        public Account(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
    }
}
