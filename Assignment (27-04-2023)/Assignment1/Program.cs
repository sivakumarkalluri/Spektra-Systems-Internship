using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    enum Days
    {
        
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the date in Format (dd/MM/yyyy) Format : ");
            string input = Console.ReadLine();
            DateTime date = DateTime.Parse(input);

            Console.WriteLine($"{input} falls on {date.DayOfWeek}");

            Console.Write("Enter the day (1 to 7) : ");
            int d = Convert.ToInt32(Console.ReadLine());
            int count = 1;

            foreach (Days day in Enum.GetValues(typeof(Days)))
                {
                if (count == d)
                {
                    Console.WriteLine(day);
                    break;
                }
                count++;

                }
}
    }
}
