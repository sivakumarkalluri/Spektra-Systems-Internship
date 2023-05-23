create Procedure fetchFullName 
@productNumber varchar(30)
AS
BEGIN
(select Distinct CONCAT(pe.FirstName,' ',pe.MiddleName,' ',pe.LastName) as FullName from Sales.SalesOrderDetail O
inner join Sales.SalesOrderHeader H
on O.SalesOrderID=H.SalesOrderID
inner join Production.Product P
on P.ProductID=O.ProductID
inner join Person.Person Pe
on H.SalesPersonID=Pe.BusinessEntityID
where ProductNumber=@productNumber);

end;
