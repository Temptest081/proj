-- Use the correct database
USE [New Database];
GO

-- Drop existing tables if they exist (for clean recreation)
-- Be careful with this in a production environment as it deletes all data!
IF OBJECT_ID('dbo.collab', 'U') IS NOT NULL DROP TABLE dbo.collab;
IF OBJECT_ID('dbo.doctors', 'U') IS NOT NULL DROP TABLE dbo.doctors;
IF OBJECT_ID('dbo.nurses', 'U') IS NOT NULL DROP TABLE dbo.nurses;
IF OBJECT_ID('dbo.users', 'U') IS NOT NULL DROP TABLE dbo.users;
GO

-- 1. Create the 'users' table first (as it's referenced by doctors and nurses)
CREATE TABLE dbo.users (
    Id INT IDENTITY(1,1) NOT NULL,
    IdNumber NVARCHAR(50) NOT NULL,
    Password NVARCHAR(100) NOT NULL,
    Role NVARCHAR(20) NOT NULL,
    CONSTRAINT PK_users PRIMARY KEY CLUSTERED (Id ASC)
);
GO

-- 2. Create the 'doctors' table
CREATE TABLE dbo.doctors (
    DoctorId INT IDENTITY(1,1) NOT NULL,
    UserId INT NOT NULL,
    FirstName NVARCHAR(50) NULL,
    LastName NVARCHAR(50) NULL,
    Gender NVARCHAR(10) NULL,
    DateOfBirth DATETIME NULL,
    ContactNumber NVARCHAR(20) NULL,
    Specialty NVARCHAR(50) NULL,
    Qualifications NVARCHAR(100) NULL,
    YearsExperience INT NULL,
    Department NVARCHAR(50) NULL,
    LicenseNumber NVARCHAR(50) NULL,
    MedicalSchool NVARCHAR(100) NULL,
    DateJoined DATETIME NULL,
    Status NVARCHAR(20) NULL,
    CONSTRAINT PK_doctors PRIMARY KEY CLUSTERED (DoctorId ASC),
    CONSTRAINT FK_doctors_UserId FOREIGN KEY (UserId) REFERENCES dbo.users (Id)
);
GO

-- 3. Create the 'nurses' table
CREATE TABLE dbo.nurses (
    NurseId INT IDENTITY(1,1) NOT NULL,
    UserId INT NOT NULL,
    Department NVARCHAR(100) NULL,
    DateOfBirth DATETIME NULL,
    FirstName NVARCHAR(50) NULL,
    LastName NVARCHAR(50) NULL,
    Gender NVARCHAR(10) NULL,
    ContactNumber NVARCHAR(20) NULL,
    Qualifications NVARCHAR(255) NULL,
    YearsExperience INT NULL,
    LicenseNumber NVARCHAR(50) NULL,
    NursingSchool NVARCHAR(100) NULL,
    DateJoined DATETIME NULL,
    Status NVARCHAR(20) NULL,
    CONSTRAINT PK_nurses PRIMARY KEY CLUSTERED (NurseId ASC),
    CONSTRAINT FK_nurses_UserId FOREIGN KEY (UserId) REFERENCES dbo.users (Id)
);
GO

-- 4. Create the 'collab' table
CREATE TABLE dbo.collab (
    Id INT NOT NULL, -- Assuming this is a manually assigned ID, not IDENTITY, based on Designer.vb
    Time TIME(7) NULL, -- TimeSpan in VB maps to TIME in SQL Server
    Systolic NVARCHAR(MAX) NULL,
    Diastolic NVARCHAR(MAX) NULL,
    heartbeat NVARCHAR(MAX) NULL,
    Temp NVARCHAR(MAX) NULL,
    RespiratoryRate NVARCHAR(MAX) NULL,
    EmergencyContact NVARCHAR(MAX) NULL,
    Name NVARCHAR(MAX) NULL,
    Relationship NVARCHAR(MAX) NULL,
    Symptoms NVARCHAR(MAX) NULL,
    Allergies NVARCHAR(MAX) NULL,
    PastMedicalCondition NVARCHAR(MAX) NULL,
    TakingMedication NVARCHAR(MAX) NULL,
    Surgeries NVARCHAR(MAX) NULL,
    gottenbetter NVARCHAR(MAX) NULL,
    Inheritable NVARCHAR(MAX) NULL,
    affectbody NVARCHAR(MAX) NULL,
    Vaccination NVARCHAR(MAX) NULL,
    FonlylastPeriod NVARCHAR(MAX) NULL,
    Thinkmightbepregnant NVARCHAR(MAX) NULL,
    Phone NVARCHAR(MAX) NULL,
    Address NVARCHAR(MAX) NULL,
    Email NVARCHAR(MAX) NULL,
    Gender NVARCHAR(MAX) NULL,
    Nationality NVARCHAR(MAX) NULL,
    Occupation NVARCHAR(MAX) NULL,
    Status NVARCHAR(MAX) NULL,
    DateofBirth DATETIME NULL,
    Pic VARBINARY(MAX) NULL, -- Byte array in VB maps to VARBINARY(MAX) for images
    AppointmentDate DATETIME NULL,
    Pain NVARCHAR(MAX) NULL,
    VapeSmokeDrink NVARCHAR(MAX) NULL,
    CONSTRAINT PK_collab PRIMARY KEY CLUSTERED (Id ASC)
);
GO

-- Insert into users table if not exists
IF NOT EXISTS (SELECT 1 FROM dbo.users WHERE IdNumber = 'admin')
BEGIN
    INSERT INTO dbo.users (IdNumber, Password, Role) VALUES 
    ('admin', '5f4dcc3b5aa765d61d8327deb882cf99', 'Admin');
END

-- Insert into doctors table
DECLARE @User Id INT;
SELECT @User Id = Id FROM dbo.users WHERE IdNumber = 'D1001';

IF @User Id IS NULL
BEGIN
    -- If the user does not exist, create the user first
    INSERT INTO dbo.users (IdNumber, Password, Role) VALUES 
    ('D1001', 'e99a18c428cb38d5f260853678922e03', 'Doctor');
    SET @User Id = SCOPE_IDENTITY(); -- Get the newly created User ID
END

-- Now insert into doctors table using the UserId
INSERT INTO dbo.doctors (User Id, FirstName, LastName, Gender, DateOfBirth, ContactNumber, Specialty, Qualifications, YearsExperience, Department, LicenseNumber, MedicalSchool, DateJoined, Status) VALUES 
(@User Id, 'John', 'Doe', 'Male', '1980-01-01', '555-1234', 'Cardiology', 'MD', 10, 'Cardiology', 'D123456', 'Harvard', '2010-05-01', 'Active');

-- Insert into nurses table
DECLARE @NurseUser Id INT;
SELECT @NurseUser Id = Id FROM dbo.users WHERE IdNumber = 'N02';

IF @NurseUser Id IS NULL
BEGIN
    -- If the nurse user does not exist, create the user first
    INSERT INTO dbo.users (IdNumber, Password, Role) VALUES 
    ('N02', '0cc175b9c0f1b6a831c399e269772661', 'Nurse');
    SET @NurseUser Id = SCOPE_IDENTITY(); -- Get the newly created User ID
END

-- Now insert into nurses table using the NurseUser Id
INSERT INTO dbo.nurses (User Id, Department, DateOfBirth, FirstName, LastName, Gender, ContactNumber, Qualifications, YearsExperience, LicenseNumber, NursingSchool, DateJoined, Status) VALUES 
(@NurseUser Id, 'Emergency', '1990-03-03', 'Alice', 'Johnson', 'Female', '555-8765', 'BSN', 5, 'N123456', 'Stanford', '2015-07-20', 'Active');