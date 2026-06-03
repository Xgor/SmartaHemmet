namespace SmartaHemmet.Appliances;

public class RobotVaccum
{
    public string Brand { get; set; }
    public float CapacityKG { get; set; }
         
    public void StartCleaning()
    {
        Console.WriteLine("start cleaing");
    }

    public void StopCleaning()
    {
        Console.WriteLine("Stopped cleaning");
    }

    public void PrintCleaningEnergy()
    {
        Console.WriteLine("cleaning uses 4kw");
    }

}