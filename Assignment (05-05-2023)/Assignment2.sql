select SalesOrderID,sum(LineTotal) as Total_Cost from Sales.SalesOrderDetail
group by SalesOrderID having SUM(LineTotal)>100000;

select SalesOrderID,SubTotal from Sales.SalesOrderHeader where SubTotal>100000;