<%@ Page Title="" Language="C#" MasterPageFile="~/One.master" AutoEventWireup="true" CodeFile="Test.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="One" />
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Two" />
</asp:Content>

