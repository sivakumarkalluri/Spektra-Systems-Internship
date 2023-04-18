using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number3 : ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int res = (num1 > num2 && num1 > num3) ? num1 : (num2 > num3) ? num2 : num3;
            Console.WriteLine("Largest number among " + num1 + ", " + num2 + ", " + num3 + " is : " + res);


        }
    }
}
