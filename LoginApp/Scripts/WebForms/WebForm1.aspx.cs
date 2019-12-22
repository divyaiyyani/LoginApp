using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace LoginApp.Scripts.WebForms


{
    public partial class WebForm1 : System.Web.UI.Page
{
        
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        string connection = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
        SqlConnection con = new SqlConnection(connection);
           
        con.Open();
            Label1.Text = "Done";

        SqlCommand cmd = new SqlCommand("select * from Credentials where Username =@username and Password=@password", con);
        cmd.Parameters.AddWithValue("@username", TextBox1.Text);
        cmd.Parameters.AddWithValue("@password", TextBox2.Text);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
            Label1.Text = "Done";
        if (dt.Rows.Count > 0)

        {

                Label1.Visible = true;
                Label1.Text = "You are logged in!";

            }

        else

        {

            Label1.Visible = true;
            Label1.Text = "Wrong Details";
        }
    }

    }

}
