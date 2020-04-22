using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using Check;

public partial class HomePage : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V6K1L04;Initial Catalog=Time_Table_EXT;Integrated Security=True");
    
    protected void Page_Load(object sender, EventArgs e)
    {
        #region System Generated . . .
        Class1 c = new Class1();
        bool c1 = c.check("W149", con);
        if (!c1)
        {
            Response.Redirect("Login.aspx");
        }
        #endregion


    }

    protected void Button1_Click(object sender, EventArgs e)
    {
       
    }


    protected void Button5_Click(object sender, EventArgs e)
    {
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        string m = "select pass from admin where id='" + TextBox11.Text + "'";
        da = new SqlDataAdapter(m, con);
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            string pass = ds.Tables[0].Rows[0][0].ToString();
            if (TextBox12.Text == pass)
            {
                Response.Redirect("AddTeacher.aspx");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "msgtype()", "alert('Invalid Password !!!')", true);
            }

        }
        else
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgtype()", "alert('Invalid ID !!!')", true);
        }
    }

   
    protected void Button2_Click1(object sender, EventArgs e)
    {
       
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
       
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
      
    }
}