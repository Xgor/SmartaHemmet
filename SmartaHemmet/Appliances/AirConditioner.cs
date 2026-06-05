using SmartaHemmet.Appliances.Interface;

namespace SmartaHemmet.Appliances;

public class AirConditioner(string brand, string room, int targetTemperature) : Appliance(brand, room), ISchedulable
{
    public int TargetTemperature { get; set; }
    
    public DateTime NextRun { get; set; }

    public override string GetInfo()
    {
        return $"{Brand} Air Conditioner is in {room} and is target {TargetTemperature} degrees";
    }

    public override void TurnOn()
    {
        IsOn = true;
        Console.WriteLine($"{Brand} AC is now on and target {TargetTemperature} degrees");
    }

    public override void TurnOff()
    {
        IsOn = false;
        Console.WriteLine($"{Brand} AC has been turned off");
    }

    public override double GetDailyEnergyUsage()
    {
        return 3.75*24;
    }

    public void Schedule(DateTime time)
    {
        NextRun = time;
        Console.WriteLine($"{Brand} AC is sheduled at {time}");
    }
}