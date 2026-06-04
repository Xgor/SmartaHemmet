using SmartaHemmet.Appliances.Interface;

namespace SmartaHemmet.Controllers;

using Appliances;
public class SmartHomeController
{
    private List<Appliance> _devices = new List<Appliance>();
    public void AddDevice(Appliance device)
    {
        _devices.Add(device);
    }
    public void TurnOnAll()
    {
        // Loopa igenom alla devices och starta dem.
        // Du får inte använda if/switch på specifika klasser.
        _devices.ForEach(d => d.TurnOn());
    }
    public void TurnOffAll()
    {
        // Loopa igenom alla devices och stäng av dem.
        _devices.ForEach(d => d.TurnOff());
    }
    public void PrintStatusReport()
    {
        // Loopa igenom alla devices.
        // Skriv ut GetInfo() och om apparaten är på eller av.
        _devices.ForEach(d => Console.WriteLine($"{d.GetInfo()} is currently {d.IsOn : 'On' ? 'Off'}"));
    }
    public double GetTotalDailyEnergyUsage()
    {
        // Räkna ihop GetDailyEnergyUsage() för alla devices.
        // Returnera totalsumman.
        return _devices.Sum(d => d.GetDailyEnergyUsage());
    }

    // Kan inte använda devices 
    public void ScheduleAllSchedulableDevices(DateTime time)
    {
        foreach (Appliance device in _devices)
        {
            // 1. Kontrollera om device implementerar ISchedulable.
            // 2. Casta device till ISchedulable.
            // 3. Anropa Schedule(time).
            if (device is ISchedulable sheduable)
            {
                sheduable.Schedule(time);
            }
            
        }
    }

}

