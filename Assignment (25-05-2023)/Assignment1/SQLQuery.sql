select Top 10 C.CustomerID,P.FirstName,C.AccountNumber,C.TerritoryID,T.Name as Territory_Name,T.CountryRegionCode as CountryCode,Sum(SubTotal) as Total_Sales from Sales.Customer C
inner join Sales.SalesOrderHeader H
on H.CustomerID=C.CustomerID
inner join Person.Person P
on P.BusinessEntityID=C.PersonID
inner join Sales.SalesTerritory T
on T.TerritoryID=C.TerritoryID
where C.PersonID is not Null
group by C.CustomerID, P.FirstName,
    C.AccountNumber,
    C.TerritoryID,
    T.Name,
    T.CountryRegionCode order by Total_Sales desc;

	drop table studentDemo;