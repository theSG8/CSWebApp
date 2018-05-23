<%@ Page Title="" Language="C#" MasterPageFile="~/Responsable/M_responsable.master" AutoEventWireup="true" CodeBehind="ConsultarTareas.aspx.cs" Inherits="CSWebApp.Responsable.ConsultarTareas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="server">

    <div style="display:flex ;flex-direction:row ;flex-wrap:wrap" >
        <div id="left">
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" OnSelecting="SqlDataSource1_Selecting"></asp:SqlDataSource>
            <asp:GridView ID="GridView2" runat="server">
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server"></asp:SqlDataSource>
        </div>
        <div id="right">b</div>
    </div>


</asp:Content>
