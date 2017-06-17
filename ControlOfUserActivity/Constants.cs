using System;
using System.Data.SqlClient;

namespace ControlOfUserActivity
{
    public class Constants
    {
        public static int UserId { get; set; }

        public static bool IsAdmin { get; set; }

        public static string ConnectionString => @"Data Source=.;Initial Catalog=Project;Integrated Security=True";

        public static SqlConnection GetOpenConnection(bool mars = false)
        {
            var cs = Constants.ConnectionString;
            if (mars)
            {
                var scsb = new SqlConnectionStringBuilder(cs)
                {
                    MultipleActiveResultSets = true
                };
                cs = scsb.ConnectionString;
            }

            try
            {
                var connection = new SqlConnection(cs);
                connection.Open();
                return connection;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
