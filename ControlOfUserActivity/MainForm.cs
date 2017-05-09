﻿using System;
using System.Windows.Forms;

namespace ControlOfUserActivity
{
    public partial class MainForm : Form
    {
        private readonly NewsControl _newsControl;

        public MainForm()
        {
            InitializeComponent();

            _newsControl = new NewsControl
            {
                LabelWidth = 300,
                HeaderText = @"Lorem Ipsum",
                BodyText = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum vestibulum tempus scelerisque. Nulla viverra tempor erat ut laoreet. 
Aenean et massa efficitur, lacinia lectus sed, porta lorem. 
Sed venenatis id lectus et posuere. Phasellus lacinia leo a orci efficitur, at fermentum justo commodo. 
Maecenas nisi massa, commodo id magna quis, varius convallis sapien. Vivamus sagittis urna orci, vitae ornare urna feugiat ac."
            };
            flowNewsPanel.Controls.Add(_newsControl);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            _newsControl.LabelWidth = Width - panelLastNews.Width;
        }
    }
}
