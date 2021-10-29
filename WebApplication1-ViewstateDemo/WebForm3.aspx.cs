using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1_ViewstateDemo
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                MyText3.Text = "0";

            }
        }

        protected void ClickMe3_Click(object sender, EventArgs e)
        {
            int ClicksCount3 = Convert.ToInt32(MyText3.Text) + 1;
            MyText3.Text = ClicksCount3.ToString();
        }
    }
}