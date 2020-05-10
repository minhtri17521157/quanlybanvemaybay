using System;
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
            conStr = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\SELL_PLANE_TICKET_DATABASE.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            //conStr = @"Data Source=DESKTOP-N6VGHVB\SQLEXPRESS;AttachDbFilename=|DataDirectory|\SELL_PLANE_TICKET_DATABASE.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        }
        public SqlConnection GetConnect()
        {
            return new SqlConnection(conStr);
        }
    }
}
