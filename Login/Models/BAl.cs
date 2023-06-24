using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Login.Models
{
    public class BAl
    {
        public string GetLogin(Log_in login)
        {
            DAL dal = new DAL();
            string response = dal.GetLogin(login);
            return response;
        }

    }
}