using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ControlOfUserActivity
{
    public partial class MainForm : Form
    {
        Stack<Control> stackControls = new Stack<Control>();

        public MainForm()
        {
            InitializeComponent();

            AppFont.SetExo2Font(label1, 10, FontStyle.Bold);
            AppFont.SetExo2Font(linkLabel1, 9);
            AppFont.SetExo2Font(linkLabel2, 9);
            AppFont.SetExo2Font(linkLabel3, 9);
            AppFont.SetExo2Font(linkLabel4, 9);

            // ReSharper disable once VirtualMemberCallInConstructor
            MinimumSize = new Size(450, 400);

            var newsControl = new NewsControl
            {
                BorderStyle = BorderStyle.FixedSingle,
                HeaderText = @"Lorem Ipsum",
                BodyText = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vestibulum tempus scelerisque. Nulla viverra tempor erat ut laoreet. 
Aenean et massa efficitur, lacinia lectus sed, porta lorem. 
Sed venenatis id lectus et posuere. Phasellus lacinia leo a orci efficitur, at fermentum justo commodo. 
Maecenas nisi massa, commodo id magna quis, varius convallis sapien. Vivamus sagittis urna orci, vitae ornare urna feugiat ac."
            };
            newsControl.OnNewsOpen += NewsControl_OnNewsOpen;
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
        }

        private void NewsControl_OnNewsOpen(object sender, EventArgs e)
        {
            btnBack.Enabled = true;
            btnForward.Enabled = false;

            stackControls.Clear();
            foreach (Control control in flowNewsPanel.Controls)
                stackControls.Push(control);

            string headText = (flowNewsPanel.Controls[0] as NewsControl).HeaderText;
            string bodyText = (flowNewsPanel.Controls[0] as NewsControl).BodyText;
            flowNewsPanel.Controls.Clear();

            var postControl = new PostControl { HeaderText = headText, BodyText = bodyText };
            postControl.LabelWidth = Width - panelLastNews.Width - 50;
            flowNewsPanel.Controls.Add(postControl);

            flowNewsPanel.Update();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            try
            {
                foreach (Control control in flowNewsPanel.Controls)
                {
                    var flowControl = control as FlowControl;
                    if (flowControl != null) flowControl.LabelWidth = Width - panelLastNews.Width - 50;
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

        private void loadFromStack()
        {
            List<Control> temp = new List<Control>(stackControls.ToArray());
            temp.Reverse();

            stackControls.Clear();
            foreach (Control control in flowNewsPanel.Controls)
                stackControls.Push(control);

            flowNewsPanel.Controls.Clear();
            flowNewsPanel.Controls.AddRange(temp.ToArray());
        }
    }
}
