# SQL Hospital Management System (Aggregate Functions)
1. Aşağıdakı cədvəlləri yaradın:
    - `Doctor`
        - `Id` (primary key, auto-increment)
        - `Name` (maksimum 100 simvol)
        - `Specialty` (maksimum 100 simvol)
        - `Salary` (decimal)
        - `ExperienceYear` (int)
    - `Patient`
        - `Id` (primary key, auto-increment)
        - `Name` (maksimum 100 simvol)
        - `Age` (int)
        - `Gender` (maksimum 10 simvol)
        - `City` (maksimum 100 simvol)
    - `Appointment`
        - `Id` (primary key, auto-increment)
        - `DoctorName` (maksimum 100 simvol)
        - `PatientName` (maksimum 100 simvol)
        - `Fee` (decimal)
        - `VisitDate` (date)
        - `DurationMin` (int)

2. Hər cədvələ ən az 5-5 məlumat daxil edin.

3. Aşağıdakı aggregate function sorğularını yazın:
    - Bütün həkimlərin sayını göstərin (`COUNT`).
    - Həkim maaşlarının ortalamasını göstərin (`AVG`).
    - Ən yüksək və ən aşağı həkim maaşını göstərin (`MAX`, `MIN`).
    - Bütün qəbul ödənişlərinin cəmini göstərin (`SUM`).
    - Qəbul müddətinin orta dəyərini göstərin (`AVG`).
    - 30 yaşdan böyük pasiyentlərin sayını göstərin (`COUNT`, `WHERE`).