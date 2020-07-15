using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product
{
    class product
    {
        static void Main(string[] args)
        {
             internal int productId;
        internal string brand;
        internal string model;
        internal double price;
        internal string description;

        internal void Display()
        {
            Console.WriteLine("ID:" + productId + " " + brand + "-" + model + " Rs." + price + " " + description);
        }


        internal Product()
        {
            Console.WriteLine("Empty Object Initialization");
        }


        internal Product(int productId, string brand, string model, double price, string description)
        {
            Console.WriteLine("Object Initialized");
            this.productId = productId;
            this.brand = brand;
            this.model = model;
            this.description = description;
            this.price = price;
        } 
    }
}
