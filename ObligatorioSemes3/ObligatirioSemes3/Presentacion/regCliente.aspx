<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="regCliente.aspx.cs" Inherits="ObligatirioSemes3.Presentacion.regCliente" %>

<!DOCTYPE html>

<html lang="es">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title><%: Page.Title %> - Mi aplicación ASP.NET</title>

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
                        <li><a runat="server" href="~/">Inicio</a></li>
                    </ul>
                </div>
            </div>
        </div>
        <div class="container body-content">
     
            <hr />

            <p> 
     <asp:Label ID="Label1" runat="server" Text="Nombre "></asp:Label>
      <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
    </p>
       <p> 
     <asp:Label ID="Label3" runat="server" Text="Apellido "></asp:Label>
      <asp:TextBox ID="txtApe" runat="server"></asp:TextBox>
    </p>
       <p> 
     <asp:Label ID="Label4" runat="server" Text="Username "></asp:Label>
      <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
    </p>
       <p> 
     <asp:Label ID="Label5" runat="server" Text="Password "></asp:Label>
      <asp:TextBox ID="txtPass" runat="server" TextMode="Password" ></asp:TextBox>
    </p>
       <p> 
     <asp:Label ID="Label6" runat="server" Text="Ci"></asp:Label>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      <asp:TextBox ID="txtCi" runat="server"></asp:TextBox>
    </p>
       <p> 
     <asp:Label ID="Label7" runat="server" Text="Mail"></asp:Label>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      <asp:TextBox ID="txtMail" runat="server"></asp:TextBox>
    </p>
       <p> 
     <asp:Label ID="Label9" runat="server" Text="Direccion"></asp:Label>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
    </p>
        <p> 
     <asp:Label ID="Label10" runat="server" Text="Telefono"></asp:Label>
      <asp:TextBox ID="txtTel" runat="server"></asp:TextBox>
    </p>

    <p>
           <asp:Button ID="btnAltaCli" runat="server" OnClick="btnAlta_Click" Text="Registarse" Height="24px" />

     </p>
            <p>
           <asp:Label ID="lblMensajes" runat="server"></asp:Label>

     </p>


            <footer>
                <p>&copy; <%: DateTime.Now.Year %> - Mi aplicación ASP.NET</p>
            </footer>
        </div>

    </form>
</body>
</html>







