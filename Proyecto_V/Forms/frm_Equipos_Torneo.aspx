<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="frm_Equipos_Torneo.aspx.cs" Inherits="Proyecto_V.Forms.frm_Equipos_Torneo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <!----->
    <link href="../Hoja%20Estilos/EstilosJugEquipos.css" rel="stylesheet" />
    <!---Inicio-->
    <div class="jumbotron text-center">
        <h2>Registro de Equipos a los Torneos</h2>
    </div>


    <!---Contenidos-->
    <div class="container" id="IdContenedor">
        <div class="row" id="IdRow">
            <div class="col-sm-4" id="IdContenido1">
                <h3>Lista de Torneos</h3>
                <br />
                <asp:DropDownList ID="dl_lista_torneos" runat="server" AutoPostBack="True" DataTextField="C_NOMBRE_TORNEO" DataValueField="C_CONSECUTIVO" OnSelectedIndexChanged="dl_lista_torneos_SelectedIndexChanged"></asp:DropDownList>
                <br />
                  <br />
                  <br />
                <asp:Button Text="Seleccionar Otro" ID="btn_cambiar_seleccion" CssClass ="btn btn-primary" Width="200px" runat="server" OnClick="btn_cambiar_seleccion_Click" />
            </div>
            <div class="col-sm-4" id="IdContenido2">

            </div>
            <div class="col-sm-4" id="IdContenido3">
                <h3>Equipos a Elegir</h3>
                <br />
                <asp:GridView ID="tbl_equipos" CssClass="mGrid" runat="server" AutoGenerateColumns="False" AllowPaging="True" PageSize="8" OnPageIndexChanging="tbl_equipos_PageIndexChanging" OnSelectedIndexChanged="tbl_equipos_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="C_CONSECUTIVO" HeaderText="Consecutivo" />
                        <asp:BoundField DataField="C_NOMBRE_EQUIPO" HeaderText="Nombre Equipo" />
                        <asp:BoundField DataField="FUNDACION" HeaderText="Fundacion" />
                        <asp:TemplateField HeaderText="Seleccionar">
                            <ItemTemplate>
                                <asp:CheckBox ID="ch_seleccionar" runat="server" AutoPostBack="True" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <br />
                <br />
                <asp:Button ID="btn_cambiar" runat="server" Text="Cambiar Equipo" CssClass="btn btn-primary" OnClick="btn_cambiar_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button Text="Agregar" ID="btn_agregar_equipo" CssClass="btn btn-primary" Width="200px" runat="server" OnClick="btn_agregar_equipo_Click" />
            </div>
        </div>
    </div>
    
    <br />
        <div id="contenedor" class="container well container">
         <asp:Label ID="lbl_mensaje" runat="server"></asp:Label>
        </div>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />



</asp:Content>
