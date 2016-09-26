<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Registro.aspx.cs" Inherits="User_Registro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 130px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class="panel">
        <h2>Registro de Usuarios</h2>

        <table style="width: 100%;">
            <tr>
                <td class="auto-style1">Usuario</td>
                <td><asp:TextBox ID="txtUsuario" runat="server" Width="240px"></asp:TextBox> 
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Contraseña</td>
                <td><asp:TextBox ID="txtPass" runat="server" Width="240px" TextMode="Password"></asp:TextBox></td>
                
            </tr>
            <tr>
                <td class="auto-style1">Repita Contraseña</td>
                <td><asp:TextBox ID="txtPass2" runat="server" Width="240px" TextMode="Password"></asp:TextBox></td>
                
            </tr>
             <tr>
                <td class="auto-style1">E-Mail</td>
                <td><asp:TextBox ID="txtMail" runat="server" Width="240px" ></asp:TextBox></td>
                
            </tr>
             <tr>
                <td class="auto-style1">Repita E-Mail</td>
                <td><asp:TextBox ID="txtMail2" runat="server" Width="240px" ></asp:TextBox></td>
                
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td><asp:Button ID="btnRegistrar" runat="server" Text="Registrar" CssClass="button" OnClick="btnRegistrar_Click" /></td>
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
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Compruebe su contraseña" ControlToValidate="txtPass2" CssClass="msj-output"></asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Las contraseñas no coinciden" ControlToCompare="txtPass" ControlToValidate="txtPass2" CssClass="msj-output"></asp:CompareValidator>
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Ingrese su E-mail" ControlToValidate="txtMail" CssClass="msj-output"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Ingrese un E-Mail válido" ControlToValidate="txtMail" CssClass="msj-output" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Reingrese su E-mail" ControlToValidate="txtMail2" CssClass="msj-output"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Ingrese un E-Mail válido" ControlToValidate="txtMail2" CssClass="msj-output" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        <asp:CompareValidator ID="CompareValidator3" runat="server" ErrorMessage="Los E-mails  no coinciden" ControlToCompare="txtMail" ControlToValidate="txtMail2" CssClass="msj-output"></asp:CompareValidator>

    </div>
</asp:Content>

