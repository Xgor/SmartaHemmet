namespace SmartaHemmet.Appliances;

public class Washer
{
    
    public string Brand { get; set; }
    public float CapacityKG { get; set; }

    public void StartWash()
    {
        Console.WriteLine("Wash turned on");
    }

    public void StopWash()
    {
        Console.WriteLine("Wash tuned off");
    }

    public void PrintWashEnergy()
    {
        Console.WriteLine("uses 1 kw energy"); 
    }
    
}