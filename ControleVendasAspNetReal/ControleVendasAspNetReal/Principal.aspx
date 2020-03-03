<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="ControleVendasAspNetReal.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        .tabela{
            position:absolute;
            float:right;
            padding:30px;      
            top:50px;
            right:50px;
            
        }
        .erro{
            position:absolute;
            top:40%;
            right:20%;
        }
        .btn{
            padding:10px;
            margin:5px;
            font-family:RomanC;
            color:#ffffff;
            background-color:#000000;
        }
        #form{
            padding:10px;
            margin:10px;
            font-family:sans-serif;
            font-size:20px;
        }
    </style>
</head>
<body>
    <form id="form" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="NOME"></asp:Label>
        </div>

        <asp:TextBox ID="nomeCP" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="QUANTIDADE"></asp:Label>
        </p>
        <asp:TextBox ID="quantCP" runat="server" ></asp:TextBox>
        <p>
            <asp:Label ID="Label3" runat="server" Text="VALOR"></asp:Label>
        </p>
        <asp:TextBox ID="valorCP" runat="server"></asp:TextBox>
        <asp:TextBox ID="erro2CP" runat="server" CssClass="erro"></asp:TextBox>
        <p>
            <asp:Button class="btn" ID="incluir_btn" runat="server" OnClick="incluir_btn_Click" Text="Incluir" />
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Código"></asp:Label>
        </p>
        <asp:TextBox ID="codCP" runat="server"></asp:TextBox>
        <p>
            <asp:Button class="btn" ID="pesquisar_btn" runat="server" OnClick="pesquisar_btn_Click" Text="Pesquisar" />
            <asp:Button class="btn" ID="alterar_btn" runat="server" OnClick="alterar_btn_Click" Text="Alterar" />
            <asp:Button class="btn" ID="excluir_btn" runat="server" OnClick="excluir_btn_Click" Text="Excluir" />
        </p>
    <div>
        
        </div>

    <div id="tabelavendas" class="tabela" runat="server"> 
     
        <asp:GridView ID="GridView1" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" Height="298px" Width="603px">
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
            <RowStyle BackColor="White" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
    </div>
            
    </form>

    </body>
</html>
