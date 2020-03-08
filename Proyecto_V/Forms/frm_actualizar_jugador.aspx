<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="frm_actualizar_jugador.aspx.cs" Inherits="Proyecto_V.Forms.frm_actualizar_jugador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <link href="../Hoja%20Estilos/Estilos_Actualizar_jugador.css" rel="stylesheet" />
    <h2>Actualzar datos del Jugador</h2>
    <section class="frm_actualizar">
        <input class="textos" type="text" id="txt_nombre" runat="server" placeholder="Nombre Jugador" name="name" value="" />
        <input class="textos" type="text" id="txt_apellido1" runat="server" placeholder="Apellido 1" name="name" value="" />
        <input class="textos" type="text" id="txt_apellido2" runat="server" placeholder="Apellido 2" name="name" value="" />
        <input class="textos" type="text" id="txt_telefono" runat="server" placeholder="Número Télefono" name="name" value="" />
        <input class="textos" type="text" id="txt_correo" runat="server" placeholder="Email" name="name" value="" />
        <input class="textos" type="text" id="txt_direccion" runat="server" placeholder="Dirección de casa" name="name" value="" />
    </section>
</asp:Content>
