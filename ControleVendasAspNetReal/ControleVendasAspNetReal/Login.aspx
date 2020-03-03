<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ControleVendasAspNetReal.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        .label{
            font-size:22px;
            font-weight:bold;
            padding:10px;
            font-family:sans-serif;
        }
        .login{
            box-shadow: 0px 0px 10px black;
            margin:auto;
            background-color:white;
            text-align:center;
            height:150vh;
            width:90%;
        }
        .campo{
            font-size:18px;
            background-color:gray;
            margin-top: 0px;
        }
        .erro{
            position:absolute;
            top:40%;
            right:20%;
        }
        #login_btn{
            padding:10px;
            margin:20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="login">
            <asp:Label ID="loginLB" CssClass="label" runat="server" Text="Login"></asp:Label>
           
        <p>
           
        <asp:TextBox class="campo" ID="loginCP" runat="server" OnTextChanged="loginCP_TextChanged" ></asp:TextBox>
        </p>
            <asp:Label ID="senhaLB" runat="server" CssClass="label" Text="Senha"></asp:Label>
        <p>
        <asp:TextBox ID="senhaCP" class="campo" runat="server" ></asp:TextBox>
        
        </p>
            
        <p>
            <asp:Button ID="login_btn" runat="server" OnClick="Button1_Click" Text="Logar" />
        </p>
            </div>
        <div class="erro">
        <asp:TextBox ID="erroCP" class="campoerro" runat ="server"></asp:TextBox>
            </div>
    </form>

</body>
</html>
