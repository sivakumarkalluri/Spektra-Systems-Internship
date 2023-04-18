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
            Console.Write("Enter the Principle Amount (P) : ");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Time (T) : ");
            int t = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Rate of Interest (R) : ");
            int r = Convert.ToInt32(Console.ReadLine());

            float SI = (float)(p * t * r) / 100;

            Console.WriteLine("Calculated Interest is : " + SI);

        }
    }
}
