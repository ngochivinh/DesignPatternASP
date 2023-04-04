using Microsoft.AspNetCore.Mvc;

namespace DesignPatternASP.DesignPattern.Proxy
{
    public class ServiceController : Controller, ICustomerApi
    {
        [HttpDelete("{customerid}")]
        public void Delete(string customerid)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public List<Customer> Get()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{customerid}")]
        public Customer Get(string customerid)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public void Post(Customer customer)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{customerid}")]
        public void Put(string customerid, [FromBody]Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
