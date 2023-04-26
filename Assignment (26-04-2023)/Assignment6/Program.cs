using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the Number of Employees you want to Enter : ");
            int size = Convert.ToInt32(Console.ReadLine());

            Employee[] Emps = new Employee[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("\n\n************* Enter the Details of Employee " + (i + 1) + "  ************\n");

                Console.Write("Enter the Employee ID : ");
                int ID = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the Employee Name : ");
                string name = Console.ReadLine();
                Console.Write("Enter the Employee Role : ");
                string role = Console.ReadLine();
                Console.Write("Enter the Employee Salary : ");
                int exp = Convert.ToInt32(Console.ReadLine());
                Emps[i] = new Employee(ID, name, role, exp);

            }


            var data = from employees in Emps
                       orderby employees.salary
                       select employees;

            Console.WriteLine("\n\n ***************** Employees Data Sorted by Salary *******************\n\n");
            foreach (var emp in data)
            {
                Console.WriteLine($"Employee Name : {emp.empName} \t Employee ID: {emp.empID} \t Employee Role : {emp.role} \t Employee Salary : {emp.salary}");
            }

            Console.WriteLine("\n\n*************************************************************************************************\n\n");



        }

        public class Employee
        {
            public int empID { get; set; }

            public string empName { get; set; }

            public string role { get; set; }
            public int salary { get; set; }

            public Employee(int empID, string empName, string role, int salary)
            {
                this.empID = empID;
                this.empName = empName;
                this.role = role;
                this.salary = salary;

            }

        }
    }
}
