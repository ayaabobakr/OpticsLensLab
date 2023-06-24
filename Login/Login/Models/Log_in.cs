using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Login.Models
{
    public class Log_in
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}