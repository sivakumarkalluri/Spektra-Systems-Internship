create view dbo.SalesPerson_Data as
select Distinct P.FirstName,
AVG(SubTotal) as average_Sales_Amount,SUM(SubTotal) as Total_Sales_Amount 
from Sales.SalesOrderHeader S inner join Person.Person P 
on S.SalesPersonID=P.BusinessEntityID group by S.SalesPersonID,P.FirstNAme ;

select * from dbo.SalesPerson_Data