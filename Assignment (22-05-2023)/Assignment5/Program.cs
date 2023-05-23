using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Assignment5
{
    class Program
    {
        public static void deleteData(int roll, SqlConnection con)
        {

            string query = "delete from dbo.student where rollno=@id";
            SqlCommand cmd1 = new SqlCommand(query, con);
 
            cmd1.Parameters.AddWithValue("@id", roll);
            con.Open();
            int affectedRows = cmd1.ExecuteNonQuery();
            con.Close();

            Console.WriteLine("Effected Rows: " + affectedRows);

        }

        public static void addData(int roll,string name,int age,int clas, SqlConnection con)
        {
            string query = "Insert into dbo.student (rollno,name,age,class) values (@roll,@name,@age,@class)";
            SqlCommand cmd1 = new SqlCommand(query, con);
            cmd1.Parameters.AddWithValue("@roll", roll);
            cmd1.Parameters.AddWithValue("@name", name);
            cmd1.Parameters.AddWithValue("@age", age);
            cmd1.Parameters.AddWithValue("@class", clas);

            con.Open();
            int affectedRows = cmd1.ExecuteNonQuery();
            con.Close();

            Console.WriteLine("Effected Rows: " + affectedRows);
        }
        public static void update(int id,int age, SqlConnection con)
        {

            string query = "update dbo.student set age=@age where rollno=@id";
            SqlCommand cmd1 = new SqlCommand(query, con);
            cmd1.Parameters.AddWithValue("@age", age);
            cmd1.Parameters.AddWithValue("@id", id);

            con.Open();
            int affectedRows = cmd1.ExecuteNonQuery();
            con.Close();

            Console.WriteLine("Effected Rows: " + affectedRows);

        }

        public static void print(SqlConnection con)
        {
           
               
                    SqlCommand cmd = new SqlCommand("select * from dbo.student", con);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                   
                    Console.WriteLine("\n\n*********** Student Data ***********\n\n");
                    while (dr.Read())
                    {
                        Console.WriteLine("RollNo: "+dr["rollno"] + "  Name: " + dr["name"] + "  Age: " + dr["age"] + "  Class:" + dr["class"]);
                    }
                    con.Close();

        }

        static void Main(string[] args)
        {
            try
            {
                string connect = "data source=laptop-n903bui3; database=adventureworks2019; integrated security=sspi";
                using (SqlConnection con = new SqlConnection(connect))
                {
                    

                    while (true)
                    {
                        Console.WriteLine("\n\nChoose Your CRUD Operation \n1. Print Data \n2. Add Data \n3. Edit Data \n4. Delete Data \n5. Exit");
                        Console.Write("Enter your Option : ");
                        int input = Convert.ToInt32(Console.ReadLine());
                        if (input == 5)
                            break;
                        else if (input == 1)
                            print(con);
                        else if (input == 2)
                        {
                            Console.WriteLine("\n\n*************** Adding Data  ************\n\n");
                            Console.Write("Enter the rollNo : ");
                            int roll = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter the Name : ");
                            string Name = (Console.ReadLine());
                            Console.Write("Enter the age : ");
                            int Age = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter the Class : ");
                            int clas = Convert.ToInt32(Console.ReadLine());
                            addData(roll, Name, Age, clas,con);
                            Console.WriteLine("\nAdded SuccessFully...........\n");

                        }
                        else if (input == 3)
                        {
                            Console.WriteLine("\n\n*************** Editing Data  ************\n\n");
                            Console.Write("Enter the rollNo : ");
                            int roll = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter the age you want to edit: ");
                            int Age = Convert.ToInt32(Console.ReadLine());
                            update(roll, Age,con);
                            Console.WriteLine("\nEdited SuccessFully...........\n");
                        }
                        else if (input == 4)
                        {
                            Console.WriteLine("\n\n*************** Deleting Data  ************\n\n");
                            Console.Write("Enter the rollNo you want to Delete : ");
                            int roll = Convert.ToInt32(Console.ReadLine());
                            deleteData(roll,con);
                            Console.WriteLine("\nDeleted SuccessFully...........\n");

                        }
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
                Console.ReadKey();
               
            }

        
    }
}
