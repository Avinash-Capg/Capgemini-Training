using System;
public class Desktop : Computer
{   
    public int MonitorSize {get; set;}
    public int PowerSuppyVolt{get; set;}
    public double DesktopPriceCalculation()
    {
        double ProcessorCost = 0;

        if(Processor == "i3") ProcessorCost = 1500;
        else if (Processor == "i5") ProcessorCost = 3000;
        else if (Processor == "i7") processorCost = 4500;

        double price = 
        ProcessorCost + (RamSize * 200) + (HardDiskSize * 1500) + (GraphicCard * 2500) + (MonitorSize * 250) + (PowerSuppyVolt * 20);
        return price;
    }
}