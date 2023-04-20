using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            string directory = @"C:\Spektra Systems\Spektra-Systems-Internship\Assignment (20-04-2023)\Assignment1\MyDir";
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            string file1 = @"C:\Spektra Systems\Spektra-Systems-Internship\Assignment (20-04-2023)\Assignment1\MyDir\file1.txt";
            if (!File.Exists(file1))
            {
                File.Create(file1);
            }
            else
            {
                File.WriteAllText(file1,"Text inside File1");
               
            }

            string file2 = @"C:\Spektra Systems\Spektra-Systems-Internship\Assignment (20-04-2023)\Assignment1\MyDir\file2.txt";
            if (!File.Exists(file2))
            {
                File.Create(file2);


            }
            else
            {
                File.WriteAllText(file2, "Text inside File2");
            }
            Console.WriteLine(File.ReadAllText(file1));
            Console.WriteLine(File.ReadAllText(file2));





        }
    }
}
