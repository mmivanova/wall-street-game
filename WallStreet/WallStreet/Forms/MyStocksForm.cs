using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using WallStreet.Models;
using WallStreet.Services.AccountServices;
using WallStreet.Services.StockServices;
using WallStreet.Services.TransactionServices;
using WallStreet.Services.UserServices;

namespace WallStreet.Forms
{
    public partial class MyStocksForm : Form
    {
        private readonly User user;
        private readonly IUserService userService = new UserService();
        private readonly IAccountService accountService = new AccountService();
        private readonly ITransactionService transactionService = new TransactionService();
        public MyStocksForm(int accountId)
        {
            InitializeComponent();
            this.user = userService.Get(accountId);
            FillMyStocks(user);
        }

        // TODO display data in listbox 
        private void FillMyStocks(User user)
        {
            lvMyStocks.View = View.Details;
            lvMyStocks.GridLines = true;
            lvMyStocks.Columns.Add("Stock", 100);
            lvMyStocks.Columns.Add("Quantity", 100);

            Dictionary<string, int> stockAndQuantity =
                userService.GetStocksAndQuantityFromTransactions(transactionService.GetTransactionsByUser(user.UserId));

            foreach (var pair in stockAndQuantity)
            {
                var line = new string[2];
                line[0] = pair.Key;
                line[1] = pair.Value.ToString();
                var itm = new ListViewItem(line);
                lvMyStocks.Items.Add(itm);
            }
        }

        private void btnBackToProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            var profileForm = new ProfileForm(accountService.GetAccount(user.AccountId));
            profileForm.Closed += (s, args) => this.Close();
            profileForm.Show();
        }
    }
}
