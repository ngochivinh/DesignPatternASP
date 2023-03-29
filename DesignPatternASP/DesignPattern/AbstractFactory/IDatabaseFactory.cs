using System.Data.Common;

namespace DesignPatternASP.DesignPattern.AbstractFactory
{
    public interface IDatabaseFactory
    {
        DbConnection GetConnection();
        DbCommand GetCommand();
        DbParameter GetParameter();
    }
}
