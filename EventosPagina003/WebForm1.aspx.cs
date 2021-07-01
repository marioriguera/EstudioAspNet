﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventosPagina003
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("1) PreInit <br/>");
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("2) Init <br/>");
        }
        protected void Page_InitComplete(object sender, EventArgs e)
        {
            Response.Write("2) InitComplete <br/>");
        }
        protected void Page_PreLoad(object sender, EventArgs e)
        {
            Response.Write("2) PreLoad <br/>");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("2) Load <br/>");
        }
    }
}