using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        public static bool checkPalindrome(string input,int start,int end)
        {
            if (input.Length <= 1 || start >= end)
                return true;
            else if (input[start] != input[end])
                return false;
           
            return checkPalindrome(input, start + 1, end - 1);
            
           

        }
        static void Main(string[] args)
        {
            Console.Write("Enter the String to check Palindrome or Not : ");
            string input = Console.ReadLine();
            if (checkPalindrome(input, 0, input.Length-1)){
                Console.WriteLine($"{input} is a Palindrome");
            }
            else
            {
                Console.WriteLine($"{input} is \"NOT\" a Palindrome");
            }
        }
    }
}
