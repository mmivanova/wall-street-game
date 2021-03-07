using System.Collections.Generic;
using WallStreet.Models;

namespace WallStreet.Repositories.StockRepositories
{
    internal interface IStockRepository
    {
        List<Stock> GetAll();
        Stock Get(int stockId);
    }
}
