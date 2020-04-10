<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="frm_entrada.aspx.cs" Inherits="Proyecto_V.Froms.frm_entrada" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="jumbotron text-center">
           <h2><asp:Label Text="" ID="lbl_mensaje" runat="server" /></h2>
    </div>

      <asp:Image id="Image1" runat="server" Height="500px" ImageUrl="~/Imagenes/inicio.jpg" 
      Width="1400px"  AlternateText="Imagen no disponible" ImageAlign="TextTop" />

</asp:Content>
