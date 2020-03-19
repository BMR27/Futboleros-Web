<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="frm_actualizar_equipo.aspx.cs" Inherits="Proyecto_V.Forms.frm_actualizar_equipo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link href="../Hoja%20Estilos/Estilos_Actualizar_jugador.css" rel="stylesheet" />
    <h2>Actualizar datos del Equipo</h2>
    <section class="frm_actualizar">
        <asp:TextBox runat="server" ID="txt_consecutivo" CssClass="textos" />
        <input class="textos" type="text" id="txt_nombre" runat="server" placeholder="Nombre Equipo" name="name" value="" />
        <input class="textos" type="text" id="txt_provincia" runat="server" placeholder="Provincia" name="name" value="" />
        <input class="textos" type="text" id="txt_canton" runat="server" placeholder="Canton" name="name" value="" />
        <input class="textos" type="text" id="txt_distrito" runat="server" placeholder="Distrito" name="name" value="" />
        <input class="textos" type="text" id="txt_fundacion" runat="server" placeholder="Fundacion" name="name" value="" />
       
        <br />  
        <asp:Button Text="Actualizar Equipo" CssClass="btn btn-primary" runat="server" ID="btn_actualizar" OnClick="btn_actualizar_Click"  />
        <br />  
        <br />  
        <asp:Label Text="" ID="txt_mensaje" runat="server" />
    </section>






</asp:Content>
