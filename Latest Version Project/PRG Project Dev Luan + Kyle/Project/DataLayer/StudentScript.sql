CREATE TABLE tblStudents(
StudentNumber varchar(100) NOT NULL PRIMARY KEY,
StudentName varchar(100) NOT NULL,
StudentSurname varchar(100) NOT NULL,
StudentImage varbinary(max) NOT NULL, 
DOB date NOT NULL,
Gender varchar(100) NOT NULL,
Phone int NOT NULL,
Addr varchar(1000) NOT NULL,
ModuleCode varchar(100) NOT NULL
)

INSERT INTO tblStudents(
StudentNumber,
StudentName,
StudentSurname, 
DOB,
Gender,
Phone,
Addr,
ModuleCode
)
VALUES(
'3010',
'Monica',
'Mei',
'2000-07-25',
'female',
'0781781462',
'2680 Meyersig Lifestyle Estate',
'1234'
)

INSERT INTO tblStudents(
StudentImage
)
SELECT(
Senepe
)
FROM OPENROWSET(BULK
N'C:\Users\user\Downloads\PRG Project Dev - Luan + Kyle\PRG Project Dev Luan + Kyle\Project\DataLayer\Pic.jpg', SINGLE_BLOB)
AS
ImageSource(Senepe);

SELECT * FROM tblStudents