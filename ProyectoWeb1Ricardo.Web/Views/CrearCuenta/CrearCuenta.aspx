<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrearCuenta.aspx.cs" Inherits="ProyectoWeb1Ricardo.Web.Views.CrearCuenta.CrearCuenta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <title>¡Registrate!</title>
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
    <script src="../../js/sweetalert.min.js" type="text/javascript" ></script>

</head>
<body class="bg-dark">
    
        <div  class="container">
            <div class="card mx-auto mt-5">
                <div class="card-header">
                    Crear cuenta
                </div>
                <div class="card-body">
                    <form id="form1" runat="server">
                        <div class="form-group">
                            <div class="form-row">

                                <div class="col-md-12">
                    <asp:label runat="server" id="lblUsuario" text="Ingresa tu nombre de usuario:"></asp:label>
                    <asp:textbox runat="server" id="txtUsuario" TextMode="Email" cssclass="form-Control"></asp:textbox>
                </div>


                <div class="col-md-6">
                    <asp:label runat="server" id="lblApellidos" text="Ingresa Tus Apellidos:"></asp:label>
                    <asp:textbox runat="server" id="txtApellidos" cssclass="form-Control"></asp:textbox>
                </div>




                            </div>
                        </div>
                        </form>
                </div>
            </div>
        </div>
    
</body>
</html>
