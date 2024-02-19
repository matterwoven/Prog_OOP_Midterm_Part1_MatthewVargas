using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Prog_OOP_Midterm_Part1_MatthewVargas
{
    public class Groceries : Product
    {
        public string ExpiryDate { get; set; }

        public Groceries(string name, double price, string expiryDate) : base(name, price)
        {
            ExpiryDate = expiryDate;
        }

        public override void DisplayProductInfo()
        {
            Console.WriteLine($"Grocery Item: {Name}, Expiry Date: {ExpiryDate}, Price: ${Price}");

        }
    }
}
