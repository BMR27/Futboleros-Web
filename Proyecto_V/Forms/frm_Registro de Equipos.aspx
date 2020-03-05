<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="frm_Registro de Equipos.aspx.cs" Inherits="Proyecto_V.Forms.frm_Registro_de_Equipos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
       <!---HOJA DE ESTILOS-->
    <link href="../Hoja%20Estilos/Estilos_Reg_Jugadores.css" rel="stylesheet" />
    <div>
        <h2>Registro de Equipos</h2>
    </div>
    <!---CONTENEDOR PRINCIPAL-->
    <div id="contenedor_principal" class="container well container">
        <!---CONTENEDOR SECUNDARO-->
        <div id="contenedor" class="container well container">
            
            <!---NOMBRE DEL EQUIPO-->
            <div class="form-group">
                <asp:Label Text="Nombre del Equipo" runat="server" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RequiredFieldValidator ID="rq_Txt_NombreEquipo" runat="server" ErrorMessage="* Debe ingresar el nombre del equipo" ControlToValidate="txt_NombreEquipo" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RegularExpressionValidator ID="rgvTxtNombreEquipo" runat="server" ErrorMessage="El nombre del equipo solo puede llevar letras" ControlToValidate="TxtNombreEquipo" ForeColor="Red" ValidationExpression="[A-Za-z ]*"></asp:RegularExpressionValidator>
                <asp:TextBox runat="server" ID="TxtNombreEquipo" CssClass="form-control" />
            </div>
            <!---FECHA DE FUNDACION-->
            <div class="form-group">
                <asp:Label Text="Fecha de Fundacion" runat="server" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RequiredFieldValidator ID="rq_Txt_FechaFundacion" runat="server" ErrorMessage="* Debe ingresar la fecha de fundacion del equipo" ControlToValidate="Txt_FechaFundacion" ForeColor="Red"></asp:RequiredFieldValidator>
                                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RegularExpressionValidator ID="rgvTxt_FechaFundacion" runat="server" ErrorMessage="La Fecha de fundacion solo debe llevar numeros" ControlToValidate="Txt_FechaFundacion" ForeColor="Red" ValidationExpression="[0-9]*"></asp:RegularExpressionValidator>
                <asp:TextBox runat="server" ID="Txt_FechaFundacion" CssClass="form-control" />
            </div>
            
             
            <!---PROVINCIA,CANTON,DISTRITO-->
            <div class="form-group">
                <asp:Label Text="Provincia" runat="server" />
                <asp:DropDownList ID="dl_lista_provincia" runat="server" CssClass="form-control" DataTextField="nombre" DataValueField="id_Provincia" AutoPostBack="True" OnSelectedIndexChanged="dl_lista_provincia_SelectedIndexChanged"></asp:DropDownList>
            </div>
            <div class="form-group">
                <asp:Label Text="Cantón" runat="server" />
                <asp:DropDownList ID="dl_lista_cantones" runat="server" CssClass="form-control" AutoPostBack="True" DataTextField="nombre" DataValueField="id_Canton" OnSelectedIndexChanged="dl_lista_cantones_SelectedIndexChanged"></asp:DropDownList>
            </div>
            <div class="form-group">
                <asp:Label Text="Distrito" runat="server" />
                <asp:DropDownList ID="dl_lista_distritos" runat="server" CssClass="form-control" DataTextField="nombre" DataValueField="id_Canton"></asp:DropDownList>
            </div>
            
            <!---BOTON-->
            <asp:Button Text="Agregar Equipo" ID="btn_agregar" CssClass="btn btn-primary" runat="server" OnClick="btn_agregar_Click" />
        </div>
    </div>
    

</asp:Content>
