using System;

public class Program
{
    public static void Main()
    {
        Cake cake = new Cake();

        try
        {
            Console.WriteLine("Enter the flavour");
            cake.Flavour = Console.ReadLine().Trim();

            Console.WriteLine("Enter the quantity in kg");
            cake.QuantityInKg = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the price per kg");
            cake.PricePerKg = Convert.ToDouble(Console.ReadLine());

            if (cake.CakeOrder())
            {
                Console.WriteLine("Cake order was successful");
                Console.WriteLine("Price after discount is " + cake.CalculatePrice());
            }
        }
        catch (InvalidFlavourException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}