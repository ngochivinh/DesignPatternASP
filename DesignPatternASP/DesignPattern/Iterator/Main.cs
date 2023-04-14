using Microsoft.AspNetCore.Mvc;

namespace DesignPatternASP.DesignPattern.Iterator
{
    public class Main
    {
        public List<Order> Index()
        {
            OrderHistory history = new OrderHistory(true);
            List<Order> orders = new List<Order>();
            foreach (Order o in history)
            {
                orders.Add(o);
            }
            return (orders);
        }
    }
}
