using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace DesignPatternASP.DesignPattern.Facade
{
    public class ServiceBClient
    {
        public async Task<Book> SearchBook(string isbn)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:49905");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue
            ("application/json"));
            HttpResponseMessage response = await client.GetAsync("/api/ServiceB/" + isbn);
            string jsonData = await response.Content.ReadAsStringAsync();
            Book book = JsonConvert.DeserializeObject<Book>(jsonData);
            return book;
        }
    }
}
