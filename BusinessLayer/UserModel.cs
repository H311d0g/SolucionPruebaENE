﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class UserModel
    {
        UserConsult userConsult = new UserConsult();
        public bool UserLogin(string email, string clave)
        {
            return userConsult.Login(email, clave);
        }
    }
}
