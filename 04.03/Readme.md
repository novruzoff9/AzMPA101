## Kart Sistemi:
1. `Card` adında class yaradırıq:
    - Id (statik olaraq artacaq)
    - Balance
    - Bonus
    - CardNumber (mütləq 16 rəqəmdən ibarət olmalıdır)
    - Bank (enum) (dəyərlər 3-cü sualda var)
    - Kartdan pul çıxılması üçün bir `WithDraw` adında abstrakt metod olmalıdır. Bu metod parametr olaraq çıxılacaq məbləği qəbul edəcək. Və əgər proeses uğurla tamamlanarsa, `true` əks halda `false` dəyəri qaytaracaq.
2. `Bank` enum:
    - ABB, Kapital, Leo
3. `ICardService` interfeysi:
    - Card nömrəsi qəbul edib, ona əsasən Card-ı qaytaran metod
    - Siyahıya kart əlavə etmək üçün metod
4. `CardService`
    - `Card[]` massivi statik olaraq saxlayır ki, biz öz məlumatlarımızı saxlaya bilək
    - Siyahıdan `CardNumber`-a görə kartı qaytaran metod
    - Massivə yeni kart əlavə edən metod. (Əgər eyni `CardNumber` əlavə olunmağa çalışılarsa xeta mesaji gostersin)
5. Extension metodlar
    - `MaskCardNumber()` bu metod kart-ın nömrəsini gizləyərək `1234 **** **** 5678` formatında qaytaracaq
    - `ExpenseWithBonus()` metodu, özlüyündə xərclənən məbləği qəbul edəcək. Kartın bu ödənişi edib, edə bilməyəcəyini yoxlandıqdan sonra kartın hansı bank-a aid olmasına görə onun `Bonus` property-sinin dəyərini artıracaq. Bonuslar belədir:
        - `Abb` kartı üçün 2%
        - `Leo` kartı üçün 4%
        - `Kapital` kartı üçün 5%

6. Extra:  Transactions:
    1. `Transaction` adında class yaradılmalıdır:
        - Id
        - CardNumber
        - Amount
        - Date
        - `ToString` metodunun override olunması
    2. `ITransactionService`
        - `GetAll` metodu
        - Tranzaksiya artırma metodu
        - Kartın tranzaksiyalarını gətirən metod
        - Verilən tarix aralığındakı tranzaksiyaları göstərən metod
    3. `TransactionService`
        Data folderi içində `transactions.json` faylı olacaq ki, tranzaksiyalar orada saxlansın
        - Standart GetAll
        - Tranzaksiya artırma metodu, bir tranzkaisyan; həmin json faylına əlavə edəcək. Bu metod `WithDraw` və `ExpenseAndGetBonus` metodları zamanı işə düşəcək
        - Kartın nömrəsinə görə onun tranzaksiyalarını gətirsin
        - 2 fərqli tarix verilməlidi. həmin tarix aralığına uyğun gələn tranzaksiyanı göstərsin