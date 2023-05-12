
CREATE PROCEDURE EmployeesTop10
as
Begin
Select Top 10 * from(
Select E.BusinessEntityID,CONCAT(P.FirstName,' ',P.MiddleName,' ',P.LastName) as EmpName, E.Rate as Salary,
DENSE_RANK() over(order by E.Rate desc) as SalaryRank
from HumanResources.EmployeePayHistory E
inner join Person.Person P on E.BusinessEntityID=P.BusinessEntityID) as Emp
where Emp.SalaryRank<=10;
end;

Exec EmployeesTop10;


CREATE PROCEDURE EmployeOutput
@ID Int,
@NationalID nvarchar(256) Output
as
Begin
select 
@NationalID=NationalIDNumber from HumanResources.Employee
where BusinessEntityID=@ID
End;

Declare @IDNumber nvarchar(256);

Exec EmployeOutput @ID=4,@NationalID=@IDNumber output;

Select @IDNumber as Salary;
