namespace SmartaHemmet.Appliances;

public class Refrigerator
{
    
    public string Brand { get; set; }
    public float CapacityKG { get; set; }
    
    public void StartCooling()
    {
        Console.WriteLine("turned cooling on");
    }

    public void StopCooling()
    {
        Console.WriteLine("turned cooling off");
    }

    public void PrintCoolingEnergy()
    {
        Console.WriteLine("using 2 kw energy");
    }

}