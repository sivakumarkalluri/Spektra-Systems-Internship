using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Number of Customers you want to Enter : ");
            int size = Convert.ToInt32(Console.ReadLine());

            Customer[] Custs = new Customer[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("\n\n************* Enter the Details of Customer " + (i + 1) + "  ************\n");

                Console.Write("Enter the  ID : ");
                int ID = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the Customer Name : ");
                string name = Console.ReadLine();
                Console.Write("Enter the Customer City : ");
                string city = Console.ReadLine();
                Console.Write("Enter the Customer Country : ");
                string country = Console.ReadLine();
                Custs[i] = new Customer(ID, name, city, country);

            }

            Console.WriteLine("\nDo you want to Display Data ( y / n )");
            string input = Console.ReadLine();
            Predicate<string> display = delegate (string ip) {
                if (ip == "y")
                    return true;
                else
                    return false;
            };

            if (display(input))
            {
                foreach (var item in Custs)
                {

                    Console.WriteLine("\n\nCustomer ID :" + item.custID + "\t" + "Customer Name : " + item.custName
                        + "\t" + "Customer city : " + item.city + "\t" + "Customer countryerience : " + item.country);
                }
            }




        }

        public class Customer
        {
            public int custID;

            public string custName;

            public string city;
            public string country;

            public Customer(int custID, string custName, string city, string country)
            {
                this.custID = custID;
                this.custName = custName;
                this.city = city;
                this.country = country;

            }

        }


    }
}
