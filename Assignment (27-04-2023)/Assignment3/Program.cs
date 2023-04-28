using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Task<int> t1 = Task.Run(() =>
            {
                return sum(num1, num2);
                }
            );
            t1.ContinueWith((t) =>
            {
                Console.WriteLine($"Addition Operation {num1} + {num2} = {t.Result}");
                }
            );

            Task<int> t2 = Task.Run(() =>
            {
                return multiply(num1, num2);
            }
            );
            t2.ContinueWith((t) =>
            Console.WriteLine($"Multiplication Operation {num1} * {num2} = {t.Result}")
            );

            Console.ReadLine();

        }

        static int sum(int num1,int num2)
        {
            int result = num1 + num2;
            return result;

        }
        static int multiply(int num1, int num2)
        {
            int result = num1 * num2;
            System.Threading.Thread.Sleep(2000);
            return result;
            
        }
    }
}
