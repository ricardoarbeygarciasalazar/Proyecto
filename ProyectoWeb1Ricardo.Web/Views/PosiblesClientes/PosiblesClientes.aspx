<%@ Page Title="" Language="C#" MasterPageFile="~/Resources/Template/Template.Master" AutoEventWireup="true" CodeBehind="PosiblesClientes.aspx.cs" Inherits="ProyectoWeb1Ricardo.Web.Views.PosiblesClientes.PosiblesClientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Contenedor" runat="server">
    <div class="mx-auto mt-5">

        <div class="form-group">

            <div class="form-row">
                <div class="col-md-6">
                    <asp:label runat="server" id="lblEmpresa" text="Empresa"></asp:label>
                    <asp:textbox runat="server" id="txtEmpresa" cssclass="form-Control"></asp:textbox>
                </div>


                <div class="col-md-6">
                    <asp:label runat="server" id="lblNombres" text="Nombres"></asp:label>
                    <asp:textbox runat="server" id="TextBox1" cssclass="form-Control"></asp:textbox>
                </div>
            </div>
        </div>
        <div class="form-group">

            <div class="form-row">
                <div class="col-md-6">
                    <asp:label runat="server" id="lblGenero" text="Genero"></asp:label>
                    <asp:dropdownlist runat="server" id="ddlGenero" cssclass="form-control">
                 <asp:ListItem Value="1" Text="Femenino"></asp:ListItem>
                 <asp:ListItem Value="2" Text="Masculino"></asp:ListItem>
             </asp:dropdownlist>
                </div>
                <div class="col-md-6">
                    <asp:label runat="server" id="lblTieneCorreo" text="Tiene Correo"></asp:label>
                    <asp:checkbox runat="server" id="chkTieneCorreo" css="form-control"></asp:checkbox>

                </div>
            </div>

             <div class="form-row">
                   <div class="col-md-12">
                       <asp:Button ID="btnAceptar" runat="server" 
                           CssClass="btn btn-block btn-primary" 
                           Text="Aceptar"/>

<asp:GridView runat="server" ID="gvwDatos" AutoGenerateColumns="false" EmptyDataText="No Hay Registros" width="100%">
    <Columns>

        <asp:BoundField  Headertext="Identificacion" DataField="Identificacion"/>
        <asp:BoundField  Headertext="Nombres" DataField="Nombres"/>
        <asp:TemplateField Headertext="Apellidos">
            <ItemTemplate>

                <asp:TextBox ID="txtIdentificacion"
                    Runat="server"
                    CssClass="form-control"
                    Text=""
                    ></asp:TextBox>
            </ItemTemplate>

        </asp:TemplateField>
    </Columns>

</asp:GridView>
</div>

</div>
        </div>

    </div>
</asp:Content>
