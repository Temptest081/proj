-- 1. Create collab table if not exists
IF OBJECT_ID('dbo.collab', 'U') IS NULL
BEGIN
    CREATE TABLE [dbo].[collab]
    (
        [Id] INT NOT NULL PRIMARY KEY, 
        [Time] TIME NULL, 
        [Systolic] NVARCHAR(MAX) NULL, 
        [Diastolic] NVARCHAR(MAX) NULL, 
        [heartbeat] NVARCHAR(MAX) NULL, 
        [Temp] NVARCHAR(MAX) NULL, 
        [RespiratoryRate] NVARCHAR(MAX) NULL, 
        [EmergencyContact] NVARCHAR(MAX) NULL, 
        [Name] NVARCHAR(MAX) NULL, 
        [Relationship] NVARCHAR(MAX) NULL, 
        [Symptoms] NVARCHAR(MAX) NULL, 
        [Allergies] NVARCHAR(MAX) NULL, 
        [PastMedicalCondition] NVARCHAR(MAX) NULL, 
        [TakingMedication] NVARCHAR(MAX) NULL, 
        [Surgeries] NVARCHAR(MAX) NULL, 
        [Vape,Smoke,Drink] VARCHAR(MAX) NULL, 
        [gottenbetter] VARCHAR(MAX) NULL, 
        [Inheritable] VARCHAR(MAX) NULL, 
        [affectbody] VARCHAR(MAX) NULL, 
        [Vaccination] VARCHAR(MAX) NULL, 
        [FonlylastPeriod] VARCHAR(MAX) NULL, 
        [Thinkmightbepregnant] VARCHAR(MAX) NULL, 
        [Phone] VARCHAR(MAX) NULL, 
        [Address] VARCHAR(MAX) NULL, 
        [Email] VARCHAR(MAX) NULL, 
        [Gender] VARCHAR(MAX) NULL, 
        [Nationality] VARCHAR(MAX) NULL, 
        [Occupation] VARCHAR(MAX) NULL, 
        [Status] VARCHAR(MAX) NULL, 
        [DateofBirth] DATE NULL, 
        [Pic] IMAGE NULL,
        [AppointmentDate] DATE NULL
    );
    PRINT 'Table [collab] created.';
END
ELSE
    PRINT 'Table [collab] already exists.';

-- 2. Create users table if not exists
IF OBJECT_ID('dbo.users', 'U') IS NULL
BEGIN
    CREATE TABLE users (
        Id INT PRIMARY KEY IDENTITY(1,1),
        IdNumber VARCHAR(50) NOT NULL,
        Password VARCHAR(100) NOT NULL,
        Role VARCHAR(20) NOT NULL
    );
    PRINT 'Table [users] created.';
END
ELSE
    PRINT 'Table [users] already exists.';

-- 3. Insert collab sample data only if that Id doesn't exist
IF NOT EXISTS (SELECT 1 FROM collab WHERE Id = 1)
INSERT INTO collab (Id, Time, Systolic, Diastolic, heartbeat, Temp, RespiratoryRate, EmergencyContact, Name, Relationship,
    Symptoms, Allergies, PastMedicalCondition, TakingMedication, Surgeries, [Vape,Smoke,Drink], gottenbetter, Inheritable, affectbody,
    Vaccination, FonlylastPeriod, Thinkmightbepregnant, Phone, Address, Email, Gender, Nationality, Occupation, Status, DateofBirth, AppointmentDate)
VALUES (1, '09:30:00', '120', '80', '72', '36.6', '18', 'Anna Lopez', 'John Cruz', 'Wife', 'Mild fever, dry cough', 'None', 'Asthma', 'Salbutamol inhaler', 'Appendectomy in 2010', 'No', 'Stayed the same', 'Yes, asthma from mother', 'Some fatigue during work', 'Up-to-date', NULL, NULL, '09171234567', '123 Main St, Quezon City', 'johncruz@email.com', 'Male', 'Filipino', 'Engineer', 'Single', '1990-05-12', NULL);

IF NOT EXISTS (SELECT 1 FROM collab WHERE Id = 2)
INSERT INTO collab (Id, Time, Systolic, Diastolic, heartbeat, Temp, RespiratoryRate, EmergencyContact, Name, Relationship,
    Symptoms, Allergies, PastMedicalCondition, TakingMedication, Surgeries, [Vape,Smoke,Drink], gottenbetter, Inheritable, affectbody,
    Vaccination, FonlylastPeriod, Thinkmightbepregnant, Phone, Address, Email, Gender, Nationality, Occupation, Status, DateofBirth, AppointmentDate)
VALUES (2, '11:00:00', '150', '95', '85', '37.0', '20', 'Luis Ramos', 'Maria Ramos', 'Daughter', 'Dizziness, blurred vision', 'Penicillin', 'Hypertension', 'Amlodipine', 'Cataract surgery (2018)', 'No', 'Worsened', 'Yes, heart disease in family', 'Hard to walk longer distances', 'Not updated', NULL, NULL, '09180001122', '456 Sunrise Blvd, Pasig City', 'mariaramos@email.com', 'Male', 'Filipino', 'Retired', 'Widowed', '1955-07-22', NULL);

IF NOT EXISTS (SELECT 1 FROM collab WHERE Id = 3)
INSERT INTO collab (Id, Time, Systolic, Diastolic, heartbeat, Temp, RespiratoryRate, EmergencyContact, Name, Relationship,
    Symptoms, Allergies, PastMedicalCondition, TakingMedication, Surgeries, [Vape,Smoke,Drink], gottenbetter, Inheritable, affectbody,
    Vaccination, FonlylastPeriod, Thinkmightbepregnant, Phone, Address, Email, Gender, Nationality, Occupation, Status, DateofBirth, AppointmentDate)
VALUES (3, '14:15:00', '115', '75', '78', '36.9', '19', 'Karen Tan', 'Ella Tan', 'Mother', 'Nausea, missed period', 'None', 'None', 'None', 'None', 'No', 'Getting worse', 'No known family issues', 'Tired and sleepy all day', 'Up-to-date', '2025-05-10', 'Yes', '09197776655', '789 Riverpark, Makati', 'ellatan@email.com', 'Female', 'Filipino', 'Student', 'Single', '2004-10-03', NULL);

IF NOT EXISTS (SELECT 1 FROM collab WHERE Id = 4)
INSERT INTO collab (Id, Time, Systolic, Diastolic, heartbeat, Temp, RespiratoryRate, EmergencyContact, Name, Relationship,
    Symptoms, Allergies, PastMedicalCondition, TakingMedication, Surgeries, [Vape,Smoke,Drink], gottenbetter, Inheritable, affectbody,
    Vaccination, FonlylastPeriod, Thinkmightbepregnant, Phone, Address, Email, Gender, Nationality, Occupation, Status, DateofBirth, AppointmentDate)
VALUES (4, '16:45:00', '135', '88', '90', '37.4', '22', 'David Lim', 'Eric Lim', 'Brother', 'Shortness of breath, chest pain', 'Shellfish', 'None', 'Occasional pain reliever', 'None', 'Yes - Vapes regularly', 'Worsened', 'Father had heart issues', 'Breathing is difficult after walking', 'Unknown', NULL, NULL, '09170009988', '101 Hilltop Rd, Taguig', 'davidlim@email.com', 'Male', 'Filipino', 'Call Center Agent', 'Single', '1998-03-27', NULL);

-- 4. UPSERT pattern for users: update if exists, else insert
-- Admin
IF EXISTS (SELECT 1 FROM users WHERE IdNumber = 'admin')
    UPDATE users SET Password = 'VNe4IAtsNYjrcImm+lYrri48thj224SafXvGMBvr9wHdfuNq', Role = 'admin' WHERE IdNumber = 'admin';
ELSE
    INSERT INTO users (IdNumber, Password, Role) VALUES ('admin', 'VNe4IAtsNYjrcImm+lYrri48thj224SafXvGMBvr9wHdfuNq', 'admin');

-- Doctor
IF EXISTS (SELECT 1 FROM users WHERE IdNumber = 'D1001')
    UPDATE users SET Password = 'RNAyOlB0sB5YG1gXGcjK/IPTPS+AHNHGZf6YOH91EzZKPcFU', Role = 'doctor' WHERE IdNumber = 'D1001';
ELSE
    INSERT INTO users (IdNumber, Password, Role) VALUES ('D1001', 'RNAyOlB0sB5YG1gXGcjK/IPTPS+AHNHGZf6YOH91EzZKPcFU', 'doctor');

-- Nurse (plain password for now - recommend hashing in production)
IF EXISTS (SELECT 1 FROM users WHERE IdNumber = 'N2001')
    UPDATE users SET Password = 'nurse123', Role = 'nurse' WHERE IdNumber = 'N2001';
ELSE
    INSERT INTO users (IdNumber, Password, Role) VALUES ('N2001', 'nurse123', 'nurse');
-- To hash nurse password, generate a hash for 'nurse123' and update:
-- UPDATE users SET Password = 'HASHED_NURSE_PASSWORD_HERE' WHERE IdNumber = 'N2001';
CREATE TABLE doctors (
    DoctorId INT IDENTITY(1,1) PRIMARY KEY,
    UserId INT NOT NULL FOREIGN KEY REFERENCES users(Id),
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Gender VARCHAR(10),
    DateOfBirth DATE,
    ContactNumber VARCHAR(20),
    Specialty VARCHAR(50),
    Qualifications VARCHAR(100),
    YearsExperience INT,
    Department VARCHAR(50),
    LicenseNumber VARCHAR(50),
    MedicalSchool VARCHAR(100),
    DateJoined DATE,
    Status VARCHAR(20)
    -- Add other doctor-specific fields as needed
);
INSERT INTO doctors (
    UserId,         -- Links to users.Id
    FirstName,
    LastName,
    Gender,
    DateOfBirth,
    ContactNumber,
    Specialty,
    Qualifications,
    YearsExperience,
    Department,
    LicenseNumber,
    MedicalSchool
)
SELECT
    Id,            -- users.Id becomes doctors.UserId
    'First',       -- Placeholder, update as needed
    'Last',        -- Placeholder, update as needed
    'Unknown',     -- Gender
    '1970-01-01',  -- DateOfBirth
    '0000000000',  -- ContactNumber
    'General',     -- Specialty
    'MD',          -- Qualifications
    0,             -- YearExperience
    'General',     -- Department
    'LIC000',      -- LicenseNumber
    'MedSchool'    -- MedicalSchool
FROM users
WHERE Role = 'doctor'
  AND Id NOT IN (SELECT UserId FROM doctors);
CREATE TABLE nurses (
    NurseId INT PRIMARY KEY IDENTITY(1,1),
    UserId INT NOT NULL,
    Department NVARCHAR(100),
    -- Add other nurse fields as needed
    FOREIGN KEY (UserId) REFERENCES users(Id)
);
-- Example for SQL Server: Add columns only if they do not already exist

-- DateOfBirth
IF COL_LENGTH('nurses', 'DateOfBirth') IS NULL
    ALTER TABLE nurses ADD DateOfBirth DATE;

-- FirstName
IF COL_LENGTH('nurses', 'FirstName') IS NULL
    ALTER TABLE nurses ADD FirstName NVARCHAR(50);

-- LastName
IF COL_LENGTH('nurses', 'LastName') IS NULL
    ALTER TABLE nurses ADD LastName NVARCHAR(50);

-- Gender
IF COL_LENGTH('nurses', 'Gender') IS NULL
    ALTER TABLE nurses ADD Gender NVARCHAR(10);

-- ContactNumber
IF COL_LENGTH('nurses', 'ContactNumber') IS NULL
    ALTER TABLE nurses ADD ContactNumber NVARCHAR(20);

-- Department
IF COL_LENGTH('nurses', 'Department') IS NULL
    ALTER TABLE nurses ADD Department NVARCHAR(50);

-- Qualifications
IF COL_LENGTH('nurses', 'Qualifications') IS NULL
    ALTER TABLE nurses ADD Qualifications NVARCHAR(255);

-- YearsExperience
IF COL_LENGTH('nurses', 'YearsExperience') IS NULL
    ALTER TABLE nurses ADD YearsExperience INT;

-- LicenseNumber
IF COL_LENGTH('nurses', 'LicenseNumber') IS NULL
    ALTER TABLE nurses ADD LicenseNumber NVARCHAR(50);

-- NursingSchool
IF COL_LENGTH('nurses', 'NursingSchool') IS NULL
    ALTER TABLE nurses ADD NursingSchool NVARCHAR(100);

-- DateJoined
IF COL_LENGTH('nurses', 'DateJoined') IS NULL
    ALTER TABLE nurses ADD DateJoined DATE;

-- Status
IF COL_LENGTH('nurses', 'Status') IS NULL
    ALTER TABLE nurses ADD Status NVARCHAR(20);

-- UserId (if you need it)
IF COL_LENGTH('nurses', 'UserId') IS NULL
    ALTER TABLE nurses ADD UserId INT;

-- NurseId (if not already primary key, but usually this exists)
-- You can skip adding NurseId if it is already present as the PK.

-- Add any additional new fields below following the same pattern.
