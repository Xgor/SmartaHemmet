namespace SmartaHemmet.Appliances;

public class PizzaOven(string brand, string room, int maxTemerature) : Oven(brand, room, maxTemerature)
{
    public new void TurnOn()
    {
        Console.WriteLine("pizzaoven turn on");
    }
}