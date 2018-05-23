<%@ Page Title="" Language="C#" MasterPageFile="~/Director/M_director.master" AutoEventWireup="true" CodeBehind="VisualizarSolicitudes.aspx.cs" Inherits="CSWebApp.Director.VisualizarSolicitudes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="server">
    <div style="height: 281px">
        <div style="z-index: 1; left: 481px; top: 230px; position: absolute; height: 217px; width: 482px">
            <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CellPadding="4" ForeColor="Black" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellSpacing="2" Height="196px" Width="477px">
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                <RowStyle BackColor="White" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
        </div>
    </div>
</asp:Content>
