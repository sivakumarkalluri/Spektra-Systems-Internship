using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTables;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (AdventureWorks2019Entities DBAdvWorks=new AdventureWorks2019Entities())
            {
                var Output=from customer in DBAdvWorks.Customers
                           join sale in DBAdvWorks.SalesOrderHeaders on customer.CustomerID equals sale.CustomerID
                           join person in DBAdvWorks.People on customer.PersonID equals person.BusinessEntityID 
                           join territory in DBAdvWorks.SalesTerritories on customer.TerritoryID equals territory.TerritoryID
                           where customer.PersonID!=null
                           group new { customer, person, territory,sale } by new
                           {
                               customer.CustomerID,
                               person.FirstName,
                               person.MiddleName,
                               person.LastName,
                               customer.AccountNumber,
                               customer.TerritoryID,
                               territory.Name,
                               territory.CountryRegionCode
                           } into g
                           orderby g.Sum(x => x.sale.SubTotal) descending
                           select new
                           {
                               CustomerID = g.Key.CustomerID,
                               FullName = g.Key.FirstName + " " + g.Key.MiddleName + " " + g.Key.LastName,
                               AccountNumber = g.Key.AccountNumber,
                               TerritoryID = g.Key.TerritoryID,
                               Territory_Name = g.Key.Name,
                               CountryCode = g.Key.CountryRegionCode,
                               Total_Sales = g.Sum(x => x.sale.SubTotal)
                           };

                var top10Items = Output.Take(10).ToList();
                var table = new ConsoleTable("CustomerID", "FullName", "AccountNumber", "TerritoryID", "Territory_Name", "CountryCode", "Total_Sales");

                foreach (var item in top10Items)
                {
                    table.AddRow(item.CustomerID, item.FullName, item.AccountNumber, item.TerritoryID,
                        item.Territory_Name, item.CountryCode, item.Total_Sales);
                }

                Console.WriteLine("\n\t\t\t ***********************************************************************");
                Console.WriteLine("\t\t\t ****************  Top 10 Customers with Maximum Sales  ****************");
                Console.WriteLine("\t\t\t ***********************************************************************\n");

                // Print the table
                Console.WriteLine(table.ToString());


            }
        }
    }
}
