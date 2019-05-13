<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Personal.aspx.cs" Inherits="Pages_Personal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<style type="text/css">
        .auto-style3 {
            text-decoration: none;
            float:right;
        }
        .auto-style4 {
            width: 100%;
        }
        .auto-style5 {
            width: 65px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<p>
        <asp:Label ID="Label1" runat="server" Text="Bem-vindo," Font-Bold="True" Font-Size="Large"></asp:Label>
        <asp:LinkButton ID="LinkButton1" runat="server" CssClass="auto-style3" ForeColor="#333333" OnClick="LinkButton1_Click">LogOut</asp:LinkButton>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server"></asp:Label>
    </p>
    <p>
        <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Ver Dados</asp:LinkButton>
    </p>
    <asp:Panel ID="Panel1" runat="server" BorderStyle="Solid" Visible="False">
        Os seus Dados<br /> &nbsp;<table class="auto-style4">
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label3" runat="server" Text="Nome:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Campo Obrigatório"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label4" runat="server" Text="Email:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Campo Obrigatório"></asp:RequiredFieldValidator>
                    &nbsp;
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="Não válido" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
        </table>
        &nbsp;&nbsp;
        <br />
        &nbsp;&nbsp;&nbsp;<asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click">Editar</asp:LinkButton>
&nbsp;&nbsp;<asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click">Atualizar</asp:LinkButton>
&nbsp;
        <asp:LinkButton ID="LinkButton5" runat="server" OnClick="LinkButton5_Click">Fechar</asp:LinkButton>
        <br />
    </asp:Panel>
</asp:Content>

