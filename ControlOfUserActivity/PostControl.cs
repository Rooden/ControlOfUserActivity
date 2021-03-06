﻿using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using ControlOfUserActivity.Database;
using Dapper;

namespace ControlOfUserActivity
{
    public partial class PostControl : UserControl, FlowControl
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
                foreach (Control control in flowPanel.Controls)
                {
                    if (control is Label label)
                        label.Width = _labelWidth;
                }
                panel1.Width = value;

                Debug.WriteLine(lblBody.Width);
            }
        }

        public int BlogPostId { get; set; }

        /// <summary>
        /// Set <see cref="lblHeader"/> text.
        /// </summary>
        public string HeaderText { set { lblHeader.Text = value; } }

        /// <summary>
        /// Set <see cref="lblBody"/> text.
        /// </summary>
        public string BodyText { set { lblBody.Text = value; } }

        public PostControl()
        {
            InitializeComponent();

            MinimumSize = new Size(300, 50);

            LabelWidth = _labelWidth;

            AppFont.SetExo2Font(lblHeader, 13, FontStyle.Bold);
            AppFont.SetExo2Font(lblBody, 10);
        }

        private void btnAccept_Click(object sender, System.EventArgs e)
        {
            var id = connection.Query<BlogPerUserState>($"SELECT Id FROM BlogPerUserState WHERE UserId = {Constants.UserId} AND BlogPostId = {BlogPostId}").AsList();
            if (id.Count != 0) return;

            connection.Execute($"INSERT INTO BlogPerUserState VALUES ({Constants.UserId}, {BlogPostId}, 1);");
        }
    }
}
