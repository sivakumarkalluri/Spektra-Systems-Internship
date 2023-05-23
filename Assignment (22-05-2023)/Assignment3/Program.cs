using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Assignment3
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
                    con.Open();
                    string productNumber = "HL-U509-R";
                    // Create and execute the stored procedure
                    SqlCommand cmd = new SqlCommand("fetchFullName", con);

                    cmd.CommandType = CommandType.StoredProcedure;

                    // Adding  parameters to the stored procedure
                    cmd.Parameters.AddWithValue("@productNumber", productNumber);

                    SqlDataReader reader = cmd.ExecuteReader();

                    
                    while (reader.Read())
                    {
                        Console.WriteLine(reader["FullName"].ToString());
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
