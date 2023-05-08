select count(SalesOrderDetailID) as Total_Orders,ProductID from Sales.SalesOrderDetail 
group by ProductID;