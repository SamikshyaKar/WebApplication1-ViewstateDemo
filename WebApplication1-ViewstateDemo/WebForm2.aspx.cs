using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1_ViewstateDemo
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        int ClicksCount2 = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { Mytext2.Text = "0"; }

        }

        protected void Mytext2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Click1_Click(object sender, EventArgs e)
        {
            if (ViewState["Clicks"] != null)
            {
                ClicksCount2 = (int)ViewState["Clicks"] + 1;
            }

            Mytext2.Text = ClicksCount2.ToString();
            ViewState["Clicks"] = ClicksCount2;

        }
    }
}