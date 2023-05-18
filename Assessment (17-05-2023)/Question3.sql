
create view SalesPersonView as
select S.BusinessEntityID,P.FirstName,P.LastName,
CONCAT(P.FirstName,' ',P.LastName) as FullName,
CONVERT(char(20),CONVERT(int ,salesYTD)) as SalesYTDChar
from Sales.SalesPerson S 
inner join Person.Person P on S.BusinessEntityID=P.BusinessEntityID
where SalesYTD>100000;

select * from SalesPersonView order by SalesYTDChar;

