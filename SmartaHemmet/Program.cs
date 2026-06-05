using System;
using System.Collections.Generic;
using SmartaHemmet.Appliances;
using SmartaHemmet.Appliances.Interface;
using SmartaHemmet.Controllers;
SmartHomeController controller = new SmartHomeController();
controller.AddDevice(new Washer("Cylinda","Bathroom",18));
controller.AddDevice(new Refrigerator("Electrolux","Kitchen",2));
controller.AddDevice(new Oven("Elon","Kitchen",300));
controller.AddDevice(new RobotVaccum("Tesla","Bedroom",0.67f));
controller.AddDevice(new CoffeeMachine("Nespresso","Living room",2));
controller.AddDevice(new GamingConsole("Xbox", "Living room"));
controller.PrintStatusReport();
Console.WriteLine();
controller.TurnOnAll();
Console.WriteLine();
double totalEnergy = controller.GetTotalDailyEnergyUsage();
Console.WriteLine($"Total daily energy usage: {totalEnergy} kWh");
Console.WriteLine();
controller.ScheduleAllSchedulableDevices(DateTime.Now.AddHours(2));
Console.WriteLine();
controller.TurnOffAll();
Console.WriteLine();
// Part 11
SmartLamp lamp1 = new SmartLamp("IKEA", "Hallway", 80);
Appliance lamp2 = lamp1;
lamp1.TurnOn();
lamp2.TurnOn();
// Part 13
List<ISchedulable> schedulableDevices = controller.GetSchedulableDevices();
foreach (ISchedulable schedulable in schedulableDevices)
{
// Skriv ut NextRun eller schemalägg apparaten.
    Console.WriteLine($"next run for {schedulable.GetType()} is in {schedulable.NextRun}");
}
// Part 14
Appliance? foundDevice = controller.FindDeviceByBrand("Nespresso");
if (foundDevice != null)
{
    foundDevice.TurnOn();
    if(foundDevice is ISchedulable schedulable)
        schedulable.Schedule(DateTime.Now.AddHours(1));
}