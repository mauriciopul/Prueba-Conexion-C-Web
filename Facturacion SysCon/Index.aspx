<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Facturacion_SysCon.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Facturacion SysCon</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
<div class="navbar-collapse collapse">
                    <ul class="nav navbar-nav">
                        <li><a runat="server" href="~/Fachada/Usuarios.aspx">Usuarios</a></li>
                        <li><a runat="server" href="~/Fachada/Clientes.aspx">Clientes</a></li>
                        <li><a runat="server" href="~/Fachada/Productos.aspx">Productos</a></li>
                    </ul>
                </div>
            <div>
                <asp:Label ID="Label1" runat="server" Text="Usuario:"></asp:Label>
                <asp:TextBox ID="txtUsuarioLogin" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label2" runat="server" Text="Clave:"></asp:Label>
                <asp:TextBox ID="txtClaveLogin" runat="server">*</asp:TextBox>
                <br />
                <asp:Button ID="btnAceptarLogin" runat="server" Text="Aceptar" />
                <br />
                <asp:Label ID="lblConexion" runat="server"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
