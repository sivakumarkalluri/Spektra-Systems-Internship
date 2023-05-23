using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Assignment2
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
                    string query = @"select Distinct CONCAT(pe.FirstName,' ',pe.MiddleName,' ',pe.LastName) as FullName from Sales.SalesOrderDetail O
                                    inner join Sales.SalesOrderHeader H
                                    on O.SalesOrderID = H.SalesOrderID
                                    inner join Production.Product P
                                    on P.ProductID = O.ProductID
                                    inner join Person.Person Pe
                                    on H.SalesPersonID = Pe.BusinessEntityID
                                    where ProductNumber = @productNumber; ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@productNumber", productNumber);

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Console.WriteLine(dr["FullName"]);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();


            // *************** Using Stored Procedure  *******************8


            //try
            //{
            //    string connect = "data source=laptop-n903bui3; database=adventureworks2019; integrated security=sspi";
            //    using (SqlConnection con = new SqlConnection(connect))
            //    {
            //        con.Open();
            //        string productNumber = "HL-U509-R";
            //        // Create and execute the stored procedure
            //        SqlCommand cmd = new SqlCommand("fetchFullName", con);

            //        cmd.CommandType = CommandType.StoredProcedure;

            //        // Adding  parameters to the stored procedure
            //        cmd.Parameters.AddWithValue("@productNumber", productNumber);

            //        SqlDataReader reader = cmd.ExecuteReader();

            //        //        SqlDataReader reader = cmd.ExecuteReader();
            //        while (reader.Read())
            //        {
            //            Console.WriteLine(reader["FullName"].ToString());
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.ReadKey();
        }
    }
}
