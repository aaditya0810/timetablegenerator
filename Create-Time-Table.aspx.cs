using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Create_Time_Table : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V6K1L04;Initial Catalog=Time_Table_EXT;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
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
            
            /* con.Open();
             op = "delete from LabTemp";
             cmmd = new SqlCommand(op, con);
             cmmd.ExecuteNonQuery();
             con.Close();*/

            SqlDataAdapter da;
            DataSet ds = new DataSet();
            string m = "select cid,subject,teacher,type from courseA where type='Practical' order by newid()";
            da = new SqlDataAdapter(m, con);
            da.Fill(ds);
            string cid = "", subject = "", teacher = "", type = "";
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    cid = ds.Tables[0].Rows[i][0].ToString();
                    subject = ds.Tables[0].Rows[i][1].ToString();
                    
                       
                        teacher = ds.Tables[0].Rows[i][2].ToString();
                    getprac(subject, teacher);
                    
                    type = ds.Tables[0].Rows[i][3].ToString();
                    SqlCommand cmd;
                    con.Open();
                    string k = "insert into Temp values('" + cid + "','" + subject + "','" + teacher + "','" + type + "')";
                    cmd = new SqlCommand(k, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                }

            }
  
          ds = new DataSet();
             m = "select cid,subject,teacher,type from courseA where type='Lecture' order by newid()";
            da = new SqlDataAdapter(m, con);
            da.Fill(ds);
          
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    cid = ds.Tables[0].Rows[i][0].ToString();
                    subject = ds.Tables[0].Rows[i][1].ToString();
                    teacher = ds.Tables[0].Rows[i][2].ToString();
                    type = ds.Tables[0].Rows[i][3].ToString();
                    SqlCommand cmd;
                    con.Open();
                    string k = "insert into Temp values('" + cid + "','" + subject + "','" + teacher + "','" + type + "')";
                    cmd = new SqlCommand(k, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                }

            }
            string[] arr = new string[6] { "09:00-10:00", "10:00-12:00", "12:00-12:30", "12:30-02:30", "02:30-02:45", "02:45-04:45" };
            for (int i = 1; i <= arr.Length; i++)
            {
                TableRow tRow = new TableRow();//first row
                TableCell tcell = new TableCell();


                string ti = Convert.ToString(i);
                tcell.Text = ti;
                tRow.Cells.Add(tcell);
                Table2.Rows.Add(tRow);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                TableRow tRow = new TableRow();//first row
                TableCell tcell = new TableCell();


                string ti = arr[i];
                SqlCommand cmd;
                con.Open();
                string km = "insert into TimeTable(slot) values('" + arr[i] + "')";
                cmd = new SqlCommand(km, con);
                cmd.ExecuteNonQuery();
                con.Close();
                tcell.Text = ti;
                tRow.Cells.Add(tcell);
                Table3.Rows.Add(tRow);
            }
            int count = 4;

            int co = 0;

            for (int j = 0; j < 5; j++)
            {

                for (int i = 0; i < arr.Length; i++)
                {
                    TableRow tRow = new TableRow();//first row
                    TableCell tcell = new TableCell();


                    string ti = arr[i];
                    SqlDataAdapter da5;
                    DataSet ds5 = new DataSet();
                    string m5 = "select cid,subject,teacher,type from Temp";
                    da5 = new SqlDataAdapter(m5, con);
                    da5.Fill(ds5);
                    string id = "", ty = "", sub = "", teach = "", lec = "";

                    if (ds5.Tables[0].Rows.Count > 0)
                    {
                        for (int k = 0; k < ds5.Tables[0].Rows.Count; k++)
                        {
                            id = ds5.Tables[0].Rows[k][0].ToString();
                            sub = ds5.Tables[0].Rows[k][1].ToString();
                            teach = ds5.Tables[0].Rows[k][2].ToString();
                            ty = ds5.Tables[0].Rows[k][3].ToString();

                            tcell.Text = getlec(ti, sub, teach, ty,j);

                            if (tcell.Text != "")
                            {
                                SqlCommand cmd;
                                con.Open();
                                string km = "";
                                if (j == 0)
                                {
                                    km = "update TimeTable set monday='" + tcell.Text + "' where slot='" + ti + "'";
                                }
                                if (j == 1)
                                {
                                    km = "update TimeTable set tuesday='" + tcell.Text + "' where slot='" + ti + "'";
                                }
                                if (j == 2)
                                {
                                    km = "update TimeTable set wednesday='" + tcell.Text + "' where slot='" + ti + "'";
                                }
                                if (j == 3)
                                {
                                    km = "update TimeTable set thursday='" + tcell.Text + "' where slot='" + ti + "'";
                                }
                                if (j == 4)
                                {
                                    km = "update TimeTable set friday='" + tcell.Text + "' where slot='" + ti + "'";
                                }
                                cmd = new SqlCommand(km, con);
                                cmd.ExecuteNonQuery();
                                con.Close();
                                ds5 = new DataSet();
                                m5 = "select cid,subject,teacher,type from Temp";
                                da5 = new SqlDataAdapter(m5, con);
                                da5.Fill(ds5);
                                if (ds5.Tables[0].Rows.Count == 0)
                                {
                                    fill();

                                }
                                break;

                            }


                        }
                    }
                    else
                    {
                        fill();



                    }

                    tRow.Cells.Add(tcell);
                    if (j == 0)
                    {
                        Table4.Rows.Add(tRow);
                    }
                    else if (j == 1)
                    {
                        Table5.Rows.Add(tRow);
                    }
                    else if (j == 2)
                    {
                        Table6.Rows.Add(tRow);
                    }
                    else if (j == 3)
                    {
                        Table7.Rows.Add(tRow);
                    }
                    else if (j == 4)
                    {
                        Table8.Rows.Add(tRow);
                    }

                }

            }
            // ===============================Course B===========================//
            /* SqlCommand cmd2;
             con.Open();
             string kl = "delete from LabTemp where course='A' and flag='0'";
             cmd2 = new SqlCommand(kl, con);
             cmd2.ExecuteNonQuery();
             con.Close();*/
            SqlDataAdapter da1;
            DataSet ds1 = new DataSet();
            string m1 = "select cid,subject,teacher,type from courseB  where type='Practical' order by newid()";
            da1 = new SqlDataAdapter(m1, con);
            da1.Fill(ds1);
            string ccid = "", su = "", tea = "", t = "";
            if (ds1.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                {
                    ccid = ds1.Tables[0].Rows[i][0].ToString();
                    su = ds1.Tables[0].Rows[i][1].ToString();
                   su = su.Replace("<br />","");
                    string[] ss = su.Split('-');
                    string sub = "";
                    foreach (string word in ss)
                    {
                        sub = ss[0];
                        tea = ss[1];
                    }
                    t = ds1.Tables[0].Rows[i][3].ToString();
                    SqlCommand cmd;
                    con.Open();
                    string k = "insert into TempB values('" + ccid + "','" + sub + "','" + tea + "','" + t + "')";
                    cmd = new SqlCommand(k, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                }

            }
           ds1 = new DataSet();
           m1 = "select cid,subject,teacher,type from courseB where type='Lecture' order by newid()";
            da1 = new SqlDataAdapter(m1, con);
            da1.Fill(ds1);
           
            if (ds1.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                {
                    ccid = ds1.Tables[0].Rows[i][0].ToString();
                    su = ds1.Tables[0].Rows[i][1].ToString();
                    tea = ds1.Tables[0].Rows[i][2].ToString();
                    t = ds1.Tables[0].Rows[i][3].ToString();
                    SqlCommand cmd;
                    con.Open();
                    string k = "insert into TempB values('" + ccid + "','" + su + "','" + tea + "','" + t + "')";
                    cmd = new SqlCommand(k, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                }

            }
            for (int i = 1; i <= arr.Length; i++)
            {
                TableRow tRow = new TableRow();//first row
                TableCell tcell = new TableCell();


                string ti = Convert.ToString(i);
                tcell.Text = ti;
                tRow.Cells.Add(tcell);
                Table10.Rows.Add(tRow);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                TableRow tRow = new TableRow();//first row
                TableCell tcell = new TableCell();


                string ti = arr[i];
                SqlCommand cmd;
                con.Open();
                string km = "insert into TimeTableB(slot) values('" + arr[i] + "')";
                cmd = new SqlCommand(km, con);
                cmd.ExecuteNonQuery();
                con.Close();
                tcell.Text = ti;
                tRow.Cells.Add(tcell);
                Table11.Rows.Add(tRow);
            }
            SqlDataAdapter daa1;
            DataSet dss1 = new DataSet();
            string mh1 = "select cid,subject,teacher,type from TempB";
            daa1 = new SqlDataAdapter(mh1, con);
            daa1.Fill(dss1);
            int cou = 0;


            for (int j = 0; j < 5; j++)
            {

                for (int i = 0; i < arr.Length; i++)
                {
                    TableRow tRow = new TableRow();//first row
                    TableCell tcell = new TableCell();


                    string ti = arr[i];
                    SqlDataAdapter da5;
                    DataSet ds5 = new DataSet();
                    string m5 = "select cid,subject,teacher,type from TempB";
                    da5 = new SqlDataAdapter(m5, con);
                    da5.Fill(ds5);
                    string id = "", ty = "", sub = "", teach = "", lec = "";

                    if (ds5.Tables[0].Rows.Count > 0)
                    {
                        for (int k = 0; k < ds5.Tables[0].Rows.Count; k++)
                        {
                            id = ds5.Tables[0].Rows[k][0].ToString();
                            sub = ds5.Tables[0].Rows[k][1].ToString();
                            teach = ds5.Tables[0].Rows[k][2].ToString();
                            ty = ds5.Tables[0].Rows[k][3].ToString();
                            Boolean aa = checkteach(ti, j, teach);
                            if (aa == false)
                            {

                                tcell.Text = getlecB(ti, sub, teach, ty,j);


                                if (tcell.Text != "")
                                {
                                    SqlCommand cmd;
                                    con.Open();
                                    string km = "";
                                    if (j == 0)
                                    {
                                        km = "update TimeTableB set monday='" + tcell.Text + "' where slot='" + ti + "'";
                                    }
                                    if (j == 1)
                                    {
                                        km = "update TimeTableB set tuesday='" + tcell.Text + "' where slot='" + ti + "'";
                                    }
                                    if (j == 2)
                                    {
                                        km = "update TimeTableB set wednesday='" + tcell.Text + "' where slot='" + ti + "'";
                                    }
                                    if (j == 3)
                                    {
                                        km = "update TimeTableB set thursday='" + tcell.Text + "' where slot='" + ti + "'";
                                    }
                                    if (j == 4)
                                    {
                                        km = "update TimeTableB set friday='" + tcell.Text + "' where slot='" + ti + "'";
                                    }
                                    cmd = new SqlCommand(km, con);
                                    cmd.ExecuteNonQuery();
                                    con.Close();
                                    /*ds5 = new DataSet();
                                    m5 = "select cid,subject,teacher,type from TempB where type='Lecture'";
                                    da5 = new SqlDataAdapter(m5, con);
                                    da5.Fill(ds5);
                                    if (ds5.Tables[0].Rows.Count == 0)
                                    {
                                        fillB();

                                    }*/
                                    ds5 = new DataSet();
                                    m5 = "select cid,subject,teacher,type from TempB";
                                    da5 = new SqlDataAdapter(m5, con);
                                    da5.Fill(ds5);
                                    if (ds5.Tables[0].Rows.Count == 0)
                                    {
                                        fillB();

                                    }
                                    break;

                                }

                            }


                        }
                    }
                    else
                    {
                        fillB();

                    }

                    tRow.Cells.Add(tcell);
                    if (j == 0)
                    {
                        Table12.Rows.Add(tRow);
                    }
                    else if (j == 1)
                    {
                        Table13.Rows.Add(tRow);
                    }
                    else if (j == 2)
                    {
                        Table14.Rows.Add(tRow);
                    }
                    else if (j == 3)
                    {
                        Table15.Rows.Add(tRow);
                    }
                    else if (j == 4)
                    {
                        Table16.Rows.Add(tRow);
                    }

                }

            }

        }
    }
    string getprac(string sub, string teacher)
    {

        return "s";

    }
    void checkA()
    {
        SqlDataAdapter da6;
        DataSet ds6 = new DataSet();
        string m6 = "select cid,subject,teacher,type from Temp";
        da6 = new SqlDataAdapter(m6, con);
        da6.Fill(ds6);
        if (ds6.Tables[0].Rows.Count <= 0)
        {
            fill();
        }
    }
    void checkB()
    {
        SqlDataAdapter da6;
        DataSet ds6 = new DataSet();
        string m6 = "select cid,subject,teacher,type from TempB";
        da6 = new SqlDataAdapter(m6, con);
        da6.Fill(ds6);
        if (ds6.Tables[0].Rows.Count <= 0)
        {
            fillB();
        }
    }
    void selectlab(string mt, string grp)
    {

        //int[] arr = new int[] { 1, 2, 3, 4, 5 };



    }
    string upd(string ti, string grp,int j)
    {
        SqlDataAdapter da1;
        DataSet ds1 = new DataSet();
        string ml = "select name from Lab order by newid()";
        da1 = new SqlDataAdapter(ml, con);
        da1.Fill(ds1);
        string lab = "";
        string la = "";
        if (ds1.Tables[0].Rows.Count > 0)
        {
            for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
            {
                lab = ds1.Tables[0].Rows[i][0].ToString();
                bool fla = false;
                if (grp == "B")
                {
                    fla = checklab(ti, grp, j, lab);
                    if (fla == false)
                    {
                        SqlCommand cmd;
                        con.Open();
                        string ll = "insert into LabTemp values('" + lab + "','" + ti + "','" + grp + "','" + j + "')";
                        cmd = new SqlCommand(ll, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        la = lab;
                        break;
                    }
                }
                else
                {

                    SqlDataAdapter da;
                    DataSet ds = new DataSet();
                    string kl = "select lab from LabTemp where time='" + ti + "' and lab='" + lab + "' and day='" + j + "' and course='" + grp + "'";
                    da = new SqlDataAdapter(kl, con);
                    da.Fill(ds);
                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        SqlCommand cmd;
                        con.Open();
                        string ll = "insert into LabTemp values('" + lab + "','" + ti + "','" + grp + "','" + j + "')";
                        cmd = new SqlCommand(ll, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        la = lab;
                        break;
                    }
                }
            }
        }
        return la;
    }

    bool checklab(string ti,string grp,int j,string lab)
    {
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        string kl = "select lab from LabTemp where time='" + ti + "' and course='A'  and day='"+j+"' and lab='"+lab+"'";
        da = new SqlDataAdapter(kl, con);
        da.Fill(ds);
        bool fa = false;
        if (ds.Tables[0].Rows.Count > 0)
        {
            fa = true;
        }
        return fa;
    }
    string getlec(string ti, string sub, string teach, string ty,int j)
    {

        string lec = "";
        string grp = "A";
        string lab = "";
        if (ti == "09:00-10:00")
        {
            if (ty == "Lecture")
            {
                lec = sub + "-" + teach;
                SqlCommand cmd;
                string op = "delete from temp where subject='" + sub + "'";
                con.Open();
                cmd = new SqlCommand(op, con);
                cmd.ExecuteNonQuery();
                con.Close();

            }
        }
        if (ti == "10:00-12:00")
        {
            if (ty == "Practical")
            {

                lab = upd(ti, grp,j);

                lec = sub + "-" + teach + "(" + lab + ")";

                SqlCommand cmd;
                string op = "delete from temp where subject='" + sub + "'";
                con.Open();
                cmd = new SqlCommand(op, con);
                cmd.ExecuteNonQuery();
                con.Close();

            }
            else if (ty == "Lecture")
            {
                lec = sub + "-" + teach;
                SqlCommand cmd;
                string op = "delete from temp where subject='" + sub + "'";
                con.Open();
                cmd = new SqlCommand(op, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        if (ti == "12:00-12:30")
        {

            lec = "Break";


        }
        if (ti == "12:30-02:30")
        {

            if (ty == "Practical")
            {
                lab = upd(ti, grp,j);
                lec = sub + "-" + teach + "(" + lab + ")";


                SqlCommand cmd;
                string op = "delete from temp where subject='" + sub + "'";
                con.Open();
                cmd = new SqlCommand(op, con);
                cmd.ExecuteNonQuery();
                con.Close();


            }
            else if (ty == "Lecture")
            {
                lec = sub + "-" + teach;
                SqlCommand cmd;
                string op = "delete from temp where subject='" + sub + "'";
                con.Open();
                cmd = new SqlCommand(op, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }



        }
        if (ti == "02:30-02:45")
        {


            lec = "Break";



        }
        if (ti == "02:45-04:45")
        {


            if (ty == "Practical")
            {
                lab = upd(ti, grp,j);
                lec = sub + "-" + teach + "(" + lab + ")";


                SqlCommand cmd;
                string op = "delete from temp where  subject='" + sub + "'";
                con.Open();
                cmd = new SqlCommand(op, con);
                cmd.ExecuteNonQuery();
                con.Close();


            }
            else if (ty == "Lecture")
            {
                lec = sub + "-" + teach;
                SqlCommand cmd;
                string op = "delete from temp where subject='" + sub + "'";
                con.Open();
                cmd = new SqlCommand(op, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }


        }
        return lec;
    }





    string getlecB(string ti, string sub, string teach, string ty,int j)
    {
        string lab;
        string lec = "";
        string grp = "B";
        if (ti == "09:00-10:00")
        {
            if (ty == "Lecture")
            {
                lec = sub + "-" + teach;
                SqlCommand cmd;
                string op = "delete from tempB where subject='" + sub + "'";
                con.Open();
                cmd = new SqlCommand(op, con);
                cmd.ExecuteNonQuery();
                con.Close();

            }
        }
        if (ti == "10:00-12:00")
        {
            if (ty == "Practical")
            {

                lab = upd(ti, grp,j);
                lec = sub + "-" + teach + "(" + lab + ")";
                SqlCommand cmd;
                string op = "delete from tempB where subject='" + sub + "'";
                con.Open();
                cmd = new SqlCommand(op, con);
                cmd.ExecuteNonQuery();
                con.Close();

            }
            else if (ty == "Lecture")
            {

                lec = sub + "-" + teach;
                SqlCommand cmd;
                string op = "delete from tempB where subject='" + sub + "'";
                con.Open();
                cmd = new SqlCommand(op, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        if (ti == "12:00-12:30")
        {

            lec = "Break";


        }
        if (ti == "12:30-02:30")
        {

            if (ty == "Practical")
            {
                lab = upd(ti, grp,j);
                lec = sub + "-" + teach + "(" + lab + ")";
                SqlCommand cmd;
                string op = "delete from tempB where subject='" + sub + "'";
                con.Open();
                cmd = new SqlCommand(op, con);
                cmd.ExecuteNonQuery();
                con.Close();


            }
            else if (ty == "Lecture")
            {
                lec = sub + "-" + teach;
                SqlCommand cmd;
                string op = "delete from tempB where subject='" + sub + "'";
                con.Open();
                cmd = new SqlCommand(op, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }



        }
        if (ti == "02:30-02:45")
        {


            lec = "Break";



        }
        if (ti == "02:45-04:45")
        {


            if (ty == "Practical")
            {
                lab = upd(ti, grp,j);
                lec = sub + "-" + teach + "(" + lab + ")";
                SqlCommand cmd;
                string op = "delete from tempB where  subject='" + sub + "'";
                con.Open();
                cmd = new SqlCommand(op, con);
                cmd.ExecuteNonQuery();
                con.Close();


            }
            else if (ty == "Lecture")
            {
                lec = sub + "-" + teach;
                SqlCommand cmd;
                string op = "delete from tempB where subject='" + sub + "'";
                con.Open();
                cmd = new SqlCommand(op, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }


        }
        return lec;
    }

    void fill()
    {

        SqlDataAdapter da;
        DataSet ds = new DataSet();
        string m = "select cid,subject,teacher,type from courseA  where type='Lecture' order by newid()";
        da = new SqlDataAdapter(m, con);
        da.Fill(ds);
        string cid = "", subject = "", teacher = "", type = "";
        if (ds.Tables[0].Rows.Count > 0)
        {
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cid = ds.Tables[0].Rows[i][0].ToString();
                subject = ds.Tables[0].Rows[i][1].ToString();
                teacher = ds.Tables[0].Rows[i][2].ToString();
                type = ds.Tables[0].Rows[i][3].ToString();
                SqlCommand cmd;
                con.Open();
                string k = "insert into Temp values('" + cid + "','" + subject + "','" + teacher + "','" + type + "')";
                cmd = new SqlCommand(k, con);
                cmd.ExecuteNonQuery();
                con.Close();

            }

        }
    }
    void fillB()
    {
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        string m = "select cid,subject,teacher,type from courseB  where type='Lecture' order by newid()";
        da = new SqlDataAdapter(m, con);
        da.Fill(ds);
        string cid = "", subject = "", teacher = "", type = "";
        if (ds.Tables[0].Rows.Count > 0)
        {
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cid = ds.Tables[0].Rows[i][0].ToString();
                subject = ds.Tables[0].Rows[i][1].ToString();
                teacher = ds.Tables[0].Rows[i][2].ToString();
                type = ds.Tables[0].Rows[i][3].ToString();
                SqlCommand cmd;
                con.Open();
                string k = "insert into TempB values('" + cid + "','" + subject + "','" + teacher + "','" + type + "')";
                cmd = new SqlCommand(k, con);
                cmd.ExecuteNonQuery();
                con.Close();

            }

        }
    }
    Boolean checklab(string ti, int j, string teach)
    {

        Boolean chk = false;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        string op = "";
        if (j == 0)
        {
            op = "select slot,monday from TimeTable where slot='" + ti + "'";
        }
        if (j == 1)
        {
            op = "select slot,tuesday from TimeTable where slot='" + ti + "'";
        }
        if (j == 2)
        {
            op = "select slot,wednesday from TimeTable where slot='" + ti + "'";
        }
        if (j == 3)
        {
            op = "select slot,thursday from TimeTable where slot='" + ti + "'";
        }
        if (j == 4)
        {
            op = "select slot,friday from TimeTable where slot='" + ti + "'";
        }
        da = new SqlDataAdapter(op, con);
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            string teacher = ds.Tables[0].Rows[0][1].ToString();
            string[] ss = teacher.Split('-');
            foreach (string word in ss)
            {
                if (ss[0] != "Break")
                {
                    if (teach == ss[1])
                    {
                        chk = true;
                    }
                }
            }
        }
        return chk;
    }
    Boolean checkteach(string ti, int j, string teach)
    {

        Boolean chk = false;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        string op = "";
        if (j == 0)
        {
            op = "select slot,monday from TimeTable where slot='" + ti + "'";
        }
        if (j == 1)
        {
            op = "select slot,tuesday from TimeTable where slot='" + ti + "'";
        }
        if (j == 2)
        {
            op = "select slot,wednesday from TimeTable where slot='" + ti + "'";
        }
        if (j == 3)
        {
            op = "select slot,thursday from TimeTable where slot='" + ti + "'";
        }
        if (j == 4)
        {
            op = "select slot,friday from TimeTable where slot='" + ti + "'";
        }
        da = new SqlDataAdapter(op, con);
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0)
        {
            string teacher = ds.Tables[0].Rows[0][1].ToString();
            string[] ss = teacher.Split('-');
            foreach (string word in ss)
            {
                if (ss[0] != "Break")
                {
                    if (ss[1] != "")
                    {
                        if (teach == ss[1])
                        {
                            chk = true;
                        }
                    }
                }
            }
        }
        return chk;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.ClearContent();
        Response.Buffer = true;
        Response.AddHeader("content-disposition", string.Format("attachment; filename={0}", "Course-A-Time-Table.xls"));
        Response.ContentType = "application/ms-excel";
        DataTable dt = GetDatafromDatabase();
        string str = string.Empty;
        foreach (DataColumn dtcol in dt.Columns)
        {
            Response.Write(str + dtcol.ColumnName);
            str = "\t";
        }
        Response.Write("\n");
        foreach (DataRow dr in dt.Rows)
        {
            str = "";
            for (int j = 0; j < dt.Columns.Count; j++)
            {
                Response.Write(str + Convert.ToString(dr[j]));
                str = "\t";
            }
            Response.Write("\n");
        }
        Response.End();
    }
    protected DataTable GetDatafromDatabase()
    {
        DataTable dt = new DataTable();


        con.Open();
        SqlCommand cmd = new SqlCommand("Select slot,monday,tuesday,wednesday,thursday,friday from TimeTable", con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        con.Close();

        return dt;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.ClearContent();
        Response.Buffer = true;
        Response.AddHeader("content-disposition", string.Format("attachment; filename={0}", "Course-B-Time-Table.xls"));
        Response.ContentType = "application/ms-excel";
        DataTable dt = GetDatafromDatabase1();
        string str = string.Empty;
        foreach (DataColumn dtcol in dt.Columns)
        {
            Response.Write(str + dtcol.ColumnName);
            str = "\t";
        }
        Response.Write("\n");
        foreach (DataRow dr in dt.Rows)
        {
            str = "";
            for (int j = 0; j < dt.Columns.Count; j++)
            {
                Response.Write(str + Convert.ToString(dr[j]));
                str = "\t";
            }
            Response.Write("\n");
        }
        Response.End();
    }
    protected DataTable GetDatafromDatabase1()
    {
        DataTable dt = new DataTable();


        con.Open();
        SqlCommand cmd = new SqlCommand("Select slot,monday,tuesday,wednesday,thursday,friday from TimeTableB", con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        con.Close();

        return dt;
    }
}