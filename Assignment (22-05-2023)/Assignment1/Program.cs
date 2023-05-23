using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string connect = "data source=laptop-n903bui3; database=adventureworks2019; integrated security=sspi";
                using (SqlConnection con = new SqlConnection(connect))
                {
                    string creatingTable = "CREATE TABLE studentDemo (rollno INT ,name VARCHAR(50),age INT,class VARCHAR(20));";
                    string insertingData = "INSERT INTO studentDemo (rollno, name, age, class) VALUES (1, 'John Smith', 18, 'Mathematics'), (2, 'Jane Doe', 17, 'Science'),(3, 'Mike Johnson', 19, 'English')";
  
                    con.Open();
                    using (SqlCommand createTableCmd = new SqlCommand(creatingTable, con)) 
                    {
                        createTableCmd.ExecuteNonQuery();
                    }

                    Console.WriteLine("\nTable Created Successfully..........\n");

                    using (SqlCommand insertTableCmd = new SqlCommand(insertingData, con))
                    {
                        insertTableCmd.ExecuteNonQuery();
                    }

                    Console.WriteLine("\nData inserted Successfully..........\n");

                    SqlCommand cmd = new SqlCommand("select * from dbo.studentDemo", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Console.WriteLine(dr["rollno"] + "  " + dr["name"] + "  " + dr["age"] + "  " + dr["class"]);
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
