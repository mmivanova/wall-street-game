using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using WallStreet.Database;
using WallStreet.Models;
using WallStreet.Services.AccountServices;
using WallStreet.Services.UserServices;

namespace WallStreet.Forms
{
    public partial class RankingForm : Form
    {
        private IUserService userService = new UserService();
        private IAccountService accountService = new AccountService();

        public RankingForm()
        {
            InitializeComponent();
            Sort(userService.GetAll());
        }

        private void Sort(List<User> users)
        {
            lvRank.View = View.Details;
            lvRank.Columns.Add("Player");
            lvRank.Columns.Add("Money");

            Dictionary<string, decimal> playerMoney = new Dictionary<string, decimal>();
            users.OrderBy(u => u.Money);

            foreach (var user in users)
            {
                string username = accountService.GetUsername(user.AccountId);
                playerMoney.Add(username, user.Money);
            }

            foreach (var pair in playerMoney)
            {
                var listViewItem = new ListViewItem(new[] { pair.Key, pair.Value.ToString(CultureInfo.InvariantCulture) });
                lvRank.Items.Add(listViewItem);
            }
        }

    }
}
