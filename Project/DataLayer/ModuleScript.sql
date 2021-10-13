Create Database ModulesDB;

Create Table tblmodules(
ModuleCode Varchar(100) Not Null Primary Key,
ModuleName Varchar(100) Not Null ,
ModuleLinks Varchar(1000) Not Null ,
ModuleDescription Varchar(1000) Not Null 
)

Insert Into tblmodules
Values ('1234', 'Math', 'www.math.com', 'This will be maths 281');

Select * From tblmodules