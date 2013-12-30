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
        Student s1 = Session["s1"] as Student;
        if (s1 != null)
        {
            Label1.Text = s1.Roll;
            Label2.Text = s1.Name;
            Label3.Text = s1.Address;
            Label4.Text = s1.City;
        }
    }
}