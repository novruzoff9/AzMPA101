# SQL Hospital management system
1. Aşağıdakı cədvəlləri yaradın:
    - `Doctors`
        - `Id` (primary key, auto-increment)
        - `Name` (maksimum 100 simvol)
        - `Specialization` (maksimum 100 simvol)
        - `Phone` (maksimum 15 simvol)
    - `Patients`
        - `Id` (primary key, auto-increment)
        - `Name` (maksimum 100 simvol)
        - `Age` (integer)
        - `Gender` (maksimum 10 simvol)
        - `Phone` (maksimum 15 simvol)
2. Hər iki cədvələ ən az 5-5 məlumat daxil edin.
3. Aşağıdakı SQL sorğularını yazın:
    - Bütün həkimləri və onların ixtisaslarını göstərin.
    - Bütün xəstələri və onların yaşlarını göstərin.
    - Həkimlərin adlarını və telefon nömrələrini göstərin.
    - Xəstələrin adlarını və cinslərini göstərin.
    - 30 yaşdan yuxarı olan xəstələrin adlarını və yaşlarını göstərin.
    - "Cardiology" ixtisasına sahib həkimlərin adlarını göstərin.