using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoWeb1Ricardo.Web.Views.Index
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                string stLogin = string.Empty;
                if (Request.QueryString["stLogin"] != null)
                    stLogin = Request.QueryString["stLogin"].ToString();

                if (Session["sesionLogin"] != null)//validar
                    stLogin = Session["sesionLogin"].ToString();//Rececionar
                else
                    Response.Redirect("../Login/Login.aspx");


            }
        }
    }
}