select S.SalesOrderId, sum(OrderQty) as OrderQty ,sum(S.UnitPriceDiscount) as UnitPriceDiscount,sum(TotalDue) as TotalDue
from Sales.SalesOrderDetail S
inner join Sales.SalesOrderHeader O on O.SalesOrderID=S.SalesOrderID
group by S.SalesOrderID having (sum(OrderQty)>5 or sum(S.UnitPriceDiscount)<1000) and sum(TotalDue)>100;