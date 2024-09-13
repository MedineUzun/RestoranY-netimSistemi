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
    public partial class AsciForm : Form
    {
        
        public AsciForm()
        {
            InitializeComponent();
        }
        int masa = 0;
        int j = 1;
        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            for (; i <= 9; i++)
            {
                masa = (masa % 6) + 1;
                j = (i % 2) + 1;
                richTextBox1.AppendText($" {j}. aşçı aldı {masa} masasının siparişini hazırlıyor." + Environment.NewLine);

                if (j == 2 )
                {
                    i = 4;
                }

                if ((masa % 3) == 0)
                {
                    break;
                }
            }

        }
    }
}
