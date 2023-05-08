select Distinct S.BusinessEntityID,CONCAT(P.FirstName,' ',P.LastName) as FullName,
S.TerritoryID,S.SalesYTD,A.PostalCode
from Sales.SalesPerson S 
inner join Person.Person P on P.BusinessEntityID=S.BusinessEntityID 
inner join Person.Address A on S.BusinessEntityID=A.AddressID
where S.SalesYTD!=0 and S.TerritoryID!=0 order by A.PostalCode asc,S.SalesYTD desc;

select S.BusinessEntityID,CONCAT(P.FirstName,' ',P.LastName) as FullName,
S.TerritoryID,S.SalesYTD,A.PostalCode
from Sales.SalesPerson S 
inner join Person.Person P on P.BusinessEntityID=S.BusinessEntityID 
inner join Person.BusinessEntityAddress B on P.BusinessEntityID=B.BusinessEntityID
inner join Person.Address A on S.BusinessEntityID=A.AddressID
where S.SalesYTD!=0 and S.TerritoryID!=0 order by A.PostalCode asc,S.SalesYTD desc;