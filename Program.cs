using System.Net.Http.Headers;

namespace Prog_OOP_Midterm_Part1_MatthewVargas
{
    //Matthew F Vargas
    internal class Program
    {
        
        static void Main()
        {
            List<Product> productList = new List<Product>();
            List<string> dataList = MyDatabase.Data;
            Groceries banana = new Groceries("Banana", 0.99, "2024-02-10");
            Clothing tshirt = new Clothing("T-shirt", 19.99, "Medium", "Red");
            Electronics smartphone = new Electronics("Smartphone", 799.99, "Apple");

            productList.Add(tshirt);
            productList.Add(smartphone);
            productList.Add(banana);

            foreach (string item in dataList)
            {
                Console.WriteLine(item);
            }
            List<string> myLocalList = new List<string> { };

            // Display or manipulate the local list as needed.
            foreach (string item in myLocalList)
            {
                Console.WriteLine(item);
            }
            // Using our UpdateConfig method to change our connection string. Make sure to pass in the correct information
            Config.UpdateConnectionString("CramberryFarms", "training", "Admin", "1234");

            // Saving the connectionString to a local variable
            string connectionString = Config.ConnectionString;

            // Using the Database.ConnectToDatabase() method that takes a formatted connection string to connect
            Database db = Database.ConnectToDatabase(connectionString);

            // If it connects, grab the data as a list of product
            // In the real world theres a lot of framework and code to make this happen
            List<Product> data = db.Data();

            // Display our list of product from the training table.
            foreach (Product d in data)
            {
                d.DisplayProductInfo();
            }
        }
        }
    }
