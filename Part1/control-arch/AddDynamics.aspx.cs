using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddDynamics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Button btn = new Button();
        btn.ID = "myButton";
        btn.Text = "OK";
        TextBox tx = new TextBox();
        tx.BackColor = System.Drawing.Color.Red;

        //add two controls into placeholder

        PlaceHolder1.Controls.Add(btn);
        PlaceHolder1.Controls.Add(tx);
    }
}