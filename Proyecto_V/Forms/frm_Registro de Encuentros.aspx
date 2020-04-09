<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="frm_Registro de Encuentros.aspx.cs" Inherits="Proyecto_V.Forms.frm_Registro_de_Encuentros" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Hoja%20Estilos/Estilos_Actualizar_jugador.css" rel="stylesheet" />
    <div class="jumbotron text-center">
        <h2>Registro de encuentros</h2>
    </div>

    <div class ="container" id="IdContenedor">
        <div class="row" id="IdRow">
            <div class="col-sm-4" id="IdContenido1">

            </div>
            <div class="col-sm-4" id="IdContenido2">
                   <h3>Lista de Torneos</h3>
                <asp:DropDownList ID="dl_lista_torneos" runat="server" AutoPostBack="True" DataTextField="C_NOMBRE_TORNEO" DataValueField="C_CONSECUTIVO" OnSelectedIndexChanged="dl_lista_torneos_SelectedIndexChanged"></asp:DropDownList>
                <br />
            </div>
            <div class="col-sm-4" id="IdContenido3">

            </div>
        </div>
    </div>
    <br />
    <br />
    <br />

    <div class="container" id="Idcontenedor2">
        <h2>Lista de equipos</h2>
        <div class="row" id="row2">
            <div class="col-sm-4" id="conatenido1">
                <h3>Equipo Casa</h3>
                <br />
                <asp:DropDownList ID="dl_lista_casa" runat="server" AutoPostBack="True" DataTextField="C_NOMBRE_EQUIPO" DataValueField="C_FK_EQUIPOS" OnSelectedIndexChanged="dl_lista_casa_SelectedIndexChanged"></asp:DropDownList>
            </div>
            <div class="col-sm-4" id="conatenido2">
                <h3>Equipo Visita</h3>
                <br />
                <asp:DropDownList ID="dl_lista_visita" runat="server" AutoPostBack="True" DataTextField="C_NOMBRE_EQUIPO" DataValueField="C_FK_EQUIPOS"></asp:DropDownList>
            </div>
            <div class="col-sm-4" id="conatenido3">

            </div>
        </div>
    </div>

</asp:Content>
