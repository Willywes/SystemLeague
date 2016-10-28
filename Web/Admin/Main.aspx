<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Main.aspx.cs" Inherits="Admin_Main" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SystemLeague">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
            <asp:BoundField DataField="Nickname" HeaderText="Nickname" SortExpression="Nickname" />
            <asp:BoundField DataField="Contrasena" HeaderText="Contrasena" SortExpression="Contrasena" />
            <asp:BoundField DataField="Mail" HeaderText="Mail" SortExpression="Mail" />
            <asp:BoundField DataField="F_reg" HeaderText="F_reg" SortExpression="F_reg" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SystemLeague" runat="server" ConnectionString="<%$ ConnectionStrings:SystemLeagueConnectionString %>" SelectCommand="SELECT * FROM [Player]"></asp:SqlDataSource>
</asp:Content>


