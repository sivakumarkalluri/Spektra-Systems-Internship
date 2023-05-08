select P.Name,COALESCE(CONVERT(varchar(20), O.ProductID),'Not Ordered') as ProductID,
COALESCE(CONVERT(varchar(20), O.SalesOrderID),'Not Ordered') as SalesOrderID
from Sales.SalesOrderDetail O right outer join Production.Product P on O.ProductID=P.ProductID;