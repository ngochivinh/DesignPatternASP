using System.Collections;

namespace DesignPatternASP.DesignPattern.Iterator
{
    public class OrderEnumerator : IEnumerator<Order>
    {

        private OrderHistory history;
        public OrderEnumerator(OrderHistory history)
        {
            this.history = history;
        }

        public Order Current
        {
            get
            {
                Order currentOrder = new Order();
                currentOrder.OrderID = history.Cursor.GetInt32(0);
                currentOrder.CustomerID = history.Cursor.GetString(1);
                currentOrder.OrderDate = history.Cursor.GetDateTime(2);
                currentOrder.ShippedDate = history.Cursor.GetDateTime(3);
                return currentOrder;
            }
        }

        object IEnumerator.Current => Current1;

        public void Dispose()
        {
            if (history.Cursor != null && history.Cursor.IsClosed == false)
            {
                history.Cursor.Close();
            }

        }

        public bool MoveNext()
        {
            if (history.Cursor.IsClosed)
            {
                history.OpenCursor();
            }
            return history.Cursor.Read();
        }

        public void Reset()
        {
            history.Cursor.Close();
        }

        private object Current1
        {
            get
            {
                return Current;
            }
        }
    }
}
