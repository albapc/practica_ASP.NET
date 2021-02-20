<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View.aspx.cs" Inherits="ASP_Prueba.View" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
    <tbody>
        <tr>
            <th colspan="2">User Info</th>
        </tr>
        <tr>
            <td>Nombre:</td>
            <td><asp:Label ID="Nombre" runat="server" /></td>
        </tr>
        <tr>
            <td>Usuario:</td>
            <td><asp:Label ID="Usuario" runat="server" /></td>
        </tr>
    </tbody>
</table>

<table>
    <tbody>
        <tr>
            <th colspan="2">Datos de contacto</th>
        </tr>
        <tr>
            <td>Email:</td>
            <td><asp:Label ID="Email" runat="server" /></td>
        </tr>
        <tr>
            <td>Dirección:</td>
            <td><asp:Label ID="Direccion" runat="server" /></td>
        </tr>
        <tr>
            <td>Ciudad:</td>
            <td><asp:Label ID="Ciudad" runat="server" /></td>
        </tr>
    </tbody>
</table>

        </div>
    </form>
</body>
</html>
