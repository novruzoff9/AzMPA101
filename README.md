# AzMPA101 — Praktika Tapşırıqları

Bu repository **AzMPA101** qrupunun dərslərində işlənmiş praktika tapşırıqlarını əhatə edir. Mövzular C# əsaslarından başlayaraq SQL, Frontend (HTML/CSS/JS) və ASP.NET Core (MVC və Web API) mərhələlərinə qədər ardıcıl şəkildə düzülüb.

## İstifadə olunan texnologiyalar

- **C# / .NET 8** — konsol tətbiqləri və veb layihələr
- **ASP.NET Core MVC** — Controller, View, Area, ViewModel
- **ASP.NET Core Web API** — REST API, DTO, Identity, JWT
- **Entity Framework Core** — Code First, Migrations, SQL Server
- **MS SQL Server / T-SQL** — cədvəllər, əlaqələr, aggregate funksiyalar
- **HTML / CSS / Bootstrap** — səhifə quruluşu və dizayn
- **JavaScript** — DOM, event-lər, Fetch API
- Köməkçi kitabxanalar: **AutoMapper**, **FluentValidation**, **Swagger**

## Qovluq strukturu

Tarixlə adlanan qovluqlar (`AA.GG` formatında) həmin günün dərs tapşırığını saxlayır. Əksər qovluqlarda tapşırığın şərtini izah edən öz `Readme.md` faylı var.

### C# əsasları (konsol tətbiqləri)

| Qovluq | Mövzu |
|--------|-------|
| [03.04](03.04/) | Şərt operatorları (`if / else if / else`) |
| [03.05](03.05/) | Dövrlər (`for`, `while`) |
| [03.06](03.06/) | String-lər üzərində dövrlə işləmə |
| [03.10](03.10/) | `while` ilə ədəd məsələləri (2-nin qüvvəti, mərtəbə sayı və s.) |
| [03.12](03.12/) | Metodlar (parametrlər, qaytarma dəyəri) |
| [03.13](03.13/) | Massivlər və string metodları |

### OOP (Obyektyönümlü proqramlaşdırma)

| Qovluq | Mövzu |
|--------|-------|
| [03.16](03.16/) | Class, property, constructor — *SmartPhone sistemi* |
| [03.17](03.17/) | Inheritance, `virtual` / `override` — *Nəqliyyat sistemi* |
| [03.31](03.31/) | Inheritance və Encapsulation — *Məktəb idarəetmə sistemi* |
| [04.01](04.01/) | Abstract class — *Restoran simulyasiyası* |
| [04.02](04.02/) | Interface və service pattern — *Task idarəetmə sistemi* |
| [04.03](04.03/) | Interface, service, helper class-lar — *Kart sistemi* |
| [04.06](04.06/) | Enum, extension metodlar — *Film platforması* |
| [04.07](04.07/) | Enum və class əlaqələri — *Karqo sistemi* |
| [04.08](04.08/) | Custom exception-lar — *Kitabxana idarəetmə sistemi* |
| [04.10](04.10/) | Service qatı ilə CRUD — *İşçi idarəetmə sistemi* |
| [04.14](04.14/) | *Tədbir bileti idarəetmə sistemi* |
| [04.20](04.20/) | Lab tapşırığı — *Bilet sistemi* |

### SQL

| Qovluq | Mövzu |
|--------|-------|
| [04.15](04.15/) | Cədvəllərin yaradılması və əlaqələr — *Hospital Management System* |
| [04.16](04.16/) | Aggregate funksiyalar — *Hospital Management System* |
| [04.17](04.17/) | Çox-çoxa əlaqələr və sorğular — *Musiqi platforması* |

### Frontend (HTML / CSS / JavaScript)

| Qovluq | Mövzu |
|--------|-------|
| [04.21](04.21/) | HTML əsasları |
| [04.22](04.22/) | CSS, `position` xüsusiyyətləri |
| [04.23](04.23/) | Bootstrap və şriftlər (fonts) |
| [04.24](04.24/) | JavaScript — DOM və input-larla iş |
| [04.27](04.27/) | Event listener-lər və Fetch API ilə CRUD |

### ASP.NET Core layihələri

| Layihə | Mövzu |
|--------|-------|
| [MVCIntro2](MVCIntro2/) | MVC-yə giriş, EF Core və ilk migration |
| [05.04](05.04/) | MVC layihəsi — Controller, View, DbContext, service qatı, migrations |
| [Pronia](Pronia/) | MVC — Admin area, məhsul üzərində CRUD əməliyyatları |
| [logis](logis/) | MVC — Admin area, ViewModel-lər |
| [Axis](Axis/) | MVC — Admin area, fayl yükləmə (`FileService`), ViewModel-lər |
| [AzMPA101Api](AzMPA101Api/) | Web API — Identity, JWT autentifikasiya, DTO, AutoMapper, FluentValidation, Swagger |

## Layihələri işə salmaq

Konsol tətbiqləri üçün:

```bash
cd 03.16/03.16
dotnet run
```

Veb layihələr (MVC / API) üçün:

```bash
cd Pronia/Pronia
dotnet run
```

Verilənlər bazası istifadə edən layihələrdə əvvəlcə `appsettings.json` faylındakı connection string-i öz SQL Server instansınıza uyğunlaşdırın və migration-ları tətbiq edin:

```bash
dotnet ef database update
```

> **Qeyd:** `AzMPA101Api` layihəsi işə düşdükdən sonra Swagger UI vasitəsilə (`/swagger`) endpoint-ləri test etmək mümkündür.
