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
            Console.WriteLine("Enter the size of array");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[size];

            int sum = 0;
            for(int i=0; i < size; i++)
            {
                Console.Write("Enter Number " + (i+1) + " : ");
                array[i] = Convert.ToInt32(Console.ReadLine());
                sum += array[i];
            }

            Console.Write("Average of ");

            for(int i = 0; i < size; i++)
            {
                Console.Write(array[i]+" ");
            }

            float avg = (float) sum / size;

            Console.WriteLine(" is : "+avg);
        }
    }
}
