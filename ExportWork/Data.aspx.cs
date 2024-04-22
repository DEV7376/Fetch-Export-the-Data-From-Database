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
    public partial class Data : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Server=DIVYANSH\\SQLEXPRESS;Database=users;Trusted_Connection=True");
                SqlCommand cmd = new SqlCommand("EXEC [dbo].[GetData]", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "GetData");
                gdgetDetails.DataSource = ds;
                gdgetDetails.DataBind();
            } catch(Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void BtnExport_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Server=DIVYANSH\\SQLEXPRESS;Database=users;Trusted_Connection=True");
            SqlCommand cmd = new SqlCommand("EXEC [dbo].[GetData]", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd); 
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            string csv = string.Empty;

            foreach (DataColumn column in dt.Columns)
            {
                //Add the Header row for CSV file.
                csv += column.ColumnName + ',';
            }

            //Add new line.
            csv += "\r\n";

            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn column in dt.Columns)
                {
                    //Add the Data rows.
                    csv += row[column.ColumnName].ToString().Replace(",", ";") + ',';
                }

                //Add new line.
                csv += "\r\n";
            }

            //Download the CSV file.
            Response.Clear();
            Response.Buffer = true;
            Response.AddHeader("content-disposition", "attachment;filename=Getdetails.csv");
            Response.Charset = "";
            Response.ContentType = "application/text";
            Response.Output.Write(csv);
            Response.Flush();
            Response.End();
        }

        protected void BtnLogout_CheckedChanged(object sender, EventArgs e)
        {
            //Session.Abandon();
            //Session.Clear();
            
        }

        protected void BtnLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("loginpage.aspx");
        }
    }
}