select Top 1 count(SalesOrderID) as Total_Sales, DATENAME(month, GETDATE()) AS ORDER_MONTH 
from Sales.SalesOrderHeader
group by MONTH(OrderDate)
order by Count(SalesOrderID) desc ;
