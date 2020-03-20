<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="frm_actualizar_equipo.aspx.cs" Inherits="Proyecto_V.Forms.frm_actualizar_equipo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   
    <link href="../Hoja%20Estilos/EstilosActualizarEquipos.css" rel="stylesheet" />
    <div class="jumbotron text-center">
        <h2>Actualizar datos del Equipo</h2>
    </div>

    <div class="container" id="IdContenedor">
        <div class="row" id="IdRow">
            <div class="col-sm-4">
            </div>
            <div class="col-sm-4">
                <asp:Label ID="Label1" runat="server" Text="Id Equipo"></asp:Label>
                <br />
                <asp:TextBox ID="txt_consecutivo" runat="server" CssClass="form-control"></asp:TextBox>
                <br />
                <asp:Label ID="Label2" runat="server" Text="Nombre Equipo"></asp:Label>
                <br />
                <asp:TextBox ID="txt_nombre" runat="server" CssClass="form-control"></asp:TextBox>
                <br />
                <asp:Label ID="Label3" runat="server" Text="Provincia"></asp:Label>
                <br />
                <asp:TextBox ID="txt_provincia" runat="server" CssClass="form-control"></asp:TextBox>
                <br />
                <asp:Label ID="Label4" runat="server" Text="Canton"></asp:Label>
                <br />
                <asp:TextBox ID="txt_canton" runat="server" CssClass="form-control"></asp:TextBox>
                <br />
                <asp:Label ID="Label5" runat="server" Text="Distrito"></asp:Label>
                <br />
                <asp:TextBox ID="txt_distrito" runat="server" CssClass="form-control"></asp:TextBox>

                <br />
                <asp:Label ID="Label6" runat="server" Text="Fundacion"></asp:Label>
                <br />
                <asp:TextBox ID="txt_fundacion" runat="server" CssClass="form-control"></asp:TextBox>
                <br />
                <br />
                <asp:Button Text="Actualizar Equipo" CssClass="btn btn-primary" runat="server" ID="btn_actualizar" OnClick="btn_actualizar_Click" />
                <br />
                <br />
                <asp:Label Text="" ID="txt_mensaje" runat="server" />
            </div>
            <div class="col-sm-4" id="col3">
                <h4>Seleccione una opción en caso de querer cambiar la región</h4>
                <br />
                <br />
                <p>Cambio de Provincia</p>
                <asp:DropDownList ID="dl_provincia" runat="server" AutoPostBack="True" DataTextField="nombre" DataValueField="id_provincia" OnSelectedIndexChanged="dl_provincia_SelectedIndexChanged" OnTextChanged="dl_provincia_TextChanged"></asp:DropDownList>
                <br />
                <br />
                <p>Cambio de Canton</p>
                <asp:DropDownList ID="dl_canton" runat="server" AutoPostBack="True" DataTextField="nombre" DataValueField="id_Canton" OnSelectedIndexChanged="dl_canton_SelectedIndexChanged"></asp:DropDownList>
                <br />
                <br />
                <p>Cambio de Distrito</p>
                <asp:DropDownList ID="dl_distrito" runat="server" AutoPostBack="True" DataTextField="nombre" DataValueField="id_Distrito" OnSelectedIndexChanged="dl_distrito_SelectedIndexChanged"></asp:DropDownList>
            </div>
        </div>
    </div>




</asp:Content>
