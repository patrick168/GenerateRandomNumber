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
        bool stop;

        public Form1()
        {
            InitializeComponent();
        }

        private void EnableItem(bool isEnable)
        {
            tbMax.Enabled = isEnable;
            tbMin.Enabled = isEnable;
        }

        private void btnran_Click(object sender, EventArgs e)
        {
            EnableItem(false);

            if (rNumbers.Count == 0 && !stop)
            {
                GenerateNumbersByOrder();
                GenerateRandomNumbers();
            }
           
            if(rNumbers.Count==0)
            {
                MessageBox.Show("亂數已經全部產生完");
                stop = true;
            }
            else
            {
                listBoxResult.Items.Insert(0, rNumbers[0].ToString());
                rNumbers.Remove(rNumbers[0]);
                stop = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            qt = 10;
            stop = false;
        }

        private void GenerateRandomNumbers()
        {
            Random random = new Random();
            for (int i = 0; i < qt; i++)
            {
                int rOrder = random.Next(qt);
                int temp;
                temp = rNumbers[i];
                rNumbers[i] = rNumbers[rOrder];
                rNumbers[rOrder] = temp;               
            }
            //else
            //{
            //    MessageBox.Show("亂數已經全部產生完");
            //}
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


        private void btnGenAll_Click(object sender, EventArgs e)
        {
            EnableItem(false);

            if (rNumbers.Count == 0 && !stop)
            {
                GenerateNumbersByOrder();
                GenerateRandomNumbers();
            }

            while(rNumbers.Count != 0)
            {
                listBoxResult.Items.Insert(0, rNumbers[0].ToString());
                rNumbers.Remove(rNumbers[0]);
            }

            stop = true;
            MessageBox.Show("亂數已經全部產生完");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            qt = 10;
            rNumbers.Clear();
            listBoxResult.Items.Clear();
            EnableItem(true);
            stop = false;
        }
    }
}