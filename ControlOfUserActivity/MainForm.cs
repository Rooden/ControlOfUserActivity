using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dapper;
using ControlOfUserActivity.Database;

namespace ControlOfUserActivity
{
    public partial class MainForm : Form
    {
        private Stack<Control> stackControls = new Stack<Control>();
        
        private SqlConnection _connection;
        private SqlConnection connection => _connection ?? (_connection = Constants.GetOpenConnection());

        public MainForm()
        {
            InitializeComponent();

            #region Setting up font
            AppFont.SetExo2Font(btnBack, 8);
            AppFont.SetExo2Font(btnForward, 8);
            AppFont.SetExo2Font(btnMenu, 8);
            AppFont.SetExo2Font(btnMinus, 8);
            AppFont.SetExo2Font(btnPlus, 8);
            AppFont.SetExo2Font(btnExit, 8);
            AppFont.SetExo2Font(btnHome, 8);
            #endregion

            // ReSharper disable once VirtualMemberCallInConstructor
            MinimumSize = new Size(450, 400);

            if (!Constants.IsAdmin)
                btnMenu.Visible = false;
        }

        private void newsControl_OnNewsOpen(int id)
        {
            btnBack.Enabled = true;
            btnForward.Enabled = false;

            stackControls.Clear();
            foreach (Control control in flowNewsPanel.Controls)
                stackControls.Push(control);

            string headText = (flowNewsPanel.Controls[0] as NewsControl).HeaderText;
            string bodyText = (flowNewsPanel.Controls[0] as NewsControl).BodyText;
            flowNewsPanel.Controls.Clear();

            Text = headText;

            var postControl = new PostControl { BlogPostId = id, HeaderText = headText, BodyText = bodyText };
            postControl.LabelWidth = Width - 50;
            flowNewsPanel.Controls.Add(postControl);

            flowNewsPanel.Update();
        }

        private void mainForm_Resize(object sender, EventArgs e)
        {
            try
            {
                foreach (Control control in flowNewsPanel.Controls)
                {
                    if (control is FlowControl flowControl)
                        flowControl.LabelWidth = Width - 50;
                    if (control is AdminPostControl adminPostControl)
                        adminPostControl.LabelHeight = Height - panel1.Height - panelControls.Height - 50;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (stackControls.Count == 0) return;

            btnForward.Enabled = true;
            btnBack.Enabled = false;

            loadFromStack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (stackControls.Count == 0) return;

            btnBack.Enabled = true;
            btnForward.Enabled = false;

            loadFromStack();
        }

        private bool loadDataFromDatabase()
        {
            if (connection == null) return false;

            var postList = connection.Query<BlogPost>("SELECT * FROM BlogPost ORDER BY Id DESC").AsList();
            foreach (var post in postList)
            {
                var newsControl = new NewsControl
                {
                    BorderStyle = BorderStyle.FixedSingle,
                    BlogPostId = post.Id,
                    HeaderText = post.Title,
                    BodyText = post.Text
                };
                newsControl.OnNewsOpen += newsControl_OnNewsOpen;
                flowNewsPanel.Controls.Add(newsControl);
            }

            return true;
        }

        private void loadFromStack()
        {
            List<Control> temp = new List<Control>(stackControls.ToArray());
            temp.Reverse();

            stackControls.Clear();
            foreach (Control control in flowNewsPanel.Controls)
                stackControls.Push(control);

            flowNewsPanel.Controls.Clear();
            flowNewsPanel.Controls.AddRange(temp.ToArray());

            mainForm_Resize(null, null);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (trvMenu.Size.IsEmpty) trvMenu.Size = new Size(152, 97);

            trvMenu.Visible = !trvMenu.Visible;
            trvMenu.Focus();
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e) => Environment.Exit(0);

        private void trvMenu_DoubleClick(object sender, EventArgs e)
        {
            if (trvMenu.SelectedNode == null) return;

            switch (trvMenu.SelectedNode.Name)
            {
                case "CreateNews":
                    Text = "Создание новости";
                    btnBack.Enabled = true;
                    btnForward.Enabled = false;

                    stackControls.Clear();
                    foreach (Control control in flowNewsPanel.Controls)
                        stackControls.Push(control);
                    flowNewsPanel.Controls.Clear();

                    var postControl = new AdminPostControl()
                    {
                        LabelWidth = Width - 50,
                        LabelHeight = Height - panel1.Height - panelControls.Height - 50
                    };
                    flowNewsPanel.Controls.Add(postControl);
                    break;

                case "UsersList":
                    Text = "Список пользователей";
                    btnBack.Enabled = true;
                    btnForward.Enabled = false;

                    stackControls.Clear();
                    foreach (Control control in flowNewsPanel.Controls)
                        stackControls.Push(control);
                    flowNewsPanel.Controls.Clear();

                    var userListControl = new UserListControl()
                    {
                        LabelWidth = Width - 50
                    };
                    flowNewsPanel.Controls.Add(userListControl);
                    break;

                default:
                    break;
            }
        }

        private void trvMenu_Leave(object sender, EventArgs e)
        {
            trvMenu.Visible = !trvMenu.Visible;
        }

        private void btnNotification_Click(object sender, EventArgs e)
        {
            if (!Constants.IsAdmin)
            {
                new NotificationForm().Show();
                return;
            }

            if (trvNotification.Size.IsEmpty) trvNotification.Size = new Size(162, 97);

            trvNotification.Visible = !trvNotification.Visible;
            trvNotification.Focus();
        }

        private void trvNotification_DoubleClick(object sender, EventArgs e)
        {
            if (trvNotification.SelectedNode == null) return;

            switch (trvNotification.SelectedNode.Name)
            {
                case "Create":
                    new AdminNotificationForm().Show();
                    break;

                case "Open":
                    new NotificationForm().Show();
                    break;

                default:
                    break;
            }
        }

        private void trvNotification_Leave(object sender, EventArgs e)
        {
            trvNotification.Visible = !trvNotification.Visible;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            if (!loadDataFromDatabase())
            {
                #region Test
                var newsControl = new NewsControl
                {
                    BorderStyle = BorderStyle.FixedSingle,
                    HeaderText = @"Lorem Ipsum",
                    BodyText = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vestibulum tempus scelerisque. Nulla viverra tempor erat ut laoreet. 
    Aenean et massa efficitur, lacinia lectus sed, porta lorem. 
    Sed venenatis id lectus et posuere. Phasellus lacinia leo a orci efficitur, at fermentum justo commodo. 
    Maecenas nisi massa, commodo id magna quis, varius convallis sapien. Vivamus sagittis urna orci, vitae ornare urna feugiat ac."
                };
                newsControl.OnNewsOpen += newsControl_OnNewsOpen;
                flowNewsPanel.Controls.Add(newsControl);

                var newsControl2 = new NewsControl
                {
                    BorderStyle = BorderStyle.FixedSingle,
                    HeaderText = @"Lorem Ipsum",
                    BodyText = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vestibulum tempus scelerisque. Nulla viverra tempor erat ut laoreet. 
    Aenean et massa efficitur, lacinia lectus sed, porta lorem. 
    Sed venenatis id lectus et posuere. Phasellus lacinia leo a orci efficitur, at fermentum justo commodo. 
    Maecenas nisi massa, commodo id magna quis, varius convallis sapien. Vivamus sagittis urna orci, vitae ornare urna feugiat ac."
                };
                flowNewsPanel.Controls.Add(newsControl2);

                var newsControl3 = new NewsControl
                {
                    BorderStyle = BorderStyle.FixedSingle,
                    HeaderText = @"Lorem Ipsum",
                    BodyText = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vestibulum tempus scelerisque. Nulla viverra tempor erat ut laoreet. 
    Aenean et massa efficitur, lacinia lectus sed, porta lorem. 
    Sed venenatis id lectus et posuere. Phasellus lacinia leo a orci efficitur, at fermentum justo commodo. 
    Maecenas nisi massa, commodo id magna quis, varius convallis sapien. Vivamus sagittis urna orci, vitae ornare urna feugiat ac."
                };
                flowNewsPanel.Controls.Add(newsControl3);
                #endregion
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Text = "Главная";
            flowNewsPanel.Controls.Clear();

            if (!loadDataFromDatabase())
            {
                #region Test
                var newsControl = new NewsControl
                {
                    BorderStyle = BorderStyle.FixedSingle,
                    HeaderText = @"Lorem Ipsum",
                    BodyText = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vestibulum tempus scelerisque. Nulla viverra tempor erat ut laoreet. 
    Aenean et massa efficitur, lacinia lectus sed, porta lorem. 
    Sed venenatis id lectus et posuere. Phasellus lacinia leo a orci efficitur, at fermentum justo commodo. 
    Maecenas nisi massa, commodo id magna quis, varius convallis sapien. Vivamus sagittis urna orci, vitae ornare urna feugiat ac."
                };
                newsControl.OnNewsOpen += newsControl_OnNewsOpen;
                flowNewsPanel.Controls.Add(newsControl);

                var newsControl2 = new NewsControl
                {
                    BorderStyle = BorderStyle.FixedSingle,
                    HeaderText = @"Lorem Ipsum",
                    BodyText = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vestibulum tempus scelerisque. Nulla viverra tempor erat ut laoreet. 
    Aenean et massa efficitur, lacinia lectus sed, porta lorem. 
    Sed venenatis id lectus et posuere. Phasellus lacinia leo a orci efficitur, at fermentum justo commodo. 
    Maecenas nisi massa, commodo id magna quis, varius convallis sapien. Vivamus sagittis urna orci, vitae ornare urna feugiat ac."
                };
                flowNewsPanel.Controls.Add(newsControl2);

                var newsControl3 = new NewsControl
                {
                    BorderStyle = BorderStyle.FixedSingle,
                    HeaderText = @"Lorem Ipsum",
                    BodyText = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vestibulum tempus scelerisque. Nulla viverra tempor erat ut laoreet. 
    Aenean et massa efficitur, lacinia lectus sed, porta lorem. 
    Sed venenatis id lectus et posuere. Phasellus lacinia leo a orci efficitur, at fermentum justo commodo. 
    Maecenas nisi massa, commodo id magna quis, varius convallis sapien. Vivamus sagittis urna orci, vitae ornare urna feugiat ac."
                };
                flowNewsPanel.Controls.Add(newsControl3);
                #endregion
            }
        }
    }
}
