# Kitabxana İdarəetmə Sistemi

1. `Book` class yaradılacaq:
    - `Id` (statik olaraq artacaq)
    - `Title`
    - `Author`
    - `PageCount`
    - `Price`
    - `StockCount`
    - `Genre` (enum)
    - `CreatedAt` (default olaraq indiki vaxt)

2. Enum:
    - `Genre`: `Programming`, `Science`, `History`, `Novel`, `Other`

3. İnterfeys: `IBookService`
    - `Add(Book book)` -> kitab əlavə et
    - `GetById(int id)` -> id-yə görə kitab qaytar

4. `BookService` class-ı:
    - Daxildə statik `List<Book>` saxlasın
    - Eyni `Title` ilə kitab əlavə olunarsa `ConflictException` atılsın

5. Extension metodlar (`BookExtensions`):
    - `IsInStock(this Book book)`: stokda olub olmadığını yoxlasın
        `bool` qaytarsın
    - `ApplyDiscount(this Book book, double percent)`:
        qiyməti faiz qədər endirsin