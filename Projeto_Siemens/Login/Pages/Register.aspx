<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Pages_Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style22 {
        width: 70%;
    }
    .auto-style26 {
        width: 111px;
    }
    .auto-style28 {
        width: 128px;
    }
    .auto-style30 {
        width: 163px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>

   </p>
    <table class="auto-style22">
        <tr>
            <td class="auto-style26">&nbsp;</td>
            <td class="auto-style28">&nbsp;</td>
            <td class="auto-style30">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style26">Utilizador:</td>
            <td class="auto-style28">
                <asp:TextBox ID="TextBoxUtilizador" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style30">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxUtilizador" ErrorMessage="Preenchimento Obrigatório"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style26">Email:</td>
            <td class="auto-style28">
                <asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style30">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxEmail" ErrorMessage="Preenchimento Obrigatório"></asp:RequiredFieldValidator>
            </td>
            <td>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBoxEmail" ErrorMessage="Não é um Email válido" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style26">Password:</td>
            <td class="auto-style28">
                <asp:TextBox ID="TextBoxPass" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td class="auto-style30">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBoxPass" ErrorMessage="Preenchimento Obrigatório"></asp:RequiredFieldValidator>
            </td>
            <td>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Não é uma Password Válida" ValidationExpression="((?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{6,20})" ControlToValidate="TextBoxPass"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style26">Repetir Password:</td>
            <td class="auto-style28">
                <asp:TextBox ID="TextBoxPassVer" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td class="auto-style30">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBoxPassVer" ErrorMessage="Preenchimento Obrigatório"></asp:RequiredFieldValidator>
            </td>
            <td>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBoxPass" ErrorMessage="As Password não são iguais" ControlToValidate="TextBoxPassVer"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style26">&nbsp;</td>
            <td class="auto-style28">&nbsp;</td>
            <td class="auto-style30">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="Button1" runat="server" Text="Submeter" OnClick="Button1_Click" />
                <asp:Button ID="Button2" runat="server" Text="Limpar" />
            </td>
            <td class="auto-style30">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
</table>
    <p>

    </p>
</asp:Content>

