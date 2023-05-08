select P.ProductModelID,M.Name,max(ListPrice) as ListPrice from Production.Product P
inner join Production.ProductModel M on M.ProductModelID=P.ProductModelID
group by P.ProductModelID,M.Name having MAX(ListPrice)>
2*(Select avg(ListPrice) from Production.Product);

select * from Production.Product ;
select Name from Production.ProductModel order by Name;