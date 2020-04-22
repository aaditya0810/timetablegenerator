using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class CourseDetails : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V6K1L04;Initial Catalog=Time_Table_EXT;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["add"] == "add")
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgtype()", "alert('Course Details Added !!!')", true);
            Session["add"] = "";
        }
        if (!IsPostBack)
        {
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = false;
            Panel5.Visible = false;
            Panel6.Visible = false;
            Panel7.Visible = false;
            Panel8.Visible = false;
            Panel9.Visible = false;
            Panel10.Visible = false;
            Panel11.Visible = false;
            Panel12.Visible = false;
            Panel13.Visible = false;
            Panel14.Visible = false;
           
            
            Panel21.Visible = false;
            SqlDataAdapter da2;
            DataSet ds2 = new DataSet();
            string ml = "select name from teacher";
            da2 = new SqlDataAdapter(ml, con);
            da2.Fill(ds2);
            if (ds2.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
                {
                    teach1.Items.Add(ds2.Tables[0].Rows[i][0].ToString());
                    teach2.Items.Add(ds2.Tables[0].Rows[i][0].ToString());
                    teach3.Items.Add(ds2.Tables[0].Rows[i][0].ToString());
                    teach4.Items.Add(ds2.Tables[0].Rows[i][0].ToString());
                    teach5.Items.Add(ds2.Tables[0].Rows[i][0].ToString());
                    teach6.Items.Add(ds2.Tables[0].Rows[i][0].ToString());
                    teach7.Items.Add(ds2.Tables[0].Rows[i][0].ToString());
                    teach8.Items.Add(ds2.Tables[0].Rows[i][0].ToString());
                   
                    teach9.Items.Add(ds2.Tables[0].Rows[i][0].ToString());
                    teach10.Items.Add(ds2.Tables[0].Rows[i][0].ToString());
                    teach11.Items.Add(ds2.Tables[0].Rows[i][0].ToString());
                    teach12.Items.Add(ds2.Tables[0].Rows[i][0].ToString());
                    teach13.Items.Add(ds2.Tables[0].Rows[i][0].ToString());
                    teach14.Items.Add(ds2.Tables[0].Rows[i][0].ToString());
                   
                   
                }

            }
          

            SqlDataAdapter da;
            DataSet ds = new DataSet();
            string m = "select cid,subject,teacher,type from courseA";
            da = new SqlDataAdapter(m, con);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                SqlDataAdapter da1;
                DataSet ds1 = new DataSet();
                string p = "select cid,subject,teacher,type from courseB";
                da1 = new SqlDataAdapter(p, con);
                da1.Fill(ds1);
                if (ds1.Tables[0].Rows.Count > 0)
                {
                    Panel22.Enabled = false;
                }
                else
                {
                    TextBox2.Text = "B";
                    TextBox2.ReadOnly = true;
                    Panel22.Enabled = true;
                }
            }
            else
            {
                TextBox2.Text = "A";
                TextBox2.ReadOnly = true;
                Panel22.Enabled = true;
            }
        }
    }
   
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlDataAdapter da5;
        DataSet ds5 = new DataSet();
        string m = "select cname from course";
        da5 = new SqlDataAdapter(m, con);
        da5.Fill(ds5);
        int flag = 0;
        if (ds5.Tables[0].Rows.Count > 0)
        {
            
            for (int i = 0; i < ds5.Tables[0].Rows.Count; i++)
            {
                string[] s = ds5.Tables[0].Rows[i][0].ToString().Split('-');
                foreach (string word in s)
                {
                    if (s[0] == TextBox1.Text)
                    {
                        if (s[1] == "A")
                        {
                            flag = 0;
                        }
                        if(s[1]=="B")
                        {
                            flag=1;
                        }

                    }
                }

 
            }
        }
        if (flag == 1 && flag==0)
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgtype", "alert('Course details already exist')", true);

        }
        else
        {
            if (DropDownList3.SelectedItem.Text == "--Select--")
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "msgtype", "alert('Select Number of Lectures !!!')", true);
            }
            if (DropDownList4.SelectedItem.Text == "--Select--")
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "msgtype", "alert('Select Number of Practicals !!!')", true);
            }
            else
            {
               
                int total = 0;
                int g = 0;
                total = Convert.ToInt32(DropDownList3.SelectedItem.Text);
                g = Convert.ToInt32(DropDownList4.SelectedItem.Text);
                if (total >= 2)
                {
                    Panel1.Visible = true;
                    Panel2.Visible = true;
                    Panel21.Visible = true;
                }
                if (total >= 3)
                {
                    
                    Panel3.Visible = true;
                    Panel21.Visible = true;
                }
                if (total >= 4)
                {
                    
                    Panel4.Visible = true;
                    Panel21.Visible = true;

                }
                if (total >= 5)
                {
                   
                    Panel5.Visible = true;
                    Panel21.Visible = true;
                }
                if (total >= 6)
                {
                   
                    Panel6.Visible = true;
                    Panel21.Visible = true;
                }
                if (total >= 7)
                {
                   
                    Panel7.Visible = true;
                    Panel21.Visible = true;
                }
                if (total >= 8)
                {
                   
                    Panel8.Visible = true;
                    Panel21.Visible = true;
                }
                if (g==1)
                {
                   
                    Panel9.Visible = true;
                   
                    Panel10.Visible = true;
                 
                    Panel11.Visible = true;
                    Panel21.Visible = true;
                }
                if (g == 2)
                {
                    Panel9.Visible = true;
                   
                    Panel10.Visible = true;
                   
                    Panel11.Visible = true;
                   
                    Panel12.Visible = true;
                  
                    Panel13.Visible = true;
                  
                    Panel14.Visible = true;
                    Panel21.Visible = true;
                }
               
            }
        }
    }

    int valid(int to)
    {
        string[] arr = new string[to];
        if (to >= 2)
        {
            arr[0] = teach1.SelectedItem.Text;
            arr[1] = teach2.SelectedItem.Text;
        }
        if (to >= 3)
        {
           
            arr[2] = teach3.SelectedItem.Text;
        }
        if (to >= 4)
        {

            arr[3] = teach4.SelectedItem.Text;
        }
        if (to >= 5)
        {

            arr[4] = teach5.SelectedItem.Text;
        }
        if (to >= 6)
        {

            arr[5] = teach6.SelectedItem.Text;
        }
        if (to >= 7)
        {

            arr[6] = teach7.SelectedItem.Text;
        }
        if (to >= 8)
        {

            arr[7] = teach8.SelectedItem.Text;
        }
        if (to >= 9)
        {

            arr[8] = teach9.SelectedItem.Text;
        }
        if (to >= 10)
        {

            arr[9] = teach10.SelectedItem.Text;
        }
        if (to >= 11)
        {

            arr[10] = teach11.SelectedItem.Text;
        }
        if (to >= 12)
        {

            arr[11] = teach12.SelectedItem.Text;
        }
        if (to >= 13)
        {

            arr[12] = teach13.SelectedItem.Text;
        }
        if (to >= 14)
        {

            arr[13] = teach14.SelectedItem.Text;
        }
       
        int flag = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    flag = 1;
                }
            }
        }
        return flag;
    }
   int check(int to)
    {
        string[] arr = new string[to];
        if (to >= 2)
        {
            arr[0] = type1.SelectedItem.Text;
            arr[1] = type2.SelectedItem.Text;
        }
        if (to >= 3)
        {

            arr[2] = type3.SelectedItem.Text;
        }
        if (to >= 4)
        {

            arr[3] = type4.SelectedItem.Text;
        }
        if (to >= 5)
        {

            arr[4] = type5.SelectedItem.Text;
        }
        if (to >= 6)
        {

            arr[5] = type6.SelectedItem.Text;
        }
        if (to >= 7)
        {

            arr[6] = type7.SelectedItem.Text;
        }
        if (to >= 8)
        {

            arr[7] = type8.SelectedItem.Text;
        }
        if (to >= 9)
        {

            arr[8] = type9.SelectedItem.Text;
        }
        if (to >= 10)
        {

            arr[9] = type10.SelectedItem.Text;
        }
        if (to >= 11)
        {

            arr[10] = type11.SelectedItem.Text;
        }
        if (to >= 12)
        {

            arr[11] = type12.SelectedItem.Text;
        }
        if (to >= 13)
        {

            arr[12] = type13.SelectedItem.Text;
        }
        if (to >= 14)
        {

            arr[13] = type14.SelectedItem.Text;
        }
        
       
        int flag = 0;
        /*int prac=0;
        int lec=0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == "Lecture")
            {
                lec = lec + 1;
            }
            if (arr[i] == "Practical")
            {
                prac = prac + 1;
            }
        }
        if (lec > Convert.ToInt32(DropDownList3.SelectedItem.Text))
        {
            flag = 1;
        }
        else if (prac > Convert.ToInt32(DropDownList4.SelectedItem.Text))
        {
            flag = 2;
        }*/
        return flag;
        
    }
   int checkteach(int to)
   {
       string[] arr = new string[to];
       if (to >= 2)
       {
           arr[0] = teach1.SelectedItem.Text;
           arr[1] = teach2.SelectedItem.Text;
       }
       if (to >= 3)
       {

           arr[2] = teach3.SelectedItem.Text;
       }
       if (to >= 4)
       {

           arr[3] = teach4.SelectedItem.Text;
       }
       if (to >= 5)
       {

           arr[4] = teach5.SelectedItem.Text;
       }
       if (to >= 6)
       {

           arr[5] = teach6.SelectedItem.Text;
       }
       if (to >= 7)
       {

           arr[6] = teach7.SelectedItem.Text;
       }
       if (to >= 8)
       {

           arr[7] = teach8.SelectedItem.Text;
       }
       if (to >= 9)
       {

           arr[8] = teach9.SelectedItem.Text;
       }
       if (to >= 10)
       {

           arr[9] = teach10.SelectedItem.Text;
       }
       if (to >= 11)
       {

           arr[10] = teach11.SelectedItem.Text;
       }
       if (to >= 12)
       {

           arr[11] = teach12.SelectedItem.Text;
       }
       if (to >= 13)
       {

           arr[12] = teach13.SelectedItem.Text;
       }
       if (to >= 14)
       {

           arr[13] = teach14.SelectedItem.Text;
       }
       
      
       int flag = 0;
       for (int i = 0; i < arr.Length; i++)
       {
           if (arr[i] == "--Select--")
           {
               flag = 1;
           }
       }
       return flag;

   }
   int checktype(int to)
   {
       string[] arr = new string[to];
        if (to >= 2)
        {
            arr[0] = type1.SelectedItem.Text;
            arr[1] = type2.SelectedItem.Text;
        }
        if (to >= 3)
        {

            arr[2] = type3.SelectedItem.Text;
        }
        if (to >= 4)
        {

            arr[3] = type4.SelectedItem.Text;
        }
        if (to >= 5)
        {

            arr[4] = type5.SelectedItem.Text;
        }
        if (to >= 6)
        {

            arr[5] = type6.SelectedItem.Text;
        }
        if (to >= 7)
        {

            arr[6] = type7.SelectedItem.Text;
        }
        if (to >= 8)
        {

            arr[7] = type8.SelectedItem.Text;
        }
        if (to >= 9)
        {

            arr[8] = type9.SelectedItem.Text;
        }
        if (to >= 10)
        {

            arr[9] = type10.SelectedItem.Text;
        }
        if (to >= 11)
        {

            arr[10] = type11.SelectedItem.Text;
        }
        if (to >= 12)
        {

            arr[11] = type12.SelectedItem.Text;
        }
        if (to >= 13)
        {

            arr[12] = type13.SelectedItem.Text;
        }
        if (to >= 14)
        {

            arr[13] = type14.SelectedItem.Text;
        }
       
       
        int flag = 0;
       
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == "--Select--")
            {
                flag = 1;
            }
        }
        return flag;
   }
    protected void Button2_Click1(object sender, EventArgs e)
    {
        
                    

       int total = Convert.ToInt32(DropDownList3.SelectedItem.Text);
        int g = Convert.ToInt32(DropDownList4.SelectedItem.Text);
       
        int fl = check(total);
        int chktea = checkteach(total);
        int chkty = checktype(total);
        if (chktea == 1)
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgtype()", "alert('Select Teacher !!!')", true);
        }
        else if (chkty == 1)
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgtype()", "alert('Select Type !!!')", true);
        }
        else if (fl == 1)
       {
           Page.ClientScript.RegisterStartupScript(GetType(), "msgtype()", "alert('Number of lectures are more than practicals mentioned !!!')", true);
       }
        else if (fl == 2)
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgtype()", "alert('Number of practical are more than lectures mentioned !!!')", true);
        }
        else
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            string ol = "select top 1 cid from course order by cid desc";
            da = new SqlDataAdapter(ol, con);
            da.Fill(ds);
            int cid = 0;
            if (ds.Tables[0].Rows.Count > 0)
            {
                cid = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
                cid = cid + 1;
                h1.Value = Convert.ToString(cid);

            }
            else
            {
                cid = 1001;
                h1.Value = Convert.ToString(cid);
            }
            h2.Value = TextBox1.Text + "-" + TextBox2.Text;
            SqlCommand cmd;
            con.Open();
            string kl = "insert into course values('" + cid + "','" + h2.Value + "','" + DropDownList3.SelectedItem.Text + "','" + DropDownList4.SelectedItem.Text + "')";
            cmd = new SqlCommand(kl, con);
            cmd.ExecuteNonQuery();
            con.Close();
           
            if (total >= 2)
            {
                string su1 = sub1.Text;
                string te1 = teach1.Text;
                string ty1 = type1.Text;
                string su2 = sub2.Text;
                string te2 = teach2.Text;
                string ty2 = type2.Text;

                adddata(su1, te1, ty1);
                adddata(su2, te2, ty2);
            }
            if (total >= 3)
            {

                string su3 = sub3.Text;
                string te3 = teach3.Text;
                string ty3 = type3.Text;

                adddata(su3, te3, ty3);
            }
            if (total >= 4)
            {

                string su4 = sub4.Text;
                string te4 = teach4.Text;
                string ty4 = type4.Text;

                adddata(su4, te4, ty4);
            }
            if (total >= 5)
            {

                string su5 = sub5.Text;
                string te5 = teach5.Text;
                string ty5 = type5.Text;

                adddata(su5, te5, ty5);
            }
            if (total >= 6)
            {

                string su6 = sub6.Text;
                string te6 = teach6.Text;
                string ty6 = type6.Text;


                adddata(su6, te6, ty6);

            }
            if (total >= 7)
            {

                string su7 = sub7.Text;
                string te7 = teach7.Text;
                string ty7 = type7.Text;

                adddata(su7, te7, ty7);
            }
            if (total >= 8)
            {

                string su8 = sub8.Text;
                string te8 = teach8.Text;
                string ty8 = type8.Text;

                adddata(su8, te8, ty8);
            }
            if (g==1)
            {
                string te9 = teach9.Text;
                string su9 = sub9.Text;
               
                string ty9 = type9.Text;
                string te10 = teach10.Text;
                string su10 = sub10.Text;
              
                string ty10 = type10.Text;
                string te11 = teach11.Text;
                string su11 = sub11.Text;
               
                string ty11 = type11.Text;
                string teach = te9 + "," + te10 + "," + te11;
                string sub = su9 + "," + su10 + "," + su11;
                
                adddata(sub, teach, ty11);
            }
           
            if (g==2)
            {
                string te9 = teach9.Text;
                string su9 = sub9.Text;

                string ty9 = type9.Text;
                string te10 = teach10.Text;
                string su10 = sub10.Text;

                string ty10 = type10.Text;
                string te11 = teach11.Text;
                string su11 = sub11.Text;

                string ty11 = type11.Text;
               
              



                string te12 = teach12.Text;

                string su12 = sub12.Text;
              
                string ty12 = type12.Text;
                string te13 = teach13.Text;
                string su13 = sub13.Text;
                
                string ty13 = type13.Text;
                string te14 = teach14.Text;
                string su14 = sub14.Text;
                
                string ty14 = type14.Text;
                string teach1 = te9 + "," + te10 + "," + te11+","+ te12 + "," + te13 + "," + te14;
                string sub1 = su9 + "," + su10 + "," + su11 +"," +su12+","+su13 + "," + su14;
                adddata(sub1, teach1, ty12);
                
            }

        
            
            Session["add"] = "add";
            Response.Redirect("CourseDetails.aspx");
        }
    }
    void adddata(string sub,string teach,string type)

    {
        if (TextBox2.Text == "A")
        {
            SqlCommand cmd;
            con.Open();
            string m = "insert into courseA values('" + h1.Value + "','" + sub + "','" + teach + "','" + type + "')";
            cmd = new SqlCommand(m, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        else if (TextBox2.Text == "B")
        {
            SqlCommand cmd;
            con.Open();
            string m = "insert into courseB values('" + h1.Value + "','" + sub + "','" + teach + "','" + type + "')";
            cmd = new SqlCommand(m, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
     

 
    }
}