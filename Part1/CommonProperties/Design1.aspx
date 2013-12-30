<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Design1.aspx.cs" Inherits="Design1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Styles/style.css" />
</head>
<body>
    <form id="form1" runat="server">
     <section class="main">
         <header>

         </header>
         <nav>
             Welcome
             <a href="#">Home</a>
             <a href="#">About us</a>
             <asp:LinkButton ID="LinkButton2" runat="server">LinkButton</asp:LinkButton>
             <asp:LinkButton ID="LinkButton3" runat="server">LinkButton</asp:LinkButton>
             <asp:LinkButton ID="LinkButton4" runat="server">LinkButton</asp:LinkButton>
         </nav>
         <article>
             <h1>First</h1>
             <p>Sample para1</p>
             <p>
                 The <code>Java</code> is the general purpose
                 programming language where as <code>JavaScript</code>
                 is client side scrippting language.


             </p>
              <h1>First</h1>
             <p>Sample para1<asp:Button ID="Button1" runat="server" Text="Button" />
                 <asp:Button ID="Button2" runat="server" Text="Button" />
                 <asp:Button ID="Button3" runat="server" Text="Button" />
                 <asp:Button ID="Button4" runat="server" Text="Button" />
                 <asp:LinkButton ID="LinkButton1" runat="server">LinkButton</asp:LinkButton>
             </p>
              <h1>First</h1>
             <p>Sample para1</p>
              <h1>First</h1>
             <p>Sample para1</p>
              <p>Sample para1</p>
              <p>Sample para1</p>
         </article>
         <footer>
             &copy; Abc Ltd - 2013
         </footer>
     </section>
    </form>
</body>
</html>
