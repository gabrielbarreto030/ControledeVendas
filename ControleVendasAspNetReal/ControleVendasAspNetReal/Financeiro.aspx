<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Financeiro.aspx.cs" Inherits="ControleVendasAspNetReal.Financeiro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        .tabela{
            position:absolute;
            left:25%;

            
            
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
    <form id="form1" runat="server">
       
    
    <div id="tabelavendas" class="tabela" runat="server"> 
     
        <asp:GridView ID="GridView2" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" Height="298px" Width="603px">
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
