<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="ControleVendasAspNetReal.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        .erro{
            position:absolute;
            top:40%;
            right:20%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="nome"></asp:Label>
        </div>
        <asp:TextBox ID="nomeCP" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="quantidade"></asp:Label>
        </p>
        <asp:TextBox ID="quantCP" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Valor"></asp:Label>
        </p>
        <asp:TextBox ID="valorCP" runat="server"></asp:TextBox>
        <asp:TextBox ID="erro2CP" runat="server" CssClass="erro"></asp:TextBox>
        <p>
            <asp:Button ID="incluir_btn" runat="server" OnClick="incluir_btn_Click" Text="Incluir" />
        </p>
    </form>
</body>
</html>
