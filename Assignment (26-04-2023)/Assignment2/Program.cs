using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] filePaths = Directory.GetFiles(@"C:\Spektra Systems\Spektra-Systems-Internship\Assignment (26-04-2023)\Assignment2\Dir");
            List<string> extensions = new List<string>();
            foreach (var file in filePaths)
                extensions.Add(Path.GetExtension(file).TrimStart('.').ToLower());
            foreach (var file in extensions)
                Console.WriteLine(file);
            Console.Write("Enter the file extension to find the count : ");
            string input = Console.ReadLine();
            var result = from ext in extensions where ext == input select ext;

            Console.WriteLine($"Count of .{input} files is : {result.Count()}");

            Console.WriteLine("\n\n\n****************************************************\n\n\n");

            List<Folder> files = new List<Folder>()
            {
                new Folder(){fileName="file1.cs",dateCreated="26/03/2023",size=40},
                new Folder(){fileName="file2.cs",dateCreated="26/03/2023",size=40},
                new Folder(){fileName="file3.cs",dateCreated="26/03/2023",size=40},
                new Folder(){fileName="file4.cs",dateCreated="26/03/2023",size=40},
                new Folder(){fileName="file5.cs",dateCreated="26/03/2023",size=40},
                new Folder(){fileName="file8.txt",dateCreated="26/03/2023",size=40},
                new Folder(){fileName="file9.txt",dateCreated="26/03/2023",size=40},

            };

            var output = from file in files
                         group file by Path.GetExtension(file.fileName).TrimStart('.')
                         into fileGroup
                         select new { Extension = fileGroup.Key, Count = fileGroup.Count() };
            foreach (var item in output)
            {
                Console.WriteLine($"Extension: {item.Extension}, Count: {item.Count}");
            }



        }

        class Folder
        {
            public string fileName;
            public string dateCreated;
            public int size;
        }
    }
}
