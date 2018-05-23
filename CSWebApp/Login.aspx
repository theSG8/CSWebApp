<%@ Page Title="" Language="C#" MasterPageFile="~/M_anonimo.master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CSWebApp.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="server">
    ID:
<asp:TextBox ID="t_email" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="t_email" Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="t_email" Display="Dynamic" ErrorMessage="Introduzca una ID válida" ForeColor="Red" ValidationExpression="\d+"></asp:RegularExpressionValidator>
<br />
Contraseña:
<asp:TextBox ID="t_pass" runat="server" TextMode="Password"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="t_pass" Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
<br />
<p>
    <asp:Button ID="Button1" runat="server" Height="48px"  Text="Loguearse" Width="264px" OnClick="Button1_Click" />
</p>
<p>
    <asp:Label ID="lerror" runat="server" Text=""></asp:Label>
</p>
</asp:Content>
