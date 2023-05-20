using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login_Form1
{
    public partial class Default : System.Web.UI.Page
    {
        SqlConnection SQLConn = new SqlConnection("Data Source=DESKTOP-SF74HVS\\SQLEXPRESS; Initial Catalog=Login; Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            lblmsg.Text = "";
            SqlDataAdapter SQLAdapter = new SqlDataAdapter("Select * from LoginMst where username='" + txtusername.Text + "' and password='" + txtpassword.Text + "'", SQLConn);
            DataTable DT = new DataTable();
            SQLAdapter.Fill(DT);

            if (DT.Rows.Count > 0)
            {
                lblmsg.Text = "Welcome to System";
                lblmsg.ForeColor = System.Drawing.Color.Green;
            }

            else
            {
                lblmsg.Text = "Invalid username or password";
                lblmsg.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}