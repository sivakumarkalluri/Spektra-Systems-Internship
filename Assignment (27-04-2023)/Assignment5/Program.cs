using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;


namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Spektra Systems\Spektra-Systems-Internship\Assignment (27-04-2023)\Assignment5\db.json";
            List < Product > products = JsonConvert.DeserializeObject<List<Product>>(File.ReadAllText(filePath));

            Console.WriteLine("\n\n ********************  Json Data  *********************\n\n");
            foreach (var product in products)
                Console.WriteLine($"Product ID : {product.productID} \t Product Name :{product.productName} \t\t Product Price : {product.price} \t Product Quantity : {product.qty}");

            Console.WriteLine("\n\n *******************************************************\n\n");
            
        }

        class Product
        {
            public string productID { get; set; }
            public string productName { get; set; }
            public int price { get; set; }
            public int qty { get; set; }
        }
    }

}
