using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //************ Input Data  ***********
            Console.Write("Enter Number of Employees : ");
            int size = Convert.ToInt32(Console.ReadLine());
           
            //********** Creating Array of Objects ********

            SalesAssociate[] emps=new SalesAssociate[size];

            for(int i = 0; i < size; i++)
            {
                Console.Write("Enter Salary of Employee" + (i + 1)+" : ");
                int salary = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Monthly Sales of Employee" + (i + 1) + " : ");
                int sales= Convert.ToInt32(Console.ReadLine());
                emps[i] = new SalesAssociate(salary,sales);
            }

            // ********* Displaying Output Data ****************

            Console.WriteLine("\n********* Calculated Data *********\n");
            int count = 1;
            foreach(var emp in emps){
                Console.WriteLine("Total Salary (including Bonus) of Employee" + count+" is :"+emp.SalesBonus());
                count++;


            }
            
        }
    }


    //*********** Parent Class ***********
    class Employee
    {
        int salesNumber;

        
        public  void SetNumberOfSales(int num)
        {
            this.salesNumber = num;

        }
        public int GetNumberOfSales()
        {
            return this.salesNumber;
        }



        
    }

    //********** Child Class *******
    class SalesAssociate:Employee
    {
        int Salary;
        float Bonus = 0;
        public SalesAssociate(int salary,int sales)
        {
            this.Salary = salary;
            SetNumberOfSales(sales);
           
        }

        public float SalesBonus()
        {
            int numSales = GetNumberOfSales();

            if (numSales >= 10 && numSales < 20)
                this.Bonus = this.Salary + (((float)5 / 100) * this.Salary);

            else if (numSales >= 20 && numSales < 30)
                this.Bonus = this.Salary + (((float)10 / 100) * this.Salary);

            else if (numSales >= 30)
                this.Bonus = this.Salary + (((float)20 / 100) * this.Salary);

            else
                this.Bonus = this.Salary;

            
            return this.Bonus;

        }

    }
}
