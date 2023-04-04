namespace DesignPatternASP.DesignPattern.Facade
{
    public class PriceCompareFacade
    {
        public async Task<List<Book>> Compare(string isbn)
        {
            ServiceAClient clientA = new ServiceAClient();
            Book bookA = await clientA.SearchBook(isbn);
            ServiceBClient clientB = new ServiceBClient();
            Book bookB = await clientB.SearchBook(isbn);
            List<Book> books = new List<Book>();
            books.Add(bookA);
            books.Add(bookB);
            books.Sort(delegate (Book b1, Book b2)
            {
                return b1.Price.CompareTo(b2.Price);
            });
            return books;
        }
    }
}
