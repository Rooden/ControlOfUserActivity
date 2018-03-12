using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace ControlOfUserActivity
{
    public partial class RegistrationForm : Form
    {
        private SqlConnection _connection;
        private SqlConnection connection => _connection ?? (_connection = Constants.GetOpenConnection());

        public RegistrationForm()
        {
            InitializeComponent();

            #region Setting up Font
            AppFont.SetExo2Font(btnSave, 10);
            AppFont.SetExo2Font(btnExit, 10);
            AppFont.SetExo2Font(txtLogin, 10);
            AppFont.SetExo2Font(txtName, 10);
            AppFont.SetExo2Font(txtPassword, 10);
            AppFont.SetExo2Font(txtSurname, 10);
            AppFont.SetExo2Font(gbLoginForm, 10);
            #endregion
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isFormDataCorrect()) return;

            Constants.Database = ".";
            connection.Execute($"INSERT INTO Users VALUES ({txtName}, {txtSurname}, {txtLogin}, {txtPassword}, {(chkbAdmin.Checked ? 1 : 0)});");

            MessageBox.Show("Регистрация завершена!");
            Close();
        }

        private bool isFormDataCorrect()
        {
            if (txtLogin.Text.Trim().Length == 0)
            {
                MessageBox.Show("Введите Логин!");
                return false;
            }

            if (txtName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Введите Имя!");
                return false;
            }

            if (txtSurname.Text.Trim().Length == 0)
            {
                MessageBox.Show("Введите Фамилию!");
                return false;
            }

            if (txtPassword.Text.Trim().Length == 0)
            {
                MessageBox.Show("Введите пароль!");
                return false;
            }

            return false;
        }
    }
}
