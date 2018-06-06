<%@ Page Title="" Language="C#" MasterPageFile="~/Resources/Template/Template.Master" AutoEventWireup="true" CodeBehind="SubirPista.aspx.cs" Inherits="ProyectoWeb1Ricardo.Web.Views.SubirPista.SubirPista" %>

<asp:Content ID="ContentHeader" ContentPlaceHolderID="header" runat="server">
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="Contenedor" runat="server">
    <link href="../../css/sweetalert.css" rel="stylesheet">
    <script src="../../js/sweetalert.min.js"></script>
    <div class="mx-auto mt-5">
        <%-- aqui comienza la fila--%>
        <div class="form-group">
            <div class="form-row">
                <div class="col-md-12">
                    <h3>
                        <b>Subir Tu Pista</b>
                        <asp:Label runat="server" ID="lblOpcion"></asp:Label>
                    </h3>
                </div>
            </div>
        </div>
        <div class="form-group">
            <div class="form-row">

                <div class="col-md-3">
                    <asp:Label runat="server" ID="lblNombre" Text="Nombre De La Pista"></asp:Label>
                    <asp:TextBox runat="server" ID="txtNombreDeLaPista" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="col-md-3">
                    <asp:Label runat="server" ID="lblGenero" Text="Genero De Tu Pista"></asp:Label>
                    <asp:TextBox runat="server" ID="txtGeneroDeLaPista" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="col-md-3">
                    <asp:Label runat="server" ID="lblCodigo" Text="Codigo De Tu Pista  *Solo  Numeros*"></asp:Label>
                    <asp:TextBox runat="server" ID="txtCodigo" CssClass="form-control"></asp:TextBox>
                </div>



            </div>
        </div>


        <div class="form-group">
            <div class="form-row">
                <div class="col-md-12">
                    <asp:Label runat="server" ID="lblDemo" Text="Demo"></asp:Label>
                    <asp:TextBox runat="server" ID="txtDemo" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>

        <div class="form-group">
            <div class="form-row">
                <div class="col-md-12">
                    <asp:Label runat="server" ID="lblDescripcion" Text="Descripcion De La Pista"></asp:Label>
                    <asp:TextBox runat="server" ID="txtDescripcion" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>


        <%--Aqui termina la fila si queremos agregar otra con mas datos la copiamos y modificamos--%>
        <div class="form-group">
            <div class="form-row">
                <div class="col-md-12">

                    <asp:Button runat="server" ID="btnGuardar" Text="Guardar" CssClass="btn btn-primary" OnClick="btnGuardar_Click" />
                    <asp:Button runat="server" ID="btnCancelar" Text="Cancelar" CssClass="btn btn-primary" OnClick="btnCancelar_Click" />

                </div>
            </div>
        </div>
        <%--aqui otra seccion--%>
        <div class="form-group">
            <div class="form-row">
                <div class="col-md-12">
                    <h5>
                        <b>Resultado de busqueda</b>
                    </h5>
                </div>
            </div>
        </div>
        <div class="form-group">
            <div class="form-row">
                <div class="col-md-12" style="overflow: auto">
                    <asp:GridView runat="server" ID="gvwDatos" Width="100%" AutoGenerateColumns="False"
                        EmptyDataText="No se encontraron Registros" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCommand="gvwDatos_RowCommand">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <%--Representacion de datos en controles web,en este caso lo comento porque no lo necesito--%>


                            <asp:TemplateField HeaderText="Codigo">
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblCodigo" Text='<%# Bind("inCodigo")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField HeaderText="Nombre" DataField="stNombre" />
                            <asp:BoundField HeaderText="Genero" DataField="stGenero" />
                            <asp:BoundField HeaderText="Demo" DataField="stDemo" />
                            <asp:BoundField HeaderText="Observacion" DataField="stObservacion" />


                            <%--representacion en griview
                           <asp:BoundField HeaderText="Codigo" DataField="Codigo"/>
                           <asp:BoundField HeaderText="Nombre" DataField="Nombre"/>
                           <asp:BoundField HeaderText="Genero" DataField="Genero"/>
                           <asp:BoundField HeaderText="Demo" DataField="Demo"/>
                           <asp:BoundField HeaderText="Observacion" DataField="Observacion"/>--%>


                            <asp:TemplateField HeaderText="Editar">
                                <ItemTemplate>
                                    <asp:ImageButton ID="IbEditar" runat="server" ImageUrl="~/Resources/Images/edit (1).png"
                                        CommandName="Editar" CommandArgument="<%# ((GridViewRow)Container).RowIndex %>" />
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:TemplateField>


                            <asp:TemplateField HeaderText="Eliminar">
                                <ItemTemplate>
                                    <asp:ImageButton ID="IbEliminar" runat="server" ImageUrl="~/Resources/Images/remove.png"
                                        CommandName="Eliminar" CommandArgument="<%# ((GridViewRow)Container).RowIndex %>" />
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:TemplateField>
                        </Columns>

                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F5F7FB" />
                        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                        <SortedDescendingCellStyle BackColor="#E9EBEF" />
                        <SortedDescendingHeaderStyle BackColor="#4870BE" />

                    </asp:GridView>

                </div>
            </div>
        </div>
    </div>
</asp:Content>
