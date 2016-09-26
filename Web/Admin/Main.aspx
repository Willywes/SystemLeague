<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Main.aspx.cs" Inherits="Admin_Main" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="gvUsers" runat="server" ViewStateMode="Enabled" AutoGenerateColumns="False" OnRowCommand="gvUsers_RowCommand">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
            <asp:BoundField DataField="Nickname" HeaderText="Nickname" SortExpression="Nickname" />
            <asp:BoundField DataField="Contrasena" HeaderText="Contraseña" SortExpression="Contrasena" />
            <asp:BoundField DataField="Mail" HeaderText="Mail" SortExpression="Mail" />
            <asp:BoundField DataField="FechaRegistro" HeaderText="Fecha Registro" SortExpression="FechaRegistro" />
            <asp:BoundField DataField="IdTeam" HeaderText="Team" SortExpression="IdTeam" />
            <asp:ButtonField ButtonType="Button" Text="Eliminar" CommandName="Eliminar" />
            <%--<asp:ButtonField ButtonType="Button" Text="Modificar" />--%>
        </Columns>

        

    </asp:GridView>

</asp:Content>

