﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Director/M_director.master" AutoEventWireup="true" CodeBehind="AñadirParticipantes.aspx.cs" Inherits="CSWebApp.Director.AñadirParticipantes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="nombreT" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Apellidos"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="ApellidosT" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Rol"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem>Responsable</asp:ListItem>
        <asp:ListItem>Trabajador</asp:ListItem>
    </asp:DropDownList>
    <br />
    Contraseña:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="pass1T" runat="server"></asp:TextBox>
    <br />
    Repetir Contraseña:<asp:TextBox ID="pass2T" runat="server"></asp:TextBox>
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" Height="33px" Text="Añadir Participante" Width="158px" OnClick="Button1_Click" />
    <br />
</asp:Content>
