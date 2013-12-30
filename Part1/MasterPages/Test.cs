using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    
    public void page_preinit()
    {
        MasterPageFile = MyHelper.SetMasterPage;
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        MyHelper.SetMasterPage = "~/One.master";
        Response.Redirect(Request.Url.ToString());
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        MyHelper.SetMasterPage = "~/Two.master";
        Response.Redirect(Request.Url.ToString());
    }
}