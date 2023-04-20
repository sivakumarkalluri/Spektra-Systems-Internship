using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of Items : ");
            int size = Convert.ToInt32(Console.ReadLine());

            SortedList data= new SortedList();
            for(int i = 0; i < size; i++)
            {
                Console.Write("Enter ID of Student " + (i + 1) + " : ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter NAME of Student " + (i + 1) + " : ");
                string name = Console.ReadLine();

                data.Add(id, name);

            }

            Console.WriteLine("\nEnter the Index");
            int index = Convert.ToInt32(Console.ReadLine());
            if (index < 0 || index >= size)
                Console.WriteLine("Index Out of Range");
            else
                Console.WriteLine("Key at Index " + index + " is : " + data.GetKey(index));


        }
    }
}
