<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Page1.aspx.cs" Inherits="CrossPagePostBack_Page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        No<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        Name<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" PostBackUrl="~/CrossPagePostBack/Page2.aspx" Text="Button" />
        <br />
    
    </div>
    </form>
</body>
</html>
