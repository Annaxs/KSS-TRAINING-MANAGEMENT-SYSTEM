using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;
namespace WebApplication3
{
    public partial class day2form_login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            string qry = "select * from t_user_master where username = '" + username.Text + "' and u_password = '" + password.Text + "'";
            DBConnection objDBCOnnection = new DBConnection();
            DataTable dt = new DataTable();
            dt = objDBCOnnection.GetDataTable(qry);

            if (dt.Rows.Count > 0)
            {
                Response.Redirect("Home.aspx");

            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Alert", "alert('User Name or Password is wrong')", true);
            }



        }
    }
}