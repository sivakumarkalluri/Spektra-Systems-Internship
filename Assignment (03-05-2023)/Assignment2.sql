select Top 1 SalesPersonID,Count(SalesPersonID) as Total_Sales, SUM(SubTotal) as Sales_Amount
from Sales.SalesOrderHeader
group by SalesPersonID
order by Count(SalesPersonID) desc ;
