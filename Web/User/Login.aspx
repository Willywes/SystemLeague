<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="User_Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 130px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="panel">
        <h2>Acceso de Usuarios</h2>

        <table style="width: 100%;">
            <tr>
                <td class="auto-style1">Usuario</td>
                <td><asp:TextBox ID="txtUsuario" runat="server" Width="240px"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style1">Contraseña</td>
                <td><asp:TextBox ID="txtPass" runat="server" Width="240px" TextMode="Password"></asp:TextBox></td>
                
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td><asp:Button ID="btnLogin" runat="server" Text="Acceder" CssClass="button" OnClick="btnLogin_Click" /></td>
            </tr>
        </table>      
        <br />  
        <asp:Label ID="lblOuput" runat="server" Text=""></asp:Label>
    </div>
    <div class="validation">
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Ingrese un nombre de Usuario" ControlToValidate="txtUsuario" CssClass="msj-output"></asp:RequiredFieldValidator>
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Ingrese una contraseña" ControlToValidate="txtPass" CssClass="msj-output"></asp:RequiredFieldValidator>

    </div>
</asp:Content>

