<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frm_Inicio.aspx.cs" Inherits="Proyecto_V.Froms.frm_Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label>
            <asp:Label ID="Label2" runat="server" Text="Contraseña"></asp:Label>
            <asp:TextBox ID="txt_usuario" runat="server"></asp:TextBox>
            <asp:TextBox ID="txt_contraseña" runat="server"></asp:TextBox>
            <asp:Button ID="btn_iniciar" runat="server" Text="Iniciar Sesión" OnClick="btn_iniciar_Click" />
        </div>
    </form>
</body>
</html>
