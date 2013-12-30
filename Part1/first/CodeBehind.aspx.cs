using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CodeBehind : System.Web.UI.Page
{
   
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
}