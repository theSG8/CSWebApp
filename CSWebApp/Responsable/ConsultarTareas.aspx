<%@ Page Title="" Language="C#" MasterPageFile="~/Responsable/M_responsable.master" AutoEventWireup="true" CodeBehind="ConsultarTareas.aspx.cs" Inherits="CSWebApp.Responsable.ConsultarTareas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="server">

    <div style="display:flex ;flex-direction:row ;flex-wrap:wrap" >
        <div id="left">
            <h1>Asignar tareas</h1>

            <asp:GridView ID="GridView1" runat="server" DataSourceID="EntityDataSource1">
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" OnSelecting="SqlDataSource1_Selecting"></asp:SqlDataSource>
           
        </div>
        <div id="right">
            <h1>Finalizar tareas</h1>
         <asp:GridView ID="GridView2" runat="server">
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server"></asp:SqlDataSource>
           </div>


        </div>
        


</asp:Content>
