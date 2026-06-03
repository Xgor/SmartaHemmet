using System;
using System.Collections.Generic;
using SmartaHemmet.Appliances;

class Program
{
    static void Main()
    {
        List<object> devices = new List<object>();
        // Skapa minst fyra objekt:
        // Washer, Refrigerator, Oven och RobotVacuum.
        // Lägg till dem i listan devices.
        devices.Add(new Washer());
        devices.Add(new Refrigerator());
        devices.Add(new Oven());
        devices.Add(new RobotVaccum());
        devices.Add(new CoffeeMachine());
        
        RunMorningRoutine(devices);
        Console.WriteLine();
        ReportAllEnergy(devices);
    }
    static void RunMorningRoutine(List<object> devices)
    {
        foreach (object device in devices)
        {
            if (device is Washer washer)
            {
                washer.StartWash();
                washer.StopWash();
            }
            else if (device is Refrigerator refrigerator)
            {
                refrigerator.StartCooling();
                refrigerator.StopCooling();
            }
            else if (device is Oven oven)
            {
                oven.StartHeating();
                oven.StopHeating();
            }
            else if (device is RobotVaccum vaccum)
            {
                vaccum.StartCleaning();
                vaccum.StopCleaning();
            }
            else if (device is CoffeeMachine coffeeMachine)
            {
                coffeeMachine.StartBrewing();
                coffeeMachine.StopBrewing();
            }
        }
    }
    static void ReportAllEnergy(List<object> devices)
    {
        foreach (object device in devices)
        {
            if (device is Washer washer)
            {
                washer.PrintWashEnergy();
            }
            else if (device is Refrigerator refrigerator)
            {
                refrigerator.PrintCoolingEnergy();
            }
            else if (device is Oven oven)
            {
                oven.PrintHeatingEnergy();
            }
            else if (device is RobotVaccum vaccum)
            {
                vaccum.PrintCleaningEnergy();
            }
            else if (device is CoffeeMachine coffeeMachine)
            {
                coffeeMachine.PrintBrewingEnergy();
            }
        }
    }
}