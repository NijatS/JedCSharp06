--use C#06

create table Employees(
EmployeeID int,
FirstName nvarchar(20),
LastName nvarchar(20),
DepartmentID int
)

create table Departments(
DepartmentID int,
DepartmentName nvarchar(20)
)

Insert into Employees(EmployeeID,FirstName,LastName,DepartmentID)
Values(1,'Nijat','Soltanov',123),(2,'Azima','Qadirli',456),(3,'Yusif','Pirquliyev',789)

select * from Employees

Insert into Departments(DepartmentID,DepartmentName)
Values(123,'JetA'),(456,'JetB'),(789,'JetC')


select * from Departments

select *
from Employees e
join Departments d
on e.DepartmentID = d.DepartmentID


Select * , (Select DepartmentName from Departments d
where e.DepartmentID = d.DepartmentID )
from Employees e


create table Groups(
 GroupId int not null,
 Name nvarchar(100) not null,
 Speciality nvarchar(100)
)

Select * from Groups

insert into Groups 
Values(1,'C#06','C# Backend')

Truncate table Groups

Alter table Groups
alter column Speciality nvarchar(100) not null


Drop table Groups
Drop table Students


create table Students(
Id int Unique not null ,
Name nvarchar(20) not null,
Surname nvarchar(100) not null,
Phone nvarchar(100) unique
)

Select * from Students

Update Students
Set Id = 2 
Where Name = 'Nijat'

Truncate Table Students

Alter table Students
Alter column Id int not null
--ADD Unique(Id)






Drop table Students

Alter table Students
add Email nvarchar(50) not null

Alter table Students
add unique(Email)


create table Students(
Id int primary key identity(5,4),
Name nvarchar(20) not null,
Surname nvarchar(100) not null,
Age int check(Age>=18),
Phone nvarchar(100) unique,
City nvarchar(100) default 'Baku' 
)
Select * from Students

try


BEGIN TRY  
   Insert into Students(Name,Surname,Phone,Age)
Values('Nijat','Soltanov','0706139003',18)
END TRY  
BEGIN CATCH  
    SELECT
    ERROR_MESSAGE() AS ErrorMessage;
END CATCH
alter table Students
add Salary float 

Alter table Students
add Check(Salary > 345)


Alter table Students1
add default 0 for IsMarried

create table Groups(
Id int primary key Identity,
Name nvarchar(100) not null,
Speciality nvarchar(100) default 'Qalustuklu fehleler'
)

create table Students(
Id int primary key identity,
Name nvarchar(20) not null,
Surname nvarchar(100) not null,
Age int,
Phone nvarchar(100),
City nvarchar(100) default 'Baku' ,
GroupId int foreign key references Groups(Id) not null,
Constraint [Check_Age] check(Age>=18)
)

alter table Students
alter column GroupId int not null

Insert into Groups(Name)
values ('Front-end')

Select * from Groups
Select * from Students

   Insert into Students(Name,Surname,Phone,Age,GroupId)
Values('Nijat','Soltanov','0706139003',18,1)

alter table Students
add constraint [Check_Age] check(Age>=18)


create table Students2(
Id int Primary key identity,
Name nvarchar(50),
PLanguages nvarchar(100)
)

Select * from Students2

Insert into Students2
values ('Azima','C#'),
('Yusif','C# JS'),
('Nijat','C# Java JS')

create table Students3(
Id int Primary key identity,
Name nvarchar(50),
GroupID int ,
GroupName nvarchar(50)
)
create table Groups4(
Id int Primary key identity, 
GroupName nvarchar(50)
)
create table Students4(
Id int Primary key identity,
Name nvarchar(50),
GroupId int foreign key references Groups4(Id)
)

create table Customer(
Id int Primary key identity,
Name nvarchar(50),
Phone1 nvarchar(50),
Address1 nvarchar(50),
Address2 nvarchar(50),
City nvarchar(50),
Street nvarchar(50),
Email nvarchar(50),
Zip nvarchar(50),
)

create table Customer(
Id int Primary key identity,
Name nvarchar(50),
Phone1 nvarchar(50),
Email nvarchar(50),
)
create table Customer_Detail(
CustomerId int primary key foreign key references Customer(Id),
Address1 nvarchar(50),
Address2 nvarchar(50),
City nvarchar(50),
Street nvarchar(50),
Zip nvarchar(50),
)
