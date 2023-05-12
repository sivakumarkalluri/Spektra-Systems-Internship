
Go
CREATE FUNCTION GetProductDetail
(
@SalesStartYear DateTime,
@SalesEndYear DateTime
)

Returns Table 
as
Return
(
Select ProductID,Name,SellStartDate from Production.Product
where year(SellStartDate)>=@SalesStartYear and year(SellStartDate)<=@SalesEndYear
);

Select * from GetProductDetail(2010,2013);