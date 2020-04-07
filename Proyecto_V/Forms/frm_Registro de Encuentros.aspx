<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="frm_Registro de Encuentros.aspx.cs" Inherits="Proyecto_V.Forms.frm_Registro_de_Encuentros" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <div class="jumbotron text-center">
        <h2>Registro de encuentros</h2>
    </div>

    <div class ="container" id="IdContenedor">
        <div class="row" id="IdRow">
            <div class="col-sm-4" id="IdContenido1"></div>
            <div class="col-sm-4" id="IdContenido2">
                   <h3>Lista de Torneos</h3>
                <asp:DropDownList ID="dl_lista_torneos" runat="server" AutoPostBack="True" DataTextField="C_NOMBRE_TORNEO" DataValueField="C_CONSECUTIVO"></asp:DropDownList>
            </div>
            <div class="col-sm-4" id="IdContenido3"></div>
        </div>
    </div>


</asp:Content>
