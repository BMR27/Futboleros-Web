<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="frm_lista_equipos.aspx.cs" Inherits="Proyecto_V.Forms.frm_lista_equipos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Hoja%20Estilos/Estilos_Reg_Jugadores.css" rel="stylesheet" />
      <h2 id="Titulo">Lista de Equipos Registrados</h2>
    <!----Hacemos una lista para mostrar los equipos registrados-->
    <div id="cont">
        <asp:GridView ID="tbl_lista_equipos" runat="server" AutoGenerateColumns="False" CssClass="mGrid" OnSelectedIndexChanged="ch_tbl_equipos_CheckedChanged" AllowPaging="True" OnPageIndexChanging="tbl_lista_equipos_PageIndexChanging" PageSize="6">
        <Columns>
            <asp:BoundField DataField="C_CONSECUTIVO" HeaderText="Codigo" />
            <asp:BoundField DataField="C_NOMBRE_EQUIPO" HeaderText="Nombre del Equipo" />
            <asp:BoundField DataField="PROVINCIA" HeaderText="Provincia" />
            <asp:BoundField DataField="CANTON" HeaderText="Canton" />
            <asp:BoundField DataField="DISTRITO" HeaderText="Distrito" />
            <asp:BoundField DataField="FUNDACION" HeaderText="Fundacion del Equipo" />
            <asp:TemplateField HeaderText="Seleccionar">
                <ItemTemplate>
                    <asp:CheckBox ID="ch_tbl_equipos" runat="server" AutoPostBack="True" OnCheckedChanged="ch_tbl_equipos_CheckedChanged" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
      </asp:GridView>
        <asp:Button ID="btn_cambiar" runat="server" Text="Cambiar Equipo" CssClass="btn btn-primary" OnClick="btn_cambiar_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_eliminar" runat="server" Text="Eliminar Equipo" CssClass="btn btn-primary" OnClick="btn_eliminar_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_actualizar" runat="server" Text="Actualizar Equipo" CssClass="btn btn-primary" OnClick="btn_actualizar_Click" />
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
