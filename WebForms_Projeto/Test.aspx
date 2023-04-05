<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="WebForms_Projeto.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width:100%;">
            <tr>
                <td>Site</td>
                <td>Endereço</td>
                <td>Opções</td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtSite" runat="server" style="margin-bottom: 0px"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="txtEndereco" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnInserir" runat="server" OnClick="btnInserir_Click" Text="Inserir" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:DropDownList ID="dlSite" runat="server">
                        <asp:ListItem>Fundamental I</asp:ListItem>
                        <asp:ListItem>Fundamental II</asp:ListItem>
                        <asp:ListItem>Ensino Medio</asp:ListItem>
                        <asp:ListItem>Superior</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:ListBox ID="ListBox1" runat="server" Width="204px"></asp:ListBox>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <p>
            &nbsp;</p>
        <asp:SqlDataSource ID="OracleBD" runat="server"></asp:SqlDataSource>
        <asp:GridView ID="gvOracle" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        </asp:GridView>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnCarregar" runat="server" Height="31px" OnClick="btnCarregar_Click" Text="Carregar Informações BD" Width="156px" />
        </p>
    </form>
</body>
</html>
