using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace ControlOfUserActivity
{
    public partial class RatingPageControl : UserControl, FlowControl
    {
        private int _labelWidth = 300;
        private int _id = -1;

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public int Quality
        {
            get { return tbQuality.Value; }
            set { tbQuality.Value = value; }
        }

        public int Success
        {
            get { return tbSuccess.Value; }
            set { tbSuccess.Value = value; }
        }

        public int Speed
        {
            get { return tbSpeed.Value; }
            set { tbSpeed.Value = value; }
        }

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
                panel1.Width = value;
            }
        }

        public RatingPageControl()
        {
            InitializeComponent();

            MinimumSize = new Size(300, 50);

            LabelWidth = _labelWidth;
        }
    }
}
