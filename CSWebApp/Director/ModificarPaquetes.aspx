<%@ Page Title="" Language="C#" MasterPageFile="~/Director/M_director.master" AutoEventWireup="true" CodeBehind="ModificarPaquetes.aspx.cs" Inherits="CSWebApp.Director.ModificarPaquetes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Nombre Paquete:"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 617px; top: 203px; position: absolute" Text="Label"></asp:Label>
    <br />
    Estimación:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br />
    Responsable:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="Button3" runat="server" Height="39px" OnClick="Button3_Click" Text="Añadir Paquete" />
    <asp:Button ID="Button2" runat="server" Height="39px" OnClick="Button2_Click" Text="Ver Paquetes" Width="194px" />
    <br />
    <br />
<asp:GridView ID="GridView1" runat="server" Visible="False">
</asp:GridView>
<br />
</asp:Content>
