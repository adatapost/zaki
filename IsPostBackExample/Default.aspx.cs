﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack==false) // !IsPostBack
        {
            DropDownList1.Items.Add("Mehsana");
            DropDownList1.Items.Add("Surat");
        }
    }
}