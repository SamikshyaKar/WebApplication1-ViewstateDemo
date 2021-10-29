<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication1_ViewstateDemo.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="Mytext2" runat="server" OnTextChanged="Mytext2_TextChanged"></asp:TextBox>
        <asp:Button ID="Click1" runat="server" OnClick="Click1_Click" Text="Click" />
        <div>
        </div>
    </form>
</body>
</html>
