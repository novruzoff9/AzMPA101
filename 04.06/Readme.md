## Film Platforması:
1. `Movie` adında class yaradırıq:
    - Id (statik olaraq artacaq)
    - AverageRating (10 uzerinden hesablanacaq)
    - RatingsCount
    - Name
    - Duration (Müddət saxlayacaq)
    - Genre (enum) (dəyərlər 2-ci sualda var)
    - `Rate` adında metod olmalıdır. Bu metod parametr olaraq verilən reytinqi qəbul edəcək və `AverageRating`-i yeniləyəcək. `RatingsCount`-u da artıracaq.
2. `Genre` enum:
    - Action, Comedy, Horror
3. `IMovieService` interfeysi:
    - Movie nömrəsi qəbul edib, ona əsasən Movie-ı qaytaran metod
    - Ad qəbul edib, ona əsasən Movie-ı qaytaran metod
    - Siyahıya movie əlavə etmək üçün metod
4. `MovieService`
    - `Movie[]` massivi statik olaraq saxlayır ki, biz öz məlumatlarımızı saxlaya bilək
    - Siyahıdan `MovieId`-a görə movie qaytaran metod
    - Ad-a görə movie qaytaran metod
    - Massivə yeni movie əlavə edən metod. (Əgər eyni `Name` əlavə olunmağa çalışılarsa exception versin)
5. Extension metodlar
    - `IsHighlyRated()` metodu, əgər `AverageRating` 8.0-dan yuxarıdırsa `true`, əks halda `false` qaytaracaq.
    - `IsLongMovie()` metodu, əgər `Duration` 120 dəqiqədən çoxdursa `true`, əks halda `false` qaytaracaq.