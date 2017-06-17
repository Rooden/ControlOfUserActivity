using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Dapper;
using System.Linq;

namespace ControlOfUserActivity
{
    public partial class AdminPostControl : UserControl, FlowControl
    {
        private SqlConnection _connection;
        private SqlConnection connection => _connection ?? (_connection = Constants.GetOpenConnection());

        public int LabelWidth
        {
            get { return LabelWidth; }
            set
            {
                if (value < MinimumSize.Width) return;

                Width = value;
                txtHeader.Width = value;
                txtBody.Width = value;
            }
        }

        public int LabelHeight
        {
            get { return LabelHeight; }
            set
            {
                if (value < MinimumSize.Height) return;

                Height = value;
                txtBody.Height = value - lblName.Height - txtHeader.Height - 50;
            }
        }

        public AdminPostControl()
        {
            InitializeComponent();

            MinimumSize = new Size(300, 50);

            LabelWidth = 300;
            LabelHeight = 50;

            AppFont.SetExo2Font(lblName, 14);
            AppFont.SetExo2Font(txtHeader, 14);
            AppFont.SetExo2Font(txtBody, 14);
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (!isFormDataCorrect()) return;

            connection.Execute($"INSERT INTO BlogPost VALUES ('{txtHeader.Text}', '{txtBody.Text}');");

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
    }
}
