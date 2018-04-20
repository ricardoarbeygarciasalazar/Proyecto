using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ProyectoWeb1Ricardo.Web.Views.PosiblesClientes
{
    public partial class PosiblesClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    Controllers.SubirPistaController obsubirPistaController = new Controllers.SubirPistaController();
                    DataSet dsConsulta = obsubirPistaController.getConsultarPistasController();


                    if (dsConsulta.Tables[0].Rows.Count > 0)
                    {


                    }
                    else
                        throw new Exception
                        {

                        };

                }
            }
            catch (Exception ex) { ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", "<script>swal('¡Error!', '" + ex.Message + "', 'error')</script>"); }
        }
    }
}