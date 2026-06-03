namespace SmartaHemmet.Appliances;

public class Appliance(string brand, string room)
{
    public string Brand { get; } = brand;
    public string Room { get; } = room;
    public bool IsOn { get; protected set; } = false;

    public virtual string GetInfo()
    {
        // Returnera en generell text om apparaten.
        // Exempel: "LG in Laundry room"
        return $"{Brand} in {Room} room";
        
    }
    public virtual void TurnOn()
    {

        // Sätt IsOn till true.
        // Skriv ut ett generellt startmeddelande.
	    IsOn = true;
	    Console.WriteLine($"Turned on {GetInfo()}");
    }

    public virtual void TurnOff()
    {
        // Sätt IsOn till false.
        // Skriv ut ett generellt stoppmeddelande.
        IsOn = false;
        Console.WriteLine($"Turned off {GetInfo()}");
    }
    public virtual double GetDailyEnergyUsage()
    {
        // Returnera 0 som standardvärde.
        return 0; 
    }
}
