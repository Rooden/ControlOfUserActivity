using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Dapper;

namespace ControlOfUserActivity
{
    public partial class AdminNotificationForm : Form
    {
        private SqlConnection _connection;
        private SqlConnection connection => _connection ?? (_connection = Constants.GetOpenConnection());

        public AdminNotificationForm()
        {
            InitializeComponent();

            #region Setting up Font
            AppFont.SetExo2Font(lblName, 12, FontStyle.Bold);
            AppFont.SetExo2Font(txtHeader, 10);
            AppFont.SetExo2Font(txtBody, 10);
            #endregion

            // ReSharper disable once VirtualMemberCallInConstructor
            MinimumSize = new Size(450, 400);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isFormDataCorrect()) return;

            connection.Execute($"INSERT INTO Messages VALUES ('{txtHeader.Text}', '{txtBody.Text}');");

            MessageBox.Show("Сохранение выполнено!");
        }

        private bool isFormDataCorrect()
        {
            if (txtHeader.Text.Trim().Length == 0)
            {
                MessageBox.Show("Заголовок статьи не заполнен!");
                return false;
            }

            if (txtBody.Text.Trim().Length == 0)
            {
                MessageBox.Show("Текст статьи не заполнен!");
                return false;
            }

            return true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
