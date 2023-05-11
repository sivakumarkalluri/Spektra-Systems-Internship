select * from
(select P.Color,P.ProductID,P.Name,OrderQty as Qty from Production.Product P inner join Sales.SalesOrderDetail S on P.ProductID=S.ProductID  ) as pv
pivot(
sum(Qty) for Pv.Color
in([Black],Blue,
Grey,
Multi,
Red,
Silver,
[Silver/Black],
White,
Yellow)
) as PivotTable ;

select * from
(select P.Color,P.ProductID,P.Name from Production.Product P ) as pv
pivot(
count(Pv.Color) for Pv.Color
in(Black,Blue,
Grey,
Multi,
Red,
Silver,
[Silver/Black],
White,
Yellow)
) as PivotTable;