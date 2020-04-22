using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CreateTT : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V6K1L04;Initial Catalog=Time_Table_EXT;Integrated Security=True");


    public void fillTempA(bool a)
    {
        if (a)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from CourseA", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int cou = ds.Tables[0].Rows.Count;

            for (int i = 0; i < cou; i++)
            {
                SqlCommand cmd = new SqlCommand("Insert into Temp Values ('" + ds.Tables[0].Rows[i][0].ToString() + "','" + ds.Tables[0].Rows[i][1].ToString() + "','" + ds.Tables[0].Rows[i][2].ToString() + "','" + ds.Tables[0].Rows[i][3].ToString() + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        else
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from CourseA where Type = 'Lecture'", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int cou = ds.Tables[0].Rows.Count;

            for (int i = 0; i < cou; i++)
            {
                SqlCommand cmd = new SqlCommand("Insert into Temp Values ('" + ds.Tables[0].Rows[i][0].ToString() + "','" + ds.Tables[0].Rows[i][1].ToString() + "','" + ds.Tables[0].Rows[i][2].ToString() + "','" + ds.Tables[0].Rows[i][3].ToString() + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }

    public void fillTempB(bool b)
    {
        if (b)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from CourseB", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int cou = ds.Tables[0].Rows.Count;

            for (int i = 0; i < cou; i++)
            {
                SqlCommand cmd = new SqlCommand("Insert into TempB Values ('" + ds.Tables[0].Rows[i][0].ToString() + "','" + ds.Tables[0].Rows[i][1].ToString() + "','" + ds.Tables[0].Rows[i][2].ToString() + "','" + ds.Tables[0].Rows[i][3].ToString() + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        else
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from CourseB Where Type = 'Lecture'", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int cou = ds.Tables[0].Rows.Count;

            for (int i = 0; i < cou; i++)
            {
                SqlCommand cmd = new SqlCommand("Insert into TempB Values ('" + ds.Tables[0].Rows[i][0].ToString() + "','" + ds.Tables[0].Rows[i][1].ToString() + "','" + ds.Tables[0].Rows[i][2].ToString() + "','" + ds.Tables[0].Rows[i][3].ToString() + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

        }
    }

    public string GetTempA(bool prac)
    {
        string rt = "";
        if (prac == false)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from Temp Where Type = 'Lecture' Order By NewID()", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                rt = dr[1].ToString() + "*" + dr[2].ToString() + "*" + dr[3].ToString();
                con.Close();
            }
            catch (Exception ep)
            {
                con.Close();
                rt = "err";
            }
        }
        else
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from Temp Order By NewID()", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                rt = dr[1].ToString() + "*" + dr[2].ToString() + "*" + dr[3].ToString();
                con.Close();
            }
            catch (Exception ep)
            {
                con.Close();
                rt = "err";
            }
        }
        return rt;
    }
    
    public string GetTempB(bool prac)
    {
        string rt = "";

        if (prac == false)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from TempB Where Type = 'Lecture' Order By NewID()", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                rt = dr[1].ToString() + "*" + dr[2].ToString() + "*" + dr[3].ToString();
                con.Close();
            }
            catch (Exception ep)
            {
                con.Close();
                rt = "err";
            }
        }
        else
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from TempB Order By NewID()", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                rt = dr[1].ToString() + "*" + dr[2].ToString() + "*" + dr[3].ToString();
                con.Close();
            }
            catch (Exception ep)
            {
                con.Close();
                rt = "err";
            }
        }
        return rt;
    }

    public string GetLab(string day, string time)
    {
        string rt = "";
        try
        {
            SqlCommand cmd = new SqlCommand("Select Name from Lab Where name NOT IN (Select Lab from LabTemp Where Time='"+time+"' And Day='"+day+"') Order By NewID()",con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            rt = dr[0].ToString();
            con.Close();
        }
        catch (Exception ep)
        {
            rt = "err";
        }
        return rt;
    }

    public string SetLab(string lab, string day, string time, string course)
    {
        string rt = "";
        try
        {
            SqlCommand cmd = new SqlCommand("Insert into LabTemp Values ('"+lab+"','"+time+"','"+course+"','"+day+"')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            rt = "true";
        }
        catch (Exception ep)
        {
            rt = "err";
        }
        return rt;
    }

    public string checkTeach(string teach, string day, string time)
    {
        string rt = "";
        SqlCommand cmd = new SqlCommand("Select * from Final_Tab Where Teacher = '"+teach+"' AND Day = '"+day+"' AND Slot = '"+time+"'",con);
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            rt = "false";
        }
        else
        {
            rt = "true";
        }
        con.Close();
        return rt;
    }

    public void clearData()
    {
        SqlCommand cmmd;
        con.Open();
        string op = "delete from TimeTable";
        cmmd = new SqlCommand(op, con);
        cmmd.ExecuteNonQuery();
        con.Close();
        con.Open();
        op = "delete from TimeTableB";
        cmmd = new SqlCommand(op, con);
        cmmd.ExecuteNonQuery();
        con.Close();
        con.Open();
        op = "delete from Temp";
        cmmd = new SqlCommand(op, con);
        cmmd.ExecuteNonQuery();
        con.Close();
        con.Open();
        op = "delete from TempB";
        cmmd = new SqlCommand(op, con);
        cmmd.ExecuteNonQuery();
        con.Close();
        //op = "delete from LabTemp";
        //cmmd = new SqlCommand(op, con);
        //con.Open();
        //cmmd.ExecuteNonQuery();
        //con.Close();
    }




    protected void Page_Load(object sender, EventArgs e)
    {
        // Delete
        clearData();

        // Fill Data
        fillTempA(true);
        fillTempB(true);

        string[] arr1 = new string[6] { "09:00-10:00", "10:00-12:00", "12:00-12:30", "12:30-02:30", "02:30-02:45", "02:45-04:45" };

        for (int i = 0; i < arr1.Length; i++)
        {
            SqlCommand cmd = new SqlCommand("Insert into TimeTable(Slot) Values ('" + arr1[i] + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        for (int i = 0; i < arr1.Length; i++)
        {
            SqlCommand cmd = new SqlCommand("Insert into TimeTableB (Slot) Values ('" + arr1[i] + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        string[] arrBreak = new string[2] { "12:00-12:30", "02:30-02:45" };
        string[] Days = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
        string[] abreak = new string[5] { "B", "R", "E", "A", "K" };

        for (int j = 0; j < arrBreak.Length; j++)
        {
            for (int i = 0; i < Days.Length; i++)
            {
                SqlCommand cmd = new SqlCommand("Update TimeTable Set " + Days[i] + " = '" + abreak[i] + "' Where Slot = '" + arrBreak[j] + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        for (int j = 0; j < arrBreak.Length; j++)
        {
            for (int i = 0; i < Days.Length; i++)
            {
                SqlCommand cmd = new SqlCommand("Update TimeTableB Set " + Days[i] + " = '" + abreak[i] + "' Where Slot = '" + arrBreak[j] + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        for (int i = 0; i < Days.Length; i++)
        {
            bool prac = false;
            string[] arr = new string[4] { "09:00-10:00", "10:00-12:00", "12:30-02:30", "02:45-04:45" };

            for (int j = 0; j < arr.Length; j++)
            {
                Start1:
                // Get Subject
                string sb = GetTempA(prac);
                if (sb == "err")
                {
                    fillTempA(false);
                }
                else
                {
                    string[] sub = sb.Split('*');
                    if (sub[2] == "Lecture")
                    {
                        //Check Teacher
                        string teach = checkTeach(sub[1], Days[i], arr[j]);
                        if (teach == "true")
                        {
                            SqlCommand cmd = new SqlCommand("Update Timetable set " + Days[i] + " = '" + sub[0] + "-" + sub[1] + "' Where Slot = '" + arr[j] + "'", con);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();

                            cmd = new SqlCommand("Delete From Temp Where Subject = '"+sub[0]+"' AND Teacher = '"+sub[1]+"'", con);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        else
                        {
                            goto Start1;
                        }
                    }
                    else
                    {
                        string[] teach = sub[1].Split(',');
                        string t1 = checkTeach(teach[0], Days[i], arr[j]);
                        string t2 = checkTeach(teach[1], Days[i], arr[j]);
                        string t3 = checkTeach(teach[2], Days[i], arr[j]);

                        if (t1 == "false" || t2 == "false" || t3 == "false")
                        {
                            goto Start1;
                        }
                        else
                        {
                            string[] subj = sub[0].Split(',');
                            string s1 = subj[0];
                            string s2 = subj[1];
                            string s3 = subj[2];

                            string l1 = GetLab(Days[i], arr[j]);
                            SetLab(l1, Days[i], arr[j], "A");

                            string l2 = GetLab(Days[i], arr[j]);
                            SetLab(l2, Days[i], arr[j], "A");

                            string l3 = GetLab(Days[i], arr[j]);
                            SetLab(l3, Days[i], arr[j], "A");

                            string final = s1 + ":" + teach[0] + " " + l1 + "<br />";
                            final += s2 + ":" + teach[1] + " " + l2 + "<br />";
                            final += s3 + ":" + teach[2] + " " + l3 + "<br />";

                            SqlCommand cmd = new SqlCommand("Update Timetable set " + Days[i] + " = '" + final + "' Where Slot = '" + arr[j] + "'", con);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();

                            cmd = new SqlCommand("Delete From Temp Where Subject = '" + sub[0] + "' AND Teacher = '" + sub[1] + "'", con);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }

                Start2:
                // Get Subject
                sb = GetTempB(prac);
                if (sb == "err")
                {
                    fillTempB(false);
                }
                else
                {
                    string[] sub = sb.Split('*');
                    if (sub[2] == "Lecture")
                    {
                        //Check Teacher
                        string teach = checkTeach(sub[1], Days[i], arr[j]);
                        if (teach == "true")
                        {
                            SqlCommand cmd = new SqlCommand("Update TimetableB set " + Days[i] + " = '" + sub[0] + "-" + sub[1] + "' Where Slot = '" + arr[j] + "'", con);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();

                            cmd = new SqlCommand("Delete From TempB Where Subject = '" + sub[0] + "' AND Teacher = '" + sub[1] + "'", con);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        else
                        {
                            goto Start2;
                        }
                    }
                    else
                    {
                        string[] teach = sub[1].Split(',');
                        string t1 = checkTeach(teach[0], Days[i], arr[j]);
                        string t2 = checkTeach(teach[1], Days[i], arr[j]);
                        string t3 = checkTeach(teach[2], Days[i], arr[j]);

                        if (t1 == "false" || t2 == "false" || t3 == "false")
                        {
                            goto Start2;
                        }
                        else
                        {
                            string[] subj = sub[0].Split(',');
                            string s1 = subj[0];
                            string s2 = subj[1];
                            string s3 = subj[2];

                            string l1 = GetLab(Days[i], arr[j]);
                            SetLab(l1, Days[i], arr[j], "B");

                            string l2 = GetLab(Days[i], arr[j]);
                            SetLab(l2, Days[i], arr[j], "B");

                            string l3 = GetLab(Days[i], arr[j]);
                            SetLab(l3, Days[i], arr[j], "B");

                            string final = s1 + ":" + teach[0] + " " + l1 + "<br />";
                            final += s2 + ":" + teach[1] + " " + l2 + "<br />";
                            final += s3 + ":" + teach[2] + " " + l3 + "<br />";

                            SqlCommand cmd = new SqlCommand("Update TimetableB set " + Days[i] + " = '" + final + "' Where Slot = '" + arr[j] + "'", con);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();

                            cmd = new SqlCommand("Delete From TempB Where Subject = '" + sub[0] + "' AND Teacher = '" + sub[1] + "'", con);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }
                prac = true;
            }
        }

        SqlDataAdapter da = new SqlDataAdapter("Select * from TimeTable", con);
        DataSet ds = new DataSet();
        da.Fill(ds);

        GridView1.DataSource = ds;
        GridView1.DataBind();

        da = new SqlDataAdapter("Select * from TimeTableB", con);
        ds = new DataSet();
        da.Fill(ds);

        GridView2.DataSource = ds;
        GridView2.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Xl(GridView1);
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Xl(GridView2);
    }

    public override void VerifyRenderingInServerForm(Control control)
    {

    }

    public void Xl(GridView GridView1)
    {
        Response.Clear();
        Response.Buffer = true;
        Response.AddHeader("content-disposition", "attachment;filename=GridViewExport.xls");
        Response.Charset = "";
        Response.ContentType = "application/vnd.ms-excel";
        using (StringWriter sw = new StringWriter())
        {
            HtmlTextWriter hw = new HtmlTextWriter(sw);

            //To Export all pages
            GridView1.AllowPaging = false;
            GridView1.HeaderRow.BackColor = Color.White;
            foreach (TableCell cell in GridView1.HeaderRow.Cells)
            {
                cell.BackColor = GridView1.HeaderStyle.BackColor;
            }
            foreach (GridViewRow row in GridView1.Rows)
            {
                row.BackColor = Color.White;
                foreach (TableCell cell in row.Cells)
                {
                    if (row.RowIndex % 2 == 0)
                    {
                        cell.BackColor = GridView1.AlternatingRowStyle.BackColor;
                    }
                    else
                    {
                        cell.BackColor = GridView1.RowStyle.BackColor;
                    }
                    cell.CssClass = "textmode";
                }
            }

            GridView1.RenderControl(hw);

            //style to format numbers to string
            string style = @"<style> .textmode { } </style>";
            Response.Write(style);
            Response.Output.Write(sw.ToString());
            Response.Flush();
            Response.End();
        }
    }
}