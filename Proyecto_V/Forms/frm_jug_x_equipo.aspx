<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="frm_jug_x_equipo.aspx.cs" Inherits="Proyecto_V.Forms.frm_jug_x_equipo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!----->
    <link href="../Hoja%20Estilos/EstilosJugEquipos.css" rel="stylesheet" />
    <!---Inicio-->
    <div class="jumbotron text-center">
        <h2>Asignar jugadores por equipo</h2>
    </div>

    <!---Contenidos-->
    <div class="container" id="IdContenedor">
        <div class="row" id="IdRow">
            <div class="col-sm-4" id="IdContenido1">
                <h3>Lista de equipos</h3>
                <br />
                <asp:DropDownList ID="dl_lista_equipos" runat="server" AutoPostBack="True" DataTextField="C_NOMBRE_EQUIPO" DataValueField="C_CONSECUTIVO" OnSelectedIndexChanged="dl_lista_equipos_SelectedIndexChanged"></asp:DropDownList>
                <br />
                  <br />
                  <br />
                <asp:Button Text="Seleccionar Otro" ID="btn_cambiar_seleccion" CssClass ="btn btn-primary" Width="200px" runat="server" OnClick="btn_cambiar_seleccion_Click" />
            </div>
            <div class="col-sm-4" id="IdContenido2">

            </div>
            <div class="col-sm-4" id="IdContenido3">
                <h3>Jugadores sin equipo</h3>
                <br />
                <asp:GridView ID="tbl_jugadores" CssClass="mGrid" runat="server"></asp:GridView>
            </div>
        </div>
    </div>



</asp:Content>
