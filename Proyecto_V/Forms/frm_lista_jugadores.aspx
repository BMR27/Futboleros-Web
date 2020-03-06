<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="frm_lista_jugadores.aspx.cs" Inherits="Proyecto_V.Forms.frm_lista_jugadores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <h2>Jugadores del torneo</h2>
    <!----Hacemos una lista para mostrar a los jugadores-->
    <asp:GridView ID="tbl_lista_jugadores" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
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
        </Columns>
        <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
        <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
        <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
        <RowStyle BackColor="White" ForeColor="#003399" />
        <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
        <SortedAscendingCellStyle BackColor="#EDF6F6" />
        <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
        <SortedDescendingCellStyle BackColor="#D6DFDF" />
        <SortedDescendingHeaderStyle BackColor="#002876" />
      </asp:GridView>
</asp:Content>
