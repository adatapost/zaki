<%@ Page Language="C#" Theme="Blue" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>The Appleman Pvt Ltd</h1>
        <hr />
        <asp:Button ID="Button1" runat="server" Text="Red" OnClick="Button1_Click" /><asp:Button ID="Button2" runat="server" Text="Blue" OnClick="Button2_Click" /><asp:LinkButton ID="LinkButton1" runat="server">LinkButton</asp:LinkButton><asp:LinkButton ID="LinkButton2" runat="server">LinkButton</asp:LinkButton><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>
