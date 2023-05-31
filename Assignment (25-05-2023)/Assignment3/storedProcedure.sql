CREATE PROCEDURE GetMaxQuantitySalesProducts
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        D.ProductID,
        P.Name AS ProductName,
        P.ProductNumber,
        P.Color,
        S.Name AS ProductSubCategory,
        C.Name AS ProductCategory,
        SUM(D.OrderQty) AS Total_Qty,
        SUM(D.OrderQty * D.UnitPrice) AS Total_Sales_Amount
    FROM
        Sales.SalesOrderDetail D
        INNER JOIN Production.Product P ON P.ProductID = D.ProductID
        INNER JOIN Production.ProductSubcategory S ON S.ProductSubcategoryID = P.ProductSubcategoryID
        INNER JOIN Production.ProductCategory C ON C.ProductCategoryID = S.ProductCategoryID
    GROUP BY
        D.ProductID, P.Name, P.ProductNumber, P.Color, S.Name, C.Name
    HAVING
        SUM(D.OrderQty * D.UnitPrice) = (
            SELECT MAX(TotalQty) AS Total_Qty
            FROM (
                SELECT
                    SUM(D.OrderQty * D.UnitPrice) AS TotalQty
                FROM
                    Sales.SalesOrderDetail D
                GROUP BY
                    D.ProductID
            ) AS Subquery
        )
    ORDER BY
        Total_Qty, Total_Sales_Amount;
END

