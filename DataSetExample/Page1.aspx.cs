using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class Page1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("SrNo", typeof(int));
            dt.Columns["SrNo"].AutoIncrement = true;
            dt.Columns["SrNo"].AutoIncrementSeed = 100;
            dt.Columns["SrNo"].AutoIncrementStep = 3;
            dt.Columns.Add("Name");
            dt.Columns.Add("English",typeof(int));
            dt.Columns.Add("Maths", typeof(int));
            dt.Columns.Add("Science", typeof(int));
            dt.Columns.Add("Total", typeof(int), "English+Maths+Science");
            dt.Columns.Add("Percent", typeof(int), "Total/3");

            DataRow r = dt.NewRow();
            r["Name"] = "Z";
            r["English"] = 98;
            r["Maths"] = 56;
            r["Science"] = 67;

            dt.Rows.Add(r);

            r = dt.NewRow();
            r["Name"] = "A";
            r["English"] = 68;
            r["Maths"] = 96;
            r["Science"] = 87;

            dt.Rows.Add(r);

            GridView1.DataSource = dt;
            GridView1.DataBind();

        }
    }
}