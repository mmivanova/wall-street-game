using System.Collections.Generic;
using MySql.Data.MySqlClient;
using WallStreet.Models;

namespace WallStreet.Repositories.StockRepositories
{
    internal class StockRepository : IStockRepository
    {
        private readonly Database.DbContext context = new Database.DbContext();
        
        public List<Stock> GetAll()
        {
            List<Stock> stocks = new List<Stock>();
            context.OpenConnection();
            string query = "SELECT * FROM Stock";
            MySqlCommand cmd = new MySqlCommand(query, context.GetConnection());
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                Stock stock = new Stock
                {
                    StockId = int.Parse(dataReader["StockId"] + ""),
                    Ticker = dataReader["Ticker"] + "",
                    Company = dataReader["Company"] + "",
                    Price = decimal.Parse(dataReader["Price"] + "")
                };
                stocks.Add(stock);
            }
            dataReader.Close();
            context.CloseConnection();

            return stocks;
        }

        public Stock Get(int stockId)
        {
            Stock stock = GetAll().Find(s => s.StockId.Equals(stockId));
            return stock;
        }

    }
}
