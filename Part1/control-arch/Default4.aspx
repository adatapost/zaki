<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default4.aspx.cs" Inherits="Default4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>

        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

    </p>
     <p>

         <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

    </p>
     <p>

    </p>
     <asp:Button ID="Button1" runat="server" Text="Button" />
     <p>

    </p>
    <script>
        var t1 = document.getElementById("<%=TextBox1.ClientID %>");
        t1.onkeyup = function (event) {
            console.log(event.which);
         };
        var i = 1;
        setInterval(function () {
            t1.value = i;
            i = i + 1;
        }, 1000);
    </script>
</asp:Content>

