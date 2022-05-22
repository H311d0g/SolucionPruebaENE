using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class CustomerModel
    {
        CustomerConsult csConsult = new CustomerConsult();
        public bool Consult(string tipo_req, string descripcion, string prioridad, string responsable_req)
        {
            return csConsult.CustomerCS(tipo_req, descripcion, prioridad, responsable_req);
        }
    }
}
