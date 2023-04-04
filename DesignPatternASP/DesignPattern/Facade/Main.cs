using Microsoft.AspNetCore.Mvc;

namespace DesignPatternASP.DesignPattern.Facade
{
    public class Main
    {
        public async Task<List<Book>> Search(string isbn)
        {
            PriceCompareFacade comparer = new PriceCompareFacade();
            List<Book> books = await comparer.Compare(isbn);
            return books;
        }
    }
}
