using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Configuration;
using System.Runtime.Remoting.Contexts;
using System.Drawing;

namespace meat
{
    public partial class meat3 : System.Web.UI.Page
    {
        //SqlConnection o_sconn = new SqlConnection(ConfigurationManager.ConnectionStrings["betty"].ConnectionString);
        static string a = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog = master; Integrated Security = True;Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;User ID = sa;Password=betty618742.;";
        SqlConnection o_sconn = new SqlConnection(a);
        protected void Page_Load(object sender, EventArgs e)
        {

            
            string Date = Cdl.SelectedDates.ToString();

            

            try
            {
                SqlCommand sconn = new SqlCommand("SELECT * FROM reservations", o_sconn);
                o_sconn.Open();
                
                //Response.Write(a);
                o_sconn.Close();


            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
        }

        private void IsertData()
        {
            o_sconn.Open();
            string BigName = DL_big.SelectedItem.Value;
            // 大人數量
            int BigNum = Int32.Parse(BigName);
            string SmallName = DL_big.SelectedItem.Value;
            // 小孩數量
            int SmallNum = Int32.Parse(SmallName);
            string Date = Cdl.SelectedDates.ToString();

            SqlCommand scom = new SqlCommand("INSERT INTO reservations (Number, People, Date");
            //                                     "VALUES(@Number, @People, @Datetime)", o_sconn);

            scom.Parameters.Add("@Number", SqlDbType.Int);
            scom.Parameters["@Number"].Value = BigNum;
            scom.Parameters.Add("@People", SqlDbType.Int);
            scom.Parameters["@People"].Value = SmallNum;
           

            //o_sconn.Close();
        }

        protected void btn_completed_Click(object sender, EventArgs e)
        {
            IsertData();
        }
    }
}