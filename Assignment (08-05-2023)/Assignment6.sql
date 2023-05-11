
SELECT * FROM (
select S.ProductID, YEAR(H.OrderDate) as dateOrder,H.SubTotal from Sales.SalesOrderHeader H inner join Sales.SalesOrderDetail S on H.SalesOrderID=S.SalesOrderID) AS PV
pivot(
sum(PV.subTotal) for PV.dateOrder
 in(
[2011],[2012],[2013],[2014]
 ) )as pv;