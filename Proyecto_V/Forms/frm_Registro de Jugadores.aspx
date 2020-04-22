<%@ Page Title="" Language="C#" MaintainScrollPositionOnPostback="true" MasterPageFile ="~/Principal.Master" AutoEventWireup="true" CodeBehind="frm_Registro de Jugadores.aspx.cs" Inherits="Proyecto_V.Forms.frm_Registro_de_Jugadores" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!---HOJA DE ESTILOS-->
    <link href="../Hoja%20Estilos/Estilos_Reg_Jugadores.css" rel="stylesheet" />
    <div>
        <h2>Registro de Jugadores</h2>
    </div>
    <!---CONTENEDOR PRINCIPAL-->
    <div id="contenedor_principal" class="container well container">
        <!---CONTENEDOR SECUNDARO-->
        <div id="contenedor" class="container well container">
            <!---CEDULA-->
            <div class="form-group">
                <div class="col">
                    <asp:Label Text="Cédula" runat="server" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="rq_txt_cedula" runat="server" ErrorMessage="* Debe indicar el número de Cédula" ControlToValidate="txt_cedula" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RegularExpressionValidator ID="rgvTxt_Cedula" runat="server" ErrorMessage="Debe ingresar la cédula en el formato (000000000)"  ControlToValidate="txt_cedula" ForeColor="Red" ValidationExpression="([0-9]|-)*" Display="Dynamic"></asp:RegularExpressionValidator>
                    <asp:TextBox runat="server" ID="txt_cedula" CssClass="form-control" MaxLength="9"/>
                </div>
            </div>
            <!---NOMBRE-->
            <div class="form-group">
                <asp:Label Text="Nombre" runat="server" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RequiredFieldValidator ID="rq_txt_nombre" runat="server" ErrorMessage="* Debe ingresar el nombre" ControlToValidate="txt_nombre" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RegularExpressionValidator ID="rgvTxtNombre" runat="server" ErrorMessage="El nombre solo puede llevar letras" ControlToValidate="txt_nombre" ForeColor="Red" ValidationExpression="[A-Za-z ]*"></asp:RegularExpressionValidator>
                <asp:TextBox runat="server" ID="txt_nombre" CssClass="form-control" MaxLength="60" />
            </div>
            <!---APELLIDO 1-->
            <div class="form-group">
                <asp:Label Text="Apellido 1" runat="server" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RequiredFieldValidator ID="rq_txt_apellido1" runat="server" ErrorMessage="* Debe ingresar el Apellido 1" ControlToValidate="txt_apellido1" ForeColor="Red"></asp:RequiredFieldValidator>
                                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RegularExpressionValidator ID="rgvTxt_Apellido1" runat="server" ErrorMessage="El apellido solo debe llevar letras" ControlToValidate="txt_apellido1" ForeColor="Red" ValidationExpression="[A-Za-z ]*"></asp:RegularExpressionValidator>
                <asp:TextBox runat="server" ID="txt_apellido1" CssClass="form-control" MaxLength="60" />
            </div>
            <!---APELLIDO2-->
            <div class="form-group">
                <asp:Label Text="Apellido 2" runat="server" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RequiredFieldValidator ID="rq_txt_apellido2" runat="server" ErrorMessage="* Debe ingresar el Apellido 2" ControlToValidate="txt_apellido2" ForeColor="Red"></asp:RequiredFieldValidator>
                               <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="El apellido debe llevar solo letras" ControlToValidate="txt_apellido2" ValidationExpression="[A-Za-z ]*"></asp:RegularExpressionValidator>
                <asp:TextBox runat="server" ID="txt_apellido2" CssClass="form-control" MaxLength="60" />
            </div>
            <div class="form-group">
                <asp:Label Text="Fecha Nacimiento" runat="server" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <asp:ImageButton ImageUrl="~/Imagenes/icons8_Calendar_48px_1.png" CausesValidation="false" runat="server" ID="btn_imagen_calendar" OnClick="btn_imagen_calendar_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox runat="server" ID="txt_fecha_nacimiento" CssClass="form-control" />
            </div>
            <!---FECHA DE NACIMIENTO-->

            <asp:Calendar ID="dt_fechas" runat="server" BackColor="White" BorderColor="#999999" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="237px" OnSelectionChanged="dt_fechas_SelectionChanged" CellPadding="4">
                <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                <NextPrevStyle VerticalAlign="Bottom" />
                <OtherMonthDayStyle ForeColor="#808080" />
                <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                <SelectorStyle BackColor="#CCCCCC" />
                <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                <WeekendDayStyle BackColor="#FFFFCC" />
            </asp:Calendar>
            <br />
              <!---GENERO-->
            <asp:Label Text="Genero" runat="server" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <div class="custom-control custom-radio custom-control-inline">
                <input runat="server" type="radio" id="rb_masculino" name="genero" class="custom-control-input">
                <label class="custom-control-label" for="customRadioInline1">Masculino</label>
            </div>
            <div class="custom-control custom-radio custom-control-inline">
                <input runat="server" type="radio" id="rb_femenino" name="genero" class="custom-control-input">
                <label class="custom-control-label" for="rb_femenino">Femenino</label>
            </div>
            <br />
              <!---TELEFONO-->
              <div class="form-group">
                <asp:Label Text="Teléfono" runat="server" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RequiredFieldValidator ID="rq_txt_telefono" runat="server" ErrorMessage="* Debe ingresar un número teléfono" ControlToValidate="txt_telefono" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:TextBox runat="server" ID="txt_telefono" CssClass="form-control" MaxLength="12" />
            </div>
            <!---CORREO-->
              <div class="form-group">
                  <asp:Label Text="Correo" runat="server" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RequiredFieldValidator ID="rq_txt_correo" runat="server" ErrorMessage="* Debe ingresar un correo eléctronico" ControlToValidate="txt_correo" ForeColor="Red"></asp:RequiredFieldValidator>
                  <br />
                  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                  <asp:RegularExpressionValidator ID="rgvTxt_Correo" runat="server" ErrorMessage="Debe ingresar un correo valido" ControlToValidate="txt_correo" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                <asp:TextBox runat="server" ID="txt_correo" CssClass="form-control" MaxLength="30" />
              </div>
            <!---PROVINCIA,CANTON,DISTRITO-->
            <div class="form-group">
                <asp:Label Text="Provincia" runat="server" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="dl_lista_provincia" runat="server" CssClass="form-control" DataTextField="nombre" DataValueField="id_Provincia" AutoPostBack="True" OnSelectedIndexChanged="dl_lista_provincia_SelectedIndexChanged"></asp:DropDownList>
            </div>
            <div class="form-group">
                <asp:Label Text="Cantón" runat="server" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="dl_lista_cantones" runat="server" CssClass="form-control" AutoPostBack="True" DataTextField="nombre" DataValueField="id_Canton" OnSelectedIndexChanged="dl_lista_cantones_SelectedIndexChanged"></asp:DropDownList>
            </div>
            <div class="form-group">
                <asp:Label Text="Distrito" runat="server" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="dl_lista_distritos" runat="server" CssClass="form-control" DataTextField="nombre" DataValueField="id_Distrito"></asp:DropDownList>
            </div>
            <!---DIRECCION-->
              <div class="form-group">
                  <asp:Label Text="Dirección" runat="server" />&nbsp;
                    
                <asp:RequiredFieldValidator ID="rqtxt_direccion" runat="server" ErrorMessage="* Debe ingresar la dirección de la vivienda" ControlToValidate="txt_direccion" ForeColor="Red"></asp:RequiredFieldValidator>
                  <textarea id="txt_direccion" class="form-control" runat="server" MaxLength="500" ></textarea>
              </div>
             <script src="../Scripts/WebForms/Validacion_Jugadores.js"></script>
            <!---BOTON-->
            <asp:Button Text="Agregar Jugador" ID="btn_agregar" CssClass="btn btn-primary" runat="server" OnClick="btn_agregar_Click" />
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
