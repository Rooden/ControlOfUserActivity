using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace ControlOfUserActivity
{
    public partial class UserPanelControl : UserControl, FlowControl
    {
        private int _labelWidth = 300;

        public delegate void OpenButtonClicked(int userId);
        public event OpenButtonClicked OpenButtonClickedEvent;

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

                Debug.WriteLine(lblRealFullName.Width);
            }
        }

        /// <summary>
        /// Set <see cref="lblNickname"/> text.
        /// </summary>
        public string Nickname { set { lblNickname.Text = value; } }

        /// <summary>
        /// Set <see cref="lblRealFullName"/> text.
        /// </summary>
        public string RealFullName { set { lblRealFullName.Text = value; } }

        /// <summary>
        /// Get or Set user id.
        /// </summary>
        public int Id { get; set; }

        public UserPanelControl()
        {
            InitializeComponent();

            MinimumSize = new Size(300, 50);

            LabelWidth = _labelWidth;

            AppFont.SetExo2Font(lblNickname, 13, FontStyle.Bold);
            AppFont.SetExo2Font(lblRealFullName, 10);
        }

        private void btnOpen_Click(object sender, System.EventArgs e) => OpenButtonClickedEvent?.Invoke(Id);
    }
}
