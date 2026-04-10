using _04._08;

Book book = new Book() { Title = "Xosrov ve Shirin", Author = "Nizami Gencevi" };
Book book1 = new Book() { Title = "Nihat", Author = "Nizami Gencevi" };

BookService bookService = new BookService();
bookService.Add(book);
bookService.Add(book1);
Console.WriteLine(bookService.GetById(2).Author);
book1.StockCount = 5;
Console.WriteLine(book1.IsInStock());