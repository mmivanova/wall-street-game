using System.Collections.Generic;
using WallStreet.Models;

namespace WallStreet.Services.StockServices
{
    internal interface IStockService
    {
        List<Stock> GetAll();
        Stock Get(int stockId);
    }
}
