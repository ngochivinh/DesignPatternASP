using DesignPatternASP.DesignPattern.AbstractFactory;
using DesignPatternASP.SOLID.ISP;
using Microsoft.Data.SqlClient;
using System.Collections;
using System.Data;

namespace DesignPatternASP.DesignPattern.Iterator
{
    public class OrderHistory : IEnumerable<Order>
    {
        public SqlDataReader Cursor { get; set; }

        public OrderHistory(bool openImmediately) 
        {
            if (openImmediately)
            {
                this.OpenCursor();
            }
        }

        public void OpenCursor() 
        {
            SqlConnection cnn = new SqlConnection(AppSettings.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select OrderID,CustomerID,OrderDate,ShippedDate from orders where shippeddate is not null order by orderdate";
            cnn.Open();
            this.Cursor = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public IEnumerator<Order> GetEnumerator()
        {
            return new OrderEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator1();
        }

        private IEnumerator GetEnumerator1()
        {
            return this.GetEnumerator();
        }
    }
}
