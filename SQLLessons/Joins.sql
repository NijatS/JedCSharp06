--Select * from Customers --91

--Select * from Orders -- 830

--Select * from Customers
--inner join Orders
--on Customers.CustomerID = Orders.CustomerID

--Select * from Customers
--join Orders
--on Customers.CustomerID = Orders.CustomerID

--Select * from Customers
--full join Orders
--on Customers.CustomerID = Orders.CustomerID
--Where OrderID is null

--Select * from Customers c
--full join Orders o
--on c.CustomerID = o.CustomerID
--Where OrderID is null


--Select * from Students s
--left join Groups g
--on s.GroupId = g.Id
----Where GroupId is null
--Where g.Id is null


--Create table StudentAddress(
--   City nvarchar(50),
--   Street nvarchar(50),
--   Building nvarchar(50),
--   StudentId int Primary key Foreign key References Students(Id)
--)


--Select * from Groups g
--right join Students s
--on s.GroupId = g.Id


--Select * from Students s
--right join Groups g
--on s.GroupId = g.Id

--Select * from Groups g 
--left join Students s 
--on s.GroupId = g.Id

--Select * from Students s
--full join Groups g
--on s.GroupId =g.Id

Select * from Employees
Select e.EmployeeID,e.LastName + ' '+e.FirstName,b.EmployeeID, b.LastName + ' '+b.FirstName
from Employees e
left join Employees b
on e.ReportsTo = b.EmployeeID


--Write a query to find the total sales amount for each customer, showing only those customers with total sales greater than $1000.



Select c.CustomerID,c.ContactName, Sum(od.UnitPrice * od.Quantity)as [Total Sales]from Customers c
join Orders o
on c.CustomerID = o.CustomerID
join [Order Details] od
on od.OrderID = o.OrderID
group by c.CustomerID, c.ContactName
having Sum(od.UnitPrice * od.Quantity) >1000



--Write a query to find the average order quantity for each product, showing only those products with an average order quantity greater than 10.
select ProductID, AVG(Quantity) [average order quantity] from [Order Details] 
group by ProductID


--Write a query to find the total sales amount for each employee, showing only those employees with total sales greater than $5000.

Select e.EmployeeID,e.FirstName +' '+e.LastName,Sum(od.UnitPrice * od.Quantity) from Employees e
join Orders o
on e.EmployeeID = o.EmployeeID
join [Order Details] od
on o.OrderID = od.OrderID
group by e.EmployeeID,e.FirstName,e.LastName
having Sum(od.UnitPrice * od.Quantity)>5000



--Write a query to find the average discount given on each product, showing only those products with an average discount greater than 5%.
select ProductID, AVG(Discount) [average discount] from [Order Details] 
group by ProductID 
having AVG(Discount) > 0.05
--Write a query to count the number of orders handled by each employee, showing only those employees who have handled more than 50 orders.
select EmployeeID, COUNT(OrderID) [number of orders] from Orders
group by EmployeeID
having COUNT(OrderID) > 50
--Write a query to find the total sales amount for each month of each year, showing only those months with total sales greater than $10000.
select MONTH(ShippedDate) [month, year], SUM(SaleAmount) [total sale amount] from [Sales Totals by Amount]
group by MONTH(ShippedDate)
having SUM(SaleAmount) > 10000
--Write a query to find the average order value for each year, showing only those years with an average order value greater than $500.
null
--Write a query to find the total quantity of products sold each year, showing only those years with total quantity sold greater than 1000 units.
null
--Write a query to find the total freight charges for each country, showing only those countries with total freight charges greater than $1000.
select ShipCountry, SUM(Freight) [total freight charges] from Orders
group by ShipCountry 
having SUM(Freight) > 1000
--Write a query to find the average freight charges for each country, showing only those countries with an average freight charge greater than $50.
select ShipCountry, AVG(Freight) [average freight charge] from Orders
group by ShipCountry
having AVG(Freight) > 50
--Write a query to find the total sales amount for each product category for each year, showing only those categories with total sales greater than $10000 in any year.
null