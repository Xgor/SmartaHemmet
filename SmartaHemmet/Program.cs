using System;
using System.Collections.Generic;
using SmartaHemmet.Appliances;

class Program
{
    
    static void Main()
    {
        List<Appliance> devices = new List<Appliance>();
        // Skapa minst fyra objekt:
        // Washer, Refrigerator, Oven och RobotVacuum.
        // Lägg till dem i listan devices.
        devices.Add(new Washer("Cylinda","Bathroom",18));
        devices.Add(new Refrigerator("Electrolux","Kitchen",2));
        devices.Add(new Oven("Elon","Kitchen",300));
        devices.Add(new RobotVaccum("Tesla","Bedroom",0.67f));
        devices.Add(new CoffeeMachine("Nespresso","Living room",2));
        RunMorningRoutine(devices);
        ReportAllEnergy(devices);
    }
    static void RunMorningRoutine(List<Appliance> devices)
    {
        foreach (Appliance device in devices)
        {
            device.TurnOn();
            device.TurnOff();
        }
    }
    
    static void ReportAllEnergy(List<Appliance> devices)
    {
        foreach (Appliance device in devices)
        {
            Console.WriteLine($"{device.Brand} {device.GetType()} uses {device.GetDailyEnergyUsage()} kWh per use");
        }
    }
}