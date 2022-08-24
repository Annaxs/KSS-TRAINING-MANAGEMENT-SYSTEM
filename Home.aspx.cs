using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace WebApplication3
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        DBConnection dBConnection = new DBConnection();
        DataTable dtUsermaster;
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int iRecordCount = dBConnection.GetDataTable("select * from t_user_master").Rows.Count+1;
            string qry = "insert into t_user_master values('"+txtUserName.Text+"','"+txtPwd.Text+"',"+iRecordCount+")";
            int iResultCount = dBConnection.ExecuteQuery(qry);
            if (iResultCount > 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Alert", "alert('Record Added')", true);

                dtUsermaster = dBConnection.GetDataTable("select * from t_user_master");
                GridView1.DataSource = dtUsermaster;
                GridView1.DataBind();
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Alert", "alert('check data')", true);

            }

           
        }
    }
}