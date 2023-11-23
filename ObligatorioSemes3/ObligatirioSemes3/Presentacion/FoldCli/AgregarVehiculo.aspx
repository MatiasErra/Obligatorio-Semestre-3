<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarVehiculo.aspx.cs" Inherits="ObligatirioSemes3.Presentacion.FoldCli.frmVehiculo1" %>

<!DOCTYPE html>

<html lang="es">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title><%: Page.Title %>- Mi aplicación ASP.NET</title>

    <asp:PlaceHolder runat="server">
        <%: Scripts.Render("~/bundles/modernizr") %>
    </asp:PlaceHolder>

    <webopt:bundlereference runat="server" path="~/Content/css" />
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />

</head>
<body>
    <form  id="form1"  runat="server">
        <asp:ScriptManager runat="server">
            <Scripts>
                <%--To learn more about bundling scripts in ScriptManager see https://go.microsoft.com/fwlink/?LinkID=301884 --%>
                <%--Framework Scripts--%>
                <asp:ScriptReference Name="MsAjaxBundle" />
                <asp:ScriptReference Name="jquery" />
                <asp:ScriptReference Name="bootstrap" />
                <asp:ScriptReference Name="WebForms.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebForms.js" />
                <asp:ScriptReference Name="WebUIValidation.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebUIValidation.js" />
                <asp:ScriptReference Name="MenuStandards.js" Assembly="System.Web" Path="~/Scripts/WebForms/MenuStandards.js" />
                <asp:ScriptReference Name="GridView.js" Assembly="System.Web" Path="~/Scripts/WebForms/GridView.js" />
                <asp:ScriptReference Name="DetailsView.js" Assembly="System.Web" Path="~/Scripts/WebForms/DetailsView.js" />
                <asp:ScriptReference Name="TreeView.js" Assembly="System.Web" Path="~/Scripts/WebForms/TreeView.js" />
                <asp:ScriptReference Name="WebParts.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebParts.js" />
                <asp:ScriptReference Name="Focus.js" Assembly="System.Web" Path="~/Scripts/WebForms/Focus.js" />
                <asp:ScriptReference Name="WebFormsBundle" />
                <%--Site Scripts--%>
            </Scripts>
        </asp:ScriptManager>

        <div class="navbar navbar-inverse navbar-fixed-top">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" runat="server" href="~/">Nombre de la aplicación</a>
                </div>
                <div class="navbar-collapse collapse">
                    <ul class="nav navbar-nav">
                        <li><a runat="server" href="~/Presentacion/FoldCli/HomeCli">Inicio</a></li>
                    </ul>
                </div>
            </div>
        </div>
        <div class="container body-content">
     
            <hr />



     <div>
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
            &nbsp;</p>
        <p>
            &nbsp;</p>
    <p/>
        <asp:Button ID="btnAltaCli" runat="server" OnClick="btnAlta_Click" Text="Alta" Height="24px" />
    
    <p>
       
        <asp:Label ID="lblMensajes" runat="server"></asp:Label>
        <p />
        
             <footer>
                <p>&copy; <%--To learn more about bundling scripts in ScriptManager see https://go.microsoft.com/fwlink/?LinkID=301884 --%>- Mi aplicación ASP.NET</p>
            </footer>
        </div>

    </form>
</body>
</html>