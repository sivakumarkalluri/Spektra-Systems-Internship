select 
P.ProductID,P.Name,P.ProductNumber,I.Quantity,I.LocationID,L.Name as LocationName
into productDetails
from Production.Product P inner join Production.ProductInventory I on P.ProductID=I.ProductID
inner join Production.Location L on L.LocationID=I.LocationID 

--drop table ProductDetails;
select * from productDetails;