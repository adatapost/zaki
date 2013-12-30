using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Page3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (Session["no"] != null) Label1.Text = Session["no"].ToString();
        if (Session["name"] != null) Label2.Text = Session["name"].ToString();
        if (Session["address"] != null) Label3.Text = Session["address"].ToString();
        if (Session["city"] != null) Label4.Text = Session["city"].ToString();
    }
}