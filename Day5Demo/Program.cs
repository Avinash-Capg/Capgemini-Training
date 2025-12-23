using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("1. Desktop");
        Console.WriteLine("2. Laptop");
        Console.Write("Choose the option: ");

        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            Desktop dObj = new Desktop();
            Console.Write("Enter Processor (i3/i5/i7): ");
            dObj.Processor = Console.ReadLine();
            Console.Write("Enter RAM Size (GB): ");
            dObj.RamSize = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Hard Disk Size (TB): ");
            dObj.HardDiskSize = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Graphic Card Size (GB): ");
            dObj.GraphicCard = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Monitor Size (inches): ");
            dObj.MonitorSize = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Power Supply Volt: ");
            dObj.PowerSuppyVolt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Desktop Price is: " + dObj.DesktopPriceCalculation());
        }
        else if (choice == 2)
        {
            Laptop lObj = new Laptop();
            Console.Write("Enter Processor (i3/i5/i7): ");
            lObj.Processor = Console.ReadLine();
            Console.Write("Enter RAM Size (GB): ");
            lObj.RamSize = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Hard Disk Size (TB): ");
            lObj.HardDiskSize = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Graphic Card Size (GB): ");
            lObj.GraphicCard = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Display Size (inches): ");
            lObj.DisplaySize = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Battery Volt: ");
            lObj.BatteryVolt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Laptop Price is: " + lObj.LaptopPriceCalculation());
        }
        else
        {
            Console.WriteLine("Invalid Choice");
        }
    }
}