using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataLayer
{
    public class CustomerConsult:BD
    {
        public bool CustomerCS(string tipo_req, string descripcion, string prioridad, string responsable_req)
        {
            BD objCC = new BD();
            string SqlCC = "SELECT tipo_req, descripcion, prioridad, responsable_req FROM requerimiento";
            SqlCommand cmd = new SqlCommand(SqlCC, objCC.OpenWith());
            SqlDataReader reed = cmd.ExecuteReader();
            if (reed.Read())
            {
                return true;
            }
            else { return false; }
        }
    }
}
