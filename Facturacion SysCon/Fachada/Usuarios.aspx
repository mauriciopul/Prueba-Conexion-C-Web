<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="Facturacion_SysCon.Fachada.Usuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Usuarios</title>
    <style type="text/css">
        .egt {
            height: 127px;
            width: 304px;
        }
    </style>
</head>
<body style="height: 231px">
    <form id="form1" runat="server">
        <div>
            <li><a runat="server" href="~/Index.aspx">Inicio</a></li>
        </div>
        <div>

            <table class="egt">
                <tr>
                    <td>
                        <asp:Label ID="lblCodUsu" runat="server" Text="Codigo Usuario: "></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtcodUsu" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblNomUsu" runat="server" Text="Nombre: "></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtNomUsu" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblClaveUsu" runat="server" Text="Clave: "></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtClaveUsu" runat="server"></asp:TextBox></td>
                </tr>
            </table>
            <asp:Button ID="btnEnviarDatosUsu" runat="server" Text="Insertar" OnClick="btnEnviarDatosUsu_Click" />
        </div>
    </form>
</body>
</html>
