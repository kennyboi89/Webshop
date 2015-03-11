using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webshop
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                string connectionString = "Data Source=.\\sqlexpress; initial catalog=Ken; user id=sa; password=Sql2005$;";
                SqlConnection con = new SqlConnection(connectionString);
                string bruker = txtUser.Text;
                string pass = txtPass.Text;
                string spr = "Select * from Ken.Login WHERE username='";
                SqlCommand com = new SqlCommand("select * from login where username='" + bruker + "'" + "AND password='" + pass + "'", con);
                con.Open();
                SqlDataReader reader;
                reader = com.ExecuteReader();

                int count = 0;
                while (reader.Read())
                {
                    count = count + 1;
                }

                if (count == 1)
                {
                    lbl2.Text = "riktig bruker";

                }

                else if (count > 1)
                {
                    lbl2.Text = "duplikat feil";
                }
                else
                    lbl2.Text = "feil bruker/passord";
                con.Close();




            }

            catch
            {
                lbl1.Text = "Kunne ikke koble til";
            }
        }
    }
}