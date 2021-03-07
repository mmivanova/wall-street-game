using System;
using System.Windows.Forms;
using WallStreet.Models;
using WallStreet.Services.UserServices;

namespace WallStreet.Forms
{
    public partial class MarketForm : Form
    {
        private readonly User user;
        private readonly IUserService userService = new UserService();

        public MarketForm(Account account)
        {
            InitializeComponent();
            this.user = userService.Get(account.AccountId);
        }

        private void ButtonBuyIsClicked(int stockId)
        {
            string buy = "buy";
            this.Hide();
            var buyStockForm = new BuySellStockForm(buy, user, stockId);
            buyStockForm.Closed += (s, args) => this.Close();
            buyStockForm.Show();
        }

        private void btnBuyTesla_Click(object sender, EventArgs e)
        {
            int stockId = 1;
            ButtonBuyIsClicked(stockId);
        }

        private void btnBuyApple_Click(object sender, EventArgs e)
        {
            int stockId = 2;
            ButtonBuyIsClicked(stockId);
        }

        private void btnBuyMicrosoft_Click(object sender, EventArgs e)
        {
            int stockId = 3;
            ButtonBuyIsClicked(stockId);
        }

        private void btnBuyNvidia_Click(object sender, EventArgs e)
        {
            int stockId = 4;
            ButtonBuyIsClicked(stockId);
        }

        private void btnBuyModerna_Click(object sender, EventArgs e)
        {
            int stockId = 5;
            ButtonBuyIsClicked(stockId);
        }

        private void ButtonSellIsClicked(int stockId)
        {
            string buy = "sell";
            this.Hide();
            var buyStockForm = new BuySellStockForm(buy, user, stockId);
            buyStockForm.Closed += (s, args) => this.Close();
            buyStockForm.Show();
        }

        private void btnSellTesla_Click(object sender, EventArgs e)
        {
            int stockId = 1;
            ButtonSellIsClicked(stockId);
        }

        private void btnSellApple_Click(object sender, EventArgs e)
        {
            int stockId = 2;
            ButtonSellIsClicked(stockId);
        }

        private void btnSellMicrosoft_Click(object sender, EventArgs e)
        {
            int stockId = 3;
            ButtonSellIsClicked(stockId);
        }

        private void btnSellNvidia_Click(object sender, EventArgs e)
        {
            int stockId = 4;
            ButtonSellIsClicked(stockId);
        }

        private void btnSellModerna_Click(object sender, EventArgs e)
        {
            int stockId = 5;
            ButtonSellIsClicked(stockId);
        }
    }
}
