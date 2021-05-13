using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeNoAndSeries
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int flag = 0, m = 0;
            int n = Convert.ToInt32(txt_add.Text);
            m = n / 2;
            for (int i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    txt_add.Text = "It Is Not Prime Number";
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                txt_add.Text = "It Is Prime Number";
            txt_add.Visible = true;
        }

        private void btnSeries_Click(object sender, EventArgs e)
        {
            int n1, n2;
            String x = " ";
            n1 = int.Parse(txtseries1.Text);
            n2 = int.Parse(txtseries2.Text);
            for (int i = n1; i <= n2; i++)
            {
                int counter = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                        break;
                    }
                }
                if (counter == 0 && i != 1)
                {
                    x = x + " " + i;
                }
            }
            lab1.Text = x;
            lab1.Visible = true;
        }
    }
}
