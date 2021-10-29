﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1_ViewstateDemo
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Number Of Applications :"+ Application["TotalApplications"]);
            Response.Write("<br/>");
            Response.Write("Number Of Users Online:" + Application["TotalUserSessions"]);
        }
    }
}