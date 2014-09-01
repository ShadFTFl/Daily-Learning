using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace HRAppDesktopVersion
{
    class DbGateway
    {
        public SqlConnection SqlConnection { get; private set; }
        public SqlCommand SqlCommand { get; private set; }

        public DbGateway()
        {
            SqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["HrAppDbConnection"].ConnectionString);
            SqlCommand = new SqlCommand {Connection = SqlConnection};
        }
    }
}
