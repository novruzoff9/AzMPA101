# Tədbir Bilet İdarəetmə Sistemi

1. `Ticket` adında class yaradılacaq:
	- `Id` (statik olaraq artacaq)
	- `EventName`
	- `HolderName`
	- `Type` (enum olacaq, aşağıda verilib)
	- `Price`
	- `PurchaseDate`

2. Enum:
	- `TicketType`: `Standard`, `VIP`, `Student`, `Backstage`, `Online`

3. İnterfeys: `ITicketService`
	- `Add(Ticket ticket)` -> bilet əlavə et 
	- `GetById(int id)` -> id-yə görə bilet qaytar
	- `GetAll()` -> bütün biletləri qaytar
	- `GetByType(TicketType type)` -> bilet növünə görə filter
	- `GetMostExpensiveTicket()` -> ən yüksək qiymətli bilet
	- `GetCheapestTicket()` -> ən az qiymətli bilet
	- `GetAveragePrice()` -> orta bilet qiyməti
	- `CountByType(TicketType type)` -> bilet növünə görə say
	- `GetByPriceRange(double min, double max)` -> qiymət aralığına görə filter
	- `UpdatePrice(int id, double newPrice)` -> biletin qiymətini yenilə
	- `UpdateAllPrices(double percentage)` -> bütün biletlərin qiymətini faizlə artır
	- `Remove(int id)` -> id-yə görə bilet sil

4. `TicketService` class-ı:
	- Daxildə statik `List<Ticket>` saxlasın
	- Eyni `EventName + HolderName` ilə bilet əlavə olunarsa `ConflictException` atılsın
	- Tapılmayan id üçün `NotFoundException` atılsın
