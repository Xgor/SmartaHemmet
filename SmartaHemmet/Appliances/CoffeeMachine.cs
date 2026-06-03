namespace SmartaHemmet.Appliances;

public class CoffeeMachine
{
    public string Brand { get; set; }
    public int CupsPerBrew { get; set; }

    public void StartBrewing()
    {
        Console.WriteLine("Started brewing");
    }

    public void StopBrewing()
    {
        Console.WriteLine("Stopped brewing");
    }

    public void PrintBrewingEnergy()
    {
        Console.WriteLine("Uses 44.1 kWh per brewing");
    }
}
// när jag la till CoffeeMachine i koden behövde jag ändra på 3 ställen.
// Skapa upp den, caste den båda gångerna sen kolla med sätta på och av båda
// tog 30 rader kod= 22 rader för klass + 9 i program