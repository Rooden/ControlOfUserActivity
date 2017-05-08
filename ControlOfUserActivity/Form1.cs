using System.Windows.Forms;

namespace ControlOfUserActivity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var newsControl = new NewsControl
            {
                HeaderText = @"Lorem Ipsum",
                BodyText = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vestibulum tempus scelerisque. Nulla viverra tempor erat ut laoreet. 
Aenean et massa efficitur, lacinia lectus sed, porta lorem. 
Sed venenatis id lectus et posuere. Phasellus lacinia leo a orci efficitur, at fermentum justo commodo. 
Maecenas nisi massa, commodo id magna quis, varius convallis sapien. Vivamus sagittis urna orci, vitae ornare urna feugiat ac.",
                Width = 400
            };
            Controls.Add(newsControl);
        }
    }
}
