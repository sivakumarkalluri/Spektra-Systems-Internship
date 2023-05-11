/*select * from 
(select S.BusinessEntityID,S.SalesQuota from Sales.SalesPerson S 
inner join Sales.SalesPersonQuotaHistory Q on S.BusinessEntityID=Q.BusinessEntityID
) as source
pivot(
sum(Source.SalesQuota) for Source.BusinessEntityId
in(differ)
) as X;*/




select BusinessEntityID,SalesQuota,DATEPART(quarter, QuotaDate) AS Quarter
    , datepart(year,QuotaDate) AS SalesYear,
	SalesQuota -First_Value(SalesQuota)
	over (partition by BusinessEntityID,datepart(year,QuotaDate)
	order by DATEPART(quarter,QuotaDate)) as 'Current Quarter - First Quarter Quota' ,
	SalesQuota -Last_Value(SalesQuota) 
	over (partition by BusinessEntityID,datepart(year,QuotaDate)
	order by DATEPART(quarter,QuotaDate) RANGE BETWEEN CURRENT ROW AND UNBOUNDED FOLLOWING) as 'Current Quarter - Last Quarter Quota' 
	from  Sales.SalesPersonQuotaHistory ORDER BY BusinessEntityID, SalesYear, Quarter;