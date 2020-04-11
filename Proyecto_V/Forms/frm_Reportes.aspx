<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="frm_Reportes.aspx.cs" Inherits="Proyecto_V.Forms.frm_Reportes" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../Hoja%20Estilos/EstilosJugEquipos.css" rel="stylesheet" />
    <asp:ScriptManager ID="scmReporteClientes" runat="server"></asp:ScriptManager>
    <div class="jumbotron text-center">
        <h2>Reportes del por torneo</h2>
    </div>
    <div class="container">
        <p>Lista de reportes</p>
        <br />  
        <asp:DropDownList ID="dl_lista_reportes" runat="server"></asp:DropDownList>
        <br />
        <br />
        <asp:Button Text="Consultar" ID="btn_consultar" CssClass="btn btn-primary" runat="server" OnClick="btn_consultar_Click" />
        <br />
        <br />
        <br />
        <asp:Label Text="" ID="lbl_meensaje" runat="server" />
        <br />
        <br />

    </div>
    
    <div class="container">
        <rsweb:ReportViewer ID="rpv_reportes" runat="server" Width="100%" Height="800px">
       
        </rsweb:ReportViewer>
    </div>

</asp:Content>
