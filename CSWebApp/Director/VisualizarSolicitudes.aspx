<%@ Page Title="" Language="C#" MasterPageFile="~/Director/M_director.master" AutoEventWireup="true" CodeBehind="VisualizarSolicitudes.aspx.cs" Inherits="CSWebApp.Director.VisualizarSolicitudes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="server">
    <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
    <Columns>
        <asp:ButtonField ButtonType="Button" CommandName="Cancel" Text="Ver Detalles" />
    </Columns>
    </asp:GridView>
</asp:Content>
