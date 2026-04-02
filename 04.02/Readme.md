## Task idarəetmə sistemi
1. `MyTask` adında class yaradılacaq
    - Id 
    - Başlıq
    - İzahat
    - Created
    - DeadLine (tarix və saat olaraq)
    - TaskStatus
    - `Id` dəyəri Constructor vasitəsilə statik olaraq artırılaraq veriləcək, `Created` dəyəri constructor-da hazırki vaxtı göstərəcək.
    - `ToString()` override edilməli
2. `ITaskService` interfeysi yaradırıq
    - 3.1. Siyahıya Task əlavə etmək üçün metod. (eyni başlıqlı Task artırılsa konsolda xeta mesaji gosterecek)
    - 3.2 Title-a görə Siyahıdan task-i tapan metod
    - 3.3 Göndərilən Status-da olan task-ları tapan metod
    - 3.4 Göndərilən Id-də olan elementi siyahıdan silmək üçün metod
3. `TaskService` class-ı yaradırıq
    - Task-lar üçün statik Massiv saxlayır özündə
    - 3.1-deki tapsirigda Siyahıya Task əlavə etmək üçün metodda eyni başlıqlı Task artırılsa konsolda xeta mesaji gosterecek
    - 3.2 -deki Title-a görə Siyahıdan task-i tapan metod-da eger hec bir task tapilmasa konsolda mesaj göstərəcək
    - 3.4 -də göndərilən Id-də element tapılmasa konsolda mesaj göstərəcək
4. Extension metodlar `TaskHelper` class-ı
    - Task-ın bitməyinə nə qədər müddət qaldığını qaytaran metod
    - Task üçün nə qədər vaxt ayrıldığını göstərən metod

