<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddUserControl.aspx.cs" Inherits="AddUserControl" %>

<%@ Register src="Heading.ascx" tagname="Heading" tagprefix="uc1" %>
<%@ Register src="myLogin.ascx" tagname="myLogin" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:Heading ID="Heading1" runat="server" />
    <uc2:myLogin ID="myLogin1" runat="server" />
    <uc1:Heading ID="Heading2" runat="server" />
</asp:Content>

