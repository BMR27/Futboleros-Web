  <%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="frm_Registro_Torneos.aspx.cs" Inherits="Proyecto_V.Forms.frm_Registro_Torneos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!---HOJA DE ESTILOS-->
    <link href="../Hoja%20Estilos/Estilos_Reg_Jugadores.css" rel="stylesheet" />
    <div>
        <h2>Registro de Torneos</h2>
    </div>
    <!---CONTENEDOR PRINCIPAL-->
    <div id="contenedor_principal" class="container well container">
        <!---CONTENEDOR SECUNDARO-->
        <div id="contenedor" class="container well container">
            
            <!---NOMBRE DEL TORNEO-->
            <div class="form-group">
                <asp:Label Text="Nombre del Torneo" runat="server" />  
                <asp:RequiredFieldValidator ID="rq_Txt_NombreTorneo" runat="server" ErrorMessage="* Debe ingresar el nombre del torneo" ControlToValidate="TxtNombreTorneo" ForeColor="Red"></asp:RequiredFieldValidator>             
                <asp:RegularExpressionValidator ID="rgvTxtNombreTorneo" runat="server" ErrorMessage="El nombre del torneo solo puede llevar letras" ControlToValidate="TxtNombreTorneo" ForeColor="Red" ValidationExpression="[A-Za-z ]*"></asp:RegularExpressionValidator>
                <asp:TextBox runat="server" ID="TxtNombreTorneo" CssClass="form-control" />
            </div>

            <!---USUARIO-->
            <div class="form-group">
                <asp:Label Text="Usuario" runat="server" />  
                <asp:RequiredFieldValidator ID="rq_Txt_Usuario" runat="server" ErrorMessage="* Debe ingresar su usuario" ControlToValidate="txtUsuario" ForeColor="Red"></asp:RequiredFieldValidator>             
                <asp:RegularExpressionValidator ID="rgvtxtUsuario" runat="server" ErrorMessage="El usuario solo puede llevar letras" ControlToValidate="txtUsuario" ForeColor="Red" ValidationExpression="[A-Za-z ]*"></asp:RegularExpressionValidator>
                <asp:TextBox runat="server" ID="txtUsuario" CssClass="form-control" />
            </div>

            <!---FECHA DE INICIO DEL TORNEO-->
            <div class="form-group">
                <asp:Label Text="Fecha de Inicio" runat="server" />
                <br />
                <asp:ImageButton ImageUrl="~/Imagenes/icons8_Calendar_48px_1.png" CausesValidation="false" runat="server" ID="btn_imagen_calendar" OnClick="btn_imagen_calendar_Click" />
                <asp:TextBox runat="server" ID="txt_fecha_Inicio" CssClass="form-control" />
            </div>

         <asp:Calendar ID="dt_Fecha_Inicio" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" OnSelectionChanged="dt_Fecha_Inicio_SelectionChanged" ShowGridLines="True" Width="220px">
             <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
             <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
             <OtherMonthDayStyle ForeColor="#CC9966" />
             <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
             <SelectorStyle BackColor="#FFCC66" />
             <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
             <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
            </asp:Calendar>

             <br />
            <!---FECHA FINAL DEL TORNEO-->
            <div class="form-group">
                <asp:Label Text="Fecha de Finalizacion" runat="server" />
                <br />
                <asp:ImageButton ImageUrl="~/Imagenes/icons8_Calendar_48px_1.png" CausesValidation="false" runat="server" ID="btn_imagen_calendar1" OnClick="btn_imagen_calendar1_Click" />
                <asp:TextBox runat="server" ID="txt_fecha_Final" CssClass="form-control" />
            </div>

         <asp:Calendar ID="dt_Fecha_Final" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" OnSelectionChanged="dt_Fecha_Final_SelectionChanged" ShowGridLines="True" Width="220px">
             <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
             <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
             <OtherMonthDayStyle ForeColor="#CC9966" />
             <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
             <SelectorStyle BackColor="#FFCC66" />
             <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
             <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
            </asp:Calendar>
            <br />
            <!---CANIDAD DE EQUIPOS-->
              <div class="form-group">
                <div class="col">
                    <asp:Label Text="Cantidad de Equipos" runat="server" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="rq_Txt_Cantidad_Equipos" runat="server" ErrorMessage="Debe ingresar la cantidad de equipos" ControlToValidate="txt_Cantidad_Equipos" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RegularExpressionValidator ID="rgvTxt_Cantidad_Equipos" runat="server" ErrorMessage="Debe ingresar la cantidad de equipos" ControlToValidate="txt_Cantidad_Equipos" ForeColor="Red" ValidationExpression="([0-3]|-)*"></asp:RegularExpressionValidator>
                    <asp:TextBox runat="server" ID="txt_Cantidad_Equipos" CssClass="form-control" MaxLength="9" />
                </div>
            </div>

            <!---ESTADO DEL TORNEO-->
             <asp:Label Text="Estado del Torneo" runat="server" />
            <div class="custom-control custom-radio custom-control-inline">
                <input runat="server" type="radio" id="rb_activo" name="estado" class="custom-control-input">
                <label class="custom-control-label" for="customRadioInline1">Activo</label>
            </div>
            <div class="custom-control custom-radio custom-control-inline">
                <input runat="server" type="radio" id="rb_inactivo" name="estado" class="custom-control-input">
                <label class="custom-control-label" for="rb_femenino">Inactivo</label>
            </div>
            
           <!---BOTON-->
            <asp:Button Text="Agregar Torneo" ID="btn_agregar_Torneo" CssClass="btn btn-primary" runat="server" OnClick="btn_agregar_Torneo_Click" />
            <br />
            <br />
            <asp:Label Text="" ID="lbl_mensaje" runat="server" />
        </div>
    </div>
    
</asp:Content>
