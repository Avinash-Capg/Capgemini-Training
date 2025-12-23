using System;

public class Cake
{
    public string Flavour { get; set; }
    public int QuantityInKg { get; set; }
    public double PricePerKg { get; set; }

    public bool CakeOrder()
    {
        if (Flavour != "Chocolate" && Flavour != "Red Velvet" && Flavour != "Vanilla")
        {
            throw new InvalidFlavourException(
                "Flavour not available. Please select the available flavour");
        }

        if (QuantityInKg <= 0)
        {
            throw new Exception("Quantity must be greater than zero");
        }

        return true;
    }

    public double CalculatePrice()
    {
        double discount = 0;

        if (Flavour == "Vanilla")
            discount = 3;
        else if (Flavour == "Chocolate")
            discount = 5;
        else if (Flavour == "Red Velvet")
            discount = 10;

        double totalPrice = QuantityInKg * PricePerKg;
        double discountedPrice = totalPrice - (totalPrice * discount / 100);

        return discountedPrice;
    }
}