using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CrossPagePostBack_Page2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request["TextBox1"] != null)
            Label1.Text = Request["TextBox1"];
        if (Request["TextBox2"] != null)
            Label2.Text = Request["TextBox2"];

    }
}