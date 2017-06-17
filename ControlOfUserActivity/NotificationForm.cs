using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Dapper;
using ControlOfUserActivity.Database;

namespace ControlOfUserActivity
{
    public partial class NotificationForm : Form, FlowControl
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
                foreach (Control control in flowLayoutPanel1.Controls)
                {
                    if (control is Label label)
                        label.Width = _labelWidth;
                }

                //Debug.WriteLine(lblBody.Width);
            }
        }

        public NotificationForm()
        {
            InitializeComponent();

            LabelWidth = _labelWidth;
        }

        private void NotificationForm_Resize(object sender, System.EventArgs e)
        {
            try
            {
                foreach (Control control in flowLayoutPanel1.Controls)
                {
                    if (control is FlowControl flowControl)
                        flowControl.LabelWidth = Width - 50;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool loadDataFromDatabase()
        {
            if (connection == null) return false;

            var messageList = connection.Query<Messages>("SELECT * FROM Messages").AsList();
            foreach (var post in messageList)
            {
                var messageControl = new MessageControl
                {
                    HeaderText = post.Title,
                    BodyText = post.Message
                };
                flowLayoutPanel1.Controls.Add(messageControl);
            }

            return true;
        }

        private void notificationForm_Load(object sender, EventArgs e)
        {
            if (!loadDataFromDatabase())
            {
                var msg = new MessageControl()
                {
                    HeaderText = "DID Y SEE THAT?!",
                    BodyText = @"Holy shit Jesus!"
                };
                flowLayoutPanel1.Controls.Add(msg);
            }
        }
    }
}
