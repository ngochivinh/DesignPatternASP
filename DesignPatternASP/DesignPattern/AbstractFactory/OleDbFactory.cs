using System.Data.Common;
using System.Data.OleDb;

namespace DesignPatternASP.DesignPattern.AbstractFactory
{
    public class OleDbFactory : IDatabaseFactory
    {
        public DbCommand GetCommand()
        {
            return new OleDbCommand();
        }

        public DbConnection GetConnection()
        {
            return new OleDbConnection();
        }

        public DbParameter GetParameter()
        {
            return new OleDbParameter();
        }
    }
}
