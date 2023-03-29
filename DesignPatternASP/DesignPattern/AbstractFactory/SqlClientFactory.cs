using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace DesignPatternASP.DesignPattern.AbstractFactory
{
    public class SqlClientFactory : IDatabaseFactory
    {
        public DbCommand GetCommand()
        {
            return new SqlCommand();
        }

        public DbConnection GetConnection()
        {
            return new SqlConnection();
        }

        public DbParameter GetParameter()
        {
            return new SqlParameter();
        }
    }
}
