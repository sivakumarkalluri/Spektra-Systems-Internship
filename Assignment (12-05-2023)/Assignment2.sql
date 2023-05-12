
CREATE PROCEDURE SalesQuotaDiffer3
	@EmployeeID INT
As
Begin
select S.BusinessEntityID,S.QuotaDate,S.SalesQuota,
LEAD(S.SalesQuota,1,0) over(partition by S.BusinessEntityID order by S.QuotaDate) as SalesQuotaNext 
from Sales.SalesPersonQuotaHistory S
where S.BusinessEntityID=@EmployeeID;
End;

 
Exec SalesQuotaDiffer3 274;

-----------------------------------------------------------------------------------
--------------------------------------------------------------------------------

GO

CREATE PROCEDURE SalesQuotaDiff4
	
As
Begin
select S.BusinessEntityID,S.QuotaDate,S.SalesQuota, 
LEAD(S.SalesQuota,1,0) over(partition by S.BusinessEntityID order by S.QuotaDate) as SalesQuotaNext
from Sales.SalesPersonQuotaHistory S
;
End;

Exec SalesQuotaDiff4 ;