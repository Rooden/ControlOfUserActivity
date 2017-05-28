using System;
using System.Drawing;
using System.Windows.Forms;

namespace ControlOfUserActivity
{
    /// <summary>
    /// Class for every news block.
    /// </summary>
    public partial class NewsControl : UserControl, FlowControl
    {
        private int _labelWidth = 300;

        public event EventHandler OnNewsOpen;

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
            }
        }

        /// <summary>
        /// Set <see cref="lblHeader"/> text.
        /// </summary>
        public string HeaderText
        {
            get { return lblHeader.Text; }
            set { lblHeader.Text = value; }
        }

        /// <summary>
        /// Set <see cref="lblBody"/> text.
        /// </summary>
        public string BodyText
        {
            get { return lblBody.Text; }
            set { lblBody.Text = value; }
        }

        /// <summary>
        /// Ctor. Default MinimumSize is (300, 50). Change it for your porposes.
        /// </summary>
        public NewsControl()
        {
            InitializeComponent();

            // ReSharper disable once VirtualMemberCallInConstructor
            MinimumSize = new Size(300, 50);

            LabelWidth = _labelWidth;

            AppFont.SetExo2Font(lblHeader, 13, FontStyle.Bold);
            AppFont.SetExo2Font(lblBody, 10);

            lblHeader.ForeColor = Color.Blue;
            lblHeader.MouseClick += LblHeader_MouseClick;
        }

        private void LblHeader_MouseClick(object sender, MouseEventArgs e)
        {
            OnNewsOpen?.Invoke(sender, e);
        }
    }
}
