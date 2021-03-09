namespace WallStreet.Models
{
    class Transaction
    {
        public int TransactionId { get; set; }
        public User User { get; set; }
        public Stock Stock { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public bool IsBought { get; set; }
    }
}
