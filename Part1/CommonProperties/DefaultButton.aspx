<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DefaultButton.aspx.cs" Inherits="DefaultButton" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" defaultbutton="Button2">
    <div>
    
        No<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        Name<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Button" />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
