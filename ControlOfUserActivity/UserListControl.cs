using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using Dapper;
using ControlOfUserActivity.Database;
using System.Data.SqlClient;

namespace ControlOfUserActivity
{
    public partial class UserListControl : UserControl, FlowControl
    {
        private int _labelWidth = 300;

        private SqlConnection _connection;
        private SqlConnection connection => _connection ?? (_connection = Constants.GetOpenConnection());

        /// <summary>
        /// Set label width. Applies only if value grater than form minimum width.
        /// </summary>
        public int LabelWidth
        {
            get { return _labelWidth; }
            set
            {
                if (value < MinimumSize.Width) return;

                Width = value;
                _labelWidth = value;
            }
        }

        public UserListControl()
        {
            InitializeComponent();

            MinimumSize = new Size(300, 50);

            LabelWidth = _labelWidth;
        }

        private void user_OpenButtonClickedEvent(int userId)
        {
            var userRatingControl = new UserRatingControl()
            {
                UserId = userId
            };
            userRatingControl.Show();
        }

        private bool loadDataFromDatabase()
        {
            if (connection == null) return false;

            var userList = connection.Query<Users>($"SELECT * FROM Users").AsList();
            foreach (var user in userList)
            {
                var userpanelControl = new UserPanelControl
                {
                    Id = user.Id,
                    Nickname = user.Nickname,
                    RealFullName = user.Name + " " + user.Surname
                };
                userpanelControl.OpenButtonClickedEvent += user_OpenButtonClickedEvent;
                flowLayoutPanel1.Controls.Add(userpanelControl);
            }

            return true;
        }

        private void UserListControl_Load(object sender, System.EventArgs e)
        {
            if (!loadDataFromDatabase())
            {
                var testUser1 = new UserPanelControl()
                {
                    Id = 1,
                    Nickname = "User1",
                    RealFullName = "Shit!"
                };
                testUser1.OpenButtonClickedEvent += user_OpenButtonClickedEvent;
                flowLayoutPanel1.Controls.Add(testUser1);

                var testUser2 = new UserPanelControl()
                {
                    Id = 1,
                    Nickname = "User2",
                    RealFullName = "Shit2222!"
                };
                testUser2.OpenButtonClickedEvent += user_OpenButtonClickedEvent;
                flowLayoutPanel1.Controls.Add(testUser2);

                var testUser3 = new UserPanelControl()
                {
                    Id = 1,
                    Nickname = "User3",
                    RealFullName = @"Shit33333yhtgftyfytgfdtgfydtgdfyutfytgfuyuyfguyjfhkuyjfh3!
dfgiluhrgdfiuhdrfgiuhdfgr"
                };
                testUser3.OpenButtonClickedEvent += user_OpenButtonClickedEvent;
                flowLayoutPanel1.Controls.Add(testUser3);
            }
        }
    }
}
