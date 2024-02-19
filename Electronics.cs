using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Prog_OOP_Midterm_Part1_MatthewVargas
{
    public class Electronics : Product
    {
        public string Brand { get; set; }

        public Electronics(string name, double price, string brand) : base(name, price)
        {
            Brand = brand;
        }

        public override void DisplayProductInfo()
        {
            Console.WriteLine($"Technology: {Name}, Brand: {Brand}, Price: ${Price}");

        }
    }
}
