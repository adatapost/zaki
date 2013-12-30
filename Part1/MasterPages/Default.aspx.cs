using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    string masterPage = "~/One.master";
    public void page_preinit()
    {
        if (Session["master"] != null)
            masterPage = Session["master"].ToString();

        MasterPageFile = masterPage;
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["master"] = "~/One.master";
        Response.Redirect(Request.Url.ToString());
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Session["master"] = "~/Two.master";
        Response.Redirect(Request.Url.ToString());
    }
}