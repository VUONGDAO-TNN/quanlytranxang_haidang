<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="TraHoaDon.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="myForm" action="/XemHD.aspx">
        <div style="text-align:center;margin-top:5%">
        <h1 style="color:darkgreen" id="header1">Tra cứu hóa đơn điện tử - Hải Đăng</h1>
        <input style="text-align:center" type ="text" id="txtFkey" placeholder="Nhập mã tra cứu" runat="server"/>
        <!--<asp:Button runat="server" id="btnTraCuu" Text="Tra cứu" OnClick="btnTraCuu_Click" />-->
        <input type="button" onclick="myFunction()" value="Submit form">
        <div id="viewError" runat="server" />
    </div>
    </form>
    <script>
    function myFunction() {
        document.getElementById("myForm").submit();
    }
</script>
</body>
</html>
