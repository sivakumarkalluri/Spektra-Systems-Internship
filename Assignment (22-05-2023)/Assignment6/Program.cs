using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Assignment6
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
                    string query = "select * from dbo.student where rollno=@id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    Console.Write("Enter the RollNo Data you want to find : ");
                    int roll = Convert.ToInt32(Console.ReadLine());
                    cmd.Parameters.AddWithValue("@id", roll);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Console.WriteLine("RollNo: " + dr["rollno"] + "  Name: " + dr["name"] + "  Age: " + dr["age"] + "  Class:" + dr["class"]);
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
