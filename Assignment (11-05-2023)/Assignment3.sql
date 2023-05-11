create view dbo.customers_Data as
select OrderDate,count(Distinct CustomerID) as Total_Customers, 
AVG(SubTotal) as average_Sales_Amount,SUM(SubTotal) as Total_Sales_Amount 
from Sales.SalesOrderHeader group by OrderDate ;

--drop view customers_Data;

select * from dbo.customers_Data order by OrderDate;