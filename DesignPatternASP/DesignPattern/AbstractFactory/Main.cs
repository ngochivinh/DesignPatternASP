using System.Data.Common;
using System.Reflection;
using System.Runtime.Remoting;

namespace DesignPatternASP.DesignPattern.AbstractFactory
{
    public class Main
    {
        public dynamic ExecuteQuery(string query)
        {
            IDatabaseFactory factory = null;
            //string factorytype = AppSettings.Factory;
            //if (factorytype == "sqlclient")
            //{
            //    factory = new SqlClientFactory();
            //}
            //else
            //{
            //    factory = new OleDbFactory();
            //}

            string factorytype = AppSettings.FactoryType;
            ObjectHandle o = Activator.CreateInstance(Assembly.GetExecutingAssembly().FullName, factorytype);
            factory = (IDatabaseFactory)o.Unwrap();
            DatabaseHelper helper = new DatabaseHelper(factory);
            query = query.ToLower();
            if (query.StartsWith("select"))
            {
                DbDataReader reader = helper.ExecuteSelect(query);
                return reader ;
            }
            else
            {
                int i = helper.ExecuteAction(query);
                return i;
            }
        }
    }
}
