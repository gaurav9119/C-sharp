using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumAndProduct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] ar;
        int d1, i;
        string s = " ";

        private void Btn_sum_Click(object sender, EventArgs e)
        {
            int a = 0;
            foreach (int value in ar)
            {
                a += value;
            }
            lab_sum.Text = "Sum of array: " + a;
            lab_sum.Visible = true;
        }

        private void Btn_accept_Click(object sender, EventArgs e)
        {
            d1 = int.Parse(Interaction.InputBox("Enter Size of First Array", "TO Find sum and product"));
            ar = new int[d1];
            for (i = 0; i < d1; i++)
            {
                string m = "Enter the element of Array ";
                ar[i] = int.Parse(Interaction.InputBox(m, "sum and product of Array"));
                s = s + " " + ar[i];
            }
            lblarray.Text = "Array element : " + s;

            lblarray.Visible = true;
        }

        private void Btn_prod_Click(object sender, EventArgs e)
        {
            int a = 1;
            foreach (int value in ar)
            {
                a *= value;
            }
            lab_prod.Text = "Product of array: " + a;
            lab_prod.Visible = true;
        }
    }

        
}
