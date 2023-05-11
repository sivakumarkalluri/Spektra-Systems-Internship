
select Concat(P.FirstName,' ',P.MiddleName,' ',P.LastName) as FullName,A.*
from (select 
e.BusinessEntityID,e.JobTitle,e.VacationHours,
rank() over(partition by jobtitle order by e.VacationHours asc) as rn
from HumanResources.Employee e) as A inner join Person.Person P on A.BusinessEntityID=P.BusinessEntityID where A.rn=1;