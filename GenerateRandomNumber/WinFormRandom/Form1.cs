using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormRandom
{
    public partial class Form1 : Form
    {
        List<int> rNumbers = new List<int>();       
        int qt;
        bool stop;
        int minNum, maxNum;

        public Form1()
        {
            InitializeComponent();
        }

        //元件是否Enable的設定
        private void EnableItem(bool isEnable)
        {
            tbMax.Enabled = isEnable;
            tbMin.Enabled = isEnable;
        }

        //確認是否輸入錯誤
        private bool InputError()
        {
            minNum = 0; maxNum = 0;
            bool minTryParse, maxTryParse;

            try
            {
                minTryParse = Int32.TryParse(tbMin.Text, out minNum);
                maxTryParse = Int32.TryParse(tbMax.Text, out maxNum);
                if (!minTryParse || minNum < 0)
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

        //產生一個亂數
        private void btnran_Click(object sender, EventArgs e)
        {
            startRandom();

        
           
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
            lbrannumqt.Text = rNumbers.Count.ToString();
        }

        //初始狀態時做一些初始狀態的設定
        private void Form1_Load(object sender, EventArgs e)
        {
            qt = 0;
            lbrannumqt.Text = "";
            stop = false;
        }

        //產生亂數，洗牌
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

        //產生亂數的序號
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

        //產生所有亂數
        private void btnGenAll_Click(object sender, EventArgs e)
        {
            startRandom();
            
            while(rNumbers.Count != 0)
            {
                listBoxResult.Items.Insert(0, rNumbers[0].ToString());
                rNumbers.Remove(rNumbers[0]);
            }

            lbrannumqt.Text = "0";
            stop = true;
            MessageBox.Show("亂數已經全部產生完");
        }

        private void startRandom()
        {
            if (rNumbers.Count == 0)
            {
                if (InputError())
                    return;
            }

            EnableItem(false);
            qt = maxNum - minNum + 1;

            if (rNumbers.Count == 0 && !stop) //一開始狀態還沒產生亂數時建立好亂數
            {
                GenerateNumbersByOrder();
                GenerateRandomNumbers();
            }
        }

        //按下重置，清空已產生的亂數
        private void btnReset_Click(object sender, EventArgs e)
        {
            tbMin.Text = "1";
            tbMax.Text = "10";
            lbrannumqt.Text = "";
            qt = 0;
            rNumbers.Clear();
            listBoxResult.Items.Clear();
            EnableItem(true);
            stop = false;
        }
    }
}