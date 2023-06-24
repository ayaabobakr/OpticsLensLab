using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI.WebControls;
using System.Runtime.Remoting.Messaging;


namespace Login.Models
{
    public class DAL
    {

        public string GetLogin(Log_in login)
        {
            string connstring = "server=mssql-132712-0.cloudclusters.net,10130; uid=admin; pwd=#Sahar2023; database=Gimpses";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connstring;
            con.Open();
            String sql = "SELECT username, password FROM Receptionist WHERE username='" + login.UserName + "' And password='" + login.Password + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0)
                { return "Logged In Successfully"; }
            else
            { return "Log In Failed"; }
            
        }
    }
}