using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormRandom
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnRanNO_Click(object sender, EventArgs e)
        {
            int i,qt=10;
            Random random = new Random();
            List<int> numbers = new List<int>();
            for(i=0;i< qt; i++)
            {
                numbers.Add(i);
            }

            int rnum = random.Next(qt-i);
            ResultBoX.Text = rnum.ToString();
        }
    }
}