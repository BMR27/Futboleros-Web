<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="frm_lista_torneos.aspx.cs" Inherits="Proyecto_V.Forms.frm_lista_torneos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Hoja%20Estilos/EstilosJugEquipos.css" rel="stylesheet" />
    <link href="../Hoja%20Estilos/Estilos_Reg_Jugadores.css" rel="stylesheet" />
      <h2 id="Titulo">Lista de Torneos Registrados</h2>
    <div class="container">
        <div class="row">
            <div class="col-sm-4">
                <h3>Fecha Inicial</h3>
                <br />
                <asp:Calendar ID="c_fecha_inicial" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="True" Width="220px">
                    <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                    <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                    <OtherMonthDayStyle ForeColor="#CC9966" />
                    <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                    <SelectorStyle BackColor="#FFCC66" />
                    <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                    <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                </asp:Calendar>
            </div>
            <div class="col-sm-4">
                <h3>Fecha Final</h3>
                <br />
                <asp:Calendar ID="c_fecha_final" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="True" Width="220px">
                    <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                    <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                    <OtherMonthDayStyle ForeColor="#CC9966" />
                    <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                    <SelectorStyle BackColor="#FFCC66" />
                    <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                    <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                </asp:Calendar>
            </div>
            <div class="col-sm-4"></div>
        </div>
        <br />
        <br />
        <asp:Button Text="Buscar por fecha" ID="btn_buscar" CssClass="btn btn-primary" runat="server" OnClick="btn_buscar_Click" />
    </div>
    <br />
    <br />
    <!----Hacemos una lista para mostrar los torneos registrados-->
    <div id="cont">
        <asp:GridView ID="tbl_lista_torneos" runat="server" AutoGenerateColumns="False" CssClass="mGrid" OnSelectedIndexChanged="ch_tbl_torneos_CheckedChanged" AllowPaging="True" PageSize="5" OnPageIndexChanging="tbl_lista_jugadores_PageIndexChanging">
        <Columns>
            <asp:BoundField DataField="C_CONSECUTIVO" HeaderText="Codigo" />
            <asp:BoundField DataField="C_NOMBRE_TORNEO" HeaderText="Nombre del Torneo" />
            <asp:BoundField DataField="FECHA_INICIAL" HeaderText="Fecha Inicial" />
            <asp:BoundField DataField="FECHA_FINAL" HeaderText="Fecha Final" />
            <asp:BoundField DataField="C_CANT_EQUIPOS" HeaderText="Cantidad de Equipo" />
            <asp:TemplateField HeaderText="Seleccionar">
                <ItemTemplate>
                    <asp:CheckBox ID="ch_tbl_torneos" runat="server" AutoPostBack="True" OnCheckedChanged="ch_tbl_torneos_CheckedChanged"/>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
      </asp:GridView>
        <asp:Button ID="btn_cambiar" runat="server" Text="Cambiar Torneo" CssClass="btn btn-primary" OnClick="btn_cambiar_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_eliminar" runat="server" Text="Eliminar Torneo" CssClass="btn btn-primary" OnClick="btn_eliminar_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_actualizar" runat="server" Text="Actualizar Torneo" CssClass="btn btn-primary" OnClick="btn_actualizar_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_iniciar" runat="server" Text="Iniciar Torneo" CssClass="btn btn-primary" OnClick="btn_iniciar_Click" />
        <br />
        <asp:Label Text="" ID="lbl_mensaje" runat="server" />
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
    <br />


</asp:Content>
