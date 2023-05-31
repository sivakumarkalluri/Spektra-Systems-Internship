using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ConsoleTables;

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

                    Console.OutputEncoding = Encoding.UTF8;
                    var data = InitEmployee(dr);
                    string[] columnNames = data.Columns.Cast<DataColumn>()
                                         .Select(x => x.ColumnName)
                                         .ToArray();

                    DataRow[] rows = data.Select();

                    var table = new ConsoleTable(columnNames);
                    foreach (DataRow row in rows)
                    {
                        table.AddRow(row.ItemArray);
                    }
                    table.Write(Format.MarkDown);
                    table.Write(Format.Alternative);
                    table.Write(Format.Minimal);
                    table.Write(Format.Default);
                    Console.Read();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }

        public static DataTable InitEmployee(SqlDataReader dr)
        {
            var table = new DataTable();
            table.Columns.Add("rollno", typeof(int));
            table.Columns.Add("name", typeof(string));
            table.Columns.Add("age", typeof(int));
            table.Columns.Add("class", typeof(string));


            while (dr.Read())
            {
                table.Rows.Add(dr["rollno"], dr["name"], dr["age"], dr["class"]);
                //Console.WriteLine(dr["rollno"] + "  " + dr["name"] + "  " + dr["age"] + "  " + dr["class"]);
            }
            return table;
        }
    }
}