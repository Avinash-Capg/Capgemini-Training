using System;
using InterfaceDemoProject;

class Program
{
    static void Main()
    {
        Console.WriteLine("Demo on Interfaces");

        Product pObj1 = new Product()
        {
            ProdID = 102,
            Name = "Luxor Marker",
            Price = 25
        };

        Console.WriteLine("Product ID   : " + pObj1.ProdID);
        Console.WriteLine("Product Name : " + pObj1.Name);
        Console.WriteLine("Price        : " + pObj1.Price);
    }
}