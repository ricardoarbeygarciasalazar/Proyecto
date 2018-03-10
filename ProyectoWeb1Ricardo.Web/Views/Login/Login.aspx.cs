using System;

namespace ProyectoWeb1Ricardo.Web.Views.Login
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", "<script>swal('Buen Trabajo!', 'Se realizo proceso con exito!', 'success')</script>");

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string stMensaje = string.Empty;

                if (string.IsNullOrEmpty(txtEmail.Text)) stMensaje += "Ingrese Email,";
                if (string.IsNullOrEmpty(txtPassword.Text)) stMensaje += "Ingrese Password,";
                if (!string.IsNullOrEmpty(stMensaje)) throw new Exception(stMensaje.TrimEnd(','));

                //defino objeto con propiedades
                Logica.Models.clsUsuarios obclsUsuarios = new Logica.Models.clsUsuarios
                {
                    stLogin = txtEmail.Text,
                    stPassword = txtPassword.Text,
                };
                //instancio controlador
                Controllers.LoginController obloginController = new Controllers.LoginController();
                bool blBandera = obloginController.getValidarUsuarioController(obclsUsuarios);

                //mod
                if (blBandera)
                    Response.Redirect("../Index/Index.aspx");//redirecciono
                else
                    throw new Exception("Usuario o Password Incorrectos");
            } catch (Exception ex){

                ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", "<script>swal('¡Error!', '"+ex.Message+"', 'error')</script>");
            }
        }
    }
}