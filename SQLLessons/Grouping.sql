Select Count(Region) from Customers

Select Region from Customers
Where Region is not null


Select SUM(UnitsInStock) as [Product Stock Count] from Products

Select Sum(UnitPrice) from Products

Select Count(*) from Products

Select AVG(UnitsInStock) from Products


Select MAx(UnitPrice) from Products

Select Min(UnitPrice) from Products

Select * from Products
Order by ProductName

Select Max(ProductName) from Products

Select OrderDate from Orders
Order by OrderDate desc


Select Max(OrderDate) from Orders

Select OrderID , SUM(UnitPrice) from [Order Details]
Group by OrderID

Select EmployeeID , Count(OrderID) from Orders
group by EmployeeID


Select * from [Order Details]

Select OrderID,ProductID , SUM(UnitPrice) from [Order Details]
Group by OrderID,ProductID
--Sifarisler ve onlarin umumi deyerin cixarin haradaki umumi deyer 50$ dan cox ve Order Id-si 10270 den boyuk olsun.

Select OrderId,Sum(UnitPrice) from [Order Details]
Where OrderID >10270
Group by OrderId
Having Sum(UnitPrice) > 50




--Task 16: Total Orders by Country and Year
--Write a query to count the number of orders placed in each country for each year, 
--showing only those countries with more than 20 orders in any year.

Select ShipCountry , Year(OrderDate) as [Year],Count(OrderID) [Order Count] from Orders
Where ShipCountry like 'a%' 
Group by ShipCountry,Year(OrderDate)
Having Count(OrderID) > 20
Order by  ShipCountry

