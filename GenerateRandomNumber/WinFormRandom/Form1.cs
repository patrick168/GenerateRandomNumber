using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinFormRandom
{
    public partial class Form1 : Form
    {
        List<int> rNumbers = new List<int>();       
        static int qt;
        bool stop;
        int minNum, maxNum;

        public Form1()
        {
            InitializeComponent();
        }

        private void EnableItem(bool isEnable)
        {
            tbMax.Enabled = isEnable;
            tbMin.Enabled = isEnable;
        }

        private bool InputError()
        {
            minNum = 0; maxNum = 0;
            bool minTryParsel, maxTryParse;

            try
            {
                minTryParsel = Int32.TryParse(tbMin.Text, out minNum);
                maxTryParse = Int32.TryParse(tbMax.Text, out maxNum);
                if (!minTryParsel || minNum < 0)
                {
                    minNum = -1;
                }
                if (!maxTryParse || maxNum < 0)
                {
                    maxNum = -1;
                }
                if (minNum == -1 || maxNum == -1 || minNum >= maxNum)
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                string errMsg = "操作錯誤:";
                if (minNum == -1)
                    errMsg += "\r\n最小數字請輸入正整數或0。";
                if (maxNum == -1)
                    errMsg += "\r\n最大數字請輸入正整數。";
                else if (minNum >= maxNum)
                    errMsg += "\r\n最小數字需小於最大數字。";

                MessageBox.Show(errMsg);
                return true;
            }
            return false;
        }

        private void btnran_Click(object sender, EventArgs e)
        {
            if (rNumbers.Count == 0)
            {
                if (InputError())
                    return;
            }

            EnableItem(false);
            qt = maxNum - minNum + 1;

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
        }

        private void GenerateNumbersByOrder()
        {
            int i;            

            if (rNumbers.Count == 0)
            {
                for (i = minNum; i <= maxNum; i++)
                {
                    rNumbers.Add(i);
                }
            }          
        }

        private void btnGenAll_Click(object sender, EventArgs e)
        {
            if (rNumbers.Count == 0)
            {
                if (InputError())
                    return;
            }

            EnableItem(false);
            qt = maxNum - minNum + 1;

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
            qt = 0;
            rNumbers.Clear();
            listBoxResult.Items.Clear();
            EnableItem(true);
            stop = false;
        }
    }
}