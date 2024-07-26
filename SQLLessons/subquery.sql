Select * from Categories

Select CategoryId , COUNT(ProductId) from Products
group by CategoryID


-- sifaris vermemis musterilerin siyahisini

--1st solution
Select * from Customers c
left  join Orders o 
on c.CustomerID = o.CustomerID
where o.OrderID is null

--2nd solution
Select * from Customers
Where CustomerID in ('FISSA','PARIS')

--3rd solution(subquery)
Select * from Customers
Where CustomerID not in  (Select  CustomerID
from Orders where CustomerID is not null)


Select * from Products
Where CategoryID = (Select CategoryID from Categories
Where CategoryName = 'Beverages')





 Delete from Orders
Where CustomerId is null


-- Order Details cedvelinden ele sifarisleri gosterin ki, UnitPrice-i Products cedvelindeki (ortalama UnitPrice*UnitsInStock)/10-dan yuxari olsun

Select * from [Order Details]
Where UnitPrice > 
( Select AVG(UnitPrice* UnitsInStock) /10 from Products)


-- Mehsul adi 20 dan boyuk olanlarin qiymetinden boyuk olan sifarisleri gösterin.
--any ,all


Select * from [Order Details]
Where UnitPrice > all(Select UnitPrice from Products
Where LEN(ProductName) >20)

Select * from Products
Where 6 > all (Select Id from Numbers)


--10>4,5,6,7

-- [Customers] Berlin-de,  yasayan ve Sales representative veya Owner olan  adamlarin verdiyi sifarisleri gosterin[Orders]


Select * from Orders 
Where CustomerID in (Select CustomerID from Customers
Where (Country ='Germany' and ContactTitle = 'Sales Representative') or( ContactTitle = 'Owner' and Country ='Germany' ))


Select * from Orders o
join Customers c
on o.CustomerID = c.CustomerID
Where (c.Country ='Germany' and c.ContactTitle = 'Sales Representative') or( c.ContactTitle = 'Owner' and c.Country ='Germany' )

--- [Products] cedvelinden qiymeti umumi mehsullarin qiymetlerinin ortalamasindan boyuk olan mehsullari getiren query yazin


Select * from Products
Where UnitPrice > (Select AVG(UnitPrice) from Products)


--- [Orders] ve [Customers] cedvellerinden sadece Almaniyadan olan musterilerin verdiyi sifarisleri gosteren query yazin

Select * from Orders o
join Customers c
on o.CustomerID = c.CustomerID
Where c.Country = 'Germany'


Select * from Orders 
Where CustomerID in (Select CustomerID from Customers
Where Country ='Germany' )

--- [Orders] ve [Employees] cedvellerinden hec sifaris qebul etmemis iscilerin adlarini gosteren query yazin

Select * from Employees e
left join Orders o 
on e.EmployeeID  = o.EmployeeID
Where OrderID is Null


Select * from Employees
Where EmployeeID not in (Select EmployeeID from Orders)


--- [Order Details] ve [Products] cedvellerinden hec sifaris verilmemis mehsullari gosteren query yazin


Select * from [Order Details]

Select * from Products p
left join [Order Details] od
on p.ProductID = od.ProductID
Where OrderID is null


Select * from Products
Where ProductID not in (Select ProductID from [Order Details])

Select * from Products p 
Where  not Exists  (Select ProductID from [Order Details] od where od.ProductID = p.ProductID)


Select CategoryID,CategoryName ,
(Select Count(*) from Products p
Where p.CategoryID = c.CategoryID
)
from Categories c


--- [Employees], [Orders], [Customers] cedvellerini istifade ederek Polsadan olan musterilerden sifaris goturmus iscileri gosteren query yazin


Select distinct e.EmployeeID from Employees e
join Orders o
on e.EmployeeID =o.EmployeeID
join Customers c
on o.CustomerID = c.CustomerID
Where c.Country = 'Poland'



Select * from Employees e
Where Exists (Select * from Orders o
Where e.EmployeeID = o.EmployeeID  and o.CustomerID = (
Select CustomerID from Customers c
Where  c.Country = 'Poland'
)
)







