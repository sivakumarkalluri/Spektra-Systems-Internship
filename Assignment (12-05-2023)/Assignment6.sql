

Go
CREATE FUNCTION GetProductData
(
@productID INT
)

Returns Table 
as
Return
(
Select I.ProductID,P.Name,I.Quantity from Production.ProductInventory I
inner join Production.Product P on I.ProductID=P.ProductID
where I.ProductID=@productID
);

select * from GetProductData(323);