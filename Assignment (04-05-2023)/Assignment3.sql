select E.BusinessEntityID,CONCAT(P.FirstName,' ',P.MiddleName,' ',P.LastName) as FullName, CONVERT(date,E.RateChangeDate) as RateChangeDate,(40 * E.Rate) as Weekly_Salary
from HumanResources.EmployeePayHistory E 
inner join Person.Person P on P.BusinessEntityID=E.BusinessEntityID order by FullName;
