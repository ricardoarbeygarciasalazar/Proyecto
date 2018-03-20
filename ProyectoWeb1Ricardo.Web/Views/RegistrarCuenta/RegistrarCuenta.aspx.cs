using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoWeb1Ricardo.Web.Views.RegistrarCuenta
{
    public partial class RegistrarCuenta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrame_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("../Login/Login.aspx");
            }
            catch (Exception ex)
            {

                ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", "<script>swal('¡Error!', '" + ex.Message + "', 'error')</script>");
            }
        }
    }
}