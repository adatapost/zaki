<%@ Page  Language="C#"     AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="<%$ Resources:Site, title %>"></asp:Label>
    
    </div>
        <asp:Label ID="Label2" runat="server" Text="<%$ Resources:Site, company %>"></asp:Label>
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Gujarati" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Brit" />
    </form>
</body>
</html>
