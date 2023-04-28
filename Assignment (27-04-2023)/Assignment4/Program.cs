using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Number of Persons you want to Enter : ");
            int size = Convert.ToInt32(Console.ReadLine());

            Person[] Custs = new Person[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("\n\n************* Enter the Details of Persons " + (i + 1) + "  ************\n");

               
                Console.Write("Enter the Persons Name : ");
                string name = Console.ReadLine();
                Console.Write("Enter the  Persons Age : ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the Persons City : ");
               
                string city = Console.ReadLine();
                Custs[i] = new Person(name,age, city);

            }

            string output = JsonConvert.SerializeObject(Custs);
            Console.WriteLine("\n\n******************** Json Data *****************\n\n");
            Console.WriteLine(output);
            Console.WriteLine("\n\n************************************************\n\n");

            string filePath = @"C:\Spektra Systems\Spektra-Systems-Internship\Assignment (27-04-2023)\Assignment4\data.json";
            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }
            else
            {
                File.WriteAllText(filePath, output);

            }
            Console.WriteLine("***********      Json File Created Successfully    ***********");




        }

        public class Person
        {
            

            public string name;
            public int age;
            public string city;
            
            public Person(string custName, int age, string city)
            {
                
                this.name = custName;
                this.age = age;
                this.city = city;
                

            }

        }
    }
}
