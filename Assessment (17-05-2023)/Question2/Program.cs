using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of a : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of b : ");
            int b = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("\nBefore Swapping Value of a : " + a);
            Console.WriteLine("Before Swapping Value of b : " + b);

            Console.WriteLine("\n\n********* Swapping is Done ************\n\n");

            swap(ref a,ref b);

            Console.WriteLine("After Swapping Value of a : " + a);
            Console.WriteLine("After Swapping Value of b : " + b);

        }
        static void swap( ref int a,ref int b)
        {
            int temp = a;
            a= b;
            b= temp;


        }
    }
}
