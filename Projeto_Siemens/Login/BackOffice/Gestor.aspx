<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Gestor.aspx.cs" Inherits="BackOffice_Gestor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style3 {
            text-decoration: none;
            float: right;
        }
        .auto-style4 {
            width: 42%;
        }
        .auto-style9 {
            width: 238px;
            height: 40px;
        }
        .auto-style10 {
            width: 909px;
            height: 40px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <asp:Label ID="Label1" runat="server" Text="Bem-Vindo,"></asp:Label>
        <asp:LinkButton ID="LinkButton1" runat="server" CssClass="auto-style3" OnClick="LinkButton1_Click">LogOut</asp:LinkButton>
    </p>
    <p>
        <br />
        <asp:Label ID="Label2" runat="server"></asp:Label>
    </p>
    <p>
        <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Ver Dados Pessoais</asp:LinkButton>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton6" runat="server" PostBackUrl="~/BackOffice/VerUtilizadores.aspx">Ver Todos Utilizadores</asp:LinkButton>
    </p>
    <asp:Panel ID="Panel1" runat="server" Visible="False">
        <table class="auto-style4">
            <tr>
                <td class="auto-style9">
                    <asp:Label ID="Label3" runat="server" Font-Size="Large" Text="Nome"></asp:Label>
                </td>
                <td class="auto-style10">
                    <asp:TextBox ID="TextBox1" runat="server" Height="25px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Campo Obrigatório" ForeColor="Maroon"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Label ID="Label4" runat="server" Font-Size="Large" Text="Email"></asp:Label>
                </td>
                <td class="auto-style10">
                    <asp:TextBox ID="TextBox2" runat="server" Height="25px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Campo Obrigatório" ForeColor="Maroon"></asp:RequiredFieldValidator>
                </td>
            </tr>
        </table>
        <br />
        <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click">Editar</asp:LinkButton>
        &nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click">Atualizar</asp:LinkButton>
        &nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton5" runat="server" OnClick="LinkButton5_Click">Fechar</asp:LinkButton>
        <br />
        <br />
        <br />
        <br />
    </asp:Panel>
</asp:Content>

