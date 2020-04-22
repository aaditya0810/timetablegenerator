using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class AddTeacher : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V6K1L04;Initial Catalog=Time_Table_EXT;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["add"] == "add")
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgtype", "alert('Teacher Details Added into Database !!!')", true);
            Session["add"] = "";
        }


    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlDataAdapter da;
        DataSet ds=new DataSet();
        string m="select top 1 tid from teacher order by tid desc";
        da=new SqlDataAdapter(m,con);
        da.Fill(ds);
        int tid=0;
        if(ds.Tables[0].Rows.Count>0)
        {
            tid=Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
            tid=tid+1;
        }
        else
        {
            tid=50001;
        }
        SqlCommand cmd;
        con.Open();
        string n = "insert into teacher values('" + tid + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')";
        cmd = new SqlCommand(n, con);
        cmd.ExecuteNonQuery();
        con.Close();
        Session["add"] = "add";
        Response.Redirect("AddTeacher.aspx");
    }
}