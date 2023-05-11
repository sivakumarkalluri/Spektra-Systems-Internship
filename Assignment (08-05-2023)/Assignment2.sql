select *
from(
select S.BusinessEntityID,CONCAT(P.FirstName,' ',P.MiddleName,' ',P.LastName) as FullName,S.SalesYTD,S.TerritoryID,A.PostalCode,
ROW_NUMBER() over(partition by A.PostalCode order by A.PostalCode) as rowNumber,
rank() over( order by A.PostalCode) as ranking,
dense_rank() over( order by A.PostalCode) as DenseRank,
NTile(4) over(order by A.PostalCode) as Quartile
from Sales.SalesPerson S inner join Person.Person P on S.BusinessEntityID=P.BusinessEntityID
inner join Person.Address A on A.AddressID=P.BusinessEntityID where S.TerritoryID is not Null and SalesYTD is not NULL) as O;