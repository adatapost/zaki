<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <p  id="para1" />
        <asp:TextBox ID="p1" runat="server"></asp:TextBox>
    
    </div>
        <asp:TextBox ID="TextBox1" runat="server" BackColor="#FF66CC" TextMode="Password"   style="visibility:hidden"></asp:TextBox>
        <asp:Calendar ID="Calendar1" runat="server" Visible="False"></asp:Calendar>
    </form>
</body>
</html>
