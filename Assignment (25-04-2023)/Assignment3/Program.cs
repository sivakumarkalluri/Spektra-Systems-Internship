using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        
        public static void addAndDisplay(params string[] names)
        {
            List<string> data=new List<string>();
            foreach (string name in names)
                data.Add(name);
            Console.WriteLine("\n\nThe Names You Entered are : \n");
            foreach (string name in data)
                Console.WriteLine(name);
        }
       
        static void Main(string[] args)
        {
            Console.Write("Enter the Size of List : ");
            int size = Convert.ToInt32(Console.ReadLine());
            string[] input = new string[size];
            for(int i = 0; i < size; i++)
            {
                Console.Write($"Enter Name{i + 1} : ");
                input[i] = Console.ReadLine();
            }
            Action<string[]> Op = addAndDisplay;
            addAndDisplay(input);

        }
    }
}
