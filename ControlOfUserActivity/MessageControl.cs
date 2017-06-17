using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace ControlOfUserActivity
{
    public partial class MessageControl : UserControl, FlowControl
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

                //Debug.WriteLine(Width);
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

        public MessageControl()
        {
            InitializeComponent();

            LabelWidth = _labelWidth - 50;

            #region Setting up Font
            AppFont.SetExo2Font(lblHeader, 12, FontStyle.Bold);
            AppFont.SetExo2Font(lblBody, 10);
            #endregion
        }
    }
}
