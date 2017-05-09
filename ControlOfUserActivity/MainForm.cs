using System;
using System.Drawing;
using System.Windows.Forms;

namespace ControlOfUserActivity
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            new Font().SetExo2Font(label1, 10, FontStyle.Bold);
            new Font().SetExo2Font(linkLabel1, 9);
            new Font().SetExo2Font(linkLabel2, 9);
            new Font().SetExo2Font(linkLabel3, 9);
            new Font().SetExo2Font(linkLabel4, 9);

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

        private void MainForm_Resize(object sender, EventArgs e)
        {
            foreach (Control control in flowNewsPanel.Controls)
            {
                var newsControl = control as NewsControl;
                if (newsControl != null) newsControl.LabelWidth = Width - panelLastNews.Width - 50;
            }
        }
    }
}
