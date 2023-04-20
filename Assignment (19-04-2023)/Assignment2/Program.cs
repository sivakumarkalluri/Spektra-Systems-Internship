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
            Console.Write("Enter Number of Students : ");
            int size = Convert.ToInt32(Console.ReadLine());

            SortedList<int,string> data = new SortedList<int,string>();
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter ID of Student " + (i + 1) + " : ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter NAME of Student " + (i + 1) + " : ");
                string name = Console.ReadLine();

                data.Add(id, name);



            }

            Console.WriteLine("\n\n**************  Students Data *****************");
            
            foreach (var item in data)
                Console.WriteLine("ID : "+item.Key+"\t Name : "+item.Value);


        }
    }
}
