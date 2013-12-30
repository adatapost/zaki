using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Emp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    string CnStr = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\csnet\Zaki\SqlProviderExample\App_Data\EmpDb.mdf;Integrated Security=True";

    protected void Button1_Click(object sender, EventArgs e)
    {
        using (SqlConnection cn = new SqlConnection())
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cn.ConnectionString = CnStr;
                cmd.Connection = cn;
                cmd.CommandText = "insert into emp values (@empid,@empname,@joindate)";
                cmd.Parameters.AddWithValue("@empid", TextBox1.Text);
                cmd.Parameters.AddWithValue("@empname", TextBox2.Text);
                cmd.Parameters.AddWithValue("@joindate", TextBox3.Text);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                Label1.Text = "Added";
            }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        using (SqlConnection cn = new SqlConnection())
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cn.ConnectionString = CnStr;
                cmd.Connection = cn;
                cmd.CommandText = "select * from emp where empid=@empid";
                cmd.Parameters.AddWithValue("@empid", TextBox1.Text);
                cn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {

                        TextBox2.Text = dr["EmpName"].ToString();
                        TextBox3.Text = dr["EmpDate"].ToString();
                        Label1.Text = "Found";
                    }
                    else
                    {
                        TextBox3.Text = "";
                        TextBox2.Text = "";
                        Label1.Text = "Not Found";
                    }
                }
                cn.Close();
                 
            }
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        using (SqlConnection cn = new SqlConnection())
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cn.ConnectionString = CnStr;
                cmd.Connection = cn;
                cmd.CommandText = "update emp set empname=@empname,empdate=@joindate where empid=@empid";
                cmd.Parameters.AddWithValue("@empid", TextBox1.Text);
                cmd.Parameters.AddWithValue("@empname", TextBox2.Text);
                cmd.Parameters.AddWithValue("@joindate", TextBox3.Text);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                Label1.Text = "Updated";
            }
        }
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        using (SqlConnection cn = new SqlConnection())
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cn.ConnectionString = CnStr;
                cmd.Connection = cn;
                cmd.CommandText = "delete from  emp   where empid=@empid";
                cmd.Parameters.AddWithValue("@empid", TextBox1.Text);
                
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                Label1.Text = "Deleted";
            }
        }
    }
}