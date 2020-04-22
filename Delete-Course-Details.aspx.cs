using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class Delete_Course_Details : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V6K1L04;Initial Catalog=Time_Table_EXT;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["delete"] == "delete")
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgtype", "alert('Course Details Deleted !!!')", true);
            Session["delete"] = "";

        }
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        string m = "select cid,cname from course";
        da = new SqlDataAdapter(m, con);
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "yes")
        {
            string i = Convert.ToString(e.CommandArgument.ToString());
            string s = "Delete from course where cid='" + i + "'";
            SqlCommand cmd = new SqlCommand(s, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            try
            {
                s = "Delete from courseA where cid='" + i + "'";
                cmd = new SqlCommand(s, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            { }
            try
            {
                s = "Delete from courseB where cid='" + i + "'";
                cmd = new SqlCommand(s, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            { }
            Session["delete"] = "delete";
            Response.Redirect("Delete-Course-Details.aspx");

        }
    }


}