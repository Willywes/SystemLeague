<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Inicio.aspx.cs" Inherits="Inicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div class="top-login">
        <h1 style="float: left; line-height: 22px; margin-top: 5px;">Bienvenido a la Liga de League of Legends</h1>
        <asp:Panel ID="pnlUser" runat="server">
            <asp:Label ID="lblUser" runat="server" Text=""></asp:Label>
            &nbsp;<asp:Button ID="btnPerfil" runat="server" Text="Mi Perfil" OnClick="btnPerfil_Click" />
            &nbsp;<asp:Button ID="btnCerrarSesion" runat="server" Text="Desconectar" OnClick="btnCerrarSesion_Click" />
        </asp:Panel>
        <asp:Panel ID="pnlLogin" runat="server">
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
            &nbsp
                        <asp:Button ID="btnRegistrar" runat="server" Text="Registrate" OnClick="btnRegistrar_Click" />
        </asp:Panel>
    </div>
    <br />
    <hr />
    <div style="text-align: center;">

        <div class="panel-none">
            <img src="img/d-league.png" width="1050" /></div>

    </div>
</asp:Content>

