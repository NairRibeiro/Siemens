<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Pages_Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style3 {
            width: 70%;
        }
        .auto-style5 {
            width: 79px;
        }
        .auto-style7 {
            width: 128px;
        }
        .auto-style8 {
            width: 79px;
            height: 23px;
        }
        .auto-style9 {
            width: 128px;
            height: 23px;
        }
        .auto-style10 {
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
       <h1>Login</h1>
    </p>
    <table class="auto-style3">
        <tr>
            <td class="auto-style5">
                <asp:Label ID="LabelUtilizador" runat="server"  Text="Utilizador:"></asp:Label>
            </td>
            <td class="auto-style7">
                <asp:TextBox ID="TextBoxUser" Placeholder="Insira UserName" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxUser" ErrorMessage="Preenchimento Obrigatório"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="LabelPass" runat="server" Text="Password:"></asp:Label>
            </td>
            <td class="auto-style7">
                <asp:TextBox ID="TextBoxPass" Placeholder="Insira Password" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxPass" ErrorMessage="Preenchimento Obrigatório"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style8"></td>
            <td class="auto-style9"></td>
            <td class="auto-style10"></td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Button ID="Button1" runat="server" Text="Entrar" OnClick="Button1_Click" />
            </td>
            <td class="auto-style7">
                <asp:Button ID="Button2" runat="server" Text="Limpar" OnClick="Button2_Click" CausesValidation="False" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <p>
       
    </p>
</asp:Content>

