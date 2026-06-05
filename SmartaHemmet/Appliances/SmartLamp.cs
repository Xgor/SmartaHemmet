namespace SmartaHemmet.Appliances;

public class SmartLamp : Appliance
{
    public int Brightness { get; set; }
    public SmartLamp(string brand, string room, int brightness)
        : base(brand, room)
    {
        Brightness = brightness;
    }
    public new void TurnOn()
    {
// Skriv ut att lampan tänds.
        Console.WriteLine("Lampan sätts på");
    }
}