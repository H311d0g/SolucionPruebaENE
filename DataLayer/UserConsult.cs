using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataLayer
{
    public class UserConsult:BD
    {
        public bool Login(string email, string clave)
        {
            BD obj = new BD();
            string Sql = "SELECT email, clave FROM usuario WHERE email=@vemail AND clave=@vclave";
            SqlCommand scmd = new SqlCommand(Sql, obj.OpenWith());
            scmd.Parameters.AddWithValue("@vemail", email);
            scmd.Parameters.AddWithValue("@vclave", clave);
            SqlDataReader reed = scmd.ExecuteReader();
            if(reed.Read()== true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
