namespace SmartaHemmet.Appliances;

using Interface;
public class RobotVaccum(string brand, string room, float batteryLevel) : Appliance(brand, room), ISchedulable
{
    public DateTime NextRun { get; set; }
    public float BatteryLevel { get; set; }
        
    public override string GetInfo()
    {
        return $"your {Brand} vaccum is currently in {room} room and currently is at {batteryLevel * 100}%";
    }

    public override void TurnOn()
    {
        IsOn = true;
        Console.WriteLine($"{Brand} vaccum is now currently cleaning in {Room}");
    }

    public override void TurnOff()
    {
        IsOn = false;
        Console.WriteLine($"{Brand} vaccum is now turned off. Please move it to a charging station from {Room}");
    }

    public override double GetDailyEnergyUsage()
    {
        return 0.4;
    }
    
    public void Schedule(DateTime time)
    {
        NextRun = time;
        Console.WriteLine($"Vaccum is sheduled at {time}");
    }

}