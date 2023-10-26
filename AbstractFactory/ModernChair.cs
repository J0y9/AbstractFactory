namespace AbstractFactory;

public class ModernChair : IChair
{
    public void HasLegs()
    {
        Console.WriteLine("Modern Chair ");
    }

    public void SitOn()
    {
        Console.WriteLine("Sitting on Modern Chair ");

    }
}