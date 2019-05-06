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
        List<int> rNumbers = new List<int>();       
        static int qt;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnran_Click(object sender, EventArgs e)
        {
            GenerateNumbersByOrder();
            GenerateRandomNumbers();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            qt = 10;           
        }

        private void GenerateRandomNumbers()
        {
            Random random = new Random();
            if (qt > 0)
            {
                int rOrder = random.Next(qt);

                listBoxResult.Items.Insert(0, rNumbers[rOrder].ToString());
                qt--;
                rNumbers.Remove(rNumbers[rOrder]);
            }
            else
            {
                MessageBox.Show("亂數已經全部產生完");
            }
        }

        private void GenerateNumbersByOrder()
        {
            int i;            

            if (rNumbers.Count == 0)
            {
                for (i = 1; i <= qt; i++)
                {
                    rNumbers.Add(i);
                }
            }

          
        }

        private void shuffle()
        {

        }

        private void btnGenAll_Click(object sender, EventArgs e)
        {
            GenerateNumbersByOrder();
            while (qt > 0)
            {
                GenerateRandomNumbers();
            }
        }
    }
}
