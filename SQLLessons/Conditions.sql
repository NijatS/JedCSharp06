Select * from Customers
Where Country = 'Germany'


Select * from Customers
Where ContactTitle = 'Sales Representative'


Select * from Products
Where UnitPrice > 100

Select * from Products
Where UnitsInStock <= 10

Select * from Products
Where UnitPrice Between 50 and 100

Select * from Orders
Where  Freight Between 180 and 200

--A ile baslayan butun musterileri getir
Select * from Customers
Where ContactName like 'a%'

--Contact Name -de n herfi olanlari getir
Select * from Customers
Where ContactName like '%n%'

--l ile biten butun musteriler
Select * from Customers
Where ContactName like '%l'


--Telefon nomresi 7 ile baslayan musteriler
Select * from Customers
Where Phone like '7%'

Select * from Customers
Where Region is NULL

Select * from Employees
Where Region is not NULL

--Mehsullarin arasinda qiymeti 5 den 50 e kimi olanlari cap ele(Between-siz)

Select * from Products
Where UnitPrice > 5 and UnitPrice <50
order by UnitPrice

--Almaniya ve Brazilidan olan musterilerimi cap edin

Select * from Customers
Where Country='germany' or Country = 'brazil'

Select * from Customers
Where Country in  ('Germany','Brazil')


Select * from Customers
Where Country not in ('Germany','Brazil')

Select * from Customers
Where Country != 'Brazil' and Country != 'Germany'


Select * from Products
Where UnitsInStock<10 or UnitsInStock >20



Select LastName+' '+FirstName as [Nameler] from Employees

Select CONCAT(LastName,' ',FirstName)as [Nameler] from Employees

Select FirstName, LEN(FirstName) as [Namenin uzunlugu] from Employees

--Column Name,Start Point,Length
Select City, SUBSTRING(City,2,3) from Customers


Select CHARINDEX('u','yusif') as 'Yusifin u-un yeri'


Select TRIM('   Yusif Pirquliyev   ') as 'Name'

Select REPLACE('Set Academy','s',UPPER('j')) as 'Academy'


Select SPACE(5) + 'salammm'

--ToString()

SELECT SQL_VARIANT_PROPERTY(STR(5), 'BaseType') AS DataType

SELECT SQL_VARIANT_PROPERTY(5, 'BaseType') AS DataType


Select CEILING(21.75)
Select Floor(21.75)



Select Round(21.753423423,3)

Select ABS(-5) 

Select PI()

Select POWER(5,2)


Select SQUARE(5)

Select SQRT(25)

Select CURRENT_TIMESTAMP
Select GETDATE()

Select GETUTCDATE()

Select DATEDIFF(HOUR,GETUTCDATE(), GetDate())

Select DATEDIFF(MONTH,'11.12.2003',GetDate())


--Select CAST(5.5 as int)
SELECT SQL_VARIANT_PROPERTY(CAST(5 as int), 'BaseType') AS DataType

Select CONVERT(int,'asdasd')

Select PARSE('11.12.2003'as date)


Select CHOOSE(2,'Celil','Azima','Idris','Yusif','Nijat')


Select IIF( DATEDIFF(day, '11.12.2003','12.14.2003')>0 ,'Nijat','Azima')


Select NULLIF('yusiz','Yusiz') 

Select Coalesce('Nijat','Yusif')