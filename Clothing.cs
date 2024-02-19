using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_OOP_Midterm_Part1_MatthewVargas
{
    public class Clothing : Product
    {
        public string Size { get; set; }
        public string Color { get; set; }

        public Clothing(string name, double price, string size, string color) : base(name, price)
        {
            Color = color;
            Size = size;
        }

        public override void DisplayProductInfo()
        {
            Console.WriteLine($"Clothing Item: {Name}, Color: {Color}, Size: {Size}, Price: ${Price}");
        }
    }
}
