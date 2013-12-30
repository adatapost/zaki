using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class MyHelper
{
    public static string SetMasterPage
    {
        get
        {
            if (HttpContext.Current.Session["master"] == null)
                return "~/One.master";
            return HttpContext.Current.Session["master"].ToString();
        }
        set
        {
            
            HttpContext.Current.Session["master"] = value;
        }

    }
}