using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExportWork
{
    public partial class loginpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Server=DIVYANSH\\SQLEXPRESS;Database=users;Trusted_Connection=True");
                SqlCommand cmd = new SqlCommand("Select * From loginData Where USERID=@userid and PASSWORD=@password ",conn);
                cmd.Parameters.AddWithValue("@userid",txtUser.Text);
                cmd.Parameters.AddWithValue("@password",txtPass.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "loginData");
                if(ds.Tables[0].Rows.Count ==0 )
                {
                    Response.Write("Invalid User");
                }
                else
                {
                    Response.Redirect("Data.aspx");
                    
                }

            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
        }
    }
}