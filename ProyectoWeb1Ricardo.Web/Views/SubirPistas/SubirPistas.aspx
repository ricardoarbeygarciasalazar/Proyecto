<%@ Page Title="" Language="C#" MasterPageFile="~/Resources/Template/Template.Master" AutoEventWireup="true" CodeBehind="SubirPistas.aspx.cs" Inherits="ProyectoWeb1Ricardo.Web.Views.SubirPistas.SubirPistas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenedor" runat="server">



    <div class="mx-auto mt-5">
        ¡Llena Toda La Informacion Necesaria!
        <div class="form-group">

            <div class="form-row">
              


                <div class="col-md-6">
                    <asp:label runat="server" id="lblNombres" text="Nombre de la pista"></asp:label>
                    <asp:textbox runat="server" id="TextBox1" cssclass="form-Control"></asp:textbox>
                </div>

              

                
            </div>
            <div class="form-row">

                    <div class="col-md-6">
                    <asp:label runat="server" id="lblDuracion" text="Duracion de la pista"></asp:label>
                    <asp:textbox runat="server" id="TextBox2" cssclass="form-Control"></asp:textbox>
                </div>



            </div>


             <div class="form-row">

         
                   <div class="col-md-6">
                    <asp:label runat="server" id="lblObservacion" text="Descripcion de tu pista"></asp:label>
                    <asp:textbox runat="server" id="TextBox3" cssclass="form-Control"></asp:textbox>
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
                       <asp:Button ID="btnSubir" runat="server" 
                           CssClass="btn btn-block btn-primary" 
                           Text="Subir"/>


</div>

</div>
        </div>

    </div>
</asp:Content>


