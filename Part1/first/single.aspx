<%@ Page Language="C#" %>
<%@ Import Namespace="System.Text" %>

<!DOCTYPE html>

<script runat="server">
    public void page_load()
    {
        Response.Write("<br/>Load");
    }
    public void page_preinit()
    {
        Response.Write("<br/>PreInit");
    }
    public void page_init()
    {
        Response.Write("<br/>Init");
    }
    public void page_prerender()
    {
        Response.Write("<br/>PreRender");
    }
</script>
<%
    StringBuilder sb = new StringBuilder();
%>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <%
  //local variables and executable statements

  int no = 10;
  for(int i=1;i<=no;i++)
   {
     Response.Write("<br/>" + i);
    }
%>

<p>Value of no <%=no%>


<%=no%> is equivalent to 

<%
 Response.Write(no);
%>
    </div>
    </form>
</body>
</html>
