<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmAdmin.aspx.cs" Inherits="ObligatirioSemes3.Presentacion.frmAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p> 
        &nbsp;</p>
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
      <asp:TextBox ID="txtPass" runat="server"  TextMode="Password" ></asp:TextBox>
    </p>
    <p/>
           <asp:Button ID="btnAlta" runat="server" OnClick="btnAlta_Click" Text="Alta" Height="24px" />
           <asp:Button ID="btnBaja" runat="server" OnClick="btnBaja_Click" Text="Baja" Width="41px" />
           <asp:Button ID="btnModificar" runat="server" OnClick="btnModificar_Click" Text="Modificar" />
           <asp:Button ID="btnLimpiar" runat="server"  Text="Limpiar" OnClick="btnLimpiar_Click" />
    <p/>
           Iniciar Sesion<p/>
      <asp:TextBox ID="txtUserSA" runat="server"></asp:TextBox>
    <p/>
      <asp:TextBox ID="txtPassSA" runat="server"  TextMode="Password" ></asp:TextBox>
    <p/>
           <asp:Button ID="btnIniciarSesion" runat="server" Text="Inciar Sesion" OnClick="btnIniciarSesion_Click" />
           <p>

        <asp:ListBox ID="lstAdmin" runat="server" Height="160px" Width="309px" OnInit="lstAdmin_Init"></asp:ListBox>
           <asp:Button ID="btnSelect" runat="server" OnClick="btnSelect_Click" Text="Selecionar" />
           <asp:Label ID="lblMensajes" runat="server"></asp:Label>

     </p>



</asp:Content>
