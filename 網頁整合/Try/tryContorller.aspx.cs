﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 網頁整合.Try
{
    public partial class tryContorller : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            p1.InnerText = IsPostBack?"123": "321";
        }
    }
}