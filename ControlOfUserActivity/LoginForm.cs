using System;
using System.Windows.Forms;

namespace ControlOfUserActivity
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            Constants.UserId = 1;
            
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
            var form = new MainForm()
            {
                StartPosition = FormStartPosition.CenterParent
            };
            form.Show();

            Hide();
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();
    }
}
