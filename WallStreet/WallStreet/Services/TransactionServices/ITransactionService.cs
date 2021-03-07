using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WallStreet.Models;

namespace WallStreet.Services.TransactionServices
{
    internal interface ITransactionService
    {
        Transaction Get(int transactionId);
        List<Transaction> GetAll();
        void BuyStocks(int quantity, Stock stock, int userId);
        void SellStocks(int quantity, Stock stock, int userId);
    }
}
