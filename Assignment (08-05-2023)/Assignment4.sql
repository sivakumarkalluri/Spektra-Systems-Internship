select A.*
from(
select S.BusinessEntityID,S.TerritoryID,t.NAME,S.SalesLastYear,S.SalesYTD,
Lag(S.SalesYTD) over(order by T.Name) as prevRepSales,
case 
when 
S.SalesYTD> LEAD(S.SalesYTD) over(order by T.Name) then 'Higher Than Next Employee'
when 
S.SalesYTD< LEAD(S.SalesYTD) over(order by T.Name) then 'Lesser Than Next Employee'
when
S.SalesYTD= LEAD(S.SalesYTD) over(order by T.Name) then 'Equal to Next Employee'
else
'No Employee is present After'
end as Next_Emp_Sales_YTD_Comparison,

case 
when 
S.SalesYTD> Lag(S.SalesYTD) over(order by T.Name) then 'Higher Than Previous Employee'
when 
S.SalesYTD< Lag(S.SalesYTD) over(order by T.Name) then 'Lesser Than Previous Employee'
when
S.SalesYTD= Lag(S.SalesYTD) over(order by T.Name) then 'Equal to Previous Employee'
else
'No Employee is present Before'
end as Prev_Emp_Sales_YTD_Comparison

from Sales.SalesPerson S inner join Sales.SalesTerritory T on T.TerritoryID=s.TerritoryID) as A ;