using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_OOP_Midterm_Part1
{

    // If you are here, welcome! I appricate your curiosity, it will take you far.
    // This is not a real database, but it does replicate connecting to one
    // Feel free to browse
    // And extra credit if you explain what is happening here ( there's some advanced concepts here )
    // You are also welcome to ask me.

    // Highlight the line of code underneath here and uncomment
    // ctrl + k, u
    #region Uncomment This Code
    //internal class Database
    //{
    //    List<Product> tempData = new List<Product>();

    //    // Driver={SQL Server Native Client 11.0};Server=CramberryFarms;Database=test;Uid=admin;Pwd=password;

    //    static Database _instance = null;

    //    private Database(ConnectionStringParser csp)
    //    {
    //        PopulateData(csp.Database);
    //    }

    //    public static Database ConnectToDatabase(string connectionString)
    //    {
    //        ConnectionStringParser csp = new ConnectionStringParser(connectionString);

    //        if (!csp.IsValid())
    //        {
    //            Console.WriteLine("The Connection String you entered was invalid. Check all of your arguments");
    //            return null;
    //        }

    //        if (!ValidateInfo(csp)) return null;


    //        if (_instance == null)
    //        {
    //            _instance = new Database(csp);
    //        }

    //        return _instance;
    //    }

    //    private void PopulateData(string database)
    //    {
    //        if (database == "training")
    //        {
    //            tempData = new List<Product>
    //            {
    //                new Clothing("T-shirt", 19.99, "Medium", "Red"),
    //                new Electronics("Smartphone", 799.99, "Apple"),
    //                new Groceries("Banana", 0.99, "2024-02-10"),
    //                new Clothing("Jeans", 39.99, "Large", "Blue"),
    //                new Electronics("Laptop", 1499.99, "Dell"),
    //                new Groceries("Apple", 1.99, "2024-02-15"),
    //                new Clothing("Dress", 49.99, "Small", "Black"),
    //                new Electronics("Tablet", 499.99, "Samsung"),
    //                new Groceries("Orange", 0.79, "2024-02-12"),
    //                new Clothing("Jacket", 59.99, "Medium", "Green"),
    //            };
    //            // Add more hardcoded products in different categories for training as needed
    //        }
    //        else
    //        {
    //            tempData = new List<Product> {
    //        new Clothing("T-shirt", 19.99, "Medium", "Red"),
    //        new Electronics("Smartphone", 799.99, "Apple"),
    //        new Groceries("Banana", 0.99, "2024-02-10"),
    //        new Clothing("Jeans", 39.99, "Large", "Blue"),
    //        new Electronics("Laptop", 1499.99, "Dell"),
    //        new Groceries("Apple", 1.99, "2024-02-15"),
    //        new Clothing("Dress", 49.99, "Small", "Black"),
    //        new Electronics("Tablet", 499.99, "Samsung"),
    //        new Groceries("Orange", 0.79, "2024-02-12"),
    //        new Clothing("Jacket", 59.99, "Medium", "Green"),
    //        new Electronics("Smartwatch", 199.99, "Fitbit"),
    //        new Groceries("Grapes", 1.49, "2024-02-14"),
    //        new Clothing("Sweater", 29.99, "Large", "Gray"),
    //        new Electronics("Desktop Computer", 899.99, "HP"),
    //        new Groceries("Pineapple", 2.99, "2024-02-20"),
    //        new Clothing("Hat", 9.99, "One Size", "White"),
    //        new Electronics("Bluetooth Speaker", 79.99, "JBL"),
    //        new Groceries("Mango", 1.29, "2024-02-17"),
    //        new Clothing("Shorts", 29.99, "Medium", "Blue"),
    //        new Electronics("Digital Camera", 299.99, "Canon"),
    //        new Groceries("Cherry", 1.59, "2024-02-25"),
    //        new Clothing("Socks", 4.99, "One Size", "Black"),
    //        new Electronics("Headphones", 149.99, "Sony"),
    //        new Groceries("Watermelon", 3.49, "2024-02-28"),
    //        new Clothing("Gloves", 7.99, "Medium", "Brown"),
    //        new Electronics("Gaming Console", 399.99, "Microsoft"),
    //        new Groceries("Blueberry", 1.69, "2024-03-05"),
    //        new Clothing("Scarf", 12.99, "One Size", "Blue"),
    //        new Electronics("Smartphone 1", 799.99, "Apple"),
    //        new Groceries("Milk", 2.49, "2024-02-10"),
    //        new Clothing("Shorts 1", 24.99, "Large", "Gray"),
    //        new Electronics("Laptop 1", 1499.99, "Dell"),
    //        new Groceries("Eggs", 1.99, "2024-02-15"),
    //        new Clothing("Sweatshirt 1", 34.99, "Large", "Gray"),
    //        new Electronics("Tablet 1", 499.99, "Samsung"),
    //        new Groceries("Bread", 2.99, "2024-02-12"),
    //        new Clothing("Dress 1", 39.99, "Small", "Red"),
    //        new Electronics("Smartwatch 1", 199.99, "Fitbit"),
    //        new Groceries("Apples", 1.29, "2024-02-14"),
    //        new Clothing("Jeans 1", 49.99, "Large", "Black"),
    //        new Electronics("Desktop Computer 1", 899.99, "HP"),
    //        new Groceries("Pasta", 1.49, "2024-02-17"),
    //        new Clothing("Shoes 1", 59.99, "8", "White"),
    //        new Electronics("Digital Camera 1", 299.99, "Canon"),
    //        new Groceries("Oranges", 0.99, "2024-02-20"),
    //        new Clothing("Hat 1", 12.99, "One Size", "Green"),
    //        new Electronics("Bluetooth Speaker 1", 79.99, "JBL"),
    //        new Groceries("Cereal", 3.49, "2024-02-22"),
    //        new Clothing("Socks 1", 4.99, "One Size", "Black"),
    //        new Electronics("Headphones 1", 149.99, "Sony"),
    //        new Groceries("Tomatoes", 1.79, "2024-02-25"),
    //        new Clothing("Gloves 1", 7.99, "Medium", "Brown"),
    //        new Electronics("Gaming Console 1", 399.99, "Microsoft"),
    //        new Groceries("Potatoes", 1.49, "2024-02-28"),
    //        new Clothing("Scarf 1", 12.99, "One Size", "Blue"),
    //        new Electronics("Smartphone 2", 899.99, "Samsung"),
    //        new Groceries("Carrots", 1.29, "2024-03-02"),
    //        new Clothing("T-shirt 2", 17.99, "Large", "White"),
    //        new Electronics("Smart TV 1", 899.99, "LG"),
    //        new Groceries("Onions", 0.79, "2024-03-05"),
    //        new Clothing("Dress 2", 44.99, "Medium", "Purple"),
    //        new Electronics("Wireless Mouse 1", 24.99, "Logitech"),
    //        new Groceries("Bell Peppers", 1.99, "2024-03-08"),
    //        new Clothing("Jeans 2", 45.99, "Medium", "Black"),
    //        new Electronics("E-book Reader 1", 119.99, "Amazon"),
    //        new Groceries("Cucumbers", 0.99, "2024-03-10"),
    //        new Clothing("Shoes 2", 69.99, "9", "Brown"),
    //        // Add more hardcoded Electronics products as needed
    //    };
    //        }
    //    }

    //    private static bool ValidateInfo(ConnectionStringParser csp)
    //    {
    //        if (csp.Server != "CramberryFarms")
    //        {
    //            Console.WriteLine("Unrecognized Database Name");
    //            return false;
    //        }


    //        if (csp.Database != "training" && csp.Database != "main")
    //        {
    //            Console.WriteLine("Unrecognized Server Name");
    //            return false;
    //        }


    //        if (csp.Uid != "Admin")
    //        {
    //            Console.WriteLine("Unrecognized Admin Name");
    //            return false;
    //        }


    //        if (csp.Password != "1234")
    //        {
    //            Console.WriteLine("Unrecognized Password");
    //            return false;
    //        }

    //        return true;
    //    }

    //    public static bool IsConnected()
    //    {
    //        return !(_instance == null);
    //    }

    //    public List<Product> Data()
    //    {
    //        return tempData;
    //    }

    //    private class ConnectionStringParser
    //    {
    //        public string Driver { get; set; }
    //        public string Server { get; set; }
    //        public string Database { get; set; }
    //        public string Uid { get; set; }
    //        public string Password { get; set; }

    //        public ConnectionStringParser(string connectionString)
    //        {
    //            string[] parts = connectionString.Split(';');
    //            foreach (var part in parts)
    //            {
    //                var keyValue = part.Split('=');
    //                if (keyValue.Length == 2)
    //                {
    //                    var key = keyValue[0].Trim();
    //                    var value = keyValue[1].Trim();
    //                    switch (key.ToLower())
    //                    {
    //                        case "driver":
    //                            Driver = value;
    //                            break;
    //                        case "server":
    //                            Server = value;
    //                            break;
    //                        case "database":
    //                            Database = value;
    //                            break;
    //                        case "uid":
    //                            Uid = value;
    //                            break;
    //                        case "pwd":
    //                            Password = value;
    //                            break;
    //                    }
    //                }
    //            }
    //        }

    //        public void DisplayInfo()
    //        {
    //            Console.WriteLine($"Driver: {Driver}");
    //            Console.WriteLine($"Database: {Database}");
    //            Console.WriteLine($"Server: {Server}");
    //            Console.WriteLine($"Uid: {Uid}");
    //            Console.WriteLine($"Password: {Password}");
    //        }

    //        public bool IsValid()
    //        {
    //            return !string.IsNullOrWhiteSpace(Driver)
    //                && !string.IsNullOrWhiteSpace(Server)
    //                && !string.IsNullOrWhiteSpace(Database)
    //                && !string.IsNullOrWhiteSpace(Uid)
    //                && !string.IsNullOrWhiteSpace(Password);
    //        }
    //    }


    //} // class Database
    #endregion

} // namespace
