<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Page2.aspx.cs" Inherits="Page2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
      <table>
          <tr><td>Address</td><td>
              <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
              </td></tr>
          <tr><td>City</td><td>
              <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
              </td></tr>
          <tr>  <td colspan="2">
              <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Next" />
              </td></tr>
      </table>
    
    </div>
    </form>
</body>
</html>
