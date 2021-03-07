using System.Collections.Generic;
using WallStreet.Models;
using WallStreet.Repositories.StockRepositories;

namespace WallStreet.Services.StockServices
{
    internal class StockService : IStockService
    {
        private readonly IStockRepository stockRepository = new StockRepository();

        public List<Stock> GetAll()
        {
            return stockRepository.GetAll();
        }

        public Stock Get(int stockId)
        {
            return stockRepository.Get(stockId);
        }
    }
}
