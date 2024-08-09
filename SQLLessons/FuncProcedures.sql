use Northwind

create view GetOrdersWithEmployee
as
Select o.OrderID,e.FirstName,e.LastName from Orders o
join Employees e
on e.EmployeeID = o.EmployeeID



Select * from GetOrdersWithEmployee


--*View: ActiveCustomers
--List all customers who have placed at least one order.

create view ActiveCustomers
as
Select distinct c.* from Customers c
join Orders o 
on c.CustomerID = o.CustomerID

Select * from ActiveCustomers


--*View: ProductsInStock
--List all products that are currently in stock.

create view ProductsInStock
as 
Select * from Products
Where UnitsInStock > 0


alter view ProductMoreThan10
as 
Select * from Products
Where UnitPrice > 10


drop view ProductMoreThan10



Create procedure Test1
as
Begin
Select * from Employees
End

Exec Test1

create or alter Procedure GetProductsViaPrice(@beginPrice int,@endPrice int)
as 
begin
Select * from Products
Where @beginPrice <= UnitPrice and UnitPrice <= @endPrice
end

Exec GetProductsViaPrice @beginPrice = 100, @endPrice = 200

drop Procedure GetProductsViaPrice

declare @begin nvarchar(MAx) 
set @begin = 'Salammmmm'
print @begin











create or alter Procedure InsertRegion(@id int, @regionName nchar(50))
as 
begin
Insert into Region
Values (@id,@regionName)
Select * from Region
end

Exec InsertRegion @id =5,@regionName = 'Koroglu'

Go
create or alter function SumTwoNumbers(@number1 int,@number2 int)
returns int
as
begin 
declare @sum int 
set @sum = @number1+@number2
return @sum
end


print dbo.SumTwoNumbers(5,10) 


--*Function: GetCustomerOrderCount
--This function returns the number of orders placed by a specific customer.
Go
create or alter function GetCustomerOrderCount(@customerId nchar(5))
returns int as
begin
declare @orderCount int
Select  @orderCount = Count(OrderId) from Orders o 
join Customers c 
on c.CustomerID = o.CustomerID
Where o.CustomerID = @customerId
return @orderCount
end

Select * from Customers

print dbo.GetCustomerOrderCount('ALFKI')

Go
create or alter function GetOrderDetailByRegion(@regionName nchar(50))
returns table as
Return (Select distinct o.* from Orders o
join Employees e
on o.EmployeeID = e.EmployeeID
join EmployeeTerritories et
on e.EmployeeID = et.EmployeeID
join Territories t
on et.TerritoryID = t.TerritoryID
join Region r
on t.RegionID = r.RegionID
Where r.RegionDescription = @regionName)

Select  * from GetOrderDetailByRegion('Northern')

Select * from Orders

begin transaction
Delete from Territories
Where RegionID =5
delete from Region 
Where RegionId = 'asda'
rollback

create table emp(empid int constraint PRIMARYKEY primary key, empName varchar(15))  
insert into emp  
Values( 16,'d'), 
(17,'ee'),
(18,'p'),
( 19,'a'), 
 (20,'k')  

Select  * from emp


begin transaction

Delete from emp
Where empid = 19

Update emp
Set empName = 'Azima'
Where empid ='as'

rollback