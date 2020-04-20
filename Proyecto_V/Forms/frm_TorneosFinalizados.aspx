<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="frm_TorneosFinalizados.aspx.cs" Inherits="Proyecto_V.Forms.frm_TorneosFinalizados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Hoja%20Estilos/EstilosJugEquipos.css" rel="stylesheet" />
    <link href="../Hoja%20Estilos/Estilos_Reg_Jugadores.css" rel="stylesheet" />

    <div class="jumbotron text-center">
        <h2>Torneos Finalizados</h2>
    </div>
    <div class="container" id="id-contenedor">
        <div class="row" id="id_contenedor_row">
            <div class="col-sm-4">
                <h3>Campeones</h3>
                <br />
                <br />
                <asp:GridView ID="tbl_campeones" runat="server" CssClass="mGrid"></asp:GridView>
            </div>
            <div class="col-sm-4">

            </div>
            <div class="col-sm-4">
                <h3>Campeones</h3>
                <br />
                <br />
                <asp:GridView ID="Goleador" runat="server" CssClass="mGrid"></asp:GridView>

            </div>
        </div>
    </div>
</asp:Content>
