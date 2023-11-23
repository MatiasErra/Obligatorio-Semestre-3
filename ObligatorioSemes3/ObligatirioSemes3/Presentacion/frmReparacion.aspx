<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmReparacion.aspx.cs" Inherits="ObligatirioSemes3.Presentacion.frmReparacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        Fecha Entrada<asp:TextBox ID="txtFechaEntrada" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label5" runat="server" Text="Fecha Salida"></asp:Label>
        <asp:TextBox ID="txtFechaSalida" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label6" runat="server" Text="Descripcion"></asp:Label>
        <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label8" runat="server" Text="Mecanico"></asp:Label>
        &nbsp;</p>
    <p>
      
        <asp:ListBox ID="lstMec" runat="server" Height="100px" Width="225px" OnInit="lstMec_Init" ></asp:ListBox>
      
    </p>
    <p>
      
        <asp:Label ID="Label9" runat="server" Text="Horas"></asp:Label>
        &nbsp;<asp:TextBox ID="txtHoras" runat="server"></asp:TextBox>
      
    </p>
    <p>
      
        Vehiculo</p>
    <p>
      
        <asp:ListBox ID="lstVeh" runat="server" Height="100px" Width="225px" OnInit="lstVeh_Init" ></asp:ListBox>
      
    </p>
    <p>
      
        Repuesto&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        Repuesto por añadir&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Cantidad&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </p>
    <p>
        <asp:ListBox ID="lstRepuesto" runat="server" Height="100px" Width="225px" OnInit="lstRepuesto_Init" ></asp:ListBox>
        &nbsp;<asp:Button ID="btnBajaRep" runat="server"    Text="&lt;---" Height="24px" OnClick="btnBajaRep_Click" />
        &nbsp; <asp:TextBox ID="txtCant" runat="server" placeHolder ="Cantidad "></asp:TextBox>
        &nbsp;
        <asp:Button ID="btnAltaRep" runat="server"  Text="---&gt;" Height="24px" OnClick="btnAltaRep_Click" />
        &nbsp;
        <asp:ListBox ID="lstRepuestoAdd" runat="server" Height="100px" Width="225px" OnInit="lstRepuestoAdd_Init" ></asp:ListBox>
        <asp:ListBox ID="lstCantidad" runat="server" Height="100px" Width="225px"  ></asp:ListBox>
        

        </p>
    <p>
        Repuestos de la Reparacion</p>
    <p>
        <asp:ListBox ID="lstReparacion_Rep" runat="server" Height="100px" Width="225px" ></asp:ListBox>
        <asp:Button ID="btnAltaRep_Rep" runat="server" Text="Alta" Height="24px" OnClick="btnAltaRep_Rep_Click" />
        &nbsp;<asp:Button ID="btnBajaRep_Rep" runat="server"  Text="Baja" Width="41px" OnClick="btnBajaRep_Rep_Click"  />
        

        </p>
    <p>
        Fecha Agendada <asp:TextBox ID="txtFechaReservada" runat="server"></asp:TextBox>
        </p>
    <p>
        Lista de Reparaciones</p>
    <p>
        Agendado&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; En Reparacion&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Reparado</p>
    <p>
        <asp:ListBox ID="lstReparAgendado" runat="server" Height="100px" Width="396px" OnInit="lstRepar_Init" ></asp:ListBox>
        
        <asp:ListBox ID="lstReparReparacion" runat="server" Height="100px" Width="402px" OnInit="lstRepar_Init"  ></asp:ListBox>

        <asp:ListBox ID="lstRepar" runat="server" Height="100px" Width="596px" OnInit="lstRepar_Init" ></asp:ListBox>

    </p>
    <p>

        <asp:Label ID="lblMensajes" runat="server"></asp:Label>

    </p>
    <p/>
        <asp:Button ID="btnAlta" runat="server" OnClick="btnAlta_Click" Text="Alta" Height="24px" />
        <asp:Button ID="btnBaja" runat="server"  Text="Baja" Width="41px" OnClick="btnBaja_Click" />
        <asp:Button ID="btnModificar" runat="server"  Text="Modificar" OnClick="btnModificar_Click" />
        <asp:Button ID="btnLimpiar" runat="server"  Text="Limpiar" OnClick="btnLimpiar_Click" />
        <asp:Button ID="btnSelect" runat="server"  Text="Selecionar" OnClick="btnSelect_Click" />
        

</asp:Content>
