using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using ControlOfUserActivity.Database;
using Dapper;
using System.Linq;

namespace ControlOfUserActivity
{
    public partial class LoginForm : Form
    {
        private SqlConnection _connection;
        private SqlConnection connection => _connection ?? (_connection = Constants.GetOpenConnection());

        public LoginForm()
        {
            InitializeComponent();
            
            #region Setting up font
            AppFont.SetExo2Font(lblIP, 8);
            AppFont.SetExo2Font(lblLogin, 8);
            AppFont.SetExo2Font(lblPassword, 8);
            AppFont.SetExo2Font(txtIP, 8);
            AppFont.SetExo2Font(txtLogin, 8);
            AppFont.SetExo2Font(txtPassword, 8);
            AppFont.SetExo2Font(btnAccept, 8);
            AppFont.SetExo2Font(btnExit, 8);
            #endregion
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (!isFormDataCorrect()) return;

            if (txtIP.Text == "127.0.0.1") Constants.Database = ".";

            if (txtLogin.Text != "test")
            {
                try
                {
                    var user = connection.Query<Users>($"SELECT * FROM Users WHERE Nickname = '{txtLogin.Text}' AND Password = '{txtPassword.Text}'").Single();
                    Constants.UserId = user.Id;
                    Constants.IsAdmin = user.IsAdmin == 1;
                }
                catch (Exception)
                {
                    MessageBox.Show("Логин или пароль не верный! Или такого пользователя не существует!");
                    return;
                }
            }
            else
            {
                Constants.UserId = 1;
                Constants.IsAdmin = true;
            }

            var form = new MainForm()
            {
                StartPosition = FormStartPosition.CenterParent
            };
            form.Show();

            Hide();
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();

        private bool isFormDataCorrect()
        {
            if (txtIP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Введите IP!");
                return false;
            }

            if (txtLogin.Text.Trim().Length == 0)
            {
                MessageBox.Show("Введите логин!");
                return false;
            }

            if (txtPassword.Text.Trim().Length == 0)
            {
                MessageBox.Show("Введите пароль!");
                return false;
            }

            return true;
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            new RegistrationForm().Show();
        }
    }
}
