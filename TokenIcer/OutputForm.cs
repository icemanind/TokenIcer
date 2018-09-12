using System.Drawing;
using System.Windows.Forms;
using ScintillaNET;

namespace TokenIcer
{
    public partial class OutputForm : Form
    {
        public string Output
        {
            set
            {
                txtOutput.Text = value;
                txtOutput.SetSelection(0, 0);
            }
        }

        public OutputForm()
        {
            InitializeComponent();

            txtOutput.Styles[Style.Default].BackColor = Color.FromArgb(100, 100, 100);
            txtOutput.Styles[Style.Default].ForeColor = Color.FromArgb(225, 225, 225);
            txtOutput.Styles[Style.Default].Font = "Consolas";
            txtOutput.Styles[Style.Default].Size = 12;
            txtOutput.Margins.Capacity = 0;
            txtOutput.StyleClearAll();
        }
    }
}
