select Distinct CONCAT(pe.FirstName,' ',pe.MiddleName,' ',pe.LastName) as FullName from Sales.SalesOrderDetail O
inner join Sales.SalesOrderHeader H
on O.SalesOrderID=H.SalesOrderID
inner join Production.Product P
on P.ProductID=O.ProductID
inner join Person.Person Pe
on H.SalesPersonID=Pe.BusinessEntityID
where ProductNumber='HL-U509-R';

select  * from Sales.SalesOrderDetail O
inner join Sales.SalesOrderHeader H
on O.SalesOrderID=H.SalesOrderID
inner join Production.Product P
on P.ProductID=O.ProductID
select * from Person.Person where BusinessEntityID=279;
select * from Production.Product where ProductID=776;