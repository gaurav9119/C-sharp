using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Find_Word
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            string str = txt1.Text;
            string word = txt2.Text;
            int count = 0;
            string[] s1 = str.Split(' ');
            for (int i = 0; i < s1.Length; i++)
            {
                if (word.Equals(s1[i]))
                    count++;
            }

            //label1.Text="Total Frequency of word is : " count;
            MessageBox.Show(count.ToString());
        }
    }
}
