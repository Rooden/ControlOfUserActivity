using System.Windows.Forms;

namespace ControlOfUserActivity
{
    public partial class NewsControl : UserControl
    {
        public int LabelMaxWidth
        {
            set
            {
                foreach (Label label in flowPanel.Controls)
                    label.Width = value;
            }
        }

        public string HeaderText { set { lblHeader.Text = value; } }

        public string BodyText { set { lblBody.Text = value; } }

        public NewsControl()
        {
            InitializeComponent();
        }
    }
}
