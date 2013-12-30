<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Page1.aspx.cs" Inherits="Page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 300px;
        }
        .auto-style2 {
            height: 33px;
        }
        .auto-style3 {
            width: 400px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
            <asp:View ID="View2" runat="server">
                <table class="auto-style1">
                    <tr>
                        <td>No</td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Name</td>
                        <td>
                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>
                            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Next" />
                        </td>
                    </tr>
                </table>
            </asp:View>
            <asp:View ID="View3" runat="server">
                <table class="auto-style1">
                    <tr>
                        <td>Address</td>
                        <td>
                            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">City</td>
                        <td class="auto-style2">
                            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>
                            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Prev" />
                            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Next" />
                        </td>
                    </tr>
                </table>
            </asp:View>
            <asp:View ID="View1" runat="server">
                <table class="auto-style3">
                    <tr>
                        <td>No</td>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Name</td>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Address</td>
                        <td>
                            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>City</td>
                        <td>
                            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>
                            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Save It" />
                        </td>
                    </tr>
                </table>

            </asp:View>
            <asp:View ID="View4" runat="server">Are you sure to save?
                <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Yes" />
                <asp:Button ID="Button6" runat="server" Text="No" />
            </asp:View>
            <asp:View ID="View5" runat="server">
                Thank you

            </asp:View>
        </asp:MultiView>
    
    </div>
    </form>
</body>
</html>
