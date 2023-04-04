using Newtonsoft.Json;
using System.Diagnostics.Eventing.Reader;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json.Serialization;

namespace DesignPatternASP.DesignPattern.Facade
{
    public class ServiceAClient
    {
        public async Task<Book> SearchBook(string isbn) 
        { 
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://serviceA");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await client.GetAsync("/api/ServiceA/" + isbn);
            string jsonData = await response.Content.ReadAsStringAsync();
            Book book = JsonConvert.DeserializeObject<Book>(jsonData);
            return book;
        }
    }
}
