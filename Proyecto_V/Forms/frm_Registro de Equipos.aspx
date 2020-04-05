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
                <asp:Label Text="Nombre del Equipo" runat="server" />  
                <asp:RequiredFieldValidator ID="rq_Txt_NombreEquipo" runat="server" ErrorMessage="* Debe ingresar el nombre del equipo" ControlToValidate="TxtNombreEquipo" ForeColor="Red"></asp:RequiredFieldValidator>             
                <asp:RegularExpressionValidator ID="rgvTxtNombreEquipo" runat="server" ErrorMessage="El nombre del equipo solo puede llevar letras" ControlToValidate="TxtNombreEquipo" ForeColor="Red" ValidationExpression="[A-Za-z ]*"></asp:RegularExpressionValidator>
                <asp:TextBox runat="server" ID="TxtNombreEquipo" CssClass="form-control" />
            </div>

            <!---FECHA DE FUNDACION-->
            <div class="form-group">
                <asp:Label Text="Fundacion" runat="server" />
                <br />
                <asp:ImageButton ImageUrl="~/Imagenes/icons8_Calendar_48px_1.png" CausesValidation="false" runat="server" ID="btn_imagen_calendar" OnClick="btn_imagen_calendar_Click" />
                <asp:TextBox runat="server" ID="txt_fundacion" CssClass="form-control" />
            </div>

         <asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" OnSelectionChanged="Calendar1_SelectionChanged" ShowGridLines="True" Width="220px">
             <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
             <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
             <OtherMonthDayStyle ForeColor="#CC9966" />
             <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
             <SelectorStyle BackColor="#FFCC66" />
             <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
             <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
            </asp:Calendar>
            
             
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
           <asp:Button Text="Agregar Equipo" ID="btn_agregar" CssClass="btn btn-primary" runat="server" OnClick="btn_agregar_Click" Width="128px"/>
         
           <asp:Button Text="Eliminar Equipo" ID="btn_eliminar" CssClass="btn btn-primary" runat="server" OnClick="btn_agregar_Click" Width="137px" style="margin-left: 1px"/>
         
            <br />
            <br />
           <asp:Button Text="Actualizar Equipo" ID="btn_actualizar" CssClass="btn btn-primary" runat="server" OnClick="btn_actualizar_Click" Width="262px"/>
         
            <br />
            <br />
            <asp:Label Text="" ID="lbl_mensaje" runat="server" />
        </div>
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
