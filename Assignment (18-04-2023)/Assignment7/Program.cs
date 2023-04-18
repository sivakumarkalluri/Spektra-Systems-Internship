using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of Rows");
            int rows = Convert.ToInt32(Console.ReadLine());

            //Declaring Jagged Array
            int[][] jagged = new int[rows][];

            //Assinging values to Jagged Array
            for(int i = 0; i < rows; i++)
            {
                Console.WriteLine("\nEnter number of columns in Row " + i);
                int col = Convert.ToInt32(Console.ReadLine());
                jagged[i] = new int[col];

                for(int j=0; j<col; j++)
                {
                    Console.Write("Enter value of array[" + i + "][" + j + "] ");
                    jagged[i][j]= Convert.ToInt32(Console.ReadLine());

                }

            }

            //Displaying Values

            Console.WriteLine("\nValues in Jagged Array: \n");

            for(int i = 0; i < rows; i++)
            {
                for(int j=0; j < jagged[i].Length; j++)
                {
                    Console.Write(jagged[i][j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
