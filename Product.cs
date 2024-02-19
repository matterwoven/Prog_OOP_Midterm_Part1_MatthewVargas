using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Prog_OOP_Midterm_Part1_MatthewVargas
{
    public abstract class Product
    {
        protected Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public double Price { get; set; }
        public abstract void DisplayProductInfo();
    }



}
