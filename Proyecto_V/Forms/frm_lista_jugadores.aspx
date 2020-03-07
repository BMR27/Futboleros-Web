<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="frm_lista_jugadores.aspx.cs" Inherits="Proyecto_V.Forms.frm_lista_jugadores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Hoja%20Estilos/Estilos_Reg_Jugadores.css" rel="stylesheet" />
      <h2 id="Titulo">Jugadores del torneo</h2>
    <!----Hacemos una lista para mostrar a los jugadores-->
    <div id="cont">
        <asp:GridView ID="tbl_lista_jugadores" runat="server" AutoGenerateColumns="False" CssClass="mGrid">
        <Columns>
            <asp:BoundField DataField="C_CEDULA" HeaderText="Número Cédula" />
            <asp:BoundField DataField="C_NOMBRE" HeaderText="Nombre" />
            <asp:BoundField DataField="C_APELLIDO1" HeaderText="Apellido 1" />
            <asp:BoundField DataField="C_APELLIDO2" HeaderText="Apellido 2" />
            <asp:BoundField DataField="FECHA" HeaderText="Nacimiento" />
            <asp:BoundField DataField="TELEFONO" HeaderText="Télefono" />
            <asp:BoundField DataField="CORREO" HeaderText="Correo" />
            <asp:BoundField DataField="GENERO" HeaderText="Género" />
            <asp:BoundField DataField="PROVINCIA" HeaderText="Provincia " />
            <asp:BoundField DataField="CANTON" HeaderText="Cantón" />
            <asp:BoundField DataField="DISTRITO" HeaderText="Distrito" />
            <asp:TemplateField HeaderText="Seleccionar">
                <ItemTemplate>
                    <asp:CheckBox ID="ch_tbl_jugadores" runat="server" AutoPostBack="True" OnCheckedChanged="ch_tbl_jugadores_CheckedChanged" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
      </asp:GridView>
        <asp:Button ID="btn_cambiar" runat="server" Text="Cambiar Jugador" CssClass="btn btn-primary" OnClick="btn_cambiar_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_eliminar" runat="server" Text="Eliminar Jugador" CssClass="btn btn-primary" OnClick="btn_eliminar_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_actualizar" runat="server" Text="Actualizar Jugador" CssClass="btn btn-primary" OnClick="btn_actualizar_Click" />
    </div>
</asp:Content>
