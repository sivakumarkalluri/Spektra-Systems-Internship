select COALESCE(CONVERT(varchar(20), S.SalesOrderID),'PRODUCT-NOT-FOUND') AS SALES_SALESID,COALESCE(CONVERT(varchar(20), S.PRODUCTID),'PRODUCT-NOT-FOUND') as sales_ProductID, P.ProductID as product_productId,p.Name
from Production.Product P Full outer join Sales.SalesOrderDetail S on S.ProductID=P.ProductID order by Name;
