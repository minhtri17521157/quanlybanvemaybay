﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBVMB
{
    class DataConnection
    {
        string  conStr="";
        public DataConnection()
        {
            // conStr = @"Data Source =.\SQLEXPRESS; Initial Catalog=SELL_PLANE_TICKET_DATABASE; Integrated Security=True";DESKTOP-N6VGHVB\SQLEXPRESS SELL_PLANE_TICKET_DATABASE
            //conStr = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\SELL_PLANE_TICKET_DATABASE.mdf;Integrated Security=True;Connect Timeout=60;User Instance=True";
            //DESKTOP-N6VGHVB\SQLEXPRESS
            conStr = @"Data Source=DESKTOP-N6VGHVB\SQLEXPRESS;Initial Catalog=SELL_PLANE_TICKET_DATABASE;Integrated Security=True";

        }
        public SqlConnection GetConnect()
        {
            return new SqlConnection(conStr);
        }
    }
}
