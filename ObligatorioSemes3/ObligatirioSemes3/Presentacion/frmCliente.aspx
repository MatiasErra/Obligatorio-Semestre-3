<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmCliente.aspx.cs" Inherits="ObligatirioSemes3.Presentacion.abmCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


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
     <asp:Label ID="Label8" runat="server" Text="FechaRegistro"></asp:Label>
      <asp:TextBox ID="txtFecha" runat="server"></asp:TextBox>
            <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
                <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                <OtherMonthDayStyle ForeColor="#999999" />
                <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                <TodayDayStyle BackColor="#CCCCCC" />
            </asp:Calendar>
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
         <asp:ListBox ID="lstCliente" runat="server" Height="160px" Width="309px" OnInit="lstCliente_Init"></asp:ListBox>
        </p>

    <p>
           <asp:Button ID="btnAlta" runat="server" OnClick="btnAlta_Click" Text="Alta" Height="24px" />
         <asp:Button ID="btnBaja" runat="server"  Text="Baja" Height="24px" OnClick="btnBaja_Click" />
         <asp:Button ID="btnMod" runat="server"  Text="Modficar" Height="24px" OnClick="btnMod_Click" />
       
           <asp:Button ID="btnSelectCli" runat="server" OnClick="btnSelect_Click" Text="Selecionar" />
           <asp:Label ID="lblMensajes" runat="server"></asp:Label>

     </p>
</asp:Content>
