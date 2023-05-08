select O.SalesOrderID,

SUM(O.OrderQty) as Total_Orders_Quantity,
AVG(O.OrderQty) as Average_Orders,
Count(O.ProductID) as Total_Orders, 
MAX(O.OrderQty) as Maximum_Order, 
MIN(O.OrderQty) as Minimum_Order 
from Sales.SalesOrderDetail O 
where O.SalesOrderID in(43659,43664) group by O.SalesOrderID;


select 
P.Name,
O.SalesOrderID,
O.ProductID,
SUM(O.OrderQty) as Total_Orders_Quantity,
AVG(O.OrderQty) as Average_Orders,
Count(O.ProductID) as Total_Orders, 
MAX(O.OrderQty) as Maximum_Order, 
MIN(O.OrderQty) as Minimum_Order 
from Sales.SalesOrderDetail O
inner join Production.Product P
on O.ProductID=P.ProductID
where O.SalesOrderID in(43659,43664)
group by O.ProductID,P.Name,O.SalesOrderID ;