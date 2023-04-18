<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdicionarCadastro.aspx.cs" Inherits="WebForms_Projeto.AdicionarCadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:Label ID="lbl_Id" runat="server" Text="ID:"></asp:Label>
            <asp:TextBox ID="txt_Id" runat="server" Height="16px"></asp:TextBox>
        </p>
        <asp:Label ID="lbl_Nome" runat="server" Text="Nome"></asp:Label>
        <asp:TextBox ID="txt_Nome" runat="server" Height="16px"></asp:TextBox>
        <p>
            <asp:Label ID="lbl_Ddd" runat="server" Text="DDD:"></asp:Label>
            <asp:TextBox ID="txt_Ddd" runat="server" Height="16px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lbl_Tel" runat="server" Text="Telefone:"></asp:Label>
            <asp:TextBox ID="txt_Tel" runat="server" Height="16px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lbl_TipoTel" runat="server" Text="Tipo Tel"></asp:Label>
        <asp:DropDownList ID="DropDownList1_TipoTel" runat="server">
            <asp:ListItem>Movel</asp:ListItem>
            <asp:ListItem>Fixo</asp:ListItem>
            <asp:ListItem>Comercial</asp:ListItem>
            <asp:ListItem>Recado</asp:ListItem>
        </asp:DropDownList>
        </p>
        <p>
        <asp:Button ID="btn_Apagar" runat="server" Text="Apagar" OnClick="btn_Apagar_Click" Width="77px" />
        <asp:Button ID="btn_Adicionar" runat="server" Text="Adicionar" OnClick="btn_Adicionar_Click" />
            <asp:Button ID="btn_Alterar" runat="server" OnClick="btn_Alterar_Click" Text="Alterar" Width="64px" />
        </p>
        <asp:Label ID="lblMsgErro" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
