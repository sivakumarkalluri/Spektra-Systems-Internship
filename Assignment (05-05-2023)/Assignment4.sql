select D.DepartmentID,D.Name,count(H.BusinessEntityID) as TotalEmployees,
MIN(P.Rate) as Min_Salary ,Max(P.Rate) as Max_Salary,
AVG(P.Rate) as Avg_Salary
from HumanResources.EmployeeDepartmentHistory H 
inner join HumanResources.EmployeePayHistory P on H.BusinessEntityID=P.BusinessEntityID
inner join HumanResources.Department D on H.DepartmentID=D.DepartmentID
group by D.DepartmentID,D.Name;