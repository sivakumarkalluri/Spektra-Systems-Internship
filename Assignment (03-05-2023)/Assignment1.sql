select SalesPersonID, SUM(SubTotal) as Total_Sales_Amount, Count(SalesPersonID) as Total_Sales, OrderDate
from Sales.SalesOrderHeader
where SalesPersonID is not Null
group by SalesPersonID,OrderDate order by OrderDate; 