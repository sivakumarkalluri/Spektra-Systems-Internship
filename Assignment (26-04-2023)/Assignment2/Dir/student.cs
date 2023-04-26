using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
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
                Emps[i] = new Employee(); 
                Console.Write("Enter the Employee ID : ");
                Emps[i]["empID"] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the Employee Name : ");
                Emps[i]["empName"] = Console.ReadLine();
                Console.Write("Enter the Employee Role : ");
                Emps[i]["role"] = Console.ReadLine();
                Console.Write("Enter the Employee Experience : ");
                Emps[i]["exp"]= Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("\n\n ************  Employee Details  **************\n\n");
            
            foreach(var item in Emps)
            {
                Console.WriteLine("Employee ID :"+item["empID"]+"\t"+"Employee Name : "+item["empName"]
                    +"\t"+"Employee Role : "+item["role"]+"\t"+"Employee Experience : "+item["exp"]);
            }
        }

        public class Employee
        {
            int empID; string empName; string role; int exp;

            public Employee()
            {

            }
            public object this[string index]
            {
                get
                {
                    if (index == "empID")
                        return this.empID;
                    else if (index == "empName")
                        return this.empName;
                    else if (index == "role")
                        return this.role;
                    else if (index == "exp")
                        return this.exp;
                    else
                        return "Enter the right index to fetch the data";

                }

                set
                {
                    if (index == "empID")
                        this.empID = (int)value;
                    else if (index == "empName")
                        this.empName = (string)value;
                    else if (index == "role")
                        this.role = (string)value;
                    else if (index == "exp")
                        this.exp = (int)value;
                    else
                        Console.WriteLine("Enter the correct key Value");
                }
            }

        }
    }
}
