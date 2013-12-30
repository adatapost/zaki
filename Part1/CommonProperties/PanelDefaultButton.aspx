<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PanelDefaultButton.aspx.cs" Inherits="PanelDefaultButton" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server" DefaultButton="Button1">
            <br />
            No<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Name<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </asp:Panel>
    
    </div>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Panel ID="Panel2" runat="server" DefaultButton="Button2">
            Username<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            Password<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
        </asp:Panel>
        <br />
        <br />
    </form>
</body>
</html>
