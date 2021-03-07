using System;
using System.Windows.Forms;
using WallStreet.Models;
using WallStreet.Services.AccountServices;
using WallStreet.Services.UserServices;

namespace WallStreet.Forms
{
    public partial class MainPageForm : Form
    {
        private readonly IAccountService accountService = new AccountService();
        private readonly Account account;
       
        public MainPageForm(int accountId)
        {
            InitializeComponent();
            this.account = accountService.GetAccount(accountId);
        }

        private void btnRanking_Click(object sender, EventArgs e)
        {
            this.Hide();
            var rankingForm = new RankingForm();
            rankingForm.Closed += (s, args) => this.Close();
            rankingForm.Show();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            var profileForm = new ProfileForm(account);
            profileForm.Closed += (s, args) => this.Close();
            profileForm.Show();
        }

        private void btnStockMarket_Click(object sender, EventArgs e)
        {
            this.Hide();
            var marketForm = new MarketForm(account);
            marketForm.Closed += (s, args) => this.Close();
            marketForm.Show();
        }
    }
}
