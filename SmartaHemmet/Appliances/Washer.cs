namespace SmartaHemmet.Appliances;

public class Washer(string brand, string room, float capacityKg) : Appliance(brand, room)
{
    public float CapacityKg { get; set; } = capacityKg;

    public override string GetInfo()
    {
        return $"{Brand} washer in {room} can carry up to {CapacityKg}kg";
    }

    public override void TurnOn()
    {
        IsOn = true;
        Console.WriteLine($"{Brand} washer is turned on, please close it to start washing");
    }

    public override void TurnOff()
    {
        IsOn = false;
        Console.WriteLine($"{Brand} washer is turned off, please remove all clothing");
    }

    public override double GetDailyEnergyUsage()
    {
        return 1.2;
    }
   
}