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

            while (true)
            {
                Console.Write("\n\nEnter the Number1 : ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the Number2 : ");

                double b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the Operation you want to Perform (+, -, *, /) : ");

                string op = Console.ReadLine();
                Console.WriteLine("\n******* Result ********");

                switch (op)
                {
                    case "+":
                        {
                            Func<double,double,double> addOp = (num1,num2)=>num1+num2;
                            Console.WriteLine($"{a} + {b} = { addOp(a, b)}");
                            break;
                        }
                    case "-":
                        {
                            Func<double, double, double> subOp = (num1, num2) => num1 - num2;
                            Console.WriteLine($"{a} - {b} = { subOp(a, b)}");
                            break;
                        }
                    case "*":
                        {
                            Func<double, double, double> multiplyOp = (num1, num2) => num1 * num2;
                            Console.WriteLine($"{a} x {b} = { multiplyOp(a, b)}");
                            break;
                        }
                    case "/":
                        {
                            Func<double, double, double> divOp = (num1, num2) => num1 / num2;
                            Console.WriteLine($"{a} / {b} = { divOp(a, b)}");
                            break;
                        }
                    default:
                        Console.WriteLine("Enter the proper Operation (+, -, *, /)");
                        break;
                }
            }


        }
    }
}
