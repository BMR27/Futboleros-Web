<%@ Page Title="" Language="C#" MaintainScrollPositionOnPostback="true" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="frm_torneo_finalizado.aspx.cs" Inherits="Proyecto_V.Forms.frm_torneo_finalizado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Hoja%20Estilos/Estilos_Reg_Jugadores.css" rel="stylesheet" />
    <link href="../Hoja%20Estilos/HojaEstilos.css" rel="stylesheet" />

    <div class="jumbotron text-center">
        <h2>Datos de Torneos Finalizados</h2>
    </div>

    <div class="container" id="idcontenedor">
        <div class="row" id="idrow">
            <div class="col-sm-4">
                <h3>Lista de Torneos Finalizados</h3>
                <br />
                <br />
                <asp:DropDownList ID="dl_lista_finalizados" runat="server" DataTextField="C_NOMBRE_TORNEO" DataValueField="C_CONSECUTIVO" AutoPostBack="True" OnSelectedIndexChanged="dl_lista_finalizados_SelectedIndexChanged"></asp:DropDownList>
            </div>
            <div class="col-sm-4">

            </div>
            <div class="col-sm-4">
            </div>
        </div>
    </div>
    <br />
    <br />
    <br />
    <!---Division 1--->
    <div class="container" id="id_container 2">
        <div class="row" id="id_row_2">
            <div class="col-sm-4">

            </div>
            <div class="col-sm-4">
                <h3>Campeón </h3>
                <asp:GridView ID="tbl_campeon" CssClass="mGrid" runat="server" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="C_NOMBRE_EQUIPO" HeaderText="Nombre" />
                        <asp:BoundField DataField="Puntos" HeaderText="Puntos" />
                    </Columns>
                </asp:GridView>
            </div>
            <div class="col-sm-4">

            </div>
        </div>
    </div>
    
    <!---Division 1--->
    <br />
    <br />
    <br />
    <div class="container" id="id_container 3">
        <div class="row" id="id_row_3">
            <div class="col-sm-4">

            </div>
            <div class="col-sm-4">
                   <h3>Goleador </h3>
                <asp:GridView ID="tbl_goleador" CssClass="mGrid" runat="server" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="NOMBRE" HeaderText="Nombre Jugador" />
                        <asp:BoundField DataField="C_NOMBRE_EQUIPO" HeaderText="Equipo" />
                        <asp:BoundField DataField="GOLES" HeaderText="Goles" />
                    </Columns>
                </asp:GridView>
            </div>
            <div class="col-sm-4">

            </div>
        </div>
    </div>
</asp:Content>
