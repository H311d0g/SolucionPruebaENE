using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public class BD
    {
        SqlConnection conn = new SqlConnection(@"Data Source= DESKTOP-M51EKPM\SQLEXPRESS; initial catalog= PRUEBAENE; User ID= sa; Password= h4ckth1s");
        public SqlConnection OpenWith()
        {
            conn.Open();
            return conn;
        }
        public SqlConnection CloseWith()
        {
            conn.Close();
            return conn;
        }
    }
}
