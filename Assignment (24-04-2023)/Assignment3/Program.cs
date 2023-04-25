using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
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
                Console.Write("Enter the Employee Experience : ");
                int exp = Convert.ToInt32(Console.ReadLine());
                Emps[i] = new Employee(ID,name,role,exp);

            }

            Console.WriteLine("\n\n ************  Employee Details  **************\n\n");

            foreach (var item in Emps)
            {
                Console.WriteLine("Employee ID :" + item.empID + "\t" + "Employee Name : " + item.empName
                    + "\t" + "Employee Role : " + item.role + "\t" + "Employee Experience : " + item.exp);
            }

           
            while (true)
            {
                Console.Write("\nEnter the ID of Employee you need to find (press 0 to exit) : ");
                int ID = Convert.ToInt32(Console.ReadLine());
                if (ID == 0)
                    break;
                else
                {
                    foreach (var item in Emps)
                    {
                        if(item.empID==ID)
                            Console.WriteLine("\n\nEmployee ID :" + item.empID + "\t" + "Employee Name : " + item.empName
                                + "\t" + "Employee Role : " + item.role + "\t" + "Employee Experience : " + item.exp);
                    }
                }
            }
        }

        public class Employee
        {
            public int empID { get; set; }

            public string empName { get; set; }

            public string role { get; set; }
            public int exp { get; set; }

            public Employee(int empID, string empName, string role, int exp)
            {
                this.empID = empID;
                this.empName = empName;
                this.role = role;
                this.exp = exp;

            }

        }
           
    
    }
}
