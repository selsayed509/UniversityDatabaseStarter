-- CMP205 Week 8: University database for the lecture and lab
-- Run this in SSMS on your own database (it creates two tables in dbo).
-- The columns match the Person, Student and Department classes from Week 6.

IF OBJECT_ID('dbo.Student', 'U') IS NOT NULL DROP TABLE dbo.Student;
IF OBJECT_ID('dbo.Department', 'U') IS NOT NULL DROP TABLE dbo.Department;
GO

CREATE TABLE dbo.Department
(
    DepartmentId INT IDENTITY(1,1) PRIMARY KEY,
    Name         NVARCHAR(50)  NOT NULL,
    School       NVARCHAR(100) NOT NULL
);

CREATE TABLE dbo.Student
(
    StudentId    NVARCHAR(10)  PRIMARY KEY,
    NationalId   NVARCHAR(13)  NOT NULL,
    Name         NVARCHAR(100) NOT NULL,
    DateOfBirth  DATE          NOT NULL,
    PhoneNumber  NVARCHAR(20)  NOT NULL,
    Address      NVARCHAR(200) NOT NULL,
    Course       NVARCHAR(100) NOT NULL,
    DepartmentId INT           NOT NULL
        REFERENCES dbo.Department (DepartmentId)
);
GO

INSERT INTO dbo.Department (Name, School) VALUES
('Computing', 'Design, Informatics and Business'),
('Games',     'Design, Informatics and Business'),
('Cyber',     'Design, Informatics and Business');

INSERT INTO dbo.Student
    (StudentId, NationalId, Name, DateOfBirth, PhoneNumber, Address, Course, DepartmentId)
VALUES
('2400123', 'NI003', 'Amira',  '2005-05-20', '07000 000003', '3 Perth Road',     'BSc Computing',        1),
('2400456', 'NI004', 'Ben',    '2004-11-08', '07000 000004', '4 Perth Road',     'BSc Computer Games',   2),
('2400789', 'NI005', 'Chloe',  '2005-02-14', '07000 000005', '12 Nethergate',    'BSc Computing',        1),
('2401012', 'NI006', 'Daniel', '2003-09-30', '07000 000006', '7 Hawkhill',       'BSc Ethical Hacking',  3),
('2401345', 'NI007', 'Eilidh', '2005-07-01', '07000 000007', '21 Seagate',       'BSc Computer Science', 1),
('2401678', 'NI008', 'Farah',  '2004-03-17', '07000 000008', '9 Lochee Road',    'BSc Computer Games',   2);
GO

SELECT * FROM dbo.Department;
SELECT * FROM dbo.Student;
