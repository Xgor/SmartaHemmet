namespace SmartaHemmet.Appliances;

public class Oven(string brand, string room, int maxTemperature) : Appliance(brand, room)
{
    public int MaxTemperature { get; set; } = maxTemperature;

    public override string GetInfo()
    {
        return $"{Brand} oven in {Room} room can get up to {MaxTemperature} degrees"; //Kanske ha något om celcius eller farenheigt
    }

    public sealed override void TurnOn()
    {
        IsOn = true;
        Console.WriteLine($"{Brand} oven starts preheating");
    }

    public override void TurnOff()
    {
        IsOn = false;
        Console.WriteLine($"{Brand} oven stopped heat");
    }

    public override double GetDailyEnergyUsage()
    {
        return 2.5;
    }
    
}