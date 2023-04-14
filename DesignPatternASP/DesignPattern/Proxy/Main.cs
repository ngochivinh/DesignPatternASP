using Microsoft.AspNetCore.Mvc;

namespace DesignPatternASP.DesignPattern.Proxy
{
    public class Main
    {
        public List<Customer> GetCustomers()
        {
            ServiceProxy proxy = new ServiceProxy();
            var data = proxy.Get();
            return data;
        }

        public Customer Update(string id)
        {
            ServiceProxy proxy = new ServiceProxy();
            Customer data = proxy.Get(id);
            return (data);
        }
    }
}
