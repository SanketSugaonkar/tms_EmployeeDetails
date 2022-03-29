//using System.Data;
//using System.Configuration;
//using System.Data.SqlClient;



using Microsoft.Data.SqlClient;
using WebApplication1.Models;
namespace WebApplication1.Models
{
    public class db
    {
        SqlConnection con = new SqlConnection("Server=tcp:nitorserver.database.windows.net,1433;Initial Catalog=NitorDb;Persist Security Info=False;User ID=Sanket;Password=Nitor1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");


        public int LoginCheck(Ad_login ad)
        {
            SqlCommand cmd = new SqlCommand("SP_Login", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Admin_id", ad.Admin_Id);
            cmd.Parameters.AddWithValue("@Password", ad.Ad_Password);

            SqlParameter oblogin = new SqlParameter();
            oblogin.ParameterName = "@IsValid";
            oblogin.SqlDbType = System.Data.SqlDbType.Bit;
            oblogin.Direction = System.Data.ParameterDirection.Output;
            cmd.Parameters.Add(oblogin);
            con.Open();
            cmd.ExecuteNonQuery();
            int res = Convert.ToInt32(oblogin.Value);
            con.Close();
            return res;
        }
    }
}
