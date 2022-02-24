using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestPage
{
    public partial class gutanwr3 : Form
    {
        int fin = 0;
        public gutanwr3()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (true == gudAnswr1.Checked)
            {
                fin++;
            }
            if (true == gutanswr2.Checked)
            {
                fin++;
            }
            if (true == gudanswr3.Checked)
            {
                fin++;
            }
            if (true == gudanswr4.Checked)
            {
                fin++;
            }
            if (true == gudanswr5.Checked)
            {
                fin++;
            }
            if (true == gutanswr6.Checked)
            {
                fin++;
            }
            if (true == gudanswr7.Checked)
            {
                fin++;
            }
            if (true == gudanswr8.Checked)
            {
                fin++;
            }
            if (true == gudanswer9.Checked)
            {
                fin++;
            }
            if (true == gudanswer10.Checked)
            {
                fin++;
            }
            pasux.Text = (fin.ToString() + "/10");
        }
    }
}
