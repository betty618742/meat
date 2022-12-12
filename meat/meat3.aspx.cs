using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace meat
{
    public partial class meat3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s_com = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;" +
                "Integrated Security=True;Connect Timeout=30;Encrypt=False;" +
                "TrustServerCertificate=False;ApplicationIntent=ReadWrite;" +
                "MultiSubnetFailover=False;" +
                "User ID=sa; Password=betty618742.";
            try
            {
                SqlConnection scon = new SqlConnection(s_com);
                SqlCommand scom = new SqlCommand("SELECT * FROM reservations", scon);
                scon.Open();
                string c = DL.SelectedItem.Value;
                int a = Int32.Parse(c);
                Response.Write(a);
                scon.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
        }
    }
}