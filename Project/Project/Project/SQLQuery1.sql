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
    [Pic] IMAGE NULL
)INSERT INTO [dbo].[collab]
(
    Id, Time, Systolic, Diastolic, heartbeat, Temp, RespiratoryRate, EmergencyContact, Name, Relationship,
    Symptoms, Allergies, PastMedicalCondition, TakingMedication, Surgeries, [Vape,Smoke,Drink],
    gottenbetter, Inheritable, affectbody, Vaccination, FonlylastPeriod, Thinkmightbepregnant,
    Phone, Address, Email, Gender, Nationality, Occupation, Status, DateofBirth
)
VALUES
(
    1, '09:30:00', '120', '80', '72', '36.6', '18', 'Anna Lopez', 'John Cruz', 'Wife',
    'Mild fever, dry cough', 'None', 'Asthma', 'Salbutamol inhaler', 'Appendectomy in 2010', 'No',
    'Stayed the same', 'Yes, asthma from mother', 'Some fatigue during work', 'Up-to-date', NULL, NULL,
    '09171234567', '123 Main St, Quezon City', 'johncruz@email.com', 'Male', 'Filipino', 'Engineer', 'Single', '1990-05-12'
);
INSERT INTO [dbo].[collab]
(
    Id, Time, Systolic, Diastolic, heartbeat, Temp, RespiratoryRate, EmergencyContact, Name, Relationship,
    Symptoms, Allergies, PastMedicalCondition, TakingMedication, Surgeries, [Vape,Smoke,Drink],
    gottenbetter, Inheritable, affectbody, Vaccination, FonlylastPeriod, Thinkmightbepregnant,
    Phone, Address, Email, Gender, Nationality, Occupation, Status, DateofBirth
)
VALUES
(
    2, '11:00:00', '150', '95', '85', '37.0', '20', 'Luis Ramos', 'Maria Ramos', 'Daughter',
    'Dizziness, blurred vision', 'Penicillin', 'Hypertension', 'Amlodipine', 'Cataract surgery (2018)', 'No',
    'Worsened', 'Yes, heart disease in family', 'Hard to walk longer distances', 'Not updated', NULL, NULL,
    '09180001122', '456 Sunrise Blvd, Pasig City', 'mariaramos@email.com', 'Male', 'Filipino', 'Retired', 'Widowed', '1955-07-22'
);
INSERT INTO [dbo].[collab]
(
    Id, Time, Systolic, Diastolic, heartbeat, Temp, RespiratoryRate, EmergencyContact, Name, Relationship,
    Symptoms, Allergies, PastMedicalCondition, TakingMedication, Surgeries, [Vape,Smoke,Drink],
    gottenbetter, Inheritable, affectbody, Vaccination, FonlylastPeriod, Thinkmightbepregnant,
    Phone, Address, Email, Gender, Nationality, Occupation, Status, DateofBirth
)
VALUES
(
    3, '14:15:00', '115', '75', '78', '36.9', '19', 'Karen Tan', 'Ella Tan', 'Mother',
    'Nausea, missed period', 'None', 'None', 'None', 'None', 'No',
    'Getting worse', 'No known family issues', 'Tired and sleepy all day', 'Up-to-date', '2025-05-10', 'Yes',
    '09197776655', '789 Riverpark, Makati', 'ellatan@email.com', 'Female', 'Filipino', 'Student', 'Single', '2004-10-03'
);
INSERT INTO [dbo].[collab]
(
    Id, Time, Systolic, Diastolic, heartbeat, Temp, RespiratoryRate, EmergencyContact, Name, Relationship,
    Symptoms, Allergies, PastMedicalCondition, TakingMedication, Surgeries, [Vape,Smoke,Drink],
    gottenbetter, Inheritable, affectbody, Vaccination, FonlylastPeriod, Thinkmightbepregnant,
    Phone, Address, Email, Gender, Nationality, Occupation, Status, DateofBirth
)
VALUES
(
    4, '16:45:00', '135', '88', '90', '37.4', '22', 'David Lim', 'Eric Lim', 'Brother',
    'Shortness of breath, chest pain', 'Shellfish', 'None', 'Occasional pain reliever', 'None', 'Yes - Vapes regularly',
    'Worsened', 'Father had heart issues', 'Breathing is difficult after walking', 'Unknown', NULL, NULL,
    '09170009988', '101 Hilltop Rd, Taguig', 'davidlim@email.com', 'Male', 'Filipino', 'Call Center Agent', 'Single', '1998-03-27'
);
CREATE TABLE users (
    Id INT PRIMARY KEY IDENTITY(1,1),
    IdNumber VARCHAR(50) NOT NULL,
    Password VARCHAR(100) NOT NULL,
    Role VARCHAR(20) NOT NULL  -- Values: 'doctor', 'nurse'
);
INSERT INTO users (IdNumber, Password, Role)
VALUES 
('D1001', 'doctor123', 'doctor'),
('N2001', 'nurse123', 'nurse');
INSERT INTO users (IdNumber, Password, Role)
VALUES ('admin001', 'adminpass', 'admin');
