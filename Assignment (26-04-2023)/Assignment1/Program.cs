using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;


namespace Assignment1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string file1 = @"C:\Spektra Systems\Spektra-Systems-Internship\Assignment (26-04-2023)\Assignment1\file1.txt";
            if (!File.Exists(file1))
            {
                File.Create(file1);
            }
            else
            {
                File.WriteAllText(file1, "Text inside File1");

            }
            
            string data=await readFile(file1);
            Console.WriteLine(data);
            Console.WriteLine(data.Length);
        }

        static async Task<string> readFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                return await reader.ReadToEndAsync();
            }


        }
    }
}
