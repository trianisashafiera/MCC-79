using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnectivity
{
    class Connection
    {
        public static string connectionString = "Data Source=LAPTOP-KCLNIRVS; Database= db_hr2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public static SqlConnection connection = new SqlConnection(connectionString);

    }
}

