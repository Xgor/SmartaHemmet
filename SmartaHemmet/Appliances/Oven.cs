namespace SmartaHemmet.Appliances;

public class Oven
{
    public string Brand { get; set; }
    public float CapacityKG { get; set; }
     
    public void StartHeating()
    {
        Console.WriteLine("Started Heating");
    }

    public void StopHeating()
    {
        Console.WriteLine("Stopped heating");
    }

    public void PrintHeatingEnergy()
    {
        Console.WriteLine("heating used 4 kw");
    }

}