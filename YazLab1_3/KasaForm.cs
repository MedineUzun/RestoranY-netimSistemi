using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazLab1_3
{
    public partial class KasaForm : Form
    {
        int masa = 0;
        int j = 1;
        public KasaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {

                masa = (masa % 6) + 1;

                richTextBox1.AppendText($" {masa} masası ödemesini yaptı yeni müşteri olusturabılır " + Environment.NewLine);

                if (j == 3 || i <= 6)
                {
                    j = 1;
                    break;
                }

                j++;

            }

        }
    }
}
