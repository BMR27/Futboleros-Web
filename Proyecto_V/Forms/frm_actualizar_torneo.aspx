<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="frm_actualizar_torneo.aspx.cs" Inherits="Proyecto_V.Forms.frm_actualizar_torneo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <link href="../Hoja%20Estilos/EstilosActualizarEquipos.css" rel="stylesheet" />
    <div class="jumbotron text-center">
        <h2>Actualizar datos del Torneo</h2>
    </div>

    <div class="container" id="IdContenedor">
        <div class="row" id="IdRow">
            <div class="col-sm-4">
            </div>
            <div class="col-sm-4">
                <asp:Label ID="Label1" runat="server" Text="Id Torneo"></asp:Label>
                <br />
                <asp:TextBox ID="txt_consecutivo" runat="server" CssClass="form-control"></asp:TextBox>
                <br />
                <asp:Label ID="Label2" runat="server" Text="Nombre del Torneo"></asp:Label>
                <br />
                <asp:TextBox ID="txt_nombre_torneo" runat="server" CssClass="form-control"></asp:TextBox>
                <br />
                <asp:Label ID="Label3" runat="server" Text="Fecha Inicio"></asp:Label>
                <br />
                <asp:TextBox ID="txt_fecha_Inicio" runat="server" CssClass="form-control"></asp:TextBox>
                <br />
                <asp:Label ID="Label4" runat="server" Text="Fecha Final"></asp:Label>
                <br />
                <asp:TextBox ID="txt_fecha_Final" runat="server" CssClass="form-control"></asp:TextBox>
                <br />
                <asp:Label ID="Label5" runat="server" Text="Cantidad de Equipos"></asp:Label>
                <br />
                <asp:TextBox ID="txtCantidad_Equipos" runat="server" CssClass="form-control"></asp:TextBox>
                <br />
                <br />
                <asp:Button Text="Actualizar Torneo" CssClass="btn btn-primary" runat="server" ID="btn_actualizar" OnClick="btn_actualizar_Click" />
                <br />
                <br />
                <asp:Label Text="" ID="txt_mensaje" runat="server" />
            </div>

        </div>
    </div>

</asp:Content>


