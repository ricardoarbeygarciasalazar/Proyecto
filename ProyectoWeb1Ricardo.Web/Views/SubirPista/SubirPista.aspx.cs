using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


namespace ProyectoWeb1Ricardo.Web.Views.SubirPista
{
    public partial class SubirPista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //try
          //  {
                if (!IsPostBack)
                {
                    Controllers.SubirPistaController obsubirPistaController = new Controllers.SubirPistaController();
                //DataSet dsConsulta = obsubirPistaController.getConsultarPistasController();

                getPistas();
                    //if (dsConsulta.Tables[0].Rows.Count > 0)
                      //  gvwDatos.DataSource = dsConsulta;
                    //else
                      // gvwDatos.DataSource = null;
                        
                    //gvwDatos.DataBind();
                }
           // }
            //catch (Exception ex) { ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", "<script>alert('" + ex.Message + "')</script>"); }
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
                if (string.IsNullOrEmpty(lblOpcion.Text))
                    ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", "<script> swal('Mensaje','" + obsubirPistaController.addPistasController(obclsPistas) + "','success')</script>");
              else
                    ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", "<script> swal('Mensaje','" + obsubirPistaController.updatePistasController(obclsPistas) + "','success')</script>");
                lblOpcion.Text = txtCodigo.Text = txtNombreDeLaPista.Text = txtGeneroDeLaPista.Text = txtDescripcion.Text = txtDemo.Text;

                getPistas();
                //ClientScript.RegisterStartupScript(this.GetType(), "Mensaje!", "<script>alert('" + obsubirPistaController.setAdministrarPistasController(obclsPistas,Convert.ToInt32(lblOpcion.Text)) + "')</script>");
            } catch (Exception ex) { ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", "<script> swal('Error','"+ex.Message+"','error')</script>"); }
        }

        protected void gvwDatos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
           
            try {


                int inIndice = Convert.ToInt32(e.CommandArgument);


                if (e.CommandName.Equals("Editar")) { lblOpcion.Text = "2";

                    txtCodigo.Text = ((Label)gvwDatos.Rows[inIndice].FindControl("lblCodigo")).Text;
                    txtNombreDeLaPista.Text = gvwDatos.Rows[inIndice].Cells[1].Text;
                    txtGeneroDeLaPista.Text = gvwDatos.Rows[inIndice].Cells[2].Text;
                    txtDemo.Text = gvwDatos.Rows[inIndice].Cells[3].Text;
                    txtDescripcion.Text= gvwDatos.Rows[inIndice].Cells[4].Text;

                }
                else if (e.CommandName.Equals("Eliminar")) { lblOpcion.Text = "3";
                    Logica.Models.clsPistas obclsPistas = new Logica.Models.clsPistas {

                        inCodigo  = Convert.ToInt32(((Label)gvwDatos.Rows[inIndice].FindControl("lblCodigo")).Text)

                };

                    Controllers.SubirPistaController obsubirPistaController = new Controllers.SubirPistaController();


;
                    ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", "<script> swal('Mensaje','" + obsubirPistaController.deletePistasController(obclsPistas) + "','success')</script>");

                }
            }
            catch  (Exception ex) { ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", "<script>alert('" + ex.Message + "')</script>"); }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            lblOpcion.Text = txtCodigo.Text = txtNombreDeLaPista.Text = txtGeneroDeLaPista.Text = txtDescripcion.Text = txtDemo.Text;
        }

        void getPistas()
        {

            try
            {
                Controllers.SubirPistaController obsubirPistaController = new Controllers.SubirPistaController();
                List<Logica.Models.clsPistas> lstclsPistas = obsubirPistaController.getPistasController();


                if (lstclsPistas.Count > 0)
                     gvwDatos.DataSource = lstclsPistas;
                else
                gvwDatos.DataSource = null;
                gvwDatos.DataBind();
            }
            catch   (Exception ex) { ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", "<script>alert('" + ex.Message + "')</script>"); }



        }

    }
}
    
