namespace SmartaHemmet.Appliances;

public class GamingConsole(string brand, string room) : Appliance(brand, room)
{
    
    public override string GetInfo()
    {
        return $"{Brand} console in {room}!";
    }

    public override void TurnOn()
    {
        IsOn = true;
        Console.WriteLine($"{Brand} On!");
    }

    public override void TurnOff()
    {
        IsOn = false;
        Console.WriteLine($"{Brand} Off!");
    }

    public override double GetDailyEnergyUsage()
    {
        return 13.37;
    }

}