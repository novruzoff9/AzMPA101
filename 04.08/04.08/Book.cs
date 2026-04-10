

namespace _04._08
{
    internal class Book
    {
        private static int IdCounter = 0;

        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public Genre Genre { get; set; }
        public int Pagecounter { get; set; }
        public int Price { get; set; }
        public int StockCount { get; set; }
        public DateTime CreatedAt { get; set; }

        public Book()
        {
            Id = ++IdCounter;
            CreatedAt = DateTime.Now;
        }





    }
}
