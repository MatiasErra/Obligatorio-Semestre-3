<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmMecanico.aspx.cs" Inherits="ObligatirioSemes3.Presentacion.frmMecanico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>

    </p>
      <p>
        <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
        <asp:TextBox ID="txtNom" runat="server"></asp:TextBox>
    </p>


       <p>
           <asp:Label ID="Label1" runat="server" Text="Apellido"></asp:Label>
        <asp:TextBox ID="txtApe" runat="server"></asp:TextBox>
    </p>
    
    <p>
        <asp:Label ID="lblCiMec" runat="server" Text="Ci"></asp:Label>
        <asp:TextBox ID="txtCI" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblTel" runat="server" Text="Telefono"></asp:Label>
        <asp:TextBox ID="txtTel" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblFechaIngreso" runat="server" Text="Fecha Ingreso"></asp:Label>
        <asp:TextBox ID="txtFechaIng" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblValorHora" runat="server" Text="Valor hora"></asp:Label>
        <asp:TextBox ID="txtValorHora" runat="server"></asp:TextBox>
    </p>
    <p/>
     
           <asp:Button ID="btnAltaMec" runat="server" OnClick="btnAlta_Click" Text="Alta" Height="24px" />
           <asp:Button ID="btnBajaMec" runat="server" OnClick="btnBaja_Click" Text="Baja" Width="41px" />
           <asp:Button ID="btnModificarMec" runat="server" OnClick="btnModificar_Click" Text="Modificar" />
    <p>
        <asp:ListBox ID="lstMecanico" runat="server" Height="160px" Width="309px" OnInit="lstMecanico_Init"></asp:ListBox>
        <asp:Button ID="btnSelectMec" runat="server" OnClick="btnSelect_Click" Text="Selecionar" />
        <asp:Label ID="lblMensajes" runat="server"></asp:Label>
    </p>
</asp:Content>
