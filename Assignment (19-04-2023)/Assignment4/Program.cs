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
            List<string> data = new List<string>();
            Console.WriteLine("Enter the Items ( ** Press q to Exit **)");

            while (true)
            {
                string item = Console.ReadLine();
                if (item == "q")
                    break;
                data.Add(item);

            }

            Console.WriteLine("\nItems you Entered are\n");
            foreach (var item in data)
                Console.WriteLine(item);
        }
    }
}
