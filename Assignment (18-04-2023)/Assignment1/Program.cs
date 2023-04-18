using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the Sentence");
            string input = Console.ReadLine();
           
            int result = 1;
            for(int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                    result++;

            }

            Console.WriteLine("Total Number of words in the given String \"" + input + "\" is : " + result);
        }
    }
}
