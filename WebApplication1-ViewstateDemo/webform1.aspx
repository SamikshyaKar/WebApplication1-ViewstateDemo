<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="webform1.aspx.cs" Inherits="WebApplication1_ViewstateDemo.webform1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="Mytext1" runat="server" Width="190px"></asp:TextBox>
        <asp:Button ID="ClickMe1" runat="server" OnClick="Button1_Click" Text="ClickMe" />
        <div>
        </div>
    </form>
</body>
</html>
