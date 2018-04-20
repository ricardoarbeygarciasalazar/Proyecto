using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ProyectoWeb1Ricardo.Web.Views.Credito
{
    public partial class Credito : System.Web.UI.Page
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
                        gvwDatos.DataSource = dsConsulta;
                    else
                       gvwDatos.DataSource = null;
                        
                    gvwDatos.DataBind();
                }
            }
            catch (Exception ex) { ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", "<script>alert('" + ex.Message + "')</script>"); }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try {
                string stMensaje = string.Empty;

                if (string.IsNullOrEmpty(txtCodigo.Text)) stMensaje += "Ingrese Codigo,";

                if (!string.IsNullOrEmpty(stMensaje)) throw new Exception(stMensaje.TrimEnd(','));

                Logica.Models.clsPistas obclsPistas = new Logica.Models.clsPistas {
                    inCodigo = Convert.ToInt32(txtCodigo.Text),
                    stNombre = txtNombreDeLaPista.Text,
                    stGenero = txtGeneroDeLaPista.Text,
                    stDemo = txtDemo.Text,
                    stObservacion = txtDescripcion.Text,
                };

                Controllers.SubirPistaController obsubirPistaController = new Controllers.SubirPistaController();

                if (string.IsNullOrEmpty(lblOpcion.Text)) lblOpcion.Text ="1";

                ClientScript.RegisterStartupScript(this.GetType(), "Mensaje!", "<script>alert('" + obsubirPistaController.setAdministrarPistasController(obclsPistas,Convert.ToInt32(lblOpcion.Text)) + "')</script>");
            } catch (Exception ex) { ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", "<script>alert('" + ex.Message + "')</script>"); }
        }

        protected void gvwDatos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int inIndice =Convert.ToInt32 (e.CommandArgument);
            try {
                if (e.CommandName.Equals("Editar")) { lblOpcion.Text = "2"; }
                else if (e.CommandName.Equals("Eliminar")) { lblOpcion.Text = "3"; }
            }
            catch  (Exception ex) { ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", "<script>alert('" + ex.Message + "')</script>"); }
        }
    }
}
    
