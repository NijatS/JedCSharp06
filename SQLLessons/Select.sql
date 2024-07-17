--create database Test;

--use Northwind

Select  CompanyName,ContactName,Phone,[Address] from  Customers


Select ProductID,ProductName from Products


--Select Products from ProductName  you will get error


Select CategoryID,CategoryName,[Description],Picture from Categories

Select * from Categories


Select CategoryName [Kateqorinin adi] from Categories

Select CategoryName as [Kateqorinin adi] from Categories

Select CategoryName  "Kateqorinin adi" from Categories

Select [CategoryName] [Kateqori Adi]  from Categories


Select EmployeeID , LastName + ' '+ FirstName as[FullName] from Employees

Select EmployeeID , CONCAT(FirstName,' ',LastName) as[FullName] from Employees


Select ProductID , ProductName , UnitPrice * UnitsInStock 
[Bajioglunun pulu] from Products

Select distinct City from Customers


Select * from Products
Order by UnitPrice asc

Select * from Products
Order by UnitPrice desc

Select * from Products
Order by -UnitPrice 



Select * from Products
Order by ProductName desc




Select ProductID , ProductName , UnitPrice * UnitsInStock 
[Bajioglunun pulu] from Products
--Order by UnitPrice * UnitsInStock 
Order by [Bajioglunun pulu]


--Select * from Customers
--Order by Country,City


Select * from Products
Order by ProductID
--Limit 4,5 MYSQL
OFFSET 4 ROWS FETCH NEXT 5 ROWS ONLY;

Select Top 20 with Ties  City from Customers
Order by City

