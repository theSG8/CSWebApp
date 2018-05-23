<%@ Page Title="" Language="C#" MasterPageFile="~/Director/M_director.master" AutoEventWireup="true" CodeBehind="ModificarPaquetes.aspx.cs" Inherits="CSWebApp.Director.ModificarPaquetes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Nombre Paquete:"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 846px; top: 203px; position: absolute" Text="Nombre:"></asp:Label>
    <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 1007px; top: 199px; position: absolute"></asp:TextBox>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CS-18ConnectionString %>" SelectCommand="SELECT * FROM [Paquete]"></asp:SqlDataSource>
    <br />
    Estimación:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 845px; top: 234px; position: absolute" Text="Descripción:"></asp:Label>
<asp:TextBox ID="TextBox5" runat="server" style="z-index: 1; left: 1007px; top: 230px; position: absolute"></asp:TextBox>
    <br />
    Responsable:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 845px; top: 259px; position: absolute" Text="Horas Estimadas:"></asp:Label>
<asp:TextBox ID="TextBox6" runat="server" style="z-index: 1; left: 1005px; top: 257px; position: absolute"></asp:TextBox>
<asp:GridView ID="GridView2" runat="server" style="z-index: 1; left: 813px; top: 367px; position: absolute; height: 158px; width: 259px">
</asp:GridView>
    <br />
    <asp:Button ID="Button3" runat="server" Height="37px" OnClick="Button3_Click" Text="Añadir Paquete" style="z-index: 1; left: 10px; top: 323px; position: absolute" />
    <asp:Button ID="Button2" runat="server" Height="37px" OnClick="Button2_Click" Text="Ver Paquetes" Width="167px" style="z-index: 1; left: 181px; top: 322px; position: absolute" />
    <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 846px; top: 289px; position: absolute" Text="Fecha Limite:"></asp:Label>
<asp:TextBox ID="TextBox7" runat="server" style="z-index: 1; left: 1006px; top: 287px; position: absolute"></asp:TextBox>
    <br />
    <asp:Button ID="Button4" runat="server" Height="38px" OnClick="Button4_Click" style="z-index: 1; left: 838px; top: 320px; position: absolute" Text="Añadir Tarea" Width="171px" />
<asp:Button ID="Button5" runat="server" Height="37px" style="z-index: 1; left: 1016px; top: 319px; position: absolute" Text="Ver Tareas" Width="171px" />
    <br />
<br />
<asp:GridView ID="GridView1" runat="server" style="z-index: 1; left: 48px; top: 368px; position: absolute; height: 158px; width: 259px" DataSourceID="SqlDataSource1" Visible="False">
</asp:GridView>
</asp:Content>
