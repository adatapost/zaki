<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Page1.aspx.cs" Inherits="hyper_Page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/hyper/Page2.aspx">Page2</asp:HyperLink>
    
    </div>
        <p>
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/hyper/Page2.aspx" Target="_blank">Page2</asp:HyperLink>
        </p>
        <p>
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/hyper/Page2.aspx?no=10&name=abc" Target="_blank">Page2</asp:HyperLink>
        </p>
    </form>
</body>
</html>
