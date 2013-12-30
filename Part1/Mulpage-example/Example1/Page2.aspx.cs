using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Page2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Student s1 = Session["s1"] as Student;

       s1.Address = TextBox1.Text;
        s1.City = TextBox2.Text;
        Response.Redirect("Page3.aspx");
    }
}