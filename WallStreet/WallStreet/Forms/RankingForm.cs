using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using WallStreet.Models;
using WallStreet.Services.AccountServices;
using WallStreet.Services.UserServices;

namespace WallStreet.Forms
{
    public partial class RankingForm : Form
    {
        private readonly User user;
        private readonly IUserService userService = new UserService();
        private readonly IAccountService accountService = new AccountService();

        public RankingForm(int accountId)
        {
            InitializeComponent();
            this.user = userService.Get(accountId);
            Sort(userService.GetAll());
        }

        private void Sort(List<User> users)
        {
            lvRank.View = View.Details;
            lvRank.Columns.Add("Player", 150);
            lvRank.Columns.Add("Money", 150);

            Dictionary<string, decimal> playerMoney = new Dictionary<string, decimal>();

            foreach (var user in users)
            {
                string username = accountService.GetUsername(user.AccountId);
                playerMoney.Add(username, user.Money);
            }

            foreach (var pair in playerMoney.OrderByDescending(u=>u.Value))
            {
                var listViewItem = new ListViewItem(new[] { pair.Key, pair.Value.ToString(CultureInfo.InvariantCulture) });
                lvRank.Items.Add(listViewItem);
            }
        }

        private void btnBackToMain_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            var mainPage = new MainPageForm(user.AccountId);
            mainPage.Closed += (s, args) => this.Close();
            mainPage.Show();
        }

        private void lvRank_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }
    }
}
