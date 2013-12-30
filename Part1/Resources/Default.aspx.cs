using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    string cult = "en-US";
    protected override void InitializeCulture()
    {
        if (Session["cult"] != null)
            cult = Session["cult"].ToString();

        base.InitializeCulture();
        Culture = cult;
        UICulture = cult;
    }
    protected void Page_Load(object sender, EventArgs e)
    {
      
        Label3.Text = Resources.Site.success;
        
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["cult"] = "gu-IN";
        Response.Redirect(Request.Url.ToString());
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Session["cult"] = "en-GB";
        Response.Redirect(Request.Url.ToString());
    }
}