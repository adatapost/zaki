using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class hyper_Page2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["no"] != null)
            Label1.Text = Request.QueryString["no"];
        if (Request.QueryString["name"] != null)
            Label2.Text = Request.QueryString["name"];

    }
}