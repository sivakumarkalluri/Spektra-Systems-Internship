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

            //Creating Array of Objects for Courses
            Course[] courses = new Course[3];
            courses[0] = new Course("CSE");
            courses[1] = new Course("ECE");
            courses[2] = new Course("Mech");
            
            //*********   Adding Students Data Dynamically  **********
            
            while (true)
            {
                Console.Write("Do you want to Add Student ( y / n) : ");
                string input = Console.ReadLine();

                if (input == "n")
                    break;

                Console.Write($"\nEnter RollNumber : ");
                int roll = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Enter Name : ");
                string name = Console.ReadLine();
                Console.Write($"Enter Age : ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Enter Course Enrolled : ");
                string course = Console.ReadLine();

                //******* Adding Students data according to their course  *********
                if (course == "cse")
                    courses[0].addStudent(roll, name, age, course);
                else if (course == "ece")
                    courses[1].addStudent(roll, name, age, course);
                else if (course == "mech")
                    courses[2].addStudent(roll, name, age, course);
                else
                    Console.WriteLine("Enter the Course name Correctly (ece, cse, mech)");
                Console.WriteLine("\n\n");

            }

            // ********** Displaying the Students details by their Courses Enrolled *******
            foreach(var item in courses)
            {
                item.DisplayData();
            }

        }


        // *********** Course Class *******
        class Course
        {
            public string courseName { get; set; }
            public List<Students> data=new List<Students>();
            public Course(string course)
            {
                this.courseName = course;
               
            }

            //****** Adding the new Student  **********
            public void addStudent(int roll, string name, int age, string course)
            {
                
                Students st = new Students(roll, name, age, course);
                this.data.Add(st);
                  
            }

            // Printing the students data by Course Name
            public void DisplayData()
            {
                Console.WriteLine($"\n\n **************  Students who are enrolled in \"{this.courseName}\"  *****************\n\n");
                foreach (var st in data)
                {

                    Console.Write($"RollNo : {st.rollNo}\t");
                    Console.Write($"Name : {st.name}\t");
                    Console.Write($"Age : {st.age}\t");
                    Console.Write($"Course : {st.course}\t");
                    Console.WriteLine();

                }
            }
        }


        // ******* Students Class ***********
        class Students
        {
            public int rollNo { get; set; }
            public string name { get; set; }
            public int age { get; set; }
            public string course { get; set; }

            public Students(int roll,string name,int age,string course)
            {
                this.rollNo = roll;
                this.name = name;
                this.age = age;
                this.course = course;
            }


        }
    }
}
