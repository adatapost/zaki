<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AccessKeyEx.cs" Inherits="First" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" defaultfocus="TextBox2">
    <div>
    
        No<asp:TextBox ID="TextBox1" runat="server" AccessKey="n"></asp:TextBox>
        <br />
        Name<asp:TextBox ID="TextBox2" runat="server" AccessKey="m"></asp:TextBox>
        <br />
        Date<asp:TextBox ID="TextBox3" runat="server" AccessKey="d"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
