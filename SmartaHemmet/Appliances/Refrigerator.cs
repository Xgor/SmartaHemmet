namespace SmartaHemmet.Appliances;

public class Refrigerator(string brand, string room, float temprature) : Appliance(brand, room)
{

    public float Temprature { get; set; } = temprature;
   
    public override string GetInfo()
    {
        return $"{Room} {Brand} refigerator is at {Temprature} degrees.";
    }

    public override void TurnOn()
    {
        IsOn = true;
        Console.WriteLine($"{Brand} refrigerator will now start cooling");
    }

    public override void TurnOff()
    {
        IsOn = false;
        Console.WriteLine($"{Brand} refrigerator is turned of. please remove everything from it.");
    }

    public override double GetDailyEnergyUsage()
    {
        return 3.6;
    }
}