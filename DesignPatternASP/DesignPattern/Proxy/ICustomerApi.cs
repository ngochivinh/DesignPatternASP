namespace DesignPatternASP.DesignPattern.Proxy
{
    public interface ICustomerApi
    {
        List<Customer> Get();
        Customer Get(string customerid);
        void Post(Customer customer);
        void Put(string customerid, Customer customer);
        void Delete(string customerid);
    }
}
