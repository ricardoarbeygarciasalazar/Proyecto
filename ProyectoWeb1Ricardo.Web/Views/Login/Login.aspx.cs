using System;
using System.Web;
using static System.Net.WebRequestMethods;

namespace ProyectoWeb1Ricardo.Web.Views.Login
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", "<script>swal('Buen Trabajo!', 'Se realizo proceso con exito!', 'success')</script>");
            if (!IsPostBack)
            {
                if (Request.Cookies["Email"] != null) {
                    txtEmail.Text=Request.Cookies["Email"].Value.ToString();

                }

            }

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
                {
                    if (chkRecordar.Checked)
                    {
                        HttpCookie cookieEmail = new HttpCookie("Email", txtEmail.Text);
                        cookieEmail.Expires = DateTime.Now.AddDays(2);
                        Response.Cookies.Add(cookieEmail);
                    }
                    else
                    {

                        HttpCookie cookieEmail = new HttpCookie("Email", txtEmail.Text);
                        cookieEmail.Expires = DateTime.Now.AddDays(-1);
                        Response.Cookies.Add(cookieEmail);

                    }
                    //Otra manera de atrapar
                    //ViewState["viewLogin"] = txtEmail.Text;
                    //ViewState["viewPassword"] = txtPassword.Text;


                    //Definir sesion

                    Session["sesionLogin"] = txtEmail.Text;
                    Session["sesionPassword"] = txtPassword.Text;

                    //Para borrar variables de sesion:
                    //Session.RemoveAll(); borrar todas
                    //Session.RemoveAll("sesionLogin");Una variable en especifico

                    Response.Redirect("../Index/Index.aspx?stLogin=" + txtEmail.Text + "&stPassword=" + txtPassword.Text);//redirecciono

                }
                else
                    throw new Exception("Usuario o Password Incorrectos");
            } catch (Exception ex){

                ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", "<script>swal('¡Error!', '"+ex.Message+"', 'error')</script>");
            }
        }
    }
}