using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number of rows");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of Columns");
            int col = Convert.ToInt32(Console.ReadLine());

            //Declaring 2D Array
            int[,] array = new int[rows,col];
            for(int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.WriteLine("Enter value of array[" + i + "][" + j + "] ");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }

            //Displaying Array Values
            Console.WriteLine("Array Values are : ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.WriteLine("array[" + i + "][" + j + "] = "+array[i,j]);
                  
                }
            }
        }
    }
}
