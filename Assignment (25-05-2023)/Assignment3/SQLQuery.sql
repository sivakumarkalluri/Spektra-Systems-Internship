select D.ProductID,P.Name as ProductName,P.ProductNumber,P.Color,S.Name as ProductSubCategory,C.Name as ProductCategory,
SUM(D.OrderQty) as Total_Qty,
SUM(D.OrderQty*UnitPrice) as Total_Sales_Amount
from Sales.SalesOrderDetail D
inner join Production.Product P 
on P.ProductID=D.ProductID
inner join Production.ProductSubcategory S
on S.ProductSubcategoryID=P.ProductSubcategoryID 
inner join Production.ProductCategory C
on C.ProductCategoryID=S.ProductCategoryID

group by D.ProductID,P.Name,P.ProductNumber,P.Color,S.Name,C.Name
having SUM(D.OrderQty*UnitPrice)=(select Max(TotalQty) as Total_Qty
 FROM
            (SELECT
                SUM(D.OrderQty*UnitPrice) AS TotalQty
            FROM
                Sales.SalesOrderDetail D
            GROUP BY
                D.ProductID) AS Subquery)
order by Total_Qty,Total_Sales_Amount ;