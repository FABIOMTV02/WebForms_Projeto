<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="WebForms_Projeto.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            &nbsp;
        </p>
        <asp:GridView ID="gvOracle" runat="server"></asp:GridView>
        <asp:Label ID="lblErroMsg" runat="server" Text=""></asp:Label>
        <p>
            <asp:Button ID="btnInserir" runat="server" OnClick="btnInserir_Click" Text="Inserir" />
        </p>
    </form>
</body>
</html>
