

namespace _04._08
{
    internal class BookService : IBookService
    {
        private static List<Book> books = []; 
        public void Add(Book book)
        {
            foreach (var item in books)
            {
                if (item.Title == book.Title)
                    throw new ConfilctException();
            }
            books.Add(book);
        }

        public Book GetById(int id)
        {
            foreach (var item in books)
            {
                if (item.Id == id)
                    return item;                    
            }
            Console.WriteLine("Tapilmadi");
            return null;
        }
    }
}
