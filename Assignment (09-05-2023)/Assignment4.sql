select * from
(select P.Name,C.Name as Product_Category,MIN(ListPrice) as Min_Price,Rank() over(partition by C.ProductCategoryID order by MIN(ListPrice)) as Rn from Production.Product P
inner join Production.ProductSubcategory S on P.ProductSubcategoryID=S.ProductSubcategoryID
inner join Production.ProductCategory C on C.ProductCategoryID=S.ProductCategoryID 
group by C.ProductCategoryID,P.Name,C.Name) as X where X.Rn=1 ;


select P.Name,C.Name as Product_Category,ListPrice,FIRST_VALUE(P.Name) over(partition by C.NAme order by ListPrice asc) as LeastPriceProduct from Production.Product P
inner join Production.ProductSubcategory S on P.ProductSubcategoryID=S.ProductSubcategoryID
inner join Production.ProductCategory C on C.ProductCategoryID=S.ProductCategoryID 
;