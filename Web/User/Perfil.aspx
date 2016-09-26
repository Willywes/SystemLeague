<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Perfil.aspx.cs" Inherits="User_Perfil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="pnlPerfil" runat="server">
        <div class="panel">
        <h2>Mi Perfil</h2>

        <table style="width: 100%;">
            <tr>
                <td class="auto-style1">Fecha Registro : </td>
                <td><asp:Label ID="lblFecharegistro" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td class="auto-style1">Nick Usuario : </td>
                <td><asp:Label ID="lblUsuario" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td class="auto-style1">E-Mail : </td>
                <td><asp:Label ID="lblMail" runat="server" Text=""></asp:Label></td>
            </tr>
            
            <tr>
                <td class="auto-style1"></td>
                <td><asp:Button ID="btnModificar" runat="server" Text="Modificar" CssClass="button" OnClick="btnModificar_Click" />
                </td>
            </tr>
        </table>   
    </div>

    </asp:Panel>
    <asp:Panel ID="pnlModificable" runat="server" Visible="False">

        <div class="panel">
        <h2>Modifica tus Datos</h2>

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
                <td><asp:Button ID="btnGuardar" runat="server" Text="Guardar Cambios" CssClass="button" OnClick="btnGuardar_Click" />&nbsp;&nbsp;<a class="button" href="/User/Perfil.aspx">Cancelar</a></td>
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

    </asp:Panel>
</asp:Content>

