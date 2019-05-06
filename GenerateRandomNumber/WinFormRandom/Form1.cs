using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormRandom
{
    public partial class Form1 : Form
    {
        List<int> numbers = new List<int>();
        static int qt;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnran_Click(object sender, EventArgs e)
        {
            int i;
            Random random = new Random();

            if (numbers.Count == 0)
            {
                for (i = 1; i <= qt; i++)
                {
                    numbers.Add(i);
                }
            }

            int rnum = numbers[random.Next(qt)];
           
            textRandom.Text += numbers[rnum].ToString()+"\t";
            qt--;
            numbers.RemoveAt(rnum);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            qt = 10;
            textRandom.Text = string.Empty;
        }
    }
}
