using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestPage
{
    public partial class saemocio : Form
    {
        int fin = 0;
        int j = 0;
        public saemocio()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (j == 0 && namebox.Text != "")
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
                j++;
                MessageBox.Show(fin.ToString() + "/10");
                textstore();
            }
            else if(namebox.Text == "")
            {
                MessageBox.Show("შეიყვანეთ სახელი");
            }
            else if (j!=0)
            {
                MessageBox.Show("Already submited");
            }
        }
        public void textstore()
        {
            StreamWriter writer = File.AppendText("summarys.txt");
            writer.WriteLine(namebox.Text + ":" + fin.ToString() + "/10");
            writer.Close();
        }

        private void RESET_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
