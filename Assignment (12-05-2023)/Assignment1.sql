
CREATE PROCEDURE EmployeeData
as
select CONCAT(p.FirstName,' ',p.MiddleName,' ',P.LastName) as EmpName,E.NationalIDNumber,E.JobTitle
from HumanResources.Employee E 
inner join Person.Person p on p.BusinessEntityID=E.BusinessEntityID;

EXEC EmployeeData;
