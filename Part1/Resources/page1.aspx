<%@ Page Language="C#" AutoEventWireup="true" CodeFile="page1.aspx.cs" Inherits="page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server" Text="<%$ Resources:Site, title %>"  BackColor="<%$ Resources:Site, back %>"></asp:TextBox>
        <input type="text" placeholder="Enter name" />
    </div>
        <asp:TextBox ID="TextBox2"
            placeholder="Email"
            
            
             runat="server"></asp:TextBox>
    </form>
</body>
</html>
