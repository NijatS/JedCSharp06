----Retrieve products with the maximum unit price.
----select od.ProductID, MAX(od.UnitPrice) [maximum unit price] from [Order Details] od
----group by od.ProductID
----order by od.ProductID

--Select ProductID,ProductName,
--(Select Max(UnitPrice) from Products)
--from Products

--Select * from [Order Details]
--Order by ProductID

--Select distinct ProductId , 
--(Select MAX(UnitPrice) from [Order Details] od1
--Where od.ProductID = od1.ProductID
--) [Max Price]
--from [Order Details] od


--SELECT *
--FROM Products
--WHERE UnitPrice = (SELECT MAX(UnitPrice) FROM Products);


create database C#06

use C#06

--columns
create table Students(
StudentId int,
[Name] nvarchar(20),
Surname nvarchar(40),
FINCode nvarchar(7),
)

Alter table Students
add  Email nvarchar(50)

Alter table Students 
add IsMarried bit

Alter table Students
add BirthDate datetime2

alter table Students
drop column BirthDate

Alter table Students
add Scholarship decimal(7,2)


--Drop table Students2

--DML(INSERT, UPDATE, DELETE)

Insert into Students(StudentId,[Name],Surname,FINCode,
Email,IsMarried,BirthDate,Scholarship)
Values (1,'Azima','Qadirli','12AB345','azima@gmail.com',0,
'12.14.2003',173.5),(2,'Yusif','Pirquliyev','12AA345','yusif@gmail.com',0,'12-07-2002',98.0),(3,'Nijat','Soltanov','10ON010','nijat@gmail.com',0,'11-12-2003',
171.5)

Select * from Students

Insert into Students
Values(4,'Test','Test',null,null,null,null,null)


Update Students
set Name = 'Isa' , Surname = 'Sadigov'
where StudentId = 4


Delete from Students
Where StudentId =4

BACKUP DATABASE C#06
TO DISK = 'D:\Videos\test.bak';


Truncate table Students

