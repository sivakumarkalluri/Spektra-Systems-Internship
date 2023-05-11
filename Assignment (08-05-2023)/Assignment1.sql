
 select Customerid,
  SUM(SubTotal) as Total_Sales,
  RANK() over(order by SUM(SubTotal) desc) as rank
  from Sales.SalesOrderHeader O group by CustomerID ;