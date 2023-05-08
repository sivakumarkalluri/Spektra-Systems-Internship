select D.DepartmentID,D.Name,E.JobTitle,COUNT(E.BusinessEntityID) as Total_Employees 
from HumanResources.Employee E 
inner join HumanResources.EmployeeDepartmentHistory H on E.BusinessEntityID=H.BusinessEntityID
inner join HumanResources.Department D on H.DepartmentID=D.DepartmentID
where D.DepartmentID in (12,14)
group by D.DepartmentID,D.Name,E.JobTitle;

select COUNT(E.BusinessEntityID) as CompanyTotal
from HumanResources.Employee E 
inner join HumanResources.EmployeeDepartmentHistory H on E.BusinessEntityID=H.BusinessEntityID
inner join HumanResources.Department D on H.DepartmentID=D.DepartmentID
where D.DepartmentID in (12,14);