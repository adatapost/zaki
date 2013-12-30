<%@ Page Language="C#" Trace="true" AutoEventWireup="true" CodeFile="Page1.aspx.cs" Inherits="Page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server" EnableViewState="False"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Height="205px" OnClick="Button1_Click" Text="Change BK" Width="310px" />
        <asp:Button ID="Button2" runat="server" Text="Button" />
    
    </div>
        <asp:Calendar ID="Calendar1" runat="server" ForeColor="#FF6699"></asp:Calendar>
        <asp:CheckBox ID="CheckBox1" runat="server" />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
        </asp:CheckBoxList>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Value="22">11</asp:ListItem>
            <asp:ListItem Value="33"></asp:ListItem>
            <asp:ListItem Value="44"></asp:ListItem>
        </asp:DropDownList>
    </form>
</body>
</html>
