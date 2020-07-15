using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1session2
{
    class program2
    {
        int x = 100;


        Product product1; 
        product1 = new Product();

        //assigning values to attributes
        product1.productId = 1001;
            product1.price = 78000;
            product1.brand = "iphone";
            product1.description = "available in all colors";
            product1.model = "X";

          
            product1.Display();

           
            Product product2 = new Product(1002, "iphone", "8", 55000, "available in black and blue colors only");
        product2.Display();

            product1 = new Product();
        product1.Display();


        }
}
