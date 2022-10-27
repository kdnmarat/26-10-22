using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FunWithWindowsForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tbCommon_KeyPress(object sender, KeyPressEventArgs e)
        {
            // accept only digits and points
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            System.Windows.Forms.TextBox tb = (System.Windows.Forms.TextBox)sender;
            // but only one point, and not at the beginning of the string
            if (e.KeyChar == '.' && (tb.Text.Contains('.') || (tb.SelectionStart == 0)))
            {
                e.Handled = true;
            }
        }

        private void tbRadius_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox tb = (System.Windows.Forms.TextBox)sender;
            // to not have problems with empty field
            if (tb.Text.Length == 0)
            {
                tb.Text = "0";
                return;
            }
            double r = Convert.ToDouble(tb.Text);
            double c = 2 * Math.PI * r;
            double a = Math.PI * r * r;
            // to prevent loops
            if (tb.Focused)
            {
                tbLength.Text = c.ToString("0.####");
                tbArea.Text = a.ToString("0.####");
            }
        }

        private void tbLength_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox tb = (System.Windows.Forms.TextBox)sender;
            // to not have problems with empty field
            if (tb.Text.Length == 0)
            {
                tb.Text = "0";
                return;
            }
            double c = Convert.ToDouble(tb.Text);
            double r = c / (2 * Math.PI);
            double a = c * c / (4 * Math.PI);
            // to prevent loops
            if (tb.Focused)
            {
                tbRadius.Text = r.ToString("0.####");
                tbArea.Text = a.ToString("0.####");
            }
        }

        private void tbArea_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox tb = (System.Windows.Forms.TextBox)sender;
            // to not have problems with empty field
            if (tb.Text.Length == 0)
            {
                tb.Text = "0";
                return;
            }
            double a = Convert.ToDouble(tb.Text);
            double r = Math.Sqrt(a / Math.PI);
            double c = Math.Sqrt(4 * a * Math.PI);
            // to prevent loops
            if (tb.Focused)
            {
                tbRadius.Text = r.ToString("0.####");
                tbLength.Text = c.ToString("0.####");
            }
        }

        private void btnLegend_Click(object sender, EventArgs e)
        {
            if (pnlLegend.Visible)
            {
                pnlLegend.Visible = false;
                this.MinimumSize = new Size(242, 340);
                this.MaximumSize = new Size(242, 340);
                this.Size = new Size(242, 340);
                btnLegend.Text = "Show legend =>";
            }
            else
            {
                pnlLegend.Visible = true;
                this.MinimumSize = new Size(520, 340);
                this.MaximumSize = new Size(520, 340);
                this.Size = new Size(520, 340);
                btnLegend.Text = "Hide legend <=";
            }
        }
    }
}
