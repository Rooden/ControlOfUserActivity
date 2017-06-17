using System.Drawing;
using System.Windows.Forms;
using Dapper;
using ControlOfUserActivity.Database;
using System.Data.SqlClient;
using System.Linq;

namespace ControlOfUserActivity
{
    public partial class UserRatingControl : Form
    {
        private SqlConnection _connection;
        private SqlConnection connection => _connection ?? (_connection = Constants.GetOpenConnection());

        public int UserId { get; set; }

        public UserRatingControl()
        {
            InitializeComponent();

            MinimumSize = new Size(300, 50);

            AppFont.SetExo2Font(btnExit, 10);
            AppFont.SetExo2Font(btnSave, 10);
        }

        private void tcRating_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (tcRating.SelectedTab.Text == "+")
            {
                tcRating.TabPages.Insert(tcRating.TabPages.Count - 1, $"Рейтинг {tcRating.TabPages.Count}");
                tcRating.TabPages[tcRating.TabPages.Count - 2].Controls.Add(new RatingPageControl() { Location = new Point(6, 6) });
                tcRating.SelectTab(tcRating.TabPages.Count - 2); 
            }
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            var ratingPage = tcRating.SelectedTab.Controls[0] as RatingPageControl;
            if (ratingPage.Id == -1)
            {
                ratingPage.Id = connection.Query<int>(
                    $@"INSERT INTO UserActivity VALUES ({UserId}, {ratingPage.Quality}, {ratingPage.Success}, {ratingPage.Speed}); 
                        SELECT CAST(SCOPE_IDENTITY() AS int)"
                        ).Single();

                MessageBox.Show("Сохранение выполнено!");
            }
            else
            {
                connection.Execute($@"UPDATE UserActivity 
                    SET Quality =  {ratingPage.Quality}, Success = {ratingPage.Success}, Speed = {ratingPage.Speed} 
                    WHERE Id = {ratingPage.Id};");

                MessageBox.Show("Обновление выполнено!");
            }
        }
        
        private void loadDataFromDatabase()
        {
            if (connection == null) return;

            var userActivityList = connection.Query<UserActivity>($"SELECT * FROM UserActivity WHERE UserId = {UserId}").AsList();
            foreach (var userActivity in userActivityList)
            {
                var ratingPageControl = new RatingPageControl
                {
                    Id = userActivity.Id,
                    Quality = userActivity.Quality,
                    Success = userActivity.Success,
                    Speed = userActivity.Speed,
                    Location = new Point(6, 6)
                };

                tcRating.TabPages.Insert(tcRating.TabPages.Count - 1, $"Рейтинг {tcRating.TabPages.Count}");
                tcRating.TabPages[tcRating.TabPages.Count - 2].Controls.Add(ratingPageControl);
                tcRating.SelectTab(tcRating.TabPages.Count - 2);
            }
        }

        private void userRatingControl_Load(object sender, System.EventArgs e)
        {
            loadDataFromDatabase();
            if (tcRating.TabCount == 1)
            {
                tcRating.TabPages.Insert(0, $"Рейтинг {tcRating.TabPages.Count}");
                tcRating.TabPages[0].Controls.Add(new RatingPageControl() { Location = new Point(6, 6) });
                tcRating.SelectTab(0);
            }
        }
    }
}
