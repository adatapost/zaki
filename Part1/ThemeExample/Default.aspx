<%@ Page Language="C#" StylesheetTheme="Red" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Sample Page</h1>
    
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
    
        <asp:Button ID="Button3" runat="server" SkinID="softButton" Text="Button" />
        <asp:Button ID="Button2" runat="server" Text="Button" />
    
    </div>
        <asp:LinkButton ID="LinkButton1" runat="server">LinkButton</asp:LinkButton>
        <asp:LinkButton ID="LinkButton2" runat="server">LinkButton</asp:LinkButton>
        <asp:LinkButton ID="LinkButton3" runat="server">LinkButton</asp:LinkButton>
        <asp:LinkButton ID="LinkButton4" runat="server">LinkButton</asp:LinkButton>
    </form>
</body>
</html>
