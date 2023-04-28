using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
           
            while (true)
            {
                Console.WriteLine("\n*******************************************************");
                Console.WriteLine("\n1.Add \n2. Edit \n3. Delete \n4. Display Data \n5. Exit ");
                Console.Write("Enter your Choice : ");
                int input = Convert.ToInt32(Console.ReadLine());

                //******************** Exit Condition *******************
                if (input == 5)
                {
                    break;
                }
                switch (input)
                {

                    //******************** Adding Data *******************

                    case 1:
                        {
                                Console.WriteLine("\n***********  Enter the Product Details for Adding **********\n");
                                Console.Write("\n\nEnter the Product ID : ");
                                int id = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Enter the Product Name : ");
                                string name = Console.ReadLine();
                                Console.Write("Enter the Product Price : ");
                                int price = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Enter the Product Quantity : ");
                                int quantity = Convert.ToInt32(Console.ReadLine());
                                
                                // ********** Creating New Product ************
                                Product newProduct = new Product(id, name, price, quantity);

                                products = products.Append(newProduct).ToList();

                                Console.WriteLine($"\n******** Product with ID : {id} Added Successfully ");

                                break;
                        }

                    //******************** Editing Data *******************

                    case 2:
                        {

                                Console.WriteLine("\n********************************");
                                Console.Write("\n\nEnter the Product Id for Editing : ");
                                int ID = Convert.ToInt32(Console.ReadLine());
                                
                                // ***** Getting the particular ID data  *****
                                Product productToUpdate = products.FirstOrDefault(p => p.id == ID);

                                if (productToUpdate != null)
                                {
                                    Console.WriteLine("\n1. Edit ID \n2. Edit Name \n3. Edit Price \n4. Edit Quantity");
                                    Console.Write("Enter your Choice : ");

                                int edit = Convert.ToInt32(Console.ReadLine());
                                    switch (edit)
                                    {
                                        case 1:
                                            {
                                                Console.Write("\nEnter new ID : ");
                                                int newID = Convert.ToInt32(Console.ReadLine());
                                                productToUpdate.id = newID;
                                                Console.WriteLine($"\n*** {ID} edited to {newID} ***");
                                                break;
                                            }
                                        case 2:
                                            {
                                                Console.Write("\nEnter new Name : ");
                                                string newName = Console.ReadLine();
                                                productToUpdate.name = newName;
                                                Console.WriteLine($"\n*** {ID} Name edited to {newName} ***");
                                                break;
                                            }
                                        case 3:
                                            {
                                                Console.Write("\nEnter new Price: ");
                                                int newPrice = Convert.ToInt32(Console.ReadLine());
                                                productToUpdate.price = newPrice;
                                                Console.WriteLine($"\n***  {ID}  Price edited to  {newPrice}  ****");
                                                break;
                                            }
                                        case 4:
                                            {
                                                Console.Write("\nEnter new Quantity : ");
                                                int newQty = Convert.ToInt32(Console.ReadLine());
                                                productToUpdate.qty = newQty;
                                                Console.WriteLine($"\n***  {ID}  Quantity edited to  {newQty}  ****");
                                                break;
                                            }
                                        default:
                                            Console.WriteLine("\n*** Wrong Input Entered Enter Between 1 to 4 ***");
                                            break;

                                    }

                                   
                                }
                                else
                                {
                                    Console.WriteLine("\n*** Entered Id is not Present in the Data ***");
                                }
                                break;
                        }

                    //******************** Deleting Data *******************

                    case 3:
                        {
                                Console.WriteLine("\n********************************");

                                Console.Write("\n\nEnter the Product Id for Delete : ");

                                int productToDelete = Convert.ToInt32(Console.ReadLine());
                               
                                products = products.Where(p => p.id != productToDelete).ToList();

                                Console.WriteLine($"\n*** Product with {productToDelete} is Deleted Successfully ***");

                                break;
                        }

                    //******************** Displaying Data *******************

                    case 4:
                        {
                                Console.WriteLine("\n********************************");

                                var data = from prod in products select prod;
                                if(data.Count()==0)
                                {
                                Console.WriteLine("Products Data is Empty");
                                break;
                                }

                                Console.WriteLine("\n\n*******************   Products Data  *****************\n");
                                foreach(var p in data)
                                {
                                    Console.WriteLine($"Product ID : {p.id}\t Name : {p.name} \t Price : {p.price} \t Quantity : {p.qty}");
                                }


                                break;
                        }


                        default:
                            Console.WriteLine("\nEnter the Correct Option Between (1 to 4 ) ");
                            break;
                        


                }


            }
        }
    }

    class Product
    {
        public int id;
        public string name;
        public int price;
        public int qty;

        public Product(int id,string name,int price, int qty)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.qty = qty;
        }
    }
}
