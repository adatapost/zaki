﻿using System;
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

    public void page_init()
    {
        TextBox1.BackColor = System.Drawing.Color.Green;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        TextBox1.BackColor = System.Drawing.Color.Red;
    }
}