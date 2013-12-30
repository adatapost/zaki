<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Page1.aspx.cs" Inherits="Page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <table>
          <tr><td>No</td><td>
              <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
              </td></tr>
          <tr><td>Name</td><td>
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
