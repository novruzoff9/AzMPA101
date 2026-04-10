using System.Runtime.CompilerServices;

namespace _04._08
{
    internal static class BookExtensions

    {
        public static bool  IsInStock (this Book book )
        {
            return book.StockCount > 0;
        }
    }
}
