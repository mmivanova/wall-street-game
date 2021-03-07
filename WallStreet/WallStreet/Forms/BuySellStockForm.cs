using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using WallStreet.Models;
using WallStreet.Services.StockServices;
using WallStreet.Services.TransactionServices;

namespace WallStreet.Forms
{
    public partial class BuySellStockForm : Form
    {
        private readonly User user;
        private readonly Stock stock;
        private readonly ITransactionService transactionService = new TransactionService();
        private readonly IStockService stockService = new StockService();

        public BuySellStockForm(string action, User user, int stockId)
        {
            InitializeComponent();
            this.user = user;
            this.stock = stockService.Get(stockId);
            if (action.Equals("buy"))
            {
                lblAction.Text = "Buy Stocks";
                lblStocksToBuy.Text = "Stocks to buy";
                lblMessage.Text = "Enter the amount of stocks you would like to buy/must be a whole number/";
                btnBuySell.Text = "Buy";
                btnBuySell.ForeColor = Color.DarkOliveGreen;
                btnBuySell.BackColor = Color.YellowGreen;
            }
            else if (action.Equals("sell"))
            {
                lblAction.Text = "Sell Stocks";
                lblStocksToBuy.Text = "Stocks to sell";
                lblMessage.Text = "Enter the amount of stocks you would like to sell/must be a whole number/";
                btnBuySell.Text = "Sell";
                btnBuySell.BackColor = Color.Red;
                btnBuySell.ForeColor = Color.Maroon;
            }

            tbCurrentMoney.Text = user.Money.ToString(CultureInfo.InvariantCulture);
        }

        private void btnBuySell_Click(object sender, EventArgs e)
        {
            if (lblStocksToBuy.Text.Equals("Stocks to buy"))
            {
                try
                {
                    int amount = int.Parse(tbStocksToBuy.Text);
                    transactionService.BuyStocks(amount, stock, user.UserId);
                    MessageBox.Show("You have successfully bought your stocks!");
                }
                catch
                {
                    MessageBox.Show("Invalid input, try again!");
                }
            }
            else if (lblStocksToBuy.Text.Equals("Stocks to sell"))
            {
                try
                {
                    int amount = int.Parse(tbStocksToBuy.Text);
                    transactionService.SellStocks(amount, stock, user.UserId);
                    MessageBox.Show("You have successfully sold your stocks!");
                }
                catch
                {
                    MessageBox.Show("Invalid input, try again!");
                }
            }
        }
    }
}
