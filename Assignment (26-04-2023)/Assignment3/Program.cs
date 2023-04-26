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
            Console.Write("Enter the Number of Students you want to Enter : ");
            int size = Convert.ToInt32(Console.ReadLine());
            Student[] students = new Student[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"\n****************    Enter Student {i + 1} Details    ***************\n");
                Console.Write("Enter Roll Number : ");
                int roll = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Name : ");
                string name = Console.ReadLine();
                Console.Write("Enter Age : ");
                int age = Convert.ToInt32(Console.ReadLine());
                students[i] = new Student(name, roll, age);

            }


            Console.Write("\n\nEnter the Class Size : ");
            int len = Convert.ToInt32(Console.ReadLine());
            Class[] classes = new Class[len];
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine($"\n****************    Enter Student {i + 1} Details    ***************\n");
                Console.Write("Enter Roll Number : ");
                int roll = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Class : ");
                int cl = Convert.ToInt32(Console.ReadLine());
                classes[i] = new Class(roll, cl);

            }

            var result = from student in students
                         join st in classes
                         on student.rollNo equals st.rollNo
                         where student.age > 18
                         select new
                         {
                             StudentName = student.name,
                             StudentClass = st.stu_class,
                             StudentAge = student.age
                         };

            Console.WriteLine("\n***************  Student Details Whose Age Greater than 18  *********************\n");
            foreach (var item in result)
            {
                Console.WriteLine($"Name : {item.StudentName} \t Class : {item.StudentClass} \t Age: {item.StudentAge}");
            }
            Console.WriteLine("\n********************************************************************************\n");
        }

        class Student
        {
            public string name;
            public int rollNo;
            public int age;
            
            public Student(string name,int rollNo,int age)
            {
                this.name = name;
                this.rollNo = rollNo;
                this.age = age;
            }
        }

        class Class
        {
            public int rollNo;
            public int stu_class;

            public Class(int rollNo,int st_class)
            {
                this.rollNo = rollNo;
                this.stu_class = st_class;
            }

        }
    }
}
