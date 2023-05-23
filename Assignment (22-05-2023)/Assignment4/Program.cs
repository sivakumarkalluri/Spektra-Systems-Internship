using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Assignment4
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
                    string storedProcedureQuery = @"create Procedure fetchPersonData 
                                                    @productNumber varchar(30)
                                                    AS
                                                    BEGIN
                                                    (select Distinct CONCAT(pe.FirstName,' ',pe.MiddleName,' ',pe.LastName) as FullName from Sales.SalesOrderDetail O
                                                    inner join Sales.SalesOrderHeader H
                                                    on O.SalesOrderID=H.SalesOrderID
                                                    inner join Production.Product P
                                                    on P.ProductID=O.ProductID
                                                    inner join Person.Person Pe
                                                    on H.SalesPersonID=Pe.BusinessEntityID
                                                    where ProductNumber=@productNumber);end;";
                    SqlCommand cmd = new SqlCommand(storedProcedureQuery, con);
       
                    cmd.ExecuteNonQuery();

                    // Execute the stored procedure
                    string executeProcedureQuery = "EXEC fetchPersonData @productNumber";
                    SqlCommand executeCmd = new SqlCommand(executeProcedureQuery, con);
                    executeCmd.Parameters.AddWithValue("@productNumber", productNumber);

                    SqlDataReader dr = executeCmd.ExecuteReader();
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
        }
    }
}
