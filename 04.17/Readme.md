# Musiqi Platforması
1. Aşağıdakı table-lar olacaq:
    - `Artist`
        - `Id` (primary key, auto-increment)
        - `Name` (maksimum 100 simvol)
        - `Nationality` (maksimum 50 simvol)
    - `Album`
        - `Id` (primary key, auto-increment)
        - `Title` (maksimum 100 simvol)
        - `ReleaseYear` (int)
        - `ArtistId` (int, foreign key referencing Artist(Id))
    - `Track`
        - `Id` (primary key, auto-increment)
        - `Title` (maksimum 100 simvol)
        - `DurationSec` (int)
        - `AlbumId` (int, foreign key referencing Album(Id))
2. Hər cədvələ ən az 5-5 məlumat daxil edin.
3. Aşağıdakı sorğuları yazın:
    - Hər bir albumu artisinin adı ilə birlikdə göstərin
    - Hər bir track-in adını və onun aid olduğu albumun adını göstərin
    - Hər bir track-in adını və o albumun artistinin adını göstərin
    - 2000-ci ildən sonra çıxan albomlardakı track-lərin adlarını göstərin
    - Hər bir track-in adını və onun aid olduğu albumun adını göstərin, yalnız track-lərin müddəti 240 saniyədən az olanları daxil edin.
4. Aşağıdakı view-ları yaradın:
    - `ArtistAlbums` view-u, hər bir artistin adını və onun albomlarının adlarını göstərin.
    - `AlbumTracks` view-u, hər bir albumun adını və onun track-lərinin adlarını göstərin.
    - `TrackDetails` view-u, hər bir track-in adını, onun aid olduğu albumun adını və o albumun artistinin adını göstərin.
5. Aşağıdakı stored procedure-ları yaradın:
    - `GetArtistAlbums` stored procedure-u, bir artistin adını parametr olaraq qəbul edir və o artistin albomlarının adlarını qaytarır.
    - `GetAlbumTracks` stored procedure-u, bir albumun adını parametr olaraq qəbul edir və o albumun track-lərinin adlarını qaytarır.
    - `GetTrackDetails` stored procedure-u, bir track-in adını parametr olaraq qəbul edir və o track-in aid olduğu albumun adını və o albumun artistinin adını qaytarır.