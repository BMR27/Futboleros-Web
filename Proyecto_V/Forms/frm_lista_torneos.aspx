<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="frm_lista_torneos.aspx.cs" Inherits="Proyecto_V.Forms.frm_lista_torneos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link href="../Hoja%20Estilos/Estilos_Reg_Jugadores.css" rel="stylesheet" />
      <h2 id="Titulo">Lista de Torneos Registrados</h2>
    <!----Hacemos una lista para mostrar los torneos registrados-->
    <div id="cont">
        <asp:GridView ID="tbl_lista_torneos" runat="server" AutoGenerateColumns="False" CssClass="mGrid" OnSelectedIndexChanged="ch_tbl_torneos_CheckedChanged">
        <Columns>
            <asp:BoundField DataField="C_CONSECUTIVO" HeaderText="Codigo" />
            <asp:BoundField DataField="C_NOMBRE_TORNEO" HeaderText="Nombre del Torneo" />
            <asp:BoundField DataField="C_FK_USUARIO" HeaderText="Usuario" />
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
        <asp:Button ID="btn_actualizar" runat="server" Text="Actualizar Torneo" CssClass="btn btn-primary" OnClick="btn_actualizar_Click" />
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
