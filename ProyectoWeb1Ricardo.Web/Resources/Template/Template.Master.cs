﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoWeb1Ricardo.Web.Resources.Template
{
    public partial class Template : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbSalir_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("../../Views/Login/Login.aspx");
        }
    }
}