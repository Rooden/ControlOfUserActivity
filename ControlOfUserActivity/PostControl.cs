using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ControlOfUserActivity
{
    public partial class PostControl : UserControl, FlowControl
    {
        private int _labelWidth = 300;

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
    }
}
