<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="TraHoaDon.test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <div id="test1" runat="server"/> 
        
        <asp:Button ID="Button2" runat="server" Text="Button2" />
    </form>
    </body>
</html>
