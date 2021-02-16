namespace WallStreet.Models
{
    class Stock
    {
        public int StockId { get; set; }
        public string Ticker { get; set; }
        public string Company { get; set; }
        public decimal Price { get; set; }
    }
}
