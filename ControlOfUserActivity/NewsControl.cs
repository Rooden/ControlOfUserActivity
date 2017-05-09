using System.Windows.Forms;

namespace ControlOfUserActivity
{
    /// <summary>
    /// Class for every news block.
    /// </summary>
    public partial class NewsControl : UserControl
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

                _labelWidth = value;
                foreach (Control control in flowPanel.Controls)
                {
                    var label = control as Label;
                    if (label != null) label.Width = _labelWidth;
                }
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

        /// <summary>
        /// Ctor. Default MinimumSize is (300, 50). Change it for your porposes.
        /// </summary>
        public NewsControl()
        {
            InitializeComponent();

            // ReSharper disable once VirtualMemberCallInConstructor
            MinimumSize = new System.Drawing.Size(300, 50);

            LabelWidth = _labelWidth;

            new Font().SetExo2Font(lblHeader, 13, System.Drawing.FontStyle.Bold);
            new Font().SetExo2Font(lblBody, 10);
        }
    }
}
