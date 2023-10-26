namespace AbstractFactory;

public class ModernSofa : ISofa
{
    public void HasLegs()
    {
        Console.WriteLine("Modern Sofa ");

    }

    public void SitOn()
    {
        Console.WriteLine("Sitting on Modern Sofa ");
    }
}