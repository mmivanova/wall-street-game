using System.Collections.Generic;
using WallStreet.Models;

namespace WallStreet.Repositories.TransactionRepositories
{
    internal interface ITransactionRepository
    {
        Transaction Get(int transactionId);
        List<Transaction> GetAll();
        Transaction GetByUser(int userId);
        void Create(int stockId, int usesrId, int quantity, decimal price);
        bool BuyStocks(int quantity, Stock stock, int userId);
        void SellStocks(int quantity, Stock stock, int userId);
    }
}
