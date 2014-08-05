using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class AutoExtendControl : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        /*Data Source=RAGHU\SQLEXPRESS;Initial Catalog="Sangam Trust";Integrated Security=True*/

    }
    //myfristbranch

    [System.Web.Script.Services.ScriptMethod()]
    [System.Web.Services.WebMethod]
    public static List<string> GetNamesList(string prefixText)
    {
        SqlConnection con = new SqlConnection("Data Source=RAGHU\\SQLEXPRESS;Initial Catalog=Sangam Trust;Integrated Security=True");
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from StudentData where StudentName like @StudentName+'%'",con);
        cmd.Parameters.AddWithValue("@StudentName", prefixText);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        List<string> StudentNames = new List<string>();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            StudentNames.Add(dt.Rows[i][1].ToString());
        }
        return StudentNames;
    }
    protected void btnCheck_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=RAGHU\\SQLEXPRESS;Initial Catalog=Sangam Trust;Integrated Security=True");
        con.Open();
        // SqlCommand myCommand = new SqlCommand("select * from customer_registration where username='" + Session["username"] + "'", con1);

        SqlCommand cmd = new SqlCommand("select * from StudentData where StudentName='"+txtStudentName.Text+"'",con);
        
        //cmd.CommandText = "select * from StudentData where StudentName=" + txtStudentName.Text;
        //cmd.Connection = con;
        SqlDataReader rdr;
        rdr = cmd.ExecuteReader();
        bool temp = false;
        while (rdr.Read())
        {
            temp = true;
        }
        if (temp == true)
        {

            //MessageBox.Show("Name Exist");
            Label1.Text = "Name Exists";
        }
        else
        {
            Label1.Text = "Name doesn't Exists";
        }
    }
}