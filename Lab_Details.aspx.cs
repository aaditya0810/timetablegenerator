using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Lab_Details : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V6K1L04;Initial Catalog=Time_Table_EXT;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["delete"] == "delete")
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgtype", "alert('Lab Details Cleared !!!')", true);
            Session["delete"] = "";
        }
        Panel1.Visible = false;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        string m = "select name from Lab";
        da = new SqlDataAdapter(m, con);
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            GridView1.DataSource = ds;
            GridView1.DataBind();
            Panel1.Visible = true;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        string m = "select top 1 lid from Lab order by lid desc";
        da = new SqlDataAdapter(m, con);
        da.Fill(ds);
        int tid = 0;
        if (ds.Tables[0].Rows.Count > 0)
        {
            tid = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
            tid = tid + 1;
        }
        else
        {
            tid = 1001;
        }
        SqlCommand cmd;
        con.Open();
        string n = "insert into Lab values('" + tid + "','" + TextBox1.Text + "')";
        cmd = new SqlCommand(n, con);
        cmd.ExecuteNonQuery();
        con.Close();
        Session["add"] = "add";
        Response.Redirect("Lab_Details.aspx");
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        SqlCommand cmd;
        con.Open();
        string m = "delete from LabTemp";
        cmd = new SqlCommand(m, con);
        cmd.ExecuteNonQuery();
        con.Close();
        Session["delete"] = "delete";
    }
}