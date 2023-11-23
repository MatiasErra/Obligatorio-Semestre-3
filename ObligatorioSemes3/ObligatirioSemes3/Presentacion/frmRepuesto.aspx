<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="frmRepuesto.aspx.cs" Inherits="ObligatirioSemes3.Presentacion.frmRepuesto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <p> 
            &nbsp;</p>
     <p>
         
          <p> 
     <asp:Label ID="Label4" runat="server" Text="Nombre"></asp:Label>
      <asp:TextBox ID="txtNom" runat="server"></asp:TextBox>
 <p> 
     <asp:Label ID="Label1" runat="server" Text="Descripcion"></asp:Label>
      <asp:TextBox ID="txtDesc" runat="server"></asp:TextBox>
    </p>

       <p> 
     <asp:Label ID="Label3" runat="server" Text="Costo"></asp:Label>
      <asp:TextBox ID="txtCosto" runat="server"></asp:TextBox>
    </p>
       <p> 
     <asp:Label runat="server" Text="Tipo"></asp:Label>
      <asp:TextBox ID="txtTipo" runat="server"></asp:TextBox>
    </p>
        <p> 
     <asp:Label runat="server" Text="Stock" ID="Label5"></asp:Label>
      <asp:TextBox ID="txtStock" runat="server"></asp:TextBox>
    </p>
     
           <asp:Button ID="btnAlta" runat="server" OnClick="btnAlta_Click" Text="Alta" Height="24px" />
           <asp:Button ID="btnBaja" runat="server" OnClick="btnBaja_Click" Text="Baja" Width="41px" />
           <asp:Button ID="btnModificar" runat="server" OnClick="btnModificar_Click" Text="Modificar" />
    <p>

        <asp:ListBox ID="lstRepues" runat="server" Height="160px" Width="309px" OnInit="lstRep_Init"></asp:ListBox>
           <asp:Button ID="btnSelect" runat="server" OnClick="btnSelect_Click" Text="Selecionar" />
           <asp:Label ID="lblMensajes" runat="server"></asp:Label>

     </p>
</asp:Content>

