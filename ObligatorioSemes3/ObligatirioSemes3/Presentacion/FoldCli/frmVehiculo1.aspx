<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmVehiculo1.aspx.cs" Inherits="ObligatirioSemes3.Presentacion.FoldCli.frmVehiculo1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                  <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="lblMatricula" runat="server" Text="Matricula"></asp:Label>
        <asp:TextBox ID="txtMat" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblMarca" runat="server" Text="Marca"></asp:Label>
        <asp:TextBox ID="txtMar" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblModelo" runat="server" Text="Modelo"></asp:Label>
        <asp:TextBox ID="txtMdel" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblAnio" runat="server" Text="Anio"></asp:Label>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtAnio" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblColor" runat="server" Text="Color"></asp:Label>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtColor" runat="server"></asp:TextBox>
    </p>
        <p>
        <asp:Label ID="lbl" runat="server" Text="Cliente"></asp:Label>
    </p>
        <p>
        <asp:ListBox ID="lstCli" runat="server" Height="100px" Width="225px" OnInit="lstCli_Init"></asp:ListBox>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
    </p>
    <p/>
        <asp:Button ID="btnAltaCli" runat="server" OnClick="btnAlta_Click" Text="Alta" Height="24px" />
        <asp:Button ID="btnBajaCli" runat="server"  Text="Baja" Width="41px" OnClick="btnBajaCli_Click" />
        <asp:Button ID="btnModificarCli" runat="server"  Text="Modificar" OnClick="btnModificarCli_Click" />
        <asp:Button ID="btnLimpiar" runat="server"  Text="Limpiar" OnClick="btnLimpiar_Click" />
    <p>
        <asp:ListBox ID="lstVeh" runat="server" Height="160px" Width="309px" OnInit="lstVeh_Init"></asp:ListBox>
        <asp:Button ID="btnSelect" runat="server" OnClick="btnSelect_Click" Text="Selecionar" />
        <asp:Label ID="lblMensajes" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
