<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Button ID="btnTest" runat="server" Text="Button" OnClick="btnTest_Click" />

    <script>
        var b = document.getElementById("<%=btnTest.ClientID %>");
        console.log(b);
        b.value = "Hi";
    </script>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
</asp:Content>

