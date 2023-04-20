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

            ////******* using Generic List *****

            //Console.Write("Enter the number of Items : ");
            //int size=Convert.ToInt32(Console.ReadLine());
            //List<string> data = new List<string>();

            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write("Enter your Item "+ (i+1)+" : ");
            //    data.Add(Console.ReadLine());
            //}


            //data = data.Distinct().ToList();
            //data.Sort();

            //Console.WriteLine("The sorted Items are ");

            //foreach (var item in data)
            //    Console.WriteLine(item);


            ////********* using Generic SortedSet  ************

            Console.Write("Enter the number of Items : ");
            int size = Convert.ToInt32(Console.ReadLine());
            SortedSet<string> data = new SortedSet<string>();

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter your Item " + (i + 1) + " : ");
                data.Add(Console.ReadLine());
            }


            Console.WriteLine("The sorted Items are ");

            foreach (var item in data)
                Console.WriteLine(item);


            ////******* using Generic SortedList  ******

            //SortedList<string, int> data = new SortedList<string, int>();
            //for(int i = 0; i < size; i++)
            //{
            //    Console.Write("Enter your first key Item : ");
            //    data.Add(Console.ReadLine(), i);
            //}

            //Console.WriteLine("The sorted Items are ");
            //foreach (var item in data)
            //    Console.WriteLine(item.Key);

          

        }
    }
}
