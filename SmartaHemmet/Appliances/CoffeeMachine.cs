namespace SmartaHemmet.Appliances;

using Interface;
public class CoffeeMachine(string brand, string room, int cupsPerBrew) : Appliance(brand, room), ISchedulable
{
    public int CupsPerBrew { get; set; } = cupsPerBrew;
    public DateTime NextRun { get; set; }

    public override string GetInfo()
    {
        return $"{Brand} coffee brewer in {room} can brew up to {CupsPerBrew} cups per brew!";
    }

    public override void TurnOn()
    {
        IsOn = true;
        Console.WriteLine($"{Brand} coffeeMachine is turned on and ready for brewing");
    }

    public override void TurnOff()
    {
        IsOn = false;
        Console.WriteLine($"{Brand} coffeeMachine will stop boiling now");
    }

    public override double GetDailyEnergyUsage()
    {
        return 0.3;
    }

    public void Schedule(DateTime time)
    {
        NextRun = time;
        Console.WriteLine($"CofeeMachine {Brand} is sheduled at {time}");
    }
}
// när jag la till CoffeeMachine i koden behövde jag ändra på 3 ställen.
// Skapa upp den, caste den båda gångerna sen kolla med sätta på och av båda
// tog 30 rader kod= 22 rader för klass + 9 i program