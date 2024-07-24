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

SELECT CustomerID, SUM(Freight) FROM Orders
--Where CustomerID > 'B'
GROUP BY CustomerID
--HAVING CustomerID > 'B'
Having SUM(Freight) >500 and SUM(Freight) <1000

--Task 1: Count Orders by Customer
--Write a query to count the number of orders placed by each customer,
--showing only those customers who have placed more than 5 orders.

Select CustomerID,Count(OrderId)  as [Order Count] from Orders
Group by CustomerID
Having Count(OrderId)   >5


--Task 2: Total Quantity Sold by Product
--Write a query to find the total quantity of each product sold, 
--showing only those products that have sold more than 100 units.

Select ProductName,Sum(UnitsOnOrder) from Products
Group by ProductName
Having Sum(UnitsOnOrder) >20


--Task 3: Number of Products in Each Category
--Write a query to count the number of products in each category, 
--showing only those categories with more than 10 products.


Select CategoryID,COUNT(ProductID) as [Product Count] from Products
Group by CategoryID
Having Count(ProductID) >10


--Task 4: Average Unit Price of Products
--Write a query to find the average unit price of products, 
--showing only those categories with an average unit price greater than $30.


Select CategoryId, Avg(UnitPrice) from Products
Group by CategoryID
Having Avg(UnitPrice) >30



--Task 5: Total Freight by Shipper
--Write a query to find the total freight charges handled by each shipper, showing only those shippers with total freight charges exceeding $500.

--Task 6: Total Sales by Customer
--Write a query to find the total sales amount for each customer, showing only those customers with total sales greater than $1000.

--Task 7: Average Order Quantity by Product
--Write a query to find the average order quantity for each product, showing only those products with an average order quantity greater than 10.

--Task 8: Total Sales by Employee
--Write a query to find the total sales amount for each employee, showing only those employees with total sales greater than $5000.

--Task 9: Average Discount by Product
--Write a query to find the average discount given on each product, showing only those products with an average discount greater than 5%.

--Task 10: Count Orders by Employee
--Write a query to count the number of orders handled by each employee, showing only those employees who have handled more than 50 orders.


