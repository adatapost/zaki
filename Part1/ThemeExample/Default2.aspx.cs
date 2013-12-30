using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    public void page_preinit()
    {
        string theme = "Blue";
       if (Session["theme"] != null)
            theme = Session["theme"].ToString();

        Theme = theme;
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["theme"] = "Red";
        Response.Redirect(Request.Url.ToString());
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Session["theme"] = "Blue";
        Response.Redirect(Request.Url.ToString());
    }
}