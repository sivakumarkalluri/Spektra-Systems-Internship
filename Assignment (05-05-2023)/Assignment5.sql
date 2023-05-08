select E.BusinessEntityID,CONCAT(P.FirstName,' ',P.MiddleName,' ',P.LastName) as FullName,
E.VacationHours,E.SickLeaveHours,(VacationHours+SickLeaveHours) as Total_Hours_Away 
from HumanResources.Employee E 
inner join Person.Person P on E.BusinessEntityID=P.BusinessEntityID
order by Total_Hours_Away;

