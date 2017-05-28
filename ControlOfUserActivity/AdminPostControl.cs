using System.Drawing;
using System.Windows.Forms;

namespace ControlOfUserActivity
{
    public partial class AdminPostControl : UserControl, FlowControl
    {
        public int LabelWidth
        {
            get { return LabelWidth; }
            set
            {
                if (value < MinimumSize.Width) return;

                Width = value;
                txtHeader.Width = value;
                txtBody.Width = value;
            }
        }

        public int LabelHeight
        {
            get { return LabelHeight; }
            set
            {
                if (value < MinimumSize.Height) return;

                Height = value;
                txtBody.Height = value - lblName.Height - txtHeader.Height - 50;
            }
        }

        public AdminPostControl()
        {
            InitializeComponent();

            MinimumSize = new Size(300, 50);

            LabelWidth = 300;
            LabelHeight = 50;

            AppFont.SetExo2Font(lblName, 14);
            AppFont.SetExo2Font(txtHeader, 14);
            AppFont.SetExo2Font(txtBody, 14);
        }
    }
}
