<%@ Page Title="" Language="C#" MaintainScrollPositionOnPostback="true" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="frm_Registro de Encuentros.aspx.cs" Inherits="Proyecto_V.Forms.frm_Registro_de_Encuentros" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Hoja%20Estilos/Estilos_Actualizar_jugador.css" rel="stylesheet" />
    <link href="../Hoja%20Estilos/Estilos_Reg_Jugadores.css" rel="stylesheet" />
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
                  <h3>Fecha del partido</h3>
                <br />
                <asp:Calendar ID="id_fecha" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="152px" ShowGridLines="True" Width="197px">
                    <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                    <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                    <OtherMonthDayStyle ForeColor="#CC9966" />
                    <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                    <SelectorStyle BackColor="#FFCC66" />
                    <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                    <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                </asp:Calendar>
            </div>
        </div>
    </div>
    <br />
    <br />
    <br />
    <div class="container">
        <asp:Button Text="Agregar encuentro" ID="btn_agregar_encuentro" CssClass="btn btn-primary" runat="server" OnClick="btn_agregar_encuentro_Click" />
        <br />
        <br />
        <br />
        <asp:Label Text="" ID="lbl_mensaje" ForeColor="Red" runat="server" />
    </div>
    <br />
    <br />
    <br />
    <br />
    <div class="jumbotron text-center" id="Titulo2">
        <h2>Mantenimiento de encuentros</h2>
    </div>
    <br />
    <div class="container" id="Idcontenedor_mantenimiento">
        <h3>Lista de torneos</h3>
        <br />
        <asp:DropDownList ID="dl_lista_torneo2"  runat="server" AutoPostBack="True" DataTextField="C_NOMBRE_TORNEO" DataValueField="C_CONSECUTIVO"></asp:DropDownList>
        <br />
        <br />
        <asp:Button Text="Buscar partidos" CssClass="btn btn-primary" ID="btn_buscar_partido" runat="server" OnClick="btn_buscar_partido_Click" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <h3>Lista de partidos</h3>
        <br />
        <asp:GridView ID="tbl_lista_partidos" CssClass="mGrid" runat="server" AllowPaging="True" AutoGenerateColumns="False" OnPageIndexChanging="tbl_lista_partidos_PageIndexChanging" PageSize="3">
            <Columns>
                <asp:BoundField DataField="C_CONSECUTIVO" HeaderText="Id Partido" />
                <asp:BoundField DataField="C_NOMBRE_TORNEO" HeaderText="Torneo" />
                <asp:BoundField DataField="FECHA" HeaderText="Fecha" />
                <asp:BoundField DataField="CASA" HeaderText="Equipo Casa" />
                <asp:BoundField DataField="VISITA" HeaderText="Equipo Visita" />
                <asp:BoundField DataField="C_GOL_CASA" HeaderText="Casa" />
                <asp:BoundField DataField="C_GOL_VISITA" HeaderText="Visita" />
                <asp:TemplateField HeaderText="Seleccionar">
                    <ItemTemplate>
                        <asp:CheckBox ID="ch_seleccionar" runat="server" AutoPostBack="True" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    <br />
    <br />
    <br />
    <br />
</asp:Content>
