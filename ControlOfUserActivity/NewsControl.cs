using System.Windows.Forms;

namespace ControlOfUserActivity
{
    public partial class NewsControl : UserControl
    {
        public int LabelMaxWidth
        {
            get { return lblHeader.Width; }
            set
            {
                foreach (Label label in flowPanel.Controls)
                    label.Width = value - label.Margin.Right;
            }
        }

        public string HeaderText { set { lblHeader.Text = value; } }

        public string BodyText { set { lblBody.Text = value; } }

        public NewsControl()
        {
            InitializeComponent();

            // ReSharper disable once VirtualMemberCallInConstructor
            MinimumSize = new System.Drawing.Size(300, 300);

            new Font().SetExo2Font(lblHeader, 13, System.Drawing.FontStyle.Bold);
            new Font().SetExo2Font(lblBody, 10);
        }
    }
}
