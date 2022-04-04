<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="lookupInv._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
<form id="myForm" action="/previewInv.aspx">
<div style="text-align:center;margin-top:5%">
        <h1 style="color:darkgreen" id="header1">Tra cứu hóa đơn điện tử - Hải Đăng</h1>
<p style="align:center">        
  Mã tra cứu: 
  </p>
  <input type="text" name="lname"><br><br>
  <input type="button" onclick="myFunction()" value="Tra cứu">

</form>

<script>
function myFunction() {
    document.getElementById("myForm").submit();
}
</script>
</body>
</html>
