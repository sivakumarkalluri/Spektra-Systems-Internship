select Distinct CONCAT(Pe.FirstName,' ',Pe.MiddleName,' ',Pe.LastName) as FullName from Production.Product P
inner join Sales.SalesOrderDetail D on p.ProductID=D.ProductID
inner join Sales.SalesOrderHeader O on D.SalesOrderID=O.SalesOrderID
inner join Person.Person Pe on Pe.BusinessEntityID=O.SalesPersonID
where ProductNumber='BK-M68B-42';