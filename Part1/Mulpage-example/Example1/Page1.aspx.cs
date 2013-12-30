using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Page1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Student s1 = new Student()
        {
             Roll = TextBox1.Text,
             Name = TextBox2.Text
        };
        Session["s1"] = s1;
        Response.Redirect("Page2.aspx");
    }
}