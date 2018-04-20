<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarCuenta.aspx.cs" Inherits="ProyectoWeb1Ricardo.Web.Views.RegistrarCuenta.RegistrarCuenta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <title>Login</title>
    <!-- Bootstrap core CSS-->
    <link href="../../vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <!-- Custom fonts for this template-->
    <link href="../../vendor/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css" />
    <!-- Custom styles for this template-->
    <link href="../../css/sb-admin.css" rel="stylesheet" />

    <!-- Bootstrap core JavaScript-->
    <script src="../../vendor/jquery/jquery.min.js"></script>
    <script src="../../vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
    <!-- Core plugin JavaScript-->
    <script src="../../vendor/jquery-easing/jquery.easing.min.js"></script>

    <link href="../../css/sweetalert.css" rel="stylesheet" />
    <script src="../../js/sweetalert.min.js" type="text/javascript"></script>

</head>
<body class="bg-dark">
    <div class="container-fluid">
        <div class="card card-login mx-auto mt-5">
            <div class="card-header">¡Registrate!    </div>
            <div class="card-body">
            
           <form id="form1" runat="server">

        <div class="form-group">

            <div class="form-row">
                <div class="col-md-12">
                    <asp:label runat="server" id="lblNombre" text="Ingresa Tu Nombre:"></asp:label>
                    <asp:textbox runat="server" id="txtNombre" cssclass="form-Control"></asp:textbox>
                </div>


                <div class="col-md-6">
                    <asp:label runat="server" id="lblApellidos" text="Ingresa Tus Apellidos:"></asp:label>
                    <asp:textbox runat="server" id="txtApellidos" cssclass="form-Control"></asp:textbox>
                </div>
                <div class="col-md-6">
                    <asp:label runat="server" id="lblCorreoElectronico" text="Ingresa Tu Correo Eletronico:"></asp:label>
                    <asp:textbox runat="server" id="txtCorreo" cssclass="form-Control"></asp:textbox>
                </div>

                <div>
                    Selecciona Tu Genero:
                    <asp:RadioButton ID="rbHombre" runat="server"  Text="Hombre" />
                    <asp:RadioButton ID="rbMujer" runat="server" Text="Mujer" />
                </div>

            </div>
        </div>
             
        <div class="form-group">

            <div class="form-row">
                <div class="col-md-7">
                    Selecciona tu fecha de nacimiento:
                    <br />
                    Año<asp:dropdownlist runat="server" id="ddlAñoNacimiento" cssclass="form-control" Height="21px" Width="134px">
                 <asp:ListItem Value="1" Text="1985"></asp:ListItem>
                 <asp:ListItem Value="2" Text="1986"></asp:ListItem>
                 <asp:ListItem Value="3" Text="1987"></asp:ListItem>
                 <asp:ListItem Value="4" Text="1988"></asp:ListItem>
                 <asp:ListItem Value="5" Text="1989"></asp:ListItem>
                 <asp:ListItem Value="6" Text="1990"></asp:ListItem>
                 <asp:ListItem Value="7" Text="1991"></asp:ListItem>
                 <asp:ListItem Value="8" Text="1992"></asp:ListItem>
                 <asp:ListItem Value="9" Text="1993"></asp:ListItem>
                 <asp:ListItem Value="10" Text="1994"></asp:ListItem>
                 <asp:ListItem Value="11" Text="1995"></asp:ListItem>
                 <asp:ListItem Value="12" Text="1996"></asp:ListItem>
                 <asp:ListItem Value="13" Text="1997"></asp:ListItem>
                 <asp:ListItem Value="14" Text="1998"></asp:ListItem>
                 <asp:ListItem Value="15" Text="1999"></asp:ListItem>
                 <asp:ListItem Value="16" Text="2000"></asp:ListItem>
             </asp:dropdownlist>
                    Mes<asp:dropdownlist runat="server" id="ddlMesNacimiento" cssclass="form-control" Height="21px" Width="134px">
                 <asp:ListItem Value="1" Text="Enero"></asp:ListItem>
                 <asp:ListItem Value="2" Text="Febrero"></asp:ListItem>
                 <asp:ListItem Value="3" Text="Marzo"></asp:ListItem>
                 <asp:ListItem Value="4" Text="Abril"></asp:ListItem>
                 <asp:ListItem Value="5" Text="Mayo"></asp:ListItem>
                 <asp:ListItem Value="6" Text="Junio"></asp:ListItem>
                 <asp:ListItem Value="7" Text="Julio"></asp:ListItem>
                 <asp:ListItem Value="8" Text="Agosto"></asp:ListItem>
                 <asp:ListItem Value="9" Text="Septiembre"></asp:ListItem>
                 <asp:ListItem Value="10" Text="Octubre"></asp:ListItem>
                 <asp:ListItem Value="11" Text="Noviembre"></asp:ListItem>
                 <asp:ListItem Value="12" Text="Diciembre"></asp:ListItem>
             </asp:dropdownlist>
                    Dia<asp:dropdownlist runat="server" id="ddlDiaNacimiento" cssclass="form-control" Height="21px" Width="134px">
                 <asp:ListItem Value="1" Text="1"></asp:ListItem>
                        <asp:ListItem Value="1" Text="1"></asp:ListItem>
                        <asp:ListItem Value="2" Text="2"></asp:ListItem>
                        <asp:ListItem Value="3" Text="3"></asp:ListItem>
                        <asp:ListItem Value="4" Text="4"></asp:ListItem>
                        <asp:ListItem Value="5" Text="5"></asp:ListItem>
                        <asp:ListItem Value="6" Text="6"></asp:ListItem>
                        <asp:ListItem Value="7" Text="7"></asp:ListItem>
                        <asp:ListItem Value="8" Text="8"></asp:ListItem>
                        <asp:ListItem Value="9" Text="9"></asp:ListItem>
                        <asp:ListItem Value="10" Text="10"></asp:ListItem>
                        <asp:ListItem Value="11" Text="11"></asp:ListItem>
                        <asp:ListItem Value="12" Text="12"></asp:ListItem>
                        <asp:ListItem Value="13" Text="13"></asp:ListItem>
                        <asp:ListItem Value="14" Text="14"></asp:ListItem>
                        <asp:ListItem Value="15" Text="15"></asp:ListItem>
                        <asp:ListItem Value="16" Text="16"></asp:ListItem>
                        <asp:ListItem Value="17" Text="17"></asp:ListItem>
                        <asp:ListItem Value="18" Text="18"></asp:ListItem>
                        <asp:ListItem Value="19" Text="19"></asp:ListItem>
                        <asp:ListItem Value="20" Text="20"></asp:ListItem>
                        <asp:ListItem Value="21" Text="21"></asp:ListItem>
                        <asp:ListItem Value="22" Text="22"></asp:ListItem>
                        <asp:ListItem Value="23" Text="23"></asp:ListItem>
                        <asp:ListItem Value="24" Text="24"></asp:ListItem>
                        <asp:ListItem Value="25" Text="25"></asp:ListItem>
                        <asp:ListItem Value="26" Text="26"></asp:ListItem>
                        <asp:ListItem Value="27" Text="27"></asp:ListItem>
                        <asp:ListItem Value="28" Text="28"></asp:ListItem>
                        <asp:ListItem Value="29" Text="29"></asp:ListItem>
                        <asp:ListItem Value="30" Text="30"></asp:ListItem>
                        <asp:ListItem Value="31" Text="31"></asp:ListItem> 

             </asp:dropdownlist>
                <div class="col-md-6">
                    <asp:label runat="server" id="lblPoliticas" text="aceptas las Condiciones y confirmas que has leído nuestra Política de datos,"></asp:label>
                    <asp:checkbox runat="server" id="chkPoliticas" css="form-control" Text="Acepto"></asp:checkbox>

                </div>
                
                </div>
                <asp:Button ID="btnRegistrame" runat="server" CssClass="btn btn-primary btn-block" Text="Registrarme" OnClick="btnRegistrame_Click" />
            </div>


        </div>


              </form>
            
            
            </div>
        </div>
    </div>

</body>

</html>
