<%@ Page Title="" Language="C#" MasterPageFile="~/Resources/Template/Template.Master" AutoEventWireup="true" CodeBehind="Pistas.aspx.cs" Inherits="ProyectoWeb1Ricardo.Web.Views.PosiblesClientes.PosiblesClientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Contenedor" runat="server">
    <div class="mx-auto mt-5">
        ¡Selecciona Un Item Para Iniciar La Busqueda!
        <div class="form-group">

            <div class="form-row">
              


                <div class="col-md-6">
                    <asp:label runat="server" id="lblNombres" text="Nombre de la pista"></asp:label>
                    <asp:textbox runat="server" id="TextBox1" cssclass="form-Control"></asp:textbox>
                </div>
            </div>
        </div>
        <div class="form-group">

            <div class="form-row">
                <div class="col-md-6">
                    <asp:label runat="server" id="lblGenero" text="Genero de la Pista"></asp:label>
                    <asp:dropdownlist runat="server" id="ddlGenero" cssclass="form-control">
                 <asp:ListItem Value="1" Text="Disco"></asp:ListItem>
                 <asp:ListItem Value="2" Text="Rock"></asp:ListItem>
                 <asp:ListItem Value="3" Text="Todo"></asp:ListItem>
             </asp:dropdownlist>
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
        <asp:BoundField  Headertext="Duracion" DataField="Duracion"/>
        <asp:TemplateField Headertext="Generos">

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
